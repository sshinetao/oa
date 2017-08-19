﻿//文件名:PersonnelForm.aspx.cs
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

public partial class FileManage_PersonnelForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string MyForbidString = Session["MyForbid"].ToString();
        if (MyForbidString.IndexOf("A1") > 1)
        {
            Server.Transfer("~/SystemManage/AllErrorHelp.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {//新增员工基本档案信息
        this.SqlDataSource1.Insert();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {//修改员工基本档案信息
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
    {//在控件中显示选择的记录
        this.TextBox2.Text = this.GridView1.SelectedRow.Cells[3].Text.ToString();
        this.DropDownList1.Text = this.GridView1.SelectedRow.Cells[4].Text.ToString();
        this.TextBox3.Text = this.GridView1.SelectedRow.Cells[5].Text.ToString();
        this.DropDownList2.Text = this.GridView1.SelectedRow.Cells[6].Text.ToString();
        this.TextBox4.Text = this.GridView1.SelectedRow.Cells[7].Text.ToString();
        this.TextBox5.Text = this.GridView1.SelectedRow.Cells[8].Text.ToString();
        this.TextBox6.Text = this.GridView1.SelectedRow.Cells[9].Text.ToString();
        this.TextBox7.Text = this.GridView1.SelectedRow.Cells[10].Text.ToString();
        this.TextBox8.Text = this.GridView1.SelectedRow.Cells[11].Text.ToString();
        this.DropDownList3.Text = this.GridView1.SelectedRow.Cells[12].Text.ToString();
        this.DropDownList4.Text = this.GridView1.SelectedRow.Cells[13].Text.ToString();
        this.DropDownList5.Text  = this.GridView1.SelectedRow.Cells[14].Text.ToString();
        this.TextBox9.Text = this.GridView1.SelectedRow.Cells[15].Text.ToString();
        this.TextBox10.Text = this.GridView1.SelectedRow.Cells[16].Text.ToString();
        this.TextBox11.Text = this.GridView1.SelectedRow.Cells[17].Text.ToString();
        this.TextBox12.Text = this.GridView1.SelectedRow.Cells[18].Text.ToString();
        this.DropDownList6.Text = this.GridView1.SelectedRow.Cells[19].Text.ToString();
        this.TextBox13.Text = this.GridView1.SelectedRow.Cells[20].Text.ToString();
        this.TextBox14.Text = this.GridView1.SelectedRow.Cells[21].Text.ToString();
        this.TextBox15.Text = this.GridView1.SelectedRow.Cells[22].Text.ToString();
        this.TextBox16.Text = this.GridView1.SelectedRow.Cells[23].Text.ToString();
        this.TextBox17.Text = this.GridView1.SelectedRow.Cells[24].Text.ToString();
        this.TextBox18.Text = this.GridView1.SelectedRow.Cells[25].Text.ToString();
        this.TextBox19.Text = this.GridView1.SelectedRow.Cells[26].Text.ToString();
        this.TextBox20.Text = this.GridView1.SelectedRow.Cells[27].Text.ToString();
        this.TextBox21.Text = this.GridView1.SelectedRow.Cells[28].Text.ToString();
        this.TextBox22.Text = this.GridView1.SelectedRow.Cells[29].Text.ToString();
        this.TextBox23.Text = this.GridView1.SelectedRow.Cells[30].Text.ToString();
        this.TextBox24.Text = this.GridView1.SelectedRow.Cells[2].Text.ToString();
    }
}
