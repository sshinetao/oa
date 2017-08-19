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
	/// BB_YWY 的摘要说明。
	/// </summary>
	public class BB_YWY : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.TextBox Starttime;
		protected System.Web.UI.WebControls.TextBox Endtime;
		Db List=new Db();
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		public static decimal  allmoney;
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.StockPeoName.Text.Trim() != "")
			{
				MidSql=MidSql+" and StockPeoName like '%"+this.StockPeoName.Text.Trim()+"%'";
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
				string SQL_GetList_xs    =  "select distinct StockPeoName  from SellOrder where  (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废')  and  1=1 "+Server.UrlDecode(Request.QueryString["str"])+" ";
				Datagrid2.DataSource   = List.GetGrid_Pages_not(SQL_GetList_xs);
				Datagrid2.DataBind();

				string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+" from SellOrder where   (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废')  and  1=1 "+Server.UrlDecode(Request.QueryString["str"])+" ";
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
			
				string SQL_GetList_xs    =  "select  distinct StockPeoName  from SellOrder where   (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废')";
				Datagrid2.DataSource   = List.GetGrid_Pages_not(SQL_GetList_xs);
				Datagrid2.DataBind();	
	


				string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+"  from SellOrder where   (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废')  ";
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Datagrid2.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.Datagrid2_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("BB_YWY.aspx?str="+CreateMidSql()+"");
		}

		private void Imagebutton9_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				
				Response.Redirect("StockPlan_BB_BT_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

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
			
					
				string    SQL_money_1     =  " SELECT SUM(AllMoney) AS "+"sum"+" from SellOrder  where   (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废')  and  StockPeoName='"+e.Item.Cells[1].Text+"' ";
				OleDbDataReader NewReader_money_1 = List.GetList(SQL_money_1);
				if(NewReader_money_1.Read())
				{
					try
					{
						e.Item.Cells[2].Text=null;
						e.Item.Cells[2].Text+=NewReader_money_1.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[2].Text=null;
						e.Item.Cells[2].Text+="0";
							
					}
					NewReader_money_1.Close();
				}
			
			
			}
		}

	}
}
