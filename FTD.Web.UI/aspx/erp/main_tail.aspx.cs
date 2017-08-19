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
	/// main_tail 的摘要说明。
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
					cdk="正式版";
					
				}
				else
				{
					cdk="演示版";
				}
			}
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
