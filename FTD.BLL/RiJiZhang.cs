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
    public class RiJiZhang
    {
        public RiJiZhang()
        { }
        #region Model
        private int _id;
        private int? _year;
        private int? _month;
        private int? _day;
        private string _proof;
        private string _zaiyao;
        private string _subject;
        private decimal? _inmoney;
        private decimal? _outmoney;
        private decimal? _nowmoney;
        private string _createuser;
        private DateTime? _createtime;
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
        public int? Year
        {
            set { _year = value; }
            get { return _year; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Month
        {
            set { _month = value; }
            get { return _month; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Day
        {
            set { _day = value; }
            get { return _day; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Proof
        {
            set { _proof = value; }
            get { return _proof; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZaiYao
        {
            set { _zaiyao = value; }
            get { return _zaiyao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Subject
        {
            set { _subject = value; }
            get { return _subject; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? InMoney
        {
            set { _inmoney = value; }
            get { return _inmoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? OutMoney
        {
            set { _outmoney = value; }
            get { return _outmoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? NowMoney
        {
            set { _nowmoney = value; }
            get { return _nowmoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CreateUser
        {
            set { _createuser = value; }
            get { return _createuser; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public RiJiZhang(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Year,Month,Day,Proof,ZaiYao,Subject,InMoney,OutMoney,NowMoney,CreateUser,CreateTime ");
            strSql.Append(" FROM [RiJiZhang] ");
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
                if (ds.Tables[0].Rows[0]["Year"] != null && ds.Tables[0].Rows[0]["Year"].ToString() != "")
                {
                    this.Year = int.Parse(ds.Tables[0].Rows[0]["Year"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Month"] != null && ds.Tables[0].Rows[0]["Month"].ToString() != "")
                {
                    this.Month = int.Parse(ds.Tables[0].Rows[0]["Month"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Day"] != null && ds.Tables[0].Rows[0]["Day"].ToString() != "")
                {
                    this.Day = int.Parse(ds.Tables[0].Rows[0]["Day"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Proof"] != null)
                {
                    this.Proof = ds.Tables[0].Rows[0]["Proof"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZaiYao"] != null)
                {
                    this.ZaiYao = ds.Tables[0].Rows[0]["ZaiYao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Subject"] != null)
                {
                    this.Subject = ds.Tables[0].Rows[0]["Subject"].ToString();
                }
                if (ds.Tables[0].Rows[0]["InMoney"] != null && ds.Tables[0].Rows[0]["InMoney"].ToString() != "")
                {
                    this.InMoney = decimal.Parse(ds.Tables[0].Rows[0]["InMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OutMoney"] != null && ds.Tables[0].Rows[0]["OutMoney"].ToString() != "")
                {
                    this.OutMoney = decimal.Parse(ds.Tables[0].Rows[0]["OutMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NowMoney"] != null && ds.Tables[0].Rows[0]["NowMoney"].ToString() != "")
                {
                    this.NowMoney = decimal.Parse(ds.Tables[0].Rows[0]["NowMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreateUser"] != null)
                {
                    this.CreateUser = ds.Tables[0].Rows[0]["CreateUser"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null && ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    this.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [RiJiZhang]");
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
            strSql.Append("insert into [RiJiZhang] (");
            strSql.Append("Year,Month,Day,Proof,ZaiYao,Subject,InMoney,OutMoney,NowMoney,CreateUser,CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@Year,@Month,@Day,@Proof,@ZaiYao,@Subject,@InMoney,@OutMoney,@NowMoney,@CreateUser,@CreateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Year", SqlDbType.Int,4),
					new SqlParameter("@Month", SqlDbType.Int,4),
					new SqlParameter("@Day", SqlDbType.Int,4),
					new SqlParameter("@Proof", SqlDbType.VarChar,50),
					new SqlParameter("@ZaiYao", SqlDbType.VarChar,250),
					new SqlParameter("@Subject", SqlDbType.VarChar,250),
					new SqlParameter("@InMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OutMoney", SqlDbType.Decimal,9),
					new SqlParameter("@NowMoney", SqlDbType.Decimal,9),
					new SqlParameter("@CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
            parameters[0].Value = Year;
            parameters[1].Value = Month;
            parameters[2].Value = Day;
            parameters[3].Value = Proof;
            parameters[4].Value = ZaiYao;
            parameters[5].Value = Subject;
            parameters[6].Value = InMoney;
            parameters[7].Value = OutMoney;
            parameters[8].Value = NowMoney;
            parameters[9].Value = CreateUser;
            parameters[10].Value = CreateTime;

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
            strSql.Append("update [RiJiZhang] set ");
            strSql.Append("Year=@Year,");
            strSql.Append("Month=@Month,");
            strSql.Append("Day=@Day,");
            strSql.Append("Proof=@Proof,");
            strSql.Append("ZaiYao=@ZaiYao,");
            strSql.Append("Subject=@Subject,");
            strSql.Append("InMoney=@InMoney,");
            strSql.Append("OutMoney=@OutMoney,");
            strSql.Append("NowMoney=@NowMoney,");
            strSql.Append("CreateUser=@CreateUser,");
            strSql.Append("CreateTime=@CreateTime");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Year", SqlDbType.Int,4),
					new SqlParameter("@Month", SqlDbType.Int,4),
					new SqlParameter("@Day", SqlDbType.Int,4),
					new SqlParameter("@Proof", SqlDbType.VarChar,50),
					new SqlParameter("@ZaiYao", SqlDbType.VarChar,250),
					new SqlParameter("@Subject", SqlDbType.VarChar,250),
					new SqlParameter("@InMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OutMoney", SqlDbType.Decimal,9),
					new SqlParameter("@NowMoney", SqlDbType.Decimal,9),
					new SqlParameter("@CreateUser", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = Year;
            parameters[1].Value = Month;
            parameters[2].Value = Day;
            parameters[3].Value = Proof;
            parameters[4].Value = ZaiYao;
            parameters[5].Value = Subject;
            parameters[6].Value = InMoney;
            parameters[7].Value = OutMoney;
            parameters[8].Value = NowMoney;
            parameters[9].Value = CreateUser;
            parameters[10].Value = CreateTime;
            parameters[11].Value = id;

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
            strSql.Append("delete from [RiJiZhang] ");
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
            strSql.Append("select id,Year,Month,Day,Proof,ZaiYao,Subject,InMoney,OutMoney,NowMoney,CreateUser,CreateTime ");
            strSql.Append(" FROM [RiJiZhang] ");
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
                if (ds.Tables[0].Rows[0]["Year"] != null && ds.Tables[0].Rows[0]["Year"].ToString() != "")
                {
                    this.Year = int.Parse(ds.Tables[0].Rows[0]["Year"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Month"] != null && ds.Tables[0].Rows[0]["Month"].ToString() != "")
                {
                    this.Month = int.Parse(ds.Tables[0].Rows[0]["Month"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Day"] != null && ds.Tables[0].Rows[0]["Day"].ToString() != "")
                {
                    this.Day = int.Parse(ds.Tables[0].Rows[0]["Day"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Proof"] != null)
                {
                    this.Proof = ds.Tables[0].Rows[0]["Proof"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ZaiYao"] != null)
                {
                    this.ZaiYao = ds.Tables[0].Rows[0]["ZaiYao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Subject"] != null)
                {
                    this.Subject = ds.Tables[0].Rows[0]["Subject"].ToString();
                }
                if (ds.Tables[0].Rows[0]["InMoney"] != null && ds.Tables[0].Rows[0]["InMoney"].ToString() != "")
                {
                    this.InMoney = decimal.Parse(ds.Tables[0].Rows[0]["InMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OutMoney"] != null && ds.Tables[0].Rows[0]["OutMoney"].ToString() != "")
                {
                    this.OutMoney = decimal.Parse(ds.Tables[0].Rows[0]["OutMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NowMoney"] != null && ds.Tables[0].Rows[0]["NowMoney"].ToString() != "")
                {
                    this.NowMoney = decimal.Parse(ds.Tables[0].Rows[0]["NowMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreateUser"] != null)
                {
                    this.CreateUser = ds.Tables[0].Rows[0]["CreateUser"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null && ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    this.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
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
            strSql.Append(" FROM [RiJiZhang] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}
