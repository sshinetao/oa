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
	/// StockPlan_add ��ժҪ˵����
	/// </summary>
	public class StockPlan_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox unit;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.TextBox StartTime;
		protected System.Web.UI.WebControls.TextBox EndTime;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
        protected System.Web.UI.WebControls.ImageButton ImageButton5;
        protected System.Web.UI.WebControls.TextBox rname;
        protected System.Web.UI.WebControls.TextBox uname;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{

			//�������
			if(!IsPostBack)
			{
			
				Random g  = new Random();
				string rad=g.Next(10000).ToString();

				number.Text=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+System.DateTime.Now.Hour.ToString()+""+System.DateTime.Now.Minute.ToString()+""+System.DateTime.Now.Second.ToString()+""+System.DateTime.Now.Millisecond.ToString()+""+rad+"";

                rname.Text = this.Session["TrueName"].ToString();
                uname.Text = this.Session["UserName"].ToString();

			

                //this.ImageButton5.Attributes.Add("onclick","javascript:return del();"); 

                //this.ImageButton3.Attributes.Add("onclick","javascript:zjOpen();"); 
			
			}

		


			string SQL_GetList_xs    =  "select * from StockPlanMx where  Keyfile='"+number.Text+"' order by id desc";
			//Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
			//Datagrid2.DataBind();
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
			Response.Redirect("StockPlan.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[�ɹ��ƻ�]','�ɹ��ƻ�','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

			string sql_insert="insert into StockPlan  (number,tilte,StartTime,EndTime,Type,ALLMoney,Unit,Username,Realname,Nowtimes,Ifopen) values('"+number.Text+"','"+tilte.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+StartTime.Text+"','"+EndTime.Text+"','����ִ��','0','"+unit.Text+"','"+this.Session["username"].ToString()+"','"+this.Session["TrueName"].ToString()+"','"+System.DateTime.Now.ToString()+"','0')";
			List.ExeSql(sql_insert);

			string Sql_update ="Update StockPlanMx Set Ifopen='0',Type='����ִ��' where Keyfile='" +number.Text+"'";
			List.ExeSql(Sql_update);

			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='StockPlan.aspx'</script>");
		}

		

	
	}
}
