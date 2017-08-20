using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.Project
{
    public partial class XiangmucaiwubiaoModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    int id = (Convert.ToInt32(Request.Params["id"]));
                    ShowInfo(id);
                }
            }
        }

        private void ShowInfo(int id)
        {
            BLL.XMCWB model = new BLL.XMCWB();
            model.GetModel(id);
            hidVal.Value = model.Id.ToString();
            Kemu.Text = model.Kemu + "";
            Riqi.Text = model.Riqi.ToShortDateString().ToString();
            Jine.Text = model.Jine + "";
            Zhuangtai.SelectedValue = model.Zhuangtai + "";
        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            
            string Id = Request["hidVal"] + "";
            string Kemu = Request["Kemu"] + "";
            decimal Jine = Utils.GetDecimal( Request["Jine"] + "",0);
            string Zhuangtai = Request["Zhuangtai"] + "";
            DateTime Riqi = DateTime.Parse(Request["Riqi"] + "");       

         
            try
            {
                BLL.XMCWB model = new BLL.XMCWB();
                model.Kemu = Kemu;
                model.Jine = Jine;
                model.Zhuangtai = Zhuangtai;
                model.Riqi = Riqi;
                model.Id = int.Parse(Id);
                model.Update();
                Unit.MessageBox.ShowAndRedirect(this, "项目财务表修改成功！", "Xiangmucaiwubiao.aspx");
            }
            catch (Exception exp)
            {
                Unit.MessageBox.ShowAndRedirect(this, "项目财务表修改失败" + exp.Message, "Xiangmucaiwubiao.aspx");
            }
        }
    }
}