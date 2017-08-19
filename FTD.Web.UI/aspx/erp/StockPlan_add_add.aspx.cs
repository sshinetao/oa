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
	/// StockPlan_add_add 的摘要说明。
	/// </summary>
	public class StockPlan_add_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.TextBox CompanyAdd;
		protected System.Web.UI.WebControls.TextBox JyOrderTime;
		protected System.Web.UI.WebControls.TextBox JyToTime;
		protected System.Web.UI.WebControls.TextBox TxTime;
		protected System.Web.UI.WebControls.TextBox StockPoint;
		protected System.Web.UI.WebControls.TextBox SingleMoney;
		protected System.Web.UI.WebControls.TextBox Allmoney;
		protected System.Web.UI.WebControls.DropDownList Stocktype;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
        protected System.Web.UI.WebControls.TextBox CompanyNumber;
        protected System.Web.UI.WebControls.TextBox Realname;
        protected System.Web.UI.WebControls.TextBox number;
        protected System.Web.UI.WebControls.TextBox rname;
        protected System.Web.UI.WebControls.TextBox uname;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{

            string ss = GoodsNumber.Text;
            string ss3 = GoodsName.Text;
			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();");
                Realname.Text = this.Session["TrueName"].ToString();

                Random g = new Random();
                string rad = g.Next(10000).ToString();

                number.Text = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + "" + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + "" + System.DateTime.Now.Millisecond.ToString() + "" + rad + "";

                StockPeoName.Text = Session["TrueName"].ToString();
                StockPeoNum.Text = Session["UserName"].ToString();
                rname.Text = this.Session["TrueName"].ToString();
                uname.Text = this.Session["UserName"].ToString();
               
			}
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
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增[采购计划明细]','采购计划','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

			string sql_insert="insert into StockPlanMx (Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,Stocktype,StockPeoNum,StockPeoName,CompanyNumber,CompanyName,CompanyAdd,JyOrderTime,JyToTime,TxTime,Username,Realname,Nowtimes) values('"+Request.QueryString["number"]+"','"+GoodsNumber.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"','"+GoodsName.Text+"','"+CountUnit.Text+"','"+Model.Text+"','"+StockPoint.Text+"','"+SingleMoney.Text+"','"+Allmoney.Text+"','"+Stocktype.SelectedValue+"','"+StockPeoNum.Text+"','"+StockPeoName.Text+"','"+CompanyNumber.Text+"','"+CompanyName.Text+"','"+CompanyAdd.Text+"','"+JyOrderTime.Text+"','"+JyToTime.Text+"','"+TxTime.Text+"','"+this.Session["username"].ToString()+"','"+this.Session["TrueName"].ToString()+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert);
			
			this.Response.Write("<script language=javascript>alert('提交成功！');window.close()</script>");
		}
	}
}
