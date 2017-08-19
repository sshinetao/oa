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
	/// BB_SellQuote_BT 的摘要说明。
	/// </summary>
	public class BB_SellQuote_BT : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox unit;
		protected System.Web.UI.WebControls.TextBox Starttime;
		protected System.Web.UI.WebControls.TextBox Endtime;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.ImageButton Imagebutton3;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox QdTime;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		Db List=new Db();
		protected System.Web.UI.WebControls.TextBox InvoiceType;
		public static decimal  allmoney;
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.title.Text.Trim() != "")
			{
				MidSql=MidSql+" and title like '%"+this.title.Text.Trim()+"%'";
			}


			if (this.InvoiceType.Text.Trim() != "")
			{
				MidSql=MidSql+" and InvoiceType like '%"+this.InvoiceType.Text.Trim()+"%'";
			}

			if (this.StockPeoName.Text.Trim() != "")
			{
				MidSql=MidSql+" and StockPeoName like '%"+this.StockPeoName.Text.Trim()+"%'";
			}

			if (this.CompanyName.Text.Trim() != "")
			{
				MidSql=MidSql+" and CompanyName like '%"+this.CompanyName.Text.Trim()+"%'";
			}


			if (this.QdTime.Text.Trim() != "" )
			{
				MidSql=MidSql+" and convert(char(10),cast(QdTime as datetime),120)=convert(char(10),cast('"+this.QdTime.Text+"' as datetime),120) ";
			}	




			if (this.unit.Text.Trim() != "")
			{
				MidSql=MidSql+" and Unit = '"+this.unit.Text.Trim()+"'";
			}
	
			if (this.Starttime.Text.Trim() != "" && this.Endtime.Text.Trim() != "")
			{
				MidSql=MidSql+" and (Nowtimes between '"+this.Starttime.Text+"' and  '"+this.Endtime.Text+"' or convert(char(10),cast(Nowtimes as datetime),120)=convert(char(10),cast('"+this.Starttime.Text+"' as datetime),120) or convert(char(10),cast(Nowtimes as datetime),120)=convert(char(10),cast('"+this.Endtime.Text+"' as datetime),120)) ";
			}	

			return MidSql;

		}

		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{

				Starttime.Text="2006-01-01";
				Endtime.Text=System.DateTime.Now.ToShortDateString();


			}
			if(Request.QueryString["str"]!=null)
			{
				string SQL_GetList_xs    =  "select * from SellQuote where 1=1 "+Server.UrlDecode(Request.QueryString["str"])+" ";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

				string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+" from SellQuote where 1=1 "+Server.UrlDecode(Request.QueryString["str"])+" ";
				OleDbDataReader NewReader_money = List.GetList(SQL_money_);
				if(NewReader_money.Read())
				{
					try
					{
						
						allmoney=NewReader_money.GetDecimal(0);
							
					}
					catch
					{
						
						allmoney=0;
							
					}
					NewReader_money.Close();
				}
				else
				{
					allmoney=0;
				}




			}
			else
			{
			
				string SQL_GetList_xs    =  "select * from SellQuote order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
	


				string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+"  from SellQuote ";
				OleDbDataReader NewReader_money = List.GetList(SQL_money_);
				if(NewReader_money.Read())
				{
					try
					{
						
						allmoney=NewReader_money.GetDecimal(0);
							
					}
					catch
					{
						
						allmoney=0;
							
					}
					NewReader_money.Close();
				}
				else
				{
					allmoney=0;
				}
			}
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);
			this.Imagebutton3.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton3_Click);
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
			Response.Redirect("BB_SellQuote_BT.aspx?str="+CreateMidSql()+"");
		}

		private void Imagebutton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				
				Response.Redirect("BB_SellQuote_BT_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

	}
}
