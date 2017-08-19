using FTD.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTD.Web.UI.aspx.ashx
{
    /// <summary>
    /// plan 的摘要说明
    /// </summary>
    public class plan : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";  string _type = context.Request.QueryString["type"];
            string _ReturnJson = "";
            switch (_type)
            {
                case "save":
                    _ReturnJson = SavePlan(context);
                    break;
                case "save2":
                    SavePlanMx(context);
                    break;
            }
            context.Response.Write(_ReturnJson.ToString());
            context.Response.End();
        }

        protected string SavePlan(HttpContext context)
        {
            string _resault2 = "";
            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];
            string _number = context.Request.Form["number"];
            string _title = context.Request.Form["title"];
            string _StartTime = context.Request.Form["st"];
            string _EndTime = context.Request.Form["et"];
            string _unit = context.Request.Form["unit"];
            string _companyAdd = context.Request.Form["CompanyAdd"];
         
            SystemLog _bll = new SystemLog();
            _bll.Name = "新增[生产计划]";
            _bll.MkName = "生产计划";
            _bll.Username = _username;
            _bll.Realname = _realname;
            _bll.Nowtimes = DateTime.Now;
            _bll.Add();
            StockPlan bll = new StockPlan();
            bll.number = _number;
            bll.tilte = _title;
            bll.StartTime = Utils.ToDate(_StartTime);
            bll.EndTime = Utils.ToDate(_EndTime);
            bll.Type = "正在执行";
            bll.ALLMoney = 0;
            bll.Unit = _unit;
            bll.Username = _username;
            bll.Realname = _realname;
            bll.Nowtimes = DateTime.Now;
            bll.Ifopen = "否";
            int i = bll.Add();
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

        protected void SavePlanMx(HttpContext context)
        {

            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];
      
            string _companyAdd = context.Request.Form["CompanyAdd"]; 
            string gname = context.Request.Form["gname"];
            string _itemid = context.Request.Form["itemid"];
            string _number = context.Request.Form["number"];
            string _model = context.Request.Form["model"];

            SystemLog _bll = new SystemLog();
            _bll.Name = "新增[生产计划]";
            _bll.MkName = "生产计划";
            _bll.Username = _username;
            _bll.Realname = _realname;
            _bll.Nowtimes = DateTime.Now;
            _bll.Add();
            FTD.BLL.GoodsData _bll2 = new FTD.BLL.GoodsData();
            _bll2.GetModel(gname);

            string gnum = _bll2.Number;
            if (gnum == null || gnum == "") // 没有产品,将该产品加入产品库中
            {
                gnum = SaveProduct(context);
            }
            StockPlanMx model = new StockPlanMx();
            model.Keyfile = _number;
            model.GoodsNumber = gnum;
            model.GoodsName = gname;
            model.CountUnit = "";
            model.Model = _model;
            model.StockPoint = 0;
            model.SingleMoney = 0;
            model.Allmoney = 0;
            model.Stocktype = "";
            model.StockPeoNum = _username;
            model.StockPeoName = _realname;
            model.CompanyNumber = "";
            model.CompanyName = "";
            model.CompanyAdd = _companyAdd;
            model.JyOrderTime = DateTime.Now;
            model.JyToTime = DateTime.Now;
            model.TxTime = DateTime.Now;
            model.Username = _username;
            model.Realname = _realname;
            model.Nowtimes = DateTime.Now;
            model.Ifopen = "0";

            model.Add();
           



        }

        protected string SaveProduct(HttpContext context)
        {

            Random g = new Random();
            string rad = g.Next(10000).ToString();

            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];
            string gname = context.Request.Form["gname"];
            SystemLog _bll = new SystemLog();
            _bll.Name = "'新增[货品资料]-" + gname;
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
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}