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
	/// SellInMoney_update 的摘要说明。
	/// </summary>
	public class SellInMoney_update : System.Web.UI.Page
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


			if(!IsPostBack)
			{
				string    SQL_GetList1    =  "select * from SellInMoney  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader1 = List.GetList(SQL_GetList1);
				if(NewReader1.Read())
				{
				
					number.Text=NewReader1["number"].ToString();
					title.Text=NewReader1["title"].ToString();
		
					Type.Text=NewReader1["Type"].ToString();
					//Allmoney.Text=NewReader1["Allmoney"].ToString();
                    string outtime = NewReader1["Outtime"].ToString() + "" == "" ? DateTime.Now.ToLocalTime().ToString() : NewReader1["Outtime"].ToString();
                    Outtime.Text = System.DateTime.Parse(outtime).ToShortDateString();
					IncomeSet.Text=NewReader1["IncomeSet"].ToString();
					FkMoney.Text=NewReader1["FkMoney"].ToString();
					SyMoney.Text=NewReader1["SyMoney"].ToString();
					InvoiceType.Text=NewReader1["InvoiceType"].ToString();
					CompanyNumber.Text=NewReader1["CompanyNumber"].ToString();


					CompanyName.Text=NewReader1["CompanyName"].ToString();
					JbPeoNum.Text=NewReader1["JbPeoNum"].ToString();
					JbName.Text=NewReader1["JbName"].ToString();
					State.Text=NewReader1["number"].ToString();
					







					StreamNumber.Text=NewReader1["StreamNumber"].ToString();
					StreamName.Text=NewReader1["StreamName"].ToString();
				
				}

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

				QdTime.Text=System.DateTime.Parse(NewReader["QdTime"].ToString()).ToShortDateString();
				OrderAdd.Text=NewReader["OrderAdd"].ToString();

				LxAdd.Text=NewReader["LxAdd"].ToString();
				Storeroom.Text=NewReader["Storeroom"].ToString();
				ShTime.Text=System.DateTime.Parse(NewReader["ShTime"].ToString()).ToShortDateString();

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

				YxStarttime.Text=System.DateTime.Parse(NewReader["YxStarttime"].ToString()).ToShortDateString();				
				YxEndtime.Text=System.DateTime.Parse(NewReader["YxEndtime"].ToString()).ToShortDateString();
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
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
		
		
				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('修改[销售收款]','销售收款','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);
		
					
				string sql_insert1="insert into SellInMoneylog_lc values('"+this.Session["TrueName"]+"修改了销售收款["+title.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"]','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
				List.ExeSql(sql_insert1);
		
		
				string Sql_update ="Update SellInMoney Set title='"+title.Text+"',Type='"+Type.Text+"',Allmoney='"+AllMoney.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',Outtime='"+Outtime.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',IncomeSet='"+IncomeSet.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',FkMoney='"+FkMoney.Text+"',SyMoney='"+SyMoney.Text+"',InvoiceType='"+InvoiceType.Text+"',CompanyNumber='"+CompanyNumber.Text+"',CompanyName='"+CompanyName.Text+"',JbPeoNum='"+JbPeoNum.Text+"',JbName='"+JbName.Text+"',MyTimes='"+this.Session["MyTimes"]+"',StreamNumber='"+StreamNumber.Text+"',StreamName='"+StreamName.Text+"',Gusername='"+Gusername+"',Grealname='"+Grealname+"',Gname='"+Gname+"',Username='"+this.Session["Username"]+"',Realname='"+this.Session["TrueName"]+"',State='等待审批' where id='" + int.Parse(Request.QueryString["id"])+"'";
				
				List.ExeSql(Sql_update);


		
				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='SellInMoney.aspx'</script>");
		
			}
			else
			{
				this.Response.Write("<script language=javascript>alert('此工作流；未找到对应的流程！操作失败');</script>");
				return;
					
			}
		
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("SellInMoney.aspx");
		}
	}
}
