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
	/// Company_add ��ժҪ˵����
	/// </summary>
	public class Company_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Number;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.TextBox Linkman;
		protected System.Web.UI.WebControls.TextBox MoveTel;
		protected System.Web.UI.WebControls.TextBox Bank;
		protected System.Web.UI.WebControls.TextBox BankNumber;
		protected System.Web.UI.WebControls.TextBox TaxNumber;
		protected System.Web.UI.WebControls.TextBox Deputy;
		protected System.Web.UI.WebControls.TextBox Tel;
		protected System.Web.UI.WebControls.TextBox Fax;
		protected System.Web.UI.WebControls.TextBox Mail;
		protected System.Web.UI.WebControls.TextBox Address;
		protected System.Web.UI.WebControls.TextBox Other;
		protected System.Web.UI.WebControls.TextBox Email;
		protected System.Web.UI.WebControls.TextBox QQ;
		Db List=new Db();
		public static string str;
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();
			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			}

			//�������
			if(!IsPostBack)
			{
			
				Random g  = new Random();
				string rad=g.Next(10000).ToString();

				Number.Text=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+rad+"";
			
			}

			if(Request.QueryString["key"].ToString()=="0")
			{
	
				str="��Ӧ��";
			
			}
			else if(Request.QueryString["key"].ToString()=="1")
			{
			
				str="�ͻ�";
			
			}
			else
			{
		
				str="���߽���";
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


			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[�����ͻ�]','�����ͻ�','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);




			
			string sql_insert="insert into Company (Number,Name,Type,Linkman,MoveTel,Bank,BankNumber,TaxNumber,Deputy,Tel,Fax,Address,Mail,Email,QQ,Other,Remark,AllType) values('"+Number.Text+"','"+Name.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Type.Text+"','"+Linkman.Text+"','"+MoveTel.Text+"','"+Bank.Text+"','"+BankNumber.Text+"','"+TaxNumber.Text+"','"+Deputy.Text+"','"+Tel.Text+"','"+Fax.Text+"','"+Address.Text+"','"+Mail.Text+"','"+Email.Text+"','"+QQ.Text+"','"+Other.Text+"','"+Remark.Text+"','"+str+"')";
			List.ExeSql(sql_insert);



			
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='Company.aspx?key="+Request.QueryString["key"].ToString()+"'</script>");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("Company.aspx?key="+Request.QueryString["key"].ToString()+"");
		}


	}
}
