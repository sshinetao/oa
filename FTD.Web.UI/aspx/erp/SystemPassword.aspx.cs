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
	/// SystemPassword 的摘要说明。
	/// </summary>
	public class SystemPassword : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Username;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox Password;
		protected System.Web.UI.WebControls.TextBox NewPassword;
		protected System.Web.UI.WebControls.TextBox NewPassword_c;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!this.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return check();"); 

			}

			if (!StrIFInStr("6000f", Session["perstr"].ToString()))
			{
				this.Response.Write("<script language=javascript>alert('对不起！没有权限！');window.location.href='main_1.aspx'</script>");
				return;

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

		private bool StrIFInStr(string Str1, string Str2)
		{
			if (Str2.IndexOf(Str1) < 0)
			{
				
				return false;
			}
			else
			{
				
				return true;
			}
		} 

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string    SQL_GetList     =  "select * from Username where Username='"+Username.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"' and Password='" + Password.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				string Sql_update ="Update Username Set Password='"+NewPassword.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"' where Username='"+Username.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"' and Password='" + Password.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"'";
				List.ExeSql(Sql_update);
				NewReader.Close();
				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='main_1.aspx'</script>");
			}
			else
			{
				Response.Write("<script>alert('旧密码输入错误！')</Script>");
			}
		}
	}
}
