using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类StockOutMoney_Order。
	/// </summary>
	[Serializable]
	public partial class StockOutMoney_Order
	{
		public StockOutMoney_Order()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _title;
		private string _type;
		private string _nbnumber;
		private DateTime? _qdtime;
		private string _orderremark;
		private string _orderadd;
		private string _lxadd;
		private string _storeroom;
		private DateTime? _shtime;
		private string _companynumber;
		private string _companyname;
		private string _companyadd;
		private string _unit;
		private string _stockpeonum;
		private string _stockpeoname;
		private decimal? _allmoney;
		private decimal? _yfmoney;
		private string _state;
		private string _username;
		private string _realname;
		private DateTime? _nowtimes;
		private string _streamnumber;
		private string _streamname;
		private string _gusername;
		private string _grealname;
		private string _gname;
		private string _sreakmart;
		private string _spusername;
		private string _sprealname;
		private DateTime? _mytimes;
		private string _ifopen;
		/// <summary>
		/// 
		/// </summary>
		public long Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NbNumber
		{
			set{ _nbnumber=value;}
			get{return _nbnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? QdTime
		{
			set{ _qdtime=value;}
			get{return _qdtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderRemark
		{
			set{ _orderremark=value;}
			get{return _orderremark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderAdd
		{
			set{ _orderadd=value;}
			get{return _orderadd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LxAdd
		{
			set{ _lxadd=value;}
			get{return _lxadd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Storeroom
		{
			set{ _storeroom=value;}
			get{return _storeroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ShTime
		{
			set{ _shtime=value;}
			get{return _shtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyNumber
		{
			set{ _companynumber=value;}
			get{return _companynumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyAdd
		{
			set{ _companyadd=value;}
			get{return _companyadd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StockPeoNum
		{
			set{ _stockpeonum=value;}
			get{return _stockpeonum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StockPeoName
		{
			set{ _stockpeoname=value;}
			get{return _stockpeoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AllMoney
		{
			set{ _allmoney=value;}
			get{return _allmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? YfMoney
		{
			set{ _yfmoney=value;}
			get{return _yfmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Realname
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Nowtimes
		{
			set{ _nowtimes=value;}
			get{return _nowtimes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StreamNumber
		{
			set{ _streamnumber=value;}
			get{return _streamnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StreamName
		{
			set{ _streamname=value;}
			get{return _streamname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Gusername
		{
			set{ _gusername=value;}
			get{return _gusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Grealname
		{
			set{ _grealname=value;}
			get{return _grealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Gname
		{
			set{ _gname=value;}
			get{return _gname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sreakmart
		{
			set{ _sreakmart=value;}
			get{return _sreakmart;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPUsername
		{
			set{ _spusername=value;}
			get{return _spusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPRealname
		{
			set{ _sprealname=value;}
			get{return _sprealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MyTimes
		{
			set{ _mytimes=value;}
			get{return _mytimes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ifopen
		{
			set{ _ifopen=value;}
			get{return _ifopen;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public StockOutMoney_Order(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes,Ifopen ");
			strSql.Append(" FROM [StockOutMoney_Order] ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["Id"].ToString() != "") { this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()); }
				if(ds.Tables[0].Rows[0]["number"]!=null)
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
				}
				if(ds.Tables[0].Rows[0]["title"]!=null)
				{
					this.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NbNumber"]!=null)
				{
					this.NbNumber=ds.Tables[0].Rows[0]["NbNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QdTime"]!=null && ds.Tables[0].Rows[0]["QdTime"].ToString()!="")
				{
					this.QdTime=DateTime.Parse(ds.Tables[0].Rows[0]["QdTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OrderRemark"]!=null)
				{
					this.OrderRemark=ds.Tables[0].Rows[0]["OrderRemark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["OrderAdd"]!=null)
				{
					this.OrderAdd=ds.Tables[0].Rows[0]["OrderAdd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LxAdd"]!=null)
				{
					this.LxAdd=ds.Tables[0].Rows[0]["LxAdd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Storeroom"]!=null)
				{
					this.Storeroom=ds.Tables[0].Rows[0]["Storeroom"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ShTime"]!=null && ds.Tables[0].Rows[0]["ShTime"].ToString()!="")
				{
					this.ShTime=DateTime.Parse(ds.Tables[0].Rows[0]["ShTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CompanyNumber"]!=null)
				{
					this.CompanyNumber=ds.Tables[0].Rows[0]["CompanyNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyName"]!=null)
				{
					this.CompanyName=ds.Tables[0].Rows[0]["CompanyName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyAdd"]!=null)
				{
					this.CompanyAdd=ds.Tables[0].Rows[0]["CompanyAdd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Unit"]!=null)
				{
					this.Unit=ds.Tables[0].Rows[0]["Unit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoNum"]!=null)
				{
					this.StockPeoNum=ds.Tables[0].Rows[0]["StockPeoNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoName"]!=null)
				{
					this.StockPeoName=ds.Tables[0].Rows[0]["StockPeoName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["AllMoney"]!=null && ds.Tables[0].Rows[0]["AllMoney"].ToString()!="")
				{
					this.AllMoney=decimal.Parse(ds.Tables[0].Rows[0]["AllMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YfMoney"]!=null && ds.Tables[0].Rows[0]["YfMoney"].ToString()!="")
				{
					this.YfMoney=decimal.Parse(ds.Tables[0].Rows[0]["YfMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null)
				{
					this.State=ds.Tables[0].Rows[0]["State"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Username"]!=null)
				{
					this.Username=ds.Tables[0].Rows[0]["Username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Realname"]!=null)
				{
					this.Realname=ds.Tables[0].Rows[0]["Realname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Nowtimes"]!=null && ds.Tables[0].Rows[0]["Nowtimes"].ToString()!="")
				{
					this.Nowtimes=DateTime.Parse(ds.Tables[0].Rows[0]["Nowtimes"].ToString());
				}
				if(ds.Tables[0].Rows[0]["StreamNumber"]!=null)
				{
					this.StreamNumber=ds.Tables[0].Rows[0]["StreamNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StreamName"]!=null)
				{
					this.StreamName=ds.Tables[0].Rows[0]["StreamName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Gusername"]!=null)
				{
					this.Gusername=ds.Tables[0].Rows[0]["Gusername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Grealname"]!=null)
				{
					this.Grealname=ds.Tables[0].Rows[0]["Grealname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Gname"]!=null)
				{
					this.Gname=ds.Tables[0].Rows[0]["Gname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Sreakmart"]!=null)
				{
					this.Sreakmart=ds.Tables[0].Rows[0]["Sreakmart"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SPUsername"]!=null)
				{
					this.SPUsername=ds.Tables[0].Rows[0]["SPUsername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SPRealname"]!=null)
				{
					this.SPRealname=ds.Tables[0].Rows[0]["SPRealname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MyTimes"]!=null && ds.Tables[0].Rows[0]["MyTimes"].ToString()!="")
				{
					this.MyTimes=DateTime.Parse(ds.Tables[0].Rows[0]["MyTimes"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Ifopen"]!=null)
				{
					this.Ifopen=ds.Tables[0].Rows[0]["Ifopen"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [StockOutMoney_Order]");
			strSql.Append(" where Id=@Id ");

			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [StockOutMoney_Order] (");
			strSql.Append("number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes,Ifopen)");
			strSql.Append(" values (");
			strSql.Append("@number,@title,@Type,@NbNumber,@QdTime,@OrderRemark,@OrderAdd,@LxAdd,@Storeroom,@ShTime,@CompanyNumber,@CompanyName,@CompanyAdd,@Unit,@StockPeoNum,@StockPeoName,@AllMoney,@YfMoney,@State,@Username,@Realname,@Nowtimes,@StreamNumber,@StreamName,@Gusername,@Grealname,@Gname,@Sreakmart,@SPUsername,@SPRealname,@MyTimes,@Ifopen)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,3000),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@NbNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@QdTime", SqlDbType.DateTime),
					new SqlParameter("@OrderRemark", SqlDbType.NText),
					new SqlParameter("@OrderAdd", SqlDbType.NVarChar,4000),
					new SqlParameter("@LxAdd", SqlDbType.NVarChar,4000),
					new SqlParameter("@Storeroom", SqlDbType.NVarChar,50),
					new SqlParameter("@ShTime", SqlDbType.DateTime),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,4000),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@AllMoney", SqlDbType.Decimal,9),
					new SqlParameter("@YfMoney", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@StreamNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@StreamName", SqlDbType.NVarChar,50),
					new SqlParameter("@Gusername", SqlDbType.NVarChar,50),
					new SqlParameter("@Grealname", SqlDbType.NVarChar,50),
					new SqlParameter("@Gname", SqlDbType.NVarChar,50),
					new SqlParameter("@Sreakmart", SqlDbType.NText),
					new SqlParameter("@SPUsername", SqlDbType.NVarChar,4000),
					new SqlParameter("@SPRealname", SqlDbType.NVarChar,4000),
					new SqlParameter("@MyTimes", SqlDbType.DateTime),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50)};
			parameters[0].Value = number;
			parameters[1].Value = title;
			parameters[2].Value = Type;
			parameters[3].Value = NbNumber;
			parameters[4].Value = QdTime;
			parameters[5].Value = OrderRemark;
			parameters[6].Value = OrderAdd;
			parameters[7].Value = LxAdd;
			parameters[8].Value = Storeroom;
			parameters[9].Value = ShTime;
			parameters[10].Value = CompanyNumber;
			parameters[11].Value = CompanyName;
			parameters[12].Value = CompanyAdd;
			parameters[13].Value = Unit;
			parameters[14].Value = StockPeoNum;
			parameters[15].Value = StockPeoName;
			parameters[16].Value = AllMoney;
			parameters[17].Value = YfMoney;
			parameters[18].Value = State;
			parameters[19].Value = Username;
			parameters[20].Value = Realname;
			parameters[21].Value = Nowtimes;
			parameters[22].Value = StreamNumber;
			parameters[23].Value = StreamName;
			parameters[24].Value = Gusername;
			parameters[25].Value = Grealname;
			parameters[26].Value = Gname;
			parameters[27].Value = Sreakmart;
			parameters[28].Value = SPUsername;
			parameters[29].Value = SPRealname;
			parameters[30].Value = MyTimes;
			parameters[31].Value = Ifopen;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [StockOutMoney_Order] set ");
			strSql.Append("number=@number,");
			strSql.Append("title=@title,");
			strSql.Append("Type=@Type,");
			strSql.Append("NbNumber=@NbNumber,");
			strSql.Append("QdTime=@QdTime,");
			strSql.Append("OrderRemark=@OrderRemark,");
			strSql.Append("OrderAdd=@OrderAdd,");
			strSql.Append("LxAdd=@LxAdd,");
			strSql.Append("Storeroom=@Storeroom,");
			strSql.Append("ShTime=@ShTime,");
			strSql.Append("CompanyNumber=@CompanyNumber,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyAdd=@CompanyAdd,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("StockPeoNum=@StockPeoNum,");
			strSql.Append("StockPeoName=@StockPeoName,");
			strSql.Append("AllMoney=@AllMoney,");
			strSql.Append("YfMoney=@YfMoney,");
			strSql.Append("State=@State,");
			strSql.Append("Username=@Username,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Nowtimes=@Nowtimes,");
			strSql.Append("StreamNumber=@StreamNumber,");
			strSql.Append("StreamName=@StreamName,");
			strSql.Append("Gusername=@Gusername,");
			strSql.Append("Grealname=@Grealname,");
			strSql.Append("Gname=@Gname,");
			strSql.Append("Sreakmart=@Sreakmart,");
			strSql.Append("SPUsername=@SPUsername,");
			strSql.Append("SPRealname=@SPRealname,");
			strSql.Append("MyTimes=@MyTimes,");
			strSql.Append("Ifopen=@Ifopen");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,3000),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@NbNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@QdTime", SqlDbType.DateTime),
					new SqlParameter("@OrderRemark", SqlDbType.NText),
					new SqlParameter("@OrderAdd", SqlDbType.NVarChar,4000),
					new SqlParameter("@LxAdd", SqlDbType.NVarChar,4000),
					new SqlParameter("@Storeroom", SqlDbType.NVarChar,50),
					new SqlParameter("@ShTime", SqlDbType.DateTime),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,4000),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@AllMoney", SqlDbType.Decimal,9),
					new SqlParameter("@YfMoney", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@StreamNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@StreamName", SqlDbType.NVarChar,50),
					new SqlParameter("@Gusername", SqlDbType.NVarChar,50),
					new SqlParameter("@Grealname", SqlDbType.NVarChar,50),
					new SqlParameter("@Gname", SqlDbType.NVarChar,50),
					new SqlParameter("@Sreakmart", SqlDbType.NText),
					new SqlParameter("@SPUsername", SqlDbType.NVarChar,4000),
					new SqlParameter("@SPRealname", SqlDbType.NVarChar,4000),
					new SqlParameter("@MyTimes", SqlDbType.DateTime),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = number;
			parameters[1].Value = title;
			parameters[2].Value = Type;
			parameters[3].Value = NbNumber;
			parameters[4].Value = QdTime;
			parameters[5].Value = OrderRemark;
			parameters[6].Value = OrderAdd;
			parameters[7].Value = LxAdd;
			parameters[8].Value = Storeroom;
			parameters[9].Value = ShTime;
			parameters[10].Value = CompanyNumber;
			parameters[11].Value = CompanyName;
			parameters[12].Value = CompanyAdd;
			parameters[13].Value = Unit;
			parameters[14].Value = StockPeoNum;
			parameters[15].Value = StockPeoName;
			parameters[16].Value = AllMoney;
			parameters[17].Value = YfMoney;
			parameters[18].Value = State;
			parameters[19].Value = Username;
			parameters[20].Value = Realname;
			parameters[21].Value = Nowtimes;
			parameters[22].Value = StreamNumber;
			parameters[23].Value = StreamName;
			parameters[24].Value = Gusername;
			parameters[25].Value = Grealname;
			parameters[26].Value = Gname;
			parameters[27].Value = Sreakmart;
			parameters[28].Value = SPUsername;
			parameters[29].Value = SPRealname;
			parameters[30].Value = MyTimes;
			parameters[31].Value = Ifopen;
			parameters[32].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [StockOutMoney_Order] ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,number,title,Type,NbNumber,QdTime,OrderRemark,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,AllMoney,YfMoney,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes,Ifopen ");
			strSql.Append(" FROM [StockOutMoney_Order] ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					this.Id=long.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["number"]!=null )
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
				}
				if(ds.Tables[0].Rows[0]["title"]!=null )
				{
					this.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NbNumber"]!=null )
				{
					this.NbNumber=ds.Tables[0].Rows[0]["NbNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QdTime"]!=null && ds.Tables[0].Rows[0]["QdTime"].ToString()!="")
				{
					this.QdTime=DateTime.Parse(ds.Tables[0].Rows[0]["QdTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OrderRemark"]!=null )
				{
					this.OrderRemark=ds.Tables[0].Rows[0]["OrderRemark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["OrderAdd"]!=null )
				{
					this.OrderAdd=ds.Tables[0].Rows[0]["OrderAdd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LxAdd"]!=null )
				{
					this.LxAdd=ds.Tables[0].Rows[0]["LxAdd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Storeroom"]!=null )
				{
					this.Storeroom=ds.Tables[0].Rows[0]["Storeroom"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ShTime"]!=null && ds.Tables[0].Rows[0]["ShTime"].ToString()!="")
				{
					this.ShTime=DateTime.Parse(ds.Tables[0].Rows[0]["ShTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CompanyNumber"]!=null )
				{
					this.CompanyNumber=ds.Tables[0].Rows[0]["CompanyNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyName"]!=null )
				{
					this.CompanyName=ds.Tables[0].Rows[0]["CompanyName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyAdd"]!=null )
				{
					this.CompanyAdd=ds.Tables[0].Rows[0]["CompanyAdd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Unit"]!=null )
				{
					this.Unit=ds.Tables[0].Rows[0]["Unit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoNum"]!=null )
				{
					this.StockPeoNum=ds.Tables[0].Rows[0]["StockPeoNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoName"]!=null )
				{
					this.StockPeoName=ds.Tables[0].Rows[0]["StockPeoName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["AllMoney"]!=null && ds.Tables[0].Rows[0]["AllMoney"].ToString()!="")
				{
					this.AllMoney=decimal.Parse(ds.Tables[0].Rows[0]["AllMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YfMoney"]!=null && ds.Tables[0].Rows[0]["YfMoney"].ToString()!="")
				{
					this.YfMoney=decimal.Parse(ds.Tables[0].Rows[0]["YfMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null )
				{
					this.State=ds.Tables[0].Rows[0]["State"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Username"]!=null )
				{
					this.Username=ds.Tables[0].Rows[0]["Username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Realname"]!=null )
				{
					this.Realname=ds.Tables[0].Rows[0]["Realname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Nowtimes"]!=null && ds.Tables[0].Rows[0]["Nowtimes"].ToString()!="")
				{
					this.Nowtimes=DateTime.Parse(ds.Tables[0].Rows[0]["Nowtimes"].ToString());
				}
				if(ds.Tables[0].Rows[0]["StreamNumber"]!=null )
				{
					this.StreamNumber=ds.Tables[0].Rows[0]["StreamNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StreamName"]!=null )
				{
					this.StreamName=ds.Tables[0].Rows[0]["StreamName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Gusername"]!=null )
				{
					this.Gusername=ds.Tables[0].Rows[0]["Gusername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Grealname"]!=null )
				{
					this.Grealname=ds.Tables[0].Rows[0]["Grealname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Gname"]!=null )
				{
					this.Gname=ds.Tables[0].Rows[0]["Gname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Sreakmart"]!=null )
				{
					this.Sreakmart=ds.Tables[0].Rows[0]["Sreakmart"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SPUsername"]!=null )
				{
					this.SPUsername=ds.Tables[0].Rows[0]["SPUsername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SPRealname"]!=null )
				{
					this.SPRealname=ds.Tables[0].Rows[0]["SPRealname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MyTimes"]!=null && ds.Tables[0].Rows[0]["MyTimes"].ToString()!="")
				{
					this.MyTimes=DateTime.Parse(ds.Tables[0].Rows[0]["MyTimes"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Ifopen"]!=null )
				{
					this.Ifopen=ds.Tables[0].Rows[0]["Ifopen"].ToString();
				}
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [StockOutMoney_Order] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

