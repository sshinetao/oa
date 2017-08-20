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
 public partial class CarBaoXianAdd: System.Web.UI.Page
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
		FTD.BLL.ERPCarBaoXian Model = new FTD.BLL.ERPCarBaoXian();
		
		Model.CarName=this.txtCarName.Text.ToString();
		Model.FeiYongName=this.txtFeiYongName.Text.ToString();
		//Model.ProjectName=;
		Model.BaoXianPrice=this.txtBaoXianPrice.Text.ToString();
		Model.BaoXianDate=this.txtBaoXianDate.Text.ToString();
		Model.TiXingDate=this.txtTiXingDate.Text.ToString();
        Model.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName"); ;
        Model.TimeStr = DateTime.Parse(this.txtProjectName.Text.ToString());
		Model.BackInfo=this.txtBackInfo.Text.ToString();
		
		Model.Add();
		
		FTD.Unit.MessageBox.ShowAndRedirect(this, "车辆保险/年检信息添加成功！", "CarBaoXian.aspx");
	}
}
}