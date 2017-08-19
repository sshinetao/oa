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
	/// UserSteup 的摘要说明。
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
						this.Response.Write("<script language=javascript>alert('验证错误！请勿随意修改数据库');window.location.href='main_1.aspx'</script>");
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
					this.Response.Write("<script language=javascript>alert('验证错误！请勿随意修改数据库');window.location.href='main_1.aspx'</script>");
				}

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
			string    SQL_GetList     =  "select * from UserSteup  where id='1'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{

				if(NewReader["IfSteup"].ToString()!="13002355133"&&NewReader["IfSteup"].ToString()!="0")
				{
					this.Response.Write("<script language=javascript>alert('验证错误！请勿随意修改数据库');window.location.href='main_1.aspx'</script>");
					return;
				}
				if(NewReader["IfSteup"].ToString()=="13002355133")
				{
					this.Response.Write("<script language=javascript>alert('你已经设置过！请勿重复设置');window.location.href='main_1.aspx'</script>");
				}
				else
				{
					if(Incode.Text=="邱鹏")
					{
						string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('设置了使用单位','使用单位设置','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
						List.ExeSql(sql_insert_xtrz);

						string Sql_update ="Update UserSteup Set Name='"+Name.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',Address='"+Address.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',Artper='"+Artper.Text.Replace("<","〈").Replace(">","〉").Replace("'","’")+"',Incode='邱鹏',IfSteup='13002355133'  where id='1'";
						List.ExeSql(Sql_update);
						this.Response.Write("<script language=javascript>alert('设置成功');window.parent.location = 'main.aspx'</script>");

					}
					else
					{
					 this.Response.Write("<script language=javascript>alert('注册代码错误！');</script>");
					}
				}

				
			}
			else
			{
				this.Response.Write("<script language=javascript>alert('验证错误！请勿随意修改数据库');window.location.href='main_1.aspx'</script>");
			}
		}
	}
}
