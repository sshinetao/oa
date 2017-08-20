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
    public partial class CarNianJianAdd : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
             
        }
        protected void iButton1_Click(object sender, EventArgs e)
        {
            FTD.BLL.ERPCarNianJian Model = new FTD.BLL.ERPCarNianJian();
            DateTime dt = DateTime.Now;
            Model.Carname = this.txtCarName.Text.ToString();
            Model.Chejiandate = this.txtChejiandate.Text.ToString();
            Model.Username = this.txtUsername.Text.ToString();
            Model.Timestr = DateTime.Parse(this.txtTimestr.Text);
            Model.Backinfo = this.txtBackInfo.Text.ToString();

            Model.Add();

            FTD.Unit.MessageBox.ShowAndRedirect(this, "培训学习信息添加成功！", "CarNianJian.aspx");
        }
    }
}