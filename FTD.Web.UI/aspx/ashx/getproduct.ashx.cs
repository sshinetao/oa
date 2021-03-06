﻿using FTD.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace FTD.Web.UI.aspx.ashx
{
    /// <summary>
    /// getproduct 的摘要说明
    /// </summary>
    public class getproduct : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string _type = context.Request.QueryString["type"];
            string _ReturnJson = "";
            switch (_type)
            {
                case "list": // 获取产品列表
                    _ReturnJson = GetProductList(context);
                    break;
                case "ck": // 获取产品列表
                    _ReturnJson = GetProductCKList(context);
                    break;
                case "order": // 获取一条产品数据
                    _ReturnJson = SaveSellOrder(context);
                    break;
                case "sell": //获取卖出的产品
                    _ReturnJson = GetSellProductList(context);
                    break;
                case "del": //删除卖出的产品
                    DelSellProduct(context);
                    break;
                case "save": //获取卖出的产品
                    SaveSellOrderMx(context);
                    break;
                case "order2": //获取卖出的产品
                    _ReturnJson = SaveSellOrder2(context);
                    break;
            }
            context.Response.Write(_ReturnJson.ToString());
            context.Response.End();


        }

        protected string GetProductList(HttpContext context)
        {
            string _ProJson = "";
            FTD.BLL.GoodsData bll = new FTD.BLL.GoodsData();
            DataSet ds = bll.GetList("");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];

                StringBuilder sb = new StringBuilder(@"{""total"":28,""rows"":[ ");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (i > 0)
                    { sb.Append(","); }
                    sb.Append("{");
                    sb.AppendFormat(@"""productid"":""{0}""", dr["Number"]);
                    sb.AppendFormat(@",""productname"":""{0}""", dr["GoodsName"]);
                    sb.AppendFormat(@",""countunit"":""{0}""", dr["CountUnit"]);
                    sb.Append(@",""unitcost"":""0""");
                    sb.Append(@",""price"":""0""");
                    sb.Append(@",""allprice"":""0""");
                    sb.AppendFormat(@",""itemid"":""EST-{0}""", i);


                    sb.Append("}");

                }
                sb.Append("]}");
                _ProJson = sb.ToString();
            }

            return _ProJson;
        }
        protected string GetProductCKList(HttpContext context)
        {
            string _ProJson = "";
            FTD.BLL.GoodsData bll = new FTD.BLL.GoodsData();
            DataSet ds = bll.GetList("");
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];

                StringBuilder sb = new StringBuilder(@"[ ");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (i > 0)
                    { sb.Append(","); }
                    sb.Append("{");
                    sb.AppendFormat(@"""productid"":""{0}""", dr["Number"]);
                    sb.AppendFormat(@",""productname"":""{0}""", dr["GoodsName"]);
                    sb.AppendFormat(@",""countunit"":""{0}""", dr["CountUnit"]);
                    sb.Append(@",""unitcost"":""0""");
                    sb.Append(@",""price"":""0""");
                    sb.Append(@",""allprice"":""0""");
                    sb.AppendFormat(@",""itemid"":""EST-{0}""", i);


                    sb.Append("}");

                }
                sb.Append("]");
                _ProJson = sb.ToString();
            }

            return _ProJson;
        }

        protected string GetSellProductList(HttpContext context)
        {
            string _ProJson = "";

            string _itemid = context.Request.Form["itemid"];
            string _number = context.Request.Form["number"];
            if(_number==null || _number=="")
            {
                return _ProJson;
            }
            string _strItemid = _number + _itemid;
            string strSql = string.Format(@"Keyfile='{0}'", _number);
            SellOrderMx bll = new SellOrderMx();
            DataSet ds = bll.GetList(strSql);
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];

                StringBuilder sb = new StringBuilder(@"{""total"":28,""rows"":[ ");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    if (i > 0)
                    { sb.Append(","); }
                    sb.Append("{");
                    sb.AppendFormat(@"""productid"":""{0}""", dr["GoodsNumber"]);
                    sb.AppendFormat(@",""productname"":""{0}""", dr["GoodsName"]);
                    sb.AppendFormat(@",""countunit"":""{0}""", dr["CountUnit"]);
                    sb.Append(@",""unitcost"":""0""");
                    sb.Append(@",""price"":""0""");
                    sb.Append(@",""allprice"":""0""");
                    sb.AppendFormat(@",""itemid"":""{0}""", dr["ItemId"]);


                    sb.Append("}");

                }
                sb.Append("]}");
                _ProJson = sb.ToString();
            }


            return _ProJson;
        }
      
        protected void  DelSellProduct(HttpContext context)
        {
            string _itemid = context.Request.Form["itemid"];
            string _number = context.Request.Form["number"];
            string _strItemid = _number + _itemid;
            string strSql = string.Format(@"Keyfile='{0}'", _number);
            SellOrderMx bll = new SellOrderMx();
            bll.Delete(strSql);
        }

        protected void SaveSellOrderMx(HttpContext context)
        {
            string gname = context.Request.Form["gname"];
            string _itemid = context.Request.Form["itemid"];
            string _number = context.Request.Form["number"];
            string _strItemid = _number + _itemid;
            SellOrderMx bll = new SellOrderMx();
            bll.GetModel(_strItemid);
            bool isUpdate = false;
            if( bll.ItemId!=null && bll.ItemId!="")
            {
                isUpdate = true;
            }

            //根据产品获取产品信息
            FTD.BLL.GoodsData _bll = new FTD.BLL.GoodsData();
            _bll.GetModel(gname);
            string gnum = _bll.Number;

            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];

            if (!isUpdate)
            {
                SystemLog bll_systemLog = new SystemLog();
                bll_systemLog.Name = "新增[销售订单明细]";
                bll_systemLog.MkName = "销售订单";
                bll_systemLog.Username = _username;
                bll_systemLog.Realname = _realname;
                bll_systemLog.Nowtimes = System.DateTime.Now;
                bll_systemLog.Add();
            }

            bll.Keyfile = _number; //外键 销售单号
            bll.GoodsNumber = gnum; //产品编号
            bll.GoodsName = context.Request.Form["gname"]; //产品名称
            bll.CountUnit = context.Request.Form["countunit"]; //产品单位
            bll.Model = "农产品"; //产品规格
            bll.StockPoint = Utils.GetDecimal(context.Request.Form["unitcost"], 0); ;  //售卖件数
            bll.SingleMoney = Utils.GetDecimal(context.Request.Form["price"], 0);   //单价
            bll.Allmoney = Utils.GetDecimal(context.Request.Form["allprice"], 0); //总价
            bll.Username = _username;
            bll.Realname = _realname;
            bll.Nowtimes = System.DateTime.Now;
            bll.YfMoney = Utils.GetDecimal(context.Request.Form["yfmoney"], 0); ;
            bll.ItemId = _strItemid;
            if (!isUpdate)
            {
                bll.Add();
            }
            else
            {
                bll.Update();
            }


        }

        protected string SaveSellOrder(HttpContext context)
        {
            string _resault2 = @"{""status"":false}";
            string Grealname = "等待审核";
            string Gname = "等待审核";
            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];
            string _Company = "no number";
            string _number = context.Request.Form["number"];
            string _shtime = context.Request.Form["ShTime"];
            string _companyAdd = context.Request.Form["CompanyAdd"];
            string _CompanyName = context.Request.Form["CompanyName"];
            string _Tel = context.Request.Form["Tel"];
            string _StockPeoNum = context.Request.Form["StockPeoNum"];
            string _StockPeoName = context.Request.Form["StockPeoName"];
            string _Discount = context.Request.Form["Discount"];
            string _AllMoney = context.Request.Form["AllMoney"];
            string _Remark = context.Request.Form["Remark"];
            string _StreamNumber = context.Request.Form["StreamNumber"];
            string _Title = context.Request.Form["title"]+"";
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
            SellOrder_pt bll_sellorder_pt = new SellOrder_pt();
            bll_sellorder_pt.title = _Title;//_realname + "的普通客户订单" + "合同";
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
            bll_sellorder_pt.StockPeoNum = _StockPeoNum;
            bll_sellorder_pt.StockPeoName = _StockPeoName;
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
            int i = bll_sellorder_pt.Add();

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


        protected string SaveSellOrder2(HttpContext context)
        {

           

            string _resault2 = @"{""status"":false}";
            string Grealname = "等待审核";
            string Gname = "等待审核";
            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];
            string _Company = "no number";
            string _number = context.Request.Form["number"];
            string _shtime = context.Request.Form["ShTime"];
            string _companyAdd = context.Request.Form["CompanyAdd"];
            string _CompanyName = context.Request.Form["CompanyName"];
            string _Tel = context.Request.Form["Tel"];
            string _StockPeoNum = context.Request.Form["StockPeoNum"];
            string _StockPeoName = context.Request.Form["StockPeoName"];
            string _Discount = context.Request.Form["Discount"];
            string _AllMoney = context.Request.Form["AllMoney"];
            string _Remark = context.Request.Form["Remark"];
            string _StreamNumber = context.Request.Form["StreamNumber"];
            string _Storeroom = context.Request.Form["Storeroom"];
            string _Seller = context.Request.Form["Seller"];
            string _Storekeeper = context.Request.Form["Storekeeper"];
            string _Title = context.Request.Form["title"]+"";
            string strSql = "KeyFile='" + _StreamNumber + "'";
            Xsdd_WorkStreamName bll2 = new Xsdd_WorkStreamName();
            bll2.GetModel("");
            string Gusername = bll2.username;
            Grealname = bll2.realname;// NewReader["realname"].ToString();
            Gname = bll2.Name_Jd;// NewReader["Name_Jd"].ToString();

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
            SellOrder bll_sellorder_pt = new SellOrder();
            bll_sellorder_pt.title = _Title; //_realname + "的会员客户订单" + "','" + "合同";
            bll_sellorder_pt.Type = "普通发票";
            bll_sellorder_pt.number = _number;
            bll_sellorder_pt.InvoiceType = "000";
            bll_sellorder_pt.QdTime = DateTime.Now;
            bll_sellorder_pt.OrderAdd = "0";
            bll_sellorder_pt.LxAdd = "0";
            bll_sellorder_pt.Storeroom = _Storeroom;
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
            bll_sellorder_pt.StockPeoNum = _StockPeoNum;
            bll_sellorder_pt.StockPeoName = _StockPeoName;
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
            bll_sellorder_pt.Gusername = Gusername;
            bll_sellorder_pt.Grealname = Grealname;

            bll_sellorder_pt.Gname = Gname;
            bll_sellorder_pt.MyTimes = DateTime.Now.ToString();// this.Session["MyTimes"].ToString();
            bll_sellorder_pt.Ifopen = "是";
            bll_sellorder_pt.Seller = _Seller;
            bll_sellorder_pt.Storekeeper = _Storekeeper;
            int i = bll_sellorder_pt.Add();

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