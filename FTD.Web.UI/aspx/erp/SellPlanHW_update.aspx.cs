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
	/// SellPlanHW_update 的摘要说明。
	/// </summary>
	public class SellPlanHW_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox Limit;
		protected System.Web.UI.WebControls.TextBox State;
		protected System.Web.UI.WebControls.TextBox Starttime;
		protected System.Web.UI.WebControls.TextBox Endtime;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from SellPlanHW  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					GoodsName.Text=NewReader["GoodsName"].ToString();
					GoodsNumber.Text=NewReader["GoodsNumber"].ToString();
					Type.Text=NewReader["Type"].ToString();
					State.Text=NewReader["State"].ToString();
					Limit.Text=NewReader["Limit"].ToString();
					Starttime.Text=System.DateTime.Parse(NewReader["Starttime"].ToString()).ToShortDateString();	
					Endtime.Text=System.DateTime.Parse(NewReader["Endtime"].ToString()).ToShortDateString();	
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
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('修改[货物销售计划]','货物销售计划','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

			string Sql_update ="Update SellPlanHW Set GoodsNumber='"+GoodsNumber.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',GoodsName='"+GoodsName.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',Type='"+Type.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',Limit='"+Limit.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',Starttime='"+Starttime.Text+"',Endtime='"+Endtime.Text+"' where  id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);

			this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='SellPlanHW.aspx'</script>");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
				Response.Redirect("SellPlanHW.aspx");
		}
	}
}
