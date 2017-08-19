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
	/// GoodsData_tj ��ժҪ˵����
	/// </summary>
	public class GoodsData_tj : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.ImageButton Imagebutton4;
		protected System.Web.UI.WebControls.ImageButton Imagebutton5;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();
		
			if(!Page.IsPostBack)
			{
				GoodsName.Attributes["onkeydown"]="if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";

				this.Imagebutton5.Attributes.Add("onclick","javascript:drjh();"); 
			}


			if(Request.QueryString["str"]!=null)
			{
				string SQL_GetList_xs    =  "select * from GoodsData where  GoodsName like '%"+Server.UrlDecode(Request.QueryString["str"])+"%'   order by id desc";
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
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);
			this.Datagrid2.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.Datagrid2_ItemDataBound);
			this.Datagrid2.SelectedIndexChanged += new System.EventHandler(this.Datagrid2_SelectedIndexChanged);
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}
		private void Datagrid2_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if(e.Item.ItemType==ListItemType.Header)
			{
			}
			else
			{
				
				string    SQL_GetList_ck     =  "select * from StoreAmount where Number='"+e.Item.Cells[2].Text+"' ";
				OleDbDataReader NewReader_ck = List.GetList(SQL_GetList_ck);
				if(NewReader_ck.Read())
				{
					string    SQL_GetList     =  "select sum(Amount) as counts from StoreAmount where Number='"+e.Item.Cells[2].Text+"' ";
					OleDbDataReader NewReader = List.GetList(SQL_GetList);
					if(NewReader.Read())
					{
						string alldelpoint=NewReader["counts"].ToString();
						e.Item.Cells[6].Text+=alldelpoint;
					}
				}
				else
				{
					e.Item.Cells[6].Text+="0";
				
				}



			
			}
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{	
			Response.Redirect("GoodsData_tj.aspx?str="+GoodsName.Text+"");
		
		}

		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("GoodsData_tj_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}

		private void Datagrid2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
			
				Imagebutton4.Attributes.Add("onclick","window.showModalDialog('GoodsData_tj_tj.aspx?a='+Math.random()+'&id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"','window','dialogWidth:750px;DialogHeight=430px;status:no;help=no;scroll=no');window.location='#'");
			//Imagebutton5.Attributes.Add("onclick","window.showModalDialog('GoodsData_tj_pl.aspx?a='+Math.random()+'&id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"','window','dialogWidth:750px;DialogHeight=430px;status:no;help=no;scroll=no');window.location='#'");

			}
			catch
			{
				//this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}
	}
}
