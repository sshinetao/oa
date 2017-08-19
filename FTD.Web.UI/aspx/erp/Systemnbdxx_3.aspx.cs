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
namespace bjoa
{
	/// <summary>
	/// Systemnbdxx_3 的摘要说明。
	/// </summary>
	public class Systemnbdxx_3 : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
	
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			string SQL_GetList_xs    =  "select * from nbdxx where (acceptusername='"+this.Session["userName"]+"' or acceptusername='"+this.Session["worknum"]+"') order by id desc";
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
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Datagrid2.ItemCreated += new System.Web.UI.WebControls.DataGridItemEventHandler(this.Datagrid2_ItemCreated);
			this.Datagrid2.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.Datagrid2_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("Systemnbdxx_add.aspx");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}

		private void Datagrid2_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			ListItemType itemType = e.Item.ItemType;
		
			if (itemType == ListItemType.Item )
			{
				e.Item.Attributes["onmouseover"] = "javascript:this.style.backgroundColor='#BBCEEA';cursor='hand';" ;
				e.Item.Attributes["onmouseout"] = "javascript:this.style.backgroundColor='#E6EDF7';";
			}
			else if( itemType == ListItemType.AlternatingItem)
			{
				e.Item.Attributes["onmouseover"] = "javascript:this.style.backgroundColor='#BBCEEA';cursor='hand';" ;
				e.Item.Attributes["onmouseout"] = "javascript:this.style.backgroundColor='#FBFCFE';";
			}
		}

		private void Datagrid2_ItemCreated(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			foreach(DataGridItem di in this.Datagrid2.Items) 
　			{
				if(di.ItemType==ListItemType.Item||di.ItemType==ListItemType.AlternatingItem) 
　　			{ 
					
　　　				((LinkButton)di.Cells[5].Controls[0]).Attributes.Add("onclick","return confirm('确认删除此项吗？');"); 
					
					
　　			} 
			}
		}
		public void DataGrid2_Delete(Object sender, DataGridCommandEventArgs e) 
		{
	
			string SQL_Del = "Delete from nbdxx where id='"+e.Item.Cells[0].Text+"'";
					
			List.ExeSql(SQL_Del);

			Response.Redirect("Systemnbdxx_3.aspx");
		
		}

	}
}
