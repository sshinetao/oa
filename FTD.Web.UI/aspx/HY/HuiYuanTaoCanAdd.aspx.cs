using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.HY
{
    public partial class HuiYuanTaoCanAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FTD.Unit.PublicMethod.CheckSession();
            }
        }


        protected void iButton1_Click(object sender, EventArgs e)
        {
            FTD.BLL.ERPHuiYuanTaoCan Model = new FTD.BLL.ERPHuiYuanTaoCan();
            Model.TaoCanName = this.txtNameStr.Text.ToString();
            Model.SendCount = GetInt(this.txtSendCount.Text.ToString());

           
            Model.Add();

            //写系统日志
            FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
            MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户添加会员套餐信息(" + this.txtNameStr.Text + ")";
            MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
            MyRiZhi.Add();

            FTD.Unit.MessageBox.ShowAndRedirect(this, "会员套餐添加成功！", "HuiYuanTaoCanView.aspx");
        }


        protected int GetInt(string str)
        {
            int i = 0;

            try
            {
                return int.Parse(str);

            }
            catch
            {
                return i;
            }
           

        }
    }
}