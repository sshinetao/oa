using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class OutRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FTD.Unit.PublicMethod.CheckSession();


            if (!Page.IsPostBack)
            {
                tilte.Attributes["onkeydown"] = "if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
                this.Imagebutton5.Attributes.Add("onclick", "javascript:return del();");


            }

            FTD.BLL.OutRoom bll = new FTD.BLL.OutRoom();
            string strSql = "";
            if (Request.QueryString["str"] != null)
            {
                strSql = "  " + Server.UrlDecode(Request.QueryString["keywords"]) + "  like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'  and Username='" + this.Session["username"] + "'  order by id desc";


            }
            else
            {
                strSql = " Username='" + this.Session["username"] + "'order by id desc";

            }
            DataSet ds = bll.GetList(strSql);
            if (ds != null && ds.Tables.Count > 0)
            {
                Datagrid2.DataSource = ds.Tables[0];
                Datagrid2.DataBind();
            }
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("OutRoom.aspx?str=" + tilte.Text + "&keywords=" +selectList.SelectedValue);
        }

        protected void Imagebutton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("OutRoom_add.aspx");
        }

        protected void Imagebutton9_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                Response.Redirect("OutRoom_show.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

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
                Response.Redirect("OutRoom_update.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");
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

                FTD.BLL.OutRoom bll = new FTD.BLL.OutRoom();

                int _id = Utils.GetInt(Datagrid2.SelectedItem.Cells[1].Text.ToString(), 0);
                bll.Delete(_id);


                string strSql = "";
                if (Request.QueryString["str"] != null)
                {
                    strSql = "  title like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'  and Username='" + this.Session["username"] + "'  order by id desc";


                }
                else
                {
                    strSql = " Username='" + this.Session["username"] + "'order by id desc";

                }
                DataSet ds = bll.GetList(strSql);
                if (ds != null && ds.Tables.Count > 0)
                {
                    Datagrid2.DataSource = ds.Tables[0];
                    Datagrid2.DataBind();
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

                Response.Redirect("OutRoom_gz.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

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
            Response.Redirect("OutRoomLeading.aspx");
        }

        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }
    }
}