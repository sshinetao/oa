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
	/// StockPlan_add_update ��ժҪ˵����
	/// </summary>
	public class StockPlan_add_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.TextBox StockPoint;
		protected System.Web.UI.WebControls.TextBox SingleMoney;
		protected System.Web.UI.WebControls.TextBox Allmoney;
		protected System.Web.UI.WebControls.DropDownList Stocktype;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox CompanyName;
		protected System.Web.UI.WebControls.TextBox CompanyAdd;
		protected System.Web.UI.WebControls.TextBox JyOrderTime;
		protected System.Web.UI.WebControls.TextBox JyToTime;
		protected System.Web.UI.WebControls.TextBox TxTime;
		protected System.Web.UI.WebControls.TextBox Realname;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
		
			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
				Realname.Text=this.Session["TrueName"].ToString();
			}

			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from StockPlanMx  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					GoodsNumber.Text=NewReader["GoodsNumber"].ToString();
					GoodsName.Text=NewReader["GoodsName"].ToString();
					CountUnit.Text=NewReader["CountUnit"].ToString();
					Model.Text=NewReader["Model"].ToString();
					StockPoint.Text=NewReader["StockPoint"].ToString();
					SingleMoney.Text=NewReader["SingleMoney"].ToString();
					Allmoney.Text=NewReader["Allmoney"].ToString();
					Stocktype.SelectedValue=NewReader["Stocktype"].ToString();
					StockPeoNum.Text=NewReader["StockPeoNum"].ToString();
					StockPeoName.Text=NewReader["StockPeoName"].ToString();
					CompanyNumber.Text=NewReader["CompanyNumber"].ToString();
					CompanyName.Text=NewReader["CompanyName"].ToString();
					CompanyAdd.Text=NewReader["CompanyAdd"].ToString();
					JyOrderTime.Text=NewReader["JyOrderTime"].ToString();
					JyToTime.Text=NewReader["JyToTime"].ToString();
					TxTime.Text=NewReader["TxTime"].ToString();
					Realname.Text=this.Session["TrueName"].ToString();

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
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('�޸�[�ɹ��ƻ���ϸ]','�ɹ��ƻ�','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);


			string Sql_update ="Update StockPlanMx Set GoodsNumber='"+GoodsNumber.Text+"',GoodsName='"+GoodsName.Text+"',CountUnit='"+CountUnit.Text+"',Model='"+Model.Text+"',StockPoint='"+StockPoint.Text+"',SingleMoney='"+SingleMoney.Text+"',Allmoney='"+Allmoney.Text+"',Stocktype='"+Stocktype.SelectedValue+"',StockPeoNum='"+StockPeoNum.Text+"',StockPeoName='"+StockPeoName.Text+"',CompanyNumber='"+CompanyNumber.Text+"',CompanyName='"+CompanyName.Text+"',CompanyAdd='"+CompanyAdd.Text+"',JyOrderTime='"+JyOrderTime.Text+"',JyToTime='"+JyToTime.Text+"',TxTime='"+TxTime.Text+"',Username='"+this.Session["username"].ToString()+"',realname='"+this.Session["TrueName"].ToString()+"',Nowtimes='"+System.DateTime.Now.ToString()+"' where id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);
	
			
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.close()</script>");
		}
	}
}
