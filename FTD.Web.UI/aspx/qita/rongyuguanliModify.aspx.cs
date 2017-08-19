using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.qita
{
    public partial class rongyuguanliModify : System.Web.UI.Page
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
            BLL.RYGL model = new BLL.RYGL();
            model.GetModel(id);
            hidVal.Value = model.Id.ToString();
            leibie.SelectedValue = model.Leibie + "";
            banfabumen.Text = model.Banfabumen + "";
            banfashijian.Text = model.Banfashijian.ToShortDateString().ToString();
            youxiaoqi.Text = model.Youxiaoqi + "";
            mingcheng.Text = model.Mingcheng + "";
        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
 
            BLL.RYGL model = new BLL.RYGL();
            model.Leibie = Request["leibie"]+"";
            model.Banfabumen = Request["banfabumen"] + "";
            model.Banfashijian = Utils.ToDate( Request["banfashijian"] + "");
            model.Youxiaoqi = int.Parse( Request["youxiaoqi"] + "");
            model.Mingcheng = Request["Mingcheng"] + "";
 
            model.Id = Utils.GetInt(hidVal.Value, 0);
            if (model.Id < 0)
            {
                Unit.MessageBox.ShowAndRedirect(this, "请正确操作！", "rongyuguanli.aspx");
            }
            else
            {
                model.Update();
                Unit.MessageBox.ShowAndRedirect(this, "荣誉管理修改成功！", "rongyuguanli.aspx");
            }
        }
    }
}