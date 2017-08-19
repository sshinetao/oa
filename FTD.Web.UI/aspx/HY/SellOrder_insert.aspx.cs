using FTD.BLL;
using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.HY
{
    public partial class SellOrder_insert : System.Web.UI.Page
    {
        Db List = new Db();
        public static string Gusername, Grealname, Gname;
        protected void Page_Load(object sender, EventArgs e)
        {

            //编号生成
            if (!IsPostBack)
            {

                Random g = new Random();
                string rad = g.Next(10000).ToString();

                number.Text = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + "" + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + "" + System.DateTime.Now.Millisecond.ToString() + "" + rad + "";



                StockPeoName.Text = Session["TrueName"].ToString();
                StockPeoNum.Text = Session["UserName"].ToString();

                rname.Text = this.Session["TrueName"].ToString();
                uname.Text = this.Session["UserName"].ToString();

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

          
        }

        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }
        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("SellOrderList.aspx");
        }

        private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            

        }

        private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {
                SellOrderMx bll_sellorderMx = new SellOrderMx();
                int smxid = Utils.GetInt(Datagrid2.SelectedItem.Cells[1].Text, 0);
                bll_sellorderMx.Delete(smxid);

                DataSet ds = bll_sellorderMx.GetList("Keyfile='" + number.Text + "'");
                if(ds !=null)
                {
                    Datagrid2.DataSource = ds.Tables[0];
                    Datagrid2.DataBind();

                }
                


                

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
            }
        }

     

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {

            Grealname = "完成审核";
            Gname = "完成审核";
            string strCompany = "no number";
            if(string.IsNullOrEmpty(strCompany))
            {
                this.Response.Write("<script language=javascript>alert('请填写客户名称！')</script>");
                return;
            }

            string _username = this.Session["username"].ToString();
            string _realname = this.Session["TrueName"].ToString();

            SystemLog bll_systemLog = new SystemLog();
            bll_systemLog.Name = "新增[销售订单明细]";
            bll_systemLog.MkName = "销售订单";
            bll_systemLog.Username = _username;
            bll_systemLog.Realname = _realname;
            bll_systemLog.Nowtimes = System.DateTime.Now;
            bll_systemLog.Add();
            SellOrderlog_lc bll_sellorderlog_lc = new SellOrderlog_lc();
            bll_sellorderlog_lc.KeyField = number.Text;
            bll_sellorderlog_lc.settime = DateTime.Now;
            bll_sellorderlog_lc.title = this.Session["TrueName"] + "新增了销售订单[" + this.Session["TrueName"] + "的普通客户订单]'";
            bll_sellorderlog_lc.Add();
            SellOrder_pt bll_sellorder_pt = new SellOrder_pt();
            bll_sellorder_pt.title = this.Session["TrueName"] + "的普通客户订单" + "合同";
            bll_sellorder_pt.Type = "普通发票";
            bll_sellorder_pt.number = number.Text;
            bll_sellorder_pt.InvoiceType = "000";
            bll_sellorder_pt.QdTime = DateTime.Now;
            bll_sellorder_pt.OrderAdd = "0";
            bll_sellorder_pt.LxAdd = "0";
            bll_sellorder_pt.Storeroom = "0";
            bll_sellorder_pt.ShTime = ShTime.Text;
            bll_sellorder_pt.CompanyNumber = strCompany;
            bll_sellorder_pt.CompanyAdd = CompanyAdd.Text;
            bll_sellorder_pt.CompanyName = CompanyName.Text;
            bll_sellorder_pt.BankNumber = "0";
            bll_sellorder_pt.TaxNumber = "0";
            bll_sellorder_pt.Bank = "0";
            bll_sellorder_pt.Tel = Tel.Text;
            bll_sellorder_pt.LxPeople = "0";
            bll_sellorder_pt.DlPeople = "0";
            bll_sellorder_pt.Unit = "普通";
            bll_sellorder_pt.StockPeoNum = StockPeoNum.Text;
            bll_sellorder_pt.StockPeoName = StockPeoName.Text;
            bll_sellorder_pt.YxStarttime = DateTime.Now;
            bll_sellorder_pt.YxEndtime = DateTime.Now;
            bll_sellorder_pt.Discount = Utils.GetDecimal(Discount.Text, 0); ;
            bll_sellorder_pt.AllMoney = Utils.GetDecimal(AllMoney.Text, 0);
            bll_sellorder_pt.DisMoney = Utils.GetDecimal(Discount.Text, 0);
            bll_sellorder_pt.YjMoney = Utils.GetDecimal(AllMoney.Text, 0);
            bll_sellorder_pt.Remark = Remark.Text;
            bll_sellorder_pt.State = "完成审核";
            bll_sellorder_pt.Username = this.Session["username"].ToString();
            bll_sellorder_pt.Realname = this.Session["TrueName"].ToString();
            bll_sellorder_pt.Nowtimes = DateTime.Now;
            bll_sellorder_pt.StreamNumber = StreamNumber.Text;
            bll_sellorder_pt.StreamName = "销售订单";
            bll_sellorder_pt.Gusername = Grealname;
            bll_sellorder_pt.Gname = Gname;
            bll_sellorder_pt.MyTimes = DateTime.Now.ToString();// this.Session["MyTimes"].ToString();
            bll_sellorder_pt.Ifopen = "是";
            bll_sellorder_pt.Add();
            


                     //Response.Write(sql_insert);

            this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='SellOrderList.aspx'</script>");


        }
    }
}