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
	/// IncomeRoom_add ��ժҪ˵����
	/// </summary>
	public class IncomeRoom_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox ShTime;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox Remark;
        protected System.Web.UI.WebControls.TextBox Balance;
        protected System.Web.UI.WebControls.TextBox StreamNumber;
        protected System.Web.UI.WebControls.DropDownList ddlStoreroom;
        protected System.Web.UI.WebControls.DropDownList ddlSource;

        
		Db List=new Db();
		public static string Gusername,Grealname,Gname;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			//�������
			if(!IsPostBack)
            {
                //
                BindInSource();
                BindStoreroom();
				Random g  = new Random();
				string rad=g.Next(10000).ToString();

				number.Text=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+System.DateTime.Now.Hour.ToString()+""+System.DateTime.Now.Minute.ToString()+""+System.DateTime.Now.Second.ToString()+""+System.DateTime.Now.Millisecond.ToString()+""+rad+"";
                ShTime.Text = DateTime.Now.ToShortDateString();

			

				this.ImageButton5.Attributes.Add("onclick","javascript:return del();"); 

			

				this.ImageButton3.Attributes.Add("onclick","javascript:zjOpen();"); 

				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			
			}




			string SQL_GetList_xs    =  "select * from IncomeRoomMx where  Keyfile='"+number.Text+"' order by id desc";
			
		}


        /// <summary>
        /// �����Դ
        /// </summary>
        protected void BindInSource()
        {
            string SQL_GetList_xs = "select * from InSource order by id desc";
           
            //ddlStoreroom
            //= List.GetGrid_Pages(SQL_GetList_xs, "id");
            ddlSource.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
            ddlSource.DataTextField = "Name";
            ddlSource.DataValueField = "Name";
            ddlSource.DataBind();
        }

        protected void BindStoreroom()
        {
            string SQL_GetList_xs = "select * from Storeroom order by id desc";

            ddlStoreroom.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
            ddlStoreroom.DataTextField = "Name";
            ddlStoreroom.DataValueField = "Name";
            ddlStoreroom.DataBind();
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
			this.ImageButton5.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton5_Click);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion



		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("IncomeRoom.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{


			string    SQL_GetList     =  "select top 1 * from Rk_WorkStreamName  where KeyFile='"+StreamNumber.Text+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				Gusername=NewReader["username"].ToString();
				Grealname=NewReader["realname"].ToString();
				Gname=NewReader["Name_Jd"].ToString();


				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[���]','���','"+this.Session["UserName"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);

			
				string sql_insert1="insert into IncomeRoomlog_lc values('"+this.Session["TrueName"]+"���������["+title.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"]','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
				List.ExeSql(sql_insert1);


                string sql_insert = "insert into IncomeRoom  (number,title,ShTime,StockPeoNum,StockPeoName,Storeroom,InSource,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,MyTimes) values('" + number.Text + "','" + title.Text.Replace("<", "��").Replace(">", "��").Replace("'", "��") + "','" + ShTime.Text + "','" + StockPeoNum.Text + "','" + StockPeoName.Text + "','" + ddlStoreroom.SelectedValue + "','" + ddlSource.SelectedValue+ "','" + Remark.Text + "','�ȴ�����','" + this.Session["UserName"].ToString() + "','" + this.Session["TrueName"].ToString() + "','" + System.DateTime.Now.ToString() + "','" + StreamNumber.Text + "','" + StreamName.Text + "','" + Gusername + "','" + Grealname + "','" + Gname + "','" + this.Session["MyTimes"] + "')";
				List.ExeSql(sql_insert);

				this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='IncomeRoom.aspx'</script>");

			}
			else
			{
				this.Response.Write("<script language=javascript>alert('�˹�������δ�ҵ���Ӧ�����̣�����ʧ��');</script>");
				return;
			
			}




		}

		private void ImageButton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
			
				//string SQL_Del = "Delete from IncomeRoomMx where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				//List.ExeSql(SQL_Del);


				string SQL_GetList_xs    =  "select * from IncomeRoomMx where  Keyfile='"+number.Text+"' order by id desc";
		




			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('ɾ��ʧ�ܣ���ȷ���Ƿ�ѡ��ɾ����');</script>");
			}
		}

		
	}
}
