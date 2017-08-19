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
    public partial class IncomeRoomLeading : System.Web.UI.Page
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
                string _shtime ="";
                string _StockPeoNum = "";
                string _StockPeoName ="";
                string _Remark = "";
                string _StreamNumber = "";
                string _Storeroom = ""; //来源仓库
                string _InSource ="";//入库来源

                string _Gname = "待审核";
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
                                    _Storeroom = strArray[1].Trim().Replace("仓库号：", "").Replace("仓库号:", "");
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
                                if (dr[0].ToString().IndexOf("收货人:") >= 0 || dr[0].ToString().IndexOf("收货人：") >= 0)
                                {
                                    n = i;
                                    
                                }
                                else
                                {
                                    _InSource = dr[1].ToString();
                                    _StreamNumber = "";
                                    SaveIncome(dr, _number);
                                }
                                break;
                        }
                    }
                    else
                    {

                    }



                }




                SystemLog bll_log = new SystemLog();
                bll_log.Name = _realname + "新增[入库]";
                bll_log.MkName = "入库";
                bll_log.Username = _username;
                bll_log.Realname = _realname;
                bll_log.Nowtimes = DateTime.Now;
                bll_log.Add();


                IncomeRoomlog_lc bll_lc = new IncomeRoomlog_lc();
                bll_lc.title = _realname + "新增了入库[" + _title + "]";
                bll_lc.settime = DateTime.Now;
                bll_lc.KeyField = _number;
                bll_lc.Add();


                FTD.BLL.IncomeRoom _bll = new FTD.BLL.IncomeRoom();
                _bll.number = _number;
                _bll.title = _realname + "产品入库单" + _shtime;
                _bll.ShTime = Utils.ToDate(_shtime);
                _bll.StockPeoNum = _StockPeoNum;
                _bll.StockPeoName = _StockPeoName;
                _bll.Storeroom = _Storeroom;
                _bll.InSource = _InSource;
                _bll.Remark = _Remark;
                _bll.State = "待审核";
                _bll.Username = _username;
                _bll.Realname = _realname;
                _bll.Nowtimes = DateTime.Now;
                _bll.StreamNumber = _StreamNumber;
                _bll.StreamName = _StreamNumber;   //重新定义成村
                _bll.Gusername = _username;
                _bll.Grealname = _realname;
                _bll.Gname = _Gname;
                _bll.MyTimes = DateTime.Now;
                int r = _bll.Add();
                this.Response.Write("<script language=javascript>alert('导入成功！');window.close()</script>");

            }
        }

        public void SaveIncome(DataRow dr, string _number)
        {
            string gname = dr[3].ToString();
            string _strItemid = _number;

            FTD.BLL.GoodsData _bll = new FTD.BLL.GoodsData();
            _bll.GetModel(gname);

            string gnum = _bll.Number;
            if (gnum == null || gnum == "") // 没有产品,将该产品加入产品库中
            {
                gnum = SaveProduct(gname);
            }

            string _username = this.Session["UserName"].ToString();
            string _realname = this.Session["TrueName"].ToString();

            IncomeRoomMx bll = new IncomeRoomMx();
            bll.Keyfile = _number;
            bll.GoodsNumber = gnum;
            bll.GoodsName = gname;
            bll.CountUnit = "斤";
            bll.Model = dr[2].ToString();  //来源
            bll.StockPoint = Utils.GetDecimal(dr[4], 0); ;  //售卖件数
            bll.Username = _username;
            bll.Realname = _realname;
            bll.Nowtimes = DateTime.Now;
            bll.Add();
        }

        protected string SaveProduct(string gname)
        {

            Random g = new Random();
            string rad = g.Next(10000).ToString();

            string _username = this.Session["UserName"].ToString();
            string _realname = this.Session["TrueName"].ToString();
            SystemLog _bll = new SystemLog();
            _bll.Name = "'新增[货品资料]-" + gname;
            _bll.Nowtimes = DateTime.Now;
            _bll.Realname = _realname;
            _bll.MkName = "货品资料";
            _bll.Username = _username;
            _bll.Add();
            FTD.BLL.GoodsData bll = new FTD.BLL.GoodsData();
            bll.Number = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString();
            bll.GoodsName = gname;

            bll.CountUnit = "斤";
            bll.Model = "农产品";
            bll.Type = "土特产";
            bll.Code = "0";
            bll.Color = "0";
            bll.Area = "0";
            bll.Cubage = "0";
            bll.Weight = "0";
            bll.Amountup = 0;
            bll.Amountdown = 0;
            bll.Powermoney = 0;
            bll.Powermoney = 0;
            bll.Stockmoney = 0;
            bll.Sellmoney1 = 0;
            bll.Sellmoney2 = 0;
            bll.Sellmoney3 = 0;
            bll.Sellmoney4 = 0;
            bll.Remark = "0";
            bll.State = "启用";
            bll.Add();
            return bll.Number;
        }
    }
}