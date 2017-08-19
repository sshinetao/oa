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
	/// BB_IncomeRoom_HW ��ժҪ˵����
	/// </summary>
	public class BB_IncomeRoom_HW : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.TextBox Starttime;
		protected System.Web.UI.WebControls.TextBox Endtime;
		Db List=new Db();
		protected System.Web.UI.WebControls.TextBox GoodsName;
		protected System.Web.UI.WebControls.DataGrid Datagrid2;
		protected System.Web.UI.WebControls.DropDownList Stocktype;
		public static decimal  allmoney;
		public string CreateMidSql()
		{
			string MidSql = string.Empty;
			
			if (this.GoodsName.Text.Trim() != "")
			{
				MidSql=MidSql+" and IncomeRoomMx.GoodsName like '%"+this.GoodsName.Text.Trim()+"%'";
			}




	
			if (this.Starttime.Text.Trim() != "" && this.Endtime.Text.Trim() != "")
			{
				MidSql=MidSql+" and (IncomeRoomMx.Nowtimes between '"+this.Starttime.Text+"' and  '"+this.Endtime.Text+"' or convert(char(10),cast(IncomeRoomMx.Nowtimes as datetime),120)=convert(char(10),cast('"+this.Starttime.Text+"' as datetime),120) or convert(char(10),cast(IncomeRoomMx.Nowtimes as datetime),120)=convert(char(10),cast('"+this.Endtime.Text+"' as datetime),120)) ";
			}	

			return MidSql;

		}
		private void Page_Load(object sender, System.EventArgs e)
		{
			if(!IsPostBack)
			{

				Starttime.Text="2006-01-01";
				Endtime.Text=System.DateTime.Now.ToShortDateString();


			}
			if(Request.QueryString["str"]!=null)
			{
				//string SQL_GetList_xs    =  "select IncomeRoomMx.* ,IncomeRoom.title from IncomeRoomMx,IncomeRoom where IncomeRoomMx.Keyfile=IncomeRoom.number "+Server.UrlDecode(Request.QueryString["str"])+" ";

                string SQL_GetList_xs =" select max(IncomeRoomMx.Id) as ID"+
      ",max(IncomeRoomMx.[GoodsNumber]) as GoodsNumber" +
                    " ,IncomeRoomMx.[GoodsName]" +
                    ",max(IncomeRoomMx.[CountUnit]) as CountUnit" +
                    ",max(IncomeRoomMx.[Model]) as Model" +
                    " ,Sum(IncomeRoomMx.[StockPoint]) as StockPoint " +
                    ",max(IncomeRoomMx.[Username]) as Username" +
                    ",max(IncomeRoomMx.[Realname]) as Realname" +
                    " ,max(IncomeRoomMx.[Nowtimes]) as Nowtimes  " +
"  from IncomeRoomMx "+
"where 1=1 "+
 Server.UrlDecode(Request.QueryString["str"])+" " +
 "group by GoodsName,StockPoint";

				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();

			}
			else
            {
                string SQL_GetList_xs = " select max(IncomeRoomMx.Id) as ID" +
                    ",max(IncomeRoomMx.[GoodsNumber]) as GoodsNumber" +
                    " ,IncomeRoomMx.[GoodsName]" +
                    ",max(IncomeRoomMx.[CountUnit]) as CountUnit" +
                    ",max(IncomeRoomMx.[Model]) as Model" +
                    " ,Sum(IncomeRoomMx.[StockPoint])  as StockPoint " +
                    ",max(IncomeRoomMx.[Username]) as Username" +
                    ",max(IncomeRoomMx.[Realname]) as Realname" +
                    " ,max(IncomeRoomMx.[Nowtimes]) as Nowtimes  " +
                    "  from IncomeRoomMx " +
                    "group by GoodsName,StockPoint";

			
				//string SQL_GetList_xs    =  "select IncomeRoomMx.*  ,IncomeRoom.title from IncomeRoomMx,IncomeRoom where IncomeRoomMx.Keyfile=IncomeRoom.number order by IncomeRoomMx.id desc";
				Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
				Datagrid2.DataBind();	
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
			Response.Redirect("BB_IncomeRoom_HW.aspx?str="+CreateMidSql()+"");
		}



	}
}
