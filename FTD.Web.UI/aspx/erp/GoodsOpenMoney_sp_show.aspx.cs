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
	/// GoodsOpenMoney_sp_show ��ժҪ˵����
	/// </summary>
	public class GoodsOpenMoney_sp_show : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox Number;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox Code;
		protected System.Web.UI.WebControls.TextBox Color;
		protected System.Web.UI.WebControls.TextBox Area;
		protected System.Web.UI.WebControls.TextBox Cubage;
		protected System.Web.UI.WebControls.TextBox Weight;
		protected System.Web.UI.WebControls.TextBox Powermoney;
		protected System.Web.UI.WebControls.TextBox Stockmoney;
		protected System.Web.UI.WebControls.TextBox Remark;
	Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from GoodsData  where Number='" +Server.UrlDecode(Request.QueryString["Number"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					Number.Text=NewReader["Number"].ToString();
					GoodsName.Text=NewReader["GoodsName"].ToString();
					CountUnit.Text=NewReader["CountUnit"].ToString();
					Model.Text=NewReader["Model"].ToString();
					Type.Text=NewReader["Type"].ToString();
					Code.Text=NewReader["Code"].ToString();
					Color.Text=NewReader["Color"].ToString();
					Area.Text=NewReader["Area"].ToString();
					Cubage.Text=NewReader["Cubage"].ToString();
					Weight.Text=NewReader["Weight"].ToString();
				
				
					Powermoney.Text=NewReader["Powermoney"].ToString();
					Stockmoney.Text=NewReader["Stockmoney"].ToString();
				
					Remark.Text=NewReader["Remark"].ToString();
				}

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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
