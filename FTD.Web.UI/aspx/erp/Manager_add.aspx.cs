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
	/// Manager_add ��ժҪ˵����
	/// </summary>
	public class Manager_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox name;
		protected System.Web.UI.WebControls.TextBox worknum;
		protected System.Web.UI.WebControls.TextBox unit;
		protected System.Web.UI.WebControls.DropDownList sex;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		public static string Number;
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				Random g  = new Random();
				string rad=g.Next(10000).ToString();
				Number=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+System.DateTime.Now.Millisecond.ToString()+""+rad+"";
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
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����ְԱ','ְԱ����','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);



			string SQL_Check_worknum = "select * from Manager  where worknum='"+worknum.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"'";
			OleDbDataReader MyReader_worknum = List.GetList(SQL_Check_worknum);
			if(MyReader_worknum.Read())
			{
				this.Response.Write("<script language=javascript>alert('���Ų����ظ���');</script>");
			}
			else
			{
				string sql_insert="insert into Manager (number,name,worknum,sex,unit,sftype,gztype,photo) values('"+Number+"','"+name.Text+"','"+worknum.Text+"','"+sex.SelectedValue+"','"+unit.Text+"','��ͬ��','����','nothing.jpg')";
				List.ExeSql(sql_insert);
				this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='Manager.aspx'</script>");
			}
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("Manager.aspx");
		}
	}
}
