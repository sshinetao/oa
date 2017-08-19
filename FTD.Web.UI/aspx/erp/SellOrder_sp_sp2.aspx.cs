using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class SellOrder_sp_sp2 : System.Web.UI.Page
    {
        Db List = new Db();
        BindDrowDownList list = new BindDrowDownList(); 
        public static string nbxx_num;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string SQL_GetList = "select * from SellOrder  where id='" + int.Parse(Request.QueryString["id"]) + "'";
                OleDbDataReader NewReader = List.GetList(SQL_GetList);
                if (NewReader.Read())
                {
                    number.Text = NewReader["number"].ToString();

                    title.Text = NewReader["title"].ToString();


                    Type.Text = NewReader["Type"].ToString();
                    InvoiceType.Text = NewReader["InvoiceType"].ToString();

                    InvoiceNum.Text = NewReader["InvoiceNum"].ToString();

                    QdTime.Text = NewReader["QdTime"].ToString();
                    OrderAdd.Text = NewReader["OrderAdd"].ToString();

                    LxAdd.Text = NewReader["LxAdd"].ToString();
                    Storeroom.Text = NewReader["Storeroom"].ToString();
                    ShTime.Text = NewReader["ShTime"].ToString();

                    CompanyNumber.Text = NewReader["CompanyNumber"].ToString();
                    CompanyName.Text = NewReader["CompanyName"].ToString();
                    CompanyAdd.Text = NewReader["CompanyAdd"].ToString();

                    BankNumber.Text = NewReader["BankNumber"].ToString();
                    TaxNumber.Text = NewReader["TaxNumber"].ToString();
                    Bank.Text = NewReader["Bank"].ToString();


                    Tel.Text = NewReader["Tel"].ToString();
                    LxPeople.Text = NewReader["LxPeople"].ToString();
                    DlPeople.Text = NewReader["DlPeople"].ToString();


                    Unit.Text = NewReader["Unit"].ToString();
                    StockPeoNum.Text = NewReader["StockPeoNum"].ToString();
                    StockPeoName.Text = NewReader["StockPeoName"].ToString();

                    YxStarttime.Text = NewReader["YxStarttime"].ToString();
                    YxEndtime.Text = NewReader["YxEndtime"].ToString();
                    Discount.Text = NewReader["Discount"].ToString();
                    Remark.Text = NewReader["Remark"].ToString();




                    AllMoney.Text = NewReader["AllMoney"].ToString();




                    StreamNumber.Text = NewReader["StreamNumber"].ToString();
                    StreamName.Text = NewReader["StreamName"].ToString();



                    username.Text = NewReader["username"].ToString();
                    realname.Text = NewReader["realname"].ToString();
                    Name.Text = NewReader["title"].ToString();
                    Gusername.Text = NewReader["Gusername"].ToString();
                    Grealname.Text = NewReader["Grealname"].ToString();
                    Gname.Text = NewReader["Gname"].ToString();
                    Sreakmart.Text = NewReader["Sreakmart"].ToString();


                }

            }


            //string SQL_money_ = " SELECT SUM(ALLMoney) AS " + "sum" + " from SellOrderMx  where Keyfile='" + number.Text + "'";
            //OleDbDataReader NewReader_money = List.GetList(SQL_money_);
            //if (NewReader_money.Read())
            //{
            //    try
            //    {
            //        this.AllMoney.Text = null;
            //        this.AllMoney.Text += NewReader_money.GetDecimal(0);

            //    }
            //    catch
            //    {
            //        this.AllMoney.Text = null;
            //        this.AllMoney.Text += "0";

            //    }
            //    NewReader_money.Close();
            //}//得到产品消费成本价

            string SQL_GetList_xs = "select * from SellOrderMx where  Keyfile='" + number.Text + "'  order by id desc";
            Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
            Datagrid2.DataBind();


            //驳回
            string sql_down_bh = "select top 1000 * from Xsdd_WorkStreamName where id<(select id from Xsdd_WorkStreamName where KeyFile='" + StreamNumber.Text + "' and Name_Jd='" + Gname.Text + "' and username='" + Gusername.Text + "') and KeyFile='" + StreamNumber.Text + "'";
            //string sql_down_bh="select * from WorkStreamName";		
            if (!IsPostBack)
            {
                list.Bind_DropDownList_bh(bhuser, sql_down_bh, "username", "Name_Jd");
            }

            if (Ifts.SelectedValue == "否")
            {
                Panel1.Visible = true;
            }
            else
            {
                Panel1.Visible = false;
            }

        }

        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }

        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("SellOrder_sp.aspx");
        }

        private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {



            if (Ifts.SelectedValue == "否")
            {
                if (bhuser.SelectedValue == "启始位置")
                {

                    string sql_insert1 = "insert into SellOrderlog_lc  values('" + this.Session["TrueName"] + "将采购入库[" + Name.Text + "]驳回给录入人','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                    List.ExeSql(sql_insert1);

                    string Sql_update = "Update SellOrder  Set Gname='驳回审核',Grealname='驳回审核',Gusername='驳回审核',State='驳回审核',Sreakmart='" + Sreakmart.Text + "'    where id='" + int.Parse(Request.QueryString["id"]) + "'";
                    List.ExeSql(Sql_update);


                }
                else
                {


                    string SQL_GetList = "select * from Xsdd_WorkStreamName  where  KeyFile='" + StreamNumber.Text + "' and Name_Jd='" + bhuser.SelectedItem.Text + "' and username='" + bhuser.SelectedValue + "'";
                    OleDbDataReader NewReader = List.GetList(SQL_GetList);
                    if (NewReader.Read())
                    {
                        string sql_insert1 = "insert into SellOrderlog_lc  values('" + this.Session["TrueName"] + "将采购入库[" + Name.Text + "]驳回到节点" + bhuser.SelectedItem.Text + "','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                        List.ExeSql(sql_insert1);

                        string Sql_update = "Update SellOrder  Set Gname='" + bhuser.SelectedItem.Text + "',Grealname='" + NewReader["realname"].ToString() + "',Gusername='" + bhuser.SelectedValue + "',Sreakmart='" + Sreakmart.Text + "'    where id='" + int.Parse(Request.QueryString["id"]) + "'";
                        List.ExeSql(Sql_update);


                        
                    }
                    else
                    {

                    }


                }


                string sql_insert = " insert into SellOrder_sp  (number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'驳回','" + Sreakmart.Text + "','" + this.Session["username"] + "','" + this.Session["TrueName"] + "',MyTimes from  SellOrder where  id='" + int.Parse(Request.QueryString["id"]) + "'";
                List.ExeSql(sql_insert);

                //this.Response.Write("<script language=javascript>alert('提交成功！\n拒绝审批');window.location.href='SellOrder_sp.aspx'</script>");
                this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'SellOrder_sp.aspx'</script>");


            }
            else
            {



                string SQL_GetList = "select top 1 * from Xsdd_WorkStreamName where id>(select id from Xsdd_WorkStreamName where KeyFile='" + StreamNumber.Text + "' and Name_Jd='" + Gname.Text + "' and username='" + Gusername.Text + "') and KeyFile='" + StreamNumber.Text + "' order by id asc";
                OleDbDataReader NewReader = List.GetList(SQL_GetList);
                if (NewReader.Read())
                {
                    string sql_insert1 = "insert into SellOrderlog_lc  values('" + this.Session["TrueName"] + "通过销售订单[" + Name.Text + "]的审批，节点状态为：" + NewReader["Name_Jd"].ToString() + "','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                    List.ExeSql(sql_insert1);

                    string Sql_update = "Update SellOrder  Set Gname='" + NewReader["Name_Jd"].ToString() + "',Grealname='" + NewReader["realname"].ToString() + "',Gusername='" + NewReader["username"].ToString() + "' ,Sreakmart='" + Sreakmart.Text + "',State='正在审核'   where id='" + int.Parse(Request.QueryString["id"]) + "'";
                    List.ExeSql(Sql_update);
                    
                    //Response.Write(SQL_GetList);

                    this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'SellOrder_sp.aspx'</script>");
                }
                else
                {

                    string sql_insert1 = "insert into SellOrderlog_lc  values('" + this.Session["TrueName"] + "通过采购入库[" + Name.Text + "]的审批，节点状态为：完成审核','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                    List.ExeSql(sql_insert1);



                    string Sql_update = "Update SellOrder  Set Gname='完成审核',Grealname='完成审核',Gusername='完成审核',State='完成审核',Sreakmart='" + Sreakmart.Text + "'    where id='" + int.Parse(Request.QueryString["id"]) + "'";
                    List.ExeSql(Sql_update);
                    Sql_update = @"INSERT INTO dbo.SellInMoney (number,title,Allmoney,JbName,Username,Realname,Gusername,Nowtimes,State,CompanyName,MyTimes)
                                      SELECT top 1  number,title,Allmoney,seller,Username,Realname,Username,Nowtimes,'等待审核',CompanyName,GETDATE() FROM dbo.SellOrder WHERE id={0}";
                    Sql_update = string.Format(Sql_update, int.Parse(Request.QueryString["id"]));
                    List.ExeSql(Sql_update);
                    string insert_xx = "insert into nbdxx values('销售订单[" + Name.Text + "]通过审批','销售订单[" + Name.Text + "]通过审批\n通过时间：" + System.DateTime.Now.ToString() + "','" + System.DateTime.Now.ToString() + "','" + username.Text + "','" + realname.Text + "','系统消息','系统消息','否','" + nbxx_num + "')";
                    List.ExeSql(insert_xx);



                }

                string sql_insert = " insert into SellOrder_sp  (number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'通过','" + Sreakmart.Text + "','" + this.Session["username"] + "','" + this.Session["TrueName"] + "',MyTimes from  SellOrder where  id='" + int.Parse(Request.QueryString["id"]) + "'";
                List.ExeSql(sql_insert);

                this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'SellOrder_sp.aspx'</script>");
            }

        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            if (Ifts.SelectedValue == "否")
            {
                if (bhuser.SelectedValue == "启始位置")
                {

                    string sql_insert1 = "insert into SellOrderlog_lc  values('" + this.Session["TrueName"] + "将采购入库[" + Name.Text + "]驳回给录入人','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                    List.ExeSql(sql_insert1);

                    string Sql_update = "Update SellOrder  Set Gname='驳回审核',Grealname='驳回审核',Gusername='驳回审核',State='驳回审核',Sreakmart='" + Sreakmart.Text + "'    where id='" + int.Parse(Request.QueryString["id"]) + "'";
                    List.ExeSql(Sql_update);


                }
                else
                {


                    string SQL_GetList = "select * from Xsdd_WorkStreamName  where  KeyFile='" + StreamNumber.Text + "' and Name_Jd='" + bhuser.SelectedItem.Text + "' and username='" + bhuser.SelectedValue + "'";
                    OleDbDataReader NewReader = List.GetList(SQL_GetList);
                    if (NewReader.Read())
                    {
                        string sql_insert1 = "insert into SellOrderlog_lc  values('" + this.Session["TrueName"] + "将采购入库[" + Name.Text + "]驳回到节点" + bhuser.SelectedItem.Text + "','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                        List.ExeSql(sql_insert1);

                        string Sql_update = "Update SellOrder  Set Gname='" + bhuser.SelectedItem.Text + "',Grealname='" + NewReader["realname"].ToString() + "',Gusername='" + bhuser.SelectedValue + "',Sreakmart='" + Sreakmart.Text + "'    where id='" + int.Parse(Request.QueryString["id"]) + "'";
                        List.ExeSql(Sql_update);
                    }
                    else
                    {

                    }


                }


                string sql_insert = " insert into SellOrder_sp  (number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'驳回','" + Sreakmart.Text + "','" + this.Session["username"] + "','" + this.Session["TrueName"] + "',MyTimes from  SellOrder where  id='" + int.Parse(Request.QueryString["id"]) + "'";
                List.ExeSql(sql_insert);

                //this.Response.Write("<script language=javascript>alert('提交成功！\n拒绝审批');window.location.href='SellOrder_sp.aspx'</script>");
                this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'SellOrder_sp.aspx'</script>");


            }
            else
            {



                string SQL_GetList = "select top 1 * from Xsdd_WorkStreamName where id>(select id from Xsdd_WorkStreamName where KeyFile='" + StreamNumber.Text + "' and Name_Jd='" + Gname.Text + "' and username='" + Gusername.Text + "') and KeyFile='" + StreamNumber.Text + "' order by id asc";
                OleDbDataReader NewReader = List.GetList(SQL_GetList);
                if (NewReader.Read())
                {
                    string sql_insert1 = "insert into SellOrderlog_lc  values('" + this.Session["TrueName"] + "通过销售订单[" + Name.Text + "]的审批，节点状态为：" + NewReader["Name_Jd"].ToString() + "','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                    List.ExeSql(sql_insert1);

                    string Sql_update = "Update SellOrder  Set Gname='" + NewReader["Name_Jd"].ToString() + "',Grealname='" + NewReader["realname"].ToString() + "',Gusername='" + NewReader["username"].ToString() + "' ,Sreakmart='" + Sreakmart.Text + "',State='正在审核'   where id='" + int.Parse(Request.QueryString["id"]) + "'";
                    List.ExeSql(Sql_update);

                    //Response.Write(SQL_GetList);

                    this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'SellOrder_sp.aspx'</script>");
                }
                else
                {

                    string sql_insert1 = "insert into SellOrderlog_lc  values('" + this.Session["TrueName"] + "通过采购入库[" + Name.Text + "]的审批，节点状态为：完成审核','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                    List.ExeSql(sql_insert1);



                    string Sql_update = "Update SellOrder  Set Gname='完成审核',Grealname='完成审核',Gusername='完成审核',State='完成审核',Sreakmart='" + Sreakmart.Text + "'    where id='" + int.Parse(Request.QueryString["id"]) + "'";
                    List.ExeSql(Sql_update);
                    Sql_update = @"INSERT INTO dbo.SellInMoney (number,title,Allmoney,JbName,Username,Realname,Gusername,Nowtimes,State,CompanyName,MyTimes)
                                      SELECT top 1  number,title,Allmoney,seller,Username,Realname,Username,Nowtimes,'等待审核',CompanyName,GETDATE() FROM dbo.SellOrder WHERE id={0}";
                    Sql_update = string.Format(Sql_update, int.Parse(Request.QueryString["id"]));
                    List.ExeSql(Sql_update);
                    string insert_xx = "insert into nbdxx values('销售订单[" + Name.Text + "]通过审批','销售订单[" + Name.Text + "]通过审批\n通过时间：" + System.DateTime.Now.ToString() + "','" + System.DateTime.Now.ToString() + "','" + username.Text + "','" + realname.Text + "','系统消息','系统消息','否','" + nbxx_num + "')";
                    List.ExeSql(insert_xx);



                }

                string sql_insert = " insert into SellOrder_sp  (number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'通过','" + Sreakmart.Text + "','" + this.Session["username"] + "','" + this.Session["TrueName"] + "',MyTimes from  SellOrder where  id='" + int.Parse(Request.QueryString["id"]) + "'";
                List.ExeSql(sql_insert);

                this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'SellOrder_sp.aspx'</script>");
            }

        }
    }
}