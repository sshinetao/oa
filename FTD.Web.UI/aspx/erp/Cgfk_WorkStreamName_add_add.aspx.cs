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
	/// Cgfk_WorkStreamName_add_add 的摘要说明。
	/// </summary>
	public class Cgfk_WorkStreamName_add_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Name_Jd;
		protected System.Web.UI.WebControls.TextBox realname;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox Name_type;
		protected System.Web.UI.WebControls.TextBox KeyFile;
		protected System.Web.UI.WebControls.TextBox username;
		Db List=new Db();
		public static int BigId;
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			}

			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from Cgfk_WorkStreamType  where Number='" + Server.UrlDecode(Request.QueryString["Number"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					Name_type.Text=NewReader["Name"].ToString();
					KeyFile.Text=NewReader["Number"].ToString();
				
			
				
				}

				string    SQL_GetList_n     =  "select * from Cgfk_WorkStreamName  where KeyFile='" +KeyFile.Text+"' order by id desc";
				OleDbDataReader NewReader_n = List.GetList(SQL_GetList_n);
				if(NewReader_n.Read())
				{
					BigId=int.Parse(NewReader_n["id"].ToString())*200;
				}
				else
				{
					BigId=100;
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string    SQL_GetList     =  "select * from Cgfk_WorkStreamName  where KeyFile='" +KeyFile.Text+"' and username='"+username.Text+"' and Name_Jd='"+Name_Jd.Text+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				this.Response.Write("<script language=javascript>alert('操作失败！（节点名+人员名）与前节点重复');</script>");

			}
			else
			{
				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增[采购付款]工作流','工作流设置','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);


				string sql_insert="insert into Cgfk_WorkStreamName values('"+Name_type.Text+"','"+Name_Jd.Text+"','"+username.Text+"','"+realname.Text+"','"+KeyFile.Text+"','"+BigId+"')";
				List.ExeSql(sql_insert);
				this.Response.Write("<script language=javascript>alert('提交成功！');window.close();</script>");
			}
		}
	}
}
