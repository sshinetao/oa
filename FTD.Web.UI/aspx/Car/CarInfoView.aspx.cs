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

namespace OA.aspx.Car{ 
 public partial class CarInfoView: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarInfo Model = new FTD.BLL.ERPCarInfo();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
                this.lblCarName.Text = Model.CarName.ToString();
                this.lblCarPaiHao.Text = Model.CarPaiHao.ToString();
                this.lblLeiXing.Text = Model.LeiXing.ToString();
                this.lblDunwei.Text = Model.Dunwei.ToString();
                this.lblGps.Text = Model.Gps.ToString();
                this.lblGouche.Text = Model.Gouche.ToString();
                this.lblFapiao.Text = Model.Fapiao.ToString();
                this.lblBackInfo.Text = Model.BackInfo.ToString();

                //写系统日志
                FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
			MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户查看车辆管理信息(" + this.lblCarName.Text + ")";
			MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
			MyRiZhi.Add();
			
		}
	}
}
}