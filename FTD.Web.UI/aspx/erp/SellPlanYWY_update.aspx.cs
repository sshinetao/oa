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
	/// SellPlanYWY_update ��ժҪ˵����
	/// </summary>
	public class SellPlanYWY_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox SellsName;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox Limit;
		protected System.Web.UI.WebControls.TextBox State;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox SellsNumber;
		protected System.Web.UI.WebControls.TextBox Starttime;
		protected System.Web.UI.WebControls.TextBox Endtime;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
				string    SQL_GetList     =  "select * from SellPlanYWY  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					SellsNumber.Text=NewReader["SellsNumber"].ToString();
					SellsName.Text=NewReader["SellsName"].ToString();
					Type.Text=NewReader["Type"].ToString();
					Limit.Text=NewReader["Limit"].ToString();
					State.Text=NewReader["State"].ToString();
					Starttime.Text=System.DateTime.Parse(NewReader["Starttime"].ToString()).ToShortDateString();	
					Endtime.Text=System.DateTime.Parse(NewReader["Endtime"].ToString()).ToShortDateString();	
				
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

			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('�޸�[ҵ��Ա���ۼƻ�]','ҵ��Ա���ۼƻ�','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

			string Sql_update ="Update SellPlanYWY Set SellsNumber='"+SellsNumber.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',SellsName='"+SellsName.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',Type='"+Type.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',Limit='"+Limit.Text+"',Starttime='"+Starttime.Text+"',Endtime='"+Endtime.Text+"'   where  id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);

			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='SellPlanYWY.aspx'</script>");

		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("SellPlanYWY.aspx");
		}
	}
}
