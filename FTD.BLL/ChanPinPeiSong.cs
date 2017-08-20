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
    public partial class ChanPinPeiSong
    {
        /// <summary>
        /// 
        /// </summary>
        public ChanPinPeiSong()
        { }
        #region Model
        /// <summary>
        /// 
        /// SELECT  id ,
        //recordtime ,
        //peisongdanwei ,
        //peisongdizhi ,
        //dingdanhao ,
        //jieojieren ,
        //peisongcheliang ,
        //peisonglicheng ,
        //peisongren FROM dbo.nongchanpinpeisong
        /// </summary>
        private long _id;
        private DateTime? _recordtime;
        private string _peisongdanwei;
        private string _peisongdizhi;
        private string _dingdanhao;
        private string _jiaojieren;
        private string _peisongcheliang;
        private string _peisonglicheng;
        private string _peisongren;


        /// <summary>
        /// 
        /// </summary>
        public long id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
		public DateTime? recordtime
        {
            set { _recordtime = value; }
            get { return _recordtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string peisongdanwei
        {
            set { _peisongdanwei = value; }
            get { return _peisongdanwei; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string peisongdizhi
        {
            set { _peisongdizhi = value; }
            get { return _peisongdizhi; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string dingdanhao
        {
            set { _dingdanhao = value; }
            get { return _dingdanhao; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string jiaojieren
        {
            set { _jiaojieren = value; }
            get { return _jiaojieren; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string peisongcheliang
        {
            set { _peisongcheliang = value; }
            get { return _peisongcheliang; }
        }

        public string peisonglicheng
        {
            get
            {
                return _peisonglicheng;
            }

            set
            {
                _peisonglicheng = value;
            }
        }

        public string peisongren
        {
            get
            {
                return _peisongren;
            }

            set
            {
                _peisongren = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        #endregion Model


        #region  Method

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ChanPinPeiSong(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,recordtime,peisongdanwei,peisongdizhi,dingdanhao,jiaojieren,peisongcheliang,peisonglicheng,peisongren  ");
            strSql.Append(" FROM nongchanpinpeisong ");
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
                if (ds.Tables[0].Rows[0]["recordtime"] != null)
                {
                    this.recordtime = DateTime.Parse(ds.Tables[0].Rows[0]["recordtime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["peisongdanwei"] != null)
                {
                    this.peisongdanwei = ds.Tables[0].Rows[0]["peisongdanwei"].ToString();
                }
                if (ds.Tables[0].Rows[0]["peisongdizhi"] != null)
                {
                    this.peisongdizhi = ds.Tables[0].Rows[0]["peisongdizhi"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dingdanhao"] != null)
                {
                    this.dingdanhao = ds.Tables[0].Rows[0]["dingdanhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiaojieren"] != null)
                {
                    this.jiaojieren = ds.Tables[0].Rows[0]["jiaojieren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["peisongcheliang"] != null)
                {
                    this.peisongcheliang = ds.Tables[0].Rows[0]["peisongcheliang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["peisonglicheng"] != null)
                {
                    this.peisonglicheng = ds.Tables[0].Rows[0]["peisonglicheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["peisongren"] != null)
                {
                    this.peisongren = ds.Tables[0].Rows[0]["peisongren"].ToString();
                }

            }
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from nongchanpinpeisong");
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
            strSql.Append("insert into nongchanpinpeisong (");
            strSql.Append("recordtime,peisongdanwei,peisongdizhi,dingdanhao,jiaojieren,peisongcheliang,peisonglicheng,peisongren )");
            strSql.Append(" values (");
            strSql.Append("@recordtime,@peisongdanwei,@peisongdizhi,@dingdanhao,@jiaojieren,@peisongcheliang，@peisonglicheng，@peisongren )");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
                    new SqlParameter("@recordtime", SqlDbType.DateTime),
                    new SqlParameter("@peisongdanwei", SqlDbType.VarChar,100),
                    new SqlParameter("@peisongdizhi", SqlDbType.VarChar,200),
                    new SqlParameter("@dingdanhao", SqlDbType.VarChar,50),
                    new SqlParameter("@jiaojieren", SqlDbType.VarChar,50),
                    new SqlParameter("@peisongcheliang", SqlDbType.VarChar,50),
                    new SqlParameter("@peisonglicheng", SqlDbType.VarChar,50),
                    new SqlParameter("@peisongren", SqlDbType.VarChar,50)};
            parameters[0].Value = recordtime;
            parameters[1].Value = peisongdanwei;
            parameters[2].Value = peisongdizhi;
            parameters[3].Value = dingdanhao;
            parameters[4].Value = jiaojieren;
            parameters[5].Value = peisongcheliang;
            parameters[6].Value = peisonglicheng;
            parameters[7].Value = peisongren;

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
            strSql.Append("update nongchanpinpeisong set ");
            strSql.Append("recordtime=@recordtime,");
            strSql.Append("peisongdanwei=@peisongdanwei,");
            strSql.Append("peisongdizhi=@peisongdizhi,");
            strSql.Append("dingdanhao=@dingdanhao,");
            strSql.Append("jiaojieren=@jiaojieren,");
            strSql.Append("peisongcheliang=@peisongcheliang ");
            strSql.Append("peisonglicheng=@peisonglicheng ");
            strSql.Append("peisongren=@peisongren ");
            strSql.Append(" where id=@id ");
            SqlParameter[] parameters = {
                    new SqlParameter("@recordtime", SqlDbType.DateTime),
                    new SqlParameter("@peisongdanwei", SqlDbType.VarChar,100),
                    new SqlParameter("@peisongdizhi", SqlDbType.VarChar,200),
                    new SqlParameter("@dingdanhao", SqlDbType.VarChar,50),
                    new SqlParameter("@jiaojieren", SqlDbType.VarChar,50),
                    new SqlParameter("@peisongcheliang", SqlDbType.VarChar,50),
                    new SqlParameter("@peisonglicheng", SqlDbType.VarChar,50),
                    new SqlParameter("@peisongren", SqlDbType.VarChar,50),
                    new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = recordtime;
            parameters[1].Value = peisongdanwei;
            parameters[2].Value = peisongdizhi;
            parameters[3].Value = dingdanhao;
            parameters[4].Value = jiaojieren;
            parameters[5].Value = peisongcheliang;
            parameters[6].Value = peisonglicheng;
            parameters[7].Value = peisongren;
            parameters[8].Value = id;

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
            strSql.Append("delete from nongchanpinpeisong ");
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
            strSql.Append("select id,recordtime,peisongdanwei,peisongdizhi,dingdanhao,jiaojieren,peisongcheliang,peisonglicheng,peisongren  ");
            strSql.Append(" FROM nongchanpinpeisong ");
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
                if (ds.Tables[0].Rows[0]["recordtime"] != null)
                {
                    this.recordtime = DateTime.Parse(ds.Tables[0].Rows[0]["recordtime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["peisongdanwei"] != null)
                {
                    this.peisongdanwei = ds.Tables[0].Rows[0]["peisongdanwei"].ToString();
                }
                if (ds.Tables[0].Rows[0]["peisongdizhi"] != null)
                {
                    this.peisongdizhi = ds.Tables[0].Rows[0]["peisongdizhi"].ToString();
                }
                if (ds.Tables[0].Rows[0]["dingdanhao"] != null)
                {
                    this.dingdanhao = ds.Tables[0].Rows[0]["dingdanhao"].ToString();
                }
                if (ds.Tables[0].Rows[0]["jiaojieren"] != null)
                {
                    this.jiaojieren = ds.Tables[0].Rows[0]["jiaojieren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["peisongcheliang"] != null)
                {
                    this.peisongcheliang = ds.Tables[0].Rows[0]["peisongcheliang"].ToString();
                }
                if (ds.Tables[0].Rows[0]["peisonglicheng"] != null)
                {
                    this.peisonglicheng = ds.Tables[0].Rows[0]["peisonglicheng"].ToString();
                }
                if (ds.Tables[0].Rows[0]["peisongren"] != null)
                {
                    this.peisongren = ds.Tables[0].Rows[0]["peisongren"].ToString();
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
            strSql.Append(" FROM nongchanpinpeisong ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  Method
    }
}