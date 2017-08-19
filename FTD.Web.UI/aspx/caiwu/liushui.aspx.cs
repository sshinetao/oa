using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.caiwu
{
    public partial class liushui : System.Web.UI.Page
    {
        public static int showMonth = DateTime.Now.Month;
        public static int showYear = DateTime.Now.Year;
        protected void Page_Load(object sender, EventArgs e)
        {
            showMonth = Utils.StrToInt(Request.QueryString["m"], DateTime.Now.Month);
            showYear = Utils.StrToInt(Request.QueryString["year"], DateTime.Now.Month);


            rname.Text = this.Session["TrueName"].ToString();
            uname.Text = this.Session["UserName"].ToString();
        }
    }
}