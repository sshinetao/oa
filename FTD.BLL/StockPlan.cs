using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类StockPlan。
	/// </summary>
	[Serializable]
	public partial class StockPlan
	{
		public StockPlan()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _tilte;
		private DateTime? _starttime;
		private DateTime? _endtime;
		private string _type;
		private decimal? _allmoney;
		private string _unit;
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
		public string number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string tilte
		{
			set{ _tilte=value;}
			get{return _tilte;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
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
		public decimal? ALLMoney
		{
			set{ _allmoney=value;}
			get{return _allmoney;}
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
		public StockPlan(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,number,tilte,StartTime,EndTime,Type,ALLMoney,Unit,Username,Realname,Nowtimes,Ifopen ");
			strSql.Append(" FROM [StockPlan] ");
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
				if(ds.Tables[0].Rows[0]["tilte"]!=null)
				{
					this.tilte=ds.Tables[0].Rows[0]["tilte"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StartTime"]!=null && ds.Tables[0].Rows[0]["StartTime"].ToString()!="")
				{
					this.StartTime=DateTime.Parse(ds.Tables[0].Rows[0]["StartTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EndTime"]!=null && ds.Tables[0].Rows[0]["EndTime"].ToString()!="")
				{
					this.EndTime=DateTime.Parse(ds.Tables[0].Rows[0]["EndTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ALLMoney"]!=null && ds.Tables[0].Rows[0]["ALLMoney"].ToString()!="")
				{
					this.ALLMoney=decimal.Parse(ds.Tables[0].Rows[0]["ALLMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Unit"]!=null)
				{
					this.Unit=ds.Tables[0].Rows[0]["Unit"].ToString();
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
			strSql.Append("select count(1) from [StockPlan]");
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
			strSql.Append("insert into [StockPlan] (");
			strSql.Append("number,tilte,StartTime,EndTime,Type,ALLMoney,Unit,Username,Realname,Nowtimes,Ifopen)");
			strSql.Append(" values (");
			strSql.Append("@number,@tilte,@StartTime,@EndTime,@Type,@ALLMoney,@Unit,@Username,@Realname,@Nowtimes,@Ifopen)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@tilte", SqlDbType.NVarChar,3000),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@ALLMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50)};
			parameters[0].Value = number;
			parameters[1].Value = tilte;
			parameters[2].Value = StartTime;
			parameters[3].Value = EndTime;
			parameters[4].Value = Type;
			parameters[5].Value = ALLMoney;
			parameters[6].Value = Unit;
			parameters[7].Value = Username;
			parameters[8].Value = Realname;
			parameters[9].Value = Nowtimes;
			parameters[10].Value = Ifopen;

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
			strSql.Append("update [StockPlan] set ");
			strSql.Append("number=@number,");
			strSql.Append("tilte=@tilte,");
			strSql.Append("StartTime=@StartTime,");
			strSql.Append("EndTime=@EndTime,");
			strSql.Append("Type=@Type,");
			strSql.Append("ALLMoney=@ALLMoney,");
			strSql.Append("Unit=@Unit,");
			strSql.Append("Username=@Username,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Nowtimes=@Nowtimes,");
			strSql.Append("Ifopen=@Ifopen");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@tilte", SqlDbType.NVarChar,3000),
					new SqlParameter("@StartTime", SqlDbType.DateTime),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@ALLMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Unit", SqlDbType.NVarChar,50),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = number;
			parameters[1].Value = tilte;
			parameters[2].Value = StartTime;
			parameters[3].Value = EndTime;
			parameters[4].Value = Type;
			parameters[5].Value = ALLMoney;
			parameters[6].Value = Unit;
			parameters[7].Value = Username;
			parameters[8].Value = Realname;
			parameters[9].Value = Nowtimes;
			parameters[10].Value = Ifopen;
			parameters[11].Value = Id;

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
			strSql.Append("delete from [StockPlan] ");
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
			strSql.Append("select Id,number,tilte,StartTime,EndTime,Type,ALLMoney,Unit,Username,Realname,Nowtimes,Ifopen ");
			strSql.Append(" FROM [StockPlan] ");
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
				if(ds.Tables[0].Rows[0]["tilte"]!=null )
				{
					this.tilte=ds.Tables[0].Rows[0]["tilte"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StartTime"]!=null && ds.Tables[0].Rows[0]["StartTime"].ToString()!="")
				{
					this.StartTime=DateTime.Parse(ds.Tables[0].Rows[0]["StartTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EndTime"]!=null && ds.Tables[0].Rows[0]["EndTime"].ToString()!="")
				{
					this.EndTime=DateTime.Parse(ds.Tables[0].Rows[0]["EndTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ALLMoney"]!=null && ds.Tables[0].Rows[0]["ALLMoney"].ToString()!="")
				{
					this.ALLMoney=decimal.Parse(ds.Tables[0].Rows[0]["ALLMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Unit"]!=null )
				{
					this.Unit=ds.Tables[0].Rows[0]["Unit"].ToString();
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
			strSql.Append(" FROM [StockPlan] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

