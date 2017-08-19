using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类SellOrder_sp。
	/// </summary>
	[Serializable]
	public partial class SellOrder_sp
	{
		public SellOrder_sp()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _title;
		private string _type;
		private string _invoicetype;
		private string _invoicenum;
		private DateTime? _qdtime;
		private string _orderadd;
		private string _lxadd;
		private string _storeroom;
		private string _shtime;
		private string _companynumber;
		private string _companyname;
		private string _companyadd;
		private string _banknumber;
		private string _taxnumber;
		private string _bank;
		private string _tel;
		private string _lxpeople;
		private string _dlpeople;
		private string _unit;
		private string _stockpeonum;
		private string _stockpeoname;
		private DateTime? _yxstarttime;
		private DateTime? _yxendtime;
		private decimal? _discount;
		private decimal? _allmoney;
		private decimal? _dismoney;
		private decimal? _yjmoney;
		private string _remark;
		private string _state;
		private string _username;
		private string _realname;
		private DateTime? _nowtimes;
		private string _streamnumber;
		private string _streamname;
		private string _spcz;
		private string _sreakmart;
		private string _spusername;
		private string _sprealname;
		private string _mytimes;
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
		public string InvoiceType
		{
			set{ _invoicetype=value;}
			get{return _invoicetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InvoiceNum
		{
			set{ _invoicenum=value;}
			get{return _invoicenum;}
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
		public string ShTime
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
		public string BankNumber
		{
			set{ _banknumber=value;}
			get{return _banknumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TaxNumber
		{
			set{ _taxnumber=value;}
			get{return _taxnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Bank
		{
			set{ _bank=value;}
			get{return _bank;}
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
		public string LxPeople
		{
			set{ _lxpeople=value;}
			get{return _lxpeople;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DlPeople
		{
			set{ _dlpeople=value;}
			get{return _dlpeople;}
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
		public DateTime? YxStarttime
		{
			set{ _yxstarttime=value;}
			get{return _yxstarttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? YxEndtime
		{
			set{ _yxendtime=value;}
			get{return _yxendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Discount
		{
			set{ _discount=value;}
			get{return _discount;}
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
		public decimal? DisMoney
		{
			set{ _dismoney=value;}
			get{return _dismoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? YjMoney
		{
			set{ _yjmoney=value;}
			get{return _yjmoney;}
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
		public string MyTimes
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
		public SellOrder_sp(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes,Ifopen ");
			strSql.Append(" FROM [SellOrder_sp] ");
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
				if(ds.Tables[0].Rows[0]["InvoiceType"]!=null)
				{
					this.InvoiceType=ds.Tables[0].Rows[0]["InvoiceType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["InvoiceNum"]!=null)
				{
					this.InvoiceNum=ds.Tables[0].Rows[0]["InvoiceNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QdTime"]!=null && ds.Tables[0].Rows[0]["QdTime"].ToString()!="")
				{
					this.QdTime=DateTime.Parse(ds.Tables[0].Rows[0]["QdTime"].ToString());
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
				if(ds.Tables[0].Rows[0]["ShTime"]!=null)
				{
					this.ShTime=ds.Tables[0].Rows[0]["ShTime"].ToString();
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
				if(ds.Tables[0].Rows[0]["BankNumber"]!=null)
				{
					this.BankNumber=ds.Tables[0].Rows[0]["BankNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TaxNumber"]!=null)
				{
					this.TaxNumber=ds.Tables[0].Rows[0]["TaxNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Bank"]!=null)
				{
					this.Bank=ds.Tables[0].Rows[0]["Bank"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null)
				{
					this.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LxPeople"]!=null)
				{
					this.LxPeople=ds.Tables[0].Rows[0]["LxPeople"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DlPeople"]!=null)
				{
					this.DlPeople=ds.Tables[0].Rows[0]["DlPeople"].ToString();
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
				if(ds.Tables[0].Rows[0]["YxStarttime"]!=null && ds.Tables[0].Rows[0]["YxStarttime"].ToString()!="")
				{
					this.YxStarttime=DateTime.Parse(ds.Tables[0].Rows[0]["YxStarttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YxEndtime"]!=null && ds.Tables[0].Rows[0]["YxEndtime"].ToString()!="")
				{
					this.YxEndtime=DateTime.Parse(ds.Tables[0].Rows[0]["YxEndtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Discount"]!=null && ds.Tables[0].Rows[0]["Discount"].ToString()!="")
				{
					this.Discount=decimal.Parse(ds.Tables[0].Rows[0]["Discount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AllMoney"]!=null && ds.Tables[0].Rows[0]["AllMoney"].ToString()!="")
				{
					this.AllMoney=decimal.Parse(ds.Tables[0].Rows[0]["AllMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DisMoney"]!=null && ds.Tables[0].Rows[0]["DisMoney"].ToString()!="")
				{
					this.DisMoney=decimal.Parse(ds.Tables[0].Rows[0]["DisMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YjMoney"]!=null && ds.Tables[0].Rows[0]["YjMoney"].ToString()!="")
				{
					this.YjMoney=decimal.Parse(ds.Tables[0].Rows[0]["YjMoney"].ToString());
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
				if(ds.Tables[0].Rows[0]["MyTimes"]!=null)
				{
					this.MyTimes=ds.Tables[0].Rows[0]["MyTimes"].ToString();
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
			strSql.Append("select count(1) from [SellOrder_sp]");
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
			strSql.Append("insert into [SellOrder_sp] (");
			strSql.Append("number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes,Ifopen)");
			strSql.Append(" values (");
			strSql.Append("@number,@title,@Type,@InvoiceType,@InvoiceNum,@QdTime,@OrderAdd,@LxAdd,@Storeroom,@ShTime,@CompanyNumber,@CompanyName,@CompanyAdd,@BankNumber,@TaxNumber,@Bank,@Tel,@LxPeople,@DlPeople,@Unit,@StockPeoNum,@StockPeoName,@YxStarttime,@YxEndtime,@Discount,@AllMoney,@DisMoney,@YjMoney,@Remark,@State,@Username,@Realname,@Nowtimes,@StreamNumber,@StreamName,@SpCz,@Sreakmart,@Spusername,@Sprealname,@MyTimes,@Ifopen)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@InvoiceType", SqlDbType.NVarChar,50),
					new SqlParameter("@InvoiceNum", SqlDbType.NVarChar,50),
					new SqlParameter("@QdTime", SqlDbType.DateTime),
					new SqlParameter("@OrderAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@LxAdd", SqlDbType.NVarChar,50),
					new SqlParameter("@Storeroom", SqlDbType.NVarChar,50),
					new SqlParameter("@ShTime", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@BankNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@TaxNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Bank", SqlDbType.NVarChar,50),
					new SqlParameter("@Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@LxPeople", SqlDbType.NVarChar,50),
					new SqlParameter("@DlPeople", SqlDbType.NVarChar,50),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@YxStarttime", SqlDbType.DateTime),
					new SqlParameter("@YxEndtime", SqlDbType.DateTime),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@AllMoney", SqlDbType.Decimal,9),
					new SqlParameter("@DisMoney", SqlDbType.Decimal,9),
					new SqlParameter("@YjMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@StreamNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@StreamName", SqlDbType.NVarChar,50),
					new SqlParameter("@SpCz", SqlDbType.NVarChar,50),
					new SqlParameter("@Sreakmart", SqlDbType.NText),
					new SqlParameter("@Spusername", SqlDbType.NVarChar,4000),
					new SqlParameter("@Sprealname", SqlDbType.NVarChar,4000),
					new SqlParameter("@MyTimes", SqlDbType.NVarChar,50),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50)};
			parameters[0].Value = number;
			parameters[1].Value = title;
			parameters[2].Value = Type;
			parameters[3].Value = InvoiceType;
			parameters[4].Value = InvoiceNum;
			parameters[5].Value = QdTime;
			parameters[6].Value = OrderAdd;
			parameters[7].Value = LxAdd;
			parameters[8].Value = Storeroom;
			parameters[9].Value = ShTime;
			parameters[10].Value = CompanyNumber;
			parameters[11].Value = CompanyName;
			parameters[12].Value = CompanyAdd;
			parameters[13].Value = BankNumber;
			parameters[14].Value = TaxNumber;
			parameters[15].Value = Bank;
			parameters[16].Value = Tel;
			parameters[17].Value = LxPeople;
			parameters[18].Value = DlPeople;
			parameters[19].Value = Unit;
			parameters[20].Value = StockPeoNum;
			parameters[21].Value = StockPeoName;
			parameters[22].Value = YxStarttime;
			parameters[23].Value = YxEndtime;
			parameters[24].Value = Discount;
			parameters[25].Value = AllMoney;
			parameters[26].Value = DisMoney;
			parameters[27].Value = YjMoney;
			parameters[28].Value = Remark;
			parameters[29].Value = State;
			parameters[30].Value = Username;
			parameters[31].Value = Realname;
			parameters[32].Value = Nowtimes;
			parameters[33].Value = StreamNumber;
			parameters[34].Value = StreamName;
			parameters[35].Value = SpCz;
			parameters[36].Value = Sreakmart;
			parameters[37].Value = Spusername;
			parameters[38].Value = Sprealname;
			parameters[39].Value = MyTimes;
			parameters[40].Value = Ifopen;

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
			strSql.Append("update [SellOrder_sp] set ");
			strSql.Append("number=@number,");
			strSql.Append("title=@title,");
			strSql.Append("Type=@Type,");
			strSql.Append("InvoiceType=@InvoiceType,");
			strSql.Append("InvoiceNum=@InvoiceNum,");
			strSql.Append("QdTime=@QdTime,");
			strSql.Append("OrderAdd=@OrderAdd,");
			strSql.Append("LxAdd=@LxAdd,");
			strSql.Append("Storeroom=@Storeroom,");
			strSql.Append("ShTime=@ShTime,");
			strSql.Append("CompanyNumber=@CompanyNumber,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyAdd=@CompanyAdd,");
			strSql.Append("BankNumber=@BankNumber,");
			strSql.Append("TaxNumber=@TaxNumber,");
			strSql.Append("Bank=@Bank,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("LxPeople=@LxPeople,");
			strSql.Append("DlPeople=@DlPeople,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("StockPeoNum=@StockPeoNum,");
			strSql.Append("StockPeoName=@StockPeoName,");
			strSql.Append("YxStarttime=@YxStarttime,");
			strSql.Append("YxEndtime=@YxEndtime,");
			strSql.Append("Discount=@Discount,");
			strSql.Append("AllMoney=@AllMoney,");
			strSql.Append("DisMoney=@DisMoney,");
			strSql.Append("YjMoney=@YjMoney,");
			strSql.Append("Remark=@Remark,");
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
			strSql.Append("MyTimes=@MyTimes,");
			strSql.Append("Ifopen=@Ifopen");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@InvoiceType", SqlDbType.NVarChar,50),
					new SqlParameter("@InvoiceNum", SqlDbType.NVarChar,50),
					new SqlParameter("@QdTime", SqlDbType.DateTime),
					new SqlParameter("@OrderAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@LxAdd", SqlDbType.NVarChar,50),
					new SqlParameter("@Storeroom", SqlDbType.NVarChar,50),
					new SqlParameter("@ShTime", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@BankNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@TaxNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Bank", SqlDbType.NVarChar,50),
					new SqlParameter("@Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@LxPeople", SqlDbType.NVarChar,50),
					new SqlParameter("@DlPeople", SqlDbType.NVarChar,50),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@YxStarttime", SqlDbType.DateTime),
					new SqlParameter("@YxEndtime", SqlDbType.DateTime),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@AllMoney", SqlDbType.Decimal,9),
					new SqlParameter("@DisMoney", SqlDbType.Decimal,9),
					new SqlParameter("@YjMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@StreamNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@StreamName", SqlDbType.NVarChar,50),
					new SqlParameter("@SpCz", SqlDbType.NVarChar,50),
					new SqlParameter("@Sreakmart", SqlDbType.NText),
					new SqlParameter("@Spusername", SqlDbType.NVarChar,4000),
					new SqlParameter("@Sprealname", SqlDbType.NVarChar,4000),
					new SqlParameter("@MyTimes", SqlDbType.NVarChar,50),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = number;
			parameters[1].Value = title;
			parameters[2].Value = Type;
			parameters[3].Value = InvoiceType;
			parameters[4].Value = InvoiceNum;
			parameters[5].Value = QdTime;
			parameters[6].Value = OrderAdd;
			parameters[7].Value = LxAdd;
			parameters[8].Value = Storeroom;
			parameters[9].Value = ShTime;
			parameters[10].Value = CompanyNumber;
			parameters[11].Value = CompanyName;
			parameters[12].Value = CompanyAdd;
			parameters[13].Value = BankNumber;
			parameters[14].Value = TaxNumber;
			parameters[15].Value = Bank;
			parameters[16].Value = Tel;
			parameters[17].Value = LxPeople;
			parameters[18].Value = DlPeople;
			parameters[19].Value = Unit;
			parameters[20].Value = StockPeoNum;
			parameters[21].Value = StockPeoName;
			parameters[22].Value = YxStarttime;
			parameters[23].Value = YxEndtime;
			parameters[24].Value = Discount;
			parameters[25].Value = AllMoney;
			parameters[26].Value = DisMoney;
			parameters[27].Value = YjMoney;
			parameters[28].Value = Remark;
			parameters[29].Value = State;
			parameters[30].Value = Username;
			parameters[31].Value = Realname;
			parameters[32].Value = Nowtimes;
			parameters[33].Value = StreamNumber;
			parameters[34].Value = StreamName;
			parameters[35].Value = SpCz;
			parameters[36].Value = Sreakmart;
			parameters[37].Value = Spusername;
			parameters[38].Value = Sprealname;
			parameters[39].Value = MyTimes;
			parameters[40].Value = Ifopen;
			parameters[41].Value = Id;

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
			strSql.Append("delete from [SellOrder_sp] ");
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
			strSql.Append("select Id,number,title,Type,InvoiceType,InvoiceNum,QdTime,OrderAdd,LxAdd,Storeroom,ShTime,CompanyNumber,CompanyName,CompanyAdd,BankNumber,TaxNumber,Bank,Tel,LxPeople,DlPeople,Unit,StockPeoNum,StockPeoName,YxStarttime,YxEndtime,Discount,AllMoney,DisMoney,YjMoney,Remark,State,Username,Realname,Nowtimes,StreamNumber,StreamName,SpCz,Sreakmart,Spusername,Sprealname,MyTimes,Ifopen ");
			strSql.Append(" FROM [SellOrder_sp] ");
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
				if(ds.Tables[0].Rows[0]["InvoiceType"]!=null )
				{
					this.InvoiceType=ds.Tables[0].Rows[0]["InvoiceType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["InvoiceNum"]!=null )
				{
					this.InvoiceNum=ds.Tables[0].Rows[0]["InvoiceNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QdTime"]!=null && ds.Tables[0].Rows[0]["QdTime"].ToString()!="")
				{
					this.QdTime=DateTime.Parse(ds.Tables[0].Rows[0]["QdTime"].ToString());
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
				if(ds.Tables[0].Rows[0]["ShTime"]!=null )
				{
					this.ShTime=ds.Tables[0].Rows[0]["ShTime"].ToString();
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
				if(ds.Tables[0].Rows[0]["BankNumber"]!=null )
				{
					this.BankNumber=ds.Tables[0].Rows[0]["BankNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TaxNumber"]!=null )
				{
					this.TaxNumber=ds.Tables[0].Rows[0]["TaxNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Bank"]!=null )
				{
					this.Bank=ds.Tables[0].Rows[0]["Bank"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null )
				{
					this.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LxPeople"]!=null )
				{
					this.LxPeople=ds.Tables[0].Rows[0]["LxPeople"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DlPeople"]!=null )
				{
					this.DlPeople=ds.Tables[0].Rows[0]["DlPeople"].ToString();
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
				if(ds.Tables[0].Rows[0]["YxStarttime"]!=null && ds.Tables[0].Rows[0]["YxStarttime"].ToString()!="")
				{
					this.YxStarttime=DateTime.Parse(ds.Tables[0].Rows[0]["YxStarttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YxEndtime"]!=null && ds.Tables[0].Rows[0]["YxEndtime"].ToString()!="")
				{
					this.YxEndtime=DateTime.Parse(ds.Tables[0].Rows[0]["YxEndtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Discount"]!=null && ds.Tables[0].Rows[0]["Discount"].ToString()!="")
				{
					this.Discount=decimal.Parse(ds.Tables[0].Rows[0]["Discount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AllMoney"]!=null && ds.Tables[0].Rows[0]["AllMoney"].ToString()!="")
				{
					this.AllMoney=decimal.Parse(ds.Tables[0].Rows[0]["AllMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DisMoney"]!=null && ds.Tables[0].Rows[0]["DisMoney"].ToString()!="")
				{
					this.DisMoney=decimal.Parse(ds.Tables[0].Rows[0]["DisMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["YjMoney"]!=null && ds.Tables[0].Rows[0]["YjMoney"].ToString()!="")
				{
					this.YjMoney=decimal.Parse(ds.Tables[0].Rows[0]["YjMoney"].ToString());
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
				if(ds.Tables[0].Rows[0]["MyTimes"]!=null )
				{
					this.MyTimes=ds.Tables[0].Rows[0]["MyTimes"].ToString();
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
			strSql.Append(" FROM [SellOrder_sp] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

