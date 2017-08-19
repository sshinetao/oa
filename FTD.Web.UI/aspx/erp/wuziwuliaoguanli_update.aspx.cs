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
    /// wuziwuliaoguanli_update 的摘要说明。
    /// </summary>
    public partial class wuziwuliaoguanli_update : System.Web.UI.Page
    {
 
  
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
                string SQL_GetList = "select * from wuziwuliaoguanli  where id='" + int.Parse(Request.QueryString["id"]) + "'";
                OleDbDataReader NewReader = List.GetList(SQL_GetList);
                if (NewReader.Read())
                {
                    zhongzhijidi.Text = NewReader["zhongzhijidi"].ToString();
                    zhongzhihu.Text = NewReader["zhongzhihu"].ToString();
                    wuzi.Text = NewReader["wuzi"].ToString();
                    shuliang.Text = NewReader["shuliang"].ToString();
                    jiage.Text = NewReader["jiage"].ToString();
                    jine.Text = NewReader["jine"].ToString();
                    zhuangtai.Text = NewReader["zhuangtai"].ToString();
                }
            }
            //默认选中

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
            
            string Sql_update = "Update wuziwuliaoguanli Set zhongzhijidi='" + zhongzhijidi.Text + "',zhongzhihu='" + zhongzhihu.Text + "',wuzi='" + wuzi.Text + "',shuliang='" + shuliang.Text + "',jiage='" + jiage.Text + "',jine='" + jine.Text + "',zhuangtai='" + zhuangtai.Text +  "' where id='" + int.Parse(Request.QueryString["id"]) + "'";
            List.ExeSql(Sql_update);
            this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='wuziwuliaoguanli.aspx'</script>");
        }

        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("wuziwuliaoguanli.aspx");
        }

        private void selectOp() {
            string val = zhuangtai.Text;
            if (val.IndexOf("现结") > 0)
            {
                zhuangtai.SelectedIndex = 1;
            }
            zhuangtai.DataBind();
        }
    }
}
