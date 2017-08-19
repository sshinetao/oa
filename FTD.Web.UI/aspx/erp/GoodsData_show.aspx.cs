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
	/// GoodsData_show 的摘要说明。
	/// </summary>
	public class GoodsData_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Number;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox Code;
		protected System.Web.UI.WebControls.TextBox Color;
		protected System.Web.UI.WebControls.TextBox Area;
		protected System.Web.UI.WebControls.TextBox Cubage;
		protected System.Web.UI.WebControls.TextBox Weight;
		protected System.Web.UI.WebControls.TextBox Amountup;
		protected System.Web.UI.WebControls.TextBox Amountdown;
		protected System.Web.UI.WebControls.TextBox Powermoney;
		protected System.Web.UI.WebControls.TextBox Stockmoney;
		protected System.Web.UI.WebControls.TextBox Sellmoney1;
		protected System.Web.UI.WebControls.TextBox Sellmoney2;
		protected System.Web.UI.WebControls.TextBox Sellmoney3;
		protected System.Web.UI.WebControls.TextBox Sellmoney4;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
	Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();


			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from GoodsData  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					Number.Text=NewReader["Number"].ToString();
					GoodsName.Text=NewReader["GoodsName"].ToString();
					CountUnit.Text=NewReader["CountUnit"].ToString();
					Model.Text=NewReader["Model"].ToString();
					Type.Text=NewReader["Type"].ToString();
					Code.Text=NewReader["Code"].ToString();
					Color.Text=NewReader["Color"].ToString();
					Area.Text=NewReader["Area"].ToString();
					Cubage.Text=NewReader["Cubage"].ToString();
					Weight.Text=NewReader["Weight"].ToString();
					Amountup.Text=NewReader["Amountup"].ToString();
					Amountdown.Text=NewReader["Amountdown"].ToString();
					Powermoney.Text=NewReader["Powermoney"].ToString();
					Stockmoney.Text=NewReader["Stockmoney"].ToString();
					Sellmoney1.Text=NewReader["Sellmoney1"].ToString();
					Sellmoney2.Text=NewReader["Sellmoney2"].ToString();
					Sellmoney3.Text=NewReader["Sellmoney3"].ToString();
					Sellmoney4.Text=NewReader["Sellmoney4"].ToString();
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
				Response.Redirect("GoodsData.aspx");
		}
	}
}
