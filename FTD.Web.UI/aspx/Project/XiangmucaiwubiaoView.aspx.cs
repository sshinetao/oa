using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace FTD.Web.UI.aspx.Project
{
    public partial class XiangmucaiwubiaoView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Unit.PublicMethod.CheckSession();
                BLL.XMCWB model = new BLL.XMCWB();
                model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
                Kemu.Text = model.Kemu + "";
                Riqi.Text = model.Riqi + "";
                Jine.Text = model.Jine + "";
                Zhuangtai.Text = model.Zhuangtai + "";
            }
        }
    }
}