//文件名:Login.aspx.cs
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
//该源码下载自www.51aspx.com(５１ａｓｐｘ．ｃｏｍ)

using System.Data.SqlClient; 
public partial class System_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Session["MyUserName"] = "51aspx";
        System.Text.StringBuilder MyForbidString = new System.Text.StringBuilder();
        MyForbidString.Append("禁止操作权限：A1A2A3A4A5A6A7B1B2C1C2D1D2D3D4E1E2E3");
        string MyConnectionString = ConfigurationManager.ConnectionStrings["MyPersonnelDBConnectionString"].ConnectionString; ;
        string MySQL = "Select * From 操作用户 Where 用户名称='" + "51aspx" + "'";
        SqlDataAdapter MyAdapter = new SqlDataAdapter(MySQL, MyConnectionString);
        DataTable MyTable = new DataTable();
        MyAdapter.Fill(MyTable);
        if (MyTable.Rows.Count > 0)
        {
            if ((int)MyTable.Rows[0]["人事管理之员工基本档案"] == 1)
            {
                MyForbidString.Replace("A1", "是");
            }
            if ((int)MyTable.Rows[0]["人事管理之员工家庭成员"] == 1)
            {
                MyForbidString.Replace("A2", "是");

            }
            if ((int)MyTable.Rows[0]["人事管理之员工工作简历"] == 1)
            {
                MyForbidString.Replace("A3", "是");
            }
            if ((int)MyTable.Rows[0]["人事管理之员工奖惩记录"] == 1)
            {
                MyForbidString.Replace("A4", "是");
            }
            if ((int)MyTable.Rows[0]["人事管理之员工培训记录"] == 1)
            {
                MyForbidString.Replace("A5", "是");
            }
            if ((int)MyTable.Rows[0]["人事管理之员工工作业绩"] == 1)
            {
                MyForbidString.Replace("A6", "是");
            }
            if ((int)MyTable.Rows[0]["人事管理之员工离职管理"] == 1)
            {
                MyForbidString.Replace("A7", "是");
            }
            if ((int)MyTable.Rows[0]["考勤管理之月度部门考勤"] == 1)
            {
                MyForbidString.Replace("B1", "是");
            }
            if ((int)MyTable.Rows[0]["考勤管理之年度个人考勤"] == 1)
            {
                MyForbidString.Replace("B2", "是");
            }
            if ((int)MyTable.Rows[0]["工资管理之月度工资核算"] == 1)
            {
                MyForbidString.Replace("C1", "是");
            }
            if ((int)MyTable.Rows[0]["工资管理之月度工资发放"] == 1)
            {
                MyForbidString.Replace("C2", "是");
            }
            if ((int)MyTable.Rows[0]["查询管理之查询个人档案"] == 1)
            {
                MyForbidString.Replace("D1", "是");
            }
            if ((int)MyTable.Rows[0]["查询管理之查询部门档案"] == 1)
            {
                MyForbidString.Replace("D2", "是");
            }
            if ((int)MyTable.Rows[0]["查询管理之查询考勤信息"] == 1)
            {
                MyForbidString.Replace("D3", "是");
            }
            if ((int)MyTable.Rows[0]["查询管理之查询工资信息"] == 1)
            {
                MyForbidString.Replace("D4", "是");
            }
            if ((int)MyTable.Rows[0]["系统管理之分配用户权限"] == 1)
            {
                MyForbidString.Replace("E1", "是");
            }
            if ((int)MyTable.Rows[0]["系统管理之公司信息设置"] == 1)
            {
                MyForbidString.Replace("E2", "是");
            }
            if ((int)MyTable.Rows[0]["系统管理之公司部门设置"] == 1)
            {
                MyForbidString.Replace("E3", "是");
            }
            Session["MyForbid"] = MyForbidString;
        }
    }
    protected void Login1_LoggedIn(object sender, EventArgs e)
    {
       
        
    }
    protected void LoginButton_Click(object sender, EventArgs e)
    {
        
    }
}
