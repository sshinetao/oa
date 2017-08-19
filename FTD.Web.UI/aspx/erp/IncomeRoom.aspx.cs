using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class IncomeRoom : System.Web.UI.Page
    {
        qpsmartweb_jxc.Public.Db List = new qpsmartweb_jxc.Public.Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            FTD.Unit.PublicMethod.CheckSession();

            if (!Page.IsPostBack)
            {
                tilte.Attributes["onkeydown"] = "if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
                this.Imagebutton5.Attributes.Add("onclick", "javascript:return del();");


            }

            string strSql = "";
            if (Request.QueryString["str"] != null)
            {
                strSql = "    " + Server.UrlDecode(Request.QueryString["keywords"]) + " like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'  and a.Username='" + this.Session["UserName"] + "'  order by id desc";
            }
            else
            {
                strSql = "   a.Username='" + this.Session["UserName"] + "'order by a.id desc";
            }

            FTD.BLL.IncomeRoom bll = new FTD.BLL.IncomeRoom();

            DataSet ds = bll.GetList(strSql);
            if (ds != null && ds.Tables.Count > 0)
            {
                Datagrid2.DataSource = ds.Tables[0];
                Datagrid2.DataBind();
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {

            Response.Redirect("IncomeRoom.aspx?str=" + tilte.Text + "&keywords=" +selectList.SelectedValue);
        }

        protected void Imagebutton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("IncomeRoom_add.aspx");
        }

        protected void Imagebutton9_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                Response.Redirect("IncomeRoom_show.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

        protected void Imagebutton4_Click(object sender, ImageClickEventArgs e)
        {
            try
            {





                if (Datagrid2.SelectedItem.Cells[7].Text.ToString() == "完成审核" || Datagrid2.SelectedItem.Cells[7].Text.ToString() == "正在审核")
                {
                    this.Response.Write("<script language=javascript>alert('当前状态为[" + Datagrid2.SelectedItem.Cells[7].Text.ToString() + "]，不能进行删除');</script>");
                    return;
                }



                Response.Redirect("IncomeRoom_update.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");




            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

        protected void Imagebutton5_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                string SQL_Del = "Delete from IncomeRoom where id='" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "'";
                int _id = Utils.GetInt(Datagrid2.SelectedItem.Cells[1].Text.ToString(), 0);
                FTD.BLL.IncomeRoom bll = new FTD.BLL.IncomeRoom();
                bll.Delete(_id);
                string strSql = "";
                if (Request.QueryString["str"] != null)
                {
                    strSql = "    title like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'   order by a.id desc";
                }
                else
                {
                    strSql = "    a.Username='" + this.Session["UserName"] + "'order by a.id desc";
                }
                DataSet ds = bll.GetList(strSql);
                if (ds != null)
                {
                    Datagrid2.DataSource = ds.Tables[0];
                    Datagrid2.DataBind();
                    Response.Redirect("IncomeRoom.aspx");
                }
            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
            }

        }

        protected void Imagebutton8_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                Response.Redirect("IncomeRoom_gz.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("IncomeRoomLeading.aspx");
            //IncomeRoomLeading
        }

        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }

    }
}