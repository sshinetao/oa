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
	/// GoodsData_add ��ժҪ˵����
	/// </summary>
	public class GoodsData_add : System.Web.UI.Page
	{
		
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox Number;
		protected System.Web.UI.WebControls.TextBox GoodsName;
		
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Remark;
        protected System.Web.UI.WebControls.DropDownList ddlCountUnit;
        protected System.Web.UI.WebControls.DropDownList ddlType;


		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();
			if(!Page.IsPostBack)
			{
				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();");
                BindCountUnit();
                BindType();
			}

			//�������
			if(!IsPostBack)
			{
			
				Random g  = new Random();
				string rad=g.Next(10000).ToString();

				Number.Text=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+rad+"";
			
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
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

        protected void BindCountUnit()
        {
            string SQL_GetList_xs = "select * from CountUnit order by id desc";

            ddlCountUnit.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
            ddlCountUnit.DataTextField = "Name";
            ddlCountUnit.DataValueField = "Name";
            ddlCountUnit.DataBind();
            //ddlCountUnit
        }

        protected void BindType()
        {
            string SQL_GetList_xs    =  "select * from GoodsType order by id desc";
            ddlType.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
            ddlType.DataTextField = "Name";
            ddlType.DataValueField = "Name";
            ddlType.DataBind();
            
        }

        //
				//Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				//Datagrid2.DataBind();

		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("GoodsData.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[��Ʒ����]','��Ʒ����','"+this.Session["UserName"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
			List.ExeSql(sql_insert_xtrz);

            string sql_insert = "insert into GoodsData (Number,GoodsName,CountUnit,Model,Type,Code,Color,Area,Cubage,Weight,Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark,State) values('" + Number.Text + "','" + GoodsName.Text.Replace("<", "��").Replace(">", "��").Replace("'", "��") + "','" + ddlCountUnit.SelectedValue + "','0','" + ddlType.SelectedValue + "','0','0','0','0','0','0','0','0','0','0','0','0','0','0','����')";
			List.ExeSql(sql_insert);
			
			this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='GoodsData.aspx'</script>");
		}
	}
}
