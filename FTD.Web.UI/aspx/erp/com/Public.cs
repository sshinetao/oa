using System.IO;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Collections;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;

namespace qpsmartweb_jxc.Public
{
	// 此类实现对数据库操作的具体功能。
	public class Db : System.Web.UI.Page
	{

		public static DataView Config;
		public static DataView Board;
		public static string strConn = "";
	
		public  string DbPath()
		{

			strConn=""+ConfigurationSettings.AppSettings["connstr"].ToString()+";Provider=SQLOLEDB";


			return strConn;
		}


	
		public static string ConnectionString
		{
			get
			{
				Db ConnectionString=new Db();
				return ConnectionString.DbPath();
			}
		} 


	
		public OleDbDataReader GetList(string Sql) 
		{

			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbCommand myCommand = new OleDbCommand(Sql, myConnection);

			myConnection.Open();
			OleDbDataReader result = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
			return result;
		}


	
		public DataView GetGrid(string Sql,string Tb) 
		{

			DataSet DS;
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbDataAdapter myCommand = new OleDbDataAdapter(Sql, myConnection);
			DS = new DataSet();
			myCommand.Fill(DS, Tb);
			DataView result = DS.Tables[Tb].DefaultView;
			return result;
		}


	
		public DataView GetGrid_Pages(string Sql,string Sort) 
		{
			DataTable Cart = new DataTable();
			
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbDataAdapter myCommand   = new OleDbDataAdapter(Sql,myConnection);
			DataSet ds                   = new DataSet();
			myCommand.Fill(ds,"MyDt");
			Cart = ds.Tables["MyDt"];

			DataView CartView = new DataView(Cart);
			CartView.Sort = Sort + " Desc";

			return CartView;
		}

	
		public DataView GetGrid_Pages_asc(string Sql,string Sort) 
		{
			DataTable Cart = new DataTable();
			
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbDataAdapter myCommand   = new OleDbDataAdapter(Sql,myConnection);
			DataSet ds                   = new DataSet();
			myCommand.Fill(ds,"MyDt");
			Cart = ds.Tables["MyDt"];

			DataView CartView = new DataView(Cart);
			CartView.Sort = Sort + " asc";

			return CartView;
		}

	
		public DataView GetGrid_Pages_not(string Sql) 
		{
			DataTable Cart = new DataTable();
			
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbDataAdapter myCommand   = new OleDbDataAdapter(Sql,myConnection);
			DataSet ds                   = new DataSet();
			myCommand.Fill(ds,"MyDt");
			Cart = ds.Tables["MyDt"];

			DataView CartView = new DataView(Cart);
			//CartView.Sort = Sort + " asc";

			return CartView;

		}


	
		public int ExeSql(string Sql)
		{
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbCommand myCommand=new OleDbCommand(Sql,myConnection);	
			try
			{
				myConnection.Open();
				myCommand.ExecuteNonQuery();
				myCommand.Dispose();
				myConnection.Close();
				return 1;
			}
			catch
			{
				myConnection.Close();
				return 0;
			}
		}


	
		public int GetId(string Sql) 
		{
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbCommand myCommand = new OleDbCommand(Sql, myConnection);
			myConnection.Open();
			OleDbDataReader result = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
			int i=0;
			result.Read();
			i = result.GetInt32(0);
			result.Close();
			myCommand.Dispose();
			myConnection.Close();
			return i;
		}


	
		public  string GetStringValue(string Sql) 
		{
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbCommand myCommand = new OleDbCommand(Sql, myConnection);
			myConnection.Open();
			OleDbDataReader result = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
			string i;
			result.Read();
			i = result.GetString(0);
			result.Close();
			myCommand.Dispose();
			myConnection.Close();
			return i;
		}
		

	
		public decimal GetId_Dec(string Sql) 
		{
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbCommand myCommand = new OleDbCommand(Sql, myConnection);
			myConnection.Open();
			OleDbDataReader result = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
			decimal i=0;
			result.Read();
			i = result.GetDecimal(0);
			result.Close();
			myCommand.Dispose();
			myConnection.Close();
			return i;
		}


	
		public int GetCount(string Sql)
		{
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbCommand myCommand=new OleDbCommand(Sql,myConnection);
			
			myConnection.Open();
			OleDbDataReader result = myCommand.ExecuteReader();
			int i=0;
			while(result.Read())
			{
				i=result.GetInt32(0);
			}
			result.Close();
			myCommand.Dispose();
			myConnection.Close();
			return i;
		}


	
		public decimal GetCount_Decimal(string Sql)
		{
			OleDbConnection myConnection = new OleDbConnection(Db.ConnectionString);
			OleDbCommand myCommand=new OleDbCommand(Sql,myConnection);
			
			myConnection.Open();
			OleDbDataReader result = myCommand.ExecuteReader();
			decimal i=0;
			while(result.Read())
			{
				i=result.GetDecimal(0);
			}
			result.Close();
			myCommand.Dispose();
			myConnection.Close();
			return i;
		}
		
	}



	
	public class BindDrowDownList
	{
		Db List = new Db();

	
		public void Bind_DropDownList(System.Web.UI.WebControls.DropDownList MyDropDownList,string SQL,string DataValueField,string DataTextField)
		{
			string SQL_GetCode            = SQL;
			MyDropDownList.DataSource     = List.GetGrid(SQL_GetCode,"DataView");
			MyDropDownList.DataValueField = DataValueField;
			MyDropDownList.DataTextField  = DataTextField;
			MyDropDownList.DataBind();
			
			System.Web.UI.WebControls.ListItem Item = new ListItem();
			Item.Text  = "请选择";
			Item.Value = "请选择";
			MyDropDownList.Items.Insert(0,Item);
		}


		public void Bind_DropDownList_qb(System.Web.UI.WebControls.DropDownList MyDropDownList,string SQL,string DataValueField,string DataTextField)
		{
			string SQL_GetCode            = SQL;
			MyDropDownList.DataSource     = List.GetGrid(SQL_GetCode,"DataView");
			MyDropDownList.DataValueField = DataValueField;
			MyDropDownList.DataTextField  = DataTextField;
			MyDropDownList.DataBind();
			
			System.Web.UI.WebControls.ListItem Item = new ListItem();
			Item.Text  = "全部";
			Item.Value = "全部";
			MyDropDownList.Items.Insert(0,Item);
		}



		public void Bind_DropDownList_bh(System.Web.UI.WebControls.DropDownList MyDropDownList,string SQL,string DataValueField,string DataTextField)
		{
			string SQL_GetCode            = SQL;
			MyDropDownList.DataSource     = List.GetGrid(SQL_GetCode,"DataView");
			MyDropDownList.DataValueField = DataValueField;
			MyDropDownList.DataTextField  = DataTextField;
			MyDropDownList.DataBind();
			
			System.Web.UI.WebControls.ListItem Item = new ListItem();
			Item.Text  = "启始位置";
			Item.Value = "启始位置";
			MyDropDownList.Items.Insert(0,Item);
		}

		public void Bind_DropDownList_nothing(System.Web.UI.WebControls.DropDownList MyDropDownList,string SQL,string DataValueField,string DataTextField)
		{
			string SQL_GetCode            = SQL;
			MyDropDownList.DataSource     = List.GetGrid(SQL_GetCode,"DataView");
			MyDropDownList.DataValueField = DataValueField;
			MyDropDownList.DataTextField  = DataTextField;
			MyDropDownList.DataBind();
		
		}

//		public void Bind_DropDownList_ComboBox(Bestcomy.Web.UI.WebControls.ComboBox MyComboBox,string SQL,string DataValueField,string DataTextField)
//		{
//			string SQL_GetCode            = SQL;
//			MyComboBox.DataSource     = List.GetGrid(SQL_GetCode,"DataView");
//			MyComboBox.DataValueField = DataValueField;
//			MyComboBox.DataTextField  = DataTextField;
//			MyComboBox.DataBind();
//			
//			System.Web.UI.WebControls.ListItem Item = new ListItem();
//			Item.Text  = "请选择";
//			Item.Value = "请选择";
////			MyComboBox.Items.Insert(0,Item);
//		}



		public void Bind_DropDownList_ListBox(System.Web.UI.WebControls.ListBox MyDropDownList,string SQL,string DataValueField,string DataTextField)
		{
			string SQL_GetCode            = SQL;
			MyDropDownList.DataSource     = List.GetGrid(SQL_GetCode,"DataView");
			MyDropDownList.DataValueField = DataValueField;
			MyDropDownList.DataTextField  = DataTextField;
			MyDropDownList.DataBind();
			
		//	System.Web.UI.WebControls.ListItem Item = new ListItem();
//			Item.Text  = "";
//			Item.Value = "";
//			MyDropDownList.Items.Insert(0,Item);
		}


		public void Bind_DropDownList_CheckBoxList(System.Web.UI.WebControls.CheckBoxList MyDropDownList,string SQL,string DataValueField,string DataTextField)
		{
			string SQL_GetCode            = SQL;
			MyDropDownList.DataSource     = List.GetGrid(SQL_GetCode,"DataView");
			MyDropDownList.DataValueField = DataValueField;
			MyDropDownList.DataTextField  = DataTextField;
			MyDropDownList.DataBind();
		
		}


	

		public void Bind_DropDownList_1(System.Web.UI.WebControls.DropDownList MyDropDownList,string SQL,string DataValueField,string DataTextField)
		{
			string SQL_GetCode            = SQL;
			MyDropDownList.DataSource     = List.GetGrid(SQL_GetCode,"DataView");
			MyDropDownList.DataValueField = DataValueField;
			MyDropDownList.DataTextField  = DataTextField;
			MyDropDownList.DataBind();
			
			System.Web.UI.WebControls.ListItem Item = new ListItem();
			Item.Text  = "登陆至模块..";
			Item.Value = "0";
			MyDropDownList.Items.Insert(0,Item);
		}


	
		public void Bind_DropDownList_2(System.Web.UI.WebControls.DropDownList MyDropDownList,string SQL,string DataValueField,string DataTextField)
		{
			string SQL_GetCode            = SQL;
			MyDropDownList.DataSource     = List.GetGrid(SQL_GetCode,"DataView");
			MyDropDownList.DataValueField = DataValueField;
			MyDropDownList.DataTextField  = DataTextField;
			MyDropDownList.DataBind();
			
			System.Web.UI.WebControls.ListItem Item = new ListItem();
			Item.Text  = "行业类型";
			Item.Value = "0";
			MyDropDownList.Items.Insert(0,Item);
		}








	
		public void Bind_DropDownList_Year(System.Web.UI.WebControls.DropDownList MyDropDownList,int _Begin,int _End)
		{
			ArrayList myList = new ArrayList();
			//myList.Add ("----");

			for(int i=_Begin;i<=_End;i++) myList.Add (i.ToString());

			MyDropDownList.DataSource = myList;
			MyDropDownList.DataBind();
		}


	
		public void Bind_DropDownList_Month(System.Web.UI.WebControls.DropDownList MyDropDownList)
		{
			ArrayList myList = new ArrayList();
			//myList.Add ("----");

			for(int i=1;i<13;i++) myList.Add (i.ToString());

			MyDropDownList.DataSource = myList;
			MyDropDownList.DataBind();
		}
	

	
		public void Bind_DropDownList_Date(System.Web.UI.WebControls.DropDownList MyDropDownList)
		{
			ArrayList myList = new ArrayList();
			//myList.Add ("----");

			for(int i=1;i<32;i++) myList.Add (i.ToString());

			MyDropDownList.DataSource = myList;
			MyDropDownList.DataBind();
		}
	

	
		public void Bind_DropDownList_Hour(System.Web.UI.WebControls.DropDownList MyDropDownList)
		{
			ArrayList myList = new ArrayList();
			//myList.Add ("----");

			for(int i=0;i<24;i++) myList.Add (i.ToString());

			MyDropDownList.DataSource = myList;
			MyDropDownList.DataBind();
		}

	
		public void Bind_DropDownList_Mini(System.Web.UI.WebControls.DropDownList MyDropDownList)
		{
			ArrayList myList = new ArrayList();
			//myList.Add ("----");

			for(int i=0;i<60;i++) myList.Add (i.ToString());

			MyDropDownList.DataSource = myList;
			MyDropDownList.DataBind();
		}
	
		public void Bind_DropDownList_Sec(System.Web.UI.WebControls.DropDownList MyDropDownList)
		{
			ArrayList myList = new ArrayList();
			//myList.Add ("----");

			for(int i=0;i<60;i++) myList.Add (i.ToString());

			MyDropDownList.DataSource = myList;
			MyDropDownList.DataBind();
		}

	
		public void Bind_DropDownList_Age(System.Web.UI.WebControls.DropDownList MyDropDownList)
		{
			ArrayList myList = new ArrayList();
	        myList.Add ("[请选择年龄]");

			for(int i=20;i<50;i++) myList.Add (i.ToString());

			MyDropDownList.DataSource = myList;
			MyDropDownList.DataBind();
		}
	
		public void Bind_DropDownList_Sex(System.Web.UI.WebControls.DropDownList MyDropDownList)
		{
			System.Web.UI.WebControls.ListItem Item1 = new ListItem();
			System.Web.UI.WebControls.ListItem Item2 = new ListItem();
			System.Web.UI.WebControls.ListItem Item3 = new ListItem();

			Item1.Text  = "------------------------------------------------";
			Item1.Value = "----";
			Item2.Text  = "男";
			Item2.Value = "1";
			Item3.Text  = "女";
			Item3.Value = "0";

			MyDropDownList.Items.Add(Item1);
			MyDropDownList.Items.Add(Item2);
			MyDropDownList.Items.Add(Item3);
		}
	}


}
