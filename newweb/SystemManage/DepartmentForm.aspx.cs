//文件名:DepartmentForm.aspx.cs
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

public partial class SystemManage_DepartmentForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string MyForbidString = Session["MyForbid"].ToString();
        if (MyForbidString.IndexOf("E3") > 1)
        {
            Server.Transfer("~/SystemManage/AllErrorHelp.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {//新增公司部门信息
        this.SqlDataSource1.Insert();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {//修改公司部门信息
        this.SqlDataSource1.Update();
    }
    protected void GridView1_RowCreated(object sender, GridViewRowEventArgs e)
    {//弹出删除操作确认对话框
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Button MyButton = (Button)e.Row.FindControl("Button1");
            MyButton.OnClientClick = "return confirm('是否确认删除当前选择的记录？')";
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {//在文本框中显示选择的记录
        this.TextBox1.Text = this.GridView1.SelectedRow.Cells[2].Text.ToString();
        this.TextBox2.Text = this.GridView1.SelectedRow.Cells[3].Text.ToString();
        this.TextBox3.Text = this.GridView1.SelectedRow.Cells[4].Text.ToString();
        this.TextBox4.Text = this.GridView1.SelectedRow.Cells[5].Text.ToString();
        this.TextBox5.Text = this.GridView1.SelectedRow.Cells[6].Text.ToString();
        this.TextBox6.Text = this.GridView1.SelectedRow.Cells[7].Text.ToString();
    }
}
