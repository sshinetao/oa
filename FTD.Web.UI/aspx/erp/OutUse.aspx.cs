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
	/// OutUse ��ժҪ˵����
	/// </summary>
	public class OutUse : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		protected System.Web.UI.WebControls.ImageButton ImageButton6;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			this.ImageButton6.Attributes.Add("onclick","javascript:return del();"); 


			string SQL_GetList_xs    =  "select * from OutUse order by IfSystem desc";
			Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"IfSystem");
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
			this.ImageButton4.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton4_Click);
			this.ImageButton5.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton5_Click);
			this.ImageButton6.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton6_Click);
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}




		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}

		private void ImageButton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("OutUse_add.aspx");
		}

		private void ImageButton6_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
				if(Datagrid2.SelectedItem.Cells[3].Text.ToString()=="��")
				{
					this.Response.Write("<script language=javascript>alert('ϵͳ�ⲻ��ɾ��');</script>");
					return;
				}
			
				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('ɾ��[�����Դ]','�����Դ','"+this.Session["UserName"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);


				string SQL_Del = "Delete from OutUse where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);

				Response.Redirect("OutUse.aspx");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('ɾ��ʧ�ܣ���ȷ���Ƿ�ѡ��ɾ����');</script>");
			}
		}

		private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				if(Datagrid2.SelectedItem.Cells[3].Text.ToString()=="��")
				{
					this.Response.Write("<script language=javascript>alert('ϵͳ�ⲻ���޸�');</script>");
					return;
				}


				Response.Redirect("OutUse_update.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}

	


	}
}
