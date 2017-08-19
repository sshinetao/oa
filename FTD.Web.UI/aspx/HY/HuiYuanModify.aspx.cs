using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace OA.aspx.HY{ 
 public partial class HuiYuanModify: System.Web.UI.Page
{


	protected void Page_Load(object sender, EventArgs e)
	{
		if (!Page.IsPostBack)
		{
			FTD.Unit.PublicMethod.CheckSession();

            BindTaoCan();
            FTD.BLL.ERPNewHuiYuan Model = new FTD.BLL.ERPNewHuiYuan();
			Model.GetModel(int.Parse(Request.QueryString["ID"].ToString()));
			this.txtNameStr.Text=Model.Customer.ToString();


            txtAddress.Text = Model.Address;
            ddlStaus.SelectedValue = Model.CStaus.ToString();
            txtNameStr.Text = Model.Customer;
            txtEndTime.Text = Model.EndTime.ToString();
            txtBeginTime.Text = Model.FirstTime.ToString();
            txtOrderNum.Text = Model.OrderNumber;
            txtRealCount.Text = Model.RealSend.ToString();
            txtSendCount.Text = Model.SendCounts.ToString();
            ddlSendType.SelectedValue = Model.SendType;
            Model.Sendrole = GetChecked(ckSendRole, "|");
            Model.SendTime = GetChecked(ckSendRole, "|");
            ddlTaoCan.SelectedItem.Text = Model.TaoCanNum;
            txtTel.Text = Model.Tel;  
		}
	}
	protected void iButton1_Click(object sender, EventArgs e)
	{
        FTD.BLL.ERPNewHuiYuan Model = new FTD.BLL.ERPNewHuiYuan();
		
		Model.Id = int.Parse(Request.QueryString["ID"].ToString());
       
        Model.Address = txtAddress.Text;
        Model.CStaus = GetInt(ddlStaus.SelectedValue);
        Model.Customer = txtNameStr.Text;
        Model.EndTime = GetDate(txtEndTime.Text);
        Model.FirstTime = GetDate(txtBeginTime.Text);
        Model.OrderNumber = txtOrderNum.Text;
        Model.RealSend = GetInt(txtRealCount.Text);
        Model.SendCounts = GetInt(txtSendCount.Text);
        Model.Sendrole = GetChecked(ckSendRole, "|");
        Model.SendTime = GetChecked(ckSendRole, "|");
        Model.SendType = ddlSendType.SelectedValue;
        Model.TaoCanNum = ddlTaoCan.SelectedValue;
        Model.Tel = txtTel.Text;
        Model.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
		
		Model.Update();
		
		//写系统日志
		FTD.BLL.ERPRiZhi MyRiZhi = new FTD.BLL.ERPRiZhi();
		MyRiZhi.UserName = FTD.Unit.PublicMethod.GetSessionValue("UserName");
		MyRiZhi.DoSomething = "用户修改会员信息(" + this.txtNameStr.Text + ")";
		MyRiZhi.IpStr = System.Web.HttpContext.Current.Request.UserHostAddress.ToString();
		MyRiZhi.Add();
		
		FTD.Unit.MessageBox.ShowAndRedirect(this, "会员信息修改成功！", "HuiYuan.aspx");
	}

    protected void BindTaoCan()
    {
        FTD.BLL.ERPHuiYuanTaoCan taocan = new FTD.BLL.ERPHuiYuanTaoCan();
        DataTable dt = taocan.GetList("").Tables[0];
        if (dt != null)
        {
            ddlTaoCan.DataSource = dt;
            ddlTaoCan.DataTextField = "TaoCanName";
            ddlTaoCan.DataValueField = "SendCount";
            ddlTaoCan.DataBind();
        }
    }


    protected int GetInt(string str)
    {
        int i = 0;

        try
        {
            return int.Parse(str);

        }
        catch
        {
            return i;
        }


    }

    protected DateTime? GetDate(string _strDate)
    {
        try
        {
            DateTime dt = DateTime.ParseExact(_strDate, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
            return dt;
        }
        catch
        {
            return null;
        }
    }

    protected void ddlTaoCan_SelectedIndexChanged(object sender, EventArgs e)
    {
        string sendcount = ddlTaoCan.SelectedValue;
        txtSendCount.Text = sendcount;
    }

    public string GetChecked(CheckBoxList checkList, string separator)
    {
        string str = "";
        for (int i = 0; i < checkList.Items.Count; i++)
        {

            if (checkList.Items[i].Selected)
            {
                if (str != "")
                {
                    str += separator;
                }
                str += checkList.Items[i].Value;
            }
        }
        return str;
    }
}
}