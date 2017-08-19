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
	/// SellInMoney_sp_check 的摘要说明。
	/// </summary>
	public class SellInMoney_sp_check : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox JbPeoNum;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		protected System.Web.UI.WebControls.TextBox title;
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
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox CgStreamNumber;
		Db List=new Db();
		BindDrowDownList list=new BindDrowDownList();
		public static string nbxx_num;
		protected System.Web.UI.WebControls.TextBox YjMoney;
		protected System.Web.UI.WebControls.TextBox Grealname;
		protected System.Web.UI.WebControls.TextBox Gname;
		protected System.Web.UI.WebControls.TextBox Gusername;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.TextBox username;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox Textbox5;
		protected System.Web.UI.WebControls.DropDownList Ifts;
		protected System.Web.UI.WebControls.DropDownList bhuser;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.TextBox Sreakmart;
		protected System.Web.UI.WebControls.TextBox realname;


        Decimal ConvertToDcm(string strValue)
        {
            try
            {
                return Decimal.Parse(strValue);
            }
            catch
            {
                return 0;
            }
        }


		private void Page_Load(object sender, System.EventArgs e)
		{


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
					

					username.Text=NewReader1["username"].ToString();	
					Textbox5.Text=NewReader1["realname"].ToString();	
					Name.Text=NewReader1["title"].ToString();	
					Gusername.Text=NewReader1["Gusername"].ToString();
					Grealname.Text=NewReader1["Grealname"].ToString();
					Gname.Text=NewReader1["Gname"].ToString();
					Sreakmart.Text=NewReader1["Sreakmart"].ToString();





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
                string shTime = NewReader["ShTime"].ToString() + "" == "" ? DateTime.Now.ToLocalTime().ToString() : NewReader["ShTime"].ToString();
                ShTime.Text = System.DateTime.Parse(shTime).ToShortDateString();

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

			//驳回
			string sql_down_bh="select top 1000 * from Xssk_WorkStreamName where id<(select id from Xssk_WorkStreamName where KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+Gname.Text+"' and username='"+Gusername.Text+"') and KeyFile='"+StreamNumber.Text+"'";
			//string sql_down_bh="select * from WorkStreamName";		
			if(!IsPostBack)
			{
				list.Bind_DropDownList_bh(bhuser,sql_down_bh,"username","Name_Jd");
			}

			if(Ifts.SelectedValue=="否")
			{
				Panel1.Visible=true;
			}
			else
			{
				Panel1.Visible=false;
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
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
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
			Response.Redirect("SellInMoney.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			if(Ifts.SelectedValue=="否")
			{
				if(bhuser.SelectedValue=="启始位置")
				{

					string sql_insert1="insert into SellInMoneylog_lc  values('"+this.Session["TrueName"]+"将销售收款["+Name.Text+"]驳回给录入人','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);

					string Sql_update ="Update SellInMoney  Set Gname='驳回审核',Grealname='驳回审核',Gusername='驳回审核',State='驳回审核',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);


				}
				else
				{
				

					string    SQL_GetList     =  "select * from Xssk_WorkStreamName  where  KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+bhuser.SelectedItem.Text+"' and username='"+bhuser.SelectedValue+"'";
					OleDbDataReader NewReader = List.GetList(SQL_GetList);
					if(NewReader.Read())
					{
						string sql_insert1="insert into SellInMoneylog_lc  values('"+this.Session["TrueName"]+"将销售收款["+Name.Text+"]驳回到节点"+bhuser.SelectedItem.Text+"','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
						List.ExeSql(sql_insert1);

						string Sql_update ="Update SellInMoney  Set Gname='"+bhuser.SelectedItem.Text+"',Grealname='"+NewReader["realname"].ToString()+"',Gusername='"+bhuser.SelectedValue+"',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
						List.ExeSql(Sql_update);
					}
					else
					{
				
					}
			

				}


				string sql_insert=" insert into SellInMoney_sp  (number,title,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'驳回','"+Sreakmart.Text+"','"+this.Session["username"]+"','"+this.Session["TrueName"]+"',MyTimes from  SellInMoney where  id='" + int.Parse(Request.QueryString["id"])+"'";
				List.ExeSql(sql_insert);
				
			
				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'SellInMoney_sp.aspx'</script>");
			
			
			}
			else
			{

			

				string    SQL_GetList     =  "select top 1 * from Xssk_WorkStreamName where id>(select id from Xssk_WorkStreamName where KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+Gname.Text+"' and username='"+Gusername.Text+"') and KeyFile='"+StreamNumber.Text+"' order by id asc";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					string sql_insert1="insert into SellInMoneylog_lc  values('"+this.Session["TrueName"]+"通过销售收款["+Name.Text+"]的审批，节点状态为："+NewReader["Name_Jd"].ToString()+"','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);

					string Sql_update ="Update SellInMoney  Set Gname='"+NewReader["Name_Jd"].ToString()+"',Grealname='"+NewReader["realname"].ToString()+"',Gusername='"+NewReader["username"].ToString()+"' ,Sreakmart='"+Sreakmart.Text+"',State='正在审核'   where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);

					//Response.Write(SQL_GetList);

					this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'SellInMoney_sp.aspx'</script>");
				}
				else
				{
				
					string sql_insert1="insert into SellInMoneylog_lc  values('"+this.Session["TrueName"]+"通过销售收款["+Name.Text+"]的审批，节点状态为：完成审核','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);



					string Sql_update ="Update SellInMoney  Set Gname='完成审核',Grealname='完成审核',Gusername='完成审核',State='完成审核',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);

					string insert_xx="insert into nbdxx values('销售收款["+Name.Text+"]通过审批','销售收款["+Name.Text+"]通过审批\n通过时间："+System.DateTime.Now.ToString()+"','"+System.DateTime.Now.ToString()+"','"+username.Text+"','"+realname.Text+"','系统消息','系统消息','否','"+nbxx_num+"')";
					List.ExeSql(insert_xx);



                    decimal yfje = ConvertToDcm(YjMoney.Text + "") + ConvertToDcm(FkMoney.Text + "");
					
					string Sql_update_dd ="Update SellOrder Set YjMoney='"+yfje+"' where  number='" + number.Text+"'";
									
					List.ExeSql(Sql_update_dd);


				


			
				}

				string sql_insert=" insert into SellInMoney_sp  (number,title,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'通过','"+Sreakmart.Text+"','"+this.Session["username"]+"','"+this.Session["TrueName"]+"',MyTimes from  SellInMoney where  id='" + int.Parse(Request.QueryString["id"])+"'";
				List.ExeSql(sql_insert);
			

				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'SellInMoney_sp.aspx'</script>");
			}
		}
	}
}