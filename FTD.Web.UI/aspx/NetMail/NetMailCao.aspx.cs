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

namespace OA.aspx.NetMail{ 
 public partial class NetMailCao: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();
            DataBindToGridview();

            //设定按钮权限
            iButton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|093A|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
            iButton2.Visible = FTD.Unit.PublicMethod.StrIFIn("|093M|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
            iButton3.Visible = FTD.Unit.PublicMethod.StrIFIn("|093D|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
            iButton5.Visible = FTD.Unit.PublicMethod.StrIFIn("|093E|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
        }
    }
    public void DataBindToGridview()
    {
        FTD.BLL.ERPNetEmail MyLanEmail = new FTD.BLL.ERPNetEmail();
        GVData.DataSource = MyLanEmail.GetList("EmailTitle like '%" + this.TextBox1.Text.Trim() + "%' and FromUser='" + FTD.Unit.PublicMethod.GetSessionValue("UserName") + "' and EmailState='草稿' order by ID desc");
        GVData.DataBind();
        LabPageSum.Text = Convert.ToString(GVData.PageCount);
        LabCurrentPage.Text = Convert.ToString(((int)GVData.PageIndex + 1));
        this.GoPage.Text = LabCurrentPage.Text.ToString();
    }
    #region  分页方法
    protected void ButtonGo_Click(object sender, EventArgs e)
    {
        try
        {
            if (GoPage.Text.Trim().ToString() == "")
            {
                Response.Write("<script language='javascript'>alert('页码不可以为空!');</script>");
            }
            else if (GoPage.Text.Trim().ToString() == "0" || Convert.ToInt32(GoPage.Text.Trim().ToString()) > GVData.PageCount)
            {
                Response.Write("<script language='javascript'>alert('页码不是一个有效值!');</script>");
            }
            else if (GoPage.Text.Trim() != "")
            {
                int PageI = Int32.Parse(GoPage.Text.Trim()) - 1;
                if (PageI >= 0 && PageI < (GVData.PageCount))
                {
                    GVData.PageIndex = PageI;
                }
            }

            if (TxtPageSize.Text.Trim().ToString() == "")
            {
                Response.Write("<script language='javascript'>alert('每页显示行数不可以为空!');</script>");
            }
            else if (TxtPageSize.Text.Trim().ToString() == "0")
            {
                Response.Write("<script language='javascript'>alert('每页显示行数不是一个有效值!');</script>");
            }
            else if (TxtPageSize.Text.Trim() != "")
            {
                try
                {
                    int MyPageSize = int.Parse(TxtPageSize.Text.ToString().Trim());
                    this.GVData.PageSize = MyPageSize;
                }
                catch
                {
                    Response.Write("<script language='javascript'>alert('每页显示行数不是一个有效值!');</script>");
                }
            }

            DataBindToGridview();
        }
        catch
        {
            DataBindToGridview();
            Response.Write("<script language='javascript'>alert('请输入有效数字！');</script>");
        }
    }
    protected void PagerButtonClick(object sender, EventArgs e)
    {
        //获得Button的参数值
        string arg = ((ImageButton)sender).CommandName.ToString();
        switch (arg)
        {
            case ("Next"):
                if (this.GVData.PageIndex < (GVData.PageCount - 1))
                    GVData.PageIndex++;
                break;
            case ("Pre"):
                if (GVData.PageIndex > 0)
                    GVData.PageIndex--;
                break;
            case ("Last"):
                try
                {
                    GVData.PageIndex = (GVData.PageCount - 1);
                }
                catch
                {
                    GVData.PageIndex = 0;
                }

                break;
            default:
                //本页值
                GVData.PageIndex = 0;
                break;
        }
        DataBindToGridview();
    }
    #endregion
    protected void GVData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        FTD.Unit.PublicMethod.GridViewRowDataBound(e);
    }
    protected void iButton4_Click(object sender, EventArgs e)
    {
        DataBindToGridview();
    }
    protected void iButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("NetEmailAdd.aspx");
    }
    protected void iButton2_Click(object sender, EventArgs e)
    {
        string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
        if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("update ERPNetEmail set EmailState='已发' where ID in (" + IDlist + ")") == -1)
        {
            Response.Write("<script>alert('发送邮件时发生错误！请重新登陆后重试！');</script>");
        }
        else
        {
            string[] IDArray = IDlist.Split(',');
            for (int jk = 0; jk < IDArray.Length; jk++)
            {
                if (IDArray[jk].Trim().Length > 0 && IDArray[jk].Trim() != "0")
                {
                    FTD.BLL.ERPNetEmail MyModel = new FTD.BLL.ERPNetEmail();
                    MyModel.GetModel(int.Parse(IDArray[jk].Trim()));
                    //Jmail发送邮件到InterNet                    
                    FTD.BLL.ERPPOPAndSMTP MySMTPModel = new FTD.BLL.ERPPOPAndSMTP();
                    MySMTPModel.GetModel(int.Parse(FTD.Unit.PublicMethod.GetSessionValue("UserID")));
                    //发送邮件到Internet地址
                    try
                    {
                        Pop3ForJmail.SendMail(MySMTPModel.SMTPUserName, MySMTPModel.SMTPUserPwd, MySMTPModel.SMTPServer, MyModel.EmailTitle, MyModel.EmailContent, MySMTPModel.SMTPFromEmail, MyModel.ToUser, MyModel.FuJian);
                    }
                    catch
                    {
                        //Response.Write("<script>alert('发送邮件时发生错误，请检查您的邮件参数设置是否正确！');</script>");
                    }
                }
            }

            DataBindToGridview();
            //写系统日志
            FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
            MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户发送草稿箱中的邮件";
            MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
            MyRiZhi.Add();

            Response.Write("<script>alert('邮件发送完毕！');</script>");
        }
    }
    protected void iButton3_Click(object sender, EventArgs e)
    {
        string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
        if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("delete from ERPNetEmail where ID in (" + IDlist + ")") == -1)
        {
            Response.Write("<script>alert('删除选中记录时发生错误！请重新登陆后重试！');</script>");
        }
        else
        {
            DataBindToGridview();
            //写系统日志
            FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
            MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "用户删除草稿箱中的邮件";
            MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
            MyRiZhi.Add();
        }
    }
    protected void iButton5_Click(object sender, EventArgs e)
    {
        string IDList = "0";
        for (int i = 0; i < GVData.Rows.Count; i++)
        {
            Label LabVis = (Label)GVData.Rows[i].FindControl("LabVisible");
            IDList = IDList + "," + LabVis.Text.ToString();
        }
        Hashtable MyTable = new Hashtable();
        MyTable.Add("EmailTitle", "邮件标题");
        MyTable.Add("ToUser", "接收人");
        MyTable.Add("TimeStr", "发送时间");
        MyTable.Add("EmailState", "邮件状态");
        FTD.Unit.DataToExcel.GridViewToExcel(FTD.DBUnit.DbHelperSQL.GetDataSet("select EmailTitle,ToUser,TimeStr,EmailState from ERPNetEmail where ID in (" + IDList + ") order by ID desc"), MyTable, "Excel报表");
    }
}}