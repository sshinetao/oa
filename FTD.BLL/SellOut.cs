using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类SellOut。
	/// </summary>
	[Serializable]
	public partial class SellOut
	{
		public SellOut()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _title;
		private DateTime? _shtime;
		private string _type;
		private string _storeroom;
		private string _companynumber;
		private string _companyname;
		private string _companyadd;
		private string _thpeople;
		private string _tel;
		private DateTime? _thstarttime;
		private DateTime? _thendtime;
		private string _stockpeonum;
		private string _stockpeoname;
		private string _traffictype;
		private string _remark;
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
		public DateTime? ShTime
		{
			set{ _shtime=value;}
			get{return _shtime;}
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
		public string Storeroom
		{
			set{ _storeroom=value;}
			get{return _storeroom;}
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
		public string ThPeople
		{
			set{ _thpeople=value;}
			get{return _thpeople;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ThStarttime
		{
			set{ _thstarttime=value;}
			get{return _thstarttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ThEndtime
		{
			set{ _thendtime=value;}
			get{return _thendtime;}
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
		public string TrafficType
		{
			set{ _traffictype=value;}
			get{return _traffictype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
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
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SellOut(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,number,title,ShTime,Type,Storeroom,CompanyNumber,CompanyName,CompanyAdd,ThPeople,Tel,ThStarttime,ThEndtime,StockPeoNum,StockPeoName,TrafficType,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes ");
			strSql.Append(" FROM [SellOut] ");
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
				if(ds.Tables[0].Rows[0]["ShTime"]!=null && ds.Tables[0].Rows[0]["ShTime"].ToString()!="")
				{
					this.ShTime=DateTime.Parse(ds.Tables[0].Rows[0]["ShTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Storeroom"]!=null)
				{
					this.Storeroom=ds.Tables[0].Rows[0]["Storeroom"].ToString();
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
				if(ds.Tables[0].Rows[0]["ThPeople"]!=null)
				{
					this.ThPeople=ds.Tables[0].Rows[0]["ThPeople"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null)
				{
					this.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ThStarttime"]!=null && ds.Tables[0].Rows[0]["ThStarttime"].ToString()!="")
				{
					this.ThStarttime=DateTime.Parse(ds.Tables[0].Rows[0]["ThStarttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ThEndtime"]!=null && ds.Tables[0].Rows[0]["ThEndtime"].ToString()!="")
				{
					this.ThEndtime=DateTime.Parse(ds.Tables[0].Rows[0]["ThEndtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["StockPeoNum"]!=null)
				{
					this.StockPeoNum=ds.Tables[0].Rows[0]["StockPeoNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoName"]!=null)
				{
					this.StockPeoName=ds.Tables[0].Rows[0]["StockPeoName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TrafficType"]!=null)
				{
					this.TrafficType=ds.Tables[0].Rows[0]["TrafficType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null)
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
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
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [SellOut]");
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
			strSql.Append("insert into [SellOut] (");
			strSql.Append("number,title,ShTime,Type,Storeroom,CompanyNumber,CompanyName,CompanyAdd,ThPeople,Tel,ThStarttime,ThEndtime,StockPeoNum,StockPeoName,TrafficType,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes)");
			strSql.Append(" values (");
			strSql.Append("@number,@title,@ShTime,@Type,@Storeroom,@CompanyNumber,@CompanyName,@CompanyAdd,@ThPeople,@Tel,@ThStarttime,@ThEndtime,@StockPeoNum,@StockPeoName,@TrafficType,@Remark,@State,@Username,@Realname,@Nowtimes,@StreamNumber,@StreamName,@Gusername,@Grealname,@Gname,@Sreakmart,@SPUsername,@SPRealname,@MyTimes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@ShTime", SqlDbType.DateTime),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Storeroom", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@ThPeople", SqlDbType.NVarChar,50),
					new SqlParameter("@Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@ThStarttime", SqlDbType.DateTime),
					new SqlParameter("@ThEndtime", SqlDbType.DateTime),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@TrafficType", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NText),
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
					new SqlParameter("@MyTimes", SqlDbType.DateTime)};
			parameters[0].Value = number;
			parameters[1].Value = title;
			parameters[2].Value = ShTime;
			parameters[3].Value = Type;
			parameters[4].Value = Storeroom;
			parameters[5].Value = CompanyNumber;
			parameters[6].Value = CompanyName;
			parameters[7].Value = CompanyAdd;
			parameters[8].Value = ThPeople;
			parameters[9].Value = Tel;
			parameters[10].Value = ThStarttime;
			parameters[11].Value = ThEndtime;
			parameters[12].Value = StockPeoNum;
			parameters[13].Value = StockPeoName;
			parameters[14].Value = TrafficType;
			parameters[15].Value = Remark;
			parameters[16].Value = State;
			parameters[17].Value = Username;
			parameters[18].Value = Realname;
			parameters[19].Value = Nowtimes;
			parameters[20].Value = StreamNumber;
			parameters[21].Value = StreamName;
			parameters[22].Value = Gusername;
			parameters[23].Value = Grealname;
			parameters[24].Value = Gname;
			parameters[25].Value = Sreakmart;
			parameters[26].Value = SPUsername;
			parameters[27].Value = SPRealname;
			parameters[28].Value = MyTimes;

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
			strSql.Append("update [SellOut] set ");
			strSql.Append("number=@number,");
			strSql.Append("title=@title,");
			strSql.Append("ShTime=@ShTime,");
			strSql.Append("Type=@Type,");
			strSql.Append("Storeroom=@Storeroom,");
			strSql.Append("CompanyNumber=@CompanyNumber,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyAdd=@CompanyAdd,");
			strSql.Append("ThPeople=@ThPeople,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("ThStarttime=@ThStarttime,");
			strSql.Append("ThEndtime=@ThEndtime,");
			strSql.Append("StockPeoNum=@StockPeoNum,");
			strSql.Append("StockPeoName=@StockPeoName,");
			strSql.Append("TrafficType=@TrafficType,");
			strSql.Append("Remark=@Remark,");
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
			strSql.Append("MyTimes=@MyTimes");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@ShTime", SqlDbType.DateTime),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Storeroom", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@ThPeople", SqlDbType.NVarChar,50),
					new SqlParameter("@Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@ThStarttime", SqlDbType.DateTime),
					new SqlParameter("@ThEndtime", SqlDbType.DateTime),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@TrafficType", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NText),
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
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = number;
			parameters[1].Value = title;
			parameters[2].Value = ShTime;
			parameters[3].Value = Type;
			parameters[4].Value = Storeroom;
			parameters[5].Value = CompanyNumber;
			parameters[6].Value = CompanyName;
			parameters[7].Value = CompanyAdd;
			parameters[8].Value = ThPeople;
			parameters[9].Value = Tel;
			parameters[10].Value = ThStarttime;
			parameters[11].Value = ThEndtime;
			parameters[12].Value = StockPeoNum;
			parameters[13].Value = StockPeoName;
			parameters[14].Value = TrafficType;
			parameters[15].Value = Remark;
			parameters[16].Value = State;
			parameters[17].Value = Username;
			parameters[18].Value = Realname;
			parameters[19].Value = Nowtimes;
			parameters[20].Value = StreamNumber;
			parameters[21].Value = StreamName;
			parameters[22].Value = Gusername;
			parameters[23].Value = Grealname;
			parameters[24].Value = Gname;
			parameters[25].Value = Sreakmart;
			parameters[26].Value = SPUsername;
			parameters[27].Value = SPRealname;
			parameters[28].Value = MyTimes;
			parameters[29].Value = Id;

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
			strSql.Append("delete from [SellOut] ");
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
			strSql.Append("select Id,number,title,ShTime,Type,Storeroom,CompanyNumber,CompanyName,CompanyAdd,ThPeople,Tel,ThStarttime,ThEndtime,StockPeoNum,StockPeoName,TrafficType,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,Gusername,Grealname,Gname,Sreakmart,SPUsername,SPRealname,MyTimes ");
			strSql.Append(" FROM [SellOut] ");
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
				if(ds.Tables[0].Rows[0]["ShTime"]!=null && ds.Tables[0].Rows[0]["ShTime"].ToString()!="")
				{
					this.ShTime=DateTime.Parse(ds.Tables[0].Rows[0]["ShTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Storeroom"]!=null )
				{
					this.Storeroom=ds.Tables[0].Rows[0]["Storeroom"].ToString();
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
				if(ds.Tables[0].Rows[0]["ThPeople"]!=null )
				{
					this.ThPeople=ds.Tables[0].Rows[0]["ThPeople"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null )
				{
					this.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ThStarttime"]!=null && ds.Tables[0].Rows[0]["ThStarttime"].ToString()!="")
				{
					this.ThStarttime=DateTime.Parse(ds.Tables[0].Rows[0]["ThStarttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ThEndtime"]!=null && ds.Tables[0].Rows[0]["ThEndtime"].ToString()!="")
				{
					this.ThEndtime=DateTime.Parse(ds.Tables[0].Rows[0]["ThEndtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["StockPeoNum"]!=null )
				{
					this.StockPeoNum=ds.Tables[0].Rows[0]["StockPeoNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoName"]!=null )
				{
					this.StockPeoName=ds.Tables[0].Rows[0]["StockPeoName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TrafficType"]!=null )
				{
					this.TrafficType=ds.Tables[0].Rows[0]["TrafficType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null )
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
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
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [SellOut] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

