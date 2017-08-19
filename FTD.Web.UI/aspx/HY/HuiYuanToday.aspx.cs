using Aspose.Cells;
using FTD.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.HY
{
    public partial class HuiYuanToday : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FTD.Unit.PublicMethod.CheckSession();
                DataBindToGridview("");

                //设定按钮权限            
                iButton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|HY001A|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));
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
            var nowTime = DateTime.Now;
            string username = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            int nowWork = GetDayofWeek(nowTime.DayOfWeek.ToString());
            string strSql = "  UserName='" + username + "' and (Sendrole like '%" + nowWork + "%' or SendTime like '%" + nowWork + "%') and (RealSend < SendCounts ) and CStaus=0 and     [ERPNewHuiYuan].id not in (select HuiYuanNum from huiyuanLog where  DATEDIFF(day,CreateTime,GETDATE())=0  and UserName='" + username + "' )";
            ds = MyModel.GetList(strSql);

            if (ds != null && ds.Tables.Count > 0)
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
            string CheckStr = FTD.Unit.PublicMethod.CheckCbx(this.GVData, "CheckSelect", "LabVisible");
            string[] CheckStrArray = CheckStr.Split(',');
            FTD.BLL.ERPNewHuiYuan MyModel = new FTD.BLL.ERPNewHuiYuan();
            MyModel.GetModel(Utils.GetInt(CheckStrArray[0].ToString(), 0));

            if (MyModel != null)
            {
                huiyuanLog log = new huiyuanLog();
                log.CreateTime = DateTime.Now;
                log.HuiYuanName = MyModel.Customer;
                log.HuiYuanNum = MyModel.Id.ToString();
                log.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
                log.Add();
                MyModel.RealSend = Utils.GetInt(MyModel.RealSend, 0) + 1;
                MyModel.Update();

                DataBindToGridview("");
                //Response.Redirect("HuiYuanAdd.aspx");
            }
        }


        public int GetDayofWeek(string nowWork)
        {
            // Monday 周一 Tuesday 周二 Wednesday 周三 Thursday 周四 Friday 周五 Saturday 周六 Sunday 周日
            int i = 0;
            switch (nowWork.Trim())
            {
                case "sunday":
                case "Sunday":
                    i = 0;
                    break;
                case "monday":
                case "Monday":
                    i = 1;
                    break;
                case "tuesday":
                case "Tuesday":
                    i = 2;
                    break;
                case "wednesday":
                case "Wednesday":
                    i = 3;
                    break;
                case "thursday":
                case "Thursday":
                    i = 4;
                    break;
                case "friday":
                case "Friday":
                    i = 5;
                    break;
                case "saturday":
                case "Saturday":
                    i = 6;
                    break;
            }
            return i;
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

        protected void iButton5_Click1(object sender, EventArgs e)
        {
            FTD.BLL.ERPNewHuiYuan MyModel = new FTD.BLL.ERPNewHuiYuan();
            DataSet ds;
            var nowTime = DateTime.Now;
            string username = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            int nowWork = GetDayofWeek(nowTime.DayOfWeek.ToString());
            string strSql = "  UserName='" + username + "' and (Sendrole like '%" + nowWork + "%' or SendTime like '%" + nowWork + "%') and (RealSend < SendCounts ) and CStaus=0 and     [ERPNewHuiYuan].id  in (select HuiYuanNum from huiyuanLog where  DATEDIFF(day,CreateTime,GETDATE())=0  and UserName='" + username + "' )";
            ds = MyModel._GetList(strSql);

            if (ds != null && ds.Tables.Count > 0)
            {
                string _filename = FTD.Unit.PublicMethod.GetSessionValue("TrueName")+"_" + DateTime.Now.ToString("yyyy-MM-dd");
                string _path = Server.MapPath("../outexcel/");
                DataTable dt = ds.Tables[0];
                OutFileToDisk(dt, "今日销售", _path + _filename + @".xls");
                Response.Redirect("../outexcel/" + _filename + @".xls");

            }



          
        }



        /// <summary> 
        /// 导出数据到本地 
        /// </summary> 
        /// <param name="dt">要导出的数据</param> 
        /// <param name="tableName">表格标题</param> 
        /// <param name="path">保存路径</param> 
        public static void OutFileToDisk(DataTable dt, string tableName, string path)
        {


            Workbook workbook = new Workbook(); //工作簿 
            Worksheet sheet = workbook.Worksheets[0]; //工作表 
            Cells cells = sheet.Cells;//单元格 

            //为标题设置样式     
   
            

            //样式2 
            Aspose.Cells.Style style2 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style2.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style2.Font.Name = "宋体";//文字字体 
            style2.Font.Size = 14;//文字大小 
            style2.Font.IsBold = true;//粗体 
            style2.IsTextWrapped = true;//单元格内容自动换行 
            style2.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style2.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            //样式3 
            Aspose.Cells.Style style3 = workbook.Styles[workbook.Styles.Add()];//新增样式 
            style3.HorizontalAlignment = TextAlignmentType.Center;//文字居中 
            style3.Font.Name = "宋体";//文字字体 
            style3.Font.Size = 12;//文字大小 
            style3.Borders[BorderType.LeftBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.RightBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.TopBorder].LineStyle = CellBorderType.Thin;
            style3.Borders[BorderType.BottomBorder].LineStyle = CellBorderType.Thin;

            int Colnum = dt.Columns.Count;//表格列数 
            int Rownum = dt.Rows.Count;//表格行数 

            //生成行1 标题行    
            //cells.Merge(0, 0, 1, Colnum);//合并单元格 
            ////cells[0, 0].PutValue(tableName);//填写内容 
            //cells[0, 0].SetStyle(styleTitle);
            cells.SetRowHeight(0, 25);
            cells.SetColumnWidth(0, 30);
            cells.SetColumnWidth(1, 50);
            cells.SetColumnWidth(2, 80);
            //生成行2 列名行 
            for (int i = 0; i < Colnum; i++)
            {
                string _colunmName = dt.Columns[i].ColumnName;
                 switch(_colunmName.ToLower())
                 {
                     case "customer":
                         _colunmName = "客户名称";
                         break;
                     case "tel":
                         _colunmName = "联系电话";
                         break;
                     case "address":
                         _colunmName = "联系地址";
                         break;
                 }
                 cells[0, i].PutValue(_colunmName);
                cells[0, i].SetStyle(style2);
                //cells.SetRowHeight(0, 25);
            }

            //生成数据行 
            for (int i = 0; i < Rownum; i++)
            {
                for (int k = 0; k < Colnum; k++)
                {
                    cells[1 + i, k].PutValue(dt.Rows[i][k].ToString());
                    cells[1 + i, k].SetStyle(style3);
                }
                cells.SetRowHeight(1 + i, 24);
            }

            workbook.Save(path);
        } 
  



    }
}