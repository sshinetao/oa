using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.qita
{
    public partial class qitaziliaoguanliView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Unit.PublicMethod.CheckSession();
                BLL.QTZLGL model = new BLL.QTZLGL();
                model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
                leibie.Text = model.Leibie + "";
                beizhu.Text = model.Beizhu + "";
                guidangshijian.Text = model.Guidangshijian.ToShortDateString().ToString();
                neirongjianjie.Text = model.Neirongjianjie + "";
                mingcheng.Text = model.Mingcheng + "";
            }
        }
    }
}