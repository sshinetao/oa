using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类StockOutMoney_sp。
	/// </summary>
	[Serializable]
	public partial class StockOutMoney_sp
	{
		public StockOutMoney_sp()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _title;
		private string _nbnumber;
		private string _type;
		private decimal? _allmoney;
		private DateTime? _outtime;
		private string _incomeset;
		private decimal? _fkmoney;
		private decimal? _symoney;
		private string _invoicetype;
		private string _companynumber;
		private string _companyname;
		private string _jbpeonum;
		private string _jbname;
		private string _state;
		private string _username;
		private string _realname;
		private string _nowtimes;
		private string _streamnumber;
		private string _streamname;
		private string _spcz;
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
		public string NbNumber
		{
			set{ _nbnumber=value;}
			get{return _nbnumber;}
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
		public decimal? Allmoney
		{
			set{ _allmoney=value;}
			get{return _allmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Outtime
		{
			set{ _outtime=value;}
			get{return _outtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IncomeSet
		{
			set{ _incomeset=value;}
			get{return _incomeset;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? FkMoney
		{
			set{ _fkmoney=value;}
			get{return _fkmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SyMoney
		{
			set{ _symoney=value;}
			get{return _symoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvoiceType
		{
			set{ _invoicetype=value;}
			get{return _invoicetype;}
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
		public string JbPeoNum
		{
			set{ _jbpeonum=value;}
			get{return _jbpeonum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JbName
		{
			set{ _jbname=value;}
			get{return _jbname;}
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
		public string Nowtimes
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
		public string SpCz
		{
			set{ _spcz=value;}
			get{return _spcz;}
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
		public string Spusername
		{
			set{ _spusername=value;}
			get{return _spusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sprealname
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
		public StockOutMoney_sp(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,number,title,NbNumber,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes ");
			strSql.Append(" FROM [StockOutMoney_sp] ");
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
				if(ds.Tables[0].Rows[0]["NbNumber"]!=null)
				{
					this.NbNumber=ds.Tables[0].Rows[0]["NbNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Allmoney"]!=null && ds.Tables[0].Rows[0]["Allmoney"].ToString()!="")
				{
					this.Allmoney=decimal.Parse(ds.Tables[0].Rows[0]["Allmoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Outtime"]!=null && ds.Tables[0].Rows[0]["Outtime"].ToString()!="")
				{
					this.Outtime=DateTime.Parse(ds.Tables[0].Rows[0]["Outtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IncomeSet"]!=null)
				{
					this.IncomeSet=ds.Tables[0].Rows[0]["IncomeSet"].ToString();
				}
				if(ds.Tables[0].Rows[0]["FkMoney"]!=null && ds.Tables[0].Rows[0]["FkMoney"].ToString()!="")
				{
					this.FkMoney=decimal.Parse(ds.Tables[0].Rows[0]["FkMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SyMoney"]!=null && ds.Tables[0].Rows[0]["SyMoney"].ToString()!="")
				{
					this.SyMoney=decimal.Parse(ds.Tables[0].Rows[0]["SyMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["InvoiceType"]!=null)
				{
					this.InvoiceType=ds.Tables[0].Rows[0]["InvoiceType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyNumber"]!=null)
				{
					this.CompanyNumber=ds.Tables[0].Rows[0]["CompanyNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyName"]!=null)
				{
					this.CompanyName=ds.Tables[0].Rows[0]["CompanyName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["JbPeoNum"]!=null)
				{
					this.JbPeoNum=ds.Tables[0].Rows[0]["JbPeoNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["JbName"]!=null)
				{
					this.JbName=ds.Tables[0].Rows[0]["JbName"].ToString();
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
				if(ds.Tables[0].Rows[0]["Nowtimes"]!=null)
				{
					this.Nowtimes=ds.Tables[0].Rows[0]["Nowtimes"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StreamNumber"]!=null)
				{
					this.StreamNumber=ds.Tables[0].Rows[0]["StreamNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StreamName"]!=null)
				{
					this.StreamName=ds.Tables[0].Rows[0]["StreamName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SpCz"]!=null)
				{
					this.SpCz=ds.Tables[0].Rows[0]["SpCz"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Sreakmart"]!=null)
				{
					this.Sreakmart=ds.Tables[0].Rows[0]["Sreakmart"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Spusername"]!=null)
				{
					this.Spusername=ds.Tables[0].Rows[0]["Spusername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Sprealname"]!=null)
				{
					this.Sprealname=ds.Tables[0].Rows[0]["Sprealname"].ToString();
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
			strSql.Append("select count(1) from [StockOutMoney_sp]");
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
			strSql.Append("insert into [StockOutMoney_sp] (");
			strSql.Append("number,title,NbNumber,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes)");
			strSql.Append(" values (");
			strSql.Append("@number,@title,@NbNumber,@Type,@Allmoney,@Outtime,@IncomeSet,@FkMoney,@SyMoney,@InvoiceType,@CompanyNumber,@CompanyName,@JbPeoNum,@JbName,@State,@Username,@Realname,@Nowtimes,@StreamNumber,@StreamName,@SpCz,@Sreakmart,@Spusername,@Sprealname,@MyTimes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@NbNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@Outtime", SqlDbType.DateTime),
					new SqlParameter("@IncomeSet", SqlDbType.NVarChar,50),
					new SqlParameter("@FkMoney", SqlDbType.Decimal,9),
					new SqlParameter("@SyMoney", SqlDbType.Decimal,9),
					new SqlParameter("@InvoiceType", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@JbPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@JbName", SqlDbType.NVarChar,50),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.NVarChar,50),
					new SqlParameter("@StreamNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@StreamName", SqlDbType.NVarChar,50),
					new SqlParameter("@SpCz", SqlDbType.NVarChar,50),
					new SqlParameter("@Sreakmart", SqlDbType.NText),
					new SqlParameter("@Spusername", SqlDbType.NVarChar,4000),
					new SqlParameter("@Sprealname", SqlDbType.NVarChar,4000),
					new SqlParameter("@MyTimes", SqlDbType.DateTime)};
			parameters[0].Value = number;
			parameters[1].Value = title;
			parameters[2].Value = NbNumber;
			parameters[3].Value = Type;
			parameters[4].Value = Allmoney;
			parameters[5].Value = Outtime;
			parameters[6].Value = IncomeSet;
			parameters[7].Value = FkMoney;
			parameters[8].Value = SyMoney;
			parameters[9].Value = InvoiceType;
			parameters[10].Value = CompanyNumber;
			parameters[11].Value = CompanyName;
			parameters[12].Value = JbPeoNum;
			parameters[13].Value = JbName;
			parameters[14].Value = State;
			parameters[15].Value = Username;
			parameters[16].Value = Realname;
			parameters[17].Value = Nowtimes;
			parameters[18].Value = StreamNumber;
			parameters[19].Value = StreamName;
			parameters[20].Value = SpCz;
			parameters[21].Value = Sreakmart;
			parameters[22].Value = Spusername;
			parameters[23].Value = Sprealname;
			parameters[24].Value = MyTimes;

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
			strSql.Append("update [StockOutMoney_sp] set ");
			strSql.Append("number=@number,");
			strSql.Append("title=@title,");
			strSql.Append("NbNumber=@NbNumber,");
			strSql.Append("Type=@Type,");
			strSql.Append("Allmoney=@Allmoney,");
			strSql.Append("Outtime=@Outtime,");
			strSql.Append("IncomeSet=@IncomeSet,");
			strSql.Append("FkMoney=@FkMoney,");
			strSql.Append("SyMoney=@SyMoney,");
			strSql.Append("InvoiceType=@InvoiceType,");
			strSql.Append("CompanyNumber=@CompanyNumber,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("JbPeoNum=@JbPeoNum,");
			strSql.Append("JbName=@JbName,");
			strSql.Append("State=@State,");
			strSql.Append("Username=@Username,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Nowtimes=@Nowtimes,");
			strSql.Append("StreamNumber=@StreamNumber,");
			strSql.Append("StreamName=@StreamName,");
			strSql.Append("SpCz=@SpCz,");
			strSql.Append("Sreakmart=@Sreakmart,");
			strSql.Append("Spusername=@Spusername,");
			strSql.Append("Sprealname=@Sprealname,");
			strSql.Append("MyTimes=@MyTimes");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@NbNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@Outtime", SqlDbType.DateTime),
					new SqlParameter("@IncomeSet", SqlDbType.NVarChar,50),
					new SqlParameter("@FkMoney", SqlDbType.Decimal,9),
					new SqlParameter("@SyMoney", SqlDbType.Decimal,9),
					new SqlParameter("@InvoiceType", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@JbPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@JbName", SqlDbType.NVarChar,50),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.NVarChar,50),
					new SqlParameter("@StreamNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@StreamName", SqlDbType.NVarChar,50),
					new SqlParameter("@SpCz", SqlDbType.NVarChar,50),
					new SqlParameter("@Sreakmart", SqlDbType.NText),
					new SqlParameter("@Spusername", SqlDbType.NVarChar,4000),
					new SqlParameter("@Sprealname", SqlDbType.NVarChar,4000),
					new SqlParameter("@MyTimes", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = number;
			parameters[1].Value = title;
			parameters[2].Value = NbNumber;
			parameters[3].Value = Type;
			parameters[4].Value = Allmoney;
			parameters[5].Value = Outtime;
			parameters[6].Value = IncomeSet;
			parameters[7].Value = FkMoney;
			parameters[8].Value = SyMoney;
			parameters[9].Value = InvoiceType;
			parameters[10].Value = CompanyNumber;
			parameters[11].Value = CompanyName;
			parameters[12].Value = JbPeoNum;
			parameters[13].Value = JbName;
			parameters[14].Value = State;
			parameters[15].Value = Username;
			parameters[16].Value = Realname;
			parameters[17].Value = Nowtimes;
			parameters[18].Value = StreamNumber;
			parameters[19].Value = StreamName;
			parameters[20].Value = SpCz;
			parameters[21].Value = Sreakmart;
			parameters[22].Value = Spusername;
			parameters[23].Value = Sprealname;
			parameters[24].Value = MyTimes;
			parameters[25].Value = Id;

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
			strSql.Append("delete from [StockOutMoney_sp] ");
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
			strSql.Append("select Id,number,title,NbNumber,Type,Allmoney,Outtime,IncomeSet,FkMoney,SyMoney,InvoiceType,CompanyNumber,CompanyName,JbPeoNum,JbName,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes ");
			strSql.Append(" FROM [StockOutMoney_sp] ");
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
				if(ds.Tables[0].Rows[0]["NbNumber"]!=null )
				{
					this.NbNumber=ds.Tables[0].Rows[0]["NbNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Allmoney"]!=null && ds.Tables[0].Rows[0]["Allmoney"].ToString()!="")
				{
					this.Allmoney=decimal.Parse(ds.Tables[0].Rows[0]["Allmoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Outtime"]!=null && ds.Tables[0].Rows[0]["Outtime"].ToString()!="")
				{
					this.Outtime=DateTime.Parse(ds.Tables[0].Rows[0]["Outtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IncomeSet"]!=null )
				{
					this.IncomeSet=ds.Tables[0].Rows[0]["IncomeSet"].ToString();
				}
				if(ds.Tables[0].Rows[0]["FkMoney"]!=null && ds.Tables[0].Rows[0]["FkMoney"].ToString()!="")
				{
					this.FkMoney=decimal.Parse(ds.Tables[0].Rows[0]["FkMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SyMoney"]!=null && ds.Tables[0].Rows[0]["SyMoney"].ToString()!="")
				{
					this.SyMoney=decimal.Parse(ds.Tables[0].Rows[0]["SyMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["InvoiceType"]!=null )
				{
					this.InvoiceType=ds.Tables[0].Rows[0]["InvoiceType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyNumber"]!=null )
				{
					this.CompanyNumber=ds.Tables[0].Rows[0]["CompanyNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyName"]!=null )
				{
					this.CompanyName=ds.Tables[0].Rows[0]["CompanyName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["JbPeoNum"]!=null )
				{
					this.JbPeoNum=ds.Tables[0].Rows[0]["JbPeoNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["JbName"]!=null )
				{
					this.JbName=ds.Tables[0].Rows[0]["JbName"].ToString();
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
				if(ds.Tables[0].Rows[0]["Nowtimes"]!=null )
				{
					this.Nowtimes=ds.Tables[0].Rows[0]["Nowtimes"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StreamNumber"]!=null )
				{
					this.StreamNumber=ds.Tables[0].Rows[0]["StreamNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StreamName"]!=null )
				{
					this.StreamName=ds.Tables[0].Rows[0]["StreamName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SpCz"]!=null )
				{
					this.SpCz=ds.Tables[0].Rows[0]["SpCz"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Sreakmart"]!=null )
				{
					this.Sreakmart=ds.Tables[0].Rows[0]["Sreakmart"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Spusername"]!=null )
				{
					this.Spusername=ds.Tables[0].Rows[0]["Spusername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Sprealname"]!=null )
				{
					this.Sprealname=ds.Tables[0].Rows[0]["Sprealname"].ToString();
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
			strSql.Append(" FROM [StockOutMoney_sp] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

