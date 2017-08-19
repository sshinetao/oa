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
	/// StockOut_sp_sp 的摘要说明。
	/// </summary>
	public class StockOut_sp_sp : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox ShTime;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.TextBox CompanyAdd;
		protected System.Web.UI.WebControls.TextBox Traffic;
		protected System.Web.UI.WebControls.TextBox Balance;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.TextBox realname;
		protected System.Web.UI.WebControls.DropDownList Ifts;
		protected System.Web.UI.WebControls.DropDownList bhuser;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.TextBox Sreakmart;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Grealname;
		protected System.Web.UI.WebControls.TextBox Gname;
		protected System.Web.UI.WebControls.TextBox Gusername;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.TextBox username;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		Db List=new Db();
		BindDrowDownList list=new BindDrowDownList();
		public static string nbxx_num;
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from StockOut  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					number.Text=NewReader["number"].ToString();					
					title.Text=NewReader["title"].ToString();
					ShTime.Text=NewReader["ShTime"].ToString();
					StockPeoNum.Text=NewReader["StockPeoNum"].ToString();	
					StockPeoName.Text=NewReader["StockPeoName"].ToString();	
					Storeroom.Text=NewReader["Storeroom"].ToString();
					CompanyNumber.Text=NewReader["CompanyNumber"].ToString();				
					CompanyName.Text=NewReader["CompanyName"].ToString();
					CompanyAdd.Text=NewReader["CompanyAdd"].ToString();			
					Traffic.Text=NewReader["Traffic"].ToString();
					Balance.Text=NewReader["Balance"].ToString();
					Remark.Text=NewReader["Remark"].ToString();
					StreamNumber.Text=NewReader["StreamNumber"].ToString();
					StreamName.Text=NewReader["StreamName"].ToString();
					
					username.Text=NewReader["username"].ToString();	
					realname.Text=NewReader["realname"].ToString();	
					Name.Text=NewReader["title"].ToString();	
					Gusername.Text=NewReader["Gusername"].ToString();
					Grealname.Text=NewReader["Grealname"].ToString();
					Gname.Text=NewReader["Gname"].ToString();
					Sreakmart.Text=NewReader["Sreakmart"].ToString();
				
				}

			}




			string SQL_GetList_xs    =  "select * from StockOutMx where  Keyfile='"+number.Text+"' order by id desc";
			Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
			Datagrid2.DataBind();

			//驳回
			string sql_down_bh="select top 1000 * from Cgth_WorkStreamName where id<(select id from Cgth_WorkStreamName where KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+Gname.Text+"' and username='"+Gusername.Text+"') and KeyFile='"+StreamNumber.Text+"'";
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

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("StockOut_sp.aspx");
		}

		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{



			if(Ifts.SelectedValue=="否")
			{
				if(bhuser.SelectedValue=="启始位置")
				{

					string sql_insert1="insert into StockOutlog_lc  values('"+this.Session["TrueName"]+"将采购退货["+Name.Text+"]驳回给录入人','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);

					string Sql_update ="Update StockOut  Set Gname='驳回审核',Grealname='驳回审核',Gusername='驳回审核',State='驳回审核',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);


				}
				else
				{
				

					string    SQL_GetList     =  "select * from Cgth_WorkStreamName  where  KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+bhuser.SelectedItem.Text+"' and username='"+bhuser.SelectedValue+"'";
					OleDbDataReader NewReader = List.GetList(SQL_GetList);
					if(NewReader.Read())
					{
						string sql_insert1="insert into StockOutlog_lc  values('"+this.Session["TrueName"]+"将采购退货["+Name.Text+"]驳回到节点"+bhuser.SelectedItem.Text+"','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
						List.ExeSql(sql_insert1);

						string Sql_update ="Update StockOut  Set Gname='"+bhuser.SelectedItem.Text+"',Grealname='"+NewReader["realname"].ToString()+"',Gusername='"+bhuser.SelectedValue+"',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
						List.ExeSql(Sql_update);
					}
					else
					{
				
					}
			

				}


				string sql_insert=" insert into StockOut_sp  (number,title,ShTime,StockPeoNum,StockPeoName,Storeroom,CompanyNumber,CompanyName,CompanyAdd,Traffic,Balance,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,ShTime,StockPeoNum,StockPeoName,Storeroom,CompanyNumber,CompanyName,CompanyAdd,Traffic,Balance,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'驳回','"+Sreakmart.Text+"','"+this.Session["username"]+"','"+this.Session["TrueName"]+"',MyTimes from  StockOut where  id='" + int.Parse(Request.QueryString["id"])+"'";
				List.ExeSql(sql_insert);
				
				//this.Response.Write("<script language=javascript>alert('提交成功！\n拒绝审批');window.location.href='StockOut_sp.aspx'</script>");
				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'StockOut_sp.aspx'</script>");
			
			
			}
			else
			{

			

				string    SQL_GetList     =  "select top 1 * from Cgth_WorkStreamName where id>(select id from Cgth_WorkStreamName where KeyFile='"+StreamNumber.Text+"' and Name_Jd='"+Gname.Text+"' and username='"+Gusername.Text+"') and KeyFile='"+StreamNumber.Text+"' order by id asc";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					string sql_insert1="insert into StockOutlog_lc  values('"+this.Session["TrueName"]+"通过采购退货["+Name.Text+"]的审批，节点状态为："+NewReader["Name_Jd"].ToString()+"','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);

					string Sql_update ="Update StockOut  Set Gname='"+NewReader["Name_Jd"].ToString()+"',Grealname='"+NewReader["realname"].ToString()+"',Gusername='"+NewReader["username"].ToString()+"' ,Sreakmart='"+Sreakmart.Text+"',State='正在审核'   where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);

					//Response.Write(SQL_GetList);

					this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href = 'StockOut_sp.aspx'</script>");
				}
				else
				{
				
					string sql_insert1="insert into StockOutlog_lc  values('"+this.Session["TrueName"]+"通过采购退货["+Name.Text+"]的审批，节点状态为：完成审核','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
					List.ExeSql(sql_insert1);



					string Sql_update ="Update StockOut  Set Gname='完成审核',Grealname='完成审核',Gusername='完成审核',State='完成审核',Sreakmart='"+Sreakmart.Text+"'    where id='" + int.Parse(Request.QueryString["id"])+"'";
					List.ExeSql(Sql_update);

					string insert_xx="insert into nbdxx values('采购退货["+Name.Text+"]通过审批','采购退货["+Name.Text+"]通过审批\n通过时间："+System.DateTime.Now.ToString()+"','"+System.DateTime.Now.ToString()+"','"+username.Text+"','"+realname.Text+"','系统消息','系统消息','否','"+nbxx_num+"')";
					List.ExeSql(insert_xx);




					string    SQL_GetList_drh     =  "select * from StockOutMx   where Ifdd!='否' and Keyfile='"+number.Text+"'";
				
					OleDbDataReader NewReader_drh = List.GetList(SQL_GetList_drh);
					if(NewReader_drh.Read())
					{
						string Sql_update_drh ="Update StockOrder  Set State='已导退货单'  where number='" +NewReader_drh["Ifdd"]+"'";
						List.ExeSql(Sql_update_drh);
					}//更改定单属性


					/******************出库**************************/




					string    SQL_GetList_rk     =  "select * from StockOutMx where  Keyfile='"+number.Text+"' ";
					OleDbDataReader NewReader_rk  = List.GetList(SQL_GetList_rk);
					while(NewReader_rk.Read())
					{

						string    SQL_GetList_first     =  "select  * from StoreAmount where Number='"+NewReader_rk["GoodsNumber"]+"'and Storeroom='"+Storeroom.Text+"'";
						OleDbDataReader NewReader_first = List.GetList(SQL_GetList_first);
						if(NewReader_first.Read())
						{
							string Sql_update_rk ="Update StoreAmount  Set Amount=Amount-"+NewReader_rk["StockPoint"]+"   where Number='"+NewReader_rk["GoodsNumber"]+"'and Storeroom='"+Storeroom.Text+"'";
							List.ExeSql(Sql_update_rk);
							//Response.Write(Sql_update_rk);

						}
						else
						{
							string sql_insert_rk=" insert into StoreAmount (Number,GoodsName,CountUnit,Model,Type,Code,Color,Area,Cubage,Weight,Storeroom,Storebit,Amount,Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark) select '"+NewReader_rk["GoodsNumber"]+"','"+NewReader_rk["GoodsName"]+"','"+NewReader_rk["CountUnit"]+"','"+NewReader_rk["Model"]+"',Type,Code,Color,Area,Cubage,Weight,'"+Storeroom.Text+"','','-"+NewReader_rk["StockPoint"]+"',Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark from  GoodsData  where  Number='" +NewReader_rk["GoodsNumber"]+"'";
							List.ExeSql(sql_insert_rk);
							//Response.Write(sql_insert_rk);
							
						}

					}


					/******************出库**************************/
				}

				string sql_insert=" insert into StockOut_sp  (number,title,ShTime,StockPeoNum,StockPeoName,Storeroom,CompanyNumber,CompanyName,CompanyAdd,Traffic,Balance,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes) select number,title,ShTime,StockPeoNum,StockPeoName,Storeroom,CompanyNumber,CompanyName,CompanyAdd,Traffic,Balance,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,'通过','"+Sreakmart.Text+"','"+this.Session["username"]+"','"+this.Session["TrueName"]+"',MyTimes from  StockOut where  id='" + int.Parse(Request.QueryString["id"])+"'";
				List.ExeSql(sql_insert);

				this.Response.Write("<script language=javascript>alert('提交成功！商品成功出库');window.location.href = 'StockOut_sp.aspx'</script>");
			}




		}
	}
}
