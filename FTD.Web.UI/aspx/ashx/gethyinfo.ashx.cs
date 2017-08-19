using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace FTD.Web.UI.aspx.ashx
{
    /// <summary>
    /// gethyinfo 的摘要说明
    /// </summary>
    public class gethyinfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";

            string _type = context.Request.QueryString["t"];
            string _ReturnJson = "";

            switch(_type)
            {
                case "hy": // 获取产品列表
                    _ReturnJson = GetProductList(context);
                    break;
            }

            context.Response.Write(_ReturnJson.ToString());
            context.Response.End();
        }
        protected string GetProductList(HttpContext context)
        {
            string _ProJson = "";
            FTD.BLL.ERPNewHuiYuan bll = new FTD.BLL.ERPNewHuiYuan();
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
                    sb.AppendFormat(@"""id"":""{0}""", dr["ID"]);
                    sb.AppendFormat(@",""Customer"":""{0}""", dr["Customer"]);
                    sb.AppendFormat(@",""address"":""{0}""", dr["address"]);
                 


                    sb.Append("}");

                }
                sb.Append("]");
                _ProJson = sb.ToString();
            }

            return _ProJson;
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