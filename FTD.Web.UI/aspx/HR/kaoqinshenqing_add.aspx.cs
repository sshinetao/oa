using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.HR
{
    public partial class kaoqinshenqing_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            DateTime kaishishijian = DateTime.Parse(this.kaishishijian.Text + "");
            DateTime jieshushijian = DateTime.Parse(this.jieshushijian.Text + "");
            string type = this.type.SelectedValue;
            string fuzeren = this.fuzeren.Text;
            string name = FTD.Unit.PublicMethod.GetSessionValue("UserName");

            try
            {
                FTD.BLL.KQSQ Model = new FTD.BLL.KQSQ();
                Model.Name = name;
                Model.Fuzeren = fuzeren;
                Model.Type = type;
                Model.Kaishishijian = kaishishijian;
                Model.Jieshushijian = jieshushijian;
                Model.Zhuangtai = "请假中";
                Model.Add();
                FTD.Unit.MessageBox.ShowAndRedirect(this, "添加成功！", "kaoqinshenqing.aspx");
            }
            catch (Exception ex)
            {
                FTD.Unit.MessageBox.ShowAndRedirect(this, "添加失败,失败原因："+ex.Message, "kaoqinshenqing_add.aspx");
            }

        }
    }
}