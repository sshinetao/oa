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
 public partial class CarBaoYangModify: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarBaoYang Model = new FTD.BLL.ERPCarBaoYang();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.txtCarName.Text=Model.CarName.ToString();
			this.txtBYDate.Text=Model.BYDate.ToString();
			this.txtJingBanUser.Text=Model.JingBanUser.ToString();
			this.txtZhuGuanUser.Text=Model.ZhuGuanUser.ToString();
			this.txtQiYouJinE.Text=Model.QiYouJinE.ToString();
			this.txtOtherJinE.Text=Model.OtherJinE.ToString();
			this.txtBackInfo.Text=Model.BackInfo.ToString();
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
		FTD.BLL.ERPCarBaoYang Model = new FTD.BLL.ERPCarBaoYang();
		
		Model.ID = int.Parse(Request.QueryString["ID"].ToString());
		Model.CarName=this.txtCarName.Text.ToString();
		Model.BYDate=this.txtBYDate.Text.ToString();
		Model.JingBanUser=this.txtJingBanUser.Text.ToString();
		Model.ZhuGuanUser=this.txtZhuGuanUser.Text.ToString();
		Model.QiYouJinE=this.txtQiYouJinE.Text.ToString();
		Model.OtherJinE=this.txtOtherJinE.Text.ToString();
		Model.BackInfo=this.txtBackInfo.Text.ToString();
		
		Model.Update();
		
		FTD.Unit.MessageBox.ShowAndRedirect(this, "驾驶员违章信息修改成功！", "CarBaoYang.aspx");
	}
}
}