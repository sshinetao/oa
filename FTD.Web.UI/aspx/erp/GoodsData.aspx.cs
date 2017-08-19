using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class GoodsData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PageNavigator1.OnPageChange += new PageNavigator.PageChangeHandler(PageNavigator1_PageChange);
            FTD.Unit.PublicMethod.CheckSession();
            this.ImageButton2.Attributes.Add("onclick", "javascript:return del();");
            if (!IsPostBack)
            {
                Bind(1, 20);
            }
        }

        protected void PageNavigator1_PageChange(object sender, int PageIndex)
        {
            Bind(PageIndex, 20);
        }



        protected void Bind(int PageIndex, int PageNum)
        {
            int PageCount = 0;
            int RecordCount = 0;
            int PageSize = 15;
         


            FTD.BLL.GoodsData bll = new FTD.BLL.GoodsData();
            string strWhere = "";
            DataTable dt = bll.GetGoodsDataPage(strWhere, PageIndex, PageSize, out RecordCount, out PageCount);
            
            DataSet ds = bll.GetList("");
            if (dt != null && dt.Rows.Count > 0)
            {
                //DataSet ds2 = SplitDataSet(ds, PageIndex, PageNum);
                Datagrid2.DataSource = dt;
                Datagrid2.DataBind();
            }



            this.PageNavigator1.PageCount = PageCount;
            this.PageNavigator1.PageIndex = PageIndex;
            this.PageNavigator1.RecordCount = RecordCount;
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

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("GoodsData_add.aspx");

        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                Response.Redirect("GoodsData_show.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                Response.Redirect("GoodsData_update.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
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

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("main_1.aspx");
        }
    }
}