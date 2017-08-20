using System;
using System.Configuration;
using System.IO;

namespace FTD.Web.UI.aspx.Project
{
    public partial class XiangmucaiwubiaoAdd : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            string Kemu = this.Kemu.Text + "";
            string Zhuangtai = this.Zhuangtai.SelectedValue + "";
            decimal Jine = Utils.GetDecimal(this.Jine.Text + "", 0);
            DateTime Riqi = Utils.ToDate(this.Riqi.Text + "");
            try
            {
                 
                BLL.XMCWB model = new BLL.XMCWB();
                model.Kemu = Kemu;
                model.Riqi = Riqi;
                model.Jine = Jine;
                model.Zhuangtai = Zhuangtai;
                model.Add();
                Unit.MessageBox.ShowAndRedirect(this, "项目财务表添加成功！", "Xiangmucaiwubiao.aspx");
            }
            catch (Exception exp)
            {
                Unit.MessageBox.ShowAndRedirect(this, "项目财务表添加失败" + exp.Message, "Xiangmucaiwubiao.aspx");
            }
        }

    }
}