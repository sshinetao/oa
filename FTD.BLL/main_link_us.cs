using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类main_link_us。
	/// </summary>
	[Serializable]
	public partial class main_link_us
	{
		public main_link_us()
		{}
		#region Model
		private long _id;
		private string _name;
		private string _url;
		private decimal? _tbyte;
		private string _username;
		private string _realname;
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
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Tbyte
		{
			set{ _tbyte=value;}
			get{return _tbyte;}
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
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public main_link_us(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,name,url,Tbyte,username,realname ");
			strSql.Append(" FROM [main_link_us] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["name"]!=null)
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["url"]!=null)
				{
					this.url=ds.Tables[0].Rows[0]["url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tbyte"]!=null && ds.Tables[0].Rows[0]["Tbyte"].ToString()!="")
				{
					this.Tbyte=decimal.Parse(ds.Tables[0].Rows[0]["Tbyte"].ToString());
				}
				if(ds.Tables[0].Rows[0]["username"]!=null)
				{
					this.username=ds.Tables[0].Rows[0]["username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["realname"]!=null)
				{
					this.realname=ds.Tables[0].Rows[0]["realname"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [main_link_us]");
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
			strSql.Append("insert into [main_link_us] (");
			strSql.Append("name,url,Tbyte,username,realname)");
			strSql.Append(" values (");
			strSql.Append("@name,@url,@Tbyte,@username,@realname)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,500),
					new SqlParameter("@url", SqlDbType.NVarChar,500),
					new SqlParameter("@Tbyte", SqlDbType.Decimal,9),
					new SqlParameter("@username", SqlDbType.NVarChar,50),
					new SqlParameter("@realname", SqlDbType.NVarChar,50)};
			parameters[0].Value = name;
			parameters[1].Value = url;
			parameters[2].Value = Tbyte;
			parameters[3].Value = username;
			parameters[4].Value = realname;

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
			strSql.Append("update [main_link_us] set ");
			strSql.Append("name=@name,");
			strSql.Append("url=@url,");
			strSql.Append("Tbyte=@Tbyte,");
			strSql.Append("username=@username,");
			strSql.Append("realname=@realname");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,500),
					new SqlParameter("@url", SqlDbType.NVarChar,500),
					new SqlParameter("@Tbyte", SqlDbType.Decimal,9),
					new SqlParameter("@username", SqlDbType.NVarChar,50),
					new SqlParameter("@realname", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = name;
			parameters[1].Value = url;
			parameters[2].Value = Tbyte;
			parameters[3].Value = username;
			parameters[4].Value = realname;
			parameters[5].Value = id;

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
			strSql.Append("delete from [main_link_us] ");
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
			strSql.Append("select id,name,url,Tbyte,username,realname ");
			strSql.Append(" FROM [main_link_us] ");
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
				if(ds.Tables[0].Rows[0]["name"]!=null )
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["url"]!=null )
				{
					this.url=ds.Tables[0].Rows[0]["url"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tbyte"]!=null && ds.Tables[0].Rows[0]["Tbyte"].ToString()!="")
				{
					this.Tbyte=decimal.Parse(ds.Tables[0].Rows[0]["Tbyte"].ToString());
				}
				if(ds.Tables[0].Rows[0]["username"]!=null )
				{
					this.username=ds.Tables[0].Rows[0]["username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["realname"]!=null )
				{
					this.realname=ds.Tables[0].Rows[0]["realname"].ToString();
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
			strSql.Append(" FROM [main_link_us] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

