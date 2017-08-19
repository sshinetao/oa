using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FTD.Web.UI.aspx.oldcar
{
    public partial class OldCarModify : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
                {
                    int id = (Convert.ToInt32(Request.Params["id"]));
                    ShowInfo(id);
                }
            }
        }

        private void ShowInfo(int id)
        {
            FTD.BLL.OldCar model = new FTD.BLL.OldCar();
            model.GetModel(id);
            this.hidVal.Value = model.id.ToString();
            this.txttasknum.Text = model.tasknum;
            this.txthtnum.Text = model.htnum;
            this.txtseller.Text = model.seller;
            this.txtsell_tel.Text = model.sell_tel;
            this.txtsell_address.Text = model.sell_address;
            this.txtbuyer.Text = model.buyer;
            this.txtbuy_tel.Text = model.buy_tel;
            this.txtbuy_address.Text = model.buy_address;
            this.txtplat_num.Text = model.plat_num;
            this.txtdengji_num.Text = model.dengji_num;
            this.txtcartype.Text = model.cartype;
            this.txtchejianum.Text = model.chejianum;
            this.txtchangpai.Text = model.changpai;
            this.txtzhuanru.Text = model.zhuanru;
        
            this.txtsell_coder.Text = model.sell_coder;
            this.txtbuy_coder.Text = model.buy_coder;
            this.txtoffer_time.Text = model.offer_time.ToString();

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
            model.id = Utils.GetInt(hidVal.Value, 0);
            if(model.id<0)
            {
                FTD.Unit.MessageBox.ShowAndRedirect(this, "请正确操作！", "List.aspx");
            }
            else
            {
                model.Update();
                FTD.Unit.MessageBox.ShowAndRedirect(this, "二手车修改成功！", "List.aspx");
            }
        }
    }
}