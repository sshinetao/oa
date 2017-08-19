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
using System.Text;

namespace OA.aspx.Work{ 
 public partial class WorkRiZhiAdd: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();
            this.TxtContent.Text = BindDefaultClass();
        }
    }

    protected string BindDefaultClass()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<p>");
        sb.Append(@"<strong><span style=""font-family:仿宋_gb2312;font-size:21px;"">日期：<span style=""text-decoration:underline;"">  年  月 日");
        sb.Append(@"—  月 日</span>    第<span style=""text-decoration:underline;""></span>周    </span></strong>");
        sb.Append("</p>");
        sb.Append("<p>");
        sb.Append(@"<strong><span style=""font-family:仿宋_gb2312;font-size:21px;"">姓名：<span style=""text-decoration:underline;""></span>");
        sb.Append(@"</span></strong><span style=""text-decoration:underline;""><span style=""font-family:仿宋_gb2312;font-size:24px;"">");
        sb.Append(@"</span></span><strong><span style=""font-family:仿宋_gb2312;font-size:21px;"">部门：");
        sb.Append(@"<span style=""text-decoration:underline;""></span> 职务：<span style=""text-decoration:underline;""></span>");
        sb.Append(@"</span></strong>");
        sb.Append(@"</p>");
        sb.Append(@"<table cellspacing=""0"" cellpadding=""0"">");
        sb.Append(@"<tbody>");
        sb.Append(@" <tr style=""height:18px;"" class=""firstRow"">");
        sb.Append(@"  <td style=""padding:0px 7px;border:1px solid #000;"" height=""18"" width=""583"" colspan=""3"">");
        sb.Append(@"      <p style=""text-align:center;"">");
        sb.Append(@"       <strong><span style=""font-family:宋体;font-size:21px;"">本周工作汇报</span></strong>");
        sb.Append(@" </td>");
        sb.Append(@" </tr>");
        sb.Append(@"  <tr style=""height:18px;"">");
        sb.Append(@" <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""18"" width=""101"">");
        sb.Append(@"  <p style=""text-align:center;"">");
        sb.Append(@" <strong><span style=""font-family:宋体;font-size:19px;"">日期</span></strong>");
        sb.Append(@" </p>");
        sb.Append(@"  </td>");
        sb.Append(@"  <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""18"" width=""369"">");
        sb.Append(@"  <p style=""text-align:center;"">");
        sb.Append(@"     <strong><span style=""font-family:宋体;font-size:19px;"">工作事项</span></strong>");
        sb.Append(@"   </p>");
        sb.Append(@"  </td>");
        sb.Append(@"  <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""18"" width=""113"">");
        sb.Append(@"  <p style=""text-align:center;"">");
        sb.Append(@"    <strong><span style=""font-family:宋体;font-size:19px;"">完成状态</span></strong>");
        sb.Append(@"  </p>");
        sb.Append(@"   </td>");
        sb.Append(@"  </tr>");
        sb.Append(@"   <tr style=""height:25px;"">");
        sb.Append(@"  <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""25"" width=""101"">");
        sb.Append(@" <p style=""text-align:center;"">");
        sb.Append(@"    <span style=""font-family:仿宋_gb2312;font-size:15px;"">周一</span>");
        sb.Append(@"   </p>");
        sb.Append(@" </td>");
        sb.Append(@"  <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""369"">");
        sb.Append(@"  <br />");
        sb.Append(@" </td>");
        sb.Append(@" <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""113"">");
        sb.Append(@" <br />");
        sb.Append(@"  </td>");
        sb.Append(@" </tr>");
        sb.Append(@" <tr style=""height:25px;"">");
        sb.Append(@" <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""25"" width=""101"">");
        sb.Append(@"  <p style=""text-align:center;"">");
        sb.Append(@"    <span style=""font-family:仿宋_gb2312;font-size:15px;"">周二</span>");
        sb.Append(@"  </p>");
        sb.Append(@"  </td>");
        sb.Append(@"  <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""369"">");
        sb.Append(@"  <br />");
        sb.Append(@"  </td>");
        sb.Append(@"  <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""113"">");
        sb.Append(@"   <br />");
        sb.Append(@" </td>");
        sb.Append(@" </tr>");
        sb.Append(@"  <tr style=""height:25px;"">");
        sb.Append(@" <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""25"" width=""101"">");
        sb.Append(@"  <p style=""text-align:center;"">");
        sb.Append(@" <span style=""font-family:仿宋_gb2312;font-size:15px;"">周三</span>");
        sb.Append(@" </p>");
        sb.Append(@"  </td>");
        sb.Append(@" <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""369"">");
        sb.Append(@" <br />");
        sb.Append(@" </td>");
        sb.Append(@" <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""113"">");
        sb.Append(@"  <br />");
        sb.Append(@" </td>");
        sb.Append(@" </tr>");
        sb.Append(@"   <tr style=""height:25px;"">");
        sb.Append(@"  <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""25"" width=""101"">");
        sb.Append(@"  <p style=""text-align:center;"">");
        sb.Append(@"   <span style=""font-family:仿宋_gb2312;font-size:15px;"">周四</span>");
        sb.Append(@"   </p>");
        sb.Append(@" </td>");
        sb.Append(@"  <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""369"">");
        sb.Append(@" <br />");
        sb.Append(@" </td>");
        sb.Append(@" <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""113"">");
        sb.Append(@"  <br />");
        sb.Append(@" </td>");
        sb.Append(@"  </tr>");
        sb.Append(@"  <tr style=""height:25px;"">");
        sb.Append(@" <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""25"" width=""101"">");
        sb.Append(@" <p style=""text-align:center;"">");
        sb.Append(@"  <span style=""font-family:仿宋_gb2312;font-size:15px;"">周五</span>");
        sb.Append(@" </p>");
        sb.Append(@" </td>");
        sb.Append(@" <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""369"">");
        sb.Append(@"  <br />");
        sb.Append(@" </td>");
        sb.Append(@" <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""113"">");
        sb.Append(@"  <br />");
        sb.Append(@"  </td>");
        sb.Append(@" </tr>");
        sb.Append(@" <tr style=""height:25px;"">");
        sb.Append(@" <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""25"" width=""101"">");
        sb.Append(@"  <p style=""text-align:center;"">");
        sb.Append(@"  <span style=""font-family:仿宋_gb2312;font-size:15px;"">周六</span>");
        sb.Append(@"  </p>");
        sb.Append(@" </td>");
        sb.Append(@" <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""369"">");
        sb.Append(@" <br />");
        sb.Append(@"  </td>");
        sb.Append(@" <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""113"">");
        sb.Append(@" <br />");
        sb.Append(@"  </td>");
        sb.Append(@" </tr>");
        sb.Append(@" <tr style=""height:25px;"">");
        sb.Append(@" <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""25"" width=""101"">");
        sb.Append(@"   <p style=""text-align:center;"">");
        sb.Append(@"     <span style=""font-family:仿宋_gb2312;font-size:15px;"">周日</span>");
        sb.Append(@"  </p>");
        sb.Append(@" </td>");
        sb.Append(@"  <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""369"">");
        sb.Append(@"  <br />");
        sb.Append(@" </td>");
        sb.Append(@"  <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""25"" width=""113"">");
        sb.Append(@" <br />");
        sb.Append(@"  </td>");
        sb.Append(@" </tr>");
        sb.Append(@" <tr style=""height:38px;"">");
        sb.Append(@"  <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""38"" rowspan=""3"" width=""101"">");
        sb.Append(@"  <p>");
        sb.Append(@" <strong><span style=""font-family:宋体;font-size:32px;"">小结</span></strong>");
        sb.Append(@"  </p>");
        sb.Append(@" </td>");
        sb.Append(@"   <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""38"" valign=""top"" width=""481"" colspan=""2"">");
        sb.Append(@"  <p>");
        sb.Append(@"   <strong><span style=""font-family:宋体;"">本周工作重点：</span></strong>");
        sb.Append(@"   </p>");
        sb.Append(@"  <p>");
        sb.Append(@"    <span style=""font-family:仿宋_gb2312;font-size:15px;""></span>");
        sb.Append(@"   </p>");
        sb.Append(@" </td>");
        sb.Append(@" </tr>");
        sb.Append(@"  <tr style=""height:42px;"">");
        sb.Append(@"  <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""42"" valign=""top"" width=""481"" colspan=""2"">");
        sb.Append(@"  <p>");
        sb.Append(@" <strong><span style=""font-family:宋体;font-size:16px;"">本周对公司的建议：</span></strong>");
        sb.Append(@"  </p>");
        sb.Append(@"  <p>");
        sb.Append(@"   <span style=""font-family:宋体;font-size:15px;""></span>");
        sb.Append(@" </p>");
        sb.Append(@"  </td>");
        sb.Append(@" </tr>");
        sb.Append(@"  <tr style=""height:52px;"">");
        sb.Append(@" <td style=""border-width:medium 1px 1px medium;border-style:none solid solid none;border-color:currentcolor #000 #000 currentcolor;padding:0px 7px;"" height=""52"" valign=""top"" width=""481"" colspan=""2"">");
        sb.Append(@"  <p>");
        sb.Append(@"  <strong><span style=""font-family:宋体;font-size:16px;"">本周工作中遇到的问题或困难：</span></strong>");
        sb.Append(@" </p>");
        sb.Append(@"  <p>");
        sb.Append(@" <span style=""font-family:宋体;font-size:15px;""></span>");
        sb.Append(@" </p>");
        sb.Append(@" </td>");
        sb.Append(@" </tr>");
        sb.Append(@" </tbody>");
        sb.Append(@" </table>");
        sb.Append(@" <p>");
        sb.Append(@" <br />");
        sb.Append(@" </p>");
        sb.Append(@" <table cellspacing=""0"" cellpadding=""0"">");
        sb.Append(@"    <tbody>");
        sb.Append(@"  <tr style=""height:18px;"" class=""firstRow"">");
        sb.Append(@" <td style=""padding:0px 7px;border:1px solid #000;"" height=""18"" width=""583"">");
        sb.Append(@" <p style=""text-align:center;"">");
        sb.Append(@" <strong><span style=""font-family:宋体;font-size:21px;"">下周工作计划</span></strong>");
        sb.Append(@" </p>");
        sb.Append(@" </td>");
        sb.Append(@" </tr>");
        sb.Append(@" <tr style=""height:177px;"">");
        sb.Append(@"     <td style=""border-width:medium 1px 1px;border-style:none solid solid;border-color:currentcolor #000 #000;padding:0px 7px;"" height=""177"" width=""583"">");
        sb.Append(@" <br />");
        sb.Append(@"  </td>");
        sb.Append(@"  </tr>");
        sb.Append(@"   </tbody>");
        sb.Append(@" </table>");
        sb.Append(@" <p>");
        sb.Append(@"  <br />");
        sb.Append(@" </p>");
        return sb.ToString();
        


    }

    protected void iButton1_Click(object sender, EventArgs e)
    {
        FTD.BLL.ERPWorkRiZhi Model = new FTD.BLL.ERPWorkRiZhi();
        Model.TitleStr = this.TextBox1.Text;
        Model.ContentStr = this.TxtContent.Text;
        Model.CanLookUser = this.TextBox2.Text;
        Model.TypeStr = this.TextBox5.Text.Trim();
        Model.TimeStr = DateTime.Now;   
        Model.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
        Model.Add();

        //写系统日志
        FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
        MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
        MyRiZhi.DoSomething = "用户添加工作日志信息(" + this.TextBox1.Text + ")";
        MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
        MyRiZhi.Add();

        FTD.Unit.MessageBox.ShowAndRedirect(this, "工作日志添加成功！", "WorkRiZhi.aspx");
    }
}}