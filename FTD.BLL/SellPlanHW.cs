using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类SellPlanHW。
	/// </summary>
	[Serializable]
	public partial class SellPlanHW
	{
		public SellPlanHW()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _goodsnumber;
		private string _goodsname;
		private string _type;
		private decimal? _limit;
		private DateTime? _starttime;
		private DateTime? _endtime;
		private string _state;
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
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Limit
		{
			set{ _limit=value;}
			get{return _limit;}
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
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SellPlanHW(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,number,GoodsNumber,GoodsName,Type,Limit,Starttime,Endtime,State ");
			strSql.Append(" FROM [SellPlanHW] ");
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
				if(ds.Tables[0].Rows[0]["GoodsNumber"]!=null)
				{
					this.GoodsNumber=ds.Tables[0].Rows[0]["GoodsNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GoodsName"]!=null)
				{
					this.GoodsName=ds.Tables[0].Rows[0]["GoodsName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Limit"]!=null && ds.Tables[0].Rows[0]["Limit"].ToString()!="")
				{
					this.Limit=decimal.Parse(ds.Tables[0].Rows[0]["Limit"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Starttime"]!=null && ds.Tables[0].Rows[0]["Starttime"].ToString()!="")
				{
					this.Starttime=DateTime.Parse(ds.Tables[0].Rows[0]["Starttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Endtime"]!=null && ds.Tables[0].Rows[0]["Endtime"].ToString()!="")
				{
					this.Endtime=DateTime.Parse(ds.Tables[0].Rows[0]["Endtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null)
				{
					this.State=ds.Tables[0].Rows[0]["State"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [SellPlanHW]");
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
			strSql.Append("insert into [SellPlanHW] (");
			strSql.Append("number,GoodsNumber,GoodsName,Type,Limit,Starttime,Endtime,State)");
			strSql.Append(" values (");
			strSql.Append("@number,@GoodsNumber,@GoodsName,@Type,@Limit,@Starttime,@Endtime,@State)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Limit", SqlDbType.Decimal,9),
					new SqlParameter("@Starttime", SqlDbType.DateTime),
					new SqlParameter("@Endtime", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.NVarChar,50)};
			parameters[0].Value = number;
			parameters[1].Value = GoodsNumber;
			parameters[2].Value = GoodsName;
			parameters[3].Value = Type;
			parameters[4].Value = Limit;
			parameters[5].Value = Starttime;
			parameters[6].Value = Endtime;
			parameters[7].Value = State;

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
			strSql.Append("update [SellPlanHW] set ");
			strSql.Append("number=@number,");
			strSql.Append("GoodsNumber=@GoodsNumber,");
			strSql.Append("GoodsName=@GoodsName,");
			strSql.Append("Type=@Type,");
			strSql.Append("Limit=@Limit,");
			strSql.Append("Starttime=@Starttime,");
			strSql.Append("Endtime=@Endtime,");
			strSql.Append("State=@State");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Limit", SqlDbType.Decimal,9),
					new SqlParameter("@Starttime", SqlDbType.DateTime),
					new SqlParameter("@Endtime", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = number;
			parameters[1].Value = GoodsNumber;
			parameters[2].Value = GoodsName;
			parameters[3].Value = Type;
			parameters[4].Value = Limit;
			parameters[5].Value = Starttime;
			parameters[6].Value = Endtime;
			parameters[7].Value = State;
			parameters[8].Value = Id;

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
			strSql.Append("delete from [SellPlanHW] ");
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
			strSql.Append("select Id,number,GoodsNumber,GoodsName,Type,Limit,Starttime,Endtime,State ");
			strSql.Append(" FROM [SellPlanHW] ");
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
				if(ds.Tables[0].Rows[0]["GoodsNumber"]!=null )
				{
					this.GoodsNumber=ds.Tables[0].Rows[0]["GoodsNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GoodsName"]!=null )
				{
					this.GoodsName=ds.Tables[0].Rows[0]["GoodsName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Limit"]!=null && ds.Tables[0].Rows[0]["Limit"].ToString()!="")
				{
					this.Limit=decimal.Parse(ds.Tables[0].Rows[0]["Limit"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Starttime"]!=null && ds.Tables[0].Rows[0]["Starttime"].ToString()!="")
				{
					this.Starttime=DateTime.Parse(ds.Tables[0].Rows[0]["Starttime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Endtime"]!=null && ds.Tables[0].Rows[0]["Endtime"].ToString()!="")
				{
					this.Endtime=DateTime.Parse(ds.Tables[0].Rows[0]["Endtime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null )
				{
					this.State=ds.Tables[0].Rows[0]["State"].ToString();
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
			strSql.Append(" FROM [SellPlanHW] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

