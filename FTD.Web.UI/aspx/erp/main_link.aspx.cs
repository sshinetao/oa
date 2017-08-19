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
	/// main_link ��ժҪ˵����
	/// </summary>
	public class main_link : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected DragonWebControls.GridPager GridPager1;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			//string SQL_GetList_xs    =  "select * from main_link_us where username='"+this.Session["username"]+"' order by id desc";
			
			this.ImageButton2.Attributes.Add("onclick","javascript:return del();"); 

				string SQL_GetList_xs    =  "select * from main_link_us order by id desc";
				DataGrid1.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				DataGrid1.DataBind();
		




			
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
				//				string aaa=DataGrid1.SelectedItem.Cells[1].Text.ToString();
				//				Response.Write(""+aaa+"");
			
				string SQL_Del = "Delete from main_link_us  where id='"+DataGrid1.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);

				Response.Redirect("main_link.aspx");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('ɾ��ʧ�ܣ���ȷ���Ƿ�ѡ��ɾ����');</script>");
			}
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_link_add.aspx");
		}

		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}


	}
}
