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
	/// MonthSet_add ��ժҪ˵����
	/// </summary>
	public class MonthSet_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.DropDownList Years;
		protected System.Web.UI.WebControls.DropDownList Months;
		protected System.Web.UI.WebControls.TextBox Starttime;
		protected System.Web.UI.WebControls.TextBox Endtime;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		BindDrowDownList list=new BindDrowDownList();
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 

				list.Bind_DropDownList_Year(Years,2006,2010);
				list.Bind_DropDownList_Month(Months);
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
			TimeSpan ts=DateTime.Parse(Starttime.Text)-DateTime.Parse(Endtime.Text);
			if(Convert.ToInt32(ts.TotalSeconds)>0)
			{
				Response.Write("<script>alert('�ύʧ�ܣ���ʼ����>��������');</script>");
				return;
			}

			string sql_insert="insert into MonthSet (Years,Months,Starttime,Endtime,Username,Realname,Nowtimes) values('"+Years.SelectedValue+"','"+Months.SelectedValue+"','"+Starttime.Text+"','"+Endtime.Text+"','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert);
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='MonthSet.aspx'</script>");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("MonthSet.aspx");
		}
	}
}
