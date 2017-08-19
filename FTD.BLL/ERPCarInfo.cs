using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
	/// <summary>
	/// 类ERPCarInfo。
	/// </summary>
	public class ERPCarInfo
	{
		public ERPCarInfo()
		{}
		#region Model
		private int _id;
		private string _carname;
		private string _carpaihao;
		private string _leixing;
		private string _dunwei;
		private string _gps;
        private string _backinfo;
        private DateTime? _gouche;
        private string _fapiao;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 车辆名称
		/// </summary>
		public string CarName
		{
			set{ _carname=value;}
			get{return _carname;}
		}
		/// <summary>
		/// 车牌号
		/// </summary>
		public string CarPaiHao
		{
			set{ _carpaihao=value;}
			get{return _carpaihao;}
		}

		/// <summary>
		/// 车辆类型
		/// </summary>
		public string LeiXing
		{
			set{ _leixing=value;}
			get{return _leixing;}
		}

		/// <summary>
		/// 当前状态
		/// </summary>
		public string Gps
		{
			set{ _gps=value;}
			get{return _gps;}
		}
		/// <summary>
		/// 录入时间
		/// </summary>
		public string Fapiao
		{
			set{ _fapiao=value;}
			get{return _fapiao;}
		}
        public DateTime? Gouche
        {
            set { _gouche = value; }
            get { return _gouche; }
        }
        /// <summary>
        /// 备注信息
        /// </summary>
        public string BackInfo
		{
			set{ _backinfo=value;}
			get{return _backinfo;}
		}

        public string Dunwei
        {
            set { _dunwei = value; }
            get { return _dunwei; }
        }

        #endregion Model


        #region  成员方法

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPCarInfo(int ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select ID,CarName,CarPaiHao,Dunwei,LeiXing,Fapiao,Gps,Gouche,BackInfo");
			strSql.Append(" FROM ERPCarInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				CarName=ds.Tables[0].Rows[0]["CarName"].ToString();
				CarPaiHao=ds.Tables[0].Rows[0]["CarPaiHao"].ToString();
				Dunwei=ds.Tables[0].Rows[0]["Dunwei"].ToString();
				LeiXing=ds.Tables[0].Rows[0]["LeiXing"].ToString();
				Gps=ds.Tables[0].Rows[0]["Gps"].ToString();
				Fapiao=ds.Tables[0].Rows[0]["Fapiao"].ToString();
				if(ds.Tables[0].Rows[0]["Gouche"].ToString()!="")
				{
                    Gouche = DateTime.Parse(ds.Tables[0].Rows[0]["Gouche"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{

		return DbHelperSQL.GetMaxID("ID", "ERPCarInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ERPCarInfo");
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
			strSql.Append("insert into ERPCarInfo(");
            strSql.Append("CarName,CarPaiHao,Dunwei,LeiXing,Gouche,Gps,Fapiao,BackInfo)");
			strSql.Append(" values (");
            strSql.Append("@CarName,@CarPaiHao,@Dunwei,@LeiXing,@Fapiao,@Gps,@UserName,@Gouche,@BackInfo,@SuoShuDep)");
			strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@CarName", SqlDbType.VarChar,50),
                    new SqlParameter("@CarPaiHao", SqlDbType.VarChar,50),
                    new SqlParameter("@Dunwei", SqlDbType.VarChar,50),
                    new SqlParameter("@LeiXing", SqlDbType.VarChar,50),
                    new SqlParameter("@Fapiao", SqlDbType.VarChar,50),
                    new SqlParameter("@Gps", SqlDbType.NVarChar,50),
                    new SqlParameter("@Gouche", SqlDbType.DateTime),
                    new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)
                    };
			parameters[0].Value = CarName;
			parameters[1].Value = CarPaiHao;
			parameters[2].Value = Dunwei;
			parameters[3].Value = LeiXing;
			parameters[4].Value = Fapiao;
			parameters[5].Value = Gps;
			parameters[6].Value = Gouche;
			parameters[7].Value = BackInfo;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 1;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ERPCarInfo set ");
			strSql.Append("CarName=@CarName,");
			strSql.Append("CarPaiHao=@CarPaiHao,");
			strSql.Append("Dunwei=@Dunwei,");
			strSql.Append("LeiXing=@LeiXing,");
			strSql.Append("Fapiao=@Fapiao,");
			strSql.Append("Gps=@Gps,");
			strSql.Append("Gouche=@Gouche,");
			strSql.Append("BackInfo=@BackInfo,");
			strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@CarName", SqlDbType.VarChar,50),
                    new SqlParameter("@CarPaiHao", SqlDbType.VarChar,50),
                    new SqlParameter("@Dunwei", SqlDbType.VarChar,50),
                    new SqlParameter("@LeiXing", SqlDbType.VarChar,50),
                    new SqlParameter("@Fapiao", SqlDbType.VarChar,50),
                    new SqlParameter("@Gps", SqlDbType.NVarChar,50),
                    new SqlParameter("@Gouche", SqlDbType.DateTime),
                    new SqlParameter("@BackInfo", SqlDbType.VarChar,5000)
                    };
			parameters[0].Value = ID;
			parameters[1].Value = CarName;
			parameters[2].Value = CarPaiHao;
			parameters[3].Value = Dunwei;
			parameters[4].Value = LeiXing;
			parameters[5].Value = Fapiao;
			parameters[6].Value = Gps;
			parameters[7].Value = Gouche;
			parameters[8].Value = BackInfo;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ERPCarInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public void GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select  top 1 ID,CarName,CarPaiHao,Dunwei,LeiXing,Fapiao,Gps,UserName,Gouche,BackInfo,SuoShuDep ");
			strSql.Append(" FROM ERPCarInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				CarName=ds.Tables[0].Rows[0]["CarName"].ToString();
				CarPaiHao=ds.Tables[0].Rows[0]["CarPaiHao"].ToString();
				Dunwei=ds.Tables[0].Rows[0]["Dunwei"].ToString();
				LeiXing=ds.Tables[0].Rows[0]["LeiXing"].ToString();
				Fapiao=ds.Tables[0].Rows[0]["Fapiao"].ToString();
				Gps=ds.Tables[0].Rows[0]["Gps"].ToString();
				if(ds.Tables[0].Rows[0]["Gouche"].ToString()!="")
				{
					Gouche=DateTime.Parse(ds.Tables[0].Rows[0]["Gouche"].ToString());
				}
				BackInfo=ds.Tables[0].Rows[0]["BackInfo"].ToString();
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
			strSql.Append(" FROM ERPCarInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  成员方法
	}
}

