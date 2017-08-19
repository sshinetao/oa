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
	/// SellOrder ��ժҪ˵����
	/// </summary>
	public class SellOrder : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox tilte;
		protected System.Web.UI.WebControls.ImageButton ImageButton2;
		protected System.Web.UI.WebControls.ImageButton Imagebutton1;
		protected System.Web.UI.WebControls.ImageButton Imagebutton9;
		protected System.Web.UI.WebControls.ImageButton Imagebutton4;
		protected System.Web.UI.WebControls.ImageButton Imagebutton5;
		protected System.Web.UI.WebControls.ImageButton Imagebutton7;
		protected System.Web.UI.WebControls.ImageButton ImageButton3;
        protected System.Web.UI.WebControls.DataGrid Datagrid2;
        protected System.Web.UI.WebControls.ImageButton Imagebutton8;
        protected System.Web.UI.WebControls.ImageButton Imagebutton6;
		
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

		
			if(!Page.IsPostBack)
			{
				tilte.Attributes["onkeydown"]="if (event.keyCode==13) { document.all.ImageButton2.click(); return false;}";
				this.Imagebutton5.Attributes.Add("onclick","javascript:return del();"); 			
				this.Imagebutton7.Attributes.Add("onclick","javascript:return zf();");

                Imagebutton9.Visible = FTD.Unit.PublicMethod.StrIFIn("|xiaoshou010|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian")); //�鿴
                Imagebutton4.Visible = FTD.Unit.PublicMethod.StrIFIn("|xiaoshou010M|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));//�޸�
                Imagebutton1.Visible = FTD.Unit.PublicMethod.StrIFIn("|xiaoshou010A|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));//���
                Imagebutton5.Visible = FTD.Unit.PublicMethod.StrIFIn("|xiaoshou010D|", FTD.Unit.PublicMethod.GetSessionValue("QuanXian"));//ɾ��
               
			}

            FTD.BLL.SellOrder bll = new FTD.BLL.SellOrder();
            string _sql = "";
			if(Request.QueryString["str"]!=null)
			{
                _sql = "title like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'  and Username='" + this.Session["username"] + "' ";				
			}			
            else
            {
                _sql = " Username='" + this.Session["username"] + "' ";			
            }
            DataSet ds = bll.GetList(_sql);
            if(ds != null)
            {
                DataTable dt = ds.Tables[0];
                Datagrid2.DataSource = dt;
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
			this.Imagebutton1.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton1_Click);

            this.Imagebutton7.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton7_Click);
            this.Imagebutton8.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton8_Click);
            this.Imagebutton6.Click += new System.Web.UI.ImageClickEventHandler(this.Imagebutton6_Click);
			this.ImageButton3.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton3_Click);
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
			Response.Redirect("SellOrder.aspx?str="+tilte.Text+"");
		}

		private void ImageButton3_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("main_1.aspx");
		}

		private void Imagebutton5_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{


				string    SQL_GetList_yj     =  "select * from MonthSet where  '"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) ";
				OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
				if(NewReader_yj.Read())
				{
					this.Response.Write("<script language=javascript>alert('�Ѿ�ִ���½�棬����ʧ��');</script>");
					return;


				}



				if(Datagrid2.SelectedItem.Cells[10].Text.ToString()=="ִ�����"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="ǿ��ֹͣ"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="����"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="������"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="�������" ||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="�ѵ���ⵥ"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="�ѵ��˻���")
				{
					this.Response.Write("<script language=javascript>alert('��ǰ״̬Ϊ["+Datagrid2.SelectedItem.Cells[10].Text.ToString()+"]�����ܽ���ɾ��');</script>");
					return;
				}
	
			
				string SQL_Del = "Delete from SellOrder where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
				List.ExeSql(SQL_Del);



				if(Request.QueryString["str"]!=null)
				{
					string SQL_GetList_xs    =  "select * from SellOrder where  tilte like '%"+Server.UrlDecode(Request.QueryString["str"])+"%'   order by id desc";
					Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
					Datagrid2.DataBind();

				}
				else
				{
					string SQL_GetList_xs    =  "select * from SellOrder order by id desc";
					Datagrid2.DataSource   = List.GetGrid_Pages(SQL_GetList_xs,"id");
					Datagrid2.DataBind();
				}

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('ɾ��ʧ�ܣ���ȷ���Ƿ�ѡ��ɾ����');</script>");
			}
		}

		private void Imagebutton4_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				string    SQL_GetList_yj     =  "select * from MonthSet where  '"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) ";
				OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
				if(NewReader_yj.Read())
				{
					this.Response.Write("<script language=javascript>alert('�Ѿ�ִ���½�棬����ʧ��');</script>");
					return;


				}
				if(Datagrid2.SelectedItem.Cells[10].Text.ToString()=="ִ�����"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="ǿ��ֹͣ"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="����"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="������"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="�������"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="�ѵ���ⵥ"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="�ѵ��˻���")
				{
					this.Response.Write("<script language=javascript>alert('��ǰ״̬Ϊ["+Datagrid2.SelectedItem.Cells[10].Text.ToString()+"]�����ܽ����޸�');</script>");

				}
				else
				{
					Response.Redirect("SellOrder_update.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");
				}

			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}

		private void Imagebutton9_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("SellOrder_show.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}

		private void Imagebutton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			Response.Redirect("SellOrder_insert.aspx");
		}


		private void Imagebutton7_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{
		
			
				string    SQL_GetList_yj     =  "select * from MonthSet where  '"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('"+Datagrid2.SelectedItem.Cells[11].Text.ToString()+"' as datetime),120) ";
				OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
				if(NewReader_yj.Read())
				{
					this.Response.Write("<script language=javascript>alert('�Ѿ�ִ���½�棬����ʧ��');</script>");
					return;


				}



				if(Datagrid2.SelectedItem.Cells[10].Text.ToString()=="ִ�����"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="ǿ��ֹͣ"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="����"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="�ѵ���ⵥ"||Datagrid2.SelectedItem.Cells[10].Text.ToString()=="�ѵ��˻���")
				{
			

					this.Response.Write("<script language=javascript>alert('����ʧ��!��ǰ״̬�Ѿ�Ϊ["+Datagrid2.SelectedItem.Cells[10].Text.ToString()+"]');</script>");
				}
				else
				{
					string SQL_Del = "update  SellOrder   set State='����' where id='"+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"'";
					
					List.ExeSql(SQL_Del);

					this.Response.Write("<script language=javascript>alert('�ύ�ɹ���״̬����Ϊ[����]');window.location.href='SellOrder.aspx'</script>");
				}


			

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}


		}

		private void Imagebutton8_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			try
			{

				Response.Redirect("SellOrder_gz.aspx?id="+Datagrid2.SelectedItem.Cells[1].Text.ToString()+"");

			}
			catch
			{
				this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
			}
		}
        private void Imagebutton6_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Response.Redirect("SellOrderLeading.aspx");
        }
        protected void Imagebutton4_Click1(object sender, ImageClickEventArgs e)
        {
            try
            {

              
                Response.Redirect("SellOrder_update.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");


            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
            }
        }

        protected void Imagebutton9_Click1(object sender, ImageClickEventArgs e)
        {
            try
            {

                Response.Redirect("SellOrder_show.aspx?id=" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "");

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('��ȷ���Ƿ�ѡ����');</script>");
            }
        }

        protected void Imagebutton5_Click1(object sender, ImageClickEventArgs e)
        {
            try
            {


                string SQL_GetList_yj = "select * from MonthSet where  '" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' between Starttime and  Endtime or convert(char(10),cast(Starttime as datetime),120)=convert(char(10),cast('" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' as datetime),120) or convert(char(10),cast(Endtime as datetime),120)=convert(char(10),cast('" + Datagrid2.SelectedItem.Cells[11].Text.ToString() + "' as datetime),120) ";
                OleDbDataReader NewReader_yj = List.GetList(SQL_GetList_yj);
                if (NewReader_yj.Read())
                {
                    this.Response.Write("<script language=javascript>alert('�Ѿ�ִ���½�棬����ʧ��');</script>");
                    return;


                }



                if (Datagrid2.SelectedItem.Cells[10].Text.ToString() == "ִ�����" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "ǿ��ֹͣ" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "����" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "������" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "�������" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "�ѵ���ⵥ" || Datagrid2.SelectedItem.Cells[10].Text.ToString() == "�ѵ��˻���")
                {
                    this.Response.Write("<script language=javascript>alert('��ǰ״̬Ϊ[" + Datagrid2.SelectedItem.Cells[10].Text.ToString() + "]�����ܽ���ɾ��');</script>");
                    return;
                }


                string SQL_Del = "Delete from SellOrder where id='" + Datagrid2.SelectedItem.Cells[1].Text.ToString() + "'";

                List.ExeSql(SQL_Del);



                if (Request.QueryString["str"] != null)
                {
                    string SQL_GetList_xs = "select * from SellOrder where  tilte like '%" + Server.UrlDecode(Request.QueryString["str"]) + "%'   order by id desc";
                    Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                    Datagrid2.DataBind();

                }
                else
                {
                    string SQL_GetList_xs = "select * from SellOrder order by id desc";
                    Datagrid2.DataSource = List.GetGrid_Pages(SQL_GetList_xs, "id");
                    Datagrid2.DataBind();
                }

            }
            catch
            {
                this.Response.Write("<script language=javascript>alert('ɾ��ʧ�ܣ���ȷ���Ƿ�ѡ��ɾ����');</script>");
            }
        }

	}
}

