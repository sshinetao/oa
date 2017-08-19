//文件名:ComputePrint.aspx.cs
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
public partial class SalaryManage_ComputePrint : System.Web.UI.Page
{
    private SalaryManage_ComputeForm MyComputeForm;
    protected void Page_Load(object sender, EventArgs e)
    {//将查询结果输出到Excel文件中
        MyComputeForm = (SalaryManage_ComputeForm)Context.Handler;
        string MySQL = MyComputeForm.MyPrintSQL;
        this.Label1.Text = MyComputeForm.MyPrintTitle;
        this.Label2.Text = MyComputeForm.MyPrintDate ;
        string MyConnectionString = ConfigurationManager.ConnectionStrings["MyPersonnelDBConnectionString"].ConnectionString; ;
        SqlDataAdapter MyAdapter = new SqlDataAdapter(MySQL, MyConnectionString);
        DataSet MySet = new DataSet();
        MyAdapter.Fill(MySet);
        this.DataGrid1.DataSource = MySet;
        this.DataGrid1.DataBind();
        this.Response.ContentType = "application/vnd.ms-excel";
        this.Response.Charset = "";
        //关闭 ViewState
        this.EnableViewState = false;
        System.IO.StringWriter MyWriter;
        System.Web.UI.HtmlTextWriter MyWeb;
        //将信息写入字符串
        MyWriter = new System.IO.StringWriter();
        //在Web窗体页上写出一系列连续的HTML特定字符和文本
        MyWeb = new System.Web.UI.HtmlTextWriter(MyWriter);
        //将DataGrid中的内容输出到HtmlTextWriter对象中
        this.DataGrid1.RenderControl(MyWeb);
        //把HTML写回浏览器
        Response.Write(MyWriter.ToString());
    }
}
