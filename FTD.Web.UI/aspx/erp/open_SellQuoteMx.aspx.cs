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
	/// open_SellQuoteMx ��ժҪ˵����
	/// </summary>
	public class open_SellQuoteMx : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{

			if(!Page.IsPostBack)
			{
				tilte.Attributes["onkeydown"]="if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";

				this.Imagebutton1.Attributes.Add("onclick","javascript:return del();"); 
		
				string SQL_Del = "Delete from SellOrderMx where Keyfile='"+Request.QueryString["number"].ToString()+"'";
					
				List.ExeSql(SQL_Del);
			
			}

			if(Request.QueryString["name"]!=null)
			{
				string SQL_GetList_xs    =  "select * from SellQuote where  CompanyNumber='"+Request.QueryString["CompanyNumber"]+"' and title like '%"+Server.UrlDecode(Request.QueryString["name"])+"%' and (username='"+this.Session["username"]+"' or Ifopen='��') and (Type!='ǿ��ֹͣ' or Type!='ִ�����' or Type!='����')  order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();
			}
			else
			{
				string SQL_GetList_xs    =  "select * from SellQuote where  CompanyNumber='"+Request.QueryString["CompanyNumber"]+"' and (username='"+this.Session["username"]+"' or Ifopen='��') and (Type!='ǿ��ֹͣ' or Type!='ִ�����' or Type!='����') order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();
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
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}

		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{

			try
			{
		
				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[���۱���]','���۶���','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);

				string sql_insert=" insert into SellOrderMx  (Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,Username,Realname,Nowtimes,YfMoney) select '"+Request.QueryString["number"].ToString()+"',GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,'"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"','0' from  SellQuoteMx where Keyfile='"+Datagrid2.SelectedItem.Cells[8].Text.ToString()+"'";
				List.ExeSql(sql_insert);
				//Response.Write(sql_insert);
				this.Response.Write("<script language=javascript>alert('�ύ�ɹ�');window.close()</script>");

			
			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}



		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("open_SellQuoteMx.aspx?name="+tilte.Text+"&CompanyNumber="+Request.QueryString["CompanyNumber"]+"&number="+Request.QueryString["number"]+"");
		}
	}
}
