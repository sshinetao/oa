using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类main_tc。
	/// </summary>
	[Serializable]
	public partial class main_tc
	{
		#region Model
		private string _width;
		private string _height;
		private string _content;
		private string _type;
		/// <summary>
		/// 
		/// </summary>
		public string width
		{
			set{ _width=value;}
			get{return _width;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string height
		{
			set{ _height=value;}
			get{return _height;}
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
		public string type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public main_tc()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select width,height,content,type ");
			strSql.Append(" FROM [main_tc] ");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
};

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["width"]!=null)
				{
					this.width=ds.Tables[0].Rows[0]["width"].ToString();
				}
				if(ds.Tables[0].Rows[0]["height"]!=null)
				{
					this.height=ds.Tables[0].Rows[0]["height"].ToString();
				}
				if(ds.Tables[0].Rows[0]["content"]!=null)
				{
					this.content=ds.Tables[0].Rows[0]["content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["type"]!=null)
				{
					this.type=ds.Tables[0].Rows[0]["type"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [main_tc]");
			//strSql.Append(" where 条件);

			SqlParameter[] parameters = {
};

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public void Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [main_tc] (");
			strSql.Append("width,height,content,type)");
			strSql.Append(" values (");
			strSql.Append("@width,@height,@content,@type)");
			SqlParameter[] parameters = {
					new SqlParameter("@width", SqlDbType.NVarChar,50),
					new SqlParameter("@height", SqlDbType.NVarChar,50),
					new SqlParameter("@content", SqlDbType.NText),
					new SqlParameter("@type", SqlDbType.NVarChar,50)};
			parameters[0].Value = width;
			parameters[1].Value = height;
			parameters[2].Value = content;
			parameters[3].Value = type;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update [main_tc] set ");
			strSql.Append("width=@width,");
			strSql.Append("height=@height,");
			strSql.Append("content=@content,");
			strSql.Append("type=@type");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
					new SqlParameter("@width", SqlDbType.NVarChar,50),
					new SqlParameter("@height", SqlDbType.NVarChar,50),
					new SqlParameter("@content", SqlDbType.NText),
					new SqlParameter("@type", SqlDbType.NVarChar,50)};
			parameters[0].Value = width;
			parameters[1].Value = height;
			parameters[2].Value = content;
			parameters[3].Value = type;

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
		public bool Delete()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [main_tc] ");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
};

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
		public void GetModel()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select width,height,content,type ");
			strSql.Append(" FROM [main_tc] ");
			//strSql.Append(" where 条件);
			SqlParameter[] parameters = {
};

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["width"]!=null )
				{
					this.width=ds.Tables[0].Rows[0]["width"].ToString();
				}
				if(ds.Tables[0].Rows[0]["height"]!=null )
				{
					this.height=ds.Tables[0].Rows[0]["height"].ToString();
				}
				if(ds.Tables[0].Rows[0]["content"]!=null )
				{
					this.content=ds.Tables[0].Rows[0]["content"].ToString();
				}
				if(ds.Tables[0].Rows[0]["type"]!=null )
				{
					this.type=ds.Tables[0].Rows[0]["type"].ToString();
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
			strSql.Append(" FROM [main_tc] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

