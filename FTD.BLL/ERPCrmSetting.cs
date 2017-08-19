﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPCrmSetting。
	/// </summary>
	[Serializable]
	public partial class ERPCrmSetting
	{
		public ERPCrmSetting()
		{}
		#region Model
		private int _id;
		private string _tablename;
		private string _liename;
		private string _canshuname;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TableName
		{
			set{ _tablename=value;}
			get{return _tablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LieName
		{
			set{ _liename=value;}
			get{return _liename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CanShuName
		{
			set{ _canshuname=value;}
			get{return _canshuname;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPCrmSetting(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,TableName,LieName,CanShuName ");
			strSql.Append(" FROM [ERPCrmSetting] ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TableName"]!=null)
				{
					this.TableName=ds.Tables[0].Rows[0]["TableName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LieName"]!=null)
				{
					this.LieName=ds.Tables[0].Rows[0]["LieName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CanShuName"]!=null)
				{
					this.CanShuName=ds.Tables[0].Rows[0]["CanShuName"].ToString();
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPCrmSetting"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [ERPCrmSetting]");
			strSql.Append(" where ID=@ID ");

			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [ERPCrmSetting] (");
			strSql.Append("TableName,LieName,CanShuName)");
			strSql.Append(" values (");
			strSql.Append("@TableName,@LieName,@CanShuName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TableName", SqlDbType.VarChar,100),
					new SqlParameter("@LieName", SqlDbType.VarChar,100),
					new SqlParameter("@CanShuName", SqlDbType.VarChar,100)};
			parameters[0].Value = TableName;
			parameters[1].Value = LieName;
			parameters[2].Value = CanShuName;

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
			strSql.Append("update [ERPCrmSetting] set ");
			strSql.Append("TableName=@TableName,");
			strSql.Append("LieName=@LieName,");
			strSql.Append("CanShuName=@CanShuName");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@TableName", SqlDbType.VarChar,100),
					new SqlParameter("@LieName", SqlDbType.VarChar,100),
					new SqlParameter("@CanShuName", SqlDbType.VarChar,100),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = TableName;
			parameters[1].Value = LieName;
			parameters[2].Value = CanShuName;
			parameters[3].Value = ID;

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
		public bool Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [ERPCrmSetting] ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

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
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,TableName,LieName,CanShuName ");
			strSql.Append(" FROM [ERPCrmSetting] ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					this.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TableName"]!=null )
				{
					this.TableName=ds.Tables[0].Rows[0]["TableName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LieName"]!=null )
				{
					this.LieName=ds.Tables[0].Rows[0]["LieName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CanShuName"]!=null )
				{
					this.CanShuName=ds.Tables[0].Rows[0]["CanShuName"].ToString();
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
			strSql.Append(" FROM [ERPCrmSetting] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

