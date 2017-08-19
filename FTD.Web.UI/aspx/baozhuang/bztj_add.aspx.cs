using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.baozhuang
{
    public partial class bztj_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            string pname = this.pname1.Text;
            string zhiliang = this.zhiliang1.Text;
            string shuliang = this.shuliang1.Text;

            FTD.BLL.Bztj model = new FTD.BLL.Bztj();
            model.Pname = pname;
            model.Zhiliang = zhiliang;
            model.Shuliang = int.Parse(shuliang);
            model.Add();
            FTD.Unit.MessageBox.ShowAndRedirect(this, "添加成功！", "Bztj.aspx");
        }
    }
}