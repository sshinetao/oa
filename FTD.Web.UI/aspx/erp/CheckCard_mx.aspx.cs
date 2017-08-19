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
	/// CheckCard_mx 的摘要说明。
	/// </summary>
	public class CheckCard_mx : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton6;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton8;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox Realname;
		protected System.Web.UI.WebControls.TextBox Nowtimes;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.DropDownList leixing;
		Db List=new Db();
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.GoodsName.Text.Trim() != "")
			{
				MidSql=MidSql+" and GoodsName like '%"+this.GoodsName.Text.Trim()+"%'";
			}


			if (this.Storeroom.Text.Trim() != "")
			{
				MidSql=MidSql+" and Storeroom like '%"+this.Storeroom.Text.Trim()+"%'";
			}	

			if (this.Realname.Text.Trim() != "")
			{
				MidSql=MidSql+" and Realname like '%"+this.Realname.Text.Trim()+"%'";
			}	

			if (this.Nowtimes.Text.Trim() != "")
			{
				MidSql = MidSql + " and convert(char(10),cast(Nowtimes as datetime),120)=convert(char(10),cast('"+Nowtimes.Text+"' as datetime),120) ";
			}


			if (this.leixing.SelectedValue.Trim() != "----")
			{
				MidSql = MidSql + " and cast(Difference as decimal)"+leixing.SelectedValue+"";
			}

			return MidSql;

		}

		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();
		

			if(Request.QueryString["str"]!=null)
			{
				string SQL_GetList_xs    =  "select * from CheckCard where 1=1 "+Server.UrlDecode(Request.QueryString["str"])+"  order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else
			{
			
				string SQL_GetList_xs    =  "select * from CheckCard order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();		
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
			this.Imagebutton8.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton8_Click);
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}





		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("CheckCard.aspx");
		}

		private void Imagebutton8_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("CheckCard_mx.aspx?str="+CreateMidSql()+"");
		}

		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("CheckCard.aspx");
		}


	}
}
