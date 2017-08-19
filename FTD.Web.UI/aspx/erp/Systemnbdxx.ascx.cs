namespace bjoa
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Web;
	using System.Web.UI.WebControls;
	using System.Web.UI.HtmlControls;

	/// <summary>
	///		Systemnbdxx 的摘要说明。
	/// </summary>
	public class Systemnbdxx : System.Web.UI.UserControl
	{

		protected System.Web.UI.WebControls.Button Button5;
		protected System.Web.UI.WebControls.Button Button4;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Web.UI.WebControls.Button Button8;

		private void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
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
		///		设计器支持所需的方法 - 不要使用代码编辑器
		///		修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			
			this.Button8.Click += new System.EventHandler(this.Button8_Click);
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button8_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Systemnbdxx.aspx");
		}

		private void Button3_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Systemnbdxx_1.aspx");
		}

		private void Button4_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Systemnbdxx_2.aspx");
		}

		private void Button5_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Systemnbdxx_3.aspx");
		}
	}
}