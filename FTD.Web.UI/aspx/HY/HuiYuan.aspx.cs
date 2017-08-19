
using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace OA.aspx.HY{
    public partial class HuiYuan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FTD.Unit.PublicMethod.CheckSession();
                DataBindToGridview("");

                //设定按钮权限            
                iButton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|HY001A|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
                iButton5.Visible = FTD.Unit.PublicMethod.StrIFIn("|HY001M|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
                iButton3.Visible = FTD.Unit.PublicMethod.StrIFIn("|HY001D|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
                iButton2.Visible = FTD.Unit.PublicMethod.StrIFIn("|HY001E|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
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
            FTD.BLL.ERPNewHuiYuan MyModel = new FTD.BLL.ERPNewHuiYuan();
            DataSet ds;
            if (IDList.Trim().Length > 0)
            {
                ds = MyModel.GetList(" UserName='" + FTD.Unit.PublicMethod.GetSessionValue("UserName") + "' and " + DropDownList2.SelectedItem.Value.ToString() + " like '%" + this.TextBox3.Text.Trim() + "%' and [ERPNewHuiYuan].ID in(" + IDList + ") order by [ERPNewHuiYuan].ID desc");
            }
            else
            {
                ds = MyModel.GetList(" UserName='" + FTD.Unit.PublicMethod.GetSessionValue("UserName") + "' and " + DropDownList2.SelectedItem.Value.ToString() + " like '%" + this.TextBox3.Text.Trim() + "%' order by [ERPNewHuiYuan].ID desc");
            }
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                dt.Columns.Add("weekday");
                dt.Columns.Add("statName");
                foreach (DataRow dr in dt.Rows)
                {
                    string sendrole = dr["Sendrole"].ToString();
                    if (sendrole != "")
                    {
                        #region 配送规则
                        string[] sendrolearray = sendrole.Split('|');
                        string _strsendrole = "";
                        foreach (string s in sendrolearray)
                        {
                            if (_strsendrole != "")
                            {
                                _strsendrole += ",";
                            }
                            switch (s)
                            {
                                case "0":
                                    _strsendrole += "周日";
                                    break;
                                case "1":
                                    _strsendrole += "周一";
                                    break;
                                case "2":
                                    _strsendrole += "周二";
                                    break;
                                case "3":
                                    _strsendrole += "周三";
                                    break;
                                case "4":
                                    _strsendrole += "周四";
                                    break;
                                case "5":
                                    _strsendrole += "周五";
                                    break;
                                case "6":
                                    _strsendrole += "周六";
                                    break;
                                default:

                                    break;
                            }

                        }
                        #endregion
                        dr["weekday"] = _strsendrole;
                    }
                    else
                    {
                        dr["weekday"] = "无";
                    }
                    string stat = dr["CStaus"].ToString();
                    if (stat != "")
                    {
                        switch (stat)
                        {
                            case "0":
                                dr["statName"] = "正在进行";
                                break;
                            case "1":
                                dr["statName"] = "已经结束";
                                break;
                            case "-1":
                                dr["statName"] = "暂时冻结";
                                break;
                        }
                        if (stat == "0")
                        { }
                    }
                }
                GVData.DataSource = dt;

            }
            else
            {
                GVData.DataSource = ds;
            }


            GVData.DataBind();
            LabPageSum.Text = Convert.ToString(GVData.PageCount);
            LabCurrentPage.Text = Convert.ToString(((int)GVData.PageIndex + 1));
            this.GoPage.Text = LabCurrentPage.Text.ToString();
        }
        protected void iButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("HuiYuanAdd.aspx");
        }
        protected void iButton3_Click(object sender, EventArgs e)
        {
            string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("delete from ERPNewHuiYuan where ID in (" + IDlist + ")") == -1)
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
        protected void iButton2_Click(object sender, EventArgs e)
        {
            string CheckStr = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            string[] CheckStrArray = CheckStr.Split(',');
            Response.Redirect("HYLeading.aspx?ID=" + CheckStrArray[0].ToString());


        }
        protected void iButton5_Click(object sender, EventArgs e)
        {
            string CheckStr = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            string[] CheckStrArray = CheckStr.Split(',');
            Response.Redirect("HuiYuanModify.aspx?ID=" + CheckStrArray[0].ToString());
        }


        protected void iButton8_Click(object sender, EventArgs e)
        {
            string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("update  ERPNewHuiYuan set CStaus=-1  where ID in (" + IDlist + ")") == -1)
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


        protected void iButton7_Click(object sender, EventArgs e)
        {
            string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("update  ERPNewHuiYuan set CStaus=0  where ID in (" + IDlist + ")") == -1)
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