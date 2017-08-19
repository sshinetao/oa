using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.HY
{
    public partial class SellOrder_insert_add : System.Web.UI.Page
    {
        Db List = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.ImageButton1.Attributes.Add("onclick", "javascript:return chknull();");
                Realname.Text = this.Session["TrueName"].ToString();
            }
        }
        private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
           
        }

        protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
        {
            string sql_insert_xtrz = "insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增[采购订单明细]','采购订单','" + this.Session["username"] + "','" + this.Session["TrueName"] + "','" + System.DateTime.Now.ToString() + "')";
            List.ExeSql(sql_insert_xtrz);

            string sql_insert = "insert into SellOrderMx (Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,Username,Realname,Nowtimes,YfMoney) values('" + Request.QueryString["number"] + "','" + GoodsNumber.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") + "','" + GoodsName.Text + "','" + CountUnit.Text + "','" + Model.Text + "','" + StockPoint.Text + "','" + SingleMoney.Text + "','" + Allmoney.Text + "','" + this.Session["username"].ToString() + "','" + this.Session["TrueName"].ToString() + "','" + System.DateTime.Now.ToString() + "','0')";
            List.ExeSql(sql_insert);

            this.Response.Write("<script language=javascript>alert('提交成功！');window.close()</script>");
        }
    }
}