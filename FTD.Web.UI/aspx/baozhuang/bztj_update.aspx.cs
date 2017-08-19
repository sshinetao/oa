using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.baozhuang
{
    public partial class bztj_update : System.Web.UI.Page
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

            FTD.BLL.Bztj model = new FTD.BLL.Bztj();
            model.GetModel(id);
            this.hidVal3.Value = model.Id.ToString();
            this.pname3.Text = model.Pname;
            this.zhiliang3.Text = model.Zhiliang;
            this.shuliang3.Text = model.Shuliang+"";
 


        }
        protected void iButton1_Click(object sender, EventArgs e)
        {


            FTD.BLL.Bztj model = new FTD.BLL.Bztj();


            model.Pname = Request["pname3"] + "";
            model.Zhiliang = Request["zhiliang3"] + "";
            model.Shuliang = int.Parse(Request["shuliang3"] + "");
 
            model.Id = Utils.GetInt(hidVal3.Value, 0);
            if (model.Id < 0)
            {
                FTD.Unit.MessageBox.ShowAndRedirect(this, "请正确操作！", "bztj.aspx");
            }
            else
            {
                model.Update();
                FTD.Unit.MessageBox.ShowAndRedirect(this, "修改成功！", "bztj.aspx");
            }
        }
    }
}