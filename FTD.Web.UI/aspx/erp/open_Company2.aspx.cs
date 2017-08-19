using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class open_Company2 : System.Web.UI.Page
    {
        Db List = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            FTD.Unit.PublicMethod.CheckSession();


            if (!Page.IsPostBack)
            {
                name.Attributes["onkeydown"] = "if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
            }



            FTD.BLL.ERPNewHuiYuan MyModel = new FTD.BLL.ERPNewHuiYuan();
            DataSet ds = MyModel.GetList(" UserName='" + FTD.Unit.PublicMethod.GetSessionValue("UserName") + "' order by ID desc");

            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                Datagrid2.DataSource = dt;
                Datagrid2.DataBind();
            }





        }

        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("open_Company2.aspx?name=" + name.Text + "&key=" + Request.QueryString["key"] + "");

        }


    }
}