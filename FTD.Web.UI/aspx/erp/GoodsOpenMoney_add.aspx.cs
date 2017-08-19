using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using qpsmartweb_jxc.Public;
using System.Data.OleDb;
namespace qpsmartweb_jxc
{
	/// <summary>
	/// GoodsOpenMoney_add ��ժҪ˵����
	/// </summary>
	public class GoodsOpenMoney_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.TextBox Powermoney;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		protected System.Web.UI.WebControls.TextBox KhName;
		protected System.Web.UI.WebControls.TextBox KhNumber;
		protected System.Web.UI.WebControls.TextBox Stockmoney;
		protected System.Web.UI.WebControls.TextBox Zhekou;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			}
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[��������]','��Ӧ�̱���','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

			string sql_insert="insert into GoodsOpenMoney (GoodsNumber,GoodsName,CountUnit,Model,KhName,KhNumber,Stockmoney,Zhekou,Powermoney,State,Remark) values('"+GoodsNumber.Text+"','"+GoodsName.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+CountUnit.Text+"','"+Model.Text+"','"+KhName.Text+"','"+KhNumber.Text+"','"+Stockmoney.Text+"','"+Zhekou.Text+"','"+Powermoney.Text+"','����','"+Remark.Text+"')";
			List.ExeSql(sql_insert);
			
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='GoodsOpenMoney.aspx'</script>");
		}

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("GoodsOpenMoney.aspx");
		}
	}
}
