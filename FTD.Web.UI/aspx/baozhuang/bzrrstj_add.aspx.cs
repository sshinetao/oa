using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.baozhuang
{
    public partial class bzrrstj_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            string pname = this.pname.Text;
            string rname = this.rname.Text;
            string yongshi = this.yongshi.Text;
            string shuliang = this.shuliang.Text;
            string gongzi = this.gongzi.Text;
            string zhuangtai = this.zhuangtai.SelectedValue;

            FTD.BLL.Bzrrstj model = new FTD.BLL.Bzrrstj();
            model.pname = pname;
            model.rname = rname;
            model.yongshi = yongshi;
            model.shuliang = shuliang;
            model.gongzi = gongzi;
            model.zhuangtai = zhuangtai;
            model.Add();
            FTD.Unit.MessageBox.ShowAndRedirect(this, "添加成功！", "Bzrrstj.aspx");
        }
    }
}