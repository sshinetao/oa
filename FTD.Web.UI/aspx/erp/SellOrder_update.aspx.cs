using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using qpsmartweb_jxc.Public;
using System.Data.OleDb;
namespace qpsmartweb_jxc
{
    /// <summary>
    /// SellOrder_update 的摘要说明。
    /// </summary>
    public class SellOrder_update : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.DataGrid Datagrid2;
        protected System.Web.UI.WebControls.ImageButton ImageButton3;
        protected System.Web.UI.WebControls.ImageButton ImageButton4;
        protected System.Web.UI.WebControls.ImageButton ImageButton5;
        protected System.Web.UI.WebControls.ImageButton Imagebutton6;
        protected System.Web.UI.WebControls.TextBox title;
        protected System.Web.UI.WebControls.DropDownList Ifopen;
        protected System.Web.UI.WebControls.TextBox Type;
        protected System.Web.UI.WebControls.TextBox InvoiceType;
        protected System.Web.UI.WebControls.TextBox InvoiceNum;
        protected System.Web.UI.WebControls.TextBox QdTime;
        protected System.Web.UI.WebControls.TextBox OrderAdd;
        protected System.Web.UI.WebControls.TextBox LxAdd;
        protected System.Web.UI.WebControls.TextBox Storeroom;
        protected System.Web.UI.WebControls.TextBox ShTime;
        protected System.Web.UI.WebControls.TextBox CompanyName;
        protected System.Web.UI.WebControls.TextBox CompanyAdd;
        protected System.Web.UI.WebControls.TextBox BankNumber;
        protected System.Web.UI.WebControls.TextBox TaxNumber;
        protected System.Web.UI.WebControls.TextBox Bank;
        protected System.Web.UI.WebControls.TextBox Tel;
        protected System.Web.UI.WebControls.TextBox LxPeople;
        protected System.Web.UI.WebControls.TextBox DlPeople;
        protected System.Web.UI.WebControls.TextBox Unit;
        protected System.Web.UI.WebControls.TextBox StockPeoName;
        protected System.Web.UI.WebControls.TextBox YxStarttime;
        protected System.Web.UI.WebControls.TextBox YxEndtime;
        protected System.Web.UI.WebControls.TextBox Discount;
        protected System.Web.UI.WebControls.TextBox AllMoney;
        protected System.Web.UI.WebControls.TextBox StreamName;
        protected System.Web.UI.WebControls.TextBox Remark;
        protected System.Web.UI.WebControls.ImageButton ImageButton1;
        protected System.Web.UI.WebControls.ImageButton ImageButton2;
        protected System.Web.UI.WebControls.TextBox number;
        protected System.Web.UI.WebControls.TextBox CompanyNumber;
        protected System.Web.UI.WebControls.TextBox StockPeoNum;
        protected System.Web.UI.WebControls.TextBox StreamNumber;
        protected System.Web.UI.WebControls.TextBox Seller;
        protected System.Web.UI.WebControls.TextBox Storekeeper;
        protected System.Web.UI.WebControls.TextBox MyTimes;
        Db List = new Db();
        public static string Gusername, Grealname, Gname;
        private void Page_Load(object sender, System.EventArgs e)
        {


            if (!IsPostBack)
            {
                this.ImageButton5.Attributes.Add("onclick", "javascript:return del();");

                this.Imagebutton6.Attributes.Add("onclick", "javascript:return drjh();");

                this.ImageButton3.Attributes.Add("onclick", "javascript:zjOpen();");
                this.ImageButton1.Attributes.Add("onclick", "javascript:return chknull();");

            }



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
                    Seller.Text = NewReader["Seller"] + "";
                    Storekeeper.Text = NewReader["Storekeeper"] + "";
                    MyTimes.Text = NewReader["MyTimes"] + "";
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

        #region Web 窗体设计器生成的代码
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.ImageButton5.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton5_Click);
            this.Datagrid2.SelectedIndexChanged += new System.EventHandler(this.Datagrid2_SelectedIndexChanged);
            this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
            this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
            this.Load += new System.EventHandler(this.Page_Load);

        }
        #endregion

        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }
        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("SellOrder.aspx");
        }

        private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string SQL_GetList = "select top 1 * from Xsdd_WorkStreamName  where KeyFile='" + StreamNumber.Text + "'";
            OleDbDataReader NewReader = List.GetList(SQL_GetList);
            if (NewReader.Read())
            {
                Gusername = NewReader["username"].ToString();
                Grealname = NewReader["realname"].ToString();
                Gname = NewReader["Name_Jd"].ToString();


                string sql_insert_xtrz = "insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('修改[销售订单]','销售订单','" + this.Session["username"] + "','" + this.Session["TrueName"] + "','" + System.DateTime.Now.ToString() + "')";
                List.ExeSql(sql_insert_xtrz);


                string sql_insert1 = "insert into SellOrderlog_lc values('" + this.Session["TrueName"] + "修改了销售订单[" + title.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") + "]','" + System.DateTime.Now.ToString() + "','" + number.Text + "')";
                List.ExeSql(sql_insert1);


                string Sql_update = "Update SellOrder Set Ifopen='" + Ifopen.SelectedValue + "',number='" + number.Text +
                    "',title='" + title.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") + 
                    "',Type='" + Type.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") +
                    "',InvoiceType='" + InvoiceType.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") +
                    "',InvoiceNum='" + InvoiceNum.Text + "',QdTime='" + QdTime.Text + "',OrderAdd='" + OrderAdd.Text + 
                    "',LxAdd='" + LxAdd.Text + "',Storeroom='" + Storeroom.Text + "',ShTime='" + ShTime.Text +
                    "',CompanyNumber='" + CompanyNumber.Text + "',CompanyName='" + CompanyName.Text + 
                    "',CompanyAdd='" + CompanyAdd.Text + "',BankNumber='" + BankNumber.Text + 
                    "',TaxNumber='" + TaxNumber.Text + "',Bank='" + Bank.Text + "',Tel='" + Tel.Text + 
                    "',LxPeople='" + LxPeople.Text + "',DlPeople='" + DlPeople.Text + "',Unit='" + Unit.Text +
                    "',StockPeoNum='" + StockPeoNum.Text + "',StockPeoName='" + StockPeoName.Text + "',YxStarttime='" + YxStarttime.Text + "',YxEndtime='" + YxEndtime.Text + 
                    "',DisMoney=" + AllMoney.Text + "*" + Discount.Text + ",AllMoney='" + AllMoney.Text + "',Remark='" + Remark.Text +
                    "',MyTimes='" + MyTimes.Text + "',StreamNumber='" + StreamNumber.Text + "',StreamName='" + StreamName.Text + 
                    "',Gusername='" + Gusername + "',Grealname='" + Grealname + "',Gname='" + Gname +
                    "',Username='" + this.Session["Username"] + "',Realname='" + this.Session["TrueName"] +
                     "',Seller='" + Seller.Text + "',Storekeeper='" + Storekeeper.Text + 
                    "',State='等待审批' where id='" + int.Parse(Request.QueryString["id"]) + "'";

                List.ExeSql(Sql_update);



                this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='SellOrder.aspx'</script>");

            }
            else
            {
                this.Response.Write("<script language=javascript>alert('此工作流；未找到对应的流程！操作失败');</script>");
                return;

            }

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

    }
}

