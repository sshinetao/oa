using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类main_tx。
	/// </summary>
	[Serializable]
	public partial class main_tx
	{
		public main_tx()
		{}
		#region Model
		private long _id;
		private string _iftx;
		private string _txtime;
		private string _username;
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
		public string iftx
		{
			set{ _iftx=value;}
			get{return _iftx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string txtime
		{
			set{ _txtime=value;}
			get{return _txtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public main_tx(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,iftx,txtime,username ");
			strSql.Append(" FROM [main_tx] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["iftx"]!=null)
				{
					this.iftx=ds.Tables[0].Rows[0]["iftx"].ToString();
				}
				if(ds.Tables[0].Rows[0]["txtime"]!=null)
				{
					this.txtime=ds.Tables[0].Rows[0]["txtime"].ToString();
				}
				if(ds.Tables[0].Rows[0]["username"]!=null)
				{
					this.username=ds.Tables[0].Rows[0]["username"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [main_tx]");
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
			strSql.Append("insert into [main_tx] (");
			strSql.Append("iftx,txtime,username)");
			strSql.Append(" values (");
			strSql.Append("@iftx,@txtime,@username)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@iftx", SqlDbType.NVarChar,50),
					new SqlParameter("@txtime", SqlDbType.NVarChar,50),
					new SqlParameter("@username", SqlDbType.NVarChar,50)};
			parameters[0].Value = iftx;
			parameters[1].Value = txtime;
			parameters[2].Value = username;

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
			strSql.Append("update [main_tx] set ");
			strSql.Append("iftx=@iftx,");
			strSql.Append("txtime=@txtime,");
			strSql.Append("username=@username");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@iftx", SqlDbType.NVarChar,50),
					new SqlParameter("@txtime", SqlDbType.NVarChar,50),
					new SqlParameter("@username", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = iftx;
			parameters[1].Value = txtime;
			parameters[2].Value = username;
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
			strSql.Append("delete from [main_tx] ");
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
			strSql.Append("select id,iftx,txtime,username ");
			strSql.Append(" FROM [main_tx] ");
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
				if(ds.Tables[0].Rows[0]["iftx"]!=null )
				{
					this.iftx=ds.Tables[0].Rows[0]["iftx"].ToString();
				}
				if(ds.Tables[0].Rows[0]["txtime"]!=null )
				{
					this.txtime=ds.Tables[0].Rows[0]["txtime"].ToString();
				}
				if(ds.Tables[0].Rows[0]["username"]!=null )
				{
					this.username=ds.Tables[0].Rows[0]["username"].ToString();
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
			strSql.Append(" FROM [main_tx] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

