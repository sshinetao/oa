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
	/// GoodsOpenMoney_xs_show 的摘要说明。
	/// </summary>
	public class GoodsOpenMoney_xs_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.TextBox KhNumber;
		protected System.Web.UI.WebControls.TextBox KhName;
		protected System.Web.UI.WebControls.TextBox Sellmoney1;
		protected System.Web.UI.WebControls.TextBox Sellmoney2;
		protected System.Web.UI.WebControls.TextBox Sellmoney3;
		protected System.Web.UI.WebControls.TextBox Sellmoney4;
		protected System.Web.UI.WebControls.TextBox Zhekou;
		protected System.Web.UI.WebControls.TextBox Powermoney;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

	
			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from GoodsOpenMoney_xs  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					GoodsNumber.Text=NewReader["GoodsNumber"].ToString();
					GoodsName.Text=NewReader["GoodsName"].ToString();
					CountUnit.Text=NewReader["CountUnit"].ToString();
					Model.Text=NewReader["Model"].ToString();
					KhNumber.Text=NewReader["KhNumber"].ToString();
					KhName.Text=NewReader["KhName"].ToString();
					Sellmoney1.Text=NewReader["Sellmoney1"].ToString();
					Sellmoney2.Text=NewReader["Sellmoney2"].ToString();
					Sellmoney3.Text=NewReader["Sellmoney3"].ToString();
					Sellmoney4.Text=NewReader["Sellmoney4"].ToString();
					Zhekou.Text=NewReader["Zhekou"].ToString();
					Powermoney.Text=NewReader["Powermoney"].ToString();
					Remark.Text=NewReader["Remark"].ToString();

				}

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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("GoodsOpenMoney_xs.aspx");
		}
	}
}
