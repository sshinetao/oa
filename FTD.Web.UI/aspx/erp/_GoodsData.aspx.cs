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
	/// GoodsData 的摘要说明。
	/// </summary>
	public class GoodsData : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton6;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
        protected PageNavigator PageNavigator1;

		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
        {
            PageNavigator1.OnPageChange += new PageNavigator.PageChangeHandler(PageNavigator1_PageChange);
            FTD.Unit.PublicMethod.CheckSession();
			this.ImageButton2.Attributes.Add("onclick","javascript:return del();");
            if(!IsPostBack)
            {
                Bind(1, 20);
            }
		}

        protected void PageNavigator1_PageChange(object sender, int PageIndex)
        {
            Bind(PageIndex, 20);
        }



        protected void Bind(int InPage, int PageNum)
        {
            FTD.BLL.GoodsData bll = new FTD.BLL.GoodsData();
            DataSet ds = bll.GetList("");
            if (ds != null&& ds.Tables.Count>0)
            {
                DataSet ds2 = SplitDataSet(ds, InPage, PageNum);
                Datagrid2.DataSource = ds2.Tables[0];
                Datagrid2.DataBind();
            }
        }

        #region 直接在DataSet(数据集)中分页

        /// <summary>
        /// 直接在DataSet(数据集)中分页
        /// </summary>
        /// <param name="ds">数据源表</param>
        /// <param name="InPage">第几页</param>
        /// <param name="PageNum">每页显示条数</param>
        /// <returns></returns>
        public static DataSet SplitDataSet(DataSet ds, int InPage, int PageNum)
        {
            DataSet vds = new DataSet();
            vds = ds.Clone();
            int fromIndex = PageNum * (InPage - 1);
            int toIndex = PageNum * InPage - 1;
            for (int i = fromIndex; i <= toIndex; i++)
            {
                if (i >= ds.Tables[0].Rows.Count)
                    break;
                vds.Tables[0].ImportRow(ds.Tables[0].Rows[i]);
            }
            ds.Dispose();
            return vds;
        }
        #endregion

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
			this.ImageButton4.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton4_Click);
			this.ImageButton6.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton6_Click);
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("GoodsData_add.aspx");
		}

		private void ImageButton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("GoodsData_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

		private void ImageButton6_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("GoodsData_update.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
			}
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
            try
            {

                FTD.BLL.GoodsData bll = new FTD.BLL.GoodsData();
                int _id = Utils.GetInt(Datagrid2.SelectedItem.Cells[1].Text.ToString(), 0);
                if (_id > 0)
                {
                    bll.Delete(_id);
                    Response.Redirect("GoodsData.aspx");
                }
            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
            }
		}


		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}
	}
}
