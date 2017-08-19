
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class IncomeRoom_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindInSource();
                BindStoreroom();
                Bindrukuleixing();
                Random g = new Random();
                string rad = g.Next(10000).ToString();
                number.Text = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + "" + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + "" + System.DateTime.Now.Millisecond.ToString() + "" + rad + "";
                ShTime.Text = DateTime.Now.ToShortDateString();
                rname.Text = this.Session["TrueName"]+"";
                uname.Text = this.Session["UserName"]+"";
            }
        }

        protected void BindInSource()
        {
            FTD.BLL.InSource bll = new FTD.BLL.InSource();
            DataSet ds = bll.GetList("");
            if(ds !=null)
            {
                DataTable dt = ds.Tables[0];
                if(dt !=null)
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

        protected void Bindrukuleixing() {
            FTD.BLL.RuKuLeiXing bll = new BLL.RuKuLeiXing();
            DataSet ds = bll.GetList("");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                if (dt != null)
                {
                    rukuleixing.DataSource = dt;
                    rukuleixing.DataTextField = "Name";
                    rukuleixing.DataValueField = "Name";

                    if (Request.Params["lx"] + "" != "")
                    {
                        rukuleixing.SelectedIndex = int.Parse(Request.Params["lx"] + "");
                    }
                    rukuleixing.DataBind();
                }
            }
        }



    }
}