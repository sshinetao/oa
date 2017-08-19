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
	/// GoodsOpenMoney 的摘要说明。
	/// </summary>
	public class GoodsOpenMoney : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.RadioButton RadioButton1;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.ImageButton Imagebutton4;
		protected System.Web.UI.WebControls.ImageButton Imagebutton5;
		protected System.Web.UI.WebControls.ImageButton Imagebutton6;
		protected System.Web.UI.WebControls.RadioButton RadioButton2;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.ImageButton Imagebutton7;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

		
			if(!Page.IsPostBack)
			{
				Name.Attributes["onkeydown"]="if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";

			

			}


		


			if(Request.QueryString["str1"]!=null)
			{
				string SQL_GetList_xs    =  "select * from GoodsOpenMoney where GoodsName like '%"+Server.UrlDecode(Request.QueryString["str1"])+"%'   order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else if(Request.QueryString["str2"]!=null)
			{
				string SQL_GetList_xs    =  "select * from GoodsOpenMoney where KhName like '%"+Server.UrlDecode(Request.QueryString["str2"])+"%'   order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
			}
			else
			{
				string SQL_GetList_xs    =  "select * from GoodsOpenMoney  order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();
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
			this.Imagebutton7.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton7_Click);
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);
			this.Imagebutton4.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton4_Click);
			this.Imagebutton5.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton5_Click);
			this.Imagebutton6.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton6_Click);
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
			this.Datagrid2.ItemDataBound += new System.Web.UI.WebControls.DataGridItemEventHandler(this.Datagrid2_ItemDataBound);
			this.Datagrid2.SelectedIndexChanged += new System.EventHandler(this.Datagrid2_SelectedIndexChanged);
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
			if(RadioButton1.Checked==true)
			{
				Response.Redirect("GoodsOpenMoney.aspx?str1="+Name.Text+"");
			}
			else
			{
				Response.Redirect("GoodsOpenMoney.aspx?str2="+Name.Text+"");
			}
				
		}

		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
				Response.Redirect("main_1.aspx");
		}

		private void Datagrid2_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
		{
			if(e.Item.ItemType==ListItemType.Header)
			{
			}
			else
			{
				
				string    SQL_GetList_ck     =  "select * from StoreAmount where Number='"+e.Item.Cells[10].Text+"' ";
				OleDbDataReader NewReader_ck = List.GetList(SQL_GetList_ck);
				if(NewReader_ck.Read())
				{
					string    SQL_GetList     =  "select sum(Amount) as counts from StoreAmount where Number='"+e.Item.Cells[10].Text+"' ";
					OleDbDataReader NewReader = List.GetList(SQL_GetList);
					if(NewReader.Read())
					{
						string alldelpoint=NewReader["counts"].ToString();
						e.Item.Cells[5].Text+=alldelpoint;
					}
				}
				else
				{
					e.Item.Cells[5].Text+="0";
				
				}

			}
		}

		private void Imagebutton7_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
		Response.Redirect("GoodsOpenMoney_add.aspx");
		}

		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("GoodsOpenMoney_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}



		private void Imagebutton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
		
		}

		private void Imagebutton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{

		}

		private void Datagrid2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
			
				Imagebutton4.Attributes.Add("onclick","window.showModalDialog('GoodsOpenMoney_sp_show.aspx?a='+Math.random()+'&Number="+Datagrid2.SelectedItem.Cells[10].Text.ToString()+"','window','dialogWidth:600px;DialogHeight=430px;status:no;help=no;scroll=no');window.location='#'");
				Imagebutton5.Attributes.Add("onclick","window.showModalDialog('GoodsOpenMoney_cp_show.aspx?a='+Math.random()+'&Number="+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"','window','dialogWidth:600px;DialogHeight=580px;status:no;help=no;scroll=no');window.location='#'");

			}
			catch
			{
				//this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

		private void Imagebutton6_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
		
			
				if(Datagrid2.SelectedItem.Cells[12].Text.ToString()=="启用")
				{
					string SQL_Del = "update  GoodsOpenMoney  set State='禁止' where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
					List.ExeSql(SQL_Del);

					this.Response.Write("<script language=javascript>alert('提交成功！状态更改为[禁止]');window.location.href='GoodsOpenMoney.aspx'</script>");
				}
				else
				{
					string SQL_Del = "update  GoodsOpenMoney  set State='启用' where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
					List.ExeSql(SQL_Del);

					this.Response.Write("<script language=javascript>alert('提交成功！状态更改为[启用]');window.location.href='GoodsOpenMoney.aspx'</script>");
				}


			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}
	}
}
