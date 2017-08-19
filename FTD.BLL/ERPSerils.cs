using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPSerils。
	/// </summary>
	[Serializable]
	public partial class ERPSerils
	{
		public ERPSerils()
		{}
		#region Model
		private int _id;
		private string _serilsstr;
		private string _datestr;
		private string _usernum;
		private string _danweistr;
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
		public string SerilsStr
		{
			set{ _serilsstr=value;}
			get{return _serilsstr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DateStr
		{
			set{ _datestr=value;}
			get{return _datestr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserNum
		{
			set{ _usernum=value;}
			get{return _usernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DanWeiStr
		{
			set{ _danweistr=value;}
			get{return _danweistr;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPSerils(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,SerilsStr,DateStr,UserNum,DanWeiStr ");
			strSql.Append(" FROM [ERPSerils] ");
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
				if(ds.Tables[0].Rows[0]["SerilsStr"]!=null)
				{
					this.SerilsStr=ds.Tables[0].Rows[0]["SerilsStr"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DateStr"]!=null)
				{
					this.DateStr=ds.Tables[0].Rows[0]["DateStr"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserNum"]!=null)
				{
					this.UserNum=ds.Tables[0].Rows[0]["UserNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DanWeiStr"]!=null)
				{
					this.DanWeiStr=ds.Tables[0].Rows[0]["DanWeiStr"].ToString();
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPSerils"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [ERPSerils]");
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
			strSql.Append("insert into [ERPSerils] (");
			strSql.Append("SerilsStr,DateStr,UserNum,DanWeiStr)");
			strSql.Append(" values (");
			strSql.Append("@SerilsStr,@DateStr,@UserNum,@DanWeiStr)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SerilsStr", SqlDbType.VarChar,200),
					new SqlParameter("@DateStr", SqlDbType.VarChar,200),
					new SqlParameter("@UserNum", SqlDbType.VarChar,50),
					new SqlParameter("@DanWeiStr", SqlDbType.VarChar,5000)};
			parameters[0].Value = SerilsStr;
			parameters[1].Value = DateStr;
			parameters[2].Value = UserNum;
			parameters[3].Value = DanWeiStr;

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
			strSql.Append("update [ERPSerils] set ");
			strSql.Append("SerilsStr=@SerilsStr,");
			strSql.Append("DateStr=@DateStr,");
			strSql.Append("UserNum=@UserNum,");
			strSql.Append("DanWeiStr=@DanWeiStr");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@SerilsStr", SqlDbType.VarChar,200),
					new SqlParameter("@DateStr", SqlDbType.VarChar,200),
					new SqlParameter("@UserNum", SqlDbType.VarChar,50),
					new SqlParameter("@DanWeiStr", SqlDbType.VarChar,5000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = SerilsStr;
			parameters[1].Value = DateStr;
			parameters[2].Value = UserNum;
			parameters[3].Value = DanWeiStr;
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
			strSql.Append("delete from [ERPSerils] ");
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
			strSql.Append("select ID,SerilsStr,DateStr,UserNum,DanWeiStr ");
			strSql.Append(" FROM [ERPSerils] ");
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
				if(ds.Tables[0].Rows[0]["SerilsStr"]!=null )
				{
					this.SerilsStr=ds.Tables[0].Rows[0]["SerilsStr"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DateStr"]!=null )
				{
					this.DateStr=ds.Tables[0].Rows[0]["DateStr"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserNum"]!=null )
				{
					this.UserNum=ds.Tables[0].Rows[0]["UserNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DanWeiStr"]!=null )
				{
					this.DanWeiStr=ds.Tables[0].Rows[0]["DanWeiStr"].ToString();
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
			strSql.Append(" FROM [ERPSerils] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

