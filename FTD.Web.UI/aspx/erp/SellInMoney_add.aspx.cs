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
	/// SellInMoney_add 的摘要说明。
	/// </summary>
	public class SellInMoney_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox JbPeoNum;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.TextBox State;
		protected System.Web.UI.WebControls.TextBox IncomeSet;
		protected System.Web.UI.WebControls.TextBox FkMoney;
		protected System.Web.UI.WebControls.TextBox Outtime;
		protected System.Web.UI.WebControls.TextBox SyMoney;
		protected System.Web.UI.WebControls.TextBox InvoiceType;
		protected System.Web.UI.WebControls.TextBox JbName;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.TextBox Textbox1;
		protected System.Web.UI.WebControls.DropDownList Ifopen;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox Textbox2;
		protected System.Web.UI.WebControls.TextBox InvoiceNum;
		protected System.Web.UI.WebControls.TextBox QdTime;
		protected System.Web.UI.WebControls.TextBox OrderAdd;
		protected System.Web.UI.WebControls.TextBox LxAdd;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox ShTime;
		protected System.Web.UI.WebControls.TextBox Textbox3;
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
		protected System.Web.UI.WebControls.TextBox Textbox4;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox CgStreamNumber;
		Db List=new Db();
		public static string Gusername,Grealname,Gname;
		protected System.Web.UI.WebControls.TextBox YjMoney;
		protected System.Web.UI.WebControls.TextBox realname;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:drdd();"); 
				this.ImageButton3.Attributes.Add("onclick","javascript:return chknull();"); 
			
			}


			string    SQL_GetList     =  "select * from SellOrder  where number='" +number.Text+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				number.Text=NewReader["number"].ToString();
					
				Textbox1.Text=NewReader["title"].ToString();
				

				Type.Text=NewReader["Type"].ToString();
				Textbox2.Text=NewReader["InvoiceType"].ToString();

				InvoiceNum.Text=NewReader["InvoiceNum"].ToString();

				QdTime.Text=NewReader["QdTime"].ToString();
				OrderAdd.Text=NewReader["OrderAdd"].ToString();

				LxAdd.Text=NewReader["LxAdd"].ToString();
				Storeroom.Text=NewReader["Storeroom"].ToString();
				ShTime.Text=NewReader["ShTime"].ToString();

			//	CompanyNumber.Text=NewReader["CompanyNumber"].ToString();				
				Textbox3.Text=NewReader["CompanyName"].ToString();
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




				AllMoney.Text=NewReader["AllMoney"].ToString();				

				
				

				//Textbox4.Text=NewReader["StreamNumber"].ToString();
				Textbox4.Text=NewReader["StreamName"].ToString();



				realname.Text=NewReader["realname"].ToString();

				State.Text=NewReader["State"].ToString();
				YjMoney.Text=NewReader["YjMoney"].ToString();
				
			}
			else
			{
				number.Text=null;
					
				Textbox1.Text=null;
				

				Type.Text=null;
				Textbox2.Text=null;
				InvoiceNum.Text=null;

				QdTime.Text=null;
				OrderAdd.Text=null;

				LxAdd.Text=null;
				Storeroom.Text=null;
				ShTime.Text=null;

				//CompanyNumber.Text=null;
				Textbox3.Text=null;
				CompanyAdd.Text=null;
		
				BankNumber.Text=null;
				TaxNumber.Text=null;
				Bank.Text=null;


				Tel.Text=null;
				LxPeople.Text=null;
				DlPeople.Text=null;


				Unit.Text=null;
				StockPeoNum.Text=null;
				StockPeoName.Text=null;

				YxStarttime.Text=null;
				YxEndtime.Text=null;
				Discount.Text=null;
				Remark.Text=null;




				AllMoney.Text=null;

				
				

				//Textbox4.Text=NewReader["StreamNumber"].ToString();
				Textbox4.Text=null;


				realname.Text=null;

				State.Text=null;
				YjMoney.Text=null;
			
			
			}



			string SQL_GetList_xs    =  "select * from SellOrderMx where  Keyfile='"+number.Text+"' order by id desc";
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
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}

		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{


			string    SQL_GetList     =  "select top 1 * from Xssk_WorkStreamName  where KeyFile='"+StreamNumber.Text+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				Gusername=NewReader["username"].ToString();
				Grealname=NewReader["realname"].ToString();
				Gname=NewReader["Name_Jd"].ToString();


				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增[采购收款]','采购收款','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);

			
				string sql_insert1="insert into SellInMoneylog_lc values('"+this.Session["TrueName"]+"新增了采购收款["+title.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"]','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
				List.ExeSql(sql_insert1);

				string sql_insert_order=" insert into SellInMoney_Order (number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes,Ifopen)  select number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes,Ifopen  from  StockOrder   where number='"+number.Text.ToString()+"'";
				List.ExeSql(sql_insert_order);//采购付款对应订单
				

				//				decimal  yfje=System.Decimal.Parse(YfMoney.Text)+System.Decimal.Parse(FkMoney.Text);
				//				string Sql_update_dd ="Update StockOrder Set YfMoney='"+yfje+"' where  number='" + number.Text+"'";
				//				List.ExeSql(Sql_update_dd);//得到已付



				//decimal syje=System.Decimal.Parse(AllMoney.Text)-System.Decimal.Parse(YfMoney.Text)-System.Decimal.Parse(FkMoney.Text);


				string sql_insert="insert into SellInMoney  (number,title,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,MyTimes) values('"+number.Text+"','"+title.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"','"+Type.Text+"','"+AllMoney.Text+"','"+Outtime.Text+"','"+IncomeSet.Text+"','"+FkMoney.Text+"','"+SyMoney.Text+"','"+InvoiceType.Text+"','"+CompanyNumber.Text+"','"+CompanyName.Text+"','"+JbPeoNum.Text+"','"+JbName.Text+"','等待审核','"+this.Session["username"].ToString()+"','"+this.Session["TrueName"].ToString()+"','"+System.DateTime.Now.ToString()+"','"+StreamNumber.Text+"','"+StreamName.Text+"','"+Gusername+"','"+Grealname+"','"+Gname+"','"+this.Session["MyTimes"]+"')";
				List.ExeSql(sql_insert);
				//Response.Write(sql_insert);




				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='SellInMoney.aspx'</script>");

			}
			else
			{
				this.Response.Write("<script language=javascript>alert('此工作流；未找到对应的流程！操作失败');</script>");
				return;
			
			}
		}
	}
}
