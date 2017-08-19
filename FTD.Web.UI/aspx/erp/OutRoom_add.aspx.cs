using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class OutRoom_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindInSource();
                BindStoreroom();
                Random g = new Random();
                string rad = g.Next(10000).ToString();
                number.Text = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + "" + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + "" + System.DateTime.Now.Millisecond.ToString() + "" + rad + "";
                rname.Text = this.Session["TrueName"].ToString();
                uname.Text = this.Session["UserName"].ToString();
            }
        }


        protected void BindInSource()
        {
            FTD.BLL.OutUse bll = new FTD.BLL.OutUse();
            DataSet ds = bll.GetList("");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                if (dt != null)
                {
                    ddlSource.DataSource = dt;
                    ddlSource.DataTextField = "Name";
                    ddlSource.DataValueField = "Name";
                    ddlSource.DataBind();
                }
            }

        }

        protected void BindStoreroom()
        {

            FTD.BLL.Storeroom bll = new BLL.Storeroom();
            DataSet ds = bll.GetList("");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                if (dt != null)
                {
                    ddlStoreroom.DataSource = dt;
                    ddlStoreroom.DataTextField = "Name";
                    ddlStoreroom.DataValueField = "Name";
                    ddlStoreroom.DataBind();
                }
            }


        }
    }
}