//文件名:QueryDepartmentForm.aspx.cs
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

public partial class QueryManage_QueryDepartmentForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string MyForbidString = Session["MyForbid"].ToString();
        if (MyForbidString.IndexOf("D2") > 1)
        {
            Server.Transfer("~/SystemManage/AllErrorHelp.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {//打印部门员工基本人事档案信息
        Server.Transfer("~/QueryManage/QueryDepartmentPrint.aspx");
    }
    public string MyPrintSQL
    {//设置要传递到打印页的数据
        get
        {
            return "SELECT [员工编号], [姓名], [性别], [出生日期], [身份证号码], [民族], [籍贯], [政治面貌], [婚姻状况], [文化程度], [职务], [毕业院校], [职称], [进入公司时间], [合同服务年限], [基本工资], [银行账号], [养老保险账号], [医疗保险账号], [住房基金账号], [联系电话], [手机号码], [电子信箱], [家庭住址], [邮政编码], [补充说明] FROM [在职员工视图] WHERE ([所属部门] ='"+this.DropDownList1.SelectedValue.ToString()+"')";
        }
    }
    public String MyPrintDate
    {//设置要传递到打印页的数据
        get
        {
            return "打印日期：" + DateTime.Now.ToShortDateString();
        }
    }
    public String MyPrintTitle
    {//设置要传递到打印页的数据
        get
        {
            return Session["MyCompanyName"].ToString() + this.DropDownList1.SelectedValue.ToString() + "员工基本人事档案表";
        }
    }
}
