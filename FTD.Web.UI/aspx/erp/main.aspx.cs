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
	/// main ��ժҪ˵����
	/// </summary>
	public class main : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label link;
		public static string riqi,txtime,width,height;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.WebControls.TextBox iftx;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.TextBox type;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{

            FTD.Unit.PublicMethod.CheckSession();




			string    SQL_GetList     =  "select * from main_tx  where username='" + Session["username"].ToString()+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				iftx.Text=NewReader["iftx"].ToString();
				txtime=NewReader["txtime"].ToString();
				
			}

//			if(!IsPostBack)
//			{
//				string    SQL_GetList_tcnew     =  "select * from main_tc";
//				OleDbDataReader NewReader_tcnew = List.GetList(SQL_GetList_tcnew);
//				if(NewReader_tcnew.Read())
//				{
//					width=NewReader_tcnew["width"].ToString();
//					height=NewReader_tcnew["height"].ToString();
//					
//					type.Text=NewReader_tcnew["type"].ToString();
//				
//				}
//
//			}



			this.LinkButton1.Attributes.Add("onclick","javascript:return zx();"); 


			riqi="������"+System.DateTime.Now.Year.ToString()+"��"+System.DateTime.Now.Month.ToString()+"��"+System.DateTime.Now.Day.ToString()+"��";
		
			
			
			
			string    SQL_link     =   "select   * from main_link_us where username='"+this.Session["username"]+"' order by id asc";
				
			OleDbDataReader NewReader_link = List.GetList(SQL_link);

			this.link.Text=null;
		
			while (NewReader_link.Read())
			{
				this.link.Text+="<strong><a target=rform href="+NewReader_link["url"]+"><font color=#ffffff>"+NewReader_link["name"]+"</font></a></strong>&nbsp;|&nbsp;";
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
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Session.Clear();
			Response.Write("<script>alert('ע���ɹ���');window.location.href='default.aspx'</Script>");
		}
	}
}
