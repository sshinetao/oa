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
	/// Cgdd_WorkStreamName ��ժҪ˵����
	/// </summary>
	public class Cgdd_WorkStreamName : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.TextBox Name_type;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox KeyFile;
		Db List=new Db();
		public static int id;
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();
			this.ImageButton3.Attributes.Add("onclick","javascript: lxOpen();");

			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from Cgdd_WorkStreamType  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					KeyFile.Text=NewReader["Number"].ToString();
					Name_type.Text=NewReader["Name"].ToString();
				
				}

			}


			id=int.Parse(Request.QueryString["id"]);
			
			if (Request.QueryString["Del"]!= null)
			{
				try 
				{
					string SQL_Del = "Delete from Cgdd_WorkStreamName where Id=" +Request.QueryString["Del"];
					List.ExeSql(SQL_Del);

					
				}
				catch
				{
					Response.Write("<script>alert('ɾ��ʧ��');</script>");
				}
				
			}


		
			string    SQL_Label2     =   "select  * from Cgdd_WorkStreamName where KeyFile='"+KeyFile.Text+"' order by id asc";
				
			OleDbDataReader NewReader_Label2 = List.GetList(SQL_Label2);

			this.Label1.Text=null;
			int glTMP1=0;
			this.Label1.Text+="<table width=320 border=0 align=center cellpadding=0 cellspacing=0> <tr><td align=center><img src=i_blue/start.jpg  width=28 height=104></td></tr>";
			this.Label1.Text+="<tr>";
			while (NewReader_Label2.Read())
			{
			
				this.Label1.Text+="<td align=center valign=top><table width=70% height=60 border=0 cellpadding=0 cellspacing=1 bgcolor=#000000><tr>   <td bgcolor=#FFFFFF><table width=100% border=0 cellspacing=0 cellpadding=0> <tr>    <td align=center><font color=#000000 size=2>"+NewReader_Label2["realname"].ToString()+"</font></td></tr>  <tr>        <td align=center>��"+NewReader_Label2["Name_Jd"].ToString()+"��</td>  </tr>  <tr>     <td align=right>[<a href='#' onclick='pdzj("+NewReader_Label2["id"].ToString()+");'>ƽ����Ա</a>][<a href='#' onclick='m_show("+NewReader_Label2["id"].ToString()+");'>�޸�</a>] [<a href='#' onclick='return del("+NewReader_Label2["id"].ToString()+");'>ɾ��</a>]&nbsp;</td></tr>  </table></td>  </tr>   </table>  <img src=i_blue/stjt.jpg width=25 height=28> </td>";
				
					


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
			Response.Redirect("Cgdd_stream.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			this.Response.Write("<script language=javascript>alert('���óɹ���');window.location.href='Cgdd_stream.aspx'</script>");
		}
	}
}

