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
	/// StockOrder 的摘要说明。
	/// </summary>
	public class StockOrder : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.ImageButton Imagebutton9;
		protected System.Web.UI.WebControls.ImageButton Imagebutton4;
		protected System.Web.UI.WebControls.ImageButton Imagebutton5;
		protected System.Web.UI.WebControls.ImageButton Imagebutton7;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton Imagebutton6;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton8;
        protected System.Web.UI.WebControls.DropDownList dl1;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();
		
			if(!Page.IsPostBack)
			{
				tilte.Attributes["onkeydown"]="if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
				this.Imagebutton5.Attributes.Add("onclick","javascript:return del();"); 
				this.Imagebutton6.Attributes.Add("onclick","javascript:return wb();"); 
				this.Imagebutton7.Attributes.Add("onclick","javascript:return zf();"); 
			
			}


			if(Request.QueryString["str"]!=null)
			{
                string SQL_GetList_xs = "select * from StockOrder where   " + Server.UrlDecode(Request.QueryString["keywords"]) + " like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'  and Username='" + this.Session["username"] + "'  order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else
			{
				string SQL_GetList_xs    =  "select * from StockOrder  where Username='"+this.Session["username"]+"'order by id desc";
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
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);
			this.Imagebutton9.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton9_Click);
			this.Imagebutton4.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton4_Click);
			this.Imagebutton5.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton5_Click);
			this.Imagebutton6.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton6_Click);
			this.Imagebutton7.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton7_Click);
			this.Imagebutton8.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton8_Click);
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
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
            Response.Redirect("StockOrder.aspx?str=" + tilte.Text + "&keywords=" + dl1.SelectedValue);
		}

		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}

		private void Imagebutton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{


                //string    SQL_GetList_yj     =  "select * from MonthSet where  '"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) ";
                //OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
                //if(NewReader_yj.Read())
                //{
                //    this.Response.Write("<script language=javascript>alert('已经执行月结存，操作失败');</script>");
                //    return;


                //}



                //if(Datagrid2.SelectedItem.Cells[10].Text.ToString()=="执行完毕"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="强制停止"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="作废"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="完成审核"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="正在审核" ||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="已导入库单"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="已导退货单")
                //{
                //    this.Response.Write("<script language=javascript>alert('当前状态为["+Datagrid2.SelectedItem.Cells[10].Text.ToString()+"]，不能进行删除');</script>");
                //    return;
                //}
	
			
				string SQL_Del = "Delete from StockOrder where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);



				if(Request.QueryString["str"]!=null)
				{
					string SQL_GetList_xs    =  "select * from StockOrder where  tilte like '%"+Server.UrlDecode(Request.QueryString["str"])+"%'   order by id desc";
					Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
					Datagrid2.DataBind();

				}
				else
				{
					string SQL_GetList_xs    =  "select * from StockOrder order by id desc";
					Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
					Datagrid2.DataBind();
				}

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
			}
		}

		private void Imagebutton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

                //string    SQL_GetList_yj     =  "select * from MonthSet where  '"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) ";
                //OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
                //if(NewReader_yj.Read())
                //{
                //    this.Response.Write("<script language=javascript>alert('已经执行月结存，操作失败');</script>");
                //    return;


                //}
                //if(Datagrid2.SelectedItem.Cells[10].Text.ToString()=="执行完毕"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="强制停止"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="作废"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="完成审核"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="正在审核"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="已导入库单"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="已导退货单")
                //{
                //    this.Response.Write("<script language=javascript>alert('当前状态为["+Datagrid2.SelectedItem.Cells[10].Text.ToString()+"]，不能进行修改');</script>");

                //}
                //else
                //{
					Response.Redirect("StockOrder_update.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");
                //}

			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

		private void Imagebutton9_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("StockOrder_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("StockOrder_add.aspx");
		}

		private void Imagebutton6_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
		
                //string    SQL_GetList_yj     =  "select * from MonthSet where  '"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) ";
                //OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
                //if(NewReader_yj.Read())
                //{
                //    this.Response.Write("<script language=javascript>alert('已经执行月结存，操作失败');</script>");
                //    return;


                //}



			
                //if(Datagrid2.SelectedItem.Cells[10].Text.ToString()=="执行完毕"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="强制停止"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="作废"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="已导入库单"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="已导退货单")
                //{
			

                //    this.Response.Write("<script language=javascript>alert('操作失败!当前状态已经为["+Datagrid2.SelectedItem.Cells[10].Text.ToString()+"]');</script>");
                //}
                //else
                //{
					string SQL_Del = "update  StockOrder   set State='执行完毕' where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
					List.ExeSql(SQL_Del);

					this.Response.Write("<script language=javascript>alert('提交成功！状态更改为[执行完毕]');window.location.href='StockOrder.aspx'</script>");
                //}


			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

		private void Imagebutton7_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
		
			
                //string    SQL_GetList_yj     =  "select * from MonthSet where  '"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) ";
                //OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
                //if(NewReader_yj.Read())
                //{
                //    this.Response.Write("<script language=javascript>alert('已经执行月结存，操作失败');</script>");
                //    return;


                //}



                //if(Datagrid2.SelectedItem.Cells[10].Text.ToString()=="执行完毕"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="强制停止"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="作废"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="已导入库单"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="已导退货单")
                //{
			

                //    this.Response.Write("<script language=javascript>alert('操作失败!当前状态已经为["+Datagrid2.SelectedItem.Cells[10].Text.ToString()+"]');</script>");
                //}
                //else
                //{
					string SQL_Del = "update  StockOrder   set State='作废' where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
					List.ExeSql(SQL_Del);

					this.Response.Write("<script language=javascript>alert('提交成功！状态更改为[作废]');window.location.href='StockOrder.aspx'</script>");
                //}


			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}


		}

		private void Imagebutton8_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("StockOrder_gz.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("StockOrderLeading.aspx");
        }

	}
}

