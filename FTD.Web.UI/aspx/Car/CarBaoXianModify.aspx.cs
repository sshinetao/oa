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
 public partial class CarBaoXianModify: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarBaoXian Model = new FTD.BLL.ERPCarBaoXian();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.txtCarName.Text=Model.CarName.ToString();
			this.txtFeiYongName.Text=Model.FeiYongName.ToString();
			this.txtBaoXianPrice.Text=Model.BaoXianPrice.ToString();
			this.txtBaoXianDate.Text=Model.BaoXianDate.ToString();
			this.txtTiXingDate.Text=Model.TiXingDate.ToString();
			this.txtProjectName.Text= Model.TimeStr.ToString();
            this.txtBackInfo.Text=Model.BackInfo.ToString();
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
		FTD.BLL.ERPCarBaoXian Model = new FTD.BLL.ERPCarBaoXian();
		
		Model.ID = int.Parse(Request.QueryString["ID"].ToString());
		Model.CarName=this.txtCarName.Text.ToString();
		Model.FeiYongName=this.txtFeiYongName.Text.ToString();
		Model.ProjectName=this.txtProjectName.Text.ToString();
		Model.BaoXianPrice=this.txtBaoXianPrice.Text.ToString();
		Model.BaoXianDate=this.txtBaoXianDate.Text.ToString();
		Model.TiXingDate=this.txtTiXingDate.Text.ToString();
		Model.TimeStr=DateTime.Parse(this.txtProjectName.Text);
		Model.BackInfo=this.txtBackInfo.Text.ToString();
		
		Model.Update();
		
		FTD.Unit.MessageBox.ShowAndRedirect(this, "车辆保险年检信息修改成功！", "CarBaoXian.aspx");
	}
}
}