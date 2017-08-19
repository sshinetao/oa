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
    public class QTZLGL
    {
        public QTZLGL() { }
        #region 封装字段
        private int _id;
        private string _leibie;
        private string _mingcheng;
        private string _neirongjianjie;
        private DateTime _guidangshijian;
        private string _beizhu;

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

        public string Leibie
        {
            get
            {
                return _leibie;
            }

            set
            {
                _leibie = value;
            }
        }

        public string Mingcheng
        {
            get
            {
                return _mingcheng;
            }

            set
            {
                _mingcheng = value;
            }
        }

        public string Neirongjianjie
        {
            get
            {
                return _neirongjianjie;
            }

            set
            {
                _neirongjianjie = value;
            }
        }

        public DateTime Guidangshijian
        {
            get
            {
                return _guidangshijian;
            }

            set
            {
                _guidangshijian = value;
            }
        }

        public string Beizhu
        {
            get
            {
                return _beizhu;
            }

            set
            {
                _beizhu = value;
            }
        }
        #endregion

        #region 封装数据库操作方法
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public QTZLGL(int id)
        {
            StringBuilder strSql = new StringBuilder();
            string sql = @"SELECT  Id ,
                                    Leibie ,
                                    Mingcheng ,
                                    Neirongjianjie ,
                                    Beizhu ,
                                    Guidangshijian
                            FROM    dbo.qitaziliaoguanli";
            strSql.Append(sql);
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"] + "");
                }
                if (ds.Tables[0].Rows[0]["Leibie"] != null)
                {
                    this.Leibie = ds.Tables[0].Rows[0]["Leibie"] + "";
                }
                if (ds.Tables[0].Rows[0]["Mingcheng"] != null)
                {
                    this.Mingcheng = ds.Tables[0].Rows[0]["Mingcheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Neirongjianjie"] != null)
                {
                    this.Neirongjianjie = ds.Tables[0].Rows[0]["Neirongjianjie"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Guidangshijian"] != null)
                {
                    this.Guidangshijian = DateTime.Parse(ds.Tables[0].Rows[0]["Guidangshijian"] + "");
                }
                if (ds.Tables[0].Rows[0]["Beizhu"] != null)
                {
                    this.Beizhu = ds.Tables[0].Rows[0]["Beizhu"] + "";
                }


            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [qitaziliaoguanli]");
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
            string sql = @"INSERT INTO dbo.qitaziliaoguanli
                            ( Leibie ,
                              Mingcheng ,
                              Neirongjianjie ,
                              Guidangshijian ,
                              Beizhu  
                            )";
            strSql.Append(sql);
            strSql.Append(" values (");
            strSql.Append("@Leibie,@Mingcheng,@Neirongjianjie,@Guidangshijian,@Beizhu  )");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                                        new SqlParameter("@Leibie", SqlDbType.NVarChar,50),
                    new SqlParameter("@Mingcheng", SqlDbType.NVarChar,50),
                    new SqlParameter("@Neirongjianjie", SqlDbType.NVarChar,500),
                    new SqlParameter("@Guidangshijian", SqlDbType.DateTime),
                    new SqlParameter("@Beizhu", SqlDbType.NVarChar,200) };
            parameters[0].Value = Leibie;
            parameters[1].Value = Mingcheng;
            parameters[2].Value = Neirongjianjie;
            parameters[3].Value = Guidangshijian;
            parameters[4].Value = Beizhu;

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
            strSql.Append("update [qitaziliaoguanli] set ");
            strSql.Append("Leibie=@Leibie,");
            strSql.Append("Mingcheng=@Mingcheng,");
            strSql.Append("Neirongjianjie=@Neirongjianjie,");
            strSql.Append("Guidangshijian=@Guidangshijian,");
            strSql.Append("Beizhu=@Beizhu ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Leibie", SqlDbType.NVarChar,50),
                    new SqlParameter("@Mingcheng", SqlDbType.NVarChar,50),
                    new SqlParameter("@Neirongjianjie", SqlDbType.NVarChar,500),
                    new SqlParameter("@Guidangshijian", SqlDbType.DateTime),
                    new SqlParameter("@Beizhu", SqlDbType.NVarChar,200),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = Leibie;
            parameters[1].Value = Mingcheng;
            parameters[2].Value = Neirongjianjie;
            parameters[3].Value = Guidangshijian;
            parameters[4].Value = Beizhu;
            parameters[5].Value = Id;

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
            strSql.Append("delete from [qitaziliaoguanli]");
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
            string sql = @"SELECT  Id ,
                                    Leibie ,
                                    Mingcheng ,
                                    Neirongjianjie ,
                                    Beizhu ,
                                    Guidangshijian
                            FROM    dbo.qitaziliaoguanli";
            strSql.Append(sql);
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["Id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"] + "");
                }
                if (ds.Tables[0].Rows[0]["Leibie"] != null)
                {
                    this.Leibie = ds.Tables[0].Rows[0]["Leibie"] + "";
                }
                if (ds.Tables[0].Rows[0]["Mingcheng"] != null)
                {
                    this.Mingcheng = ds.Tables[0].Rows[0]["Mingcheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Neirongjianjie"] != null)
                {
                    this.Neirongjianjie = ds.Tables[0].Rows[0]["Neirongjianjie"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Guidangshijian"] != null)
                {
                    this.Guidangshijian = DateTime.Parse(ds.Tables[0].Rows[0]["Guidangshijian"] + "");
                }
                if (ds.Tables[0].Rows[0]["Beizhu"] != null)
                {
                    this.Beizhu = ds.Tables[0].Rows[0]["Beizhu"] + "";
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
                                    leibie ,
                                    mingcheng ,
                                    Neirongjianjie ,
                                    dbo.DateFmt4(Guidangshijian)  AS Guidangshijian ,
                                    Beizhu
                            FROM    dbo.qitaziliaoguanli";
            strSql.Append(sql);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }
}
