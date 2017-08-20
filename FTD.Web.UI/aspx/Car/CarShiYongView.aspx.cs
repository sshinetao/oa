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
 public partial class CarShiYongView: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarShiYong Model = new FTD.BLL.ERPCarShiYong();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.lblCarName.Text=Model.CarName.ToString();
			this.lblYongCheUser.Text=Model.YongCheUser.ToString();
			this.lblQiShiTime.Text=Model.QiShiTime.ToString();
			this.lblJieShuTime.Text=Model.JieShuTime.ToString();
			this.lblMuDiDi.Text=Model.MuDiDi.ToString();
			this.lblShengQingShiYou.Text=Model.ShengQingShiYou.ToString();
			//this.lblNowState.Text=Model.NowState.ToString();
			this.lblBackInfo.Text=Model.BackInfo.ToString();
			
		}
	}
}
}