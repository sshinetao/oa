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
	/// Username_add ��ժҪ˵����
	/// </summary>
	public class Username_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Username;
		protected System.Web.UI.WebControls.TextBox Realname;
		protected System.Web.UI.WebControls.TextBox Password;
		protected System.Web.UI.WebControls.TextBox Unit;
		protected System.Web.UI.WebControls.DropDownList Sex;
	
		protected System.Web.UI.WebControls.TextBox Email;
		protected System.Web.UI.WebControls.DropDownList Iflogin;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox worknum;
		protected System.Web.UI.WebControls.TextBox Firsttime;
		protected System.Web.UI.WebControls.TextBox Lasttime;
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

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string SQL_Check_worknum = "select * from Username where Username='"+Username.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"' or worknum='"+worknum.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"'";
			OleDbDataReader MyReader_worknum = List.GetList(SQL_Check_worknum);
			if(MyReader_worknum.Read())
			{
				this.Response.Write("<script language=javascript>alert('�û����򹤺Ų����ظ���');</script>");
			}
			else
			{
				string sql_insert="insert into Username values('"+Username.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Realname.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Password.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Sex.SelectedValue.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Unit.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Firsttime.Text+"','"+Lasttime.Text+"','"+Email.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Remark.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Iflogin.SelectedValue.Replace("<","��").Replace(">","��").Replace("'","��")+"','','"+worknum.Text+"','��','��','0','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert);

				string sql_insert_x="insert into main_tx values('��Ҫ','300000','"+Username.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"')";
				List.ExeSql(sql_insert_x);

				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����ϵͳ�û�','�û�����','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);



				this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='Username.aspx'</script>");
			}

		
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("username.aspx");
		}
	}
}
