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
	/// Username_show ��ժҪ˵����
	/// </summary>
	public class Username_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Username;
		protected System.Web.UI.WebControls.TextBox Realname;
		protected System.Web.UI.WebControls.TextBox Unit;
		protected System.Web.UI.WebControls.TextBox Email;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.TextBox Firsttime;
		protected System.Web.UI.WebControls.TextBox Lasttime;
		protected System.Web.UI.WebControls.TextBox Sex;
		protected System.Web.UI.WebControls.TextBox Iflogin;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox worknum;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!IsPostBack)
			{
				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('�鿴ϵͳ�û�','�û�����','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);

				string    SQL_GetList     =  "select * from Username  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					Username.Text=NewReader["Username"].ToString();
					Realname.Text=NewReader["Realname"].ToString();
					Sex.Text=NewReader["Sex"].ToString();
					Unit.Text=NewReader["Unit"].ToString();
					Firsttime.Text=System.DateTime.Parse(NewReader["Firsttime"].ToString()).ToShortDateString();
					Lasttime.Text=System.DateTime.Parse(NewReader["Lasttime"].ToString()).ToShortDateString();
					Email.Text=NewReader["Email"].ToString();
					Remark.Text=NewReader["Remark"].ToString();
					Iflogin.Text=NewReader["Iflogin"].ToString();
					worknum.Text=NewReader["worknum"].ToString();
				
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("username.aspx");
		}
	}
}
