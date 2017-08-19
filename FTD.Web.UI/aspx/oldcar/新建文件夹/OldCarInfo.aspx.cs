using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.oldcar
{
    public partial class OldCarInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void iButton1_Click(object sender, EventArgs e)
        {
            string strErr = "";
            if (this.txttasknum.Text.Trim().Length == 0)
            {
                strErr += "发票单号不能为空！\\n";
            }
            if (this.txthtnum.Text.Trim().Length == 0)
            {
                strErr += "合同编号不能为空！\\n";
            }
            if (this.txtseller.Text.Trim().Length == 0)
            {
                strErr += "卖方不能为空！\\n";
            }
            if (this.txtsell_tel.Text.Trim().Length == 0)
            {
                strErr += "卖方电话不能为空！\\n";
            }
            if (this.txtsell_address.Text.Trim().Length == 0)
            {
                strErr += "卖方联系地址不能为空！\\n";
            }
            if (this.txtbuyer.Text.Trim().Length == 0)
            {
                strErr += "买方不能为空！\\n";
            }
            if (this.txtbuy_tel.Text.Trim().Length == 0)
            {
                strErr += "买方电话不能为空！\\n";
            }
            if (this.txtbuy_address.Text.Trim().Length == 0)
            {
                strErr += "买方地址不能为空！\\n";
            }
            if (this.txtplat_num.Text.Trim().Length == 0)
            {
                strErr += "车牌号不能为空！\\n";
            }
            
          
           
            if (this.txtsell_coder.Text.Trim().Length == 0)
            {
                strErr += "卖方身份证号不能为空！\\n";
            }
            if (this.txtbuy_coder.Text.Trim().Length == 0)
            {
                strErr += "买方身份证号不能为空！\\n";
            }

            if (strErr != "")
            {               
                return;
            }
            string tasknum = this.txttasknum.Text;
            string htnum = this.txthtnum.Text;
            string seller = this.txtseller.Text;
            string sell_tel = this.txtsell_tel.Text;
            string sell_address = this.txtsell_address.Text;
            string buyer = this.txtbuyer.Text;
            string buy_tel = this.txtbuy_tel.Text;
            string buy_address = this.txtbuy_address.Text;
            string plat_num = this.txtplat_num.Text;
            string dengji_num = this.txtdengji_num.Text;
            string cartype = this.txtcartype.Text;
            string chejianum = this.txtchejianum.Text;
            string changpai = this.txtchangpai.Text;
            string zhuanru = this.txtzhuanru.Text;
            string fapiaofile = "";// this.txtfapiaofile.Text;
            string chejiafile = "";// this.txtchejiafile.Text;
            string Userid = FTD.Unit.PublicMethod.GetSessionValue("UserName");
            DateTime CreateTime = DateTime.Now;
            string sell_coder = this.txtsell_coder.Text;
            string buy_coder = this.txtbuy_coder.Text;
            DateTime offer_time = DateTime.Parse(this.txtoffer_time.Text);

            FTD.BLL.OldCar model = new FTD.BLL.OldCar();
            model.tasknum = tasknum;
            model.htnum = htnum;
            model.seller = seller;
            model.sell_tel = sell_tel;
            model.sell_address = sell_address;
            model.buyer = buyer;
            model.buy_tel = buy_tel;
            model.buy_address = buy_address;
            model.plat_num = plat_num;
            model.dengji_num = dengji_num;
            model.cartype = cartype;
            model.chejianum = chejianum;
            model.changpai = changpai;
            model.zhuanru = zhuanru;
            model.fapiaofile = fapiaofile;
            model.chejiafile = chejiafile;
            model.Userid = Userid;
            model.CreateTime = CreateTime;
            model.sell_coder = sell_coder;
            model.buy_coder = buy_coder;
            model.offer_time = offer_time;
            model.Add();
            FTD.Unit.MessageBox.ShowAndRedirect(this, "二手车添加成功！", "List.aspx");
        }
    }
}