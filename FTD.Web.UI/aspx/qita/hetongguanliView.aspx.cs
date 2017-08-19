using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.qita
{
    public partial class hetongguanliAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FTD.Unit.PublicMethod.CheckSession();
                FTD.BLL.HTGL model = new FTD.BLL.HTGL();
                model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
                Hetongfenlei.Text = model.Hetongfenlei + "";
                Bianhao.Text = model.Bianhao + "";
                Jiafang.Text = model.Jiafang + "";
                Yifang.Text = model.Yifang + "";
                Hetongjine.Text = model.Hetongjine + "";
                Hetongqixian.Text = model.Hetongqixian.ToShortDateString().ToString();
                Qiandingriqi.Text = model.Qiandingriqi.ToShortDateString().ToString();
                Neirong.Text = model.Neirong + "";
                FujianXiazai.NavigateUrl = model.Fujian;
            }
        }
    }
}