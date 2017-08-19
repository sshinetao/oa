using FTD.DBUnit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace FTD.BLL
{
    public class HTGL
    {
        public HTGL() { }
        #region 封装字段
        private int _id ;
        private string _hetongfenlei ;
        private string _bianhao ;
        private string _jiafang;
        private string _yifang;
        private decimal _hetongjine;
        private DateTime _hetongqixian;
        private DateTime _qiandingriqi;
        private string _neirong;
        private string _fujian;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Hetongfenlei
        {
            get
            {
                return _hetongfenlei;
            }

            set
            {
                _hetongfenlei = value;
            }
        }

        public string Bianhao
        {
            get
            {
                return _bianhao;
            }

            set
            {
                _bianhao = value;
            }
        }

        public string Jiafang
        {
            get
            {
                return _jiafang;
            }

            set
            {
                _jiafang = value;
            }
        }

        public string Yifang
        {
            get
            {
                return _yifang;
            }

            set
            {
                _yifang = value;
            }
        }

        public decimal Hetongjine
        {
            get
            {
                return _hetongjine;
            }

            set
            {
                _hetongjine = value;
            }
        }

        public DateTime Hetongqixian
        {
            get
            {
                return _hetongqixian;
            }

            set
            {
                _hetongqixian = value;
            }
        }

        public DateTime Qiandingriqi
        {
            get
            {
                return _qiandingriqi;
            }

            set
            {
                _qiandingriqi = value;
            }
        }

        public string Neirong
        {
            get
            {
                return _neirong;
            }

            set
            {
                _neirong = value;
            }
        }

        public string Fujian
        {
            get
            {
                return _fujian;
            }

            set
            {
                _fujian = value;
            }
        }
        #endregion

        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HTGL(int id)
        {
            StringBuilder strSql = new StringBuilder();
            string sql = @"SELECT  id ,
                                    hetongfenlei ,
                                    bianhao ,
                                    jiafang ,
                                    yifang ,
                                    hetongjine ,
                                    hetongqixian ,
                                    qiandingriqi ,
                                    neirong ,
                                    fujian
                            FROM    dbo.hetongguanli";
            strSql.Append(sql);
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
             
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.Id = int.Parse(ds.Tables[0].Rows[0]["id"] + "");
                }
                if (ds.Tables[0].Rows[0]["hetongfenlei"] != null)
                {
                    this.Hetongfenlei = ds.Tables[0].Rows[0]["hetongfenlei"]+"";
                }
                if (ds.Tables[0].Rows[0]["bianhao"] != null)
                {
                    this.Bianhao = ds.Tables[0].Rows[0]["bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiafang"] != null)
                {
                    this.Jiafang = ds.Tables[0].Rows[0]["jiafang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["yifang"] != null)
                {
                    this.Yifang = ds.Tables[0].Rows[0]["yifang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["hetongjine"] != null)
                {
                    this.Hetongjine = GetDecimal(ds.Tables[0].Rows[0]["hetongjine"], 0);
                }
                if (ds.Tables[0].Rows[0]["hetongqixian"] != null)
                {
                    this.Hetongqixian = DateTime.Parse(ds.Tables[0].Rows[0]["hetongqixian"]+"");
                }
                if (ds.Tables[0].Rows[0]["qiandingriqi"] != null)
                {
                    this.Qiandingriqi = DateTime.Parse(ds.Tables[0].Rows[0]["qiandingriqi"].ToString());
                }
                if (ds.Tables[0].Rows[0]["neirong"] != null)
                {
                    this.Neirong = ds.Tables[0].Rows[0]["neirong"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fujian"] != null)
                {
                    this.Fujian = ds.Tables[0].Rows[0]["fujian"].ToString();
                }
                
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [hetongguanli]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            string sql = @"INSERT INTO dbo.hetongguanli
                            ( hetongfenlei ,
                              bianhao ,
                              jiafang ,
                              yifang ,
                              hetongjine ,
                              hetongqixian ,
                              qiandingriqi ,
                              neirong ,
                              fujian
                            )";
            strSql.Append(sql);
            strSql.Append(" values (");
            strSql.Append("@hetongfenlei,@bianhao,@jiafang,@yifang,@hetongjine,@hetongqixian,@qiandingriqi,@neirong,@fujian )");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@hetongfenlei", SqlDbType.NVarChar,50),
                    new SqlParameter("@bianhao", SqlDbType.NVarChar,50),
                    new SqlParameter("@jiafang", SqlDbType.NVarChar,50),
                    new SqlParameter("@yifang", SqlDbType.NVarChar,50),
                    new SqlParameter("@hetongjine", SqlDbType.Money),
                    new SqlParameter("@hetongqixian", SqlDbType.DateTime),
                    new SqlParameter("@qiandingriqi", SqlDbType.DateTime),
                    new SqlParameter("@neirong", SqlDbType.NVarChar,5000),
                    new SqlParameter("@fujian", SqlDbType.NVarChar,5000)  };
            parameters[0].Value = Hetongfenlei;
            parameters[1].Value = Bianhao;
            parameters[2].Value = Jiafang;
            parameters[3].Value = Yifang;
            parameters[4].Value = Hetongjine;
            parameters[5].Value = Hetongqixian;
            parameters[6].Value = Qiandingriqi;
            parameters[7].Value = Neirong;
            parameters[8].Value = Fujian;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [hetongguanli] set ");
            strSql.Append("hetongfenlei=@hetongfenlei,");
            strSql.Append("bianhao=@bianhao,");
            strSql.Append("jiafang=@jiafang,");
            strSql.Append("yifang=@yifang,");
            strSql.Append("hetongjine=@hetongjine,");
            strSql.Append("hetongqixian=@hetongqixian,");
            strSql.Append("qiandingriqi=@qiandingriqi,");
            strSql.Append("neirong=@neirong,");
            strSql.Append("fujian=@fujian");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@hetongfenlei", SqlDbType.NVarChar,50),
                    new SqlParameter("@bianhao", SqlDbType.NVarChar,50),
                    new SqlParameter("@jiafang", SqlDbType.NVarChar,50),
                    new SqlParameter("@yifang", SqlDbType.NVarChar,50),
                    new SqlParameter("@hetongjine", SqlDbType.Money),
                    new SqlParameter("@hetongqixian", SqlDbType.DateTime),
                    new SqlParameter("@qiandingriqi", SqlDbType.DateTime),
                    new SqlParameter("@neirong", SqlDbType.NVarChar,5000),
                    new SqlParameter("@fujian", SqlDbType.NVarChar,5000) ,
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = Hetongfenlei;
            parameters[1].Value = Bianhao;
            parameters[2].Value = Jiafang;
            parameters[3].Value = Yifang;
            parameters[4].Value = Hetongjine;
            parameters[5].Value = Hetongqixian;
            parameters[6].Value = Qiandingriqi;
            parameters[7].Value = Neirong;
            parameters[8].Value = Fujian;
            parameters[9].Value = Id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [hetongguanli]");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public void GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            string sql = @"SELECT  id ,
                                    hetongfenlei ,
                                    bianhao ,
                                    jiafang ,
                                    yifang ,
                                    hetongjine ,
                                    hetongqixian ,
                                    qiandingriqi ,
                                    neirong ,
                                    fujian
                            FROM    dbo.hetongguanli";
            strSql.Append(sql);
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;
             
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.Id = int.Parse(ds.Tables[0].Rows[0]["id"] + "");
                }
                if (ds.Tables[0].Rows[0]["hetongfenlei"] != null)
                {
                    this.Hetongfenlei = ds.Tables[0].Rows[0]["hetongfenlei"] + "";
                }
                if (ds.Tables[0].Rows[0]["bianhao"] != null)
                {
                    this.Bianhao = ds.Tables[0].Rows[0]["bianhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiafang"] != null)
                {
                    this.Jiafang = ds.Tables[0].Rows[0]["jiafang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["yifang"] != null)
                {
                    this.Yifang = ds.Tables[0].Rows[0]["yifang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["hetongjine"] != null)
                {

                    this.Hetongjine =  GetDecimal(ds.Tables[0].Rows[0]["hetongjine"], 0);
                }
                if (ds.Tables[0].Rows[0]["hetongqixian"] != null)
                {
                    this.Hetongqixian = DateTime.Parse(ds.Tables[0].Rows[0]["hetongqixian"] + "");
                }
                if (ds.Tables[0].Rows[0]["qiandingriqi"] != null)
                {
                    this.Qiandingriqi = DateTime.Parse(ds.Tables[0].Rows[0]["qiandingriqi"].ToString());
                }
                if (ds.Tables[0].Rows[0]["neirong"] != null)
                {
                    this.Neirong = ds.Tables[0].Rows[0]["neirong"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fujian"] != null)
                {
                    this.Fujian = ds.Tables[0].Rows[0]["fujian"].ToString();
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string sql = @"SELECT   id ,
                                    hetongfenlei ,
                                    bianhao ,
                                    jiafang ,
                                    yifang ,
                                    hetongjine ,
                                    dbo.DateFmt4(hetongqixian) AS hetongqixian ,
                                    dbo.DateFmt4(qiandingriqi) AS qiandingriqi ,
                                    neirong ,
                                    fujian
                            FROM    dbo.hetongguanli";
            strSql.Append(sql);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method

        public static decimal GetDecimal(object obj, decimal exceptionvalue)
        {

            if (obj == null)
                return exceptionvalue;
            if (string.IsNullOrEmpty(obj.ToString()))
                return exceptionvalue;
            decimal i = exceptionvalue;
            try { i = Convert.ToDecimal(obj); }
            catch { i = exceptionvalue; }
            return i;
        }
    }
}
