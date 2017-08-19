﻿//文件名:QueryCheckForm.aspx.cs
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

public partial class QueryManage_QueryCheckForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string MyForbidString = Session["MyForbid"].ToString();
        if (MyForbidString.IndexOf("D3") > 1)
        {
            Server.Transfer("~/SystemManage/AllErrorHelp.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {//打印公司月度考勤信息
        Server.Transfer("~/QueryManage/QueryCheckPrint.aspx");
    }
    public string MyPrintSQL
    {//设置要传递到打印页的数据
        get
        {
            return "SELECT * FROM [全部考勤视图] WHERE (([考勤年份] = '"+this.DropDownList1.SelectedValue.ToString()+"') AND ([考勤月份] = '"+this.DropDownList2.SelectedValue.ToString()+"'))";
        }
    }
    public String MyPrintDate
    {//设置要传递到打印页的数据
        get
        {
            return "考勤日期：" + this.DropDownList1.SelectedValue.ToString()+"年"+this.DropDownList2.SelectedValue.ToString()+"月";
        }
    }
    public String MyPrintTitle
    {//设置要传递到打印页的数据
        get
        {
            return Session["MyCompanyName"].ToString() + "员工月度考勤信息表";
        }
    }
}
