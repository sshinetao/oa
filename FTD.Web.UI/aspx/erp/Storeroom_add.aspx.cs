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
	/// Storeroom_add 的摘要说明。
	/// </summary>
	public class Storeroom_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.TextBox Principal;
		protected System.Web.UI.WebControls.TextBox Users;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
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
			string SQL_Check_worknum = "select * from Storeroom where Name='"+Name.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"'";
			OleDbDataReader MyReader_worknum = List.GetList(SQL_Check_worknum);
			if(MyReader_worknum.Read())
			{
				this.Response.Write("<script language=javascript>alert('库房名称不能重复！');</script>");
			}
			else
			{
				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增[仓库信息]','仓库信息','"+this.Session["UserName"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);

				string sql_insert="insert into Storeroom values('"+Name.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"','"+Principal.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"','"+Users.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"','0')";
				List.ExeSql(sql_insert);
				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='Storeroom.aspx'</script>");

			}

		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
				Response.Redirect("Storeroom.aspx");
		}
	}
}
