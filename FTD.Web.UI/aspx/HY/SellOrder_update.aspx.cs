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
    public partial class SellOrder_update : System.Web.UI.Page
    {
        Db List = new Db();
        public static string Gusername, Grealname, Gname;
        private void Page_Load(object sender, System.EventArgs e)
        {


            if (!IsPostBack)
            {
                this.ImageButton5.Attributes.Add("onclick", "javascript:return del();");


                this.ImageButton3.Attributes.Add("onclick", "javascript:zjOpen();");
                this.ImageButton1.Attributes.Add("onclick", "javascript:return chknull();");

            }



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
            Response.Redirect("SellOrderList.aspx");
        }

        private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {

          
        }

        private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {

                string SQL_Del = "Delete from SellOrderMx where id='" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "'";

                List.ExeSql(SQL_Del);


                string SQL_GetList_xs = "select * from SellOrderMx where  Keyfile='" + number.Text + "' order by id desc";
                Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                Datagrid2.DataBind();


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
            catch
            {
                this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
            }
        }

        private void Datagrid2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {

                ImageButton4.Attributes.Add("onclick", "window.showModalDialog('SellOrder_insert_update.aspx?a='+Math.random()+'&id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "','window','dialogWidth:700px;DialogHeight=400px;status:no;help=no;scroll=no');window.location='#'");


            }
            catch
            {
                //this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton5_Click1(object sender, ImageClickEventArgs e)
        {
            try
            {

                string SQL_Del = "Delete from SellOrderMx where id='" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "'";

                List.ExeSql(SQL_Del);


                string SQL_GetList_xs = "select * from SellOrderMx where  Keyfile='" + number.Text + "' order by id desc";
                Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                Datagrid2.DataBind();


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
            catch
            {
                this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
            }
        }

        protected void ImageButton1_Click2(object sender, ImageClickEventArgs e)
        {
            Gusername = "完成审核";
            Grealname = "完成审核";
            Gname = "完成审核";
        
            


                string sql_insert_xtrz = "insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('修改[销售订单]','销售订单','" + this.Session["username"] + "','" + this.Session["TrueName"] + "','" + System.DateTime.Now.ToString() + "')";
                List.ExeSql(sql_insert_xtrz);


                string sql_insert1 = "insert into SellOrderlog_lc values('" + this.Session["TrueName"] + "修改了销售订单[" + this.Session["TrueName"] + "的普通客户订单]','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                List.ExeSql(sql_insert1);


                string Sql_update = "Update SellOrder_pt Set Ifopen='是',number='" + number.Text + "',title='" + this.Session["TrueName"] + "的普通客户订单" + "',Type='合同',InvoiceType='" + "普通发票" + "',InvoiceNum='00',QdTime='" + DateTime.Now.ToString() + "',OrderAdd='0',LxAdd='0',Storeroom='0',ShTime='" + ShTime.Text + "',CompanyNumber='" + CompanyNumber.Text + "',CompanyName='" + CompanyName.Text + "',CompanyAdd='" + CompanyAdd.Text + "',BankNumber='0',TaxNumber='0',Bank='0',Tel='" + Tel.Text + "',LxPeople='0',DlPeople='0',Unit='0',StockPeoNum='" + StockPeoNum.Text + "',StockPeoName='" + StockPeoName.Text + "',YxStarttime='" + DateTime.Now.ToString() + "',YxEndtime='" + DateTime.Now.ToString() + "',DisMoney=" + AllMoney.Text + "*" + Discount.Text + ",AllMoney='" + AllMoney.Text + "',Remark='" + Remark.Text + "',MyTimes='" + this.Session["MyTimes"] + "',StreamNumber='" + StreamNumber.Text + "',StreamName='0',Gusername='" + Gusername + "',Grealname='" + Grealname + "',Gname='" + Gname + "',Username='" + this.Session["Username"] + "',Realname='" + this.Session["TrueName"] + "',State='完成审核' where id='" + int.Parse(Request.QueryString["id"]) + "'";

                List.ExeSql(Sql_update);



                this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='SellOrder.aspx'</script>");

          

        }

        protected void ImageButton2_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SellOrderlist.aspx");
        }
    }
}