using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPLX。
	/// </summary>
	[Serializable]
	public partial class ERPLX
	{
		public ERPLX()
		{}
		#region Model
		private int _id;
		private string _projectname;
		private DateTime? _zhrq;
		private string _xmbh;
		private DateTime? _jzjcrq;
		private DateTime? _jzjdrq;
		private string _jhdd;
		private string _gsbj;
		private string _xiangmucb;
		private string _username;
		private DateTime? _timestr= DateTime.Now;
		private string _fujian;
		private string _backinfo;
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
		public string ProjectName
		{
			set{ _projectname=value;}
			get{return _projectname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? ZHRQ
		{
			set{ _zhrq=value;}
			get{return _zhrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XMBH
		{
			set{ _xmbh=value;}
			get{return _xmbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? JZJCRQ
		{
			set{ _jzjcrq=value;}
			get{return _jzjcrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? JZJDRQ
		{
			set{ _jzjdrq=value;}
			get{return _jzjdrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JHDD
		{
			set{ _jhdd=value;}
			get{return _jhdd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GSBJ
		{
			set{ _gsbj=value;}
			get{return _gsbj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XiangMuCB
		{
			set{ _xiangmucb=value;}
			get{return _xiangmucb;}
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
		public DateTime? TimeStr
		{
			set{ _timestr=value;}
			get{return _timestr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FuJian
		{
			set{ _fujian=value;}
			get{return _fujian;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPLX(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,ProjectName,ZHRQ,XMBH,JZJCRQ,JZJDRQ,JHDD,GSBJ,XiangMuCB,UserName,TimeStr,FuJian,BackInfo ");
			strSql.Append(" FROM [ERPLX] ");
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
				if(ds.Tables[0].Rows[0]["ProjectName"]!=null)
				{
					this.ProjectName=ds.Tables[0].Rows[0]["ProjectName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ZHRQ"]!=null && ds.Tables[0].Rows[0]["ZHRQ"].ToString()!="")
				{
					this.ZHRQ=DateTime.Parse(ds.Tables[0].Rows[0]["ZHRQ"].ToString());
				}
				if(ds.Tables[0].Rows[0]["XMBH"]!=null)
				{
					this.XMBH=ds.Tables[0].Rows[0]["XMBH"].ToString();
				}
				if(ds.Tables[0].Rows[0]["JZJCRQ"]!=null && ds.Tables[0].Rows[0]["JZJCRQ"].ToString()!="")
				{
					this.JZJCRQ=DateTime.Parse(ds.Tables[0].Rows[0]["JZJCRQ"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JZJDRQ"]!=null && ds.Tables[0].Rows[0]["JZJDRQ"].ToString()!="")
				{
					this.JZJDRQ=DateTime.Parse(ds.Tables[0].Rows[0]["JZJDRQ"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JHDD"]!=null)
				{
					this.JHDD=ds.Tables[0].Rows[0]["JHDD"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GSBJ"]!=null)
				{
					this.GSBJ=ds.Tables[0].Rows[0]["GSBJ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["XiangMuCB"]!=null)
				{
					this.XiangMuCB=ds.Tables[0].Rows[0]["XiangMuCB"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null)
				{
					this.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TimeStr"]!=null && ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					this.TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FuJian"]!=null)
				{
					this.FuJian=ds.Tables[0].Rows[0]["FuJian"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BackInfo"]!=null)
				{
					this.BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPLX"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [ERPLX]");
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
			strSql.Append("insert into [ERPLX] (");
			strSql.Append("ProjectName,ZHRQ,XMBH,JZJCRQ,JZJDRQ,JHDD,GSBJ,XiangMuCB,UserName,TimeStr,FuJian,BackInfo)");
			strSql.Append(" values (");
			strSql.Append("@ProjectName,@ZHRQ,@XMBH,@JZJCRQ,@JZJDRQ,@JHDD,@GSBJ,@XiangMuCB,@UserName,@TimeStr,@FuJian,@BackInfo)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ZHRQ", SqlDbType.DateTime),
					new SqlParameter("@XMBH", SqlDbType.VarChar,50),
					new SqlParameter("@JZJCRQ", SqlDbType.DateTime),
					new SqlParameter("@JZJDRQ", SqlDbType.DateTime),
					new SqlParameter("@JHDD", SqlDbType.VarChar,200),
					new SqlParameter("@GSBJ", SqlDbType.VarChar,100),
					new SqlParameter("@XiangMuCB", SqlDbType.VarChar,200),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@FuJian", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)};
			parameters[0].Value = ProjectName;
			parameters[1].Value = ZHRQ;
			parameters[2].Value = XMBH;
			parameters[3].Value = JZJCRQ;
			parameters[4].Value = JZJDRQ;
			parameters[5].Value = JHDD;
			parameters[6].Value = GSBJ;
			parameters[7].Value = XiangMuCB;
			parameters[8].Value = UserName;
			parameters[9].Value = TimeStr;
			parameters[10].Value = FuJian;
			parameters[11].Value = BackInfo;

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
			strSql.Append("update [ERPLX] set ");
			strSql.Append("ProjectName=@ProjectName,");
			strSql.Append("ZHRQ=@ZHRQ,");
			strSql.Append("XMBH=@XMBH,");
			strSql.Append("JZJCRQ=@JZJCRQ,");
			strSql.Append("JZJDRQ=@JZJDRQ,");
			strSql.Append("JHDD=@JHDD,");
			strSql.Append("GSBJ=@GSBJ,");
			strSql.Append("XiangMuCB=@XiangMuCB,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("TimeStr=@TimeStr,");
			strSql.Append("FuJian=@FuJian,");
			strSql.Append("BackInfo=@BackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ProjectName", SqlDbType.VarChar,200),
					new SqlParameter("@ZHRQ", SqlDbType.DateTime),
					new SqlParameter("@XMBH", SqlDbType.VarChar,50),
					new SqlParameter("@JZJCRQ", SqlDbType.DateTime),
					new SqlParameter("@JZJDRQ", SqlDbType.DateTime),
					new SqlParameter("@JHDD", SqlDbType.VarChar,200),
					new SqlParameter("@GSBJ", SqlDbType.VarChar,100),
					new SqlParameter("@XiangMuCB", SqlDbType.VarChar,200),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@TimeStr", SqlDbType.DateTime),
					new SqlParameter("@FuJian", SqlDbType.VarChar,5000),
					new SqlParameter("@BackInfo", SqlDbType.VarChar,5000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ProjectName;
			parameters[1].Value = ZHRQ;
			parameters[2].Value = XMBH;
			parameters[3].Value = JZJCRQ;
			parameters[4].Value = JZJDRQ;
			parameters[5].Value = JHDD;
			parameters[6].Value = GSBJ;
			parameters[7].Value = XiangMuCB;
			parameters[8].Value = UserName;
			parameters[9].Value = TimeStr;
			parameters[10].Value = FuJian;
			parameters[11].Value = BackInfo;
			parameters[12].Value = ID;

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
			strSql.Append("delete from [ERPLX] ");
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
			strSql.Append("select ID,ProjectName,ZHRQ,XMBH,JZJCRQ,JZJDRQ,JHDD,GSBJ,XiangMuCB,UserName,TimeStr,FuJian,BackInfo ");
			strSql.Append(" FROM [ERPLX] ");
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
				if(ds.Tables[0].Rows[0]["ProjectName"]!=null )
				{
					this.ProjectName=ds.Tables[0].Rows[0]["ProjectName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ZHRQ"]!=null && ds.Tables[0].Rows[0]["ZHRQ"].ToString()!="")
				{
					this.ZHRQ=DateTime.Parse(ds.Tables[0].Rows[0]["ZHRQ"].ToString());
				}
				if(ds.Tables[0].Rows[0]["XMBH"]!=null )
				{
					this.XMBH=ds.Tables[0].Rows[0]["XMBH"].ToString();
				}
				if(ds.Tables[0].Rows[0]["JZJCRQ"]!=null && ds.Tables[0].Rows[0]["JZJCRQ"].ToString()!="")
				{
					this.JZJCRQ=DateTime.Parse(ds.Tables[0].Rows[0]["JZJCRQ"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JZJDRQ"]!=null && ds.Tables[0].Rows[0]["JZJDRQ"].ToString()!="")
				{
					this.JZJDRQ=DateTime.Parse(ds.Tables[0].Rows[0]["JZJDRQ"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JHDD"]!=null )
				{
					this.JHDD=ds.Tables[0].Rows[0]["JHDD"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GSBJ"]!=null )
				{
					this.GSBJ=ds.Tables[0].Rows[0]["GSBJ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["XiangMuCB"]!=null )
				{
					this.XiangMuCB=ds.Tables[0].Rows[0]["XiangMuCB"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null )
				{
					this.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TimeStr"]!=null && ds.Tables[0].Rows[0]["TimeStr"].ToString()!="")
				{
					this.TimeStr=DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FuJian"]!=null )
				{
					this.FuJian=ds.Tables[0].Rows[0]["FuJian"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BackInfo"]!=null )
				{
					this.BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
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
			strSql.Append(" FROM [ERPLX] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

