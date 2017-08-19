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
	/// GoodsData_tj_pl 的摘要说明。
	/// </summary>
	public class GoodsData_tj_pl : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.DropDownList Type;
		Db List=new Db();
		protected System.Web.UI.WebControls.TextBox Sellmoney;
		BindDrowDownList list=new BindDrowDownList();




		private void Page_Load(object sender, System.EventArgs e)
		{
			



			string sql_down_Type="select * from GoodsType";
		
			if(!IsPostBack)
			{
				list.Bind_DropDownList_qb(Type,sql_down_Type,"Name","Name");
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string MidSql = string.Empty;




			if (this.Type.SelectedValue.Trim() != "全部")
			{
				MidSql=MidSql+" and Type ='"+Type.SelectedValue+"'";
			}



			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('批量[销售调价]','销售调价','"+this.Session["UserName"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);



			string Sql_update ="Update GoodsData Set  "+DropDownList2.SelectedValue+"="+DropDownList2.SelectedValue+"*"+Sellmoney.Text+" where 1=1 "+MidSql+"";
			List.ExeSql(Sql_update);



			
			this.Response.Write("<script language=javascript>alert('提交成功！');window.close()</script>");
		}
	}
}
