using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;

namespace FTD.BLL
{
    public class XMCWB
    {

        public XMCWB()
        { }
        #region Model
        private int _id;
        private string _zhuangtai;
        private string _kemu;
        private DateTime _riqi;
        private decimal _jine;

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

        public string Zhuangtai
        {
            get
            {
                return _zhuangtai;
            }

            set
            {
                _zhuangtai = value;
            }
        }

        public string Kemu
        {
            get
            {
                return _kemu;
            }

            set
            {
                _kemu = value;
            }
        }

        public DateTime Riqi
        {
            get
            {
                return _riqi;
            }

            set
            {
                _riqi = value;
            }
        }

        public decimal Jine
        {
            get
            {
                return _jine;
            }

            set
            {
                _jine = value;
            }
        }

        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public XMCWB(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Zhuangtai,Kemu,Riqi,Jine ");
            strSql.Append(" FROM [xiangmucaiwubiao] ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.Id = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Zhuangtai"] != null && ds.Tables[0].Rows[0]["Zhuangtai"].ToString() != "")
                {
                    this.Zhuangtai = ds.Tables[0].Rows[0]["Zhuangtai"] + "";
                }
                if (ds.Tables[0].Rows[0]["Kemu"] != null)
                {
                    this.Kemu = ds.Tables[0].Rows[0]["Kemu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Riqi"] != null)
                {
                    this.Riqi = DateTime.Parse(ds.Tables[0].Rows[0]["Riqi"] + "");
                }
                if (ds.Tables[0].Rows[0]["Jine"] != null)
                {
                    this.Jine = GetDecimal(ds.Tables[0].Rows[0]["Jine"] + "", 0);
                }
            }
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {

            return DbHelperSQL.GetMaxID("ID", "xiangmucaiwubiao");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [xiangmucaiwubiao]");
            strSql.Append(" where ID=@ID ");

            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [xiangmucaiwubiao] (");
            strSql.Append("Zhuangtai,Kemu,Riqi,Jine)");
            strSql.Append(" values (");
            strSql.Append("@Zhuangtai,@Kemu,@Riqi,@Jine)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Zhuangtai", SqlDbType.NVarChar,20),
                    new SqlParameter("@Kemu", SqlDbType.NVarChar,100),
                    new SqlParameter("@Riqi", SqlDbType.DateTime),
                    new SqlParameter("@Jine", SqlDbType.Money)};
            parameters[0].Value = Zhuangtai;
            parameters[1].Value = Kemu;
            parameters[2].Value = Riqi;
            parameters[3].Value = Jine;

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
            strSql.Append("update [xiangmucaiwubiao] set ");
            strSql.Append("Zhuangtai=@Zhuangtai,");
            strSql.Append("Kemu=@Kemu,");
            strSql.Append("Riqi=@Riqi,");
            strSql.Append("Jine=@Jine");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Zhuangtai", SqlDbType.NVarChar,20),
                    new SqlParameter("@Kemu", SqlDbType.NVarChar,100),
                    new SqlParameter("@Riqi", SqlDbType.DateTime),
                    new SqlParameter("@Jine", SqlDbType.Money),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = Zhuangtai;
            parameters[1].Value = Kemu;
            parameters[2].Value = Riqi;
            parameters[3].Value = Jine;
            parameters[4].Value = Id;

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
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [xiangmucaiwubiao] ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

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
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Zhuangtai,Kemu,Riqi,Jine ");
            strSql.Append(" FROM [xiangmucaiwubiao] ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
                    new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    this.Id = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Zhuangtai"] != null && ds.Tables[0].Rows[0]["Zhuangtai"].ToString() != "")
                {
                    this.Zhuangtai = ds.Tables[0].Rows[0]["Zhuangtai"] + "";
                }
                if (ds.Tables[0].Rows[0]["Kemu"] != null)
                {
                    this.Kemu = ds.Tables[0].Rows[0]["Kemu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Riqi"] != null)
                {
                    this.Riqi = DateTime.Parse(ds.Tables[0].Rows[0]["Riqi"] + "");
                }
                if (ds.Tables[0].Rows[0]["Jine"] != null)
                {
                    this.Jine = GetDecimal(ds.Tables[0].Rows[0]["Jine"] + "", 0);
                }
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            string sql = @"SELECT  id ,
                            kemu ,
                            dbo.DateFmt4(riqi) AS riqi ,
                            jine ,
                            zhuangtai	 FROM xiangmucaiwubiao ";
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
