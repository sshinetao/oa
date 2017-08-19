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
	/// BB_GoodsData_HW 的摘要说明。
	/// </summary>
	public class BB_GoodsData_HW : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton6;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton8;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox Type;
		Db List=new Db();
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.GoodsName.Text.Trim() != "")
			{
				MidSql=MidSql+" and GoodsName like '%"+this.GoodsName.Text.Trim()+"%'";
			}


			if (this.Type.Text.Trim() != "")
			{
				MidSql=MidSql+" and Type like '%"+this.Type.Text.Trim()+"%'";
			}


			return MidSql;

		}

		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();
		

			if(Request.QueryString["str"]!=null)
			{
				string SQL_GetList_xs    =  "select * from GoodsData where 1=1 "+Server.UrlDecode(Request.QueryString["str"])+"  order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else
			{
			
				string SQL_GetList_xs    =  "select * from GoodsData order by id desc";
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
			this.Imagebutton8.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton8_Click);
			this.ImageButton4.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton4_Click);
			this.Datagrid2.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.Datagrid2_ItemDataBound);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}

		private void Datagrid2_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if(e.Item.ItemType==ListItemType.Header)
			{
			}
			else
			{
			
					
				string    SQL_money_1     =  " SELECT SUM(Amount) AS "+"sum"+" from StoreAmount  where Number='"+e.Item.Cells[13].Text+"' ";
				OleDbDataReader NewReader_money_1 = List.GetList(SQL_money_1);
				if(NewReader_money_1.Read())
				{
					try
					{
						e.Item.Cells[3].Text=null;
						e.Item.Cells[3].Text+=NewReader_money_1.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[3].Text=null;
						e.Item.Cells[3].Text+="0";
							
					}
					NewReader_money_1.Close();
				}
			
				
				string    SQL_money_2     =  " SELECT SUM(StockIncomeMx.StockPoint) AS "+"sum"+"  from StockIncomeMx ,StockIncome  where  (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废') and  StockIncomeMx.Keyfile=StockIncome.number and GoodsNumber='"+e.Item.Cells[13].Text+"'";
				OleDbDataReader NewReader_money_2 = List.GetList(SQL_money_2);
				if(NewReader_money_2.Read())
				{
					try
					{
						e.Item.Cells[4].Text=null;
						e.Item.Cells[4].Text+=NewReader_money_2.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[4].Text=null;
						e.Item.Cells[4].Text+="0";
							
					}
					NewReader_money_2.Close();
				}


				string    SQL_money_3     =  " SELECT SUM(StockOutMx.StockPoint) AS "+"sum"+"  from StockOutMx ,StockOut  where   (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废') and  StockOutMx.Keyfile=StockOut.number and GoodsNumber='"+e.Item.Cells[13].Text+"'";
				OleDbDataReader NewReader_money_3 = List.GetList(SQL_money_3);
				if(NewReader_money_3.Read())
				{
					try
					{
						e.Item.Cells[5].Text=null;
						e.Item.Cells[5].Text+=NewReader_money_3.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[5].Text=null;
						e.Item.Cells[5].Text+="0";
							
					}
					NewReader_money_3.Close();
				}


				string    SQL_money_4     =  " SELECT SUM(SellOutMx.StockPoint) AS "+"sum"+"  from SellOutMx ,SellOut  where   (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废') and  SellOutMx.Keyfile=SellOut.number and GoodsNumber='"+e.Item.Cells[13].Text+"'";
				OleDbDataReader NewReader_money_4 = List.GetList(SQL_money_4);
				if(NewReader_money_4.Read())
				{
					try
					{
						e.Item.Cells[6].Text=null;
						e.Item.Cells[6].Text+=NewReader_money_4.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[6].Text=null;
						e.Item.Cells[6].Text+="0";
							
					}
					NewReader_money_4.Close();
				}




				string    SQL_money_5     =  " SELECT SUM(SellQuitMx.StockPoint) AS "+"sum"+"  from SellQuitMx ,SellQuit  where   (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废') and  SellQuitMx.Keyfile=SellQuit.number and GoodsNumber='"+e.Item.Cells[13].Text+"'";
				OleDbDataReader NewReader_money_5 = List.GetList(SQL_money_5);
				if(NewReader_money_5.Read())
				{
					try
					{
						e.Item.Cells[7].Text=null;
						e.Item.Cells[7].Text+=NewReader_money_5.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[7].Text=null;
						e.Item.Cells[7].Text+="0";
							
					}
					NewReader_money_5.Close();
				}



				string    SQL_money_6     =  " SELECT SUM(IncomeRoomMx.StockPoint) AS "+"sum"+"  from IncomeRoomMx ,IncomeRoom  where   (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废') and  IncomeRoomMx.Keyfile=IncomeRoom.number and GoodsNumber='"+e.Item.Cells[13].Text+"'";
				OleDbDataReader NewReader_money_6 = List.GetList(SQL_money_6);
				if(NewReader_money_6.Read())
				{
					try
					{
						e.Item.Cells[8].Text=null;
						e.Item.Cells[8].Text+=NewReader_money_6.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[8].Text=null;
						e.Item.Cells[8].Text+="0";
							
					}
					NewReader_money_6.Close();
				}


				string    SQL_money_7     =  " SELECT SUM(OutRoomMx.StockPoint) AS "+"sum"+"  from OutRoomMx ,OutRoom  where   (State!='审批驳回' and State!='未执行'  and State!='驳回审核' and State!='正在审核' and State!='正在执行' and State!='作废') and  OutRoomMx.Keyfile=OutRoom.number and GoodsNumber='"+e.Item.Cells[13].Text+"'";
				OleDbDataReader NewReader_money_7 = List.GetList(SQL_money_7);
				if(NewReader_money_7.Read())
				{
					try
					{
						e.Item.Cells[9].Text=null;
						e.Item.Cells[9].Text+=NewReader_money_7.GetDecimal(0);
							
					}
					catch
					{
						e.Item.Cells[9].Text=null;
						e.Item.Cells[9].Text+="0";
							
					}
					NewReader_money_7.Close();
				}



			}
		}

		private void Imagebutton8_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
				Response.Redirect("BB_GoodsData_HW.aspx?str="+CreateMidSql()+"");
		}

		private void ImageButton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("BB_GoodsData_HW_show.aspx?see="+Datagrid2.SelectedItem.Cells[13].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}
	}
}
