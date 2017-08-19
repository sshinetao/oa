using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//请先添加引用
namespace FTD.BLL
{
    /// <summary>
    /// 车年检
    /// </summary>
    public class ERPCarNianJian
    {
        public ERPCarNianJian() { }
        #region Model

        private int _id;
        private string _carname;
        private string _chejiandate;
        private string _username;
        private DateTime? _timestr;
        private string _backinfo;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        

        public string Carname
        {
            get { return _carname; }
            set { _carname = value; }
        }


        public string Chejiandate
        {
            get { return _chejiandate; }
            set { _chejiandate = value; }
        }
        

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
       

        public DateTime? Timestr
        {
            get { return _timestr; }
            set { _timestr = value; }
        }
       

        public string Backinfo
        {
            get { return _backinfo; }
            set { _backinfo = value; }
        }
        #endregion 

        #region

        public ERPCarNianJian(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,CarName,Username,Chejiandate,Timestr,Backinfo ");
            strSql.Append(" FROM ERPCarNianJian ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                Carname = ds.Tables[0].Rows[0]["CarName"].ToString();
                Username = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    Timestr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Chejiandate"].ToString() != "")
                {
                    Chejiandate = ds.Tables[0].Rows[0]["Chejiandate"].ToString();
                }
                Backinfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
            }
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {

            return DbHelperSQL.GetMaxID("ID", "ERPCarNianJian");
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ERPCarNianJian");
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
            strSql.Append("insert into ERPCarNianJian(");
            strSql.Append("CarName,Username,Chejiandate,Timestr,Backinfo)");
            strSql.Append(" values (");
            strSql.Append("@CarName,@Username,@Chejiandate,@Timestr,@Backinfo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Carname", SqlDbType.VarChar,50),
					new SqlParameter("@Username", SqlDbType.VarChar,50),
					new SqlParameter("@Chejiandate", SqlDbType.VarChar,500),
					new SqlParameter("@Timestr", SqlDbType.DateTime),
					new SqlParameter("@Backinfo", SqlDbType.VarChar,500)};
            parameters[0].Value = Carname;
            parameters[1].Value = Username;
            parameters[2].Value = Chejiandate;
            parameters[3].Value = Timestr;
            parameters[4].Value = Backinfo;


            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ERPCarNianJian set ");
            strSql.Append("Carname=@Carname,");
            strSql.Append("Username=@Username,");
            strSql.Append("Chejiandate=@Chejiandate,");
            strSql.Append("Timestr=@Timestr,");
            strSql.Append("Backinfo=@Backinfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Carname", SqlDbType.VarChar,50),
					new SqlParameter("@Username", SqlDbType.VarChar,50),
					new SqlParameter("@Chejiandate", SqlDbType.VarChar,500),
					new SqlParameter("@Timestr", SqlDbType.DateTime),
					new SqlParameter("@Backinfo", SqlDbType.VarChar,500)};
            parameters[0].Value = ID;
            parameters[1].Value = Carname;
            parameters[2].Value = Username;
            parameters[3].Value = Chejiandate;
            parameters[4].Value = Timestr;
            parameters[5].Value = Backinfo;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ERPCarNianJian ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public void GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CarName,Username,Chejiandate,Timestr,Backinfo  ");
            strSql.Append(" FROM ERPCarNianJian ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                Carname = ds.Tables[0].Rows[0]["CarName"].ToString();
                Username = ds.Tables[0].Rows[0]["UserName"].ToString();
                if (ds.Tables[0].Rows[0]["TimeStr"].ToString() != "")
                {
                    Timestr = DateTime.Parse(ds.Tables[0].Rows[0]["TimeStr"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Chejiandate"].ToString() != "")
                {
                    Chejiandate = ds.Tables[0].Rows[0]["Chejiandate"].ToString();
                }
                Backinfo = ds.Tables[0].Rows[0]["BackInfo"].ToString();
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM ERPCarNianJian ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion
    }


    
}
