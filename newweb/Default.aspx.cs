using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.Page.Title = "当前位置：系统首页";
            string MyConnectionString = ConfigurationManager.ConnectionStrings["MyPersonnelDBConnectionString"].ConnectionString;
            string MySQL = "Select  *  From 公司信息 Where 优先级=1";

            SqlConnection MyConnection = new SqlConnection(MyConnectionString);
            MyConnection.Open();
            DataTable MyTable = new DataTable();
            SqlDataAdapter MyAdapter = new SqlDataAdapter(MySQL, MyConnection);
            MyAdapter.Fill(MyTable);
            this.Image1.ImageUrl = "~/Images/" + (String)MyTable.Rows[0]["首页图像"];
            Session["MySystemName"] = (String)MyTable.Rows[0]["系统名称"];
            Session["MyCompanyWebSite"] = (String)MyTable.Rows[0]["公司网站"].ToString();
            Session["MyCompanyName"] = (String)MyTable.Rows[0]["公司名称"];
            Session["MyCompanyAddress"] = (String)MyTable.Rows[0]["公司地址"];
            Session["MyCompanyPhone"] = (String)MyTable.Rows[0]["服务电话"];
            Session["MyCompanyLogo"] = (String)MyTable.Rows[0]["标志图标"];
            if (MyConnection.State == ConnectionState.Open)
            {
                MyConnection.Close();
            }
        }
    }
}
