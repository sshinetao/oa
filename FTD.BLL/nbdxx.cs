using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类nbdxx。
	/// </summary>
	[Serializable]
	public partial class nbdxx
	{
		public nbdxx()
		{}
		#region Model
		private long _id;
		private string _title;
		private string _content;
		private DateTime _itimes;
		private string _acceptusername;
		private string _acceptrealname;
		private string _sendusername;
		private string _sendrealname;
		private string _sfck;
		private string _number;
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
		public string content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime itimes
		{
			set{ _itimes=value;}
			get{return _itimes;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string acceptusername
		{
			set{ _acceptusername=value;}
			get{return _acceptusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string acceptrealname
		{
			set{ _acceptrealname=value;}
			get{return _acceptrealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sendusername
		{
			set{ _sendusername=value;}
			get{return _sendusername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sendrealname
		{
			set{ _sendrealname=value;}
			get{return _sendrealname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sfck
		{
			set{ _sfck=value;}
			get{return _sfck;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string number
		{
			set{ _number=value;}
			get{return _number;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public nbdxx(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,title,content,itimes,acceptusername,acceptrealname,sendusername,sendrealname,sfck,number ");
			strSql.Append(" FROM [nbdxx] ");
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
				if(ds.Tables[0].Rows[0]["content"]!=null)
				{
					this.content=ds.Tables[0].Rows[0]["content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["itimes"]!=null && ds.Tables[0].Rows[0]["itimes"].ToString()!="")
				{
					this.itimes=DateTime.Parse(ds.Tables[0].Rows[0]["itimes"].ToString());
				}
				if(ds.Tables[0].Rows[0]["acceptusername"]!=null)
				{
					this.acceptusername=ds.Tables[0].Rows[0]["acceptusername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["acceptrealname"]!=null)
				{
					this.acceptrealname=ds.Tables[0].Rows[0]["acceptrealname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sendusername"]!=null)
				{
					this.sendusername=ds.Tables[0].Rows[0]["sendusername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sendrealname"]!=null)
				{
					this.sendrealname=ds.Tables[0].Rows[0]["sendrealname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sfck"]!=null)
				{
					this.sfck=ds.Tables[0].Rows[0]["sfck"].ToString();
				}
				if(ds.Tables[0].Rows[0]["number"]!=null)
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [nbdxx]");
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
			strSql.Append("insert into [nbdxx] (");
			strSql.Append("title,content,itimes,acceptusername,acceptrealname,sendusername,sendrealname,sfck,number)");
			strSql.Append(" values (");
			strSql.Append("@title,@content,@itimes,@acceptusername,@acceptrealname,@sendusername,@sendrealname,@sfck,@number)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@content", SqlDbType.NText),
					new SqlParameter("@itimes", SqlDbType.DateTime),
					new SqlParameter("@acceptusername", SqlDbType.NVarChar,50),
					new SqlParameter("@acceptrealname", SqlDbType.NVarChar,50),
					new SqlParameter("@sendusername", SqlDbType.NVarChar,50),
					new SqlParameter("@sendrealname", SqlDbType.NVarChar,50),
					new SqlParameter("@sfck", SqlDbType.NVarChar,50),
					new SqlParameter("@number", SqlDbType.NVarChar,50)};
			parameters[0].Value = title;
			parameters[1].Value = content;
			parameters[2].Value = itimes;
			parameters[3].Value = acceptusername;
			parameters[4].Value = acceptrealname;
			parameters[5].Value = sendusername;
			parameters[6].Value = sendrealname;
			parameters[7].Value = sfck;
			parameters[8].Value = number;

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
			strSql.Append("update [nbdxx] set ");
			strSql.Append("title=@title,");
			strSql.Append("content=@content,");
			strSql.Append("itimes=@itimes,");
			strSql.Append("acceptusername=@acceptusername,");
			strSql.Append("acceptrealname=@acceptrealname,");
			strSql.Append("sendusername=@sendusername,");
			strSql.Append("sendrealname=@sendrealname,");
			strSql.Append("sfck=@sfck,");
			strSql.Append("number=@number");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.NVarChar,50),
					new SqlParameter("@content", SqlDbType.NText),
					new SqlParameter("@itimes", SqlDbType.DateTime),
					new SqlParameter("@acceptusername", SqlDbType.NVarChar,50),
					new SqlParameter("@acceptrealname", SqlDbType.NVarChar,50),
					new SqlParameter("@sendusername", SqlDbType.NVarChar,50),
					new SqlParameter("@sendrealname", SqlDbType.NVarChar,50),
					new SqlParameter("@sfck", SqlDbType.NVarChar,50),
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = title;
			parameters[1].Value = content;
			parameters[2].Value = itimes;
			parameters[3].Value = acceptusername;
			parameters[4].Value = acceptrealname;
			parameters[5].Value = sendusername;
			parameters[6].Value = sendrealname;
			parameters[7].Value = sfck;
			parameters[8].Value = number;
			parameters[9].Value = id;

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
			strSql.Append("delete from [nbdxx] ");
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
			strSql.Append("select id,title,content,itimes,acceptusername,acceptrealname,sendusername,sendrealname,sfck,number ");
			strSql.Append(" FROM [nbdxx] ");
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
				if(ds.Tables[0].Rows[0]["content"]!=null )
				{
					this.content=ds.Tables[0].Rows[0]["content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["itimes"]!=null && ds.Tables[0].Rows[0]["itimes"].ToString()!="")
				{
					this.itimes=DateTime.Parse(ds.Tables[0].Rows[0]["itimes"].ToString());
				}
				if(ds.Tables[0].Rows[0]["acceptusername"]!=null )
				{
					this.acceptusername=ds.Tables[0].Rows[0]["acceptusername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["acceptrealname"]!=null )
				{
					this.acceptrealname=ds.Tables[0].Rows[0]["acceptrealname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sendusername"]!=null )
				{
					this.sendusername=ds.Tables[0].Rows[0]["sendusername"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sendrealname"]!=null )
				{
					this.sendrealname=ds.Tables[0].Rows[0]["sendrealname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sfck"]!=null )
				{
					this.sfck=ds.Tables[0].Rows[0]["sfck"].ToString();
				}
				if(ds.Tables[0].Rows[0]["number"]!=null )
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
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
			strSql.Append(" FROM [nbdxx] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

