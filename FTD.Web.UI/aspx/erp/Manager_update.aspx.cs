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
	/// Manager_update ��ժҪ˵����
	/// </summary>
	public class Manager_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox name;
		protected System.Web.UI.WebControls.TextBox worknum;
		protected System.Web.UI.WebControls.TextBox unit;
		protected System.Web.UI.WebControls.DropDownList sex;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{

            FTD.Unit.PublicMethod.CheckSession();



			if(!IsPostBack)
			{


				string    SQL_GetList     =  "select * from Manager  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					name.Text=NewReader["name"].ToString();
					worknum.Text=NewReader["worknum"].ToString();
					sex.SelectedValue=NewReader["sex"].ToString();
					unit.Text=NewReader["unit"].ToString();
			
				
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('�޸�ְԱ','ְԱ����','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

			string Sql_update ="Update Manager Set name='"+name.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',sex='"+sex.SelectedValue.Replace("<","��").Replace(">","��").Replace("'","��")+"',worknum='"+worknum.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',unit='"+unit.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"'  where id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='Manager.aspx'</script>");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
				Response.Redirect("Manager.aspx");
		}
	}
}
