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
	/// Systemnbdxx_add_down ��ժҪ˵����
	/// </summary>
	public class Systemnbdxx_add_down : System.Web.UI.Page
	{
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			string    SQL_GetList     =  "select * from nbdxxFj  where KeyField='" + Server.UrlDecode(Request.QueryString["number"])+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			NewReader.Read();
				
					
			Response.Redirect("nbdxxFj/"+Server.UrlDecode(Request.QueryString["number"])+"");
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
	}
}
