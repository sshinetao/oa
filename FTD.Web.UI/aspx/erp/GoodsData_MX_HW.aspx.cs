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
	/// GoodsData_MX_HW 的摘要说明。
	/// </summary>
	public class GoodsData_MX_HW : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton6;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton8;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.ImageButton Imagebutton9;
		protected System.Web.UI.WebControls.ImageButton Imagebutton7;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		Db List=new Db();
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.GoodsName.Text.Trim() != "")
			{
				MidSql=MidSql+" and GoodsName like '%"+this.GoodsName.Text.Trim()+"%'";
			}





			return MidSql;

		}

		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();
		

			if(Request.QueryString["str"]!=null)
			{
				string SQL_GetList_xs    =  "select * from GoodsData where 1=1 "+Server.UrlDecode(Request.QueryString["str"])+"  order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else
			{
			
				string SQL_GetList_xs    =  "select * from GoodsData order by id desc";
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
			this.ImageButton4.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton4_Click);
			this.Imagebutton9.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton9_Click);
			this.Imagebutton7.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton7_Click);
			this.ImageButton5.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton5_Click);
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
			this.Datagrid2.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.Datagrid2_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}



		private void ImageButton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("GoodsData_MX_HW_show.aspx?see="+Datagrid2.SelectedItem.Cells[9].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}







		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}

		private void Imagebutton8_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("GoodsData_MX.aspx?str="+CreateMidSql()+"");
		}

		private void Imagebutton7_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("GoodsData_MX.aspx");
		}

		private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("GoodsData_MX_KJ.aspx");
		}

		private void Imagebutton9_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("GoodsData_MX_HW.aspx");
		}

		private void Datagrid2_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if(e.Item.ItemType==ListItemType.Header)
			{
			}
			else
			{
			
					
					string    SQL_money_     =  " SELECT SUM(Amount) AS "+"sum"+" from StoreAmount  where Number='"+e.Item.Cells[9].Text+"' ";
					OleDbDataReader NewReader_money = List.GetList(SQL_money_);
					if(NewReader_money.Read())
					{
						try
						{
							e.Item.Cells[3].Text=null;
							e.Item.Cells[3].Text+=NewReader_money.GetDecimal(0);
							
						}
						catch
						{
							e.Item.Cells[3].Text=null;
							e.Item.Cells[3].Text+="0";
							
						}
						NewReader_money.Close();
					}
			
				
			}
		}
	}
}
