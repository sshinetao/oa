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
	/// Systemnbdxx_show ��ժҪ˵����
	/// </summary>
	public class Systemnbdxx_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox content;
		protected System.Web.UI.WebControls.DropDownList fjlb;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Number;
		Db List=new Db();
		BindDrowDownList list=new BindDrowDownList();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from nbdxx  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					Number.Text=NewReader["Number"].ToString();
					title.Text=NewReader["title"].ToString();
					content.Text=NewReader["content"].ToString();
				
				
				}

			}
			string Sql_update ="Update nbdxx Set sfck='��' where  Id='" + int.Parse(Request.QueryString["id"]).ToString() +"'and (acceptusername='"+this.Session["userName"]+"' or acceptusername='"+this.Session["worknum"]+"') ";
			List.ExeSql(Sql_update);

			//�����б�
			string sql_down_1="select * from nbdxxFj where KeyField='"+Number.Text+"'";
		
			
			list.Bind_DropDownList_nothing(fjlb,sql_down_1,"NewName","Name");
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

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("Systemnbdxx.aspx");
		}
	}
}
