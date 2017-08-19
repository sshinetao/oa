using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类SellMoney。
	/// </summary>
	[Serializable]
	public partial class SellMoney
	{
		public SellMoney()
		{}
		#region Model
		private long _id;
		private string _companynumber;
		private string _companyname;
		private string _companyadd;
		private string _goodsnumber;
		private string _goodsname;
		private string _countunit;
		private string _model;
		private decimal? _wlmoney;
		private DateTime? _starttime;
		private string _paytype;
		private string _bjpeoname;
		private string _bjpeonumber;
		private string _username;
		private string _realname;
		private DateTime? _nowtimes;
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
		public string GoodsNumber
		{
			set{ _goodsnumber=value;}
			get{return _goodsnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsName
		{
			set{ _goodsname=value;}
			get{return _goodsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CountUnit
		{
			set{ _countunit=value;}
			get{return _countunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WlMoney
		{
			set{ _wlmoney=value;}
			get{return _wlmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Starttime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PayType
		{
			set{ _paytype=value;}
			get{return _paytype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BjPeoName
		{
			set{ _bjpeoname=value;}
			get{return _bjpeoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BjPeoNumber
		{
			set{ _bjpeonumber=value;}
			get{return _bjpeonumber;}
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
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SellMoney(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,CompanyNumber,CompanyName,CompanyAdd,GoodsNumber,GoodsName,CountUnit,Model,WlMoney,Starttime,PayType,BjPeoName,BjPeoNumber,Username,Realname,Nowtimes ");
			strSql.Append(" FROM [SellMoney] ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["Id"].ToString() != "") { this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()); }
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
				if(ds.Tables[0].Rows[0]["GoodsNumber"]!=null)
				{
					this.GoodsNumber=ds.Tables[0].Rows[0]["GoodsNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GoodsName"]!=null)
				{
					this.GoodsName=ds.Tables[0].Rows[0]["GoodsName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CountUnit"]!=null)
				{
					this.CountUnit=ds.Tables[0].Rows[0]["CountUnit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Model"]!=null)
				{
					this.Model=ds.Tables[0].Rows[0]["Model"].ToString();
				}
				if(ds.Tables[0].Rows[0]["WlMoney"]!=null && ds.Tables[0].Rows[0]["WlMoney"].ToString()!="")
				{
					this.WlMoney=decimal.Parse(ds.Tables[0].Rows[0]["WlMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Starttime"]!=null && ds.Tables[0].Rows[0]["Starttime"].ToString()!="")
				{
					this.Starttime=DateTime.Parse(ds.Tables[0].Rows[0]["Starttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PayType"]!=null)
				{
					this.PayType=ds.Tables[0].Rows[0]["PayType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BjPeoName"]!=null)
				{
					this.BjPeoName=ds.Tables[0].Rows[0]["BjPeoName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BjPeoNumber"]!=null)
				{
					this.BjPeoNumber=ds.Tables[0].Rows[0]["BjPeoNumber"].ToString();
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
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [SellMoney]");
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
			strSql.Append("insert into [SellMoney] (");
			strSql.Append("CompanyNumber,CompanyName,CompanyAdd,GoodsNumber,GoodsName,CountUnit,Model,WlMoney,Starttime,PayType,BjPeoName,BjPeoNumber,Username,Realname,Nowtimes)");
			strSql.Append(" values (");
			strSql.Append("@CompanyNumber,@CompanyName,@CompanyAdd,@GoodsNumber,@GoodsName,@CountUnit,@Model,@WlMoney,@Starttime,@PayType,@BjPeoName,@BjPeoNumber,@Username,@Realname,@Nowtimes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@WlMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Starttime", SqlDbType.DateTime),
					new SqlParameter("@PayType", SqlDbType.NVarChar,50),
					new SqlParameter("@BjPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@BjPeoNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime)};
			parameters[0].Value = CompanyNumber;
			parameters[1].Value = CompanyName;
			parameters[2].Value = CompanyAdd;
			parameters[3].Value = GoodsNumber;
			parameters[4].Value = GoodsName;
			parameters[5].Value = CountUnit;
			parameters[6].Value = Model;
			parameters[7].Value = WlMoney;
			parameters[8].Value = Starttime;
			parameters[9].Value = PayType;
			parameters[10].Value = BjPeoName;
			parameters[11].Value = BjPeoNumber;
			parameters[12].Value = Username;
			parameters[13].Value = Realname;
			parameters[14].Value = Nowtimes;

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
			strSql.Append("update [SellMoney] set ");
			strSql.Append("CompanyNumber=@CompanyNumber,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyAdd=@CompanyAdd,");
			strSql.Append("GoodsNumber=@GoodsNumber,");
			strSql.Append("GoodsName=@GoodsName,");
			strSql.Append("CountUnit=@CountUnit,");
			strSql.Append("Model=@Model,");
			strSql.Append("WlMoney=@WlMoney,");
			strSql.Append("Starttime=@Starttime,");
			strSql.Append("PayType=@PayType,");
			strSql.Append("BjPeoName=@BjPeoName,");
			strSql.Append("BjPeoNumber=@BjPeoNumber,");
			strSql.Append("Username=@Username,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Nowtimes=@Nowtimes");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NVarChar,3000),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@WlMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Starttime", SqlDbType.DateTime),
					new SqlParameter("@PayType", SqlDbType.NVarChar,50),
					new SqlParameter("@BjPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@BjPeoNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = CompanyNumber;
			parameters[1].Value = CompanyName;
			parameters[2].Value = CompanyAdd;
			parameters[3].Value = GoodsNumber;
			parameters[4].Value = GoodsName;
			parameters[5].Value = CountUnit;
			parameters[6].Value = Model;
			parameters[7].Value = WlMoney;
			parameters[8].Value = Starttime;
			parameters[9].Value = PayType;
			parameters[10].Value = BjPeoName;
			parameters[11].Value = BjPeoNumber;
			parameters[12].Value = Username;
			parameters[13].Value = Realname;
			parameters[14].Value = Nowtimes;
			parameters[15].Value = Id;

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
			strSql.Append("delete from [SellMoney] ");
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
			strSql.Append("select Id,CompanyNumber,CompanyName,CompanyAdd,GoodsNumber,GoodsName,CountUnit,Model,WlMoney,Starttime,PayType,BjPeoName,BjPeoNumber,Username,Realname,Nowtimes ");
			strSql.Append(" FROM [SellMoney] ");
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
				if(ds.Tables[0].Rows[0]["GoodsNumber"]!=null )
				{
					this.GoodsNumber=ds.Tables[0].Rows[0]["GoodsNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GoodsName"]!=null )
				{
					this.GoodsName=ds.Tables[0].Rows[0]["GoodsName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CountUnit"]!=null )
				{
					this.CountUnit=ds.Tables[0].Rows[0]["CountUnit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Model"]!=null )
				{
					this.Model=ds.Tables[0].Rows[0]["Model"].ToString();
				}
				if(ds.Tables[0].Rows[0]["WlMoney"]!=null && ds.Tables[0].Rows[0]["WlMoney"].ToString()!="")
				{
					this.WlMoney=decimal.Parse(ds.Tables[0].Rows[0]["WlMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Starttime"]!=null && ds.Tables[0].Rows[0]["Starttime"].ToString()!="")
				{
					this.Starttime=DateTime.Parse(ds.Tables[0].Rows[0]["Starttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PayType"]!=null )
				{
					this.PayType=ds.Tables[0].Rows[0]["PayType"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BjPeoName"]!=null )
				{
					this.BjPeoName=ds.Tables[0].Rows[0]["BjPeoName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BjPeoNumber"]!=null )
				{
					this.BjPeoNumber=ds.Tables[0].Rows[0]["BjPeoNumber"].ToString();
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
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM [SellMoney] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

