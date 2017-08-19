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

namespace FTD.Web.UI.aspx.erp
{
    public partial class wuziwuliaoguanli_add : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.ImageButton ImageButton1;
        protected System.Web.UI.WebControls.ImageButton ImageButton2;
        protected System.Web.UI.WebControls.TextBox zhongzhijidi;
        protected System.Web.UI.WebControls.TextBox zhongzhihu;
        protected System.Web.UI.WebControls.TextBox wuzi;
        protected System.Web.UI.WebControls.TextBox shuliang;
        protected System.Web.UI.WebControls.TextBox jiage;
        protected System.Web.UI.WebControls.TextBox jine;
        protected System.Web.UI.WebControls.DropDownList zhuangtai;


        Db List = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            FTD.Unit.PublicMethod.CheckSession();

            if (!Page.IsPostBack)
            {
                this.ImageButton1.Attributes.Add("onclick", "javascript:return chknull();");
            }
        }
        override protected void OnInit(EventArgs e)
        {
            //
            // CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
            //
            InitializeComponent();
            base.OnInit(e);
        }
        private void InitializeComponent()
        {
            this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
            this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
            this.Load += new System.EventHandler(this.Page_Load);

        }

        private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string SQL_Check_worknum = "select * from wuziwuliaoguanli where zhongzhijidi='" + zhongzhijidi.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") + "'";
            OleDbDataReader MyReader_worknum = List.GetList(SQL_Check_worknum);
            if (MyReader_worknum.Read())
            {
                this.Response.Write("<script language=javascript>alert('种植基地名称不能重复！');</script>");
            }
            else
            {
 

            string sql_insert = @"INSERT INTO [dbo].[wuziwuliaoguanli]   ( [zhongzhijidi] ,  [zhongzhihu] ,   [wuzi] ,   [shuliang] ,  [jiage] ,  [jine] ,  [zhuangtai] )
            SELECT    '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}' ";
            sql_insert = string.Format(sql_insert,zhongzhijidi.Text,zhongzhihu.Text,wuzi.Text,shuliang.Text,jiage.Text,jine.Text,zhuangtai.Text);
             List.ExeSql(sql_insert);
            this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='wuziwuliaoguanli.aspx'</script>");

            }

        }

        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("wuziwuliaoguanli.aspx");
        }
    }
}