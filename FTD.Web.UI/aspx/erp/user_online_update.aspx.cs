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
	/// user_online_update ��ժҪ˵����
	/// </summary>
	public class user_online_update : System.Web.UI.Page
	{
		Db List=new Db();	
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			
			
			string    SQL_Label     =   "select * from test_people where username='"+this.Session["userName"]+"' ";
				
			OleDbDataReader NewReader_Label= List.GetList(SQL_Label);
			if(NewReader_Label.Read())
			{
				string Sql_update ="Update test_people Set firsttime='"+System.DateTime.Now.ToString()+"' where username='"+this.Session["userName"]+"'";
				List.ExeSql(Sql_update);

				string Sql_update_last ="Update test_people Set lasttime='"+System.DateTime.Now.AddSeconds(10)+"'";
				List.ExeSql(Sql_update_last);
			}
			else
			{

				string Sql_in ="insert into test_people values('"+this.Session["userName"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(Sql_in);

				string Sql_update ="Update test_people Set lasttime='"+System.DateTime.Now.AddSeconds(10)+"'";
				List.ExeSql(Sql_update);
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
	}
}
