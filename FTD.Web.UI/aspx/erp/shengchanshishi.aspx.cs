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

namespace FTD.Web.UI.aspx.erp
{
    public partial class shengchanshishi : System.Web.UI.Page
    {
        Db List = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
           
            string SQL_GetList_xs = "select * from shengchanshishi  order by id desc";
            Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
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
            this.ImageButton4.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton4_Click);
            this.ImageButton5.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton5_Click);
            this.ImageButton6.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton6_Click);
            this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
            this.Load += new System.EventHandler(this.Page_Load);

        }
        #endregion
        private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("main_1.aspx");
        }

        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }
        private void ImageButton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("shengchanshishi_add.aspx");
        }
        private void ImageButton6_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {

                string sql_insert_xtrz = "insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('删除[生产计划实施情况]','实施情况','" + this.Session["UserName"] + "','" + this.Session["TrueName"] + "','" + System.DateTime.Now.ToString() + "')";
                List.ExeSql(sql_insert_xtrz);


                string SQL_Del = "Delete from shengchanshishi  where id='" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "'";

                List.ExeSql(SQL_Del);

                Response.Redirect("shengchanshishi.aspx");

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
            }
        }

        private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {

                Response.Redirect("shengchanshishi_update.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

    }
}