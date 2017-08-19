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
	/// StockOutMoney_add 的摘要说明。
	/// </summary>
	public class StockOutMoney_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox NbNumber;
		protected System.Web.UI.WebControls.TextBox QdTime;
		protected System.Web.UI.WebControls.TextBox OrderAdd;
		protected System.Web.UI.WebControls.TextBox LxAdd;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox ShTime;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.TextBox CompanyAdd;
		protected System.Web.UI.WebControls.TextBox Unit;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox AllMoney;
		protected System.Web.UI.WebControls.TextBox OrderRemark;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		Db List=new Db();
		public static string Gusername,Grealname,Gname;
		protected System.Web.UI.WebControls.TextBox realname;
		protected System.Web.UI.WebControls.TextBox State;
		protected System.Web.UI.WebControls.TextBox YfMoney;
		protected System.Web.UI.WebControls.TextBox JbName;
		protected System.Web.UI.WebControls.TextBox JbPeoNum;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox FkMoney;
		protected System.Web.UI.WebControls.TextBox InvoiceType;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.TextBox CgStreamName;
		protected System.Web.UI.WebControls.TextBox CgStreamNumber;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		protected System.Web.UI.WebControls.TextBox Outtime;
		protected System.Web.UI.WebControls.TextBox SyMoney;
		protected System.Web.UI.WebControls.TextBox IncomeSet;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
		

			if(!IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:drdd();"); 
					this.ImageButton3.Attributes.Add("onclick","javascript:return chknull();"); 
			
			}


			string    SQL_GetList     =  "select * from StockOrder  where number='" +number.Text+"'";
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
				realname.Text=NewReader["realname"].ToString();

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
				CgStreamName.Text=null;
			
			
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


			string    SQL_GetList     =  "select top 1 * from Cgfk_WorkStreamName  where KeyFile='"+StreamNumber.Text+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				Gusername=NewReader["username"].ToString();
				Grealname=NewReader["realname"].ToString();
				Gname=NewReader["Name_Jd"].ToString();


				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增[采购付款]','采购付款','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);

			
				string sql_insert1="insert into StockOutMoneylog_lc values('"+this.Session["TrueName"]+"新增了采购付款["+title.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"]','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
				List.ExeSql(sql_insert1);

				string sql_insert_order=" insert into StockOutMoney_Order (number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes,Ifopen)  select number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes,Ifopen  from  StockOrder   where number='"+number.Text.ToString()+"'";
				List.ExeSql(sql_insert_order);//采购付款对应订单
				

//				decimal  yfje=System.Decimal.Parse(YfMoney.Text)+System.Decimal.Parse(FkMoney.Text);
//				string Sql_update_dd ="Update StockOrder Set YfMoney='"+yfje+"' where  number='" + number.Text+"'";
//				List.ExeSql(Sql_update_dd);//得到已付



				//decimal syje=System.Decimal.Parse(AllMoney.Text)-System.Decimal.Parse(YfMoney.Text)-System.Decimal.Parse(FkMoney.Text);


				string sql_insert="insert into StockOutMoney  (number,title,NbNumber,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,MyTimes) values('"+number.Text+"','"+title.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"','"+NbNumber.Text+"','"+Type.Text+"','"+AllMoney.Text+"','"+Outtime.Text+"','"+IncomeSet.Text+"','"+FkMoney.Text+"','"+SyMoney.Text+"','"+InvoiceType.Text+"','"+CompanyNumber.Text+"','"+CompanyName.Text+"','"+JbPeoNum.Text+"','"+JbName.Text+"','等待审核','"+this.Session["username"].ToString()+"','"+this.Session["TrueName"].ToString()+"','"+System.DateTime.Now.ToString()+"','"+StreamNumber.Text+"','"+StreamName.Text+"','"+Gusername+"','"+Grealname+"','"+Gname+"','"+this.Session["MyTimes"]+"')";
				List.ExeSql(sql_insert);
				//Response.Write(sql_insert);




			this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='StockOutMoney.aspx'</script>");

			}
			else
			{
				this.Response.Write("<script language=javascript>alert('此工作流；未找到对应的流程！操作失败');</script>");
				return;
			
			}
		}
	}
}
