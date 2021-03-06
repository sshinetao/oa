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

namespace OA.aspx.Moa.Work{ 
 public partial class WorkRiZhiModify: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();
            //绑定页面数据
            FTD.BLL.ERPWorkRiZhi Model = new FTD.BLL.ERPWorkRiZhi();
            Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
            this.TextBox1.Text = Model.TitleStr;
            this.TxtContent.Text = Model.ContentStr;
            this.TextBox5.Text = Model.TypeStr;
        }
    }
    protected void iButton1_Click(object sender, EventArgs e)
    {
        FTD.BLL.ERPWorkRiZhi Model = new FTD.BLL.ERPWorkRiZhi();
        Model.TitleStr = this.TextBox1.Text;
        Model.ContentStr = this.TxtContent.Text;
        Model.TypeStr = this.TextBox5.Text.Trim();
        Model.ID = int.Parse(Request.QueryString["ID"].ToString());
        Model.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
        Model.Update();

        //写系统日志
        FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
        MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户修改工作日志信息(" + this.TextBox1.Text + ")";
        MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
        MyRiZhi.Add();

        FTD.Unit.MessageBox.ShowAndRedirect(this, "工作日志修改成功！", "WorkRiZhi.aspx");
    }
}}