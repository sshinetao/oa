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
	/// StockOutMoney_sp_check 的摘要说明。
	/// </summary>
	public class StockOutMoney_sp_check : System.Web.UI.Page
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
		protected System.Web.UI.WebControls.TextBox realname;
		protected System.Web.UI.WebControls.DropDownList Ifts;
		protected System.Web.UI.WebControls.DropDownList bhuser;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.TextBox Sreakmart;
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
		protected System.Web.UI.WebControls.TextBox lrrealname;
		protected System.Web.UI.WebControls.TextBox CgStreamName;
		protected System.Web.UI.WebControls.TextBox OrderRemark;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Grealname;
		protected System.Web.UI.WebControls.TextBox Gname;
		protected System.Web.UI.WebControls.TextBox Gusername;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.TextBox username;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox CgStreamNumber;
		Db List=new Db();
		BindDrowDownList list=new BindDrowDownList();
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		public static string nbxx_num;
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!IsPostBack)
			{
				string    SQL_GetList_fk     =  "select * from StockOutMoney  where id='" +int.Parse(Request.QueryString["id"])+"'";
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

					CompanyName.Text=NewReader_fk["CompanyName"].ToString();
					JbPeoNum.Text=NewReader_fk["JbPeoNum"].ToString();
					JbName.Text=NewReader_fk["JbName"].ToString();
					StreamNumber.Text=NewReader_fk["StreamNumber"].ToString();
					StreamName.Text=NewReader_fk["StreamName"].ToString();



					username.Text=NewReader_fk["username"].ToString();	
					realname.Text=NewReader_fk["realname"].ToString();	
					Name.Text=NewReader_fk["title"].ToString();	
					Gusername.Text=NewReader_fk["Gusername"].ToString();
					Grealname.Text=NewReader_fk["Grealname"].ToString();
					Gname.Text=NewReader_fk["Gname"].ToString();
					Sreakmart.Text=NewReader_fk["Sreakmart"].ToString();
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
				lrrealname.Text=NewReader["realname"].ToString();

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
				lrrealname.Text=null;

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



			//驳回
			string sql_down_bh="select top 1000 * from Cgfk_WorkStreamName where id<(select id from Cgfk_WorkStreamName where KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+Gname.Text+"' and username='"+Gusername.Text+"') and KeyFile='"+StreamNumber.Text+"'";
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
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
			Response.Redirect("StockOutMoney_sp.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			if(Ifts.SelectedValue=="否")
			{
				if(bhuser.SelectedValue=="启始位置")
				{

					string sql_insert1="insert into StockOutlog_lc  values('"+this.Session["TrueName"]+"将采购付款["+Name.Text+"]驳回给录入人','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);

					string Sql_update ="Update StockOutMoney  Set Gname='驳回审核',Grealname='驳回审核',Gusername='驳回审核',State='驳回审核',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);


				}
				else
				{
				

					string    SQL_GetList     =  "select * from Cgfk_WorkStreamName  where  KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+bhuser.SelectedItem.Text+"' and username='"+bhuser.SelectedValue+"'";
					OleDbDataReader NewReader = List.GetList(SQL_GetList);
					if(NewReader.Read())
					{
						string sql_insert1="insert into StockOutMoneylog_lc  values('"+this.Session["TrueName"]+"将采购付款["+Name.Text+"]驳回到节点"+bhuser.SelectedItem.Text+"','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
						List.ExeSql(sql_insert1);

						string Sql_update ="Update StockOutMoney  Set Gname='"+bhuser.SelectedItem.Text+"',Grealname='"+NewReader["realname"].ToString()+"',Gusername='"+bhuser.SelectedValue+"',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
						List.ExeSql(Sql_update);
					}
					else
					{
				
					}
			

				}


				string sql_insert=" insert into StockOutMoney_sp  (number,title,NbNumber,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,NbNumber,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'驳回','"+Sreakmart.Text+"','"+this.Session["username"]+"','"+this.Session["TrueName"]+"',MyTimes from  StockOutMoney where  id='" + int.Parse(Request.QueryString["id"])+"'";
				List.ExeSql(sql_insert);
				
				//this.Response.Write("<script language=javascript>alert('提交成功！\n拒绝审批');window.location.href='StockOut_sp.aspx'</script>");
				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'StockOutMoney_sp.aspx'</script>");
			
			
			}
			else
			{

			

				string    SQL_GetList     =  "select top 1 * from Cgfk_WorkStreamName where id>(select id from Cgfk_WorkStreamName where KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+Gname.Text+"' and username='"+Gusername.Text+"') and KeyFile='"+StreamNumber.Text+"' order by id asc";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					string sql_insert1="insert into StockOutMoneylog_lc  values('"+this.Session["TrueName"]+"通过采购付款["+Name.Text+"]的审批，节点状态为："+NewReader["Name_Jd"].ToString()+"','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);

					string Sql_update ="Update StockOutMoney  Set Gname='"+NewReader["Name_Jd"].ToString()+"',Grealname='"+NewReader["realname"].ToString()+"',Gusername='"+NewReader["username"].ToString()+"' ,Sreakmart='"+Sreakmart.Text+"',State='正在审核'   where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);

					//Response.Write(SQL_GetList);

					this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'StockOutMoney_sp.aspx'</script>");
				}
				else
				{
				
					string sql_insert1="insert into StockOutMoneylog_lc  values('"+this.Session["TrueName"]+"通过采购付款["+Name.Text+"]的审批，节点状态为：完成审核','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);



					string Sql_update ="Update StockOutMoney  Set Gname='完成审核',Grealname='完成审核',Gusername='完成审核',State='完成审核',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);

					string insert_xx="insert into nbdxx values('采购付款["+Name.Text+"]通过审批','采购付款["+Name.Text+"]通过审批\n通过时间："+System.DateTime.Now.ToString()+"','"+System.DateTime.Now.ToString()+"','"+username.Text+"','"+realname.Text+"','系统消息','系统消息','否','"+nbxx_num+"')";
					List.ExeSql(insert_xx);



					decimal  yfje=System.Decimal.Parse(YfMoney.Text)+System.Decimal.Parse(FkMoney.Text);
					
					string Sql_update_dd ="Update StockOrder Set YfMoney='"+yfje+"' where  number='" + number.Text+"'";
									
					List.ExeSql(Sql_update_dd);


				


			
				}

				string sql_insert=" insert into StockOutMoney_sp  (number,title,NbNumber,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,NbNumber,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'通过','"+Sreakmart.Text+"','"+this.Session["username"]+"','"+this.Session["TrueName"]+"',MyTimes from  StockOutMoney where  id='" + int.Parse(Request.QueryString["id"])+"'";
				List.ExeSql(sql_insert);
			

			this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'StockOutMoney_sp.aspx'</script>");
			}
		}
	}
}
