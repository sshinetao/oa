using FTD.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace FTD.Web.UI.aspx.ashx
{
    /// <summary>
    /// caiwu 的摘要说明
    /// </summary>
    public class caiwu : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain"; string _type = context.Request.QueryString["type"];
            string _ReturnJson = "";
            switch (_type)
            {
                case "save":
                    _ReturnJson = SavePlan(context);
                    break;
                case "get":
                    _ReturnJson = GetLiuShui(context);
                    break;
            
            }
            context.Response.Write(_ReturnJson.ToString());
            context.Response.End();
        }
        protected string SavePlan(HttpContext context)
        {
            string _resault2 = "";
            string _itemid = context.Request.Form["itemid"];
            FTD.BLL.liushui bll = new BLL.liushui();

            string strSql = "itemid=" + _itemid;
            DataSet ds = bll.GetList(strSql);
            if(ds!=null&& ds.Tables.Count>0&& ds.Tables[0].Rows.Count>0)
                return @"{""status"":false}"; ;


            string _username = context.Request.Form["uname"];
            string _realname = context.Request.Form["rname"];
            string month = context.Request.Form["month"];
            string day = context.Request.Form["day"];
            string year = context.Request.Form["year"];
            string pingzheng = context.Request.Form["pingzheng"];
            string duifang = context.Request.Form["duifang"];
            string zaiyao = context.Request.Form["zaiyao"];
            string inmoney = context.Request.Form["inmoney"];
            string outmoney = context.Request.Form["outmoney"];
            string nowmoney = context.Request.Form["nowmoney"];
            int in_qw = Utils.StrToInt(context.Request.Form["in_qw"], 0);
            int in_bw = Utils.StrToInt(context.Request.Form["in_bw"], 0);
            int in_sw = Utils.StrToInt(context.Request.Form["in_sw"], 0);
            int in_w = Utils.StrToInt(context.Request.Form["in_w"], 0);
            int in_q = Utils.StrToInt(context.Request.Form["in_q"], 0);
            int in_b = Utils.StrToInt(context.Request.Form["in_b"], 0);
            int in_s = Utils.StrToInt(context.Request.Form["in_s"], 0);
            int in_y = Utils.StrToInt(context.Request.Form["in_y"], 0);
            int in_j = Utils.StrToInt(context.Request.Form["in_j"], 0);
            int in_f = Utils.StrToInt(context.Request.Form["in_f"], 0);

            double inMoney = in_qw * 10000000 + in_bw * 1000000 + in_sw * 100000 + in_w * 10000 + in_q * 1000 + in_b * 100 + in_s * 10 + in_y + in_j * 0.1 + in_f * 0.01;

            int out_qw = Utils.StrToInt(context.Request.Form["out_qw"], 0);
            int out_bw = Utils.StrToInt(context.Request.Form["out_bw"], 0);
            int out_sw = Utils.StrToInt(context.Request.Form["out_sw"], 0);
            int out_w = Utils.StrToInt(context.Request.Form["out_w"], 0);
            int out_q = Utils.StrToInt(context.Request.Form["out_q"], 0);
            int out_b = Utils.StrToInt(context.Request.Form["out_b"], 0);
            int out_s = Utils.StrToInt(context.Request.Form["out_s"], 0);
            int out_y = Utils.StrToInt(context.Request.Form["out_y"], 0);
            int out_j = Utils.StrToInt(context.Request.Form["out_j"], 0);
            int out_f = Utils.StrToInt(context.Request.Form["out_f"], 0);

            double outMoney = out_qw * 10000000 + out_bw * 1000000 + out_sw * 100000 + out_w * 10000 + out_q * 1000 + out_b * 100 + out_s * 10 + out_y + out_j * 0.1 + out_f * 0.01;

            int now_qw = Utils.StrToInt(context.Request.Form["now_qw"], 0);
            int now_bw = Utils.StrToInt(context.Request.Form["now_bw"], 0);
            int now_sw = Utils.StrToInt(context.Request.Form["now_sw"], 0);
            int now_w = Utils.StrToInt(context.Request.Form["now_w"], 0);
            int now_q = Utils.StrToInt(context.Request.Form["now_q"], 0);
            int now_b = Utils.StrToInt(context.Request.Form["now_b"], 0);
            int now_s = Utils.StrToInt(context.Request.Form["now_s"], 0);
            int now_y = Utils.StrToInt(context.Request.Form["now_y"], 0);
            int now_j = Utils.StrToInt(context.Request.Form["now_j"], 0);
            int now_f = Utils.StrToInt(context.Request.Form["now_f"], 0);

            double nowMoney = now_qw * 10000000 + now_bw * 1000000 + now_sw * 100000 + now_w * 10000 + now_q * 1000 + now_b * 100 + now_s * 10 + now_y + now_j * 0.1 + now_f * 0.01;

            FTD.BLL.liushui model = new FTD.BLL.liushui();

            model.title = "";
            model.pingzheng = pingzheng;
            model.duifang = duifang;
            model.zaiyao = zaiyao;
            model.inMoney = decimal.Parse(inMoney.ToString());
            model.outMoney = decimal.Parse(outMoney.ToString());
            model.nowMoney = decimal.Parse(nowMoney.ToString()); 
            model.Year =  Utils.StrToInt(year,0);
            model.Monty = Utils.StrToInt(month, 0); 
            model.Day = Utils.StrToInt(day,0);
            model.CreateTime =DateTime.Now;
            model.Usernum = _username;
            model.RealName = _realname;
            model.itemid = _itemid;



            int i =  model.Add();
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

        protected string GetLiuShui(HttpContext context)
        {
            string _resault2 = "";

            int year = Utils.StrToInt(context.Request.QueryString["y"], DateTime.Now.Year);
            int month = Utils.StrToInt(context.Request.QueryString["m"], DateTime.Now.Month);
           // int day = Utils.StrToInt(context.Request.QueryString["day"], DateTime.Now.Month);
            string strSql = " Year=" + year + " and Monty=" + month;// +" and day=" + day;
            FTD.BLL.liushui model = new BLL.liushui();





            DataSet ds = model.GetList(strSql);
            if (ds != null)
            {
                DataTable dt = ds.Tables[0];
                StringBuilder sb = new StringBuilder();
                sb.Append("{\"total\":28,\"rows\":[");

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i > 0)
                    {
                        sb.Append(",");
                    }

                    string lblid = Utils.ObjectToStr(dt.Rows[i]["id"]);
                    string txttitle = Utils.ObjectToStr(dt.Rows[i]["title"]);
                    string txtpingzheng = Utils.ObjectToStr(dt.Rows[i]["pingzheng"]);
                    string txtduifang = Utils.ObjectToStr(dt.Rows[i]["duifang"]);
                    string txtzaiyao = Utils.ObjectToStr(dt.Rows[i]["zaiyao"]);
                    string txtinMoney = Utils.ObjectToStr(dt.Rows[i]["inMoney"]);
                    string txtoutMoney = Utils.ObjectToStr(dt.Rows[i]["outMoney"]);
                    string txtnowMoney = Utils.ObjectToStr(dt.Rows[i]["nowMoney"]);
                    string txtYear = Utils.ObjectToStr(dt.Rows[i]["Year"]);
                    string txtMonty = Utils.ObjectToStr(dt.Rows[i]["Monty"]);
                    string txtDay = Utils.ObjectToStr(dt.Rows[i]["Day"]);
                    string txtitemid = Utils.ObjectToStr(dt.Rows[i]["itemid"]);

                    sb.Append("{");
                    sb.Append("\"itemid\":\"" + txtitemid+"\"");
                    sb.Append(",\"day\":\"" + txtDay + "\"");
                    sb.Append(",\"pingzheng\":\"" + txtpingzheng + "\"");
                    sb.Append(",\"duifang\":\"" + txtduifang + "\"");
                    sb.Append(",\"zaiyao\":\"" + txtzaiyao + "\"");
                    int inMoney = Utils.StrToInt(txtinMoney, 0);


                    int in_qw = (int)(inMoney / 10000000 % 10);
                    int in_bw = (int)(inMoney / 1000000 % 10);

                    int in_sw = (int)(inMoney / 100000 % 10); ;
                    int in_w = (int)(inMoney / 10000 % 10); ;
                    int in_q = (int)(inMoney / 1000 % 10); ;
                    int in_b = (int)(inMoney / 100 % 10); ;
                    int in_s = (int)(inMoney / 10 % 10); ;
                    int in_y = (int)(inMoney % 10); ;
                    int in_j = (int)(inMoney * 10 % 10);
                    int in_f = (int)((inMoney - in_qw * 10000000 - in_bw * 1000000) * 100 % 10); ;
                    sb.Append(",\"in_qw\":" + in_qw);
                    sb.Append(",\"in_bw\":" + in_bw);
                    sb.Append(",\"in_sw\":" + in_sw);
                    sb.Append(",\"in_w\":" + in_w);
                    sb.Append(",\"in_q\":" + in_q);
                    sb.Append(",\"in_b\":" + in_b);
                    sb.Append(",\"in_s\":" + in_s);
                    sb.Append(",\"in_y\":" + in_y);
                    sb.Append(",\"in_j\":" + in_j);
                    sb.Append(",\"in_f\":" + in_f);

                    int outMoney = Utils.StrToInt(txtoutMoney, 0);

                    int out_qw = (int)(outMoney / 10000000 % 10);
                    int out_bw = (int)(outMoney / 1000000 % 10);
                    int out_sw = (int)(outMoney / 100000 % 10); ;
                    int out_w = (int)(outMoney / 10000 % 10); ;
                    int out_q = (int)(outMoney / 1000 % 10); ;
                    int out_b = (int)(outMoney / 100 % 10); ;
                    int out_s = (int)(outMoney / 10 % 10); ;
                    int out_y = (int)(outMoney % 10); ;
                    int out_j = (int)(outMoney * 10 % 10);
                    int out_f = (int)(outMoney * 100 % 10); ;
                    sb.Append(",\"out_qw\":" + out_qw);
                    sb.Append(",\"out_bw\":" + out_bw);
                    sb.Append(",\"out_sw\":" + out_sw);
                    sb.Append(",\"out_w\":" + out_w);
                    sb.Append(",\"out_q\":" + out_q);
                    sb.Append(",\"out_b\":" + out_b);
                    sb.Append(",\"out_s\":" + out_s);
                    sb.Append(",\"out_y\":" + out_y);
                    sb.Append(",\"out_j\":" + out_j);
                    sb.Append(",\"out_f\":" + out_f);


                    int nowMoney = Utils.StrToInt(txtnowMoney, 0);

                    int now_qw = (int)(nowMoney / 10000000 % 10);
                    int now_bw = (int)(nowMoney / 1000000 % 10);
                    int now_sw = (int)(nowMoney / 100000 % 10); ;
                    int now_w = (int)(nowMoney / 10000 % 10); ;
                    int now_q = (int)(nowMoney / 1000 % 10); ;
                    int now_b = (int)(nowMoney / 100 % 10); ;
                    int now_s = (int)(nowMoney / 10 % 10); ;
                    int now_y = (int)(nowMoney % 10); ;
                    int now_j = (int)(nowMoney * 10 % 10);
                    int now_f = (int)(nowMoney * 100 % 10); ;
                    sb.Append(",\"now_qw\":" + now_qw);
                    sb.Append(",\"now_bw\":" + now_bw);
                    sb.Append(",\"now_sw\":" + now_sw);
                    sb.Append(",\"now_w\":" + now_w);
                    sb.Append(",\"now_q\":" + now_q);
                    sb.Append(",\"now_b\":" + now_b);
                    sb.Append(",\"now_s\":" + now_s);
                    sb.Append(",\"now_y\":" + now_y);
                    sb.Append(",\"now_j\":" + now_j);
                    sb.Append(",\"now_f\":" + now_f);




                    sb.Append("}");

                }



                sb.Append("]}");
                _resault2 = sb.ToString();
            }
           

//            {"total":28,"rows":[
//    {"productid":"FI-SW-01","productname":"Koi","unitcost":10.00,"status":"P","listprice":36.50,"attr1":"Large","itemid":"EST-1"},
	
//]}
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