using FTD.DBUnit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FTD.BLL
{
    public class GWGL
    {
        public GWGL() { }

        #region Model
        private int _Id;
        private string _leixing;
        private string _biaoti;
        private string _neirong;
        private string _shenpiren;
        private string _fujian;
        private string _Zhuangtai;

        public int Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string Leixing
        {
            get
            {
                return _leixing;
            }

            set
            {
                _leixing = value;
            }
        }

        public string Biaoti
        {
            get
            {
                return _biaoti;
            }

            set
            {
                _biaoti = value;
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

        public string Shenpiren
        {
            get
            {
                return _shenpiren;
            }

            set
            {
                _shenpiren = value;
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

        public string Zhuangtai
        {
            get
            {
                return _Zhuangtai;
            }

            set
            {
                _Zhuangtai = value;
            }
        }





        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public GWGL(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Leixing,Biaoti,Neirong,Shenpiren,Fujian,Zhuangtai  ");
            strSql.Append(" FROM gongwen ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = Id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Leixing"] != null)
                {
                    this.Leixing = ds.Tables[0].Rows[0]["Leixing"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Biaoti"] != null)
                {
                    this.Biaoti = ds.Tables[0].Rows[0]["Biaoti"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Neirong"] != null)
                {
                    this.Neirong = ds.Tables[0].Rows[0]["Neirong"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Shenpiren"] != null)
                {
                    this.Shenpiren = ds.Tables[0].Rows[0]["Shenpiren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Fujian"] != null)
                {
                    this.Fujian = ds.Tables[0].Rows[0]["Fujian"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Zhuangtai"] != null)
                {
                    this.Zhuangtai = ds.Tables[0].Rows[0]["Zhuangtai"].ToString();
                }

            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from gongwen");
            strSql.Append(" where Id=@Id ");

            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = Id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into gongwen (");
            strSql.Append("Leixing,Biaoti,Neirong,Shenpiren,Fujian,Zhuangtai )");
            strSql.Append(" values (");
            strSql.Append("@Leixing,@Biaoti,@Neirong,@Shenpiren,@Fujian,@Zhuangtai )");
            strSql.Append(";select @@IdENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Leixing", SqlDbType.VarChar,150),
                    new SqlParameter("@Biaoti", SqlDbType.VarChar,150),
                    new SqlParameter("@Neirong", SqlDbType.VarChar,50),
                    new SqlParameter("@Shenpiren", SqlDbType.VarChar,50),
                    new SqlParameter("@Fujian", SqlDbType.VarChar,1500),
                    new SqlParameter("@Zhuangtai", SqlDbType.VarChar,50) };
            parameters[0].Value = Leixing;
            parameters[1].Value = Biaoti;
            parameters[2].Value = Neirong;
            parameters[3].Value = Shenpiren;
            parameters[4].Value = Fujian;
            parameters[5].Value = Zhuangtai;

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
            strSql.Append("update gongwen set ");
            strSql.Append("Leixing=@Leixing,");
            strSql.Append("Biaoti=@Biaoti,");
            strSql.Append("Neirong=@Neirong,");
            strSql.Append("Shenpiren=@Shenpiren,");
            strSql.Append("Fujian=@Fujian,");
            strSql.Append("Zhuangtai=@Zhuangtai ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Leixing", SqlDbType.VarChar,150),
                    new SqlParameter("@Biaoti", SqlDbType.VarChar,150),
                    new SqlParameter("@Neirong", SqlDbType.VarChar,4),
                    new SqlParameter("@Shenpiren", SqlDbType.VarChar,4),
                    new SqlParameter("@Fujian", SqlDbType.VarChar,1500),
                    new SqlParameter("@Zhuangtai", SqlDbType.VarChar,50),
                    new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = Leixing;
            parameters[1].Value = Biaoti;
            parameters[2].Value = Neirong;
            parameters[3].Value = Shenpiren;
            parameters[4].Value = Fujian;
            parameters[5].Value = Zhuangtai;
            parameters[6].Value = Id;

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
        public bool Delete(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from gongwen ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = Id;

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
        public void GetModel(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Leixing,Biaoti,Neirong,Shenpiren,Fujian,Zhuangtai  ");
            strSql.Append(" FROM gongwen ");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = Id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["Id"].ToString() != "")
                {
                    this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Leixing"] != null)
                {
                    this.Leixing = ds.Tables[0].Rows[0]["Leixing"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Biaoti"] != null)
                {
                    this.Biaoti = ds.Tables[0].Rows[0]["Biaoti"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Neirong"] != null)
                {
                    this.Neirong = ds.Tables[0].Rows[0]["Neirong"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Shenpiren"] != null)
                {
                    this.Shenpiren = ds.Tables[0].Rows[0]["Shenpiren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Fujian"] != null)
                {
                    this.Fujian = ds.Tables[0].Rows[0]["Fujian"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Zhuangtai"] != null)
                {
                    this.Zhuangtai = ds.Tables[0].Rows[0]["Zhuangtai"].ToString();
                }

            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM gongwen ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}
