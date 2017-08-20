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


            }
        }
    }
}