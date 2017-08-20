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
 public partial class CarBaoYangView: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarBaoYang Model = new FTD.BLL.ERPCarBaoYang();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.lblCarName.Text=Model.CarName.ToString();
			this.lblBYDate.Text=Model.BYDate.ToString();
			this.lblJingBanUser.Text=Model.JingBanUser.ToString();
			this.lblZhuGuanUser.Text=Model.ZhuGuanUser.ToString();

			this.lblQiYouJinE.Text=Model.QiYouJinE.ToString();

			this.lblOtherJinE.Text=Model.OtherJinE.ToString();

			this.lblBackInfo.Text=Model.BackInfo.ToString();
			
		}
	}
}
}