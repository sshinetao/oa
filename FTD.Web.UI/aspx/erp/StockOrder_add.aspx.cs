using FTD.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class StockOrder_add : System.Web.UI.Page
    {
        //protected System.Web.UI.WebControls.TextBoStockPeoName
        public static string Gusername, Grealname, Gname;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                Random g = new Random();
                string rad = g.Next(10000).ToString();

                number.Text = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + "" + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + "" + System.DateTime.Now.Millisecond.ToString() + "" + rad + "";

                StockPeoName.Text = Session["TrueName"] + "";
                StockPeoNum.Text = Session["UserName"] + "";
                rname.Text = this.Session["TrueName"] + "";
                uname.Text = this.Session["UserName"] + "";
                if (!IsPostBack)
                {
                    BindOrderType();
                    BindStoreroom();
                }
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }


        /// <summary>
        /// 订单类型
        /// </summary>
        protected void BindOrderType()
        {
            FTD.BLL.RuKuLeiXing bll = new BLL.RuKuLeiXing();
            DataSet ds = bll.GetList("");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                ddlOrderType.DataSource = dt;
                ddlOrderType.DataValueField = "Name";
                ddlOrderType.DataTextField = "Name";

                if (Request.Params["lx"]+""!="")
                {
                    ddlOrderType.SelectedIndex = int.Parse(Request.Params["lx"] + "");
                }
                ddlOrderType.DataBind();
            }
            else
            {
                ListItem li = new ListItem();
                li.Text = "没有该选项";
                li.Value = "0";
                ddlOrderType.Items.Add(li);
            }
            
        }

        protected void BindStoreroom()
        {
            FTD.BLL.Storeroom bll = new Storeroom();
            DataSet ds = bll.GetList("");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                ddlStoreroom.DataSource = dt;
                ddlStoreroom.DataValueField = "Name";
                ddlStoreroom.DataTextField = "Name";
                ddlStoreroom.DataBind();
            }
            else
            {
                ListItem li = new ListItem();
                li.Text = "没有该选项";
                li.Value = "0";
                ddlStoreroom.Items.Add(li);
            }
        }


        protected void BindXsdd_WorkStreamType()
        {
            


        }

         
    }
}