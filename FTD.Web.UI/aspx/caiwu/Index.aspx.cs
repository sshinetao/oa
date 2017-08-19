using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.ashx
{
    public partial class Index : System.Web.UI.Page
    {
        public static int year = 2017;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FTD.Unit.PublicMethod.CheckSession();
                getMonth();
                BindYear();
                year = Utils.StrToInt(ddlYear.SelectedValue, 2017);
                //设定按钮权限            
               
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
                    int PageI = Int32.Parse(GoPage.Text.Trim()) - 1;
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
                        this.GVData.PageSize = MyPageSize;
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
            FTD.Unit.PublicMethod.GridViewRowDataBound(e);
        }
        protected void iButton4_Click(object sender, EventArgs e)
        {
            DataBindToGridview("");
        }
        public void DataBindToGridview(string IDList)
        {
            FTD.BLL.ERPHuiYuanTaoCan MyModel = new FTD.BLL.ERPHuiYuanTaoCan();
            if (IDList.Trim().Length > 0)
            {
                GVData.DataSource = MyModel.GetList("");
            }
            else
            {
                GVData.DataSource = MyModel.GetList("");
            }
            GVData.DataBind();
            LabPageSum.Text = Convert.ToString(GVData.PageCount);
            LabCurrentPage.Text = Convert.ToString(((int)GVData.PageIndex + 1));
            this.GoPage.Text = LabCurrentPage.Text.ToString();
        }
        protected void iButton1_Click(object sender, EventArgs e)
        {

            getMonth();

            Response.Redirect("liushui.aspx");
        }

        protected void BindYear()
        {
            int nowyear = DateTime.Now.Year;
            for(int k = nowyear; k>2015;k--)
            {
                ListItem li = new ListItem();
                li.Text = k + "年";
                li.Value = k.ToString();
                ddlYear.Items.Add(li);
            }

        }

        protected void getMonth()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Months");
            int nowyear = DateTime.Now.Year;
            int nowmonth = DateTime.Now.Month;
            int _Year = Utils.StrToInt(ddlYear.SelectedValue, 2017);
            int KMonth = 12;
            if (nowyear == _Year)
            {
                KMonth = nowmonth;
            }

            for (int ik = KMonth; ik >= 1; ik--)
            {
                DataRow row;
                row = dt.NewRow();
                row["Months"] = ik;
                dt.Rows.Add(row);
            }
            GVData.DataSource = dt;
            GVData.DataBind();
        }



        protected void iButton3_Click(object sender, EventArgs e)
        {
            string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("delete from ERPHuiYuanTaoCan where ID in (" + IDlist + ")") == -1)
            {
                Response.Write("<script>alert('删除选中记录时发生错误！请重新登陆后重试！');</script>");
            }
            else
            {
                DataBindToGridview("");
                //写系统日志
                FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
                MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
                MyRiZhi.DoSomething = "用户删除会员信息";
                MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
                MyRiZhi.Add();
            }
        }

        protected void iButton5_Click(object sender, EventArgs e)
        {
            string CheckStr = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            string[] CheckStrArray = CheckStr.Split(',');
            Response.Redirect("HuiYuanTaoCanModify.aspx?ID=" + CheckStrArray[0].ToString());
        }
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

        protected void ddlYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            getMonth();
            year = Utils.StrToInt(ddlYear.SelectedValue, 2017);
        }
    }
}