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
	/// SellOut_gz 的摘要说明。
	/// </summary>
	public class SellOut_gz : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.TextBox State;
		protected System.Web.UI.WebControls.TextBox Gname;
		protected System.Web.UI.WebControls.TextBox Grealname;
		protected System.Web.UI.WebControls.TextBox Sreakmart;
		protected System.Web.UI.WebControls.TextBox Textbox2;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox KeyFile;
		protected System.Web.UI.WebControls.TextBox Number;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		protected System.Web.UI.WebControls.TextBox Gusername;
		protected System.Web.UI.WebControls.TextBox Type;
		protected System.Web.UI.WebControls.TextBox title;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();


			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from SellOut   where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					Number.Text=NewReader["Number"].ToString();
					title.Text=NewReader["title"].ToString();
				
				
		
					Grealname.Text=NewReader["Grealname"].ToString();
				
					Type.Text=NewReader["Type"].ToString();
					State.Text=NewReader["State"].ToString();
				
				
					StreamName.Text=NewReader["StreamName"].ToString();
					StreamNumber.Text=NewReader["StreamNumber"].ToString();
					Gusername.Text=NewReader["Gusername"].ToString();
					Gname.Text=NewReader["Gname"].ToString();
					Gusername.Text=NewReader["Gusername"].ToString();
					Sreakmart.Text=NewReader["Sreakmart"].ToString();
				}
			}






			string    SQL_Label2     =   "select  * from Xsck_WorkStreamName where KeyFile='"+StreamNumber.Text+"' order by id asc";
				
			OleDbDataReader NewReader_Label2 = List.GetList(SQL_Label2);

			this.Label1.Text=null;
			int glTMP1=0;
			this.Label1.Text+="<table width=320 border=0 align=center cellpadding=0 cellspacing=0> <tr><td align=center><img src=i_blue/start.jpg  width=28 height=104></td></tr>";
			this.Label1.Text+="<tr>";
			while (NewReader_Label2.Read())
			{


				if(NewReader_Label2["username"].ToString()==Gusername.Text && NewReader_Label2["Name_Jd"].ToString()==Gname.Text && State.Text!="驳回审核")
				{
				
					this.Label1.Text+="<td align=center valign=top><table width=70% height=60 border=0 cellpadding=0 cellspacing=1 bgcolor=#000000><tr>   <td bgcolor=#FFFFFF><table width=100% border=0 cellspacing=0 cellpadding=0> <tr>    <td align=center><b><font color=red size=2>"+NewReader_Label2["realname"].ToString()+"</font></b></td></tr>  <tr>        <td align=center><b><font color=red size=2>（"+NewReader_Label2["Name_Jd"].ToString()+"）</font></b></td>  </tr>  <tr>     <td align=right></td></tr>  </table></td>  </tr>   </table>  <img src=i_blue/stjt.jpg width=25 height=28> </td>";
				}
				else
				{
					this.Label1.Text+="<td align=center valign=top><table width=70% height=60 border=0 cellpadding=0 cellspacing=1 bgcolor=#000000><tr>   <td bgcolor=#FFFFFF><table width=100% border=0 cellspacing=0 cellpadding=0> <tr>    <td align=center><font color=#000000 size=2>"+NewReader_Label2["realname"].ToString()+"</font></td></tr>  <tr>        <td align=center>（"+NewReader_Label2["Name_Jd"].ToString()+"）</td>  </tr>  <tr>     <td align=right></td></tr>  </table></td>  </tr>   </table>  <img src=i_blue/stjt.jpg width=25 height=28> </td>";
				}
			
				
				
					


				glTMP1=glTMP1+1;
				if(glTMP1==1)
				{
					Label1.Text+="</tr><TR>";
					glTMP1=0;
				}
			}
			this.Label1.Text+=" <td align=center valign=top><img src=i_blue/end.jpg width=28 height=69></td> </tr></table>";
			NewReader_Label2.Close();
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("SellOut.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("SellOut_gz_rz.aspx?number="+Number.Text+"&id="+Request.QueryString["id"].ToString()+"");
		}
	}
}
