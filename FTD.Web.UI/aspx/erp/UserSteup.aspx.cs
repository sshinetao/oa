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
	/// UserSteup ��ժҪ˵����
	/// </summary>
	public class UserSteup : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox Incode;
		protected System.Web.UI.WebControls.TextBox Artper;
		protected System.Web.UI.WebControls.TextBox Address;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!IsPostBack)
			{

				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 

				string    SQL_GetList     =  "select * from UserSteup  where id='1'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{

					Name.Text=NewReader["Name"].ToString();
					Incode.Text=NewReader["Incode"].ToString();
					Artper.Text=NewReader["Artper"].ToString();
					Address.Text=NewReader["Address"].ToString();
					if(NewReader["IfSteup"].ToString()!="0"&&NewReader["IfSteup"].ToString()!="13002355133")
					{
						this.Response.Write("<script language=javascript>alert('��֤�������������޸����ݿ�');window.location.href='main_1.aspx'</script>");
						return;
					}
					
					if(NewReader["IfSteup"].ToString()=="13002355133")
					{
						Name.Enabled=false;
						Incode.Enabled=false;
					}
					else
					{
						Name.Enabled=true;
						Incode.Enabled=true;
					}

				
				}
				else
				{
					this.Response.Write("<script language=javascript>alert('��֤�������������޸����ݿ�');window.location.href='main_1.aspx'</script>");
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
			string    SQL_GetList     =  "select * from UserSteup  where id='1'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{

				if(NewReader["IfSteup"].ToString()!="13002355133"&&NewReader["IfSteup"].ToString()!="0")
				{
					this.Response.Write("<script language=javascript>alert('��֤�������������޸����ݿ�');window.location.href='main_1.aspx'</script>");
					return;
				}
				if(NewReader["IfSteup"].ToString()=="13002355133")
				{
					this.Response.Write("<script language=javascript>alert('���Ѿ����ù��������ظ�����');window.location.href='main_1.aspx'</script>");
				}
				else
				{
					if(Incode.Text=="����")
					{
						string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('������ʹ�õ�λ','ʹ�õ�λ����','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
						List.ExeSql(sql_insert_xtrz);

						string Sql_update ="Update UserSteup Set Name='"+Name.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',Address='"+Address.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',Artper='"+Artper.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"',Incode='����',IfSteup='13002355133'  where id='1'";
						List.ExeSql(Sql_update);
						this.Response.Write("<script language=javascript>alert('���óɹ�');window.parent.location = 'main.aspx'</script>");

					}
					else
					{
					 this.Response.Write("<script language=javascript>alert('ע��������');</script>");
					}
				}

				
			}
			else
			{
				this.Response.Write("<script language=javascript>alert('��֤�������������޸����ݿ�');window.location.href='main_1.aspx'</script>");
			}
		}
	}
}
