using FTD.Web.UI.aspx.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.HY
{
    public partial class HYLeading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            string FileNameStr = System.Web.HttpContext.Current.Request.MapPath("../../UploadFile/") +FTD.Unit.PublicMethod.UploadFileIntoDir(this.FileUpload1, DateTime.Now.Ticks.ToString() + System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName));
            AsposeExcel exl = new AsposeExcel(FileNameStr);
            DataTable dt =exl.ExcelToDatatalbe();
            if(dt !=null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    FTD.BLL.ERPNewHuiYuan Model = new FTD.BLL.ERPNewHuiYuan();
                    Model.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
                    Model.CreateTime = DateTime.Now;

                    if (dr[0] != null)
                    {
                        Model.Customer = dr[0].ToString();
                        if (Model.Customer == "会员名称" || Model.Customer == "客户名称")
                        {
                            continue;
                        }
                    }
                    else
                    {
                       
                    }
                    if (dr[1] != null)
                    {
                        Model.Tel = dr[1].ToString();
                    }
                    if (dr[2] != null)
                    {
                        Model.Address = dr[2].ToString();
                    }



                    if (dr[8] != null)
                    {
                        string SendRole = dr[8].ToString();
                       SendRole = SendRole.Replace("，", "|").Replace(",", "|").Replace("周一", "1").Replace("周二", "2").Replace("周三", "3").Replace("周四", "4").Replace("周五", "5").Replace("周六", "6").Replace("周日", "0");
                        Model.Sendrole = SendRole;

                        Model.SendTime = SendRole;
                    }
                    if (dr[4] != null && dr[4].ToString() != "")
                    {
                        Model.SendCounts = getInt(dr[4].ToString(),0);
                    }
                    if (dr[5] != null && dr[5].ToString() != "")
                    {
                        Model.RealSend = getInt(dr[5].ToString(), 0);
                    }
                    if (dr[7] != null && dr[7].ToString() != "")
                    {
                        //判断时间
                        if (IsDate(dr[7].ToString()))
                        {
                            Model.FirstTime = DateTime.Parse(dr[7].ToString());
                        }
                    }
                    if (dr[6] != null)
                    {
                        Model.SendType = dr[6].ToString();
                    }
                    if (dr[10] != null && dr[10].ToString() != "")
                    {
                        
                        string CStaus = dr[10].ToString();
                        switch(CStaus)
                        {
                            case "正在进行":
                                Model.CStaus = 0;
                                break;
                            case "冻结中":
                                Model.CStaus = -1;
                                break;
                            case "已经完成":
                            default:
                                Model.CStaus = 1;
                                break;
                        }

                       
                    }
                    if (dr[9] != null && dr[9].ToString() != "")
                    {
                        if (IsDate(dr[9].ToString()))
                        {
                            Model.EndTime = DateTime.Parse(dr[9].ToString());
                        }
                    }
                    if (dr[11] != null)
                    {
                        Model.OrderNumber = dr[11].ToString();
                    }
                    if (dr[3] != null)
                    {
                        Model.TaoCanNum = dr[3].ToString();
                    }
                    
                  
                    Model.Add();
                    //写系统日志
                    FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
                    MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
                    MyRiZhi.DoSomething = "用户添加会员信息(" + Model.Customer + ")";
                    MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
                    MyRiZhi.Add();
                    FTD.Unit.MessageBox.ShowAndRedirect(this, "会员信息添加成功！", "HuiYuan.aspx");
                }
            }
        }

        public bool IsDate(string strDate)
        {
            try
            {
                DateTime.Parse(strDate);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int getInt(string str, int _default)
        {
            int i;
            if (str != null && System.Text.RegularExpressions.Regex.IsMatch(str, @"^-?\d+$"))
                i = int.Parse(str);
            else
                i = _default;
            return i;  


        }

        public static bool IfOkFile(string DirName)
        {
            bool ReturnIF = true;
            try
            {
                string FileExd = DirName.Split('.')[1].ToString();
                string JKL = FTD.DBUnit.DbHelperSQL.GetSHSL("select FileType from ERPSystemSetting where FileType like '%|" + FileExd + "|%'");
                if (JKL.Length < 1)
                {
                    ReturnIF = false;
                }
            }
            catch
            {
                ReturnIF = false;
            }
            return ReturnIF;
        }

        public static string UploadFileIntoDir(FileUpload MyFile, string DirName)
        {
            if (IfOkFile(DirName) == true)
            {
                string ReturnStr = string.Empty;
                if (MyFile.FileContent.Length > 0)
                {
                    MyFile.SaveAs(System.Web.HttpContext.Current.Request.MapPath("../../UploadFile/") + DirName);


                    //将原文件名与现在文件名写入ERPSaveFileName表中
                    string NowName = DirName;
                    string OldName = MyFile.FileName;
                    string SqlTempStr = "insert into ERPSaveFileName(NowName,OldName) values ('" + NowName + "','" + OldName + "')";
                    FTD.DBUnit.DbHelperSQL.ExecuteSQL(SqlTempStr);


                    return DirName;
                }
                else
                {
                    return ReturnStr;
                }
            }
            else
            {
                if (MyFile.FileName.Length > 0)
                {
                    System.Web.HttpContext.Current.Response.Write("<script>alert('不允许上传此类型文件！');</script>");
                    return "";
                }
                else
                {
                    return "";
                }
            }
        }
    }
}