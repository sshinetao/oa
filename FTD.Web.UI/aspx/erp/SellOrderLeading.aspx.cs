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
    public partial class SellOrderLeading : System.Web.UI.Page
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
                string _number = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + "" + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + "" + System.DateTime.Now.Millisecond.ToString() + "" + rad + "";  //订单编号
                string _strItemid = _number;
                string _username = this.Session["UserName"].ToString();
                string _realname = this.Session["TrueName"].ToString();
                string Grealname = "等待审核";
                string Gname = "等待审核";
                string _Company = "no number";
                string _shtime = "";  //发货时间
                string _companyAdd = "";//收货地址
                string _CompanyName = ""; //单位名称
                string _Tel = "";//联系电话
                string _StockPeoNum = "";  //仓库编号
                string _StockPeoName = "";
                string _Discount = ""; // 折扣
                string _AllMoney = "";//总价
                string _Remark = "";//  备注 context.Request.Form["Remark"];
                string _StreamNumber = "";// 流程编号 context.Request.Form["StreamNumber"];
                int n=10000;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if(dr[0] ==null || dr[0].ToString()=="")
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
                                int com_length = strArray.Length;
                                if (com_length > 1)
                                {
                                    _CompanyName = strArray[0];
                                    _shtime = strArray[com_length - 1].Replace('年', '-').Replace('月', '-').Replace('日', '-');

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
                                if (dr[0].ToString().IndexOf("合计金额") >= 0)
                                {
                                    n = i;
                                    _AllMoney = dr[5].ToString();
                                }
                                else
                                {
                                    SaveProduct(dr, _number);
                                }
                                break;
                        }
                    }
                    else
                    {

                    }



                }
                #region 结束
                SystemLog bll_systemLog = new SystemLog();
                bll_systemLog.Name = "新增[销售订单明细]";
                bll_systemLog.MkName = "销售订单";
                bll_systemLog.Username = _username;
                bll_systemLog.Realname = _realname;
                bll_systemLog.Nowtimes = System.DateTime.Now;
                bll_systemLog.Add();
                SellOrderlog_lc bll_sellorderlog_lc = new SellOrderlog_lc();
                bll_sellorderlog_lc.KeyField = _number;
                bll_sellorderlog_lc.settime = DateTime.Now;
                bll_sellorderlog_lc.title = _realname + "新增了销售订单[" + _realname + "的普通客户订单]'";
                bll_sellorderlog_lc.Add();
                FTD.BLL.SellOrder bll_sellorder_pt = new FTD.BLL.SellOrder();
                bll_sellorder_pt.title = _realname + "的普通客户订单"  + "合同";
                bll_sellorder_pt.Type = "普通发票";
                bll_sellorder_pt.number = _number;
                bll_sellorder_pt.InvoiceType = "000";
                bll_sellorder_pt.QdTime = DateTime.Now;
                bll_sellorder_pt.OrderAdd = "0";
                bll_sellorder_pt.LxAdd = "0";
                bll_sellorder_pt.Storeroom = "0";
                bll_sellorder_pt.ShTime = _shtime;
                bll_sellorder_pt.CompanyNumber = _Company;
                bll_sellorder_pt.CompanyAdd = _companyAdd;
                bll_sellorder_pt.CompanyName = _CompanyName;
                bll_sellorder_pt.BankNumber = "0";
                bll_sellorder_pt.TaxNumber = "0";
                bll_sellorder_pt.Bank = "0";
                bll_sellorder_pt.Tel = _Tel;
                bll_sellorder_pt.LxPeople = "0";
                bll_sellorder_pt.DlPeople = "0";
                bll_sellorder_pt.Unit = "普通";
                bll_sellorder_pt.StockPeoNum = _username;
                bll_sellorder_pt.StockPeoName = _realname;
                bll_sellorder_pt.YxStarttime = DateTime.Now;
                bll_sellorder_pt.YxEndtime = DateTime.Now;
                bll_sellorder_pt.Discount = Utils.GetDecimal(_Discount, 0); ;
                bll_sellorder_pt.AllMoney = Utils.GetDecimal(_AllMoney, 0);
                bll_sellorder_pt.DisMoney = Utils.GetDecimal(_Discount, 0);
                bll_sellorder_pt.YjMoney = Utils.GetDecimal(_AllMoney, 0);
                bll_sellorder_pt.Remark = _Remark;
                bll_sellorder_pt.State = "等待审核";
                bll_sellorder_pt.Username = _username;
                bll_sellorder_pt.Realname = _realname;
                bll_sellorder_pt.Nowtimes = DateTime.Now;
                bll_sellorder_pt.StreamNumber = _StreamNumber;
                bll_sellorder_pt.StreamName = "销售订单";
                bll_sellorder_pt.Gusername = Grealname;
                bll_sellorder_pt.Gname = Gname;
                bll_sellorder_pt.MyTimes = DateTime.Now.ToString();// this.Session["MyTimes"].ToString();
                bll_sellorder_pt.Ifopen = "是";
                int r = bll_sellorder_pt.Add();
                #endregion 结束

                this.Response.Write("<script language=javascript>alert('导入成功！');window.close()</script>");
            }
        }




        protected void SaveProduct(DataRow dr, string _number)
        {
      
            string gname = dr[1].ToString();  // 产品名称
            string _itemid = dr[0].ToString(); // 序号

         

           

            //根据产品获取产品信息
            FTD.BLL.GoodsData _bll = new FTD.BLL.GoodsData();
            _bll.GetModel(gname);
            string gnum = _bll.Number;
            if (gnum == null || gnum == "") // 没有产品,将该产品加入产品库中
            {
                gnum = SaveProductInfo(gname);
            }

            string _username = this.Session["UserName"].ToString();
            string _realname = this.Session["TrueName"].ToString();
            SellOrderMx bll = new SellOrderMx();
            
                SystemLog bll_systemLog = new SystemLog();
                bll_systemLog.Name = "新增[销售订单明细]";
                bll_systemLog.MkName = "销售订单";
                bll_systemLog.Username = _username;
                bll_systemLog.Realname = _realname;
                bll_systemLog.Nowtimes = System.DateTime.Now;
                bll_systemLog.Add();
            

            bll.Keyfile = _number; //外键 销售单号
            bll.GoodsNumber = gnum; //产品编号
            bll.GoodsName = gname; //产品名称
            bll.CountUnit = "份"; //产品单位
            bll.Model = "农产品"; //产品规格
            bll.StockPoint = Utils.GetDecimal(dr[2], 0); ;  //售卖件数
            bll.SingleMoney = Utils.GetDecimal(dr[3], 0);   //单价
            bll.Allmoney = Utils.GetDecimal(dr[5], 0); //总价
            bll.Username = _username;
            bll.Realname = _realname;
            bll.Nowtimes = System.DateTime.Now;
            bll.YfMoney = Utils.GetDecimal(dr[4], 0);   //超市进货价
            bll.ItemId = _number;
           
                bll.Add();
           
        }


        protected string SaveProductInfo(string gname)
        {

            Random g = new Random();
            string rad = g.Next(10000).ToString();
            string _username = this.Session["UserName"].ToString();
            string _realname = this.Session["TrueName"].ToString();
            FTD.BLL.SystemLog _bll = new FTD.BLL.SystemLog();
            _bll.Name = "'新增[货品资料]-" + gname;
            _bll.Nowtimes = DateTime.Now;
            _bll.Realname = _realname;
            _bll.MkName = "货品资料";
            _bll.Username = _username;
            _bll.Add();
            FTD.BLL.GoodsData bll = new FTD.BLL.GoodsData();
            bll.Number = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString();
            bll.GoodsName = gname;

            bll.CountUnit = "份";
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