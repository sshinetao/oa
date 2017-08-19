using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.baozhuang
{
    public partial class cpjgtj_update : System.Web.UI.Page
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

            FTD.BLL.Cpjgtj model = new FTD.BLL.Cpjgtj();
            model.GetModel(id);
            this.hidVal5.Value = model.Id.ToString();
            this.pname5.Text = model.Pname;
            this.zhiliang5.Text = model.Zhiliang;
            this.shuliang5.Text = model.Shuliang + "";



        }
        protected void iButton1_Click(object sender, EventArgs e)
        {


            FTD.BLL.Cpjgtj model = new FTD.BLL.Cpjgtj();


            model.Pname = Request["pname5"] + "";
            model.Zhiliang = Request["zhiliang5"] + "";
            model.Shuliang = int.Parse(Request["shuliang5"] + "");

            model.Id = Utils.GetInt(hidVal5.Value, 0);
            if (model.Id < 0)
            {
                FTD.Unit.MessageBox.ShowAndRedirect(this, "请正确操作！", "Cpjgtj.aspx");
            }
            else
            {
                model.Update();
                FTD.Unit.MessageBox.ShowAndRedirect(this, "修改成功！", "Cpjgtj.aspx");
            }
        }
    }
}