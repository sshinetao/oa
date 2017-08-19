using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.qita
{
    public partial class rongyuguanliView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Unit.PublicMethod.CheckSession();
                BLL.RYGL Model = new BLL.RYGL();
                Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
                mingcheng.Text = Model.Mingcheng + "";
                leibie.Text = Model.Leibie + "";
                banfabumen.Text = Model.Banfabumen + "";
                banfashijian.Text =  Model.Banfashijian.ToString("yyyy-MM-dd");
                youxiaoqi.Text = Model.Youxiaoqi + "";

            }
        }
    }
}