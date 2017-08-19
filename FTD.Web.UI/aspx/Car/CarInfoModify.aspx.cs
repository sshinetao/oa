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
 public partial class CarInfoModify: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarInfo Model = new FTD.BLL.ERPCarInfo();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.txtCarName.Text=Model.CarName.ToString();
			this.txtCarPaiHao.Text=Model.CarPaiHao.ToString();
			this.txtLeiXing.Text=Model.LeiXing.ToString();
			this.txtDunwei.Text=Model.Dunwei.ToString();
			this.txtGps.Text=Model.Gps.ToString();
			this.txtGouche.Text=Model.Gouche.ToString();
			this.txtFapiao.Text=Model.Fapiao.ToString();
			this.txtBackInfo.Text=Model.BackInfo.ToString();
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
		FTD.BLL.ERPCarInfo Model = new FTD.BLL.ERPCarInfo();
		
		Model.ID = int.Parse(Request.QueryString["ID"].ToString());
		Model.CarName=this.txtCarName.Text.ToString();
		Model.CarPaiHao=this.txtCarPaiHao.Text.ToString();
		Model.Dunwei=this.txtDunwei.Text.ToString();
		Model.LeiXing=this.txtLeiXing.Text.ToString();
		Model.Gouche= DateTime.Parse(this.txtGouche.Text);
		Model.Gps=this.txtGps.Text.ToString();
		Model.Fapiao=this.txtFapiao.Text.ToString();
		Model.BackInfo=this.txtBackInfo.Text.ToString();

            

            Model.Update();
		
		//写系统日志
		FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
		MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户修改车辆管理信息(" + this.txtCarName.Text + ")";
		MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
		MyRiZhi.Add();

        FTD.Unit.MessageBox.ShowAndRedirect(this, "车辆管理信息修改成功！", "CarInfo.aspx");
	}
}
}