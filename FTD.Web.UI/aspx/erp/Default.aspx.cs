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
	/// _default ��ժҪ˵����
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



			//			string    SQL_GetList     =  "select count(*) as counts from test_people where  datediff(ss,firsttime,lasttime)<=20";
			//			int alldelpoint=List.GetCount(SQL_GetList);
			//			if(alldelpoint>=20)
			//			{
			//				this.Response.Write("<script language=javascript>alert('ϵͳ��æ�����Ժ�����');</script>");
			//				return;
			//			}

			//			if(int.Parse(Application["user_sessions"].ToString())>=20)
			//			{
			//				this.Response.Write("<script language=javascript>alert('ϵͳ��æ�����Ժ�����');</script>");
			//				return;
			//			}




			string SQL_Check_worknum = "select * from Username where Username='"+Username.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"' and Password='"+Password.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"' ";
			OleDbDataReader MyReader_worknum = List.GetList(SQL_Check_worknum);
			if(MyReader_worknum.Read())
			{
				string SQL_Check_if = "select * from Username where Username='"+Username.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"' and Password='"+Password.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"'and Iflogin='��' ";
				OleDbDataReader MyReader_if  = List.GetList(SQL_Check_if);
				if(MyReader_if.Read())
				{
					
					string SQL_Check_t = "select * from Username where  Ifsystemuser='��' and  Username='"+Username.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"' and Password='"+Password.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"'and Iflogin='��'and datediff(dd,Firsttime,getdate())>=0 and datediff(dd,Lasttime,getdate())<=0  ";
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
						this.Response.Write("<script language=javascript>alert('���ʺ���Ч�ڳ������÷�Χ��');</script>");
						return;
					}


				}
				else
				{
					this.Response.Write("<script language=javascript>alert('���ʺŲ������½��');</script>");
					return;
				}
				
			}
			else
			{
				this.Response.Write("<script language=javascript>alert('��֤��Ϣʧ�ܣ�');</script>");
				return;
				
			}
		}
	}
}
