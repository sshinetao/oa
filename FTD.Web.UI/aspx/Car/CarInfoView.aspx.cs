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
 public partial class CarInfoView: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarInfo Model = new FTD.BLL.ERPCarInfo();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
                this.lblCarName.Text = Model.CarName.ToString();
                this.lblCarPaiHao.Text = Model.CarPaiHao.ToString();
                this.lblLeiXing.Text = Model.LeiXing.ToString();
                this.lblDunwei.Text = Model.Dunwei.ToString();
                this.lblGps.Text = Model.Gps.ToString();
                this.lblGouche.Text = Model.Gouche.ToString();
                this.lblFapiao.Text = Model.Fapiao.ToString();
                this.lblBackInfo.Text = Model.BackInfo.ToString();
			
		}
	}
}
}