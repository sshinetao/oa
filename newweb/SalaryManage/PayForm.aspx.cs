//文件名:PayForm.aspx.cs
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

public partial class SalaryManage_PayForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string MyForbidString = Session["MyForbid"].ToString();
        if (MyForbidString.IndexOf("C2") > 1)
        {
            Server.Transfer("~/SystemManage/AllErrorHelp.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {//打印月度部门员工工资发放信息
        Server.Transfer("~/SalaryManage/PayPrint.aspx");
    }
    public string MyPrintSQL
    {//设置要传递到打印页的数据
        get
        {
            return "SELECT * FROM [工资发放表] WHERE (([发放年份] ='" + this.DropDownList2.SelectedValue.ToString() + "') AND ([发放月份] = '" + this.DropDownList3.SelectedValue.ToString() + "') AND ([员工编号] IN (Select 员工编号 FROM 在职员工视图 WHERE 所属部门='" + this.DropDownList1.SelectedValue.ToString() + "')))";
        }
    }
    public String MyPrintDate
    {//设置要传递到打印页的数据
        get
        {
            return "日期：" + this.DropDownList2.SelectedValue.ToString() + "年" + this.DropDownList3.SelectedValue.ToString() + "月";
        }
    }
    public String MyPrintTitle
    {//设置要传递到打印页的数据
        get
        {
            return Session["MyCompanyName"].ToString() + this.DropDownList1.SelectedValue.ToString() + "员工工资发放表";
        }
    }

}
