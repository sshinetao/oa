using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类SellQuote。
	/// </summary>
	[Serializable]
	public partial class SellQuote
	{
		public SellQuote()
		{}
		#region Model
		private long _id;
		private string _title;
		private string _number;
		private string _invoicetype;
		private DateTime? _qdtime;
		private string _orderadd;
		private string _companynumber;
		private string _companyname;
		private string _companyadd;
		private string _unit;
		private string _stockpeonum;
		private string _stockpeoname;
		private decimal? _allmoney;
		private string _remark;
		private string _type;
		private string _username;
		private string _realname;
		private DateTime? _nowtimes;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
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
		public string InvoiceType
		{
			set{ _invoicetype=value;}
			get{return _invoicetype;}
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
		public decimal? Allmoney
		{
			set{ _allmoney=value;}
			get{return _allmoney;}
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
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
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
		public SellQuote(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,title,number,InvoiceType,QdTime,OrderAdd,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,Allmoney,Remark,Type,Username,Realname,Nowtimes,Ifopen ");
			strSql.Append(" FROM [SellQuote] ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["Id"].ToString() != "") { this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()); }
				if(ds.Tables[0].Rows[0]["title"]!=null)
				{
					this.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["number"]!=null)
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
				}
				if(ds.Tables[0].Rows[0]["InvoiceType"]!=null)
				{
					this.InvoiceType=ds.Tables[0].Rows[0]["InvoiceType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QdTime"]!=null && ds.Tables[0].Rows[0]["QdTime"].ToString()!="")
				{
					this.QdTime=DateTime.Parse(ds.Tables[0].Rows[0]["QdTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OrderAdd"]!=null)
				{
					this.OrderAdd=ds.Tables[0].Rows[0]["OrderAdd"].ToString();
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
				if(ds.Tables[0].Rows[0]["Allmoney"]!=null && ds.Tables[0].Rows[0]["Allmoney"].ToString()!="")
				{
					this.Allmoney=decimal.Parse(ds.Tables[0].Rows[0]["Allmoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null)
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
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
			strSql.Append("select count(1) from [SellQuote]");
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
			strSql.Append("insert into [SellQuote] (");
			strSql.Append("title,number,InvoiceType,QdTime,OrderAdd,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,Allmoney,Remark,Type,Username,Realname,Nowtimes,Ifopen)");
			strSql.Append(" values (");
			strSql.Append("@title,@number,@InvoiceType,@QdTime,@OrderAdd,@CompanyNumber,@CompanyName,@CompanyAdd,@Unit,@StockPeoNum,@StockPeoName,@Allmoney,@Remark,@Type,@Username,@Realname,@Nowtimes,@Ifopen)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@InvoiceType", SqlDbType.NVarChar,50),
					new SqlParameter("@QdTime", SqlDbType.DateTime),
					new SqlParameter("@OrderAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50)};
			parameters[0].Value = title;
			parameters[1].Value = number;
			parameters[2].Value = InvoiceType;
			parameters[3].Value = QdTime;
			parameters[4].Value = OrderAdd;
			parameters[5].Value = CompanyNumber;
			parameters[6].Value = CompanyName;
			parameters[7].Value = CompanyAdd;
			parameters[8].Value = Unit;
			parameters[9].Value = StockPeoNum;
			parameters[10].Value = StockPeoName;
			parameters[11].Value = Allmoney;
			parameters[12].Value = Remark;
			parameters[13].Value = Type;
			parameters[14].Value = Username;
			parameters[15].Value = Realname;
			parameters[16].Value = Nowtimes;
			parameters[17].Value = Ifopen;

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
			strSql.Append("update [SellQuote] set ");
			strSql.Append("title=@title,");
			strSql.Append("number=@number,");
			strSql.Append("InvoiceType=@InvoiceType,");
			strSql.Append("QdTime=@QdTime,");
			strSql.Append("OrderAdd=@OrderAdd,");
			strSql.Append("CompanyNumber=@CompanyNumber,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyAdd=@CompanyAdd,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("StockPeoNum=@StockPeoNum,");
			strSql.Append("StockPeoName=@StockPeoName,");
			strSql.Append("Allmoney=@Allmoney,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Type=@Type,");
			strSql.Append("Username=@Username,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Nowtimes=@Nowtimes,");
			strSql.Append("Ifopen=@Ifopen");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@InvoiceType", SqlDbType.NVarChar,50),
					new SqlParameter("@QdTime", SqlDbType.DateTime),
					new SqlParameter("@OrderAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = title;
			parameters[1].Value = number;
			parameters[2].Value = InvoiceType;
			parameters[3].Value = QdTime;
			parameters[4].Value = OrderAdd;
			parameters[5].Value = CompanyNumber;
			parameters[6].Value = CompanyName;
			parameters[7].Value = CompanyAdd;
			parameters[8].Value = Unit;
			parameters[9].Value = StockPeoNum;
			parameters[10].Value = StockPeoName;
			parameters[11].Value = Allmoney;
			parameters[12].Value = Remark;
			parameters[13].Value = Type;
			parameters[14].Value = Username;
			parameters[15].Value = Realname;
			parameters[16].Value = Nowtimes;
			parameters[17].Value = Ifopen;
			parameters[18].Value = Id;

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
			strSql.Append("delete from [SellQuote] ");
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
			strSql.Append("select Id,title,number,InvoiceType,QdTime,OrderAdd,CompanyNumber,CompanyName,CompanyAdd,Unit,StockPeoNum,StockPeoName,Allmoney,Remark,Type,Username,Realname,Nowtimes,Ifopen ");
			strSql.Append(" FROM [SellQuote] ");
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
				if(ds.Tables[0].Rows[0]["title"]!=null )
				{
					this.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["number"]!=null )
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
				}
				if(ds.Tables[0].Rows[0]["InvoiceType"]!=null )
				{
					this.InvoiceType=ds.Tables[0].Rows[0]["InvoiceType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QdTime"]!=null && ds.Tables[0].Rows[0]["QdTime"].ToString()!="")
				{
					this.QdTime=DateTime.Parse(ds.Tables[0].Rows[0]["QdTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OrderAdd"]!=null )
				{
					this.OrderAdd=ds.Tables[0].Rows[0]["OrderAdd"].ToString();
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
				if(ds.Tables[0].Rows[0]["Allmoney"]!=null && ds.Tables[0].Rows[0]["Allmoney"].ToString()!="")
				{
					this.Allmoney=decimal.Parse(ds.Tables[0].Rows[0]["Allmoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null )
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
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
			strSql.Append(" FROM [SellQuote] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

