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
    public partial class GoodsLeading : System.Web.UI.Page
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
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (i == 0) continue;
                    DataRow dr = dt.Rows[i];
                    string gname = dr[0].ToString();
                    string CountUnit = dr[1].ToString();
                    string Type = dr[2].ToString();
                    SaveProduct(gname, CountUnit, Type, _number);

                }


            }


            this.Response.Write("<script language=javascript>alert('导入成功！');window.close()</script>");
        }

        protected string SaveProduct(string gname, string CountUnit, string Type,string number )
        {

            Random g = new Random();
            string rad = g.Next(10000).ToString();
            string _username = this.Session["UserName"].ToString();
            string _realname = this.Session["TrueName"].ToString();

            FTD.BLL.GoodsData bll = new FTD.BLL.GoodsData();
            #region 
            bll.GetModel(gname);

            string gnum = bll.Number;
            if (gnum != null && gnum != "") // 没有产品,将该产品加入产品库中
            {
                return "";
            }
            #endregion

            SystemLog _bll = new SystemLog();
            _bll.Name = "'新增[货品资料]-" + gname;
            _bll.Nowtimes = DateTime.Now;
            _bll.Realname = _realname;
            _bll.MkName = "货品资料";
            _bll.Username = _username;
            _bll.Add();



            bll.Number = number;
            bll.GoodsName = gname;

            bll.CountUnit = CountUnit;
            bll.Model = Type;
            bll.Type = Type;
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