using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.chanpinpeisong
{
    public partial class nongchanpinpeisong_update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
            {
                int id = (Convert.ToInt32(Request.Params["id"]));
                ShowInfo(id);
            }
        }

        private void ShowInfo(int id)
        {

            FTD.BLL.ChanPinPeiSong model = new FTD.BLL.ChanPinPeiSong();
            model.GetModel(id);
            this.recordtime.Text = model.recordtime.ToString();
            this.peisongdanwei.Text=model.peisongdanwei.ToString();
            this.peisongdizhi.Text = model.peisongdizhi.ToString() ;
            this.dingdanhao.Text = model.dingdanhao.ToString();
            this.jiaojieren.Text = model.jiaojieren.ToString();
            this.peisongcheliang.Text = model.peisongcheliang.ToString() ;
            this.peisonglicheng.Text = model.peisonglicheng.ToString() ;
            this.peisongren.Text = model.peisongren.ToString();

        }
        protected void iButton1_Click(object sender, EventArgs e)
        {


            FTD.BLL.ChanPinPeiSong model = new FTD.BLL.ChanPinPeiSong();


            DateTime recordtime = DateTime.Parse(this.recordtime.Text.ToString());
            string peisongdanwei = this.peisongdanwei.Text;
            string peisongdizhi = this.peisongdizhi.Text;
            string dingdanhao = this.dingdanhao.Text;
            string jiaojieren = this.jiaojieren.Text;
            string peisongcheliang = this.peisongcheliang.Text;
            string peisonglicheng = this.peisonglicheng.Text;
            string peisongren = this.peisongren.Text;
            /// SELECT  id ,
            //recordtime ,
            //peisongdanwei ,
            //peisongdizhi ,
            //dingdanhao ,
            //jiaojieren ,
            //peisongcheliang ,
            //peisonglicheng ,
            //peisongren FROM dbo.nongchanpinpeisong
            model.recordtime = recordtime;
            model.peisongdanwei = peisongdanwei;
            model.peisongdizhi = peisongdizhi;
            model.dingdanhao = dingdanhao;
            model.jiaojieren = jiaojieren;
            model.peisongcheliang = peisongcheliang;
            model.peisonglicheng = peisonglicheng;
            model.peisongren = peisongren;

            model.id = Utils.GetInt(this.hidVal3.Value, 0);
            if (model.id < 0)
            {
                FTD.Unit.MessageBox.ShowAndRedirect(this, "请正确操作！", "bztj.aspx");
            }
            else
            {
                model.Update();
                FTD.Unit.MessageBox.ShowAndRedirect(this, "修改成功！", "bztj.aspx");
            }
        }
    }
}