using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.qita
{
    public partial class qitaziliaoguanli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Unit.PublicMethod.CheckSession();
                DataBindToGridview("");

                //设定按钮权限            
                iButton1.Visible = Unit.PublicMethod.StrIFIn("|HY001A|", Unit.PublicMethod.GetSessionValue("QuanXian"));
                iButton5.Visible = Unit.PublicMethod.StrIFIn("|HY001M|", Unit.PublicMethod.GetSessionValue("QuanXian"));
                iButton3.Visible = Unit.PublicMethod.StrIFIn("|HY001D|", Unit.PublicMethod.GetSessionValue("QuanXian"));
                iButton2.Visible = Unit.PublicMethod.StrIFIn("|HY001E|", Unit.PublicMethod.GetSessionValue("QuanXian"));
                //iButton1.Visible = Unit.PublicMethod.StrIFIn("|2S001A|", Unit.PublicMethod.GetSessionValue("QuanXian"));
                //iButton5.Visible = Unit.PublicMethod.StrIFIn("|2S001M|", Unit.PublicMethod.GetSessionValue("QuanXian"));
                //iButton3.Visible = Unit.PublicMethod.StrIFIn("|2S001D|", Unit.PublicMethod.GetSessionValue("QuanXian"));
                //iButton2.Visible = Unit.PublicMethod.StrIFIn("|2S001E|", Unit.PublicMethod.GetSessionValue("QuanXian"));
            }
        }
        #region  分页方法
        protected void ButtonGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (GoPage.Text.Trim().ToString() == "")
                {
                    Response.Write("<script language='javascript'>alert('页码不可以为空!');</script>");
                }
                else if (GoPage.Text.Trim().ToString() == "0" || Convert.ToInt32(GoPage.Text.Trim().ToString()) > GVData.PageCount)
                {
                    Response.Write("<script language='javascript'>alert('页码不是一个有效值!');</script>");
                }
                else if (GoPage.Text.Trim() != "")
                {
                    int PageI = int.Parse(GoPage.Text.Trim()) - 1;
                    if (PageI >= 0 && PageI < (GVData.PageCount))
                    {
                        GVData.PageIndex = PageI;
                    }
                }

                if (TxtPageSize.Text.Trim().ToString() == "")
                {
                    Response.Write("<script language='javascript'>alert('每页显示行数不可以为空!');</script>");
                }
                else if (TxtPageSize.Text.Trim().ToString() == "0")
                {
                    Response.Write("<script language='javascript'>alert('每页显示行数不是一个有效值!');</script>");
                }
                else if (TxtPageSize.Text.Trim() != "")
                {
                    try
                    {
                        int MyPageSize = int.Parse(TxtPageSize.Text.ToString().Trim());
                        GVData.PageSize = MyPageSize;
                    }
                    catch
                    {
                        Response.Write("<script language='javascript'>alert('每页显示行数不是一个有效值!');</script>");
                    }
                }

                DataBindToGridview("");
            }
            catch
            {
                DataBindToGridview("");
                Response.Write("<script language='javascript'>alert('请输入有效数字！');</script>");
            }
        }
        protected void PagerButtonClick(object sender, EventArgs e)
        {
            //获得Button的参数值
            string arg = ((ImageButton)sender).CommandName.ToString();
            switch (arg)
            {
                case ("Next"):
                    if (this.GVData.PageIndex < (GVData.PageCount - 1))
                        GVData.PageIndex++;
                    break;
                case ("Pre"):
                    if (GVData.PageIndex > 0)
                        GVData.PageIndex--;
                    break;
                case ("Last"):
                    try
                    {
                        GVData.PageIndex = (GVData.PageCount - 1);
                    }
                    catch
                    {
                        GVData.PageIndex = 0;
                    }

                    break;
                default:
                    //本页值
                    GVData.PageIndex = 0;
                    break;
            }
            DataBindToGridview("");
        }
        #endregion
        protected void GVData_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            Unit.PublicMethod.GridViewRowDataBound(e);
        }

        public void DataBindToGridview()
        {
            BLL.QTZLGL MyModel = new BLL.QTZLGL();
            GVData.DataSource = MyModel.GetList(DropDownList2.SelectedItem.Value.ToString() + " like '%" + this.TextBox3.Text.Trim() + "%' order by ID desc");
            GVData.DataBind();
            LabPageSum.Text = Convert.ToString(GVData.PageCount);
            LabCurrentPage.Text = Convert.ToString(((int)GVData.PageIndex + 1));
            this.GoPage.Text = LabCurrentPage.Text.ToString();
        }
        public void DataBindToGridview(string IDList)
        {
            BLL.QTZLGL MyModel = new BLL.QTZLGL();
            DataSet ds;
            string _strsql = " 1=1 ";


            if (IDList.Trim().Length > 0)
            {
                _strsql += " and " + DropDownList2.SelectedItem.Value.ToString() + " like '%" + this.TextBox3.Text.Trim() + "%' and ID in(" + IDList + ") ";

            }

            ds = MyModel.GetList(_strsql);
            if (ds != null && ds.Tables.Count > 0)
            {
                DataTable dt = ds.Tables[0];

                GVData.DataSource = dt;
                GVData.DataBind();
                LabPageSum.Text = Convert.ToString(GVData.PageCount);
                LabCurrentPage.Text = Convert.ToString(((int)GVData.PageIndex + 1));
                this.GoPage.Text = LabCurrentPage.Text.ToString();
            }
            else
            {

            }




        }
        protected void iButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("qitaziliaoguanliAdd.aspx");
        }
        protected void iButton2_Click(object sender, EventArgs e)
        {
            string CheckStr = Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            string[] CheckStrArray = CheckStr.Split(',');
            Response.Redirect("qitaziliaoguanli.aspx?ID=" + CheckStrArray[0].ToString());
        }
        protected void iButton3_Click(object sender, EventArgs e)
        {
            string IDlist = Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            if (DBUnit.DbHelperSQL.ExecuteSQL("delete from qitaziliaoguanli where ID in (" + IDlist + ")") == -1)
            {
                Response.Write("<script>alert('删除选中记录时发生错误！请重新登陆后重试！');</script>");
            }
            else
            {
                DataBindToGridview("");
 
            }
        }
        protected void iButton4_Click(object sender, EventArgs e)
        {
            DataBindToGridview();
        }
        protected void iButton5_Click(object sender, EventArgs e)
        {
            string CheckStr = Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            string[] CheckStrArray = CheckStr.Split(',');
            Response.Redirect("qitaziliaoguanliModify.aspx?ID=" + CheckStrArray[0].ToString());
        }



        //

        protected void iButton6_Click(object sender, EventArgs e)
        {
            //保存上一次查询结果
            string JJ = "0";
            for (int i = 0; i < this.GVData.Rows.Count; i++)
            {
                Label LabV = (Label)GVData.Rows[i].FindControl("LabVisible");
                JJ = JJ + "," + LabV.Text.Trim();
            }
            DataBindToGridview(JJ);
        }
    }
}