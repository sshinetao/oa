using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace OA.aspx.Car
{
    public partial class CarNianJianModify : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FTD.Unit.PublicMethod.CheckSession();
                FTD.BLL.ERPCarNianJian Model = new FTD.BLL.ERPCarNianJian();
                Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));

                this.txtCarName.Text = Model.Carname.ToString();
                this.txtUsername.Text = Model.Username.ToString();
                this.txtChejiandate.Text = Model.Chejiandate.ToString();
                this.txtTimestr.Text = Model.Timestr.Value.ToShortDateString().ToString();
                this.txtBackInfo.Text = Model.Backinfo.ToString();
            }
        }
        protected void iButton1_Click(object sender, EventArgs e)
        {
            FTD.BLL.ERPCarNianJian Model = new FTD.BLL.ERPCarNianJian();
            DateTime dt = DateTime.Now;
            DateTime Timestr = DateTime.Parse(this.txtTimestr.Text);

            Model.ID = int.Parse(Request.QueryString["ID"].ToString());
            Model.Carname = this.txtCarName.Text.ToString();
            Model.Chejiandate = this.txtChejiandate.Text.ToString();
            Model.Backinfo = this.txtBackInfo.Text.ToString();
            Model.Username = this.txtUsername.Text.ToString();
            Model.Timestr = Timestr;

            Model.Update();

            //写系统日志
            FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
            MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户修改培训学习信息(" + this.txtCarName.Text + ")";
            MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
            MyRiZhi.Add();

            FTD.Unit.MessageBox.ShowAndRedirect(this, "驾驶员培训学习信息修改成功！", "CarNianJian.aspx");
        }
    }
}