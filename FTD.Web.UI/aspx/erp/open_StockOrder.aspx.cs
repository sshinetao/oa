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
	/// open_StockOrder 的摘要说明。
	/// </summary>
	public class open_StockOrder : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
	Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!Page.IsPostBack)
			{
				tilte.Attributes["onkeydown"]="if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
				this.Imagebutton1.Attributes.Add("onclick","javascript:return del();"); 
		
			
//				if(Request.QueryString["qk"]=="1")
//				{
					string SQL_Del = "Delete from StockIncomeMx where Keyfile='"+Request.QueryString["number"].ToString()+"'";
					
					List.ExeSql(SQL_Del);
//				}






			}


			if(Request.QueryString["name"]!=null)
			{
				string SQL_GetList_xs    =  "select * from StockOrder where  CompanyNumber='"+Request.QueryString["CompanyNumber"]+"' and title like '%"+Server.UrlDecode(Request.QueryString["name"])+"%' and (username='"+this.Session["username"]+"' or Ifopen='是')  order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();
			}
			else
			{
				string SQL_GetList_xs    =  "select * from StockOrder where  CompanyNumber='"+Request.QueryString["CompanyNumber"]+"' and (username='"+this.Session["username"]+"' or Ifopen='是')  order by id desc";
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);
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
				Response.Redirect("open_StockOrder.aspx?name="+tilte.Text+"&CompanyNumber="+Request.QueryString["CompanyNumber"]+"&number="+Request.QueryString["number"]+"");
		}

		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			
			try
			{
		
				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('导入[采购订单]','采购入库','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);

				string sql_insert=" insert into StockIncomeMx  (Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,Username,Realname,Nowtimes,Ifdd) select '"+Request.QueryString["number"].ToString()+"',GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,'"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"','"+Datagrid2.SelectedItem.Cells[12].Text.ToString()+"' from  StockOrderMx   where Keyfile='"+Datagrid2.SelectedItem.Cells[12].Text.ToString()+"'";
				List.ExeSql(sql_insert);
				this.Response.Write("<script language=javascript>alert('提交成功');window.close()</script>");

			
			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}
	}
}
