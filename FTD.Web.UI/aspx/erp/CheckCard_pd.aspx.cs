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
	/// CheckCard_pd 的摘要说明。
	/// </summary>
	public class CheckCard_pd : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.TextBox AccountPoint;
		protected System.Web.UI.WebControls.TextBox FactPoint;
		protected System.Web.UI.WebControls.TextBox Difference;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return hyjz();"); 

				string    SQL_GetList     =  "select * from StoreAmount  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					GoodsNumber.Text=NewReader["Number"].ToString();
					GoodsName.Text=NewReader["GoodsName"].ToString();
					Storeroom.Text=NewReader["Storeroom"].ToString();
					AccountPoint.Text=NewReader["Amount"].ToString();	
			
					CountUnit.Text=NewReader["CountUnit"].ToString();	
					Model.Text=NewReader["Model"].ToString();	


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
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{

			string Sql_update ="Update StoreAmount Set Amount='"+FactPoint.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"' where id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);


			string sql_insert="insert into CheckCard (GoodsNumber,GoodsName,Storeroom,CountUnit,Model,AccountPoint,FactPoint,Difference,Username,Realname,Nowtimes,MyTimes) values('"+GoodsNumber.Text+"','"+GoodsName.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"','"+Storeroom.Text+"','"+CountUnit.Text+"','"+Model.Text+"','"+AccountPoint.Text+"','"+FactPoint.Text+"','"+Difference.Text+"','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"','"+this.Session["MyTimes"]+"')";
			List.ExeSql(sql_insert);
			
			this.Response.Write("<script language=javascript>alert('提交成功！');window.close()</script>");
		}
	}
}
