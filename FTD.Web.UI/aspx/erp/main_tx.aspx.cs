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
	/// main_tx 的摘要说明。
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
				string    SQL_GetList_tx     =  "select count(*) as counts from nbdxx where (acceptusername='"+this.Session["userName"]+"' or acceptusername='"+this.Session["worknum"]+"') and sfck='否'";
				int alldelpoint_tx=List.GetCount(SQL_GetList_tx);
				Label1.Text=null;
				Label1.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='Systemnbdxx.aspx'  class='line_tx'>您有<font color=red>"+alldelpoint_tx+"</font>条新消息</a></td></tr>";
//
//			}

			//采购订单

			if (!StrIFInStr("1000d", Session["perstr"].ToString()))
			{
			
				Label2.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_gw     =  "select count(*) as counts from StockOrder  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过'  and State!='驳回审核' and State!='完成审核') ";
				int alldelpoint_gw=List.GetCount(SQL_GetList_gw);
				Label2.Text=null;
				Label2.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='StockOrder_sp.aspx' class='line_tx'>您有<font color=red>"+alldelpoint_gw+"</font>条采购订单等待审批</a></td></tr>";
			}





			//采购入库

			if (!StrIFInStr("1000f", Session["perstr"].ToString()))
			{
			
				Label6.Text=null;
				
			
			}
			else
			{
			
					
				string    SQL_GetList_gzjh     =  "select count(*) as counts from StockIncome  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过'  and State!='驳回审核' and State!='完成审核'  )  ";
				int alldelpoint_gzjh=List.GetCount(SQL_GetList_gzjh);
				Label6.Text=null;
				Label6.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='StockIncome_sp.aspx'  class='line_tx'>您有<font color=red>"+alldelpoint_gzjh+"</font>条采购入库记录等待审批</a></td></tr>";
				
			}
			




			//采购退货

			if (!StrIFInStr("1000h", Session["perstr"].ToString()))
			{
			
				Label7.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_zzjh     =  "select count(*) as counts from StockOut where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' and State!='驳回审核'  and State!='完成审核'  )  ";
				int alldelpoint_zzjh=List.GetCount(SQL_GetList_zzjh);
				Label7.Text=null;
				Label7.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='StockOut_sp.aspx'  class='line_tx'>您有<font color=red>"+alldelpoint_zzjh+"</font>条采购退货记录等待审批</a></td></tr>";

			}




			//采购付款

			if (!StrIFInStr("1000j", Session["perstr"].ToString()))
			{
			
				Label8.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_sphys     =  "select count(*) as counts from StockOutMoney  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' and State!='驳回审核'   and State!='完成审核'  )  ";
				int alldelpoint_sphys=List.GetCount(SQL_GetList_sphys);
				Label8.Text=null;
				Label8.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='StockOutMoney_sp.aspx'  class='line_tx'>您有<font color=red>"+alldelpoint_sphys+"</font>条采购付款等待审批</a></td></tr>";

			}
//采购4个



			//销售订单

			if (!StrIFInStr("2000e", Session["perstr"].ToString()))
			{
			
				Label3.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_1     =  "select count(*) as counts from SellOrder where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' and State!='驳回审核' and State!='完成审核'  ) ";
				int alldelpoint_1=List.GetCount(SQL_GetList_1);
				Label3.Text=null;
				Label3.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='SellOrder_sp.aspx' class='line_tx'>您有<font color=red>"+alldelpoint_1+"</font>条销售订单等待记录审批</a></td></tr>";
			}





			//销售出库

			if (!StrIFInStr("2000h", Session["perstr"].ToString()))
			{
			
				Label4.Text=null;
				
			
			}
			else
			{
			
					
				string    SQL_GetList_2     =  "select count(*) as counts from SellOut where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' and State!='驳回审核'  and State!='完成审核'  )  ";
				int alldelpoint_2=List.GetCount(SQL_GetList_2);
				Label4.Text=null;
				Label4.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='SellOut_sp.aspx'  class='line_tx'>您有<font color=red>"+alldelpoint_2+"</font>条销售出库记录等待审批</a></td></tr>";
				
			}
			




			//销售退货

			if (!StrIFInStr("2000j", Session["perstr"].ToString()))
			{
			
				Label5.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_3     =  "select count(*) as counts from SellQuit where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' and State!='驳回审核'  and State!='完成审核'  )  ";
				int alldelpoint_3=List.GetCount(SQL_GetList_3);
				Label5.Text=null;
				Label5.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='SellQuit_sp.aspx'  class='line_tx'>您有<font color=red>"+alldelpoint_3+"</font>条销售退货记录等待审批</a></td></tr>";

			}




			//销售收款

			if (!StrIFInStr("2000l", Session["perstr"].ToString()))
			{
			
				Label9.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_4    =  "select count(*) as counts from SellInMoney where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' and State!='驳回审核' and State!='完成审核'  )  ";
				int alldelpoint_4=List.GetCount(SQL_GetList_4);
				Label9.Text=null;
				Label9.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='SellInMoney_sp.aspx'  class='line_tx'>您有<font color=red>"+alldelpoint_4+"</font>条销售收款记录等待审批</a></td></tr>";

			}
			//销售4个

	


			//入库

			if (!StrIFInStr("3000f", Session["perstr"].ToString()))
			{
			
				Label10.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_5     =  "select count(*) as counts from IncomeRoom where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' and State!='驳回审核'  and State!='完成审核'  )  ";
				int alldelpoint_5=List.GetCount(SQL_GetList_5);
				Label10.Text=null;
				Label10.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='IncomeRoom_sp.aspx'  class='line_tx'>您有<font color=red>"+alldelpoint_5+"</font>条入库记录等待审批</a></td></tr>";

			}




			//出库

			if (!StrIFInStr("3000h", Session["perstr"].ToString()))
			{
			
				Label11.Text=null;
				
			
			}
			else
			{
				string    SQL_GetList_6   =  "select count(*) as counts from OutRoom where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' and State!='驳回审核' and State!='完成审核'   )  ";
				int alldelpoint_6=List.GetCount(SQL_GetList_6);
				Label11.Text=null;
				Label11.Text+="<tr bgColor=#f3f8fe><td align=center><a href=javascript:void(0) onclick=window.parent.opener.rform.location='OutRoom_sp.aspx'  class='line_tx'>您有<font color=red>"+alldelpoint_6+"</font>条出库记录等待审批</a></td></tr>";

			}
			//库房2个




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
