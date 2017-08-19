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
	/// StockOrder_sp_check 的摘要说明。
	/// </summary>
	public class StockOrder_sp_check : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.DropDownList Ifopen;
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
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.DropDownList Ifts;
		protected System.Web.UI.WebControls.DropDownList bhuser;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.TextBox OrderRemark;
		protected System.Web.UI.WebControls.TextBox Sreakmart;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Grealname;
		protected System.Web.UI.WebControls.TextBox Gname;
		protected System.Web.UI.WebControls.TextBox Gusername;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		protected System.Web.UI.WebControls.TextBox Name;
		Db List=new Db();
		protected System.Web.UI.WebControls.TextBox username;
		BindDrowDownList list=new BindDrowDownList();
		protected System.Web.UI.WebControls.TextBox realname;
			public static string nbxx_num;
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{

				Random g  = new Random();
				string rad=g.Next(10000).ToString();

				nbxx_num=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+System.DateTime.Now.Hour.ToString()+""+System.DateTime.Now.Minute.ToString()+""+System.DateTime.Now.Second.ToString()+""+System.DateTime.Now.Millisecond.ToString()+""+rad+"";

				string    SQL_GetList     =  "select * from StockOrder  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					number.Text=NewReader["number"].ToString();
					
					title.Text=NewReader["title"].ToString();
				

					Type.Text=NewReader["Type"].ToString();
					NbNumber.Text=NewReader["NbNumber"].ToString();

					QdTime.Text=NewReader["QdTime"].ToString();
					OrderRemark.Text=NewReader["OrderRemark"].ToString();
					OrderAdd.Text=NewReader["OrderAdd"].ToString();

					LxAdd.Text=NewReader["LxAdd"].ToString();
					Storeroom.Text=NewReader["Storeroom"].ToString();
					ShTime.Text=NewReader["ShTime"].ToString();
					CompanyNumber.Text=NewReader["CompanyNumber"].ToString();				
					CompanyName.Text=NewReader["CompanyName"].ToString();
					CompanyAdd.Text=NewReader["CompanyAdd"].ToString();				
					Unit.Text=NewReader["Unit"].ToString();					
					StockPeoNum.Text=NewReader["StockPeoNum"].ToString();	
					StockPeoName.Text=NewReader["StockPeoName"].ToString();	
					AllMoney.Text=NewReader["AllMoney"].ToString();		
					Name.Text=NewReader["title"].ToString();			
					username.Text=NewReader["username"].ToString();	
					realname.Text=NewReader["realname"].ToString();	

				
				

					StreamNumber.Text=NewReader["StreamNumber"].ToString();
					StreamName.Text=NewReader["StreamName"].ToString();



					Gusername.Text=NewReader["Gusername"].ToString();
					Grealname.Text=NewReader["Grealname"].ToString();
					Gname.Text=NewReader["Gname"].ToString();
					Sreakmart.Text=NewReader["Sreakmart"].ToString();
				
				}

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
			string sql_down_bh="select top 1000 * from Cgdd_WorkStreamName where id<(select id from Cgdd_WorkStreamName where KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+Gname.Text+"' and username='"+Gusername.Text+"') and KeyFile='"+StreamNumber.Text+"' order by id asc";
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
			
			if(Ifts.SelectedValue=="否")
			{
				if(bhuser.SelectedValue=="启始位置")
				{

					string sql_insert1="insert into StockOrderlog_lc  values('"+this.Session["TrueName"]+"将采购订单["+Name.Text+"]驳回给录入人','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);

					string Sql_update ="Update StockOrder  Set Gname='"+Gname.Text+"',Grealname='"+this.Session["TrueName"]+"',Gusername='"+this.Session["TrueName"]+"',State='驳回审核',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);


				}
				else
				{
				

					string    SQL_GetList     =  "select * from Cgdd_WorkStreamName  where  KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+bhuser.SelectedItem.Text+"' and username='"+bhuser.SelectedValue+"'";
					OleDbDataReader NewReader = List.GetList(SQL_GetList);
					if(NewReader.Read())
					{
						string sql_insert1="insert into StockOrderlog_lc  values('"+this.Session["TrueName"]+"将采购订单["+Name.Text+"]驳回到节点"+bhuser.SelectedItem.Text+"','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
						List.ExeSql(sql_insert1);

						string Sql_update ="Update StockOrder  Set Gname='"+bhuser.SelectedItem.Text+"',Grealname='"+NewReader["realname"].ToString()+"',Gusername='"+bhuser.SelectedValue+"',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
						List.ExeSql(Sql_update);
					}
					else
					{
				
					}
			

				}


				string sql_insert=" insert into StockOrder_sp  (number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,MyTimes,Ifopen,Spusername,Sprealname) select number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'驳回','"+Sreakmart.Text+"',MyTimes,Ifopen,'"+this.Session["username"]+"','"+this.Session["TrueName"]+"' from  StockOrder where  id='" + int.Parse(Request.QueryString["id"])+"'";
				List.ExeSql(sql_insert);
				//Response.Write(sql_insert);


			}
			else
			{

			

				string    SQL_GetList     =  "select top 1 * from Cgdd_WorkStreamName where id>(select id from Cgdd_WorkStreamName where KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+Gname.Text+"' and username='"+Gusername.Text+"') and KeyFile='"+StreamNumber.Text+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					string sql_insert1="insert into StockOrderlog_lc  values('"+this.Session["TrueName"]+"通过采购订单["+Name.Text+"]的审批，节点状态为："+NewReader["Name_Jd"].ToString()+"','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);

					string Sql_update ="Update StockOrder  Set Gname='"+NewReader["Name_Jd"].ToString()+"',Grealname='"+NewReader["realname"].ToString()+"',Gusername='"+NewReader["username"].ToString()+"' ,Sreakmart='"+Sreakmart.Text+"',State='正在审核'   where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);
				}
				else
				{
				



					string sql_insert1="insert into StockOrderlog_lc  values('"+this.Session["TrueName"]+"通过采购订单["+Name.Text+"]的审批，节点状态为：完成审核','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);



					string Sql_update ="Update StockOrder  Set Gname='完成审核',Grealname='完成审核',Gusername='完成审核',State='完成审核',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);

					string insert_xx="insert into nbdxx values('采购订单["+Name.Text+"]通过审批','采购订单["+Name.Text+"]通过审批\n通过时间："+System.DateTime.Now.ToString()+"','"+System.DateTime.Now.ToString()+"','"+username.Text+"','"+realname.Text+"','系统消息','系统消息','否','"+nbxx_num+"')";
					List.ExeSql(insert_xx);




					//Response.Write(sql_insert);


				
				}

				string sql_insert=" insert into StockOrder_sp  (number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,MyTimes,Ifopen,Spusername,Sprealname) select number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'通过','"+Sreakmart.Text+"',MyTimes,Ifopen,'"+this.Session["username"]+"','"+this.Session["TrueName"]+"' from  StockOrder where  id='" + int.Parse(Request.QueryString["id"])+"'";
				List.ExeSql(sql_insert);
			}
			this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='StockOrder_sp.aspx'</script>");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("StockOrder_sp.aspx");
		}
	}
}
