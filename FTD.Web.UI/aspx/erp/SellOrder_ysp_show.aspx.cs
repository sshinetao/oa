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
	/// SellOrder_ysp_show 的摘要说明。
	/// </summary>
	public class SellOrder_ysp_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.DropDownList Ifopen;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox InvoiceType;
		protected System.Web.UI.WebControls.TextBox InvoiceNum;
		protected System.Web.UI.WebControls.TextBox QdTime;
		protected System.Web.UI.WebControls.TextBox OrderAdd;
		protected System.Web.UI.WebControls.TextBox LxAdd;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox ShTime;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.TextBox CompanyAdd;
		protected System.Web.UI.WebControls.TextBox BankNumber;
		protected System.Web.UI.WebControls.TextBox TaxNumber;
		protected System.Web.UI.WebControls.TextBox Bank;
		protected System.Web.UI.WebControls.TextBox Tel;
		protected System.Web.UI.WebControls.TextBox LxPeople;
		protected System.Web.UI.WebControls.TextBox DlPeople;
		protected System.Web.UI.WebControls.TextBox Unit;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox YxStarttime;
		protected System.Web.UI.WebControls.TextBox YxEndtime;
		protected System.Web.UI.WebControls.TextBox Discount;
		protected System.Web.UI.WebControls.TextBox AllMoney;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		Db List=new Db();
		public static string Gusername,Grealname,Gname;
		protected System.Web.UI.WebControls.TextBox Realname;
		protected System.Web.UI.WebControls.TextBox Sreakmart;
		protected System.Web.UI.WebControls.TextBox SpCz;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from SellOrder_sp  where id='" + int.Parse(Request.QueryString["id"])+"'";
			
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					number.Text=NewReader["number"].ToString();
					
					title.Text=NewReader["title"].ToString();
				

					Type.Text=NewReader["Type"].ToString();
					InvoiceType.Text=NewReader["InvoiceType"].ToString();

					InvoiceNum.Text=NewReader["InvoiceNum"].ToString();

					QdTime.Text=NewReader["QdTime"].ToString();
					OrderAdd.Text=NewReader["OrderAdd"].ToString();

					LxAdd.Text=NewReader["LxAdd"].ToString();
					Storeroom.Text=NewReader["Storeroom"].ToString();
					ShTime.Text=NewReader["ShTime"].ToString();

					CompanyNumber.Text=NewReader["CompanyNumber"].ToString();				
					CompanyName.Text=NewReader["CompanyName"].ToString();
					CompanyAdd.Text=NewReader["CompanyAdd"].ToString();		
		
					BankNumber.Text=NewReader["BankNumber"].ToString();				
					TaxNumber.Text=NewReader["TaxNumber"].ToString();
					Bank.Text=NewReader["Bank"].ToString();	


					Tel.Text=NewReader["Tel"].ToString();				
					LxPeople.Text=NewReader["LxPeople"].ToString();
					DlPeople.Text=NewReader["DlPeople"].ToString();	


					Unit.Text=NewReader["Unit"].ToString();					
					StockPeoNum.Text=NewReader["StockPeoNum"].ToString();	
					StockPeoName.Text=NewReader["StockPeoName"].ToString();	

					YxStarttime.Text=NewReader["YxStarttime"].ToString();				
					YxEndtime.Text=NewReader["YxEndtime"].ToString();
					Discount.Text=NewReader["Discount"].ToString();	
					Remark.Text=NewReader["Remark"].ToString();	

					Realname.Text=NewReader["Realname"].ToString();	
					SpCz.Text=NewReader["SpCz"].ToString();	
						Sreakmart.Text=NewReader["Sreakmart"].ToString();	


					AllMoney.Text=NewReader["AllMoney"].ToString();				

				
				

					StreamNumber.Text=NewReader["StreamNumber"].ToString();
					StreamName.Text=NewReader["StreamName"].ToString();

				
				}

			}

			
			string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+" from SellOrderMx  where Keyfile='"+number.Text+"'";
			OleDbDataReader NewReader_money = List.GetList(SQL_money_);
			if(NewReader_money.Read())
			{
				try
				{
					this.AllMoney.Text=null;
					this.AllMoney.Text+=NewReader_money.GetDecimal(0);
										
				}
				catch
				{
					this.AllMoney.Text=null;
					this.AllMoney.Text+="0";
										
				}
				NewReader_money.Close();
			}//得到产品消费成本价

			string SQL_GetList_xs    =  "select * from SellOrderMx where  Keyfile='"+number.Text+"'  order by id desc";
			Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
			Datagrid2.DataBind();
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
			Response.Redirect("SellOrder_sp.aspx");
		}
	}
}
