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
	/// GoodsMove 的摘要说明。
	/// </summary>
	public class GoodsMove : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.ImageButton Imagebutton9;
		protected System.Web.UI.WebControls.ImageButton Imagebutton5;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

		
			if(!Page.IsPostBack)
			{
				
				this.Imagebutton5.Attributes.Add("onclick","javascript:return del();"); 
	
			
			}



				string SQL_GetList_xs    =  "select * from GoodsMove  where Username='"+this.Session["username"]+"'order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();
		
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
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);
			this.Imagebutton9.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton9_Click);
			this.Imagebutton5.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton5_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}



		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("GoodsMove_add.aspx");
		}

		private void Imagebutton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{

			try
			{


				string    SQL_GetList_yj     =  "select * from MonthSet where  '"+Datagrid2.SelectedItem.Cells[4].Text.ToString()+"' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[4].Text.ToString()+"' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[4].Text.ToString()+"' as datetime),120) ";
				OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
				if(NewReader_yj.Read())
				{
					this.Response.Write("<script language=javascript>alert('已经执行月结存，操作失败');</script>");
					return;


				}

		
			
				string SQL_Del = "Delete from GoodsMove where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);



				string SQL_GetList_xs    =  "select * from GoodsMove order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();
			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
			}




		}

		private void Imagebutton9_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("GoodsMove_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

	}
}
