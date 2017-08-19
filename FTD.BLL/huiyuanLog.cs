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
    public class huiyuanLog
    {
        public huiyuanLog()
        { }
        #region Model
        private int _id;
        private string _huiyuannum;
        private string _huiyuanname;
        private DateTime? _createtime = DateTime.Now;
        private string _username;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HuiYuanNum
        {
            set { _huiyuannum = value; }
            get { return _huiyuannum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string HuiYuanName
        {
            set { _huiyuanname = value; }
            get { return _huiyuanname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public huiyuanLog(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,HuiYuanNum,HuiYuanName,CreateTime,UserName ");
            strSql.Append(" FROM [huiyuanLog] ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["HuiYuanNum"] != null)
                {
                    this.HuiYuanNum = ds.Tables[0].Rows[0]["HuiYuanNum"].ToString();
                }
                if (ds.Tables[0].Rows[0]["HuiYuanName"] != null)
                {
                    this.HuiYuanName = ds.Tables[0].Rows[0]["HuiYuanName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null && ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    this.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserName"] != null)
                {
                    this.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [huiyuanLog]");
            strSql.Append(" where id=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [huiyuanLog] (");
            strSql.Append("HuiYuanNum,HuiYuanName,CreateTime,UserName)");
            strSql.Append(" values (");
            strSql.Append("@HuiYuanNum,@HuiYuanName,@CreateTime,@UserName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@HuiYuanNum", SqlDbType.VarChar,50),
					new SqlParameter("@HuiYuanName", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@UserName", SqlDbType.VarChar,50)};
            parameters[0].Value = HuiYuanNum;
            parameters[1].Value = HuiYuanName;
            parameters[2].Value = CreateTime;
            parameters[3].Value = UserName;

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
            strSql.Append("update [huiyuanLog] set ");
            strSql.Append("HuiYuanNum=@HuiYuanNum,");
            strSql.Append("HuiYuanName=@HuiYuanName,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("UserName=@UserName");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@HuiYuanNum", SqlDbType.VarChar,50),
					new SqlParameter("@HuiYuanName", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = HuiYuanNum;
            parameters[1].Value = HuiYuanName;
            parameters[2].Value = CreateTime;
            parameters[3].Value = UserName;
            parameters[4].Value = id;

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
            strSql.Append("delete from [huiyuanLog] ");
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
            strSql.Append("select id,HuiYuanNum,HuiYuanName,CreateTime,UserName ");
            strSql.Append(" FROM [huiyuanLog] ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = id;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["HuiYuanNum"] != null)
                {
                    this.HuiYuanNum = ds.Tables[0].Rows[0]["HuiYuanNum"].ToString();
                }
                if (ds.Tables[0].Rows[0]["HuiYuanName"] != null)
                {
                    this.HuiYuanName = ds.Tables[0].Rows[0]["HuiYuanName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null && ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    this.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserName"] != null)
                {
                    this.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
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
            strSql.Append(" FROM [huiyuanLog] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}
