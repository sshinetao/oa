//文件名:MasterPage.master.cs
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

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {//设置网站页头或页尾的信息
        if (!IsPostBack)
        {
            if (Session["MyUserName"] != null)
            {
                this.Label3.Text = Session["MyUserName"].ToString();
            }
            else
            {
                this.Label3.Text = "";
            }
            if (Session["MySystemName"] != null)
            {
                this.HyperLink1.Text = Session["MySystemName"].ToString();
            }
            else
            {
                this.HyperLink1.Text = "";
            }
            if (Session["MyCompanyWebSite"] != null)
            {
                this.HyperLink1.NavigateUrl = Session["MyCompanyWebSite"].ToString();
            }
            else
            {
                this.HyperLink1.NavigateUrl = "";
            }
            string MyCompanyName = "";
            if (Session["MyCompanyName"] != null)
            {
                MyCompanyName = Session["MyCompanyName"].ToString();
            }
            string MyCompanyAddress = "";
            if (Session["MyCompanyAddress"] != null)
            {
                MyCompanyAddress = Session["MyCompanyAddress"].ToString();
            }
            string MyCompanyPhone = "";
            if (Session["MyCompanyPhone"] != null)
            {
                MyCompanyPhone = Session["MyCompanyPhone"].ToString();
            }
            string MyCompanyLogo = "";
            if (Session["MyCompanyLogo"] != null)
            {
                MyCompanyLogo = "~/Images/" + Session["MyCompanyLogo"].ToString();
            }
            this.Image1.ImageUrl = MyCompanyLogo;
            this.Label1.Text = "版权所有(2007-2010)：" + MyCompanyName + " " + MyCompanyAddress + " " + MyCompanyPhone;
        }
    }
}
