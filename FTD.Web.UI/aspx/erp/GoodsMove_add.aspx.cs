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
	/// GoodsMove_add 的摘要说明。
	/// </summary>
	public class GoodsMove_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		Db List=new Db();
		public static string Gusername,Grealname,Gname;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.TextBox Uses;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			//编号生成
			if(!IsPostBack)
			{
			
				Random g  = new Random();
				string rad=g.Next(10000).ToString();

				number.Text=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+System.DateTime.Now.Hour.ToString()+""+System.DateTime.Now.Minute.ToString()+""+System.DateTime.Now.Second.ToString()+""+System.DateTime.Now.Millisecond.ToString()+""+rad+"";
			

			

				this.ImageButton5.Attributes.Add("onclick","javascript:return del();"); 


				this.ImageButton3.Attributes.Add("onclick","javascript:zjOpen();"); 

				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			
			}




			string SQL_GetList_xs    =  "select * from GoodsMoveMx where  Keyfile='"+number.Text+"' order by id desc";
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
			this.ImageButton5.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton5_Click);
			this.Datagrid2.SelectedIndexChanged += new System.EventHandler(this.Datagrid2_SelectedIndexChanged);
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
			Response.Redirect("GoodsMove.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{

			/******************出库**************************/
			string    SQL_GetList_rk     =  "select * from GoodsMoveMx where  Keyfile='"+number.Text+"' ";
			OleDbDataReader NewReader_rk  = List.GetList(SQL_GetList_rk);
			while(NewReader_rk.Read())
			{

				string    SQL_GetList_first     =  "select  * from StoreAmount where Number='"+NewReader_rk["GoodsNumber"]+"'and Storeroom='"+NewReader_rk["CStoreroom"]+"'";
				OleDbDataReader NewReader_first = List.GetList(SQL_GetList_first);
				if(NewReader_first.Read())
				{
					string Sql_update_rk ="Update StoreAmount  Set Amount=Amount-"+NewReader_rk["SplitPoint"]+"   where Number='"+NewReader_rk["GoodsNumber"]+"'and Storeroom='"+NewReader_rk["CStoreroom"]+"'";
					List.ExeSql(Sql_update_rk);
				

				}
				else
				{
					string sql_insert_rk=" insert into StoreAmount (Number,GoodsName,CountUnit,Model,Type,Code,Color,Area,Cubage,Weight,Storeroom,Storebit,Amount,Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark) select '"+NewReader_rk["GoodsNumber"]+"','"+NewReader_rk["GoodsName"]+"','"+NewReader_rk["CountUnit"]+"','"+NewReader_rk["Model"]+"',Type,Code,Color,Area,Cubage,Weight,'"+NewReader_rk["CStoreroom"]+"','','-"+NewReader_rk["SplitPoint"]+"',Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark from  GoodsData  where  Number='" +NewReader_rk["GoodsNumber"]+"'";
					List.ExeSql(sql_insert_rk);
					
							
				}

			}
			/******************出库**************************/




			/******************入库**************************/
			string    SQL_GetList_rk1     =  "select * from GoodsMoveMx where  Keyfile='"+number.Text+"' ";
			OleDbDataReader NewReader_rk1  = List.GetList(SQL_GetList_rk1);
			while(NewReader_rk1.Read())
			{

				string    SQL_GetList_first1     =  "select  * from StoreAmount where Number='"+NewReader_rk1["GoodsNumber"]+"'and Storeroom='"+NewReader_rk1["RStoreroom"]+"'";
				OleDbDataReader NewReader_first1 = List.GetList(SQL_GetList_first1);
				if(NewReader_first1.Read())
				{
					string Sql_update_rk1 ="Update StoreAmount  Set Amount=Amount+"+NewReader_rk1["SplitPoint"]+"   where Number='"+NewReader_rk1["GoodsNumber"]+"'and Storeroom='"+NewReader_rk1["RStoreroom"]+"'";
					List.ExeSql(Sql_update_rk1);
				

				}
				else
				{
					string sql_insert_rk1=" insert into StoreAmount (Number,GoodsName,CountUnit,Model,Type,Code,Color,Area,Cubage,Weight,Storeroom,Storebit,Amount,Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark) select '"+NewReader_rk1["GoodsNumber"]+"','"+NewReader_rk1["GoodsName"]+"','"+NewReader_rk1["CountUnit"]+"','"+NewReader_rk1["Model"]+"',Type,Code,Color,Area,Cubage,Weight,'"+NewReader_rk1["RStoreroom"]+"','','"+NewReader_rk1["SplitPoint"]+"',Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark from  GoodsData  where  Number='" +NewReader_rk1["GoodsNumber"]+"'";
					List.ExeSql(sql_insert_rk1);
					
							
				}

			}
			/******************入库**************************/






			string sql_insert="insert into GoodsMove  (number,Uses,StockPeoName,Username,Realname,Nowtimes,Remark,MyTimes) values('"+number.Text+"','"+Uses.Text+"','"+StockPeoName.Text+"','"+this.Session["username"].ToString()+"','"+this.Session["TrueName"].ToString()+"','"+System.DateTime.Now.ToString()+"','"+Remark.Text+"','"+this.Session["MyTimes"]+"')";
			List.ExeSql(sql_insert);

			this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='GoodsMove.aspx'</script>");
		}

		private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
			
				string SQL_Del = "Delete from GoodsMove where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);


				string SQL_GetList_xs    =  "select * from GoodsMove where  Keyfile='"+number.Text+"' order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();




			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
			}
		}

		private void Datagrid2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
			
				ImageButton4.Attributes.Add("onclick","window.showModalDialog('GoodsBind_add_update.aspx?a='+Math.random()+'&id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"&number="+number.Text+"','window','dialogWidth:700px;DialogHeight=400px;status:no;help=no;scroll=no');window.location='#'");
			

			}
			catch
			{
				//this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}
	}
}
