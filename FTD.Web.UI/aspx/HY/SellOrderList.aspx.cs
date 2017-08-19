using FTD.BLL;
using qpsmartweb_jxc.Public;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.HY
{
    public partial class SellOrderList : System.Web.UI.Page
    {
        Db List = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            FTD.Unit.PublicMethod.CheckSession();
            if (!Page.IsPostBack)
            {
                tilte.Attributes["onkeydown"] = "if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
                this.Imagebutton5.Attributes.Add("onclick", "javascript:return del();");

                Imagebutton9.Visible = FTD.Unit.PublicMethod.StrIFIn("|pthy010|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian")); //查看
                Imagebutton4.Visible = FTD.Unit.PublicMethod.StrIFIn("|pthy010M|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));//修改
                Imagebutton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|pthy010A|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));//添加
                Imagebutton5.Visible = FTD.Unit.PublicMethod.StrIFIn("|pthy010I|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));//删除

            }
            SellOrder_pt bll = new SellOrder_pt();
            if (Request.QueryString["str"] != null)
            {
                string strSql =" title like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'  and Username='" + this.Session["username"] + "'  order by id desc";
              
                DataSet ds =  bll.GetList(strSql);
                if(ds !=null)
                {
                    Datagrid2.DataSource = ds.Tables[0];
                    Datagrid2.DataBind();

                }


            }
            else
            {
                string SQL_GetList_xs = " Username='" + this.Session["username"] + "'order by id desc";
                DataSet ds = bll.GetList(SQL_GetList_xs);
                if (ds != null)
                {
                    Datagrid2.DataSource = ds.Tables[0];
                    Datagrid2.DataBind();

                }
            }
        }


        protected void MyDataGrid_Page_1(object sender, DataGridPageChangedEventArgs e)
        {
            Datagrid2.CurrentPageIndex = e.NewPageIndex;
            Datagrid2.DataBind();
        }

        private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("SellOrderlist.aspx?str=" + tilte.Text + "");
        }

        private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("main_1.aspx");
        }

        private void Imagebutton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {
                //MonthSet bll = new MonthSet();
                //string SQL_GetList_yj = "select * from MonthSet where  '" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' as datetime),120) ";
                //OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
                //if (NewReader_yj.Read())
                //{
                //    this.Response.Write("<script language=javascript>alert('已经执行月结存，操作失败');</script>");
                //    return;


                //}

                //if (Datagrid2.SelectedItem.Cells[10].Text.ToString() == "执行完毕" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "强制停止" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "作废" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "完成审核" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "正在审核" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导入库单" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导退货单")
                //{
                //    this.Response.Write("<script language=javascript>alert('当前状态为[" + Datagrid2.SelectedItem.Cells[10].Text.ToString() + "]，不能进行删除');</script>");
                //    return;
                //}

                SellOrder bll = new SellOrder();
                int sellorder =  Utils.GetInt(Datagrid2.SelectedItem.Cells[1].Text.ToString(), 0);
                bll.Delete(sellorder);
                



                if (Request.QueryString["str"] != null)
                {
                    string SQL_GetList_xs = "select * from SellOrder_pt where  tilte like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'   order by id desc";
                    Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                    Datagrid2.DataBind();

                }
                else
                {
                    string SQL_GetList_xs = "select * from SellOrder_pt order by id desc";
                    Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                    Datagrid2.DataBind();
                }

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
            }
        }

        private void Imagebutton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {

                string SQL_GetList_yj = "select * from MonthSet where  '" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' as datetime),120) ";
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

        private void Imagebutton9_Click(object sender, System.Web.UI.ImageClickEventArgs e)
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

        private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("SellOrder_insert.aspx");
        }


        private void Imagebutton7_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {


                string SQL_GetList_yj = "select * from MonthSet where  '" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' as datetime),120) ";
                OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
                if (NewReader_yj.Read())
                {
                    this.Response.Write("<script language=javascript>alert('已经执行月结存，操作失败');</script>");
                    return;


                }



                if (Datagrid2.SelectedItem.Cells[10].Text.ToString() == "执行完毕" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "强制停止" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "作废" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导入库单" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "已导退货单")
                {


                    this.Response.Write("<script language=javascript>alert('操作失败!当前状态已经为[" + Datagrid2.SelectedItem.Cells[10].Text.ToString() + "]');</script>");
                }
                else
                {
                    string SQL_Del = "update  SellOrder_pt   set State='作废' where id='" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "'";

                    List.ExeSql(SQL_Del);

                    this.Response.Write("<script language=javascript>alert('提交成功！状态更改为[作废]');window.location.href='SellOrder.aspx'</script>");
                }




            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }


        }

        private void Imagebutton8_Click(object sender, System.Web.UI.ImageClickEventArgs e)
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

        protected void Imagebutton1_Click1(object sender, ImageClickEventArgs e)
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

               
                    Response.Redirect("SellOrder_update.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");
                



            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('请确定是否选中行');</script>");
            }
        }

        protected void Imagebutton5_Click1(object sender, ImageClickEventArgs e)
        {
            try
            {
                string SQL_Del = "Delete from SellOrder_pt where id='" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "'";

                List.ExeSql(SQL_Del);

                System.Data.DataView dv = new System.Data.DataView();
                

                if (Request.QueryString["str"] != null)
                {
                    string SQL_GetList_xs = "select * from SellOrder_pt where  tilte like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'   order by id desc";
                    Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                    Datagrid2.DataBind();

                }
                else
                {
                    string SQL_GetList_xs = "select * from SellOrder_pt order by id desc";
                    Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                    Datagrid2.DataBind();
                }

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('删除失败！请确定是否选中删除行');</script>");
            }
        }



    }
}