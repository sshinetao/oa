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
	/// Company_update 的摘要说明。
	/// </summary>
	public class Company_update : System.Web.UI.Page
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
		protected System.Web.UI.WebControls.TextBox Other;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		public static string str;
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			}



			if(Request.QueryString["key"].ToString()=="0")
			{
	
				str="供应商";
			
			}
			else if(Request.QueryString["key"].ToString()=="1")
			{
			
				str="客户";
			
			}
			else
			{
		
				str="两者皆是";
			}




			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from Company  where id='" + int.Parse(Request.QueryString["id"])+"'";
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
//					Receivable.Text=NewReader["Receivable"].ToString();
//					Payable.Text=NewReader["Payable"].ToString();
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
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('修改[往来客户]','往来客户','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);




			
			string Sql_update ="Update Company Set Name='"+Name.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',Type='"+Type.Text+"',Linkman='"+Linkman.Text+"',MoveTel='"+MoveTel.Text+"',Bank='"+Bank.Text+"',BankNumber='"+BankNumber.Text+"',TaxNumber='"+TaxNumber.Text+"',Deputy='"+Deputy.Text+"',Tel='"+Tel.Text+"',Fax='"+Fax.Text+"',Address='"+Address.Text+"',Mail='"+Mail.Text+"',Email='"+Email.Text+"',QQ='"+QQ.Text+"',Other='"+Other.Text+"',Remark='"+Remark.Text+"' where id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);



			
			this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='Company.aspx?key="+Request.QueryString["key"].ToString()+"'</script>");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
				Response.Redirect("Company.aspx?key="+Request.QueryString["key"].ToString()+"");
		}
	}
}
