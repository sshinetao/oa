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
	/// OutRoom_add ��ժҪ˵����
	/// </summary>
	public class OutRoom_add : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
		Db List=new Db();
		public static string Gusername,Grealname,Gname;
		protected System.Web.UI.WebControls.TextBox ThTime;
		protected System.Web.UI.WebControls.TextBox ThPeople;
		protected System.Web.UI.WebControls.TextBox Tel;
		protected System.Web.UI.WebControls.TextBox OutUse;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			//�������
			if(!IsPostBack)
			{
			
				Random g  = new Random();
				string rad=g.Next(10000).ToString();

				number.Text=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+System.DateTime.Now.Hour.ToString()+""+System.DateTime.Now.Minute.ToString()+""+System.DateTime.Now.Second.ToString()+""+System.DateTime.Now.Millisecond.ToString()+""+rad+"";
			

			
                rname.Text = this.Session["TrueName"].ToString();
                uname.Text = this.Session["UserName"].ToString();
            

				this.ImageButton5.Attributes.Add("onclick","javascript:return del();"); 

			

				this.ImageButton3.Attributes.Add("onclick","javascript:zjOpen();"); 

				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			
			}




			string SQL_GetList_xs    =  "select * from OutRoomMx where  Keyfile='"+number.Text+"' order by id desc";
			Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
			Datagrid2.DataBind();
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
			this.Datagrid2.SelectedIndexChanged += new System.EventHandler(this.Datagrid2_SelectedIndexChanged);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.ImageButton2.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
		protected void MyDataGrid_Page_1(object sender,DataGridPageChangedEventArgs e)
		{
			Datagrid2.CurrentPageIndex = e.NewPageIndex;
			Datagrid2.DataBind();
		}


		private void ImageButton2_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("OutRoom.aspx");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{


			string    SQL_GetList     =  "select top 1 * from Ck_WorkStreamName  where KeyFile='"+StreamNumber.Text+"'";
			OleDbDataReader NewReader = List.GetList(SQL_GetList);
			if(NewReader.Read())
			{
				Gusername=NewReader["username"].ToString();
				Grealname=NewReader["realname"].ToString();
				Gname=NewReader["Name_Jd"].ToString();


				string sql_insert_xtrz="insert into SystemLog (Name,MkName,Username,Realname,Nowtimes) values ('����[����]','����','"+this.Session["username"]+"','"+this.Session["TrueName"]+"','"+System.DateTime.Now.ToString()+"')";
				List.ExeSql(sql_insert_xtrz);

			
				string sql_insert1="insert into OutRoomlog_lc values('"+this.Session["TrueName"]+"�����˳���["+title.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"]','"+System.DateTime.Now.ToString()+"','"+number.Text+"')";
				List.ExeSql(sql_insert1);


				string sql_insert="insert into OutRoom  (number,title,Storeroom,ThPeople,Tel,ThTime,OutUse,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,MyTimes) values('"+number.Text+"','"+title.Text.Replace("<","��").Replace(">","��").Replace("'","��")+"','"+Storeroom.Text+"','"+ThPeople.Text+"','"+Tel.Text+"','"+ThTime.Text+"','"+OutUse.Text+"','"+Remark.Text+"','�ȴ�����','"+this.Session["username"].ToString()+"','"+this.Session["TrueName"].ToString()+"','"+System.DateTime.Now.ToString()+"','"+StreamNumber.Text+"','"+StreamName.Text+"','"+Gusername+"','"+Grealname+"','"+Gname+"','"+this.Session["MyTimes"]+"')";
				List.ExeSql(sql_insert);

				this.Response.Write("<script language=javascript>alert('�ύ�ɹ���');window.location.href='OutRoom.aspx'</script>");

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
			
				string SQL_Del = "Delete from OutRoomMx where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);


				string SQL_GetList_xs    =  "select * from OutRoomMx where  Keyfile='"+number.Text+"' order by id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();




			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('ɾ��ʧ�ܣ���ȷ���Ƿ�ѡ��ɾ����');</script>");
			}
		}

		private void Datagrid2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try
			{
			
				ImageButton4.Attributes.Add("onclick","window.showModalDialog('OutRoom_add_update.aspx?a='+Math.random()+'&id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"&number="+number.Text+"','window','dialogWidth:700px;DialogHeight=400px;status:no;help=no;scroll=no');window.location='#'");
			

			}
			catch
			{
				//this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}
	}
}
