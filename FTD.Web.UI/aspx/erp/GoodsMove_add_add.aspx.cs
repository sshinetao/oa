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
	/// GoodsMove_add_add ��ժҪ˵����
	/// </summary>
	public class GoodsMove_add_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.TextBox Color;
		protected System.Web.UI.WebControls.TextBox SplitPoint;
		protected System.Web.UI.WebControls.TextBox Realname;
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		protected System.Web.UI.WebControls.TextBox CStoreroom;
		protected System.Web.UI.WebControls.TextBox RStoreroom;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
				Realname.Text=this.Session["TrueName"].ToString();
			
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


			string sql_insert="insert into GoodsMoveMx (Keyfile,GoodsNumber,GoodsName,CountUnit,Model,Color,SplitPoint,CStoreroom,RStoreroom,Username,Realname,Nowtimes) values('"+Request.QueryString["number"]+"','"+GoodsNumber.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+GoodsName.Text+"','"+CountUnit.Text+"','"+Model.Text+"','"+Color.Text+"','"+SplitPoint.Text+"','"+CStoreroom.Text+"','"+RStoreroom.Text+"','"+this.Session["username"].ToString()+"','"+this.Session["TrueName"].ToString()+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert);
		
			
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.close()</script>");
		}
	}
}
