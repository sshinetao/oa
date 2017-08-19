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
	/// OutRoom 的摘要说明。
	/// </summary>
	public class OutRoom : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.ImageButton Imagebutton9;
		protected System.Web.UI.WebControls.ImageButton Imagebutton4;
		protected System.Web.UI.WebControls.ImageButton Imagebutton5;
		protected System.Web.UI.WebControls.ImageButton Imagebutton8;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

		
			if(!Page.IsPostBack)
			{
				tilte.Attributes["onkeydown"]="if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
				this.Imagebutton5.Attributes.Add("onclick","javascript:return del();"); 
	
			
			}

            FTD.BLL.OutRoom bll = new FTD.BLL.OutRoom();
            string strSql ="";
			if(Request.QueryString["str"]!=null)
			{
                strSql = "  title like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'  and Username='" + this.Session["username"] + "'  order by id desc";
				

			}
			else
			{
                strSql = " Username='" + this.Session["username"] + "'order by id desc";
				
			}
            DataSet ds = bll.GetList(strSql);
            if (ds != null && ds.Tables.Count > 0)
            {
                Datagrid2.DataSource = ds.Tables[0];
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
			this.Imagebutton8.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton8_Click);
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
			Response.Redirect("OutRoom.aspx?str="+tilte.Text+"");
		}

		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("OutRoom_add.aspx");
		}

		private void Imagebutton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{

			try
			{

                FTD.BLL.OutRoom bll = new FTD.BLL.OutRoom();
			
                int _id = Utils.GetInt(Datagrid2.SelectedItem.Cells[1].Text.ToString(),0);
                bll.Delete(_id);
            

                string strSql = "";
                if (Request.QueryString["str"] != null)
                {
                    strSql = "  title like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'  and Username='" + this.Session["username"] + "'  order by id desc";


                }
                else
                {
                    strSql = " Username='" + this.Session["username"] + "'order by id desc";

                }
                DataSet ds = bll.GetList(strSql);
                if (ds != null && ds.Tables.Count > 0)
                {
                    Datagrid2.DataSource = ds.Tables[0];
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

				string    SQL_GetList_yj     =  "select * from MonthSet where  '"+Datagrid2.SelectedItem.Cells[9].Text.ToString()+"' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[9].Text.ToString()+"' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[9].Text.ToString()+"' as datetime),120) ";
				OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
				if(NewReader_yj.Read())
				{
					this.Response.Write("<script language=javascript>alert('已经执行月结存，操作失败');</script>");
					return;


				}



				if(Datagrid2.SelectedItem.Cells[8].Text.ToString()=="完成审核"||Datagrid2.SelectedItem.Cells[8].Text.ToString()=="正在审核")
				{
					this.Response.Write("<script language=javascript>alert('当前状态为["+Datagrid2.SelectedItem.Cells[8].Text.ToString()+"]，不能进行删除');</script>");
					return;
				}


		
				Response.Redirect("OutRoom_update.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");
			

			

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

				Response.Redirect("OutRoom_gz.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

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

				Response.Redirect("OutRoom_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {

        }

	}
}
