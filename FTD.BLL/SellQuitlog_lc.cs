using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类SellQuitlog_lc。
	/// </summary>
	[Serializable]
	public partial class SellQuitlog_lc
	{
		public SellQuitlog_lc()
		{}
		#region Model
		private long _id;
		private string _title;
		private DateTime? _settime;
		private string _keyfield;
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
		public string title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? settime
		{
			set{ _settime=value;}
			get{return _settime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KeyField
		{
			set{ _keyfield=value;}
			get{return _keyfield;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SellQuitlog_lc(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,title,settime,KeyField ");
			strSql.Append(" FROM [SellQuitlog_lc] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["title"]!=null)
				{
					this.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["settime"]!=null && ds.Tables[0].Rows[0]["settime"].ToString()!="")
				{
					this.settime=DateTime.Parse(ds.Tables[0].Rows[0]["settime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["KeyField"]!=null)
				{
					this.KeyField=ds.Tables[0].Rows[0]["KeyField"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [SellQuitlog_lc]");
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
			strSql.Append("insert into [SellQuitlog_lc] (");
			strSql.Append("title,settime,KeyField)");
			strSql.Append(" values (");
			strSql.Append("@title,@settime,@KeyField)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.NText),
					new SqlParameter("@settime", SqlDbType.DateTime),
					new SqlParameter("@KeyField", SqlDbType.NVarChar,50)};
			parameters[0].Value = title;
			parameters[1].Value = settime;
			parameters[2].Value = KeyField;

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
			strSql.Append("update [SellQuitlog_lc] set ");
			strSql.Append("title=@title,");
			strSql.Append("settime=@settime,");
			strSql.Append("KeyField=@KeyField");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.NText),
					new SqlParameter("@settime", SqlDbType.DateTime),
					new SqlParameter("@KeyField", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = title;
			parameters[1].Value = settime;
			parameters[2].Value = KeyField;
			parameters[3].Value = id;

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
			strSql.Append("delete from [SellQuitlog_lc] ");
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
			strSql.Append("select id,title,settime,KeyField ");
			strSql.Append(" FROM [SellQuitlog_lc] ");
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
				if(ds.Tables[0].Rows[0]["title"]!=null )
				{
					this.title=ds.Tables[0].Rows[0]["title"].ToString();
				}
				if(ds.Tables[0].Rows[0]["settime"]!=null && ds.Tables[0].Rows[0]["settime"].ToString()!="")
				{
					this.settime=DateTime.Parse(ds.Tables[0].Rows[0]["settime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["KeyField"]!=null )
				{
					this.KeyField=ds.Tables[0].Rows[0]["KeyField"].ToString();
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
			strSql.Append(" FROM [SellQuitlog_lc] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

