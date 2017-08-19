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
	/// SellPlanHW ��ժҪ˵����
	/// </summary>
	public class SellPlanHW : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.ImageButton Imagebutton4;
		protected System.Web.UI.WebControls.ImageButton Imagebutton5;
		protected System.Web.UI.WebControls.ImageButton Imagebutton6;
		protected System.Web.UI.WebControls.ImageButton Imagebutton8;
		protected System.Web.UI.WebControls.ImageButton Imagebutton9;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();
		
			if(!Page.IsPostBack)
			{
				tilte.Attributes["onkeydown"]="if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
				this.Imagebutton5.Attributes.Add("onclick","javascript:return del();"); 
				this.Imagebutton6.Attributes.Add("onclick","javascript:return wb();"); 
			
				this.Imagebutton8.Attributes.Add("onclick","javascript:return zf();"); 
			}


			if(Request.QueryString["str"]!=null)
			{
				string SQL_GetList_xs    =  "select * from SellPlanHW where   GoodsName like '%"+Server.UrlDecode(Request.QueryString["str"])+"%'   order by id desc";
			
				
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else
			{
				string SQL_GetList_xs    =  "select * from SellPlanHW order  by id desc";
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
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);
			this.Imagebutton9.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton9_Click);
			this.Imagebutton4.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton4_Click);
			this.Imagebutton5.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton5_Click);
			this.Imagebutton6.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton6_Click);
			this.Imagebutton8.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton8_Click);
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
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
			Response.Redirect("SellPlanHW.aspx?str="+tilte.Text+"");
		}

		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}

		private void Imagebutton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
			
				string SQL_Del = "Delete from SellPlanHW where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);



				if(Request.QueryString["str"]!=null)
				{
					string SQL_GetList_xs    =  "select * from SellPlanHW where   GoodsName like '%"+Server.UrlDecode(Request.QueryString["str"])+"%'   order by id desc";
			
				
					Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
					Datagrid2.DataBind();

				}
				else
				{
					string SQL_GetList_xs    =  "select * from SellPlanHW order  by id desc";
					Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
					Datagrid2.DataBind();
				}

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('ɾ��ʧ�ܣ���ȷ���Ƿ�ѡ��ɾ����');</script>");
			}
		}

		private void Imagebutton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
				if(Datagrid2.SelectedItem.Cells[7].Text.ToString()=="���"||Datagrid2.SelectedItem.Cells[7].Text.ToString()=="����")
				{
					this.Response.Write("<script language=javascript>alert('����ʧ��!��ǰ״̬�Ѿ�Ϊ["+Datagrid2.SelectedItem.Cells[7].Text.ToString()+"]');</script>");
					return;
				}

				Response.Redirect("SellPlanHW_update.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}

		private void Imagebutton9_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("SellPlanHW_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}

		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("SellPlanHW_add.aspx");
		}

		private void Imagebutton6_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
		
			
				if(Datagrid2.SelectedItem.Cells[7].Text.ToString()=="���"||Datagrid2.SelectedItem.Cells[7].Text.ToString()=="����")
				{
			

					this.Response.Write("<script language=javascript>alert('����ʧ��!��ǰ״̬�Ѿ�Ϊ["+Datagrid2.SelectedItem.Cells[7].Text.ToString()+"]');</script>");
					return;
				
				}
				else
				{
					string SQL_Del = "update  SellPlanHW   set State='���' where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
					List.ExeSql(SQL_Del);


				

					this.Response.Write("<script language=javascript>alert('�ύ�ɹ���״̬����Ϊ[���]');window.location.href='SellPlanHW.aspx'</script>");
				}


			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}


		private void Imagebutton8_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
		
			
				if(Datagrid2.SelectedItem.Cells[7].Text.ToString()=="���"||Datagrid2.SelectedItem.Cells[7].Text.ToString()=="����")
				{
			

					this.Response.Write("<script language=javascript>alert('����ʧ��!��ǰ״̬�Ѿ�Ϊ["+Datagrid2.SelectedItem.Cells[7].Text.ToString()+"]');</script>");
				}
				else
				{
					string SQL_Del = "update  SellPlanHW   set State='����' where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
					List.ExeSql(SQL_Del);//�ƻ�



					this.Response.Write("<script language=javascript>alert('�ύ�ɹ���״̬����Ϊ[����]');window.location.href='SellPlanHW.aspx'</script>");
				}


			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}

	}
}
