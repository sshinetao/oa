using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.chanpinpeisong
{
    public partial class nongchanpinpeisong_add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void iButton1_Click(object sender, EventArgs e)
        {
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

            FTD.BLL.ChanPinPeiSong model = new FTD.BLL.ChanPinPeiSong();
            model.recordtime = recordtime;
            model.peisongdanwei = peisongdanwei;
            model.peisongdizhi = peisongdizhi;
            model.dingdanhao = dingdanhao;
            model.jiaojieren = jiaojieren;
            model.peisongcheliang = peisongcheliang;
            model.peisonglicheng = peisonglicheng;
            model.peisongren = peisongren;

            model.Add();
            FTD.Unit.MessageBox.ShowAndRedirect(this, "添加成功！", "nongchanpinpeisong.aspx");
        }
    }
}
