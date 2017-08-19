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
	/// SellPlanHW_update ��ժҪ˵����
	/// </summary>
	public class SellPlanHW_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox Limit;
		protected System.Web.UI.WebControls.TextBox State;
		protected System.Web.UI.WebControls.TextBox Starttime;
		protected System.Web.UI.WebControls.TextBox Endtime;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from SellPlanHW  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					GoodsName.Text=NewReader["GoodsName"].ToString();
					GoodsNumber.Text=NewReader["GoodsNumber"].ToString();
					Type.Text=NewReader["Type"].ToString();
					State.Text=NewReader["State"].ToString();
					Limit.Text=NewReader["Limit"].ToString();
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
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('�޸�[�������ۼƻ�]','�������ۼƻ�','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

			string Sql_update ="Update SellPlanHW Set GoodsNumber='"+GoodsNumber.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',GoodsName='"+GoodsName.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',Type='"+Type.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',Limit='"+Limit.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',Starttime='"+Starttime.Text+"',Endtime='"+Endtime.Text+"' where  id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);

			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='SellPlanHW.aspx'</script>");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
				Response.Redirect("SellPlanHW.aspx");
		}
	}
}
