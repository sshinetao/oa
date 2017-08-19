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
	/// Company ��ժҪ˵����
	/// </summary>
	public class Company : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		protected System.Web.UI.WebControls.ImageButton ImageButton6;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		Db List=new Db();
		public static string str;
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();



			this.ImageButton6.Attributes.Add("onclick","javascript:return del();"); 

			if(Request.QueryString["key"].ToString()=="0")
			{
				string SQL_GetList_xs    =  "select * from Company where AllType='��Ӧ��' order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
				str="��Ӧ��";
			
			}
			else if(Request.QueryString["key"].ToString()=="1")
			{
				string SQL_GetList_xs    =  "select * from Company where AllType='�ͻ�' order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
				str="�ͻ�";
			
			}
			else
			{
				string SQL_GetList_xs    =  "select * from Company where AllType='���߽���' order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();			
				str="���߽���";
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
			this.ImageButton4.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton4_Click);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
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
			Response.Redirect("Company_add.aspx?key="+Request.QueryString["key"].ToString()+"");
		}

		private void ImageButton6_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
			
				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('ɾ��[������λ]','������λ','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);


				string SQL_Del = "Delete from Company where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);

				Response.Redirect("Company.aspx?key="+Request.QueryString["key"].ToString()+"");

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

				Response.Redirect("Company_update.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"&key="+Request.QueryString["key"].ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("Company_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"&key="+Request.QueryString["key"].ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}		
		}

	


	}
}
