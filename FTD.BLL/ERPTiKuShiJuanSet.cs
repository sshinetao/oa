using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPTiKuShiJuanSet。
	/// </summary>
	[Serializable]
	public partial class ERPTiKuShiJuanSet
	{
		public ERPTiKuShiJuanSet()
		{}
		#region Model
		private int _id;
		private int? _danxuannum;
		private int? _duoxuannum;
		private int? _panduannum;
		private int? _tiankongnum;
		private int? _jiandanum;
		private int? _shijuanid;
		private int? _tikutypeid;
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
		public int? DanXuanNum
		{
			set{ _danxuannum=value;}
			get{return _danxuannum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DuoXuanNum
		{
			set{ _duoxuannum=value;}
			get{return _duoxuannum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PanDuanNum
		{
			set{ _panduannum=value;}
			get{return _panduannum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TianKongNum
		{
			set{ _tiankongnum=value;}
			get{return _tiankongnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? JianDaNum
		{
			set{ _jiandanum=value;}
			get{return _jiandanum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ShiJuanID
		{
			set{ _shijuanid=value;}
			get{return _shijuanid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TiKuTypeID
		{
			set{ _tikutypeid=value;}
			get{return _tikutypeid;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public ERPTiKuShiJuanSet(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,DanXuanNum,DuoXuanNum,PanDuanNum,TianKongNum,JianDaNum,ShiJuanID,TiKuTypeID ");
			strSql.Append(" FROM [ERPTiKuShiJuanSet] ");
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
				if(ds.Tables[0].Rows[0]["DanXuanNum"]!=null && ds.Tables[0].Rows[0]["DanXuanNum"].ToString()!="")
				{
					this.DanXuanNum=int.Parse(ds.Tables[0].Rows[0]["DanXuanNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DuoXuanNum"]!=null && ds.Tables[0].Rows[0]["DuoXuanNum"].ToString()!="")
				{
					this.DuoXuanNum=int.Parse(ds.Tables[0].Rows[0]["DuoXuanNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PanDuanNum"]!=null && ds.Tables[0].Rows[0]["PanDuanNum"].ToString()!="")
				{
					this.PanDuanNum=int.Parse(ds.Tables[0].Rows[0]["PanDuanNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TianKongNum"]!=null && ds.Tables[0].Rows[0]["TianKongNum"].ToString()!="")
				{
					this.TianKongNum=int.Parse(ds.Tables[0].Rows[0]["TianKongNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JianDaNum"]!=null && ds.Tables[0].Rows[0]["JianDaNum"].ToString()!="")
				{
					this.JianDaNum=int.Parse(ds.Tables[0].Rows[0]["JianDaNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ShiJuanID"]!=null && ds.Tables[0].Rows[0]["ShiJuanID"].ToString()!="")
				{
					this.ShiJuanID=int.Parse(ds.Tables[0].Rows[0]["ShiJuanID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TiKuTypeID"]!=null && ds.Tables[0].Rows[0]["TiKuTypeID"].ToString()!="")
				{
					this.TiKuTypeID=int.Parse(ds.Tables[0].Rows[0]["TiKuTypeID"].ToString());
				}
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPTiKuShiJuanSet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [ERPTiKuShiJuanSet]");
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
			strSql.Append("insert into [ERPTiKuShiJuanSet] (");
			strSql.Append("DanXuanNum,DuoXuanNum,PanDuanNum,TianKongNum,JianDaNum,ShiJuanID,TiKuTypeID)");
			strSql.Append(" values (");
			strSql.Append("@DanXuanNum,@DuoXuanNum,@PanDuanNum,@TianKongNum,@JianDaNum,@ShiJuanID,@TiKuTypeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DanXuanNum", SqlDbType.Int,4),
					new SqlParameter("@DuoXuanNum", SqlDbType.Int,4),
					new SqlParameter("@PanDuanNum", SqlDbType.Int,4),
					new SqlParameter("@TianKongNum", SqlDbType.Int,4),
					new SqlParameter("@JianDaNum", SqlDbType.Int,4),
					new SqlParameter("@ShiJuanID", SqlDbType.Int,4),
					new SqlParameter("@TiKuTypeID", SqlDbType.Int,4)};
			parameters[0].Value = DanXuanNum;
			parameters[1].Value = DuoXuanNum;
			parameters[2].Value = PanDuanNum;
			parameters[3].Value = TianKongNum;
			parameters[4].Value = JianDaNum;
			parameters[5].Value = ShiJuanID;
			parameters[6].Value = TiKuTypeID;

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
			strSql.Append("update [ERPTiKuShiJuanSet] set ");
			strSql.Append("DanXuanNum=@DanXuanNum,");
			strSql.Append("DuoXuanNum=@DuoXuanNum,");
			strSql.Append("PanDuanNum=@PanDuanNum,");
			strSql.Append("TianKongNum=@TianKongNum,");
			strSql.Append("JianDaNum=@JianDaNum,");
			strSql.Append("ShiJuanID=@ShiJuanID,");
			strSql.Append("TiKuTypeID=@TiKuTypeID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@DanXuanNum", SqlDbType.Int,4),
					new SqlParameter("@DuoXuanNum", SqlDbType.Int,4),
					new SqlParameter("@PanDuanNum", SqlDbType.Int,4),
					new SqlParameter("@TianKongNum", SqlDbType.Int,4),
					new SqlParameter("@JianDaNum", SqlDbType.Int,4),
					new SqlParameter("@ShiJuanID", SqlDbType.Int,4),
					new SqlParameter("@TiKuTypeID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = DanXuanNum;
			parameters[1].Value = DuoXuanNum;
			parameters[2].Value = PanDuanNum;
			parameters[3].Value = TianKongNum;
			parameters[4].Value = JianDaNum;
			parameters[5].Value = ShiJuanID;
			parameters[6].Value = TiKuTypeID;
			parameters[7].Value = ID;

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
			strSql.Append("delete from [ERPTiKuShiJuanSet] ");
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
			strSql.Append("select ID,DanXuanNum,DuoXuanNum,PanDuanNum,TianKongNum,JianDaNum,ShiJuanID,TiKuTypeID ");
			strSql.Append(" FROM [ERPTiKuShiJuanSet] ");
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
				if(ds.Tables[0].Rows[0]["DanXuanNum"]!=null && ds.Tables[0].Rows[0]["DanXuanNum"].ToString()!="")
				{
					this.DanXuanNum=int.Parse(ds.Tables[0].Rows[0]["DanXuanNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DuoXuanNum"]!=null && ds.Tables[0].Rows[0]["DuoXuanNum"].ToString()!="")
				{
					this.DuoXuanNum=int.Parse(ds.Tables[0].Rows[0]["DuoXuanNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PanDuanNum"]!=null && ds.Tables[0].Rows[0]["PanDuanNum"].ToString()!="")
				{
					this.PanDuanNum=int.Parse(ds.Tables[0].Rows[0]["PanDuanNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TianKongNum"]!=null && ds.Tables[0].Rows[0]["TianKongNum"].ToString()!="")
				{
					this.TianKongNum=int.Parse(ds.Tables[0].Rows[0]["TianKongNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JianDaNum"]!=null && ds.Tables[0].Rows[0]["JianDaNum"].ToString()!="")
				{
					this.JianDaNum=int.Parse(ds.Tables[0].Rows[0]["JianDaNum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ShiJuanID"]!=null && ds.Tables[0].Rows[0]["ShiJuanID"].ToString()!="")
				{
					this.ShiJuanID=int.Parse(ds.Tables[0].Rows[0]["ShiJuanID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TiKuTypeID"]!=null && ds.Tables[0].Rows[0]["TiKuTypeID"].ToString()!="")
				{
					this.TiKuTypeID=int.Parse(ds.Tables[0].Rows[0]["TiKuTypeID"].ToString());
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
			strSql.Append(" FROM [ERPTiKuShiJuanSet] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

