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
	/// open_GoodsOpenMoney 的摘要说明。
	/// </summary>
	public class open_GoodsOpenMoney : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox name;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.DropDownList DropDownList1;
	
		Db List=new Db();	
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!Page.IsPostBack)
			{
				Name.Attributes["onkeydown"]="if (event.keyCode==13) { document.all.Imagebutton1.click(); return false;}";
			}

			if(Request.QueryString["str1"]!=null)
			{
				string SQL_GetList_xs    =  "select * from GoodsOpenMoney where GoodsName like '%"+Server.UrlDecode(Request.QueryString["str1"])+"%'  and State='启用'  order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else if(Request.QueryString["str2"]!=null)
			{
				string SQL_GetList_xs    =  "select * from GoodsOpenMoney where KhName like '%"+Server.UrlDecode(Request.QueryString["str2"])+"%'  and State='启用'   order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
			}
			else
			{
				string SQL_GetList_xs    =  "select * from GoodsOpenMoney where State='启用' order by id desc";
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			if(DropDownList1.SelectedValue=="商品名")
			{
				Response.Redirect("open_GoodsOpenMoney.aspx?str1="+Name.Text+"");
			}
			else
			{
				Response.Redirect("open_GoodsOpenMoney.aspx?str2="+Name.Text+"");
			}

		}
	}
}
