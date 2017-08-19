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
    public class liushui
    {
        public liushui()
        { }
        #region Model
        private int _id;
        private string _title;
        private string _pingzheng;
        private string _duifang;
        private string _zaiyao;
        private decimal? _inmoney;
        private decimal? _outmoney;
        private decimal? _nowmoney;
        private int? _year;
        private int? _monty;
        private int? _day;
        private DateTime? _createtime = DateTime.Now;
        private string _usernum;
        private string _realname;
        private string _itemid;
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
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pingzheng
        {
            set { _pingzheng = value; }
            get { return _pingzheng; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string duifang
        {
            set { _duifang = value; }
            get { return _duifang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string zaiyao
        {
            set { _zaiyao = value; }
            get { return _zaiyao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? inMoney
        {
            set { _inmoney = value; }
            get { return _inmoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? outMoney
        {
            set { _outmoney = value; }
            get { return _outmoney; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? nowMoney
        {
            set { _nowmoney = value; }
            get { return _nowmoney; }
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
        public int? Monty
        {
            set { _monty = value; }
            get { return _monty; }
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
        public DateTime? CreateTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Usernum
        {
            set { _usernum = value; }
            get { return _usernum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string RealName
        {
            set { _realname = value; }
            get { return _realname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string itemid
        {
            set { _itemid = value; }
            get { return _itemid; }
        }
        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public liushui(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,title,pingzheng,duifang,zaiyao,inMoney,outMoney,nowMoney,Year,Monty,Day,CreateTime,Usernum,RealName,itemid ");
            strSql.Append(" FROM [liushui] ");
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
                if (ds.Tables[0].Rows[0]["title"] != null)
                {
                    this.title = ds.Tables[0].Rows[0]["title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pingzheng"] != null)
                {
                    this.pingzheng = ds.Tables[0].Rows[0]["pingzheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["duifang"] != null)
                {
                    this.duifang = ds.Tables[0].Rows[0]["duifang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zaiyao"] != null)
                {
                    this.zaiyao = ds.Tables[0].Rows[0]["zaiyao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["inMoney"] != null && ds.Tables[0].Rows[0]["inMoney"].ToString() != "")
                {
                    this.inMoney = decimal.Parse(ds.Tables[0].Rows[0]["inMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["outMoney"] != null && ds.Tables[0].Rows[0]["outMoney"].ToString() != "")
                {
                    this.outMoney = decimal.Parse(ds.Tables[0].Rows[0]["outMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["nowMoney"] != null && ds.Tables[0].Rows[0]["nowMoney"].ToString() != "")
                {
                    this.nowMoney = decimal.Parse(ds.Tables[0].Rows[0]["nowMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Year"] != null && ds.Tables[0].Rows[0]["Year"].ToString() != "")
                {
                    this.Year = int.Parse(ds.Tables[0].Rows[0]["Year"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Monty"] != null && ds.Tables[0].Rows[0]["Monty"].ToString() != "")
                {
                    this.Monty = int.Parse(ds.Tables[0].Rows[0]["Monty"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Day"] != null && ds.Tables[0].Rows[0]["Day"].ToString() != "")
                {
                    this.Day = int.Parse(ds.Tables[0].Rows[0]["Day"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null && ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    this.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Usernum"] != null)
                {
                    this.Usernum = ds.Tables[0].Rows[0]["Usernum"].ToString();
                }
                if (ds.Tables[0].Rows[0]["RealName"] != null)
                {
                    this.RealName = ds.Tables[0].Rows[0]["RealName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["itemid"] != null)
                {
                    this.itemid = ds.Tables[0].Rows[0]["itemid"].ToString();
                }
            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [liushui]");
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
            strSql.Append("insert into [liushui] (");
            strSql.Append("title,pingzheng,duifang,zaiyao,inMoney,outMoney,nowMoney,Year,Monty,Day,CreateTime,Usernum,RealName,itemid)");
            strSql.Append(" values (");
            strSql.Append("@title,@pingzheng,@duifang,@zaiyao,@inMoney,@outMoney,@nowMoney,@Year,@Monty,@Day,@CreateTime,@Usernum,@RealName,@itemid)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.NVarChar,200),
					new SqlParameter("@pingzheng", SqlDbType.NVarChar,50),
					new SqlParameter("@duifang", SqlDbType.NVarChar,500),
					new SqlParameter("@zaiyao", SqlDbType.NVarChar,500),
					new SqlParameter("@inMoney", SqlDbType.Decimal,9),
					new SqlParameter("@outMoney", SqlDbType.Decimal,9),
					new SqlParameter("@nowMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Year", SqlDbType.Int,4),
					new SqlParameter("@Monty", SqlDbType.Int,4),
					new SqlParameter("@Day", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Usernum", SqlDbType.VarChar,50),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@itemid", SqlDbType.VarChar,50)};
            parameters[0].Value = title;
            parameters[1].Value = pingzheng;
            parameters[2].Value = duifang;
            parameters[3].Value = zaiyao;
            parameters[4].Value = inMoney;
            parameters[5].Value = outMoney;
            parameters[6].Value = nowMoney;
            parameters[7].Value = Year;
            parameters[8].Value = Monty;
            parameters[9].Value = Day;
            parameters[10].Value = CreateTime;
            parameters[11].Value = Usernum;
            parameters[12].Value = RealName;
            parameters[13].Value = itemid;

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
            strSql.Append("update [liushui] set ");
            strSql.Append("title=@title,");
            strSql.Append("pingzheng=@pingzheng,");
            strSql.Append("duifang=@duifang,");
            strSql.Append("zaiyao=@zaiyao,");
            strSql.Append("inMoney=@inMoney,");
            strSql.Append("outMoney=@outMoney,");
            strSql.Append("nowMoney=@nowMoney,");
            strSql.Append("Year=@Year,");
            strSql.Append("Monty=@Monty,");
            strSql.Append("Day=@Day,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("Usernum=@Usernum,");
            strSql.Append("RealName=@RealName,");
            strSql.Append("itemid=@itemid");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
					new SqlParameter("@title", SqlDbType.NVarChar,200),
					new SqlParameter("@pingzheng", SqlDbType.NVarChar,50),
					new SqlParameter("@duifang", SqlDbType.NVarChar,500),
					new SqlParameter("@zaiyao", SqlDbType.NVarChar,500),
					new SqlParameter("@inMoney", SqlDbType.Decimal,9),
					new SqlParameter("@outMoney", SqlDbType.Decimal,9),
					new SqlParameter("@nowMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Year", SqlDbType.Int,4),
					new SqlParameter("@Monty", SqlDbType.Int,4),
					new SqlParameter("@Day", SqlDbType.Int,4),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Usernum", SqlDbType.VarChar,50),
					new SqlParameter("@RealName", SqlDbType.VarChar,50),
					new SqlParameter("@itemid", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = title;
            parameters[1].Value = pingzheng;
            parameters[2].Value = duifang;
            parameters[3].Value = zaiyao;
            parameters[4].Value = inMoney;
            parameters[5].Value = outMoney;
            parameters[6].Value = nowMoney;
            parameters[7].Value = Year;
            parameters[8].Value = Monty;
            parameters[9].Value = Day;
            parameters[10].Value = CreateTime;
            parameters[11].Value = Usernum;
            parameters[12].Value = RealName;
            parameters[13].Value = itemid;
            parameters[14].Value = id;

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
            strSql.Append("delete from [liushui] ");
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
            strSql.Append("select id,title,pingzheng,duifang,zaiyao,inMoney,outMoney,nowMoney,Year,Monty,Day,CreateTime,Usernum,RealName,itemid ");
            strSql.Append(" FROM [liushui] ");
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
                if (ds.Tables[0].Rows[0]["title"] != null)
                {
                    this.title = ds.Tables[0].Rows[0]["title"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pingzheng"] != null)
                {
                    this.pingzheng = ds.Tables[0].Rows[0]["pingzheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["duifang"] != null)
                {
                    this.duifang = ds.Tables[0].Rows[0]["duifang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zaiyao"] != null)
                {
                    this.zaiyao = ds.Tables[0].Rows[0]["zaiyao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["inMoney"] != null && ds.Tables[0].Rows[0]["inMoney"].ToString() != "")
                {
                    this.inMoney = decimal.Parse(ds.Tables[0].Rows[0]["inMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["outMoney"] != null && ds.Tables[0].Rows[0]["outMoney"].ToString() != "")
                {
                    this.outMoney = decimal.Parse(ds.Tables[0].Rows[0]["outMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["nowMoney"] != null && ds.Tables[0].Rows[0]["nowMoney"].ToString() != "")
                {
                    this.nowMoney = decimal.Parse(ds.Tables[0].Rows[0]["nowMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Year"] != null && ds.Tables[0].Rows[0]["Year"].ToString() != "")
                {
                    this.Year = int.Parse(ds.Tables[0].Rows[0]["Year"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Monty"] != null && ds.Tables[0].Rows[0]["Monty"].ToString() != "")
                {
                    this.Monty = int.Parse(ds.Tables[0].Rows[0]["Monty"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Day"] != null && ds.Tables[0].Rows[0]["Day"].ToString() != "")
                {
                    this.Day = int.Parse(ds.Tables[0].Rows[0]["Day"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null && ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    this.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Usernum"] != null)
                {
                    this.Usernum = ds.Tables[0].Rows[0]["Usernum"].ToString();
                }
                if (ds.Tables[0].Rows[0]["RealName"] != null)
                {
                    this.RealName = ds.Tables[0].Rows[0]["RealName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["itemid"] != null)
                {
                    this.itemid = ds.Tables[0].Rows[0]["itemid"].ToString();
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
            strSql.Append(" FROM [liushui] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}
