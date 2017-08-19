using FTD.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTD.Web.UI.aspx.ashx
{
    /// <summary>
    /// 仓库操作
    /// </summary>
    public class getIncome : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string _type = context.Request.QueryString["type"];
            string _ReturnJson = "";
            switch (_type)
            {
              
                case "order": // 获取一条产品数据
                    //_ReturnJson = SaveSellOrder(context);
                    break;
                case "out": //获取卖出的产品
                    SaveOut(context);
                   // _ReturnJson = GetSellProductList(context);
                    break;
                case "order3":
                    _ReturnJson = SaveOutCome(context);
                    break;
                case "save": //获取卖出的产品
                    SaveIncome(context);
                    break;
                case "order2": //获取卖出的产品
                  _ReturnJson = SaveInCome(context); //SaveSellOrder2(context);
                    break;
            }
            context.Response.Write(_ReturnJson.ToString());
            context.Response.End();
        }

        public void SaveIncome(HttpContext context)
        {
            string gname = context.Request.Form["gname"];
            string _itemid = context.Request.Form["itemid"];
            string _number = context.Request.Form["number"];
            string _model = context.Request.Form["model2"];
            string _strItemid = _number + _itemid;
            string _zhongzhihu = context.Request.Form["zhongzhihu"]+"";
            string _zhuangtai = context.Request.Form["zhuangtai"] + "";
            string _beizhu = context.Request.Form["beizhu"] + "";
             FTD.BLL.GoodsData _bll = new FTD.BLL.GoodsData();
            _bll.GetModel(gname);

            string gnum = _bll.Number;
            if (gnum == null || gnum == "") // 没有产品,将该产品加入产品库中
            {
               gnum = SaveProduct(context);
            }



             string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];

            IncomeRoomMx bll = new IncomeRoomMx();
            bll.Keyfile = _number;
            bll.GoodsNumber = gnum;
            bll.GoodsName = gname;
            bll.CountUnit = context.Request.Form["countunit"];
            bll.Model = _model;  //来源
            bll.StockPoint = Utils.GetDecimal(context.Request.Form["unitcost"], 0); ;  //售卖件数
            bll.Allmoney = Utils.GetDecimal(context.Request.Form["Allmoney"], 0); ;  //售卖件数
            bll.Singlemoney = Utils.GetDecimal(context.Request.Form["Singlemoney"], 0); ;  //售卖件数
            bll.Username = _username;
            bll.Realname = _realname;
            bll.Nowtimes = DateTime.Now;
            bll.Zhongzhihu = _zhongzhihu;
            bll.Zhuangtai = _zhuangtai;
            bll.Beizhu = _beizhu;
            bll.Add();
        }

        protected string SaveProduct(HttpContext context)
        {

            Random g  = new Random();
			string rad=g.Next(10000).ToString();

            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"]; 
            string gname = context.Request.Form["gname"];
            SystemLog _bll = new SystemLog();
            _bll.Name = "'新增[货品资料]-"+gname;
            _bll.Nowtimes = DateTime.Now;
            _bll.Realname = _realname;
            _bll.MkName = "货品资料";
            _bll.Username = _username;
            _bll.Add();
            GoodsData bll = new GoodsData();
            bll.Number = "" + System.DateTime.Now.Year.ToString() + "" + System.DateTime.Now.Month.ToString();
            bll.GoodsName = gname;
            
            bll.CountUnit = context.Request.Form["countunit"];
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


        protected string SaveInCome(HttpContext context)
        {

            string _resault2 = @"{""status"":false}";
            string _username = context.Request.Form["uname"] + "";
            string _realname = context.Request.Form["rname"] + "";
            string _number = context.Request.Form["number"] + "";
            string _title = context.Request.Form["title"] + "";
            string _rukuleixing = context.Request.Form["rukuleixing"] + "" ;
            string _shtime = context.Request.Form["ShTime"];
            string _StockPeoNum = context.Request.Form["StockPeoNum"];
            string _StockPeoName = context.Request.Form["StockPeoName"];
            string _Remark = context.Request.Form["Remark"];
            string _StreamNumber = context.Request.Form["StreamNumber"];
            string _Storeroom = context.Request.Form["Storeroom"]; //来源仓库
            string _InSource = context.Request.Form["InSource"];//采购员
            string _zhongzhihu = context.Request.Form["zhongzhihu"] + "";
            string _zhuangtai = context.Request.Form["zhuangtai"] + "";
            string _beizhu = context.Request.Form["beizhu"] + "";
            
            string _Gname = "待审核";
           
            SystemLog bll_log = new SystemLog();
            bll_log.Name = _realname +"新增[入库]";
            bll_log.MkName = "入库";
            bll_log.Username = _username;
            bll_log.Realname = _realname;
            bll_log.Nowtimes = DateTime.Now;

            bll_log.Add();
           

            IncomeRoomlog_lc bll_lc = new IncomeRoomlog_lc();
            bll_lc.title =_title;
            bll_lc.settime = DateTime.Now;
            bll_lc.KeyField = _number;
            bll_lc.Add();

            
            IncomeRoom _bll = new IncomeRoom();
            _bll.number = _number;
            _bll.title = _title;
            _bll.ShTime = Utils.ToDate(_shtime);
            _bll.StockPeoNum = _StockPeoNum;
            _bll.StockPeoName = _StockPeoName;
            _bll.Storeroom = _Storeroom;
            _bll.InSource = _InSource;
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
            _bll.Rukuleixing = _rukuleixing;
            _bll.MyTimes = DateTime.Now;
   
            int i = _bll.Add();
           

            if (i > 0)
            {
                _resault2 = @"{""status"":true}";
            }
            else
            {
                _resault2 = @"{""status"":false}";
            }

            return _resault2;

        }



        protected void SaveOut(HttpContext context)
        {
           string gname = context.Request.Form["gname"];
            string _itemid = context.Request.Form["itemid"];
            string _number = context.Request.Form["number"];
            string _strItemid = _number + _itemid;
            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];

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
            bll.CountUnit = context.Request.Form["countunit"]; //产品单位
            bll.Model = "农产品"; //产品规格
            bll.StockPoint = Utils.GetDecimal(context.Request.Form["unitcost"], 0); ;  //售卖件数
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



        protected string SaveOutCome(HttpContext context)
        {
            string _resault2 = @"{""status"":false}";
            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];
            string _number = context.Request.Form["number"];
            string _title = "";
            string _shtime = context.Request.Form["ShTime"];
            string _StockPeoNum = context.Request.Form["StockPeoNum"];
            string _StockPeoName = context.Request.Form["StockPeoName"];
            string _Remark = context.Request.Form["Remark"];
            string _StreamNumber = context.Request.Form["StreamNumber"];
            string _Storeroom = context.Request.Form["Storeroom"]; //来源仓库
            string _InSource = context.Request.Form["InSource"];//入库来源
            string _Gname = "完成审核";
            string _companyAdd = context.Request.Form["CompanyAdd"];
            string _CompanyName = context.Request.Form["CompanyName"];
            string _Tel = context.Request.Form["Tel"];
            string _ThPeople = context.Request.Form["ThPeople"]; 
            string Grealname = "完成审核";
            string Gname = "完成审核";

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

            OutRoom _bll = new OutRoom();
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
            int i = _bll.Add();


            if (i > 0)
            {
                _resault2 = @"{""status"":true}";
            }
            else
            {
                _resault2 = @"{""status"":false}";
            }



         



            return _resault2;



        }



        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}