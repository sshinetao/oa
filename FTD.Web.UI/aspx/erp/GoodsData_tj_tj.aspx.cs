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
	/// GoodsData_tj_tj ��ժҪ˵����
	/// </summary>
	public class GoodsData_tj_tj : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox Sellmoney1;
		protected System.Web.UI.WebControls.TextBox Sellmoney2;
		protected System.Web.UI.WebControls.TextBox Sellmoney3;
		protected System.Web.UI.WebControls.TextBox Sellmoney4;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from GoodsData  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					GoodsNumber.Text=NewReader["Number"].ToString();
					GoodsName.Text=NewReader["GoodsName"].ToString();
				
					Sellmoney1.Text=NewReader["Sellmoney1"].ToString();
					Sellmoney2.Text=NewReader["Sellmoney2"].ToString();
					Sellmoney3.Text=NewReader["Sellmoney3"].ToString();
					Sellmoney4.Text=NewReader["Sellmoney4"].ToString();
					
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
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[��Ʒ����]','��Ʒ����','"+this.Session["UserName"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);


			string Sql_update ="Update GoodsData Set  Sellmoney1='"+Sellmoney1.Text+"',Sellmoney2='"+Sellmoney2.Text+"',Sellmoney3='"+Sellmoney3.Text+"',Sellmoney4='"+Sellmoney4.Text+"' where id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);



			
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.close()</script>");
		}
	}
}
