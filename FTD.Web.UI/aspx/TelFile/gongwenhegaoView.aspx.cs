using qpsmartweb_jxc.Public;
using System;
using System.Data;
using System.Web.UI;

namespace FTD.Web.UI.aspx.TelFile
{
    public partial class gongwenhegaoView : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!Page.IsPostBack)
            {
                Unit.PublicMethod.CheckSession();

                string sessionUname = Unit.PublicMethod.GetSessionValue("UserName");
                BLL.GWGL GWGLModel = new BLL.GWGL();
                DataSet dst = GWGLModel.GetList("shenpiren like '%" + sessionUname +"%'");
                if (dst.Tables[0].Rows.Count > 0)
                {
                    button1.Visible = true;
                }
                else
                {
                    button1.Visible = false;
                }
                 
                BLL.GWGL model = new BLL.GWGL();
                model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
                id.Value = model.Id+"";
                leixing.Text = model.Leixing + "";
                biaoti.Text = model.Biaoti + "";
                neirong.Text = model.Neirong + "";
                fujian.NavigateUrl = model.Fujian + "";
            }
            
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            Db List = new Db();
            string sql = "update gongwen set zhuangtai = '{0}' where id='{1}'";
            sql = string.Format(sql,"已审批",Request["id"]+"");
            List.ExeSql(sql);
        }
    }
}