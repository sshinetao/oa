using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.qita
{
    public partial class qitaziliaoguanliAdd : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {

            BLL.QTZLGL model = new BLL.QTZLGL();
            model.Beizhu = beizhu.Text + "";
            model.Guidangshijian = DateTime.Parse(this.guidangshijian.Text);
            model.Mingcheng = mingcheng.Text + "";
            model.Leibie = leibie.SelectedValue;
            model.Neirongjianjie = neirongjianjie.Text + "";

            model.Add();

            //20170528 陶欣 写系统日志
            BLL.ERPRiZhi MyRiZhi = new BLL.ERPRiZhi();
            MyRiZhi.UserName = Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户其他资料管理添加(" + this.mingcheng.Text + ")";
            MyRiZhi.IpStr = HttpContext.Current.Request.UserHostAddress.ToString();
            MyRiZhi.Add();

            Unit.MessageBox.ShowAndRedirect(this, "户其他资料添加成功！", "qitaziliaoguanli.aspx");
        }
    }
}