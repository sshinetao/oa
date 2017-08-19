using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.oldcar
{
    public partial class OldCarView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FTD.Unit.PublicMethod.CheckSession();
                FTD.BLL.OldCar Model = new FTD.BLL.OldCar();
                Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
                this.lbltasknum.Text = Model.tasknum.ToString();
                this.lblhtnum.Text = Model.htnum.ToString();
                this.lblseller.Text = Model.seller.ToString();
                this.lblsell_tel.Text = Model.sell_tel.ToString();
                this.lblsell_coder.Text = Model.sell_coder.ToString();
                this.lblsell_address.Text = Model.sell_address.ToString();
                this.lblbuyer.Text = Model.buyer.ToString();
                this.lblbuy_tel.Text = Model.buy_tel.ToString();
                this.lblbuy_coder.Text = Model.buy_coder.ToString();
                this.lblbuy_address.Text = Model.buy_address.ToString();
                this.lblplat_num.Text = Model.plat_num.ToString();
                this.lbldengji_num.Text = Model.dengji_num.ToString();
                this.lblcartype.Text = Model.cartype.ToString();
                this.lblchejianum.Text = Model.chejianum.ToString();
                this.lblchangpai.Text = Model.changpai.ToString();
                this.lblzhuanru.Text = Model.zhuanru.ToString();
                this.lbloffer_time.Text = Model.offer_time.ToString();
                //写系统日志
                FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
                MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
                MyRiZhi.DoSomething = "用户查看二手车信息(" + this.lbltasknum.Text + ")";
                MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
                MyRiZhi.Add();
            }
        }
    }
}