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
    public partial class hetongguanliModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    int id = (Convert.ToInt32(Request.Params["id"]));
                    ShowInfo(id);
                    Unit.MessageBox.Show(this, Hetongqixian.Text);
                }
            }
        }

        private void ShowInfo(int id)
        {
            BLL.HTGL model = new BLL.HTGL();
            model.GetModel(id);
            hidVal.Value = model.Id.ToString();
            Hetongfenlei.Text = model.Hetongfenlei + "";
            Bianhao.Text = model.Bianhao + "";
            Jiafang.Text = model.Jiafang + "";
            Yifang.Text = model.Yifang + "";
            Hetongjine.Text = model.Hetongjine + "";
            Hetongqixian.Text = model.Hetongqixian.ToShortDateString().ToString();
            Qiandingriqi.Text = model.Qiandingriqi.ToShortDateString().ToString();
            Neirong.Text = model.Neirong + "";
            Fujian_hidden.Value = model.Fujian;
            FujianXiazai.NavigateUrl =   model.Fujian;
        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            string fujian = "";
            if (Fujian.HasFile)
            {
                try
                {
                    string FileExtName = Path.GetExtension(Fujian.PostedFile.FileName);
                    string FileName = Path.GetFileNameWithoutExtension(Fujian.PostedFile.FileName);
                    string TimeStamp = Unit.TimeParser.GetTimeStamp();
                    string FilePath = ConfigurationManager.AppSettings["imagesfolder"].ToString() + "\\合同管理\\" + FileName + TimeStamp + FileExtName;
                    Fujian.SaveAs(Server.MapPath(FilePath));
                    fujian = FilePath.Replace("~/", "/");
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
            string Id = Request["hidVal"] + "";
            string Hetongfenlei = Request["Hetongfenlei"] + "";
            string Bianhao = Request["Bianhao"] + "";
            string Jiafang = Request["Jiafang"] + "";
            string Yifang = Request["Yifang"] + "";
            decimal Hetongjine =  Utils.GetDecimal(Request["Hetongjine"], 0);
            DateTime Hetongqixian = DateTime.Parse(Request["Hetongqixian"] + "");
            DateTime Qiandingriqi = DateTime.Parse(Request["Qiandingriqi"] + "");
            string Neirong = Request["Neirong"] + "";
            fujian = fujian  != "" ? fujian : Fujian_hidden.Value;

            string Userid = Unit.PublicMethod.GetSessionValue("UserName");
            try
            {
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
                model.Id = int.Parse(Id);
                model.Update();
                Unit.MessageBox.ShowAndRedirect(this, "合同修改成功！", "hetongguanli.aspx");
            }
            catch (Exception exp)
            {
                Unit.MessageBox.ShowAndRedirect(this, "合同修改失败" + exp.Message, "hetongguanli.aspx");
            }
        }
    }
}