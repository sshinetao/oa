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
	/// StockReady_add_update ��ժҪ˵����
	/// </summary>
	public class StockReady_add_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.TextBox Amount;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			
			}

			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from StockReadyMx   where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					GoodsNumber.Text=NewReader["GoodsNumber"].ToString();
					GoodsName.Text=NewReader["GoodsName"].ToString();
					CountUnit.Text=NewReader["CountUnit"].ToString();
					Model.Text=NewReader["Model"].ToString();
					Amount.Text=NewReader["Amount"].ToString();
			

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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('�޸�[����������ϸ]','��������','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);


			string Sql_update ="Update StockReadyMx Set GoodsNumber='"+GoodsNumber.Text+"',GoodsName='"+GoodsName.Text+"',CountUnit='"+CountUnit.Text+"',Model='"+Model.Text+"',Amount='"+Amount.Text+"' where id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);
	
			
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.close()</script>");
		}
	}
}
