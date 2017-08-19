//文件名:OperatorForm.aspx.cs
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

public partial class System_OperatorForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string MyForbidString = Session["MyForbid"].ToString();
        if (MyForbidString.IndexOf("E1") > 1)
        {
            Server.Transfer("~/SystemManage/AllErrorHelp.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {//新增管理系统操作用户信息
        this.SqlDataSource2.Insert();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {//修改管理系统操作用户信息
        this.SqlDataSource2.Update();
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
        this.DropDownList1.Text = this.GridView1.SelectedRow.Cells[2].Text.ToString();
        this.TextBox1.Text = this.GridView1.SelectedRow.Cells[3].Text.ToString();        
        this.DropDownList2.Text = this.GridView1.SelectedRow.Cells[4].Text.ToString();
        this.TextBox3.Text = this.GridView1.SelectedRow.Cells[5].Text.ToString();
        this.TextBox4.Text = this.GridView1.SelectedRow.Cells[6].Text.ToString();
        this.CheckBox1.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[7].Text.ToString())==1)?true:false;
        this.CheckBox2.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[8].Text.ToString()) == 1) ? true : false;
        this.CheckBox3.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[9].Text.ToString()) == 1) ? true : false;
        this.CheckBox4.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[10].Text.ToString()) == 1) ? true : false;
        this.CheckBox5.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[11].Text.ToString()) == 1) ? true : false;
        this.CheckBox6.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[12].Text.ToString()) == 1) ? true : false;
        this.CheckBox7.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[13].Text.ToString()) == 1) ? true : false;
        this.CheckBox8.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[14].Text.ToString()) == 1) ? true : false;
        this.CheckBox9.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[15].Text.ToString()) == 1) ? true : false;
        this.CheckBox10.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[16].Text.ToString()) == 1) ? true : false;
        this.CheckBox11.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[17].Text.ToString()) == 1) ? true : false;
        this.CheckBox12.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[18].Text.ToString()) == 1) ? true : false;
        this.CheckBox13.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[19].Text.ToString()) == 1) ? true : false;
        this.CheckBox14.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[20].Text.ToString()) == 1) ? true : false;
        this.CheckBox15.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[21].Text.ToString()) == 1) ? true : false;
        this.CheckBox16.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[22].Text.ToString()) == 1) ? true : false;
        this.CheckBox17.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[23].Text.ToString()) == 1) ? true : false;
        this.CheckBox18.Checked = (Convert.ToInt16(this.GridView1.SelectedRow.Cells[24].Text.ToString()) == 1) ? true : false;
    }  
}
