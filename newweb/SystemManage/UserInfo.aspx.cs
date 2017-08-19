//文件名:UserInfo.aspx.cs
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
//该源码下载自www.51aspx.com(５1ａｓpｘ．ｃｏｍ)

public partial class System_UserInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        MembershipUser MyUser = Membership.GetUser();
        MyUser.Email = (String)e.NewValues[1];
        MyUser.Comment = (String)e.NewValues[0];
        Membership.UpdateUser(MyUser);
        e.Cancel = true;
        this.DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
    }
}
