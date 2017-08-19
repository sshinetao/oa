using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.HY
{
    public partial class SellOrder_show : System.Web.UI.Page
    {
        Db List = new Db();
        public static string Gusername, Grealname, Gname;
        private void Page_Load(object sender, System.EventArgs e)
        {
            if (!IsPostBack)
            {
                string SQL_GetList = "select * from SellOrder_pt  where id='" + int.Parse(Request.QueryString["id"]) + "'";
                OleDbDataReader NewReader = List.GetList(SQL_GetList);
                if (NewReader.Read())
                {
                    number.Text = NewReader["number"].ToString();

                    ShTime.Text = NewReader["ShTime"].ToString();

                    CompanyNumber.Text = NewReader["CompanyNumber"].ToString();
                    CompanyName.Text = NewReader["CompanyName"].ToString();
                    CompanyAdd.Text = NewReader["CompanyAdd"].ToString();


                    Tel.Text = NewReader["Tel"].ToString();
                    StockPeoNum.Text = NewReader["StockPeoNum"].ToString();
                    StockPeoName.Text = NewReader["StockPeoName"].ToString();

                    Discount.Text = NewReader["Discount"].ToString();
                    Remark.Text = NewReader["Remark"].ToString();




                    AllMoney.Text = NewReader["AllMoney"].ToString();




                    StreamNumber.Text = NewReader["StreamNumber"].ToString();


                }

            }


            string SQL_money_ = " SELECT SUM(ALLMoney) AS " + "sum" + " from SellOrderMx  where Keyfile='" + number.Text + "'";
            OleDbDataReader NewReader_money = List.GetList(SQL_money_);
            if (NewReader_money.Read())
            {
                try
                {
                    this.AllMoney.Text = null;
                    this.AllMoney.Text += NewReader_money.GetDecimal(0);

                }
                catch
                {
                    this.AllMoney.Text = null;
                    this.AllMoney.Text += "0";

                }
                NewReader_money.Close();
            }//得到产品消费成本价

            string SQL_GetList_xs = "select * from SellOrderMx where  Keyfile='" + number.Text + "'  order by id desc";
            Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
            Datagrid2.DataBind();
        }

        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }

        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("SellOrderlist.aspx");
        }

        protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SellOrderlist.aspx");
        }
    }
}