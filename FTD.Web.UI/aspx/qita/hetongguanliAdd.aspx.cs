using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.qita
{
    public partial class hetongguanliInfo : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            string fujian = "";

            string Hetongfenlei = this.Hetongfenlei.Text + "";
            string Bianhao = this.Bianhao.Text + "";
            string Jiafang = this.Jiafang.Text + "";
            string Yifang = this.Yifang.Text + "";
            decimal Hetongjine = Utils.GetDecimal(this.Hetongjine.Text + "", 0);
            DateTime Hetongqixian = Utils.ToDate(this.Hetongqixian.Text + "");
            DateTime Qiandingriqi = Utils.ToDate(this.Qiandingriqi.Text + "");
            string Neirong = this.Neirong.Text + "";

            string Userid = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            try
            {
                if (Fujian.HasFile)
                {
                    try
                    {
                        string FileExtName = Path.GetExtension(Fujian.PostedFile.FileName);
                        string FileName = Path.GetFileNameWithoutExtension(Fujian.PostedFile.FileName);
                        string TimeStamp = Unit.TimeParser.GetTimeStamp();
                        string FilePath = ConfigurationManager.AppSettings["imagesfolder"].ToString()+ "\\合同管理\\" + FileName+ TimeStamp+ FileExtName;
                        Fujian.SaveAs(Server.MapPath(FilePath));
                        fujian = FilePath.Replace("~/","/");
                    }
                    catch (Exception ex)
                    {
                        Unit.MessageBox.ShowAndRedirect(this, "合同添加失败" + ex.Message, "hetongguanli.aspx");
                    }
                }
                else
                {
                    fujian = "";
                }

                BLL.HTGL model = new BLL.HTGL();
                model.Hetongfenlei = Hetongfenlei;
                model.Bianhao = Bianhao;
                model.Jiafang = Jiafang;
                model.Yifang = Yifang;
                model.Hetongjine = Hetongjine;
                model.Hetongqixian = Hetongqixian;
                model.Qiandingriqi = Qiandingriqi;
                model.Neirong = Neirong;
                model.Fujian = fujian;

                model.Add();
                Unit.MessageBox.ShowAndRedirect(this, "合同添加成功！", "hetongguanli.aspx");
            }
            catch (Exception exp)
            {
                Unit.MessageBox.ShowAndRedirect(this, "合同添加失败" + exp.Message, "hetongguanli.aspx");
            }
        }

       
    }
}