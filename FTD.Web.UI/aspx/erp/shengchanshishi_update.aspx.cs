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
    /// <summary>
    /// shengchanshishi_update 的摘要说明。
    /// </summary>
    public partial class shengchanshishi_update : System.Web.UI.Page
    {
        protected System.Web.UI.WebControls.ImageButton ImageButton1;
        protected System.Web.UI.WebControls.ImageButton ImageButton2;
        protected System.Web.UI.WebControls.TextBox zhongzhijidi;
        protected System.Web.UI.WebControls.TextBox zhongzhipinming;
        protected System.Web.UI.WebControls.TextBox mianji;
        protected System.Web.UI.WebControls.TextBox yujichanliang;
        protected System.Web.UI.WebControls.TextBox shougoujiage;
        protected System.Web.UI.WebControls.TextBox zhongzhishijian;
        protected System.Web.UI.WebControls.TextBox caishoushijian;
        Db List = new Db();
        private void Page_Load(object sender, System.EventArgs e)
        {
            FTD.Unit.PublicMethod.CheckSession();

            if (!Page.IsPostBack)
            {
                this.ImageButton1.Attributes.Add("onclick", "javascript:return chknull();");
            }
            if (!IsPostBack)
            {
                string SQL_GetList = "select * from shengchanshishi  where id='" + int.Parse(Request.QueryString["id"]) + "'";
                OleDbDataReader NewReader = List.GetList(SQL_GetList);
                if (NewReader.Read())
                {
                    zhongzhijidi.Text = NewReader["zhongzhijidi"].ToString();
                    zhongzhipinming.Text = NewReader["zhongzhipinming"].ToString();
                    mianji.Text = NewReader["mianji"].ToString();
                    yujichanliang.Text = NewReader["yujichanliang"].ToString();
                    shougoujiage.Text =  NewReader["hetongjiage"] + "";
                    zhongzhishijian.Text = NewReader["zhongzhishijian"].ToString();
                    caishoushijian.Text = NewReader["caishoushijian"].ToString();
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
            this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
            this.Load += new System.EventHandler(this.Page_Load);

        }
        #endregion

        private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            string sql_insert_xtrz = "insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('修改[生产计划实施情况]','实施情况','" + this.Session["UserName"] + "','" + this.Session["TrueName"] + "','" + System.DateTime.Now.ToString() + "')";
            List.ExeSql(sql_insert_xtrz);


            string Sql_update = "Update shengchanshishi Set zhongzhijidi='" + zhongzhijidi.Text + "',zhongzhipinming='" + zhongzhipinming.Text + "',mianji='" + mianji.Text + "',yujichanliang='" + yujichanliang.Text + "',hetongjiage='" + shougoujiage.Text + "',zhongzhishijian='" + zhongzhishijian.Text + "',caishoushijian='" + caishoushijian.Text + "' where id='" + int.Parse(Request.QueryString["id"]) + "'";
            List.ExeSql(Sql_update);
            this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='shengchanshishi.aspx'</script>");
        }

        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("shengchanshishi.aspx");
        }
    }
}
