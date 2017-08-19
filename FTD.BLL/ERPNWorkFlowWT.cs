using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPNWorkFlowWT。
	/// </summary>
	[Serializable]
	public partial class ERPNWorkFlowWT
	{
		public ERPNWorkFlowWT()
		{}
		#region Model
		private int _id;
		private string _fromuser;
		private string _touser;
		private int? _days;
		private DateTime? _daytime;
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
		public string FromUser
		{
			set{ _fromuser=value;}
			get{return _fromuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToUser
		{
			set{ _touser=value;}
			get{return _touser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Days
		{
			set{ _days=value;}
			get{return _days;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DayTime
		{
			set{ _daytime=value;}
			get{return _daytime;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPNWorkFlowWT(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,FromUser,ToUser,Days,DayTime ");
			strSql.Append(" FROM [ERPNWorkFlowWT] ");
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
				if(ds.Tables[0].Rows[0]["FromUser"]!=null)
				{
					this.FromUser=ds.Tables[0].Rows[0]["FromUser"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ToUser"]!=null)
				{
					this.ToUser=ds.Tables[0].Rows[0]["ToUser"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Days"]!=null && ds.Tables[0].Rows[0]["Days"].ToString()!="")
				{
					this.Days=int.Parse(ds.Tables[0].Rows[0]["Days"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DayTime"]!=null && ds.Tables[0].Rows[0]["DayTime"].ToString()!="")
				{
					this.DayTime=DateTime.Parse(ds.Tables[0].Rows[0]["DayTime"].ToString());
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPNWorkFlowWT"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [ERPNWorkFlowWT]");
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
			strSql.Append("insert into [ERPNWorkFlowWT] (");
			strSql.Append("FromUser,ToUser,Days,DayTime)");
			strSql.Append(" values (");
			strSql.Append("@FromUser,@ToUser,@Days,@DayTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FromUser", SqlDbType.VarChar,50),
					new SqlParameter("@ToUser", SqlDbType.VarChar,50),
					new SqlParameter("@Days", SqlDbType.Int,4),
					new SqlParameter("@DayTime", SqlDbType.DateTime)};
			parameters[0].Value = FromUser;
			parameters[1].Value = ToUser;
			parameters[2].Value = Days;
			parameters[3].Value = DayTime;

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
			strSql.Append("update [ERPNWorkFlowWT] set ");
			strSql.Append("FromUser=@FromUser,");
			strSql.Append("ToUser=@ToUser,");
			strSql.Append("Days=@Days,");
			strSql.Append("DayTime=@DayTime");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@FromUser", SqlDbType.VarChar,50),
					new SqlParameter("@ToUser", SqlDbType.VarChar,50),
					new SqlParameter("@Days", SqlDbType.Int,4),
					new SqlParameter("@DayTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = FromUser;
			parameters[1].Value = ToUser;
			parameters[2].Value = Days;
			parameters[3].Value = DayTime;
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
			strSql.Append("delete from [ERPNWorkFlowWT] ");
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
			strSql.Append("select ID,FromUser,ToUser,Days,DayTime ");
			strSql.Append(" FROM [ERPNWorkFlowWT] ");
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
				if(ds.Tables[0].Rows[0]["FromUser"]!=null )
				{
					this.FromUser=ds.Tables[0].Rows[0]["FromUser"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ToUser"]!=null )
				{
					this.ToUser=ds.Tables[0].Rows[0]["ToUser"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Days"]!=null && ds.Tables[0].Rows[0]["Days"].ToString()!="")
				{
					this.Days=int.Parse(ds.Tables[0].Rows[0]["Days"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DayTime"]!=null && ds.Tables[0].Rows[0]["DayTime"].ToString()!="")
				{
					this.DayTime=DateTime.Parse(ds.Tables[0].Rows[0]["DayTime"].ToString());
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
			strSql.Append(" FROM [ERPNWorkFlowWT] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

