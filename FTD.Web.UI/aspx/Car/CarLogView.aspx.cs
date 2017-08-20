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
 public partial class CarLogView: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarLog Model = new FTD.BLL.ERPCarLog();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.lblCarName.Text=Model.CarName.ToString();
			this.lblLogDate.Text=Model.LogDate.ToString();
			this.lblJingBanUser.Text=Model.JingBanUser.ToString();
			this.lblDriverUser.Text=Model.DriverUser.ToString();
			this.lblChuCheDate.Text=Model.ChuCheDate.ToString();
			this.lblXingShiTime.Text=Model.XingShiTime.ToString();

			this.lblXingShiLiCheng.Text=Model.XingShiLiCheng.ToString();
			this.lblYouHaoShu.Text=Model.YouHaoShu.ToString();
			this.lblBackInfo.Text=Model.BackInfo.ToString();
			
		}
	}
}
}