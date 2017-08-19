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
	/// SellQuote_add 的摘要说明。
	/// </summary>
	public class SellQuote_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.DropDownList Ifopen;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.TextBox OrderAdd;
		protected System.Web.UI.WebControls.TextBox QdTime;
		protected System.Web.UI.WebControls.TextBox InvoiceType;
		protected System.Web.UI.WebControls.TextBox Unit;
		protected System.Web.UI.WebControls.TextBox Allmoney;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox CompanyAdd;
		protected System.Web.UI.WebControls.TextBox Remark;
		Db List=new Db();
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
			
			}

			string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+" from SellQuoteMx  where Keyfile='"+number.Text+"'";
			OleDbDataReader NewReader_money = List.GetList(SQL_money_);
			if(NewReader_money.Read())
			{
				try
				{
					this.Allmoney.Text=null;
					this.Allmoney.Text+=NewReader_money.GetDecimal(0);
							
				}
				catch
				{
					this.Allmoney.Text=null;
					this.Allmoney.Text+="0";
							
				}
				NewReader_money.Close();
			}//得到产品消费成本价


			string SQL_GetList_xs    =  "select * from SellQuoteMx where  Keyfile='"+number.Text+"' order by id desc";
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
			Response.Redirect("SellQuote.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增[销售报价]','销售报价','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

			string sql_insert="insert into SellQuote  (title,number,InvoiceType,QdTime,OrderAdd,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,Allmoney,Remark,Type,Username,Realname,Nowtimes,Ifopen) values('"+tilte.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"','"+number.Text+"','"+InvoiceType.Text+"','"+QdTime.Text+"','"+OrderAdd.Text+"','"+CompanyNumber.Text+"','"+CompanyName.Text+"','"+CompanyAdd.Text+"','"+Unit.Text+"','"+StockPeoNum.Text+"','"+StockPeoName.Text+"','"+Allmoney.Text+"','"+Remark.Text+"','正在执行','"+this.Session["username"].ToString()+"','"+this.Session["TrueName"].ToString()+"','"+System.DateTime.Now.ToString()+"','"+Ifopen.SelectedValue+"')";
			List.ExeSql(sql_insert);
			//Response.Write(sql_insert);
		

			string Sql_update ="Update SellQuoteMx Set Ifopen='"+Ifopen.SelectedValue+"',Type='正在执行' where Keyfile='" +number.Text+"'";
			List.ExeSql(Sql_update);

		this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='SellQuote.aspx'</script>");
		}

		private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
			
				string SQL_Del = "Delete from SellQuoteMx where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);


				string SQL_GetList_xs    =  "select * from SellQuoteMx where  Keyfile='"+number.Text+"' order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();


				string    SQL_money_     =  " SELECT SUM(ALLMoney) AS "+"sum"+" from SellQuoteMx  where Keyfile='"+number.Text+"'";
				OleDbDataReader NewReader_money = List.GetList(SQL_money_);
				if(NewReader_money.Read())
				{
					try
					{
						this.Allmoney.Text=null;
						this.Allmoney.Text+=NewReader_money.GetDecimal(0);
							
					}
					catch
					{
						this.Allmoney.Text=null;
						this.Allmoney.Text+="0";
							
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
			
				ImageButton4.Attributes.Add("onclick","window.showModalDialog('SellQuote_add_update.aspx?a='+Math.random()+'&id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"','window','dialogWidth:700px;DialogHeight=400px;status:no;help=no;scroll=no');window.location='#'");
			

			}
			catch
			{
				//this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}
	}
}
