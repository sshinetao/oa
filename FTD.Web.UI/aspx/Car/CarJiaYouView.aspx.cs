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
 public partial class CarJiaYouView: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarJiaYou Model = new FTD.BLL.ERPCarJiaYou();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.lblCarName.Text=Model.CarName.ToString();
			this.lblJYDate.Text=Model.JYDate.ToString();
			this.lblJingBanUser.Text=Model.JingBanUser.ToString();
			this.lblDriverUser.Text=Model.DriverUser.ToString();
			this.lblJiaYouAddress.Text=Model.JiaYouAddress.ToString();
			this.lblBackInfo.Text=Model.BackInfo.ToString();
			
		}
	}
}
}