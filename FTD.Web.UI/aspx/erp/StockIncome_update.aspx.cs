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
	/// StockIncome_update 的摘要说明。
	/// </summary>
	public class StockIncome_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		protected System.Web.UI.WebControls.ImageButton Imagebutton6;
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox ShTime;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.TextBox CompanyAdd;
		protected System.Web.UI.WebControls.TextBox Traffic;
		protected System.Web.UI.WebControls.TextBox Balance;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		Db List=new Db();
		public static string Gusername,Grealname,Gname;
		private void Page_Load(object sender, System.EventArgs e)
		{
			
			if(!IsPostBack)
			{
			
	

			

				this.ImageButton5.Attributes.Add("onclick","javascript:return del();"); 

				this.Imagebutton6.Attributes.Add("onclick","javascript:return drjh();"); 

				this.ImageButton3.Attributes.Add("onclick","javascript:zjOpen();"); 
			
			}


			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from StockIncome  where id='" + int.Parse(Request.QueryString["id"])+"'";
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

				
				}

			}




			string SQL_GetList_xs    =  "select * from StockIncomeMx where  Keyfile='"+number.Text+"' order by id desc";
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
			Response.Redirect("StockIncome.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{


			string    SQL_GetList     =  "select top 1 * from Cgrk_WorkStreamName  where KeyFile='"+StreamNumber.Text+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				Gusername=NewReader["username"].ToString();
				Grealname=NewReader["realname"].ToString();
				Gname=NewReader["Name_Jd"].ToString();


				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('修改[采购入库]','采购入库','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);

			
				string sql_insert1="insert into StockIncomelog_lc values('"+this.Session["TrueName"]+"修改了采购入库["+title.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"]','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
				List.ExeSql(sql_insert1);



				string Sql_update ="Update StockIncome Set title='"+title.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',ShTime='"+ShTime.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',StockPeoNum='"+StockPeoNum.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',StockPeoName='"+StockPeoName.Text+"',Storeroom='"+Storeroom.Text+"',CompanyNumber='"+CompanyNumber.Text+"',CompanyName='"+CompanyName.Text+"',CompanyAdd='"+CompanyAdd.Text+"',Traffic='"+Traffic.Text+"',Balance='"+Balance.Text+"',Remark='"+Remark.Text+"',MyTimes='"+this.Session["MyTimes"]+"',StreamNumber='"+StreamNumber.Text+"',StreamName='"+StreamName.Text+"',Gusername='"+Gusername+"',Grealname='"+Grealname+"',Gname='"+Gname+"',Username='"+this.Session["Username"]+"',Realname='"+this.Session["TrueName"]+"',State='等待审批'  where  id='" + int.Parse(Request.QueryString["id"])+"'";
				
				List.ExeSql(Sql_update);
			



				this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='StockIncome.aspx'</script>");

			}
			else
			{
				this.Response.Write("<script language=javascript>alert('此工作流；未找到对应的流程！操作失败');</script>");
				return;
			
			}




		}

		private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
			
				string SQL_Del = "Delete from StockIncomeMx where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);


				string SQL_GetList_xs    =  "select * from StockIncomeMx where  Keyfile='"+number.Text+"' order by id desc";
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
			
				ImageButton4.Attributes.Add("onclick","window.showModalDialog('StockIncome_add_update.aspx?a='+Math.random()+'&id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"&number="+number.Text+"','window','dialogWidth:700px;DialogHeight=400px;status:no;help=no;scroll=no');window.location='#'");
			

			}
			catch
			{
				//this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}
	}
}

