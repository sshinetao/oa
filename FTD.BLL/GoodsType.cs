﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类GoodsType。
	/// </summary>
	[Serializable]
	public partial class GoodsType
	{
		public GoodsType()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _name;
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
		public string Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GoodsType(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Number,Name ");
			strSql.Append(" FROM [GoodsType] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["Number"]!=null)
				{
					this.Number=ds.Tables[0].Rows[0]["Number"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Name"]!=null)
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [GoodsType]");
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
			strSql.Append("insert into [GoodsType] (");
			strSql.Append("Number,Name)");
			strSql.Append(" values (");
			strSql.Append("@Number,@Name)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Number", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50)};
			parameters[0].Value = Number;
			parameters[1].Value = Name;

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
			strSql.Append("update [GoodsType] set ");
			strSql.Append("Number=@Number,");
			strSql.Append("Name=@Name");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Number", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = Number;
			parameters[1].Value = Name;
			parameters[2].Value = id;

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
			strSql.Append("delete from [GoodsType] ");
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
			strSql.Append("select id,Number,Name ");
			strSql.Append(" FROM [GoodsType] ");
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
				if(ds.Tables[0].Rows[0]["Number"]!=null )
				{
					this.Number=ds.Tables[0].Rows[0]["Number"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Name"]!=null )
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
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
			strSql.Append(" FROM [GoodsType] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

