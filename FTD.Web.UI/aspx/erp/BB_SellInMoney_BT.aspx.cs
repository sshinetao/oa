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
	/// BB_SellInMoney_BT 的摘要说明。
	/// </summary>
	public class BB_SellInMoney_BT : System.Web.UI.Page
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
		public static decimal  allmoney,yfmoney,symoney;
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.title.Text.Trim() != "")
			{
				MidSql=MidSql+" and title like '%"+this.title.Text.Trim()+"%'";
			}


			if (this.Type.Text.Trim() != "")
			{
				MidSql=MidSql+" and Type like '%"+this.Type.Text.Trim()+"%'";
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
				string SQL_GetList_xs    =  "select * from SellOrder where 1=1 "+Server.UrlDecode(Request.QueryString["str"])+" ";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

				string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+" from SellOrder where 1=1 "+Server.UrlDecode(Request.QueryString["str"])+" ";
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


				string    SQL_money_1     =  " SELECT SUM(YjMoney) AS "+"sum"+" from SellOrder where 1=1 "+Server.UrlDecode(Request.QueryString["str"])+" ";
				OleDbDataReader NewReader_money1 = List.GetList(SQL_money_1);
				if(NewReader_money1.Read())
				{
					try
					{
						
						yfmoney=NewReader_money1.GetDecimal(0);

							
					}
					catch
					{
						
						yfmoney=0;
							
					}
					NewReader_money1.Close();
				}
				else
				{
					yfmoney=0;
				}


			}
			else
			{
			
				string SQL_GetList_xs    =  "select * from SellOrder order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
	


				string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+"  from SellOrder ";
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


				string    SQL_money_1     =  " SELECT SUM(YjMoney) AS "+"sum"+" from SellOrder";
				OleDbDataReader NewReader_money1 = List.GetList(SQL_money_1);
				if(NewReader_money1.Read())
				{
					try
					{
						
						yfmoney=NewReader_money1.GetDecimal(0);

							
					}
					catch
					{
						
						yfmoney=0;
							
					}
					NewReader_money1.Close();
				}
				else
				{
					yfmoney=0;
				}













			}


			symoney=allmoney-yfmoney;

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
			this.Datagrid2.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.Datagrid2_ItemDataBound);
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
			Response.Redirect("BB_SellInMoney_BT.aspx?str="+CreateMidSql()+"");
		}

		private void Imagebutton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				
				Response.Redirect("BB_SellInMoney_BT_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

		private void Datagrid2_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if(e.Item.ItemType==ListItemType.Header)
			{
			}
			else
			{
			
					
			
				try
				{
					e.Item.Cells[10].Text=null;
					e.Item.Cells[10].Text+=decimal.Parse(e.Item.Cells[8].Text)-decimal.Parse(e.Item.Cells[9].Text);
							
				}
				catch
				{
					e.Item.Cells[10].Text=null;
					e.Item.Cells[10].Text+="0";
							
				}
				
				
		


			}
		}

	}
}
