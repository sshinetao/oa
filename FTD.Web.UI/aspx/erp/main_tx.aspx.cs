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
	/// main_tx ��ժҪ˵����
	/// </summary>
	public class main_tx : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label5;
		protected System.Web.UI.WebControls.TextBox btnSubmit;
		protected System.Web.UI.WebControls.Label Label6;
		protected System.Web.UI.WebControls.Label Label7;
		protected System.Web.UI.WebControls.Label Label8;
		protected System.Web.UI.WebControls.Label Label9;
		protected System.Web.UI.WebControls.Label Label10;
		protected System.Web.UI.WebControls.Label Label11;
		protected System.Web.UI.WebControls.Label Label12;
		protected System.Web.UI.WebControls.Label Label13;
		protected System.Web.UI.WebControls.Label Label14;
		protected System.Web.UI.WebControls.Label Label15;
		protected System.Web.UI.WebControls.Label Label16;
		protected System.Web.UI.WebControls.Label Label17;
		protected System.Web.UI.WebControls.Label Label18;
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();


//			if (!StrIFInStr("1000e", Session["perstr"].ToString()))
//			{
//			
//				Label1.Text=null;
//				
//			
//			}
//			else
//			{
				string    SQL_GetList_tx     =  "select count(*) as counts from nbdxx where (acceptusername='"+this.Session["userName"]+"' or acceptusername='"+this.Session["worknum"]+"') and sfck='��'";
				int alldelpoint_tx=List.GetCount(SQL_GetList_tx);
				Label1.Text=null;
				Label1.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='Systemnbdxx.aspx'  class='line_tx'>����<font color=red>"+alldelpoint_tx+"</font>������Ϣ</a></td></tr>";
//
//			}

			//�ɹ�����

			if (!StrIFInStr("1000d", Session["perstr"].ToString()))
			{
			
				Label2.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_gw     =  "select count(*) as counts from StockOrder  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��'  and State!='�������' and State!='������') ";
				int alldelpoint_gw=List.GetCount(SQL_GetList_gw);
				Label2.Text=null;
				Label2.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='StockOrder_sp.aspx' class='line_tx'>����<font color=red>"+alldelpoint_gw+"</font>���ɹ������ȴ�����</a></td></tr>";
			}





			//�ɹ����

			if (!StrIFInStr("1000f", Session["perstr"].ToString()))
			{
			
				Label6.Text=null;
				
			
			}
			else
			{
			
					
				string    SQL_GetList_gzjh     =  "select count(*) as counts from StockIncome  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��'  and State!='�������' and State!='������'  )  ";
				int alldelpoint_gzjh=List.GetCount(SQL_GetList_gzjh);
				Label6.Text=null;
				Label6.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='StockIncome_sp.aspx'  class='line_tx'>����<font color=red>"+alldelpoint_gzjh+"</font>���ɹ�����¼�ȴ�����</a></td></tr>";
				
			}
			




			//�ɹ��˻�

			if (!StrIFInStr("1000h", Session["perstr"].ToString()))
			{
			
				Label7.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_zzjh     =  "select count(*) as counts from StockOut where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��' and State!='�������'  and State!='������'  )  ";
				int alldelpoint_zzjh=List.GetCount(SQL_GetList_zzjh);
				Label7.Text=null;
				Label7.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='StockOut_sp.aspx'  class='line_tx'>����<font color=red>"+alldelpoint_zzjh+"</font>���ɹ��˻���¼�ȴ�����</a></td></tr>";

			}




			//�ɹ�����

			if (!StrIFInStr("1000j", Session["perstr"].ToString()))
			{
			
				Label8.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_sphys     =  "select count(*) as counts from StockOutMoney  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��' and State!='�������'   and State!='������'  )  ";
				int alldelpoint_sphys=List.GetCount(SQL_GetList_sphys);
				Label8.Text=null;
				Label8.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='StockOutMoney_sp.aspx'  class='line_tx'>����<font color=red>"+alldelpoint_sphys+"</font>���ɹ�����ȴ�����</a></td></tr>";

			}
//�ɹ�4��



			//���۶���

			if (!StrIFInStr("2000e", Session["perstr"].ToString()))
			{
			
				Label3.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_1     =  "select count(*) as counts from SellOrder where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��' and State!='�������' and State!='������'  ) ";
				int alldelpoint_1=List.GetCount(SQL_GetList_1);
				Label3.Text=null;
				Label3.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='SellOrder_sp.aspx' class='line_tx'>����<font color=red>"+alldelpoint_1+"</font>�����۶����ȴ���¼����</a></td></tr>";
			}





			//���۳���

			if (!StrIFInStr("2000h", Session["perstr"].ToString()))
			{
			
				Label4.Text=null;
				
			
			}
			else
			{
			
					
				string    SQL_GetList_2     =  "select count(*) as counts from SellOut where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��' and State!='�������'  and State!='������'  )  ";
				int alldelpoint_2=List.GetCount(SQL_GetList_2);
				Label4.Text=null;
				Label4.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='SellOut_sp.aspx'  class='line_tx'>����<font color=red>"+alldelpoint_2+"</font>�����۳����¼�ȴ�����</a></td></tr>";
				
			}
			




			//�����˻�

			if (!StrIFInStr("2000j", Session["perstr"].ToString()))
			{
			
				Label5.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_3     =  "select count(*) as counts from SellQuit where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��' and State!='�������'  and State!='������'  )  ";
				int alldelpoint_3=List.GetCount(SQL_GetList_3);
				Label5.Text=null;
				Label5.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='SellQuit_sp.aspx'  class='line_tx'>����<font color=red>"+alldelpoint_3+"</font>�������˻���¼�ȴ�����</a></td></tr>";

			}




			//�����տ�

			if (!StrIFInStr("2000l", Session["perstr"].ToString()))
			{
			
				Label9.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_4    =  "select count(*) as counts from SellInMoney where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��' and State!='�������' and State!='������'  )  ";
				int alldelpoint_4=List.GetCount(SQL_GetList_4);
				Label9.Text=null;
				Label9.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='SellInMoney_sp.aspx'  class='line_tx'>����<font color=red>"+alldelpoint_4+"</font>�������տ��¼�ȴ�����</a></td></tr>";

			}
			//����4��

	


			//���

			if (!StrIFInStr("3000f", Session["perstr"].ToString()))
			{
			
				Label10.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_5     =  "select count(*) as counts from IncomeRoom where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��' and State!='�������'  and State!='������'  )  ";
				int alldelpoint_5=List.GetCount(SQL_GetList_5);
				Label10.Text=null;
				Label10.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='IncomeRoom_sp.aspx'  class='line_tx'>����<font color=red>"+alldelpoint_5+"</font>������¼�ȴ�����</a></td></tr>";

			}




			//����

			if (!StrIFInStr("3000h", Session["perstr"].ToString()))
			{
			
				Label11.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_6   =  "select count(*) as counts from OutRoom where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='��������' and State!='����ͨ��' and State!='�������' and State!='������'   )  ";
				int alldelpoint_6=List.GetCount(SQL_GetList_6);
				Label11.Text=null;
				Label11.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='OutRoom_sp.aspx'  class='line_tx'>����<font color=red>"+alldelpoint_6+"</font>�������¼�ȴ�����</a></td></tr>";

			}
			//�ⷿ2��




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
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
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
