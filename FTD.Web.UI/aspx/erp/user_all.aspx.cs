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
namespace bjoa
{
	/// <summary>
	/// user_all 的摘要说明。
	/// </summary>
	public class user_all : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			if(!IsPostBack) 
			{
				string    SQL_Label1     =   "select * from username ";
				
				OleDbDataReader NewReader_Label1 = List.GetList(SQL_Label1);

				this.Label1.Text=null;
				int glTMP=0;
				this.Label1.Text+="<TABLE id=Table8 cellSpacing=0 cellPadding=2 width=100% border=0>";
				this.Label1.Text+="<TR>";
				while (NewReader_Label1.Read())
				{
					
					this.Label1.Text+="<TD align=center width=100><a href=javascript:void(0) class=red onclick=javascript:window.showModalDialog('seadmessage.aspx?us="+NewReader_Label1["username"].ToString()+"','window','dialogWidth:800px;DialogHeight=468px;status:off;scroll=off;help:no');>"+NewReader_Label1["realname"].ToString()+"</a></TD>";
				
					


					glTMP=glTMP+1;
					if(glTMP==8)
					{
						Label1.Text+="</tr><TR>";
						glTMP=0;
					}
				}
				this.Label1.Text+="</table>";
				NewReader_Label1.Close();
				


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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}
	}
}
