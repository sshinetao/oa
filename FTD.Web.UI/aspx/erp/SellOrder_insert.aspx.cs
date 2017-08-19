using FTD.BLL;
using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class SellOrder_insert : System.Web.UI.Page
    {
        Db List = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            Random g = new Random();
            string rad = g.Next(10000).ToString();
            number.Text = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + "" + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + "" + System.DateTime.Now.Millisecond.ToString() + "" + rad + "";
          
            StockPeoName.Text = Session["TrueName"].ToString();
            StockPeoNum.Text = Session["UserName"].ToString();
            rname.Text = this.Session["TrueName"].ToString();
            uname.Text = this.Session["UserName"].ToString();

            if (!IsPostBack)
            {
               
                BindOrderType();
                BindStoreroom();
                BindXsdd_WorkStreamType();
            }

        }

      

        /// <summary>
        /// 订单类型
        /// </summary>
        protected void BindOrderType()
        {
            FTD.BLL.OrderType bll = new BLL.OrderType();
            DataSet ds = bll.GetList("");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                ddlOrderType.DataSource = dt;
                ddlOrderType.DataValueField = "Name";
                ddlOrderType.DataTextField = "Name";
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
            Xsdd_WorkStreamType bll = new Xsdd_WorkStreamType();
            DataSet ds = bll.GetList("");

             if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                ddlXsdd_WorkStreamType.DataSource = dt;
                ddlXsdd_WorkStreamType.DataValueField = "Number";
                ddlXsdd_WorkStreamType.DataTextField = "Name";
                ddlXsdd_WorkStreamType.DataBind();
            }
            else
            {
                ListItem li = new ListItem();
                li.Text = "没有该选项";
                li.Value = "0";
                ddlXsdd_WorkStreamType.Items.Add(li);
            }   
          
           
        }



    }
}