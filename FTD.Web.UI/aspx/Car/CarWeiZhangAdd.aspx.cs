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
 public partial class CarWeiZhangAdd: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			//设置上传的附件为空
			 FTD.Unit.PublicMethod.SetSessionValue("WenJianList", "");
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
		FTD.BLL.ERPCarWeiZhang Model = new FTD.BLL.ERPCarWeiZhang();
		
		Model.CarName=this.txtCarName.Text.ToString();
		Model.WZDate=this.txtWZDate.Text.ToString();
		Model.DriverUser=this.txtDriverUser.Text.ToString();
		Model.KouFenNum=this.txtKouFenNum.Text.ToString();
		Model.FKJinE=this.txtFKJinE.Text.ToString();
		Model.UserName=FTD.Unit.PublicMethod.GetSessionValue("UserName");
		Model.TimeStr=DateTime.Now;
		Model.BackInfo=this.txtBackInfo.Text.ToString();
		
		Model.Add();
		
		FTD.Unit.MessageBox.ShowAndRedirect(this, "车辆事故信息添加成功！", "CarWeiZhang.aspx");
	}
}
}