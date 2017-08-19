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
	/// main_tx_ajax 的摘要说明。
	/// </summary>
	public class main_tx_ajax : System.Web.UI.Page
	{
		Db List=new Db();
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();


			string    SQL_GetList_tx     =  "select count(*) as counts from nbdxx where (acceptusername='"+this.Session["userName"]+"' or acceptusername='"+this.Session["worknum"]+"')  and sfck='否'";
			int alldelpoint_tx=List.GetCount(SQL_GetList_tx);
			
			string    SQL_GetList_cglx     =  "select count(*) as counts from StockOrder  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' ) ";
			int alldelpoint_cglx=List.GetCount(SQL_GetList_cglx);
			
			string    SQL_GetList_hgsq     =  "select count(*) as counts from StockIncome  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' )  ";
			int alldelpoint_hgsq=List.GetCount(SQL_GetList_hgsq);
		
			string    SQL_GetList_hgywjg    =  "select count(*) as counts from StockOut  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' )  ";
			int alldelpoint_hgywjg=List.GetCount(SQL_GetList_hgywjg);


			string    SQL_GetList_qgsq    =  "select count(*) as counts from StockOutMoney  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' )  ";
			int alldelpoint_qgsq=List.GetCount(SQL_GetList_qgsq);

//4个采购

			string    SQL_GetList_1     =  "select count(*) as counts from SellOrder  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' ) ";
			int alldelpoint_1=List.GetCount(SQL_GetList_1);
			
			string    SQL_GetList_2     =  "select count(*) as counts from SellOut where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' )  ";
			int alldelpoint_2=List.GetCount(SQL_GetList_2);
		
			string    SQL_GetList_3   =  "select count(*) as counts from SellQuit  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' )  ";
			int alldelpoint_3=List.GetCount(SQL_GetList_3);


			string    SQL_GetList_4   =  "select count(*) as counts from SellInMoney  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' )  ";
			int alldelpoint_4=List.GetCount(SQL_GetList_4);

			//4个销售


			string    SQL_GetList_5     =  "select count(*) as counts from IncomeRoom  where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' ) ";
			int alldelpoint_5=List.GetCount(SQL_GetList_5);
			
			string    SQL_GetList_6     =  "select count(*) as counts from OutRoom where  CHARINDEX('"+this.Session["username"]+"',Gusername ) > 0   and (State!='审批驳回' and State!='审批通过' )  ";
			int alldelpoint_6=List.GetCount(SQL_GetList_6);
		
		

			//2个库


			int all=alldelpoint_tx+alldelpoint_cglx+alldelpoint_hgsq+alldelpoint_hgywjg+alldelpoint_qgsq+alldelpoint_1+alldelpoint_2+alldelpoint_3+alldelpoint_4+alldelpoint_5+alldelpoint_6;
			
			if(all>0)
			{
				Response.Write("1");
				
			}
			else
			{
				Response.Write("0");
			}
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
	}
}
