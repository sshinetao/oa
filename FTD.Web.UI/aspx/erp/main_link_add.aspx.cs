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
	/// main_link_add 的摘要说明。
	/// </summary>
	public class main_link_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DropDownList name;
		protected System.Web.UI.WebControls.TextBox Tbyte;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Username;
		Db List=new Db();
		BindDrowDownList list=new BindDrowDownList();
		public static decimal sum;
		public static string sql_down_1;
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!Page.IsPostBack)
			{

				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			
			}


			string str_sum="select SUM(Tbyte) AS "+"sum"+" from main_link_us where username='"+Session["username"]+"' ";
	       
			OleDbDataReader NewReader_all = List.GetList(str_sum);
			NewReader_all.Read();
			
		
			try
			{
				sum=NewReader_all.GetDecimal(0);
				
				
			}
			catch
			{
				sum=0;
			}

			decimal txt=45-sum;
			Tbyte.Text+=txt;

			if(!IsPostBack)
			{
				sql_down_1="SELECT * FROM main_link WHERE  CHARINDEX(keyname, '"+this.Session["perstr"]+"') > 0 and usekey='1' order by keyname";
				list.Bind_DropDownList(name,sql_down_1,"url","name");
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

			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增快捷方式','快捷方式设置','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);


			string sql_insert="insert into main_link_us values('"+name.SelectedItem.Text+"','"+name.SelectedValue+"','"+name.SelectedItem.Text.Length+"','"+this.Session["username"]+"','"+this.Session["TrueName"]+"')";
			List.ExeSql(sql_insert);
			this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='main_link.aspx'</script>");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_link.aspx");
		}
	}
}
