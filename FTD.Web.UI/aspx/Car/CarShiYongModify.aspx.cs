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
 public partial class CarShiYongModify: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			FTD.BLL.ERPCarShiYong Model = new FTD.BLL.ERPCarShiYong();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.txtCarName.Text=Model.CarName.ToString();
			this.txtYongCheUser.Text=Model.YongCheUser.ToString();
			this.txtQiShiTime.Text=Model.QiShiTime.ToString();
			this.txtJieShuTime.Text=Model.JieShuTime.ToString();
			this.txtMuDiDi.Text=Model.MuDiDi.ToString();
			this.txtShengQingShiYou.Text=Model.ShengQingShiYou.ToString();
			this.txtBackInfo.Text=Model.BackInfo.ToString();
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
		FTD.BLL.ERPCarShiYong Model = new FTD.BLL.ERPCarShiYong();
		
		Model.ID = int.Parse(Request.QueryString["ID"].ToString());
		Model.CarName=this.txtCarName.Text.ToString();
		Model.YongCheUser=this.txtYongCheUser.Text.ToString();
		Model.QiShiTime=this.txtQiShiTime.Text.ToString();
		Model.JieShuTime=this.txtJieShuTime.Text.ToString();
		Model.MuDiDi=this.txtMuDiDi.Text.ToString();
		Model.ShengQingShiYou=this.txtShengQingShiYou.Text.ToString();
		Model.NowState="";
		Model.BackInfo=this.txtBackInfo.Text.ToString();
		
		Model.Update();

        FTD.Unit.MessageBox.ShowAndRedirect(this, "车辆使用信息修改成功！", "CarShiYong.aspx");
	}
}
}