using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.chanpinpeisong
{
    public partial class nongchanpinpeisong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataBindToGridview("");
        }
        protected void GVData_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            FTD.Unit.PublicMethod.GridViewRowDataBound(e);
        }
        private void DataBindToGridview()
        {
            FTD.BLL.ChanPinPeiSong MyModel = new FTD.BLL.ChanPinPeiSong();

            GVData.DataSource = MyModel.GetList(DropDownList2.SelectedItem.Value.ToString() + " like '%" + this.TextBox3.Text.Trim() + "%' order by ID desc");
            GVData.DataBind();
            LabPageSum.Text = Convert.ToString(GVData.PageCount);
            LabCurrentPage.Text = Convert.ToString(((int)GVData.PageIndex + 1));
            this.GoPage.Text = LabCurrentPage.Text.ToString();
        }
        public void DataBindToGridview(string IDList)
        {
            FTD.BLL.ChanPinPeiSong MyModel = new FTD.BLL.ChanPinPeiSong();
            DataSet ds = new DataSet();
            string _strsql = "";


            if (IDList.Trim().Length > 0)
            {
                _strsql += DropDownList2.SelectedItem.Value.ToString() + " like '%" + this.TextBox3.Text.Trim() + "%' and ID in(" + IDList + ") ";

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




        }
        protected void iButton4_Click(object sender, EventArgs e)
        {
            DataBindToGridview();
        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("nongchanpinpeisong_add.aspx");
        }

        protected void iButton5_Click(object sender, EventArgs e)
        {
            string CheckStr = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            string[] CheckStrArray = CheckStr.Split(',');
            Response.Redirect("nongchanpinpeisong_update.aspx?ID=" + CheckStrArray[0].ToString());
        }

        protected void iButton2_Click(object sender, EventArgs e)
        {

        }

        protected void iButton3_Click(object sender, EventArgs e)
        {
            string CheckStr = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            string[] CheckStrArray = CheckStr.Split(',');
            Response.Redirect("nongchanpinpeisong_update.aspx?ID=" + CheckStrArray[0].ToString());
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
    }
}