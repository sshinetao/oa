using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.TelFile
{
    public partial class gongwennigao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void iButton1_Click(object sender, EventArgs e)
        {
            string fj = "";
            if (fujian.HasFile)
            {
                try
                {
                    string FileExtName = Path.GetExtension(fujian.PostedFile.FileName);
                    string FileName = Path.GetFileNameWithoutExtension(fujian.PostedFile.FileName);
                    string TimeStamp = Unit.TimeParser.GetTimeStamp();
                    string FilePath = ConfigurationManager.AppSettings["imagesfolder"].ToString() + "\\公文附件\\" + FileName + TimeStamp + FileExtName;
                    fujian.SaveAs(Server.MapPath(FilePath));
                    fj = FilePath.Replace("~/", "/");
                }
                catch (Exception ex)
                {
                    Unit.MessageBox.ShowAndRedirect(this, "公文拟稿加失败" + ex.Message, "gongwennigao.aspx");
                }
            }
            else
            {
                fj = "";
            }
            BLL.GWGL model = new BLL.GWGL();
            model.Biaoti = biaoti.Text + "";
            model.Neirong =  neirong.Text ;
            model.Shenpiren = shenpiren.Text + "";
            model.Leixing = leixing.SelectedValue;
            model.Fujian = fj + "";

            model.Add();

            //20170528 陶欣 写系统日志
            BLL.ERPRiZhi MyRiZhi = new BLL.ERPRiZhi();
            MyRiZhi.UserName = Unit.PublicMethod.GetSessionValue("UserName");
            MyRiZhi.DoSomething = "公文拟稿管理添加(" + this.biaoti.Text + ")";
            MyRiZhi.IpStr = HttpContext.Current.Request.UserHostAddress.ToString();
            MyRiZhi.Add();

            Unit.MessageBox.ShowAndRedirect(this, "公文拟稿添加成功！", "gongwennigao.aspx");
        }
    }
}