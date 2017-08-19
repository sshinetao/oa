using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.baozhuang
{
    public partial class bzrrstj_update : System.Web.UI.Page
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
 
            FTD.BLL.Bzrrstj model = new FTD.BLL.Bzrrstj();
            model.GetModel(id);
            this.hidVal.Value = model.id.ToString();
            this.rname.Text = model.rname;
            this.pname.Text = model.pname;
            this.yongshi.Text = model.yongshi;
            this.shuliang.Text = model.shuliang;
            this.gongzi.Text = model.gongzi;
            this.zhuangtai.SelectedValue = model.zhuangtai;
           
           
        }
        protected void iButton1_Click(object sender, EventArgs e)
        {
            

            FTD.BLL.Bzrrstj model = new FTD.BLL.Bzrrstj();


            model.rname = Request["rname"]+"";
            model.pname =   Request["pname"] + "";
            model.yongshi =  Request["yongshi"] + "";
            model.shuliang =   Request["shuliang"] + "";
            model.gongzi =  Request["gongzi"] + "";
            model.zhuangtai =   Request["zhuangtai"] + "";

            model.id = Utils.GetInt(hidVal.Value, 0);
            if (model.id < 0)
            {
                FTD.Unit.MessageBox.ShowAndRedirect(this, "请正确操作！", "bzrrstj.aspx");
            }
            else
            {
                model.Update();
                FTD.Unit.MessageBox.ShowAndRedirect(this, "修改成功！", "bzrrstj.aspx");
            }
        }
    }
}