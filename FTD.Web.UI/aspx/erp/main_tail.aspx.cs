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
	/// main_tail ��ժҪ˵����
	/// </summary>
	public class main_tail : System.Web.UI.Page
	{
		public static string cdk,name;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
//			string    SQL_GetList_jh     =  "select * from cdk ";
//			OleDbDataReader NewReader_jh = List.GetList(SQL_GetList_jh);
//			if(NewReader_jh.Read())
//			{
//				cdk=NewReader_jh["name"].ToString();
//			}


			string    SQL_GetList     =  "select * from UserSteup  where id='1'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				name=NewReader["Name"].ToString();


					
				if(NewReader["IfSteup"].ToString()=="13002355133")
				{
					cdk="��ʽ��";
					
				}
				else
				{
					cdk="��ʾ��";
				}
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
