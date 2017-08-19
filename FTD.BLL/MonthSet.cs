using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类MonthSet。
	/// </summary>
	[Serializable]
	public partial class MonthSet
	{
		public MonthSet()
		{}
		#region Model
		private long _id;
		private string _years;
		private string _months;
		private DateTime? _starttime;
		private DateTime? _endtime;
		private string _username;
		private string _realname;
		private DateTime? _nowtimes;
		/// <summary>
		/// 
		/// </summary>
		public long id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Years
		{
			set{ _years=value;}
			get{return _years;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Months
		{
			set{ _months=value;}
			get{return _months;}
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
		public DateTime? Endtime
		{
			set{ _endtime=value;}
			get{return _endtime;}
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
		public MonthSet(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Years,Months,Starttime,Endtime,Username,Realname,Nowtimes ");
			strSql.Append(" FROM [MonthSet] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["Years"]!=null)
				{
					this.Years=ds.Tables[0].Rows[0]["Years"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Months"]!=null)
				{
					this.Months=ds.Tables[0].Rows[0]["Months"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Starttime"]!=null && ds.Tables[0].Rows[0]["Starttime"].ToString()!="")
				{
					this.Starttime=DateTime.Parse(ds.Tables[0].Rows[0]["Starttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Endtime"]!=null && ds.Tables[0].Rows[0]["Endtime"].ToString()!="")
				{
					this.Endtime=DateTime.Parse(ds.Tables[0].Rows[0]["Endtime"].ToString());
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
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [MonthSet]");
			strSql.Append(" where id=@id ");

			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [MonthSet] (");
			strSql.Append("Years,Months,Starttime,Endtime,Username,Realname,Nowtimes)");
			strSql.Append(" values (");
			strSql.Append("@Years,@Months,@Starttime,@Endtime,@Username,@Realname,@Nowtimes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Years", SqlDbType.NVarChar,50),
					new SqlParameter("@Months", SqlDbType.NVarChar,50),
					new SqlParameter("@Starttime", SqlDbType.DateTime),
					new SqlParameter("@Endtime", SqlDbType.DateTime),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime)};
			parameters[0].Value = Years;
			parameters[1].Value = Months;
			parameters[2].Value = Starttime;
			parameters[3].Value = Endtime;
			parameters[4].Value = Username;
			parameters[5].Value = Realname;
			parameters[6].Value = Nowtimes;

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
			strSql.Append("update [MonthSet] set ");
			strSql.Append("Years=@Years,");
			strSql.Append("Months=@Months,");
			strSql.Append("Starttime=@Starttime,");
			strSql.Append("Endtime=@Endtime,");
			strSql.Append("Username=@Username,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Nowtimes=@Nowtimes");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Years", SqlDbType.NVarChar,50),
					new SqlParameter("@Months", SqlDbType.NVarChar,50),
					new SqlParameter("@Starttime", SqlDbType.DateTime),
					new SqlParameter("@Endtime", SqlDbType.DateTime),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = Years;
			parameters[1].Value = Months;
			parameters[2].Value = Starttime;
			parameters[3].Value = Endtime;
			parameters[4].Value = Username;
			parameters[5].Value = Realname;
			parameters[6].Value = Nowtimes;
			parameters[7].Value = id;

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
		public bool Delete(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [MonthSet] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

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
		public void GetModel(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Years,Months,Starttime,Endtime,Username,Realname,Nowtimes ");
			strSql.Append(" FROM [MonthSet] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.id=long.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Years"]!=null )
				{
					this.Years=ds.Tables[0].Rows[0]["Years"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Months"]!=null )
				{
					this.Months=ds.Tables[0].Rows[0]["Months"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Starttime"]!=null && ds.Tables[0].Rows[0]["Starttime"].ToString()!="")
				{
					this.Starttime=DateTime.Parse(ds.Tables[0].Rows[0]["Starttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Endtime"]!=null && ds.Tables[0].Rows[0]["Endtime"].ToString()!="")
				{
					this.Endtime=DateTime.Parse(ds.Tables[0].Rows[0]["Endtime"].ToString());
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
			strSql.Append(" FROM [MonthSet] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

