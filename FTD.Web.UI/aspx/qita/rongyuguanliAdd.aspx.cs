using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.qita
{
    public partial class rongyuguanliAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
 
            BLL.RYGL model = new BLL.RYGL();
            model.Banfabumen = banfabumen.Text;
            model.Banfashijian = DateTime.Parse(this.banfashijian.Text);
            model.Mingcheng = mingcheng.Text;
            model.Leibie = leibie.SelectedValue;
            model.Youxiaoqi = int.Parse(youxiaoqi.Text + "");

            model.Add();

            //20170528 陶欣 写系统日志
            BLL.ERPRiZhi MyRiZhi = new BLL.ERPRiZhi();
            MyRiZhi.UserName = Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户荣誉管理记录(" + this.mingcheng.Text + ")";
            MyRiZhi.IpStr = HttpContext.Current.Request.UserHostAddress.ToString();
            MyRiZhi.Add();

            Unit.MessageBox.ShowAndRedirect(this, "荣誉证书添加成功！", "rongyuguanli.aspx");
        }
    }
}