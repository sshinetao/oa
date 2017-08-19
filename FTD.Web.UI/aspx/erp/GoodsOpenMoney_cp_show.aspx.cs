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
	/// GoodsOpenMoney_cp_show 的摘要说明。
	/// </summary>
	public class GoodsOpenMoney_cp_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Number;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox Linkman;
		protected System.Web.UI.WebControls.TextBox MoveTel;
		protected System.Web.UI.WebControls.TextBox Bank;
		protected System.Web.UI.WebControls.TextBox BankNumber;
		protected System.Web.UI.WebControls.TextBox TaxNumber;
		protected System.Web.UI.WebControls.TextBox Deputy;
		protected System.Web.UI.WebControls.TextBox Tel;
		protected System.Web.UI.WebControls.TextBox Fax;
		protected System.Web.UI.WebControls.TextBox Mail;
		protected System.Web.UI.WebControls.TextBox Address;
		protected System.Web.UI.WebControls.TextBox Email;
		protected System.Web.UI.WebControls.TextBox QQ;
		protected System.Web.UI.WebControls.TextBox Receivable;
		protected System.Web.UI.WebControls.TextBox Payable;
		protected System.Web.UI.WebControls.TextBox Other;
		protected System.Web.UI.WebControls.TextBox Remark;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from Company where Number='" +Server.UrlDecode(Request.QueryString["Number"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					Number.Text=NewReader["Number"].ToString();
					Name.Text=NewReader["Name"].ToString();
					Type.Text=NewReader["Type"].ToString();
					Linkman.Text=NewReader["Linkman"].ToString();
					MoveTel.Text=NewReader["MoveTel"].ToString();
					Bank.Text=NewReader["Bank"].ToString();
					BankNumber.Text=NewReader["BankNumber"].ToString();
					TaxNumber.Text=NewReader["TaxNumber"].ToString();
					Deputy.Text=NewReader["Deputy"].ToString();
					Tel.Text=NewReader["Tel"].ToString();
					Fax.Text=NewReader["Fax"].ToString();
					Receivable.Text=NewReader["Receivable"].ToString();
					Payable.Text=NewReader["Payable"].ToString();
					Address.Text=NewReader["Address"].ToString();
					Mail.Text=NewReader["Mail"].ToString();
					Email.Text=NewReader["Email"].ToString();
					QQ.Text=NewReader["QQ"].ToString();
					Other.Text=NewReader["Other"].ToString();
					Remark.Text=NewReader["Remark"].ToString();
				}

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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
