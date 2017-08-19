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
	/// OutRoom_ysp_show 的摘要说明。
	/// </summary>
	public class OutRoom_ysp_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		Db List=new Db();
	
		protected System.Web.UI.WebControls.TextBox ThTime;
		protected System.Web.UI.WebControls.TextBox ThPeople;
		protected System.Web.UI.WebControls.TextBox Tel;
		protected System.Web.UI.WebControls.TextBox Realname;
		protected System.Web.UI.WebControls.TextBox SpCz;
		protected System.Web.UI.WebControls.TextBox Sreakmart;
		protected System.Web.UI.WebControls.TextBox OutUse;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			//编号生成


			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from OutRoom_sp  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					number.Text=NewReader["number"].ToString();
					
					title.Text=NewReader["title"].ToString();
					Storeroom.Text=NewReader["Storeroom"].ToString();
					ThPeople.Text=NewReader["ThPeople"].ToString();	
					Tel.Text=NewReader["Tel"].ToString();	
					ThTime.Text=NewReader["ThTime"].ToString();
					OutUse.Text=NewReader["OutUse"].ToString();		
				
					
					Remark.Text=NewReader["Remark"].ToString();
					StreamNumber.Text=NewReader["StreamNumber"].ToString();
					StreamName.Text=NewReader["StreamName"].ToString();

					Realname.Text=NewReader["Realname"].ToString();
					Sreakmart.Text=NewReader["Sreakmart"].ToString();
					SpCz.Text=NewReader["SpCz"].ToString();
				}

			}



			string SQL_GetList_xs    =  "select * from OutRoomMx where  Keyfile='"+number.Text+"' order by id desc";
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
			Response.Redirect("OutRoom_ysp.aspx");
		}

	
	}
}
