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
	/// StockIncome_gz_rz ��ժҪ˵����
	/// </summary>
	public class StockIncome_gz_rz : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			string SQL_GetList_xs    =  "select * from StockIncomelog_lc  where KeyField='"+Request.QueryString["number"]+"' order by id desc";
			Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
			Datagrid2.DataBind();
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
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
			Response.Redirect("StockIncome_gz.aspx?id="+Request.QueryString["id"].ToString()+"");
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
	}
}
