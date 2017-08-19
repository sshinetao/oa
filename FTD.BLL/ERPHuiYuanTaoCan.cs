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
   public  class ERPHuiYuanTaoCan
    {
        public ERPHuiYuanTaoCan()
        { }
        #region Model
        private int _id;
        private string _taocanname;
        private int? _sendcount;
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
        public string TaoCanName
        {
            set { _taocanname = value; }
            get { return _taocanname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? SendCount
        {
            set { _sendcount = value; }
            get { return _sendcount; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ERPHuiYuanTaoCan(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,TaoCanName,SendCount ");
            strSql.Append(" FROM [ERPHuiYuanTaoCan] ");
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
                if (ds.Tables[0].Rows[0]["TaoCanName"] != null)
                {
                    this.TaoCanName = ds.Tables[0].Rows[0]["TaoCanName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SendCount"] != null && ds.Tables[0].Rows[0]["SendCount"].ToString() != "")
                {
                    this.SendCount = int.Parse(ds.Tables[0].Rows[0]["SendCount"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [ERPHuiYuanTaoCan]");
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
            strSql.Append("insert into [ERPHuiYuanTaoCan] (");
            strSql.Append("TaoCanName,SendCount)");
            strSql.Append(" values (");
            strSql.Append("@TaoCanName,@SendCount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TaoCanName", SqlDbType.VarChar,50),
					new SqlParameter("@SendCount", SqlDbType.Int,4)};
            parameters[0].Value = TaoCanName;
            parameters[1].Value = SendCount;

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
            strSql.Append("update [ERPHuiYuanTaoCan] set ");
            strSql.Append("TaoCanName=@TaoCanName,");
            strSql.Append("SendCount=@SendCount");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@TaoCanName", SqlDbType.VarChar,50),
					new SqlParameter("@SendCount", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = TaoCanName;
            parameters[1].Value = SendCount;
            parameters[2].Value = id;

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
            strSql.Append("delete from [ERPHuiYuanTaoCan] ");
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
            strSql.Append("select id,TaoCanName,SendCount ");
            strSql.Append(" FROM [ERPHuiYuanTaoCan] ");
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
                if (ds.Tables[0].Rows[0]["TaoCanName"] != null)
                {
                    this.TaoCanName = ds.Tables[0].Rows[0]["TaoCanName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SendCount"] != null && ds.Tables[0].Rows[0]["SendCount"].ToString() != "")
                {
                    this.SendCount = int.Parse(ds.Tables[0].Rows[0]["SendCount"].ToString());
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
            strSql.Append(" FROM [ERPHuiYuanTaoCan] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}
