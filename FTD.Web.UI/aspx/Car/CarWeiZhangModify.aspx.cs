﻿using System;
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
 public partial class CarWeiZhangModify: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarWeiZhang Model = new FTD.BLL.ERPCarWeiZhang();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.txtCarName.Text=Model.CarName.ToString();
			this.txtWZDate.Text=Model.WZDate.ToString();
			this.txtDriverUser.Text=Model.DriverUser.ToString();
			this.txtKouFenNum.Text=Model.KouFenNum.ToString();
			this.txtFKJinE.Text=Model.FKJinE.ToString();
			this.txtBackInfo.Text=Model.BackInfo.ToString();
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
		FTD.BLL.ERPCarWeiZhang Model = new FTD.BLL.ERPCarWeiZhang();
		
		Model.ID = int.Parse(Request.QueryString["ID"].ToString());
		Model.CarName=this.txtCarName.Text.ToString();
		Model.WZDate=this.txtWZDate.Text.ToString();
		Model.DriverUser=this.txtDriverUser.Text.ToString();
		Model.KouFenNum=this.txtKouFenNum.Text.ToString();
		Model.FKJinE=this.txtFKJinE.Text.ToString();
		Model.BackInfo=this.txtBackInfo.Text.ToString();
		
		Model.Update();
		
		FTD.Unit.MessageBox.ShowAndRedirect(this, "车辆事故信息修改成功！", "CarWeiZhang.aspx");
	}
}
}