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
	/// PostType_add ��ժҪ˵����
	/// </summary>
	public class PostType_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox Number;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.TextBox Content;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();


			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("PostType.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[��������]','��������','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

			string sql_insert="insert into PostType (Number,Name,Content) values('"+Number.Text+"','"+Name.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Content.Text+"')";
			List.ExeSql(sql_insert);
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='PostType.aspx'</script>");
		}
	}
}
