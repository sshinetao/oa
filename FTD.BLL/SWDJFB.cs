using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类SWDJFB。
	/// </summary>
	[Serializable]
	public partial class SWDJFB
	{
		public SWDJFB()
		{}
		#region Model
		private int _id;
		private int? _workformid;
		private string _username;
		private string _lbxx;
		private string _bhxx;
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
		public int? WorkFormID
		{
			set{ _workformid=value;}
			get{return _workformid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LBXX
		{
			set{ _lbxx=value;}
			get{return _lbxx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BHXX
		{
			set{ _bhxx=value;}
			get{return _bhxx;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SWDJFB(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,WorkFormID,UserName,LBXX,BHXX ");
			strSql.Append(" FROM [SWDJFB] ");
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
				if(ds.Tables[0].Rows[0]["WorkFormID"]!=null && ds.Tables[0].Rows[0]["WorkFormID"].ToString()!="")
				{
					this.WorkFormID=int.Parse(ds.Tables[0].Rows[0]["WorkFormID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null)
				{
					this.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LBXX"]!=null)
				{
					this.LBXX=ds.Tables[0].Rows[0]["LBXX"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BHXX"]!=null)
				{
					this.BHXX=ds.Tables[0].Rows[0]["BHXX"].ToString();
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "SWDJFB"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [SWDJFB]");
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
			strSql.Append("insert into [SWDJFB] (");
			strSql.Append("WorkFormID,UserName,LBXX,BHXX)");
			strSql.Append(" values (");
			strSql.Append("@WorkFormID,@UserName,@LBXX,@BHXX)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkFormID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@LBXX", SqlDbType.NVarChar,100),
					new SqlParameter("@BHXX", SqlDbType.NVarChar,100)};
			parameters[0].Value = WorkFormID;
			parameters[1].Value = UserName;
			parameters[2].Value = LBXX;
			parameters[3].Value = BHXX;

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
			strSql.Append("update [SWDJFB] set ");
			strSql.Append("WorkFormID=@WorkFormID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("LBXX=@LBXX,");
			strSql.Append("BHXX=@BHXX");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@WorkFormID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.VarChar,100),
					new SqlParameter("@LBXX", SqlDbType.NVarChar,100),
					new SqlParameter("@BHXX", SqlDbType.NVarChar,100),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = WorkFormID;
			parameters[1].Value = UserName;
			parameters[2].Value = LBXX;
			parameters[3].Value = BHXX;
			parameters[4].Value = ID;

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
			strSql.Append("delete from [SWDJFB] ");
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
			strSql.Append("select ID,WorkFormID,UserName,LBXX,BHXX ");
			strSql.Append(" FROM [SWDJFB] ");
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
				if(ds.Tables[0].Rows[0]["WorkFormID"]!=null && ds.Tables[0].Rows[0]["WorkFormID"].ToString()!="")
				{
					this.WorkFormID=int.Parse(ds.Tables[0].Rows[0]["WorkFormID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null )
				{
					this.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LBXX"]!=null )
				{
					this.LBXX=ds.Tables[0].Rows[0]["LBXX"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BHXX"]!=null )
				{
					this.BHXX=ds.Tables[0].Rows[0]["BHXX"].ToString();
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
			strSql.Append(" FROM [SWDJFB] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

