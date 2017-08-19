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
	/// BB_GoodsMove_HW ��ժҪ˵����
	/// </summary>
	public class BB_GoodsMove_HW : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Starttime;
		protected System.Web.UI.WebControls.TextBox Endtime;
		Db List=new Db();
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.DropDownList Stocktype;
		protected System.Web.UI.WebControls.TextBox CStoreroom;
		protected System.Web.UI.WebControls.TextBox RStoreroom;
		public static decimal  allmoney;
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.GoodsName.Text.Trim() != "")
			{
				MidSql=MidSql+" and GoodsMoveMx.GoodsName like '%"+this.GoodsName.Text.Trim()+"%'";
			}

			if (this.CStoreroom.Text.Trim() != "")
			{
				MidSql=MidSql+" and GoodsMoveMx.CStoreroom= '"+this.CStoreroom.Text.Trim()+"'";
			}

			if (this.RStoreroom.Text.Trim() != "")
			{
				MidSql=MidSql+" and GoodsMoveMx.RStoreroom= '"+this.RStoreroom.Text.Trim()+"'";
			}
	
			if (this.Starttime.Text.Trim() != "" && this.Endtime.Text.Trim() != "")
			{
				MidSql=MidSql+" and (GoodsMoveMx.Nowtimes between '"+this.Starttime.Text+"' and  '"+this.Endtime.Text+"' or convert(char(10),cast(GoodsMoveMx.Nowtimes as datetime),120)=convert(char(10),cast('"+this.Starttime.Text+"' as datetime),120) or convert(char(10),cast(GoodsMoveMx.Nowtimes as datetime),120)=convert(char(10),cast('"+this.Endtime.Text+"' as datetime),120)) ";
			}	

			return MidSql;

		}
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{

				Starttime.Text="2006-01-01";
				Endtime.Text=System.DateTime.Now.ToShortDateString();


			}
			if(Request.QueryString["str"]!=null)
			{
				string SQL_GetList_xs    =  "select GoodsMoveMx.* ,GoodsMove.Uses from GoodsMoveMx,GoodsMove where GoodsMoveMx.Keyfile=GoodsMove.number "+Server.UrlDecode(Request.QueryString["str"])+" ";

				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else
			{
			
				string SQL_GetList_xs    =  "select GoodsMoveMx.*  ,GoodsMove.Uses from GoodsMoveMx,GoodsMove where GoodsMoveMx.Keyfile=GoodsMove.number order by GoodsMoveMx.id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
			}


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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
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
			Response.Redirect("BB_GoodsMove_HW.aspx?str="+CreateMidSql()+"");
		}



	}
}
