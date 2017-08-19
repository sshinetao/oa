using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class SellOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            tilte.Attributes["onkeydown"] = "if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
            this.Imagebutton5.Attributes.Add("onclick", "javascript:return del();");
            this.Imagebutton7.Attributes.Add("onclick", "javascript:return zf();");

            Imagebutton9.Visible = FTD.Unit.PublicMethod.StrIFIn("|xiaoshou010|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian")); //查看
            Imagebutton4.Visible = FTD.Unit.PublicMethod.StrIFIn("|xiaoshou010M|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));//修改
            Imagebutton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|xiaoshou010A|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));//添加
            Imagebutton5.Visible = FTD.Unit.PublicMethod.StrIFIn("|xiaoshou010D|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));//删除
            FTD.BLL.SellOrder bll = new FTD.BLL.SellOrder();
            string _sql = "";
            if (Request.QueryString["str"] != null)
            {
                _sql = "( {0} like '%{1}%' ) and Username='{2}' ";
                _sql = string.Format(_sql, Server.UrlDecode(Request.QueryString["keywords"]), Server.UrlDecode(Request.QueryString["str"]), this.Session["username"]);
            }
            else
            {
                _sql = " Username='" + this.Session["username"] + "' ";
            }
            DataSet ds = bll.GetList(_sql);
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
            Response.Redirect("SellOrder.aspx?str=" + tilte.Text + "&keywords=" + sellorderSelect.SelectedValue);
        }

        protected void Imagebutton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SellOrder_insert.aspx");
        }

        protected void Imagebutton9_Click1(object sender, ImageClickEventArgs e)
        {
            try
            {

                Response.Redirect("SellOrder_show.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

        protected void Imagebutton4_Click1(object sender, ImageClickEventArgs e)
        {
            try
            {

                string MyTimes = Datagrid2.SelectedItem.Cells[13].Text+"";
                string SQL_GetList_yj = "select * from MonthSet where   '" + MyTimes +  "'  between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('" +
                    MyTimes + "' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('" +
                    MyTimes + "' as datetime),120) ";
                OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
                if (NewReader_yj.Read())
                {
                    this.Response.Write("<script language=javascript>alert('已经执行月结存，操作失败');</script>");
                    return;


                }
                if (Datagrid2.SelectedItem.Cells[10].Text.ToString() == "执行完毕" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "强制停止" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "作废" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "完成审核" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "正在审核" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导入库单" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导退货单")
                {
                    this.Response.Write("<script language=javascript>alert('当前状态为[" + Datagrid2.SelectedItem.Cells[10].Text.ToString() + "]，不能进行修改');</script>");

                }
                else
                {
                    Response.Redirect("SellOrder_update.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");
                }



            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }
        Db List = new Db();
        protected void Imagebutton5_Click1(object sender, ImageClickEventArgs e)
        {
            try
            {


            
                if (Datagrid2.SelectedItem.Cells[10].Text.ToString() == "执行完毕" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "强制停止" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "作废" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "完成审核" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "正在审核" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导入库单" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导退货单")
                {
                    this.Response.Write("<script language=javascript>alert('当前状态为[" + Datagrid2.SelectedItem.Cells[10].Text.ToString() + "]，不能进行删除');</script>");
                    return;
                }


                string SQL_Del = "Delete from SellOrder where id='" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "'";

                List.ExeSql(SQL_Del);



                if (Request.QueryString["str"] != null)
                {
                    string SQL_GetList_xs = "select * from SellOrder where  tilte like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'   order by id desc";
                    Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                    Datagrid2.DataBind();

                }
                else
                {
                    string SQL_GetList_xs = "select * from SellOrder order by id desc";
                    Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                    Datagrid2.DataBind();
                }

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
            }
        }

        protected void Imagebutton7_Click(object sender, ImageClickEventArgs e)
        {
            try
            {





                if (Datagrid2.SelectedItem.Cells[10].Text.ToString() == "执行完毕" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "强制停止" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "作废" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导入库单" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导退货单")
                {


                    this.Response.Write("<script language=javascript>alert('操作失败!当前状态已经为[" + Datagrid2.SelectedItem.Cells[10].Text.ToString() + "]');</script>");
                }
                else
                {
                    string SQL_Del = "update  SellOrder   set State='作废' where id='" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "'";

                    List.ExeSql(SQL_Del);

                    this.Response.Write("<script language=javascript>alert('提交成功！状态更改为[作废]');window.location.href='SellOrder.aspx'</script>");
                }




            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }

        }

        protected void Imagebutton8_Click(object sender, ImageClickEventArgs e)
        {
            try
            {

                Response.Redirect("SellOrder_gz.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("main_1.aspx");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SellOrderLeading.aspx");
        }
    }
}