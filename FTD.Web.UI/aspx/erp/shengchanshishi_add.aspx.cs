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
    public partial class shengchanshishi_add : System.Web.UI.Page
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
            string SQL_Check_worknum = "select * from shengchanshishi where zhongzhijidi='" + zhongzhijidi.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") + "'";
            OleDbDataReader MyReader_worknum = List.GetList(SQL_Check_worknum);
            if (MyReader_worknum.Read())    
            {
                this.Response.Write("<script language=javascript>alert('种植基地名称不能重复！');</script>");
            }
            else
            {
                
                string sql_insert = "insert into shengchanshishi values('" + zhongzhijidi.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") + "','" +zhongzhipinming.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") + "','" + mianji.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") + "','0')";
                sql_insert = @"INSERT INTO dbo.shengchanshishi
                                        ( zhongzhijidi ,
                                          zhongzhipinming ,
                                          mianji ,
                                          yujichanliang ,
                                          hetongjiage ,
                                          zhongzhishijian ,
                                          caishoushijian
                                        )
                                VALUES  ( '{0}' ,   '{1}' ,   '{2}' ,  '{3}' ,   '{4}' ,  '{5}' ,   '{6}'  )	";
                sql_insert = string.Format(sql_insert,zhongzhijidi.Text,zhongzhipinming.Text,mianji.Text,yujichanliang.Text,shougoujiage.Text,zhongzhishijian.Text,caishoushijian.Text);
                List.ExeSql(sql_insert);
                this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='shengchanshishi.aspx'</script>");

            }

        }

        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("shengchanshishi.aspx");
        }
    }
}