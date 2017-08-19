//文件名:CompanyForm.aspx.cs
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

public partial class System_CompanyForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string MyForbidString = Session["MyForbid"].ToString();
        if (MyForbidString.IndexOf("E2") > 1)
        {
            Server.Transfer("~/SystemManage/AllErrorHelp.aspx");
        }
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {//上传图像文件
        string MyFileName=this.FileUpload1.FileName;
        string MyTargetFile = System.IO.Path.Combine(HttpContext.Current.Server.MapPath("~/Images/"), MyFileName);
        this.FileUpload1.PostedFile.SaveAs(MyTargetFile);     
    }
}
