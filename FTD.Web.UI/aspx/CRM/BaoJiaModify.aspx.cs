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

namespace OA.aspx.CRM{ 
 public partial class BaoJiaModify: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();
            FTD.BLL.ERPBaoJia model = new FTD.BLL.ERPBaoJia();
            model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
            this.txtCustomName.Text = model.CustomName;
            this.txtBaoJiaTitle.Text = model.BaoJiaTitle;
            this.txtBaoJiaType.Text = model.BaoJiaType;
            this.txtBaoJiaJinE.Text = model.BaoJiaJinE;
            this.txtBaoJiaContent.Text = model.BaoJiaContent;
            this.txtBaoJiaResult.Text = model.BaoJiaResult;
            this.txtBaoJiaTime.Text = model.BaoJiaTime;
            this.txtBackInfo.Text = model.BackInfo;
            this.Label1.Text = model.UserName;
            this.Label2.Text = model.TimeStr.ToString();
            this.txtIFShare.Text = model.IFShare;
            this.txtCusBakA.Text = model.CusBakA;
            this.txtCusBakB.Text = model.CusBakB;
            this.txtCusBakC.Text = model.CusBakC;
            this.txtCusBakD.Text = model.CusBakD;
            this.txtCusBakE.Text = model.CusBakE;
        }
    }
    protected void iButton1_Click(object sender, EventArgs e)
    {
        FTD.BLL.ERPBaoJia model = new FTD.BLL.ERPBaoJia();
        model.ID = int.Parse(Request.QueryString["ID"].ToString());
        model.CustomName = this.txtCustomName.Text;
        model.BaoJiaTitle = this.txtBaoJiaTitle.Text;
        model.BaoJiaType = this.txtBaoJiaType.Text;
        model.BaoJiaJinE = this.txtBaoJiaJinE.Text;
        model.BaoJiaContent = this.txtBaoJiaContent.Text;
        model.BaoJiaResult = this.txtBaoJiaResult.Text;
        model.BaoJiaTime = this.txtBaoJiaTime.Text;
        model.BackInfo = this.txtBackInfo.Text;
        model.UserName =this.Label1.Text;
        model.TimeStr = DateTime.Parse(this.Label2.Text);
        model.IFShare = this.txtIFShare.Text;
        model.CusBakA = this.txtCusBakA.Text;
        model.CusBakB = this.txtCusBakB.Text;
        model.CusBakC = this.txtCusBakC.Text;
        model.CusBakD = this.txtCusBakD.Text;
        model.CusBakE = this.txtCusBakE.Text;
        model.Update();

        //写系统日志
        FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
        MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户修改报价记录(" + this.txtCustomName.Text + ")";
        MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
        MyRiZhi.Add();

        FTD.Unit.MessageBox.ShowAndRedirect(this, "报价信息修改成功！", "MyCustomPrice.aspx?CustomName=" + Request.QueryString["CustomName"].ToString());
    }
}}