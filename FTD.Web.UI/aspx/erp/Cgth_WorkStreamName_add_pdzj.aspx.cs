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
	/// Cgth_WorkStreamName_add_pdzj ��ժҪ˵����
	/// </summary>
	public class Cgth_WorkStreamName_add_pdzj : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox realname;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox Name_Jd;
		protected System.Web.UI.WebControls.TextBox username;
	
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			}
			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from Cgth_WorkStreamName  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					Name_Jd.Text=NewReader["Name_Jd"].ToString();

				
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
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[ƽ����Ա]������','����������','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);


			string Sql_update ="Update Cgth_WorkStreamName Set realname=realname+'|"+realname.Text+"',username=username+'|"+username.Text+"' where id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);

		
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.close();</script>");
		}
	}
}

