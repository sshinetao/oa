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
	/// open_GoodsOpenMoney ��ժҪ˵����
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
				string SQL_GetList_xs    =  "select * from GoodsOpenMoney where GoodsName like '%"+Server.UrlDecode(Request.QueryString["str1"])+"%'  and State='����'  order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else if(Request.QueryString["str2"]!=null)
			{
				string SQL_GetList_xs    =  "select * from GoodsOpenMoney where KhName like '%"+Server.UrlDecode(Request.QueryString["str2"])+"%'  and State='����'   order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
			}
			else
			{
				string SQL_GetList_xs    =  "select * from GoodsOpenMoney where State='����' order by id desc";
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
			if(DropDownList1.SelectedValue=="��Ʒ��")
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
