using FTD.BLL;
using FTD.Web.UI.aspx.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.erp
{
    public partial class OutRoomLeading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            string FileNameStr = System.Web.HttpContext.Current.Request.MapPath("../../UploadFile/") + FTD.Unit.PublicMethod.UploadFileIntoDir(this.FileUpload1, DateTime.Now.Ticks.ToString() + System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName));
            AsposeExcel exl = new AsposeExcel(FileNameStr);
            DataTable dt = exl.ExcelToDatatalbe();
            if (dt != null)
            {
                Random g = new Random();
                string rad = g.Next(10000).ToString();
                string _username = this.Session["UserName"].ToString();
                string _realname = this.Session["TrueName"].ToString();
                string _number = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + "" + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + "" + System.DateTime.Now.Millisecond.ToString() + "" + rad + "";
                string _title = "";
                string _shtime = "";
                string _StockPeoNum = "";//提货人
                string _StockPeoName = "";//提货人
                string _Remark = "";
                string _StreamNumber = "";
                string _Storeroom = ""; //来源仓库
                string _InSource = "销售出库";//入库来源

                string _Gname = "完成审核";
                string _companyAdd ="";
                string _CompanyName = "";
                string _Tel = "";//提货人电话
                string _ThPeople = "";//提货人
                string Grealname = "完成审核";
                string Gname = "完成审核";

                int n = 10000;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (dr[0] == null || dr[0].ToString() == "")
                    {
                        continue;
                    }
                    if (i < n)
                    {
                        switch (i)
                        {
                            case 1:
                                string strCompany = dr[0].ToString();
                                string[] strArray = strCompany.Trim().Split(' ');
                                strArray = strArray.Where(s => !string.IsNullOrEmpty(s)).ToArray();
                                int com_length = strArray.Length;
                                if (com_length > 2)
                                {
                                    _StockPeoName = strArray[0].Trim().Replace("仓管：", "").Replace("仓管:", "");
                                    _Storeroom = strArray[1].Trim().Replace("仓库号：", "").Replace("仓库号:", "").Replace("仓库：", "").Replace("仓库:", "");
                                    _shtime = strArray[com_length - 1].Replace('年', '-').Replace('月', '-').Replace('日', ' ').Trim();

                                }
                                else
                                {
                                    return; // 没有客户名称，直接返回 
                                }
                                break;
                            case 0:
                            case 2:
                                continue;
                            default:
                                if (dr[0].ToString().IndexOf("提货人:") >= 0 || dr[0].ToString().IndexOf("提货人：") >= 0)
                                {
                                    n = i;
                                    if (dr[1] !=null)
                                    _ThPeople = dr[1].ToString();
                                    if (dr[3] != null)
                                        _Tel = dr[3].ToString();
                                    
                                }
                                else
                                {
                                    SaveOut(dr, _number);
                                }
                                break;
                        }
                    }
                    else
                    {

                    }



                }

                SystemLog bll_log = new SystemLog();
                bll_log.Name = _realname + "新增[出库]";
                bll_log.MkName = "出库";
                bll_log.Username = _username;
                bll_log.Realname = _realname;
                bll_log.Nowtimes = DateTime.Now;
                bll_log.Add();

                OutRoomlog_lc bll_lc = new OutRoomlog_lc();
                bll_lc.title = _realname + "新增了出库[" + _title + "]";
                bll_lc.settime = DateTime.Now;
                bll_lc.KeyField = _number;
                bll_lc.Add();

                FTD.BLL.OutRoom _bll = new FTD.BLL.OutRoom();
                _bll.number = _number;
                _bll.title = _realname + "产品出库单" + _shtime;
                _bll.ThTime = Utils.ToDate(_shtime);
                _bll.Storeroom = _Storeroom;
                _bll.OutUse = _InSource;
                _bll.Remark = _Remark;
                _bll.State = "完成审批";
                _bll.Username = _username;
                _bll.Realname = _realname;
                _bll.Nowtimes = DateTime.Now;
                _bll.StreamNumber = _StreamNumber;
                _bll.StreamName = _StreamNumber;
                _bll.Gusername = _username;
                _bll.Grealname = _realname;
                _bll.Gname = _Gname;
                _bll.MyTimes = DateTime.Now;
                _bll.Username = _username;
                _bll.Realname = _realname;
                _bll.StreamName = "出库";
                _bll.Gusername = _username;
                _bll.Grealname = Grealname;
                _bll.ThPeople = _ThPeople;
                _bll.Tel = _Tel;
                
                int r = _bll.Add();


                this.Response.Write("<script language=javascript>alert('导入成功！');window.close()</script>");

            }
        }


        protected void SaveOut(DataRow dr, string _number)
        {
            string gname = dr[2].ToString();
            string _strItemid = _number ;
            string _username = this.Session["UserName"].ToString();
            string _realname = this.Session["TrueName"].ToString();

            OutRoomMx bll = new OutRoomMx();
            bll.GetModel(_number);
            bool isUpdate = false;
            if (bll.Keyfile != null && bll.Keyfile != "")
            {
                isUpdate = true;
            }
            FTD.BLL.GoodsData _bll = new FTD.BLL.GoodsData();
            _bll.GetModel(gname);
            string gnum = _bll.Number;

            bll.Keyfile = _number; //外键 销售单号
            bll.GoodsNumber = gnum; //产品编号
            bll.GoodsName = gname; //产品名称
            bll.CountUnit = "斤"; //产品单位
            bll.Model = "农产品"; //产品规格
            bll.StockPoint = Utils.GetDecimal(dr[3], 0); ;  //售卖件数
            bll.Username = _username;
            bll.Realname = _realname;
            bll.Nowtimes = System.DateTime.Now;
            if (!isUpdate)
            {
                bll.Add();
            }
            else
            {
                bll.Update();
            }



        }



       

    }
}