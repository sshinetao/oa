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
	/// IncomeRoom_update ��ժҪ˵����
	/// </summary>
	public class IncomeRoom_update : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
		protected System.Web.UI.WebControls.ImageButton ImageButton4;
		protected System.Web.UI.WebControls.ImageButton ImageButton5;
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox Storeroom;
		protected System.Web.UI.WebControls.TextBox ShTime;
		protected System.Web.UI.WebControls.TextBox StreamName;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox number;
		protected System.Web.UI.WebControls.TextBox CompanyNumber;
		protected System.Web.UI.WebControls.TextBox StockPeoNum;
		protected System.Web.UI.WebControls.TextBox StockPeoName;
		protected System.Web.UI.WebControls.TextBox Remark;
		protected System.Web.UI.WebControls.TextBox StreamNumber;
        protected System.Web.UI.WebControls.TextBox rukuleixing;
		Db List=new Db();
		public static string Gusername,Grealname,Gname;
		protected System.Web.UI.WebControls.TextBox State;
		protected System.Web.UI.WebControls.TextBox InSource;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			//�������
			if(!IsPostBack)
			{
			
			
			

			

				this.ImageButton5.Attributes.Add("onclick","javascript:return del();"); 

			

				this.ImageButton3.Attributes.Add("onclick","javascript:zjOpen();"); 

				this.ImageButton1.Attributes.Add("onclick","javascript:return chknull();"); 
			
			}


			if(!IsPostBack)
			{
				string    SQL_GetList     =  "select * from IncomeRoom  where id='" + int.Parse(Request.QueryString["id"])+"'";
				OleDbDataReader NewReader = List.GetList(SQL_GetList);
				if(NewReader.Read())
				{
					number.Text=NewReader["number"].ToString();
					
					title.Text=NewReader["title"].ToString();
					ShTime.Text=NewReader["ShTime"].ToString();
					StockPeoNum.Text=NewReader["StockPeoNum"].ToString();	
					StockPeoName.Text=NewReader["StockPeoName"].ToString();	
					Storeroom.Text=NewReader["Storeroom"].ToString();
					InSource.Text=NewReader["InSource"].ToString();		
					State.Text=NewReader["State"].ToString();		
					
					Remark.Text=NewReader["Remark"].ToString();
					StreamNumber.Text=NewReader["StreamNumber"].ToString();
					StreamName.Text=NewReader["StreamName"].ToString();
                    rukuleixing.Text = NewReader["rukuleixing"].ToString();
				
				}

			}









			string SQL_GetList_xs    =  "select * from IncomeRoomMx where  Keyfile='"+number.Text+"' order by id desc";
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


                string Sql_update = "";
                Sql_update = @"update IncomeRoom set title='{0}',ShTime='{1}',StockPeoNum='{2}',StockPeoName='{3}',Storeroom='{4}',InSource='{5}',Remark='{6}',MyTimes='{7}',StreamNumber='{8}',StreamName='{9}',Gusername='{10}',Grealname='{11}',Gname='{12}',Username='{13}',Realname='{14}',State='{15}',rukuleixing='{16}' where  id='{17}'";
                Sql_update = string.Format(Sql_update, title.Text, ShTime.Text.Replace("<", "��").Replace(">", "��").Replace("'", "��"), StockPeoNum.Text.Replace("<", "��").Replace(">", "��").Replace("'", "��"), StockPeoName.Text,Storeroom.Text, InSource.Text, Remark.Text, this.Session["MyTimes"], StreamNumber.Text, StreamName.Text, Gusername, Grealname, Gname, this.Session["UserName"], this.Session["TrueName"], "�ȴ�����", rukuleixing.Text, int.Parse(Request.QueryString["id"]));
                List.ExeSql(Sql_update);

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
			
				string SQL_Del = "Delete from IncomeRoomMx where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);


				string SQL_GetList_xs    =  "select * from IncomeRoomMx where  Keyfile='"+number.Text+"' order by id desc";
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
			
				ImageButton4.Attributes.Add("onclick","window.showModalDialog('IncomeRoom_add_update.aspx?a='+Math.random()+'&id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"&number="+number.Text+"','window','dialogWidth:700px;DialogHeight=400px;status:no;help=no;scroll=no');window.location='#'");
			

			}
			catch
			{
				//this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}
	}
}
