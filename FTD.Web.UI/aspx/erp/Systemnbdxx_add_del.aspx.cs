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
	/// Systemnbdxx_add_del ��ժҪ˵����
	/// </summary>
	public class Systemnbdxx_add_del : System.Web.UI.Page
	{
		Db List=new Db();
		public string newname,name,	_SavePath;
		private void Page_Load(object sender, System.EventArgs e)
        {
            FTD.Unit.PublicMethod.CheckSession();

			_SavePath =this.Server.MapPath("nbdxxFj/");

			string SQL_Del = "Delete from nbdxxFj where NewName='" +Server.UrlDecode(Request.QueryString["number"])+"'";
			List.ExeSql(SQL_Del);

			//			Response.Write(SQL_Del);

			string DelPath  = _SavePath+Server.UrlDecode(Request.QueryString["number"]);
������������System.IO.File.Delete(DelPath);

			this.Response.Write("<script language=javascript>alert('ɾ���ɹ���');window.close();</script>");
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
