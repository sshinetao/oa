using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace qpsmartweb_jxc
{
    public partial class StockPlan_add_add2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.ImageButton1.Attributes.Add("onclick", "javascript:return chknull();");
                Realname.Text = this.Session["TrueName"].ToString();

            }
        }


       
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Db List = new Db();
            string sql_insert_xtrz = "insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('新增[采购计划明细]','采购计划','" + this.Session["username"] + "','" + this.Session["TrueName"] + "','" + System.DateTime.Now.ToString() + "')";
            List.ExeSql(sql_insert_xtrz);

            string sql_insert = "insert into StockPlanMx (Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,Stocktype,StockPeoNum,StockPeoName,CompanyNumber,CompanyName,CompanyAdd,JyOrderTime,JyToTime,TxTime,Username,Realname,Nowtimes) values('" + Request.QueryString["number"] + "','" + GoodsNumber.Text.Replace("<", "〈").Replace(">", "〉").Replace("'", "’") + "','" + GoodsName.Text + "','" + CountUnit.Text + "','" + Model.Text + "','" + StockPoint.Text + "','" + SingleMoney.Text + "','" + Allmoney.Text + "','" + Stocktype.SelectedValue + "','" + StockPeoNum.Text + "','" + StockPeoName.Text + "','" + CompanyNumber.Text + "','" + CompanyName.Text + "','" + CompanyAdd.Text + "','" + JyOrderTime.Text + "','" + JyToTime.Text + "','" + TxTime.Text + "','" + this.Session["username"].ToString() + "','" + this.Session["TrueName"].ToString() + "','" + System.DateTime.Now.ToString() + "')";
            List.ExeSql(sql_insert);

            this.Response.Write("<script language=javascript>alert('提交成功！');window.close()</script>");
        }
    }
}