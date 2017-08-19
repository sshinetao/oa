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
	/// BB_Company 的摘要说明。
	/// </summary>
	public class BB_Company : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton9;
		Db List=new Db();
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.TextBox Name;
	
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.Name.Text.Trim() != "")
			{
				MidSql=MidSql+" and Name like '%"+this.Name.Text.Trim()+"%'";
			}




			return MidSql;

		}
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{

			

			}
			if(Request.QueryString["str"]!=null)
			{
				string SQL_GetList_xs    =  "select * from Company where 1=1 "+Server.UrlDecode(Request.QueryString["str"])+" ";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else
			{
			
				string SQL_GetList_xs    =  "select * from Company order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	

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
			this.Imagebutton9.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton9_Click);
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
			Response.Redirect("BB_Company.aspx?str="+CreateMidSql()+"");
		}

		private void Imagebutton9_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				
				Response.Redirect("BB_Company_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

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
			
					
				string    SQL_money_1     =  " SELECT SUM(AllMoney) AS "+"sum"+" from StockOrder  where CompanyName='"+e.Item.Cells[2].Text+"'  and (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废') ";
				OleDbDataReader NewReader_money_1 = List.GetList(SQL_money_1);
				if(NewReader_money_1.Read())
				{
					try
					{
						e.Item.Cells[6].Text=null;
						e.Item.Cells[6].Text+=NewReader_money_1.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[6].Text=null;
						e.Item.Cells[6].Text+="0";
							
					}
					NewReader_money_1.Close();
				}
			
				

				string    SQL_money_2     =  " SELECT SUM(YfMoney) AS "+"sum"+" from StockOrder  where CompanyName='"+e.Item.Cells[2].Text+"'  and (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废')  ";
				OleDbDataReader NewReader_money_2 = List.GetList(SQL_money_2);
				if(NewReader_money_2.Read())
				{
					try
					{
						e.Item.Cells[7].Text=null;
						e.Item.Cells[7].Text+=NewReader_money_2.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[7].Text=null;
						e.Item.Cells[7].Text+="0";
							
					}
					NewReader_money_2.Close();
				}


				try
				{
					e.Item.Cells[8].Text=null;
					e.Item.Cells[8].Text+=decimal.Parse(e.Item.Cells[6].Text)-decimal.Parse(e.Item.Cells[7].Text);
							
				}
				catch
				{
					e.Item.Cells[8].Text=null;
					e.Item.Cells[8].Text+="0";
							
				}




				string    SQL_money_3     =  " SELECT SUM(AllMoney) AS "+"sum"+" from SellOrder  where CompanyName='"+e.Item.Cells[2].Text+"'  and (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废') ";
				OleDbDataReader NewReader_money_3 = List.GetList(SQL_money_3);
				if(NewReader_money_3.Read())
				{
					try
					{
						e.Item.Cells[9].Text=null;
						e.Item.Cells[9].Text+=NewReader_money_3.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[9].Text=null;
						e.Item.Cells[9].Text+="0";
							
					}
					NewReader_money_3.Close();
				}


				string    SQL_money_4     =  " SELECT SUM(YjMoney) AS "+"sum"+" from SellOrder  where CompanyName='"+e.Item.Cells[2].Text+"'   and (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废') ";
				OleDbDataReader NewReader_money_4 = List.GetList(SQL_money_4);
				if(NewReader_money_4.Read())
				{
					try
					{
						e.Item.Cells[10].Text=null;
						e.Item.Cells[10].Text+=NewReader_money_4.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[10].Text=null;
						e.Item.Cells[10].Text+="0";
							
					}
					NewReader_money_4.Close();
				}


				try
				{
					e.Item.Cells[11].Text=null;
					e.Item.Cells[11].Text+=decimal.Parse(e.Item.Cells[9].Text)-decimal.Parse(e.Item.Cells[10].Text);
							
				}
				catch
				{
					e.Item.Cells[11].Text=null;
					e.Item.Cells[11].Text+="0";
							
				}



			}
		}

	}
}
