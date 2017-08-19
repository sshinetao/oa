//文件名:QueryMemberPrint.aspx.cs
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

using System.Data.SqlClient;
public partial class QueryManage_QueryMemberPrint : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {//显示员工个人人事档案
        string MyID = this.Request.Params["MyID"].ToString();
        if (Session["MyCompanyName"] != null)
        {
            this.Label1.Text = Session["MyCompanyName"].ToString() + "员工人事档案卡";
        }
        this.Label2.Text = "打印日期：" + DateTime.Now.ToShortDateString();
        string MyConnectionString = ConfigurationManager.ConnectionStrings["MyPersonnelDBConnectionString"].ConnectionString; ;
        string MySQL = "Select * From 基本档案 WHERE 员工编号 LIKE '" + MyID + "'";
        SqlDataAdapter MyAdapter = new SqlDataAdapter(MySQL, MyConnectionString);
        DataTable MyTable = new DataTable();
        MyAdapter.Fill(MyTable);
        this.Label3.Text = "员工编号：" + MyID;
        this.Label4.Text = "部门：" + MyTable.Rows[0][2].ToString();
        this.Label5.Text = "姓名：" + MyTable.Rows[0][3].ToString();
        this.Label6.Text = "性别：" + MyTable.Rows[0][4].ToString();
        this.Label7.Text = "民族：" + MyTable.Rows[0][5].ToString();
        this.Label8.Text = "籍贯：" + MyTable.Rows[0][6].ToString();
        this.Label9.Text = "出生日期：" + MyTable.Rows[0][7].ToString().TrimEnd(new char[2] { ':', '0' });
        this.Label10.Text = "身份证号码：" + MyTable.Rows[0][8].ToString();
        this.Label11.Text = "政治面貌：" + MyTable.Rows[0][9].ToString();
        this.Label12.Text = "婚姻状况：" + MyTable.Rows[0][10].ToString();
        this.Label13.Text = "文化程度：" + MyTable.Rows[0][11].ToString();
        this.Label14.Text = "职称：" + MyTable.Rows[0][12].ToString();
        this.Label15.Text = "职务：" + MyTable.Rows[0][13].ToString();
        this.Label16.Text = "专业：" + MyTable.Rows[0][14].ToString();
        this.Label17.Text = "毕业院校：" + MyTable.Rows[0][15].ToString();
        this.Label18.Text = "进入公司时间：" + MyTable.Rows[0][16].ToString().TrimEnd(new char[2] { ':', '0' });
        this.Label19.Text = "合同服务年限：" + MyTable.Rows[0][17].ToString();
        this.Label20.Text = "基本工资：" + MyTable.Rows[0][18].ToString();
        this.Label21.Text = "银行账号：" + MyTable.Rows[0][19].ToString();
        this.Label22.Text = "养老保险账号：" + MyTable.Rows[0][20].ToString();
        this.Label23.Text = "医疗保险账号：" + MyTable.Rows[0][21].ToString();
        this.Label24.Text = "住房基金账号：" + MyTable.Rows[0][22].ToString();
        this.Label25.Text = "联系电话：" + MyTable.Rows[0][23].ToString();
        this.Label26.Text = "手机号码：" + MyTable.Rows[0][24].ToString();
        this.Label27.Text = "电子信箱：" + MyTable.Rows[0][25].ToString();
        this.Label28.Text = "家庭地址：" + MyTable.Rows[0][26].ToString();
        this.Label29.Text = "邮政编码：" + MyTable.Rows[0][27].ToString();
        this.Label30.Text = "补充说明：" + MyTable.Rows[0][28].ToString();
        MySQL = "Select 家庭成员姓名,与员工关系,工作单位,担任职务,联系电话 From 家庭成员 WHERE 员工编号 LIKE '" + MyID + "'";
        MyAdapter = new SqlDataAdapter(MySQL, MyConnectionString);
        MyTable = new DataTable();
        MyAdapter.Fill(MyTable);
        this.GridView1.DataSource = MyTable;
        this.GridView1.DataBind();
        MySQL = "Select 开始日期,结束日期,单位名称,所在部门,担任职务 From 工作简历 WHERE 员工编号 LIKE '" + MyID + "'";
        MyAdapter = new SqlDataAdapter(MySQL, MyConnectionString);
        MyTable = new DataTable();
        MyAdapter.Fill(MyTable);
        this.GridView2.DataSource = MyTable;
        this.GridView2.DataBind();
        MySQL = "Select 开始日期,培训单位,培训地点,培训内容 From 培训记录 WHERE 员工编号 LIKE '" + MyID + "'";
        MyAdapter = new SqlDataAdapter(MySQL, MyConnectionString);
        MyTable = new DataTable();
        MyAdapter.Fill(MyTable);
        this.GridView3.DataSource = MyTable;
        this.GridView3.DataBind();
        MySQL = "Select 奖惩日期,奖惩类型,奖惩原因,奖惩批准单位 From 奖惩记录 WHERE 员工编号 LIKE '" + MyID + "'";
        MyAdapter = new SqlDataAdapter(MySQL, MyConnectionString);
        MyTable = new DataTable();
        MyAdapter.Fill(MyTable);
        this.GridView4.DataSource = MyTable;
        this.GridView4.DataBind();
        MySQL = "Select 专长描述,工作业绩,补充说明 From 工作业绩 WHERE 员工编号 LIKE '" + MyID + "'";
        MyAdapter = new SqlDataAdapter(MySQL, MyConnectionString);
        MyTable = new DataTable();
        MyAdapter.Fill(MyTable);
        this.GridView5.DataSource = MyTable;
        this.GridView5.DataBind();
        if (Session["MyUserName"] != null)
        {
            this.Label31.Text = "人事专员："+Session["MyUserName"].ToString();
        }
    }
  }
