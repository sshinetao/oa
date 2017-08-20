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
 public partial class CarJiaYouModify: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarJiaYou Model = new FTD.BLL.ERPCarJiaYou();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.txtCarName.Text=Model.CarName.ToString();
			this.txtJYDate.Text=Model.JYDate.ToString();
			this.txtJingBanUser.Text=Model.JingBanUser.ToString();
			this.txtDriverUser.Text=Model.DriverUser.ToString();
			this.txtJiaYouAddress.Text=Model.JiaYouAddress.ToString();
			this.txtBackInfo.Text=Model.BackInfo.ToString();
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
		FTD.BLL.ERPCarJiaYou Model = new FTD.BLL.ERPCarJiaYou();
		
		Model.ID = int.Parse(Request.QueryString["ID"].ToString());
		Model.CarName=this.txtCarName.Text.ToString();
		Model.JYDate=this.txtJYDate.Text.ToString();
		Model.JingBanUser=this.txtJingBanUser.Text.ToString();
		Model.DriverUser=this.txtDriverUser.Text.ToString();
		Model.JiaYouAddress=this.txtJiaYouAddress.Text.ToString();
		Model.BackInfo=this.txtBackInfo.Text.ToString();
		
		Model.Update();
		
		FTD.Unit.MessageBox.ShowAndRedirect(this, "车辆加油记录信息修改成功！", "CarJiaYou.aspx");
	}
}
}