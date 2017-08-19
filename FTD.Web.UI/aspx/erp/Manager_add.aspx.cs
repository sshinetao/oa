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
	/// Manager_add 的摘要说明。
	/// </summary>
	public class Manager_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox name;
		protected System.Web.UI.WebControls.TextBox worknum;
		protected System.Web.UI.WebControls.TextBox unit;
		protected System.Web.UI.WebControls.DropDownList sex;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		public static string Number;
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				Random g  = new Random();
				string rad=g.Next(10000).ToString();
				Number=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+System.DateTime.Now.Millisecond.ToString()+""+rad+"";
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
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增职员','职员设置','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);



			string SQL_Check_worknum = "select * from Manager  where worknum='"+worknum.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"'";
			OleDbDataReader MyReader_worknum = List.GetList(SQL_Check_worknum);
			if(MyReader_worknum.Read())
			{
				this.Response.Write("<script language=javascript>alert('工号不能重复！');</script>");
			}
			else
			{
				string sql_insert="insert into Manager (number,name,worknum,sex,unit,sftype,gztype,photo) values('"+Number+"','"+name.Text+"','"+worknum.Text+"','"+sex.SelectedValue+"','"+unit.Text+"','合同工','正常','nothing.jpg')";
				List.ExeSql(sql_insert);
				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='Manager.aspx'</script>");
			}
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("Manager.aspx");
		}
	}
}
