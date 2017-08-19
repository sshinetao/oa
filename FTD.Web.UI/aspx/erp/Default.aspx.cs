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
using System.Web.Security;
namespace qpsmartweb_jxc
{
	/// <summary>
	/// _default 的摘要说明。
	/// </summary>
	public class _default : System.Web.UI.Page
	{
		Db List=new Db();
		public static string PbType;
		public static string DjType_1,DjType_2,DjType_3,DjType_4,DjType_5,DjType_6;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox Username;
		protected System.Web.UI.WebControls.TextBox Password;
	
		private void Page_Load(object sender, System.EventArgs e)
		{

			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			}



		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{



			//			string    SQL_GetList     =  "select count(*) as counts from test_people where  datediff(ss,firsttime,lasttime)<=20";
			//			int alldelpoint=List.GetCount(SQL_GetList);
			//			if(alldelpoint>=20)
			//			{
			//				this.Response.Write("<script language=javascript>alert('系统繁忙，请稍后再试');</script>");
			//				return;
			//			}

			//			if(int.Parse(Application["user_sessions"].ToString())>=20)
			//			{
			//				this.Response.Write("<script language=javascript>alert('系统繁忙，请稍后再试');</script>");
			//				return;
			//			}




			string SQL_Check_worknum = "select * from Username where Username='"+Username.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"' and Password='"+Password.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"' ";
			OleDbDataReader MyReader_worknum = List.GetList(SQL_Check_worknum);
			if(MyReader_worknum.Read())
			{
				string SQL_Check_if = "select * from Username where Username='"+Username.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"' and Password='"+Password.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"'and Iflogin='是' ";
				OleDbDataReader MyReader_if  = List.GetList(SQL_Check_if);
				if(MyReader_if.Read())
				{
					
					string SQL_Check_t = "select * from Username where  Ifsystemuser='是' and  Username='"+Username.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"' and Password='"+Password.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"'and Iflogin='是'and datediff(dd,Firsttime,getdate())>=0 and datediff(dd,Lasttime,getdate())<=0  ";
					OleDbDataReader MyReader_t = List.GetList(SQL_Check_t);
					if(MyReader_t.Read())
					{
						this.Session["userName"]=MyReader_worknum["Username"].ToString();
						this.Session["TrueName"]=MyReader_worknum["Realname"].ToString();
						this.Session["Unit"]=MyReader_worknum["Unit"].ToString();
						this.Session["worknum"]=MyReader_worknum["worknum"].ToString();
						this.Session["perstr"]=MyReader_worknum["Perstr"].ToString();

						this.Session["MyTimes"]="2007-6-12 23:17:59";

						Response.Redirect("main.aspx");
					}
					else
					{
						this.Response.Write("<script language=javascript>alert('此帐号有效期超过设置范围！');</script>");
						return;
					}


				}
				else
				{
					this.Response.Write("<script language=javascript>alert('此帐号不允许登陆！');</script>");
					return;
				}
				
			}
			else
			{
				this.Response.Write("<script language=javascript>alert('验证信息失败！');</script>");
				return;
				
			}
		}
	}
}
