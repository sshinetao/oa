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
	/// GoodsData_tj_pl ��ժҪ˵����
	/// </summary>
	public class GoodsData_tj_pl : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.DropDownList DropDownList2;
		protected System.Web.UI.WebControls.DropDownList Type;
		Db List=new Db();
		protected System.Web.UI.WebControls.TextBox Sellmoney;
		BindDrowDownList list=new BindDrowDownList();




		private void Page_Load(object sender, System.EventArgs e)
		{
			



			string sql_down_Type="select * from GoodsType";
		
			if(!IsPostBack)
			{
				list.Bind_DropDownList_qb(Type,sql_down_Type,"Name","Name");
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string MidSql = string.Empty;




			if (this.Type.SelectedValue.Trim() != "ȫ��")
			{
				MidSql=MidSql+" and Type ='"+Type.SelectedValue+"'";
			}



			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[���۵���]','���۵���','"+this.Session["UserName"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);



			string Sql_update ="Update GoodsData Set  "+DropDownList2.SelectedValue+"="+DropDownList2.SelectedValue+"*"+Sellmoney.Text+" where 1=1 "+MidSql+"";
			List.ExeSql(Sql_update);



			
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.close()</script>");
		}
	}
}
