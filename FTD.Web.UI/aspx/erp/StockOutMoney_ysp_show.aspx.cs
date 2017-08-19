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
	/// StockOutMoney_ysp_show 的摘要说明。
	/// </summary>
	public class StockOutMoney_ysp_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox JbPeoNum;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.TextBox YfMoney;
		protected System.Web.UI.WebControls.TextBox State;
		protected System.Web.UI.WebControls.TextBox IncomeSet;
		protected System.Web.UI.WebControls.TextBox FkMoney;
		protected System.Web.UI.WebControls.TextBox Outtime;
		protected System.Web.UI.WebControls.TextBox SyMoney;
		protected System.Web.UI.WebControls.TextBox InvoiceType;
		protected System.Web.UI.WebControls.TextBox JbName;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox NbNumber;
		protected System.Web.UI.WebControls.TextBox QdTime;
		protected System.Web.UI.WebControls.TextBox OrderAdd;
		protected System.Web.UI.WebControls.TextBox LxAdd;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox ShTime;
		protected System.Web.UI.WebControls.TextBox Unit;
		protected System.Web.UI.WebControls.TextBox CompanyAdd;
		protected System.Web.UI.WebControls.TextBox AllMoney;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox CgStreamName;
		protected System.Web.UI.WebControls.TextBox OrderRemark;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox CgStreamNumber;
		Db List=new Db();
		public static string Gusername,Grealname,Gname;
		protected System.Web.UI.WebControls.TextBox realname;
		protected System.Web.UI.WebControls.TextBox ddrealname;
	
		private void Page_Load(object sender, System.EventArgs e)
		{

			if(!IsPostBack)
			{
				string    SQL_GetList_fk     =  "select * from StockOutMoney_sp  where id='" +int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader_fk = List.GetList(SQL_GetList_fk);
				if(NewReader_fk.Read())
				{
					number.Text=NewReader_fk["number"].ToString();
					title.Text=NewReader_fk["title"].ToString();

					NbNumber.Text=NewReader_fk["NbNumber"].ToString();
					Type.Text=NewReader_fk["Type"].ToString();
					//	AllMoney.Text=NewReader_fk["Allmoney"].ToString();

					Outtime.Text=NewReader_fk["Outtime"].ToString();
					IncomeSet.Text=NewReader_fk["IncomeSet"].ToString();
					FkMoney.Text=NewReader_fk["FkMoney"].ToString();
					SyMoney.Text=NewReader_fk["SyMoney"].ToString();
					InvoiceType.Text=NewReader_fk["InvoiceType"].ToString();
					CompanyNumber.Text=NewReader_fk["CompanyNumber"].ToString();
					realname.Text=NewReader_fk["realname"].ToString();

					CompanyName.Text=NewReader_fk["CompanyName"].ToString();
					JbPeoNum.Text=NewReader_fk["JbPeoNum"].ToString();
					JbName.Text=NewReader_fk["JbName"].ToString();
					StreamNumber.Text=NewReader_fk["StreamNumber"].ToString();
					StreamName.Text=NewReader_fk["StreamName"].ToString();
				}
			}







			string    SQL_GetList     =  "select * from StockOutMoney_Order  where number='" +number.Text+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				Type.Text=NewReader["Type"].ToString();
				NbNumber.Text=NewReader["NbNumber"].ToString();

				QdTime.Text=NewReader["QdTime"].ToString();
				OrderRemark.Text=NewReader["OrderRemark"].ToString();
				OrderAdd.Text=NewReader["OrderAdd"].ToString();

				LxAdd.Text=NewReader["LxAdd"].ToString();
				Storeroom.Text=NewReader["Storeroom"].ToString();
				ShTime.Text=NewReader["ShTime"].ToString();

				CompanyAdd.Text=NewReader["CompanyAdd"].ToString();				
				Unit.Text=NewReader["Unit"].ToString();					
				StockPeoNum.Text=NewReader["StockPeoNum"].ToString();	
				StockPeoName.Text=NewReader["StockPeoName"].ToString();	
				AllMoney.Text=NewReader["AllMoney"].ToString();				
				CgStreamNumber.Text=NewReader["StreamNumber"].ToString();
				CgStreamName.Text=NewReader["StreamName"].ToString();
				ddrealname.Text=NewReader["realname"].ToString();

				State.Text=NewReader["State"].ToString();
				YfMoney.Text=NewReader["YfMoney"].ToString();
				
			}
			else
			{
				Type.Text=null;
				NbNumber.Text=null;

				QdTime.Text=null;
				OrderRemark.Text=null;
				OrderAdd.Text=null;

				LxAdd.Text=null;
				Storeroom.Text=null;
				ShTime.Text=null;

				CompanyAdd.Text=null;
				Unit.Text=null;			
				StockPeoNum.Text=null;
				StockPeoName.Text=null;
				AllMoney.Text=null;
				StreamNumber.Text=null;
				StreamName.Text=null;
				realname.Text=null;

				State.Text=null;
				YfMoney.Text=null;
			
			
			}

	

			string SQL_GetList_xs    =  "select * from StockOrderMx where  Keyfile='"+number.Text+"' order by id desc";
			Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
			Datagrid2.DataBind();


			
			string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+" from StockOrderMx  where Keyfile='"+number.Text+"'";
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
			Response.Redirect("StockOutMoney_ysp.aspx");
		}

	}
}
