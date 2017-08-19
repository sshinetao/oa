using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.baozhuang
{
    public partial class cpjgtj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }
        protected void iButton1_Click(object sender, EventArgs e)
        {
            string pname = this.pname4.Text;
            string zhiliang = this.zhiliang4.Text;
            string shuliang = this.shuliang4.Text;

            FTD.BLL.Cpjgtj model = new FTD.BLL.Cpjgtj();
            model.Pname = pname;
            model.Zhiliang = zhiliang;
            model.Shuliang = int.Parse(shuliang);
            model.Add();
            FTD.Unit.MessageBox.ShowAndRedirect(this, "添加成功！", "Cpjgtj.aspx");
        }
    }
}