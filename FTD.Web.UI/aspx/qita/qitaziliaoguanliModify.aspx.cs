using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.qita
{
    public partial class qitaziliaoguanliModify : System.Web.UI.Page
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
            BLL.QTZLGL model = new BLL.QTZLGL();
            model.GetModel(id);
            hidVal.Value = model.Id.ToString();
            leibie.SelectedValue = model.Leibie + "";
            beizhu.Text = model.Beizhu + "";
            guidangshijian.Text = model.Guidangshijian.ToShortDateString().ToString();
            neirongjianjie.Text = model.Neirongjianjie + "";
            mingcheng.Text = model.Mingcheng + "";
        }

        protected void iButton1_Click(object sender, EventArgs e)
        {

            BLL.QTZLGL model = new BLL.QTZLGL();
            model.Leibie = Request["leibie"] + "";
            model.Beizhu = Request["beizhu"] + "";
            model.Guidangshijian = Utils.ToDate(Request["guidangshijian"] + "");
            model.Neirongjianjie =  Request["neirongjianjie"] + "" ;
            model.Mingcheng = Request["Mingcheng"] + "";

            model.Id = Utils.GetInt(hidVal.Value, 0);
            if (model.Id < 0)
            {
                Unit.MessageBox.ShowAndRedirect(this, "请正确操作！", "qitaziliaoguanli.aspx");
            }
            else
            {
                model.Update();
                Unit.MessageBox.ShowAndRedirect(this, "其他资料管理修改成功！", "qitaziliaoguanli.aspx");
            }
        }
    }
}