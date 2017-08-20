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
 public partial class CarShiYongAdd: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();
			
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
		FTD.BLL.ERPCarShiYong Model = new FTD.BLL.ERPCarShiYong();
		
		Model.CarName=this.txtCarName.Text.ToString();
		Model.YongCheUser=this.txtYongCheUser.Text.ToString();
		Model.QiShiTime=this.txtQiShiTime.Text.ToString();
		Model.JieShuTime=this.txtJieShuTime.Text.ToString();
		Model.MuDiDi=this.txtMuDiDi.Text.ToString();
		Model.ShengQingShiYou=this.txtShengQingShiYou.Text.ToString();
		Model.NowState="";
		Model.UserName=FTD.Unit.PublicMethod.GetSessionValue("UserName");
		Model.TimeStr=DateTime.Now;
		Model.BackInfo=this.txtBackInfo.Text.ToString();
		
		Model.Add();

        FTD.Unit.MessageBox.ShowAndRedirect(this, "车辆使用信息添加成功！", "CarShiYong.aspx");
	}
}
}