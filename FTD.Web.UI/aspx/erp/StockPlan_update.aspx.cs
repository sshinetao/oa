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
	/// StockPlan_update 的摘要说明。
	/// </summary>
	public class StockPlan_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.TextBox StartTime;
		protected System.Web.UI.WebControls.TextBox EndTime;
		protected System.Web.UI.WebControls.TextBox unit;
		protected System.Web.UI.WebControls.TextBox ALLMoney;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.DropDownList Ifopen;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{

		
			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from StockPlan  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					number.Text=NewReader["number"].ToString();
					tilte.Text=NewReader["tilte"].ToString();
					StartTime.Text=NewReader["StartTime"].ToString();
					EndTime.Text=NewReader["EndTime"].ToString();
					ALLMoney.Text=NewReader["ALLMoney"].ToString();
					unit.Text=NewReader["Unit"].ToString();
					Ifopen.SelectedValue=NewReader["Ifopen"].ToString();
				}

			
			}


			if(!IsPostBack)
			{
			
		
			
				this.ImageButton3.Attributes.Add("onclick","javascript:zjOpen();"); 

				this.ImageButton5.Attributes.Add("onclick","javascript:return del();"); 
			
			
			}

			string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+" from StockPlanMx  where Keyfile='"+number.Text+"'";
			OleDbDataReader NewReader_money = List.GetList(SQL_money_);
			if(NewReader_money.Read())
			{
				try
				{
					this.ALLMoney.Text=null;
					this.ALLMoney.Text+=NewReader_money.GetDecimal(0);
							
				}
				catch
				{
					this.ALLMoney.Text=null;
					this.ALLMoney.Text+="0";
							
				}
				NewReader_money.Close();
			}//得到产品消费成本价


			string SQL_GetList_xs    =  "select * from StockPlanMx where  Keyfile='"+number.Text+"' order by id desc";
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
			Response.Redirect("StockPlan.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('修改[采购计划]','采购计划','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

	
			string Sql_update ="Update StockPlan Set tilte='"+tilte.Text+"',StartTime='"+StartTime.Text+"',EndTime='"+EndTime.Text+"',ALLMoney='"+ALLMoney.Text+"',unit='"+unit.Text+"',Username='"+this.Session["username"].ToString()+"',Realname='"+this.Session["TrueName"].ToString()+"',Nowtimes='"+System.DateTime.Now.ToString()+"',Ifopen='"+Ifopen.SelectedValue+"' where id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);


			string Sql_update_1 ="Update StockPlanMx Set Ifopen='"+Ifopen.SelectedValue+"' where Keyfile='" +number.Text+"'";
			List.ExeSql(Sql_update_1);


			this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='StockPlan.aspx'</script>");
		}

		private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
			
				string SQL_Del = "Delete from StockPlanMx where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);


				string SQL_GetList_xs    =  "select * from StockPlanMx where  Keyfile='"+number.Text+"' order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();


				string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+" from StockPlanMx  where Keyfile='"+number.Text+"'";
				OleDbDataReader NewReader_money = List.GetList(SQL_money_);
				if(NewReader_money.Read())
				{
					try
					{
						this.ALLMoney.Text=null;
						this.ALLMoney.Text+=NewReader_money.GetDecimal(0);
							
					}
					catch
					{
						this.ALLMoney.Text=null;
						this.ALLMoney.Text+="0";
							
					}
					NewReader_money.Close();
				}//得到产品消费成本价


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
			
				ImageButton4.Attributes.Add("onclick","window.showModalDialog('StockPlan_add_update.aspx?a='+Math.random()+'&id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"','window','dialogWidth:700px;DialogHeight=600px;status:no;help=no;scroll=no');window.location='#'");
			

			}
			catch
			{
				//this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}
	}
}
