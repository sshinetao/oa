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
    public partial class StockOrderLeading : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string Gusername, Grealname, Gname;
        protected void iButton1_Click(object sender, EventArgs e)
        {

            string FileNameStr = System.Web.HttpContext.Current.Request.MapPath("../../UploadFile/") + FTD.Unit.PublicMethod.UploadFileIntoDir(this.FileUpload1, DateTime.Now.Ticks.ToString() + System.IO.Path.GetExtension(FileUpload1.PostedFile.FileName));
            AsposeExcel exl = new AsposeExcel(FileNameStr);
            DataTable dt = exl.ExcelToDatatalbe();
            Gusername = "完成审核";
            Grealname = "完成审核";
            Gname = "完成审核";
            string _username = this.Session["UserName"].ToString();
            string _realname = this.Session["TrueName"].ToString();
            if (dt != null)
            {


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    string gname = dr[0].ToString();

                    SystemLog log = new SystemLog();
                    log.Name = "新增[采购入库]";
                    log.MkName = "采购入库";
                    log.Username = _username;
                    log.Realname = _realname;
                    log.Nowtimes = System.DateTime.Now;
                    log.Add();

                    Random g = new Random();
                    string rad = g.Next(10000).ToString();
                    string _number = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString() + "" + System.DateTime.Now.Day.ToString() + "" + System.DateTime.Now.Hour.ToString() + "" + System.DateTime.Now.Minute.ToString() + "" + System.DateTime.Now.Second.ToString() + "" + System.DateTime.Now.Millisecond.ToString() + "" + rad + "";

                    StockIncomelog_lc log_lc = new StockIncomelog_lc();
                    log_lc.KeyField = _number;
                    log_lc.settime = DateTime.Now;
                    log_lc.title = this.Session["TrueName"] + "新增了采购入库";
                    log_lc.Add();


                    	

                    StockOrder income = new StockOrder();
                    income.number = _number;
                    income.title = "采购" + gname; //产品入库
                    income.ShTime = Utils.ToDate(dr[1].ToString()); //购买时间
                    income.StockPeoNum = dr[2].ToString(); //采购人员
                    income.StockPeoName = dr[2].ToString(); // 采购人员
                    income.Storeroom = dr[7].ToString();  //仓库
                    income.CompanyNumber = "";
                    income.CompanyName = dr[8].ToString(); //供应商名称
                    income.CompanyAdd = dr[9].ToString(); //供应商地址
                  
                    income.State = "";
                    income.Username = _username;
                    income.Realname = _realname;
                    
                    income.Nowtimes = DateTime.Now;
                    income.StreamNumber = "";
                    income.StreamName = "";
                    income.Gusername = Gusername;
                    income.Grealname = Grealname;
                    income.Gname = Gname;
                    income.MyTimes = DateTime.Now;
                    income.Add();   //入库单

                    SystemLog log2 = new SystemLog();
                    log2.Name = "新增[采购订单明细]','采购订单";
                    log2.MkName = "采购订单";
                    log2.Realname = _realname;
                    log2.Username = _username;
                    log2.Nowtimes = DateTime.Now;
                    log2.Add();


                    FTD.BLL.GoodsData _bll = new FTD.BLL.GoodsData();
                    _bll.GetModel(gname);

                    string gnum = _bll.Number;
                    if (gnum == null || gnum == "") // 没有产品,将该产品加入产品库中
                    {
                        gnum = SaveProduct(gname);
                    }

                    StockOrderMx mx = new StockOrderMx();
                    mx.Keyfile = _number;
                    mx.GoodsNumber = gnum;
                    mx.GoodsName = gname;
                    mx.CountUnit = dr[3].ToString();
                    mx.Model = dr[4].ToString();
                    mx.StockPoint = Utils.GetDecimal(dr[5], 0); ;  //售卖件数
                    mx.Username = _username;
                    mx.Realname = _realname;
                    mx.Nowtimes = DateTime.Now;
                    mx.SingleMoney = Utils.GetDecimal(dr[6], 0); ; // 单价
                    mx.Allmoney = Utils.GetDecimal(dr[5], 0) * Utils.GetDecimal(dr[6], 0); ; // 总价
                    mx.Add();

                }

             

                this.Response.Write("<script language=javascript>alert('提交成功！');window.location.href='StockIncome.aspx'</script>");
            }







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