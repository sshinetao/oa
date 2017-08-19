using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类Xssk_WorkStreamName。
	/// </summary>
	[Serializable]
	public partial class Xssk_WorkStreamName
	{
		public Xssk_WorkStreamName()
		{}
		#region Model
		private long _id;
		private string _name_type;
		private string _name_jd;
		private string _username;
		private string _realname;
		private string _keyfile;
		private string _bigid;
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
		public string Name_type
		{
			set{ _name_type=value;}
			get{return _name_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name_Jd
		{
			set{ _name_jd=value;}
			get{return _name_jd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string realname
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KeyFile
		{
			set{ _keyfile=value;}
			get{return _keyfile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BigId
		{
			set{ _bigid=value;}
			get{return _bigid;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Xssk_WorkStreamName(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Name_type,Name_Jd,username,realname,KeyFile,BigId ");
			strSql.Append(" FROM [Xssk_WorkStreamName] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["Name_type"]!=null)
				{
					this.Name_type=ds.Tables[0].Rows[0]["Name_type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Name_Jd"]!=null)
				{
					this.Name_Jd=ds.Tables[0].Rows[0]["Name_Jd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["username"]!=null)
				{
					this.username=ds.Tables[0].Rows[0]["username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["realname"]!=null)
				{
					this.realname=ds.Tables[0].Rows[0]["realname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["KeyFile"]!=null)
				{
					this.KeyFile=ds.Tables[0].Rows[0]["KeyFile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BigId"]!=null)
				{
					this.BigId=ds.Tables[0].Rows[0]["BigId"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Xssk_WorkStreamName]");
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
			strSql.Append("insert into [Xssk_WorkStreamName] (");
			strSql.Append("Name_type,Name_Jd,username,realname,KeyFile,BigId)");
			strSql.Append(" values (");
			strSql.Append("@Name_type,@Name_Jd,@username,@realname,@KeyFile,@BigId)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name_type", SqlDbType.NVarChar,50),
					new SqlParameter("@Name_Jd", SqlDbType.NVarChar,50),
					new SqlParameter("@username", SqlDbType.NVarChar,50),
					new SqlParameter("@realname", SqlDbType.NVarChar,50),
					new SqlParameter("@KeyFile", SqlDbType.NVarChar,50),
					new SqlParameter("@BigId", SqlDbType.NVarChar,4000)};
			parameters[0].Value = Name_type;
			parameters[1].Value = Name_Jd;
			parameters[2].Value = username;
			parameters[3].Value = realname;
			parameters[4].Value = KeyFile;
			parameters[5].Value = BigId;

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
			strSql.Append("update [Xssk_WorkStreamName] set ");
			strSql.Append("Name_type=@Name_type,");
			strSql.Append("Name_Jd=@Name_Jd,");
			strSql.Append("username=@username,");
			strSql.Append("realname=@realname,");
			strSql.Append("KeyFile=@KeyFile,");
			strSql.Append("BigId=@BigId");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name_type", SqlDbType.NVarChar,50),
					new SqlParameter("@Name_Jd", SqlDbType.NVarChar,50),
					new SqlParameter("@username", SqlDbType.NVarChar,50),
					new SqlParameter("@realname", SqlDbType.NVarChar,50),
					new SqlParameter("@KeyFile", SqlDbType.NVarChar,50),
					new SqlParameter("@BigId", SqlDbType.NVarChar,4000),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = Name_type;
			parameters[1].Value = Name_Jd;
			parameters[2].Value = username;
			parameters[3].Value = realname;
			parameters[4].Value = KeyFile;
			parameters[5].Value = BigId;
			parameters[6].Value = id;

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
			strSql.Append("delete from [Xssk_WorkStreamName] ");
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
			strSql.Append("select id,Name_type,Name_Jd,username,realname,KeyFile,BigId ");
			strSql.Append(" FROM [Xssk_WorkStreamName] ");
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
				if(ds.Tables[0].Rows[0]["Name_type"]!=null )
				{
					this.Name_type=ds.Tables[0].Rows[0]["Name_type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Name_Jd"]!=null )
				{
					this.Name_Jd=ds.Tables[0].Rows[0]["Name_Jd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["username"]!=null )
				{
					this.username=ds.Tables[0].Rows[0]["username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["realname"]!=null )
				{
					this.realname=ds.Tables[0].Rows[0]["realname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["KeyFile"]!=null )
				{
					this.KeyFile=ds.Tables[0].Rows[0]["KeyFile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BigId"]!=null )
				{
					this.BigId=ds.Tables[0].Rows[0]["BigId"].ToString();
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
			strSql.Append(" FROM [Xssk_WorkStreamName] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

