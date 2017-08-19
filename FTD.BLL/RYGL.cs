﻿using FTD.DBUnit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace FTD.BLL
{
    public class RYGL
    {
        public RYGL() { }
        private int _id;
        private string _leibie;
        private string _mingcheng;
        private string _banfabumen;
        private DateTime _banfashijian;
        private int _youxiaoqi;

        #region 封装字段
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

        public string Banfabumen
        {
            get
            {
                return _banfabumen;
            }

            set
            {
                _banfabumen = value;
            }
        }

        public DateTime Banfashijian
        {
            get
            {
                return _banfashijian;
            }

            set
            {
                _banfashijian = value;
            }
        }

        public int Youxiaoqi
        {
            get
            {
                return _youxiaoqi;
            }

            set
            {
                _youxiaoqi = value;
            }
        }
        #endregion 

        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RYGL(int id)
        {
            StringBuilder strSql = new StringBuilder();
            string sql = @"SELECT  Id ,
                                    Leibie ,
                                    Mingcheng ,
                                    Banfabumen ,
                                    Banfashijian ,
                                    Youxiaoqi
                            FROM    dbo.rongyuguanli";
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
                if (ds.Tables[0].Rows[0]["Banfabumen"] != null)
                {
                    this.Banfabumen = ds.Tables[0].Rows[0]["Banfabumen"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Youxiaoqi"] != null)
                {
                    this.Youxiaoqi = int.Parse(ds.Tables[0].Rows[0]["Youxiaoqi"]+"");
                }
                if (ds.Tables[0].Rows[0]["Banfashijian"] != null)
                {
                    this.Banfashijian = DateTime.Parse(ds.Tables[0].Rows[0]["Banfashijian"]+"");
                }
                 

            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [rongyuguanli]");
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
            string sql = @"INSERT INTO dbo.rongyuguanli
                            ( Leibie ,
                              Mingcheng ,
                              Banfabumen ,
                              Youxiaoqi ,
                              Banfashijian  
                            )";
            strSql.Append(sql);
            strSql.Append(" values (");
            strSql.Append("@Leibie,@Mingcheng,@Banfabumen,@Youxiaoqi,@Banfashijian  )");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@Leibie", SqlDbType.NVarChar,50),
                    new SqlParameter("@Mingcheng", SqlDbType.NVarChar,50),
                    new SqlParameter("@Banfabumen", SqlDbType.NVarChar,50),
                    new SqlParameter("@Youxiaoqi", SqlDbType.Int,4),
                    new SqlParameter("@Banfashijian", SqlDbType.DateTime)  };
            parameters[0].Value = Leibie;
            parameters[1].Value = Mingcheng;
            parameters[2].Value = Banfabumen;
            parameters[3].Value = Youxiaoqi;
            parameters[4].Value = Banfashijian;

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
            strSql.Append("update [rongyuguanli] set ");
            strSql.Append("Leibie=@Leibie,");
            strSql.Append("Mingcheng=@Mingcheng,");
            strSql.Append("Banfabumen=@Banfabumen,");
            strSql.Append("Youxiaoqi=@Youxiaoqi,");
            strSql.Append("Banfashijian=@Banfashijian ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@Leibie", SqlDbType.NVarChar,50),
                    new SqlParameter("@Mingcheng", SqlDbType.NVarChar,50),
                    new SqlParameter("@Banfabumen", SqlDbType.NVarChar,50),
                    new SqlParameter("@Youxiaoqi", SqlDbType.Int,4),
                    new SqlParameter("@Banfashijian", SqlDbType.DateTime),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = Leibie;
            parameters[1].Value = Mingcheng;
            parameters[2].Value = Banfabumen;
            parameters[3].Value = Youxiaoqi;
            parameters[4].Value = Banfashijian;
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
            strSql.Append("delete from [rongyuguanli]");
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
                                    Banfabumen ,
                                    Banfashijian ,
                                    Youxiaoqi
                            FROM    dbo.rongyuguanli";
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
                if (ds.Tables[0].Rows[0]["Banfabumen"] != null)
                {
                    this.Banfabumen = ds.Tables[0].Rows[0]["Banfabumen"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Youxiaoqi"] != null)
                {
                    this.Youxiaoqi = int.Parse(ds.Tables[0].Rows[0]["Youxiaoqi"] + "");
                }
                if (ds.Tables[0].Rows[0]["Banfashijian"] != null)
                {
                    this.Banfashijian = DateTime.Parse(ds.Tables[0].Rows[0]["Banfashijian"] + "");
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
                                    banfabumen ,
                                    dbo.DateFmt4(banfashijian)  AS banfashijian ,
                                    youxiaoqi
                            FROM    dbo.rongyuguanli";
            strSql.Append(sql);
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method

    }
}
