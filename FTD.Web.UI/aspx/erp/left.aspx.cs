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
using Microsoft.Web.UI.WebControls;
namespace qpsmartweb_jxc
{
	/// <summary>
	/// left 的摘要说明。
	/// </summary>
	public class left : System.Web.UI.Page
	{
		protected Microsoft.Web.UI.WebControls.TreeView TreeView1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			string str=this.Session["perstr"].ToString();
			
			BindTheTree(this.TreeView1.Nodes,str);
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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void BindTheTree( Microsoft.Web.UI.WebControls.TreeNodeCollection Nds, string UserPerStr)
		{
			for (int i = 0; i < Nds.Count; i++)
			{
			
				if (!StrIFInStr(Nds[i].NodeData.ToString(), UserPerStr))
				{
					Nds.Remove(Nds[i]);
					i = i - 1;
				}
				else
				{
					

					BindTheTree(Nds[i].Nodes, UserPerStr);
				}
			}
		}
		private bool StrIFInStr(string Str1, string Str2)
		{
			if (Str2.IndexOf(Str1) < 0)
			{
				
				return false;
			}
			else
			{
				
				return true;
			}
		} 
		
	}
}
