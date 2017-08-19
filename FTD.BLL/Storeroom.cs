using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类Storeroom。
	/// </summary>
	[Serializable]
	public partial class Storeroom
	{
		public Storeroom()
		{}
		#region Model
		private long _id;
		private string _name;
		private string _principal;
		private string _users;
		private string _ifpower;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Principal
		{
			set{ _principal=value;}
			get{return _principal;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Users
		{
			set{ _users=value;}
			get{return _users;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IfPower
		{
			set{ _ifpower=value;}
			get{return _ifpower;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Storeroom(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Name,Principal,Users,IfPower ");
			strSql.Append(" FROM [Storeroom] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["Name"]!=null)
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Principal"]!=null)
				{
					this.Principal=ds.Tables[0].Rows[0]["Principal"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Users"]!=null)
				{
					this.Users=ds.Tables[0].Rows[0]["Users"].ToString();
				}
				if(ds.Tables[0].Rows[0]["IfPower"]!=null)
				{
					this.IfPower=ds.Tables[0].Rows[0]["IfPower"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Storeroom]");
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
			strSql.Append("insert into [Storeroom] (");
			strSql.Append("Name,Principal,Users,IfPower)");
			strSql.Append(" values (");
			strSql.Append("@Name,@Principal,@Users,@IfPower)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Principal", SqlDbType.NVarChar,50),
					new SqlParameter("@Users", SqlDbType.NVarChar,50),
					new SqlParameter("@IfPower", SqlDbType.NVarChar,50)};
			parameters[0].Value = Name;
			parameters[1].Value = Principal;
			parameters[2].Value = Users;
			parameters[3].Value = IfPower;

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
			strSql.Append("update [Storeroom] set ");
			strSql.Append("Name=@Name,");
			strSql.Append("Principal=@Principal,");
			strSql.Append("Users=@Users,");
			strSql.Append("IfPower=@IfPower");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Principal", SqlDbType.NVarChar,50),
					new SqlParameter("@Users", SqlDbType.NVarChar,50),
					new SqlParameter("@IfPower", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = Name;
			parameters[1].Value = Principal;
			parameters[2].Value = Users;
			parameters[3].Value = IfPower;
			parameters[4].Value = id;

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
			strSql.Append("delete from [Storeroom] ");
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
			strSql.Append("select id,Name,Principal,Users,IfPower ");
			strSql.Append(" FROM [Storeroom] ");
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
				if(ds.Tables[0].Rows[0]["Name"]!=null )
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Principal"]!=null )
				{
					this.Principal=ds.Tables[0].Rows[0]["Principal"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Users"]!=null )
				{
					this.Users=ds.Tables[0].Rows[0]["Users"].ToString();
				}
				if(ds.Tables[0].Rows[0]["IfPower"]!=null )
				{
					this.IfPower=ds.Tables[0].Rows[0]["IfPower"].ToString();
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
			strSql.Append(" FROM [Storeroom] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

