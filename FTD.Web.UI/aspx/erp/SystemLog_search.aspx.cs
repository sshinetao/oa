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

namespace qpsmartweb_jxc
{
	/// <summary>
	/// SystemLog_search ��ժҪ˵����
	/// </summary>
	public class SystemLog_search : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Realname;
		protected System.Web.UI.WebControls.TextBox Nowtimes;
		protected System.Web.UI.WebControls.TextBox MkName;
		protected System.Web.UI.WebControls.TextBox Name;
		protected System.Web.UI.WebControls.TextBox Username;
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.Name.Text.Trim() != "")
			{
				MidSql=MidSql+" and Name like '%"+this.Name.Text.Trim()+"%'";
			}


			if (this.MkName.Text.Trim() != "")
			{
				MidSql=MidSql+" and MkName like '%"+this.MkName.Text.Trim()+"%'";
			}	

			if (this.Username.Text.Trim() != "")
			{
				MidSql=MidSql+" and Username = '"+this.Username.Text.Trim()+"'";
			}	

			if (this.Nowtimes.Text.Trim() != "")
			{
				MidSql = MidSql + " and convert(char(10),cast(Nowtimes as datetime),120)=convert(char(10),cast('"+Nowtimes.Text+"' as datetime),120) ";
			}



			return MidSql;

		}
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

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

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
				Response.Redirect("SystemLog.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
				Response.Redirect("SystemLog_search_for.aspx?str="+CreateMidSql()+"");
		}
	}
}
