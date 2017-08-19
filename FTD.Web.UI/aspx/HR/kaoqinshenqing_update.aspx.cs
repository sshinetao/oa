using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.HR
{
    public partial class kaoqinshenqing_update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                int id = (Convert.ToInt32(Request.Params["id"]));
                ShowInfo(id);
            }
        }

        private void ShowInfo(int id)
        {
            FTD.BLL.KQSQ model = new FTD.BLL.KQSQ();
            model.GetModel(id);
            this.kaishishijian.Text = model.Kaishishijian.ToString("yyyy-MM-dd");
            this.jieshushijian.Text = model.Jieshushijian.ToString("yyyy-MM-dd");
            this.type.SelectedValue = model.Type;
            this.fuzeren.Text = model.Fuzeren;
            this.name.Value = model.Name;
            this.zhuangtai.SelectedValue = model.Zhuangtai;
        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            FTD.BLL.KQSQ model = new FTD.BLL.KQSQ();
            model.Kaishishijian = DateTime.Parse(Request["kaishishijian"]+"");
            model.Jieshushijian = DateTime.Parse(Request["jieshushijian"] + "");
            model.Type = Request["type"] + "";
            model.Zhuangtai = Request["zhuangtai"] + "";
            model.Fuzeren = Request["fuzeren"] + "";
            model.Name = Request["name"] + "";
            model.Id = Utils.GetInt(Request["ID"], 0);
            if (model.Id < 0)
            {
                FTD.Unit.MessageBox.ShowAndRedirect(this, "请正确操作！", "kaoqinshenqing.aspx");
            }
            else
            {
                model.Update();
                FTD.Unit.MessageBox.ShowAndRedirect(this, "修改成功！", "kaoqinshenqing.aspx");
            }
        }
    }
}