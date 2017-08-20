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
 public partial class CarWeiZhangView: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarWeiZhang Model = new FTD.BLL.ERPCarWeiZhang();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.lblCarName.Text=Model.CarName.ToString();
			this.lblWZDate.Text=Model.WZDate.ToString();
			this.lblDriverUser.Text=Model.DriverUser.ToString();
			this.lblKouFenNum.Text=Model.KouFenNum.ToString();
			this.lblFKJinE.Text=Model.FKJinE.ToString();
			this.lblBackInfo.Text=Model.BackInfo.ToString();
			
		}
	}
}
}