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
	/// StockIncome_add_update ��ժҪ˵����
	/// </summary>
	public class StockIncome_add_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox GoodsNumber;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.TextBox CountUnit;
		protected System.Web.UI.WebControls.TextBox Model;
		protected System.Web.UI.WebControls.TextBox StockPoint;
		protected System.Web.UI.WebControls.TextBox SingleMoney;
		protected System.Web.UI.WebControls.TextBox Allmoney;
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

			string    SQL_GetList_drh     =  "select * from StockIncomeMx   where Ifdd!='��' and Keyfile='"+Request.QueryString["number"]+"'";
		//	Response.Write(SQL_GetList_drh);
			OleDbDataReader NewReader_drh = List.GetList(SQL_GetList_drh);
			if(NewReader_drh.Read())
			{
				this.Response.Write("<script language=javascript>alert('����ⵥ�Ѿ����붩���������޸��У�');window.close()</script>");
				return;
			}


			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from StockIncomeMx   where id='" + int.Parse(Request.QueryString["id"])+"'";
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
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('�޸�[�ɹ������ϸ]','�ɹ�����','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);


			string Sql_update ="Update StockIncomeMx  Set GoodsNumber='"+GoodsNumber.Text+"',GoodsName='"+GoodsName.Text+"',CountUnit='"+CountUnit.Text+"',Model='"+Model.Text+"',StockPoint='"+StockPoint.Text+"',SingleMoney='"+SingleMoney.Text+"',Allmoney='"+Allmoney.Text+"',Username='"+this.Session["Username"].ToString()+"',Realname='"+this.Session["TrueName"].ToString()+"' where id='" + int.Parse(Request.QueryString["id"])+"'";
			List.ExeSql(Sql_update);
	
			
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.close()</script>");
		}
	}
}
