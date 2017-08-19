using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPRecive。
	/// </summary>
	[Serializable]
	public partial class ERPRecive
	{
		public ERPRecive()
		{}
		#region Model
		private int _id;
		private string _hetongname;
		private string _qianyuekehu;
		private DateTime? _daokuandate;
		private DateTime? _tixingdate;
		private DateTime? _createtime= DateTime.Now;
		private string _createuser;
		private string _backinfo;
		private string _nowstate;
		private string _htje;
		private string _sfdk= "0";
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
		public string HeTongName
		{
			set{ _hetongname=value;}
			get{return _hetongname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QianYueKeHu
		{
			set{ _qianyuekehu=value;}
			get{return _qianyuekehu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DaoKuanDate
		{
			set{ _daokuandate=value;}
			get{return _daokuandate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TiXingDate
		{
			set{ _tixingdate=value;}
			get{return _tixingdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CreateUser
		{
			set{ _createuser=value;}
			get{return _createuser;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NowState
		{
			set{ _nowstate=value;}
			get{return _nowstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HTJE
		{
			set{ _htje=value;}
			get{return _htje;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SFDK
		{
			set{ _sfdk=value;}
			get{return _sfdk;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPRecive(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,HeTongName,QianYueKeHu,DaoKuanDate,TiXingDate,CreateTime,CreateUser,BackInfo,NowState,HTJE,SFDK ");
			strSql.Append(" FROM [ERPRecive] ");
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
				if(ds.Tables[0].Rows[0]["HeTongName"]!=null)
				{
					this.HeTongName=ds.Tables[0].Rows[0]["HeTongName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QianYueKeHu"]!=null)
				{
					this.QianYueKeHu=ds.Tables[0].Rows[0]["QianYueKeHu"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DaoKuanDate"]!=null && ds.Tables[0].Rows[0]["DaoKuanDate"].ToString()!="")
				{
					this.DaoKuanDate=DateTime.Parse(ds.Tables[0].Rows[0]["DaoKuanDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TiXingDate"]!=null && ds.Tables[0].Rows[0]["TiXingDate"].ToString()!="")
				{
					this.TiXingDate=DateTime.Parse(ds.Tables[0].Rows[0]["TiXingDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateUser"]!=null)
				{
					this.CreateUser=ds.Tables[0].Rows[0]["CreateUser"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BackInfo"]!=null)
				{
					this.BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NowState"]!=null)
				{
					this.NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
				}
				if(ds.Tables[0].Rows[0]["HTJE"]!=null)
				{
					this.HTJE=ds.Tables[0].Rows[0]["HTJE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SFDK"]!=null)
				{
					this.SFDK=ds.Tables[0].Rows[0]["SFDK"].ToString();
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPRecive"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [ERPRecive]");
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
			strSql.Append("insert into [ERPRecive] (");
			strSql.Append("HeTongName,QianYueKeHu,DaoKuanDate,TiXingDate,CreateTime,CreateUser,BackInfo,NowState,HTJE,SFDK)");
			strSql.Append(" values (");
			strSql.Append("@HeTongName,@QianYueKeHu,@DaoKuanDate,@TiXingDate,@CreateTime,@CreateUser,@BackInfo,@NowState,@HTJE,@SFDK)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@HeTongName", SqlDbType.VarChar,200),
					new SqlParameter("@QianYueKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@DaoKuanDate", SqlDbType.DateTime),
					new SqlParameter("@TiXingDate", SqlDbType.DateTime),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@HTJE", SqlDbType.NVarChar,30),
					new SqlParameter("@SFDK", SqlDbType.NVarChar,20)};
			parameters[0].Value = HeTongName;
			parameters[1].Value = QianYueKeHu;
			parameters[2].Value = DaoKuanDate;
			parameters[3].Value = TiXingDate;
			parameters[4].Value = CreateTime;
			parameters[5].Value = CreateUser;
			parameters[6].Value = BackInfo;
			parameters[7].Value = NowState;
			parameters[8].Value = HTJE;
			parameters[9].Value = SFDK;

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
			strSql.Append("update [ERPRecive] set ");
			strSql.Append("HeTongName=@HeTongName,");
			strSql.Append("QianYueKeHu=@QianYueKeHu,");
			strSql.Append("DaoKuanDate=@DaoKuanDate,");
			strSql.Append("TiXingDate=@TiXingDate,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("CreateUser=@CreateUser,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append("NowState=@NowState,");
			strSql.Append("HTJE=@HTJE,");
			strSql.Append("SFDK=@SFDK");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@HeTongName", SqlDbType.VarChar,200),
					new SqlParameter("@QianYueKeHu", SqlDbType.VarChar,200),
					new SqlParameter("@DaoKuanDate", SqlDbType.DateTime),
					new SqlParameter("@TiXingDate", SqlDbType.DateTime),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,8000),
					new SqlParameter("@NowState", SqlDbType.VarChar,50),
					new SqlParameter("@HTJE", SqlDbType.NVarChar,30),
					new SqlParameter("@SFDK", SqlDbType.NVarChar,20),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = HeTongName;
			parameters[1].Value = QianYueKeHu;
			parameters[2].Value = DaoKuanDate;
			parameters[3].Value = TiXingDate;
			parameters[4].Value = CreateTime;
			parameters[5].Value = CreateUser;
			parameters[6].Value = BackInfo;
			parameters[7].Value = NowState;
			parameters[8].Value = HTJE;
			parameters[9].Value = SFDK;
			parameters[10].Value = ID;

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
			strSql.Append("delete from [ERPRecive] ");
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
			strSql.Append("select ID,HeTongName,QianYueKeHu,DaoKuanDate,TiXingDate,CreateTime,CreateUser,BackInfo,NowState,HTJE,SFDK ");
			strSql.Append(" FROM [ERPRecive] ");
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
				if(ds.Tables[0].Rows[0]["HeTongName"]!=null )
				{
					this.HeTongName=ds.Tables[0].Rows[0]["HeTongName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QianYueKeHu"]!=null )
				{
					this.QianYueKeHu=ds.Tables[0].Rows[0]["QianYueKeHu"].ToString();
				}
				if(ds.Tables[0].Rows[0]["DaoKuanDate"]!=null && ds.Tables[0].Rows[0]["DaoKuanDate"].ToString()!="")
				{
					this.DaoKuanDate=DateTime.Parse(ds.Tables[0].Rows[0]["DaoKuanDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TiXingDate"]!=null && ds.Tables[0].Rows[0]["TiXingDate"].ToString()!="")
				{
					this.TiXingDate=DateTime.Parse(ds.Tables[0].Rows[0]["TiXingDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CreateUser"]!=null )
				{
					this.CreateUser=ds.Tables[0].Rows[0]["CreateUser"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BackInfo"]!=null )
				{
					this.BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["NowState"]!=null )
				{
					this.NowState=ds.Tables[0].Rows[0]["NowState"].ToString();
				}
				if(ds.Tables[0].Rows[0]["HTJE"]!=null )
				{
					this.HTJE=ds.Tables[0].Rows[0]["HTJE"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SFDK"]!=null )
				{
					this.SFDK=ds.Tables[0].Rows[0]["SFDK"].ToString();
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
			strSql.Append(" FROM [ERPRecive] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

