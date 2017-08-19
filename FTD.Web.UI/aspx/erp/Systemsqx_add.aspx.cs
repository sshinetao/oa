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
	/// Systemsqx_add 的摘要说明。
	/// </summary>
	public class Systemsqx_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Username;
		protected System.Web.UI.WebControls.TextBox Realname;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.CheckBoxList userlist;
		Db List=new Db();
		BindDrowDownList list=new BindDrowDownList();
		public static string PerSessionStr;
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from Username  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					Username.Text=NewReader["Username"].ToString();
					Realname.Text=NewReader["Realname"].ToString();
					PerSessionStr=NewReader["Perstr"].ToString();
				}

				  

			}
			string sql_down="select * from main_link where usekey='1' order by keyname asc";

			
			if(!IsPostBack)
			{
				list.Bind_DropDownList_CheckBoxList(userlist,sql_down,"keyname","name");


				BindChecked();
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

		private void BindChecked()
		{
			for (int i = 0; i < this.userlist.Items.Count; i++)
			{
				if (StrIFInStr(this.userlist.Items[i].Value.ToString(), PerSessionStr) == true)
				{
					this.userlist.Items[i].Selected = true;
				}
			}
		}


		private bool StrIFInStr(string Str1, string Str2)
		{
			if (Str2.IndexOf("|" + Str1 + "|") < 0)
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
			Response.Redirect("Systemsqx.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{

			

			string PerStr = null;
			for (int i = 0; i < this.userlist.Items.Count; i++)
			{
				if (this.userlist.Items[i].Selected)
				{
					PerStr = PerStr + this.userlist.Items[i].Value.ToString().Trim() + "|";
				}
			}


			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增权限管理','权限管理','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);


			string Sql_update ="Update Username Set Perstr='|"+PerStr+"' where id='" + int.Parse(Request.QueryString["id"])+"'";

			List.ExeSql(Sql_update);
			this.Response.Write("<script language=javascript>alert('提交成功，您设置的用户，需要重新登陆后才能生效！');window.location.href='Systemsqx.aspx'</script>");

		}
	}
}
