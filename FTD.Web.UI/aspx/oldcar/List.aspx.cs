using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.oldcar
{
    public partial class List : System.Web.UI.Page
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
                //iButton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|2S001A|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
                //iButton5.Visible = FTD.Unit.PublicMethod.StrIFIn("|2S001M|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
                //iButton3.Visible = FTD.Unit.PublicMethod.StrIFIn("|2S001D|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
                //iButton2.Visible = FTD.Unit.PublicMethod.StrIFIn("|2S001E|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
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
            DataBindToGridview();
        }
        public void DataBindToGridview()
        {
            FTD.BLL.OldCar MyModel = new FTD.BLL.OldCar();
            GVData.DataSource = MyModel.GetList(DropDownList2.SelectedItem.Value.ToString() + " like '%" + this.TextBox3.Text.Trim() + "%' order by ID desc");
            GVData.DataBind();
            LabPageSum.Text = Convert.ToString(GVData.PageCount);
            LabCurrentPage.Text = Convert.ToString(((int)GVData.PageIndex + 1));
            this.GoPage.Text = LabCurrentPage.Text.ToString();
        }
        public void DataBindToGridview(string IDList)
        {
            FTD.BLL.OldCar MyModel = new FTD.BLL.OldCar();
            DataSet ds;
            string _strsql = " UserId='" + FTD.Unit.PublicMethod.GetSessionValue("UserName") + "'";


            if (IDList.Trim().Length > 0)
            {
                _strsql += " and " + DropDownList2.SelectedItem.Value.ToString()+ " like '%" + this.TextBox3.Text.Trim() + "%' and ID in(" + IDList + ") ";
              
            }
           
            ds = MyModel.GetList(_strsql);
            if (ds != null&& ds.Tables.Count>0)
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
            Response.Redirect("OldCarInfo.aspx");
        }
        protected void iButton2_Click(object sender, EventArgs e)
        {
            string CheckStr = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            string[] CheckStrArray = CheckStr.Split(',');
            Response.Redirect("List.aspx?ID=" + CheckStrArray[0].ToString());
        }
        protected void iButton3_Click(object sender, EventArgs e)
        {
            string IDlist = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            if (FTD.DBUnit.DbHelperSQL.ExecuteSQL("delete from OldCar where ID in (" + IDlist + ")") == -1)
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
            Response.Redirect("OldCarModify.aspx?ID=" + CheckStrArray[0].ToString());
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