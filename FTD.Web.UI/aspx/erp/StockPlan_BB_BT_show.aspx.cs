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
	/// StockPlan_BB_BT_show ��ժҪ˵����
	/// </summary>
	public class StockPlan_BB_BT_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.TextBox StartTime;
		protected System.Web.UI.WebControls.TextBox EndTime;
		protected System.Web.UI.WebControls.TextBox unit;
		protected System.Web.UI.WebControls.TextBox ALLMoney;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
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
			}//�õ���Ʒ���ѳɱ���


			string SQL_GetList_xs    =  "select * from StockPlanMx where  Keyfile='"+number.Text+"' order by id desc";
			Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
			Datagrid2.DataBind();
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
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
			Response.Redirect("StockPlan_BB_BT.aspx");
		}
	}
}
