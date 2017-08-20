using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace FTD.Web.UI.aspx.TelFile
{
    public partial class gongwenhegao : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Unit.PublicMethod.CheckSession();
                DataBindToGridview("");
 
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
            Unit.PublicMethod.GridViewRowDataBound(e);
        }

        public void DataBindToGridview(string IDList)
        {
            BLL.GWGL MyModel = new BLL.GWGL();
            DataSet ds;            
            string sessionUname = Unit.PublicMethod.GetSessionValue("UserID");
            BLL.ERPUser UserModel = new BLL.ERPUser();
            DataSet dst =  UserModel.GetList("id="+ sessionUname);
            string UserRole = "";
            if (dst.Tables[0].Rows.Count > 0)
            {
                UserRole = dst.Tables[0].Rows[0]["JiaoSe"].ToString();
            }
                

            string _strsql = " zhuangtai='已审批'";
            if (UserRole.IndexOf("管理员") != -1)
            {
                _strsql = " 1=1 ";
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
    }
}