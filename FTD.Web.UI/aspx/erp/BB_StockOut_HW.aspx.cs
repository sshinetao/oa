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
	/// BB_StockOut_HW ��ժҪ˵����
	/// </summary>
	public class BB_StockOut_HW : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Starttime;
		protected System.Web.UI.WebControls.TextBox Endtime;
		Db List=new Db();
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.DropDownList Stocktype;
		public static decimal  allmoney;
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.GoodsName.Text.Trim() != "")
			{
				MidSql=MidSql+" and StockOutMx.GoodsName like '%"+this.GoodsName.Text.Trim()+"%'";
			}




	
			if (this.Starttime.Text.Trim() != "" && this.Endtime.Text.Trim() != "")
			{
				MidSql=MidSql+" and (StockOutMx.Nowtimes between '"+this.Starttime.Text+"' and  '"+this.Endtime.Text+"' or convert(char(10),cast(StockOutMx.Nowtimes as datetime),120)=convert(char(10),cast('"+this.Starttime.Text+"' as datetime),120) or convert(char(10),cast(StockOutMx.Nowtimes as datetime),120)=convert(char(10),cast('"+this.Endtime.Text+"' as datetime),120)) ";
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
				string SQL_GetList_xs    =  "select StockOutMx.* ,StockOut.title from StockOutMx,StockOut where StockOutMx.Keyfile=StockOut.number "+Server.UrlDecode(Request.QueryString["str"])+" ";

				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

				string    SQL_money_     =  " SELECT SUM(StockOutMx.Allmoney) AS "+"sum"+"  from StockOutMx ,StockOut  where StockOutMx.Keyfile=StockOut.number  "+Server.UrlDecode(Request.QueryString["str"])+" ";
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
			
				string SQL_GetList_xs    =  "select StockOutMx.*  ,StockOut.title from StockOutMx,StockOut where StockOutMx.Keyfile=StockOut.number order by StockOutMx.id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
	


				string    SQL_money_     =  " SELECT SUM(StockOutMx.Allmoney) AS "+"sum"+"  from StockOutMx ,StockOut  where StockOutMx.Keyfile=StockOut.number ";
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
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("BB_StockOut_HW.aspx?str="+CreateMidSql()+"");
		}



	}
}
