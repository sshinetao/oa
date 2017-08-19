using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OA.aspx.Car
{
    public partial class CarNianJianView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FTD.Unit.PublicMethod.CheckSession();
                FTD.BLL.ERPCarNianJian Model = new FTD.BLL.ERPCarNianJian();
                 

                Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
                this.lblCarname.Text = Model.Carname.ToString();
                this.lblUsername.Text = Model.Username.ToString();
                this.lblChejiandate.Text = Model.Chejiandate.ToString();
                this.lblTimestr.Text = Model.Timestr.ToString();
                this.lblBackinfo.Text = Model.Backinfo.ToString();

                //写系统日志
                FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
                MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
                MyRiZhi.DoSomething = "用户查看驾驶员培训学习信息(" + this.lblCarname.Text + ")";
                MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
                MyRiZhi.Add();

            }
        }
    }
}