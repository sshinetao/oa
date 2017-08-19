﻿using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qpsmartweb_jxc
{
    public partial class open_rukuleixing : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.TextBox name;
        protected System.Web.UI.WebControls.ImageButton ImageButton2;
        protected System.Web.UI.WebControls.DataGrid Datagrid2;
        Db List = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            FTD.Unit.PublicMethod.CheckSession();

            if (!Page.IsPostBack)
            {
                name.Attributes["onkeydown"] = "if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
            }

            if (Request.QueryString["name"] != null)
            {


                string SQL_GetList_xs = "select * from rukuleixing where Name like '%" + Server.UrlDecode(Request.QueryString["name"]) + "%' order by id desc";
                Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                Datagrid2.DataBind();

            }
            else
            {
                string SQL_GetList_xs = "select * from rukuleixing order by id desc";
                Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
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
            this.Load += new System.EventHandler(this.Page_Load);

        }
        #endregion
        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }

        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("open_rukuleixing.aspx?name=" + name.Text + "");
        }
    }
}