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
   public class ERPNewHuiYuan
    {
        public ERPNewHuiYuan()
        { }

        #region Model
        private int _id;
        private string _customer;
        private string _tel;
        private string _address;
        private string _sendrole;
        private string _sendtime;
        private int? _sendcounts;
        private int? _realsend;
        private DateTime? _firsttime;
        private string _sendtype;
        private int? _cstaus;
        private DateTime? _endtime;
        private string _ordernumber;
        private string _taocannum;
        private string _username;
        private DateTime? _createtime;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Customer
        {
            set { _customer = value; }
            get { return _customer; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Tel
        {
            set { _tel = value; }
            get { return _tel; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Sendrole
        {
            set { _sendrole = value; }
            get { return _sendrole; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SendTime
        {
            set { _sendtime = value; }
            get { return _sendtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? SendCounts
        {
            set { _sendcounts = value; }
            get { return _sendcounts; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? RealSend
        {
            set { _realsend = value; }
            get { return _realsend; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? FirstTime
        {
            set { _firsttime = value; }
            get { return _firsttime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SendType
        {
            set { _sendtype = value; }
            get { return _sendtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? CStaus
        {
            set { _cstaus = value; }
            get { return _cstaus; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? EndTime
        {
            set { _endtime = value; }
            get { return _endtime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string OrderNumber
        {
            set { _ordernumber = value; }
            get { return _ordernumber; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string TaoCanNum
        {
            set { _taocannum = value; }
            get { return _taocannum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
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
        public ERPNewHuiYuan(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [ERPNewHuiYuan].Id,Customer,Tel,Address,Sendrole,SendTime,SendCounts,RealSend,FirstTime,SendType,CStaus,EndTime,OrderNumber,[ERPHuiYuanTaoCan].TaoCanName AS TaoCanNum,UserName,CreateTime  ");
            strSql.Append(" FROM [ERPNewHuiYuan]  ");
            strSql.Append("LEFT JOIN [ERPHuiYuanTaoCan] ON [ERPHuiYuanTaoCan].SendCount = [ERPNewHuiYuan].TaoCanNum");
            strSql.Append(" where ERPNewHuiYuan.Id=@Id ");
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
                if (ds.Tables[0].Rows[0]["Customer"] != null)
                {
                    this.Customer = ds.Tables[0].Rows[0]["Customer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Tel"] != null)
                {
                    this.Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Address"] != null)
                {
                    this.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Sendrole"] != null)
                {
                    this.Sendrole = ds.Tables[0].Rows[0]["Sendrole"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SendTime"] != null)
                {
                    this.SendTime = ds.Tables[0].Rows[0]["SendTime"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SendCounts"] != null && ds.Tables[0].Rows[0]["SendCounts"].ToString() != "")
                {
                    this.SendCounts = int.Parse(ds.Tables[0].Rows[0]["SendCounts"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RealSend"] != null && ds.Tables[0].Rows[0]["RealSend"].ToString() != "")
                {
                    this.RealSend = int.Parse(ds.Tables[0].Rows[0]["RealSend"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FirstTime"] != null && ds.Tables[0].Rows[0]["FirstTime"].ToString() != "")
                {
                    this.FirstTime = DateTime.Parse(ds.Tables[0].Rows[0]["FirstTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SendType"] != null)
                {
                    this.SendType = ds.Tables[0].Rows[0]["SendType"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CStaus"] != null && ds.Tables[0].Rows[0]["CStaus"].ToString() != "")
                {
                    this.CStaus = int.Parse(ds.Tables[0].Rows[0]["CStaus"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EndTime"] != null && ds.Tables[0].Rows[0]["EndTime"].ToString() != "")
                {
                    this.EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["EndTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderNumber"] != null)
                {
                    this.OrderNumber = ds.Tables[0].Rows[0]["OrderNumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["TaoCanNum"] != null)
                {
                    this.TaoCanNum = ds.Tables[0].Rows[0]["TaoCanNum"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UserName"] != null)
                {
                    this.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
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
        public bool Exists(int Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [ERPNewHuiYuan]");
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
            strSql.Append("insert into [ERPNewHuiYuan] (");
            strSql.Append("Customer,Tel,Address,Sendrole,SendTime,SendCounts,RealSend,FirstTime,SendType,CStaus,EndTime,OrderNumber,TaoCanNum,UserName,CreateTime)");
            strSql.Append(" values (");
            strSql.Append("@Customer,@Tel,@Address,@Sendrole,@SendTime,@SendCounts,@RealSend,@FirstTime,@SendType,@CStaus,@EndTime,@OrderNumber,@TaoCanNum,@UserName,@CreateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Customer", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,250),
					new SqlParameter("@Sendrole", SqlDbType.VarChar,50),
					new SqlParameter("@SendTime", SqlDbType.VarChar,50),
					new SqlParameter("@SendCounts", SqlDbType.Int,4),
					new SqlParameter("@RealSend", SqlDbType.Int,4),
					new SqlParameter("@FirstTime", SqlDbType.DateTime),
					new SqlParameter("@SendType", SqlDbType.VarChar,50),
					new SqlParameter("@CStaus", SqlDbType.Int,4),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@OrderNumber", SqlDbType.VarChar,50),
					new SqlParameter("@TaoCanNum", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime)};
            parameters[0].Value = Customer;
            parameters[1].Value = Tel;
            parameters[2].Value = Address;
            parameters[3].Value = Sendrole;
            parameters[4].Value = SendTime;
            parameters[5].Value = SendCounts;
            parameters[6].Value = RealSend;
            parameters[7].Value = FirstTime;
            parameters[8].Value = SendType;
            parameters[9].Value = CStaus;
            parameters[10].Value = EndTime;
            parameters[11].Value = OrderNumber;
            parameters[12].Value = TaoCanNum;
            parameters[13].Value = UserName;
            parameters[14].Value = CreateTime;

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
            strSql.Append("update [ERPNewHuiYuan] set ");
            strSql.Append("Customer=@Customer,");
            strSql.Append("Tel=@Tel,");
            strSql.Append("Address=@Address,");
            strSql.Append("Sendrole=@Sendrole,");
            strSql.Append("SendTime=@SendTime,");
            strSql.Append("SendCounts=@SendCounts,");
            strSql.Append("RealSend=@RealSend,");
            strSql.Append("FirstTime=@FirstTime,");
            strSql.Append("SendType=@SendType,");
            strSql.Append("CStaus=@CStaus,");
            strSql.Append("EndTime=@EndTime,");
            strSql.Append("OrderNumber=@OrderNumber,");
            strSql.Append("TaoCanNum=@TaoCanNum,");
            strSql.Append("UserName=@UserName,");
            strSql.Append("CreateTime=@CreateTime");
            strSql.Append(" where Id=@Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@Customer", SqlDbType.VarChar,50),
					new SqlParameter("@Tel", SqlDbType.VarChar,50),
					new SqlParameter("@Address", SqlDbType.VarChar,250),
					new SqlParameter("@Sendrole", SqlDbType.VarChar,50),
					new SqlParameter("@SendTime", SqlDbType.VarChar,50),
					new SqlParameter("@SendCounts", SqlDbType.Int,4),
					new SqlParameter("@RealSend", SqlDbType.Int,4),
					new SqlParameter("@FirstTime", SqlDbType.DateTime),
					new SqlParameter("@SendType", SqlDbType.VarChar,50),
					new SqlParameter("@CStaus", SqlDbType.Int,4),
					new SqlParameter("@EndTime", SqlDbType.DateTime),
					new SqlParameter("@OrderNumber", SqlDbType.VarChar,50),
					new SqlParameter("@TaoCanNum", SqlDbType.VarChar,50),
					new SqlParameter("@UserName", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.Int,4)};
            parameters[0].Value = Customer;
            parameters[1].Value = Tel;
            parameters[2].Value = Address;
            parameters[3].Value = Sendrole;
            parameters[4].Value = SendTime;
            parameters[5].Value = SendCounts;
            parameters[6].Value = RealSend;
            parameters[7].Value = FirstTime;
            parameters[8].Value = SendType;
            parameters[9].Value = CStaus;
            parameters[10].Value = EndTime;
            parameters[11].Value = OrderNumber;
            parameters[12].Value = TaoCanNum;
            parameters[13].Value = UserName;
            parameters[14].Value = CreateTime;
            parameters[15].Value = Id;

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
            strSql.Append("delete from [ERPNewHuiYuan] ");
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
            strSql.Append("select [ERPNewHuiYuan].Id,Customer,Tel,Address,Sendrole,SendTime,SendCounts,RealSend,FirstTime,SendType,CStaus,EndTime,OrderNumber,       TaoCanNum,UserName,CreateTime  ");
            strSql.Append(" FROM [ERPNewHuiYuan]  ");
            strSql.Append(" where ERPNewHuiYuan.Id=@Id ");
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
                if (ds.Tables[0].Rows[0]["Customer"] != null)
                {
                    this.Customer = ds.Tables[0].Rows[0]["Customer"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Tel"] != null)
                {
                    this.Tel = ds.Tables[0].Rows[0]["Tel"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Address"] != null)
                {
                    this.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Sendrole"] != null)
                {
                    this.Sendrole = ds.Tables[0].Rows[0]["Sendrole"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SendTime"] != null)
                {
                    this.SendTime = ds.Tables[0].Rows[0]["SendTime"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SendCounts"] != null && ds.Tables[0].Rows[0]["SendCounts"].ToString() != "")
                {
                    this.SendCounts = int.Parse(ds.Tables[0].Rows[0]["SendCounts"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RealSend"] != null && ds.Tables[0].Rows[0]["RealSend"].ToString() != "")
                {
                    this.RealSend = int.Parse(ds.Tables[0].Rows[0]["RealSend"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FirstTime"] != null && ds.Tables[0].Rows[0]["FirstTime"].ToString() != "")
                {
                    this.FirstTime = DateTime.Parse(ds.Tables[0].Rows[0]["FirstTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SendType"] != null)
                {
                    this.SendType = ds.Tables[0].Rows[0]["SendType"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CStaus"] != null && ds.Tables[0].Rows[0]["CStaus"].ToString() != "")
                {
                    this.CStaus = int.Parse(ds.Tables[0].Rows[0]["CStaus"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EndTime"] != null && ds.Tables[0].Rows[0]["EndTime"].ToString() != "")
                {
                    this.EndTime = DateTime.Parse(ds.Tables[0].Rows[0]["EndTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderNumber"] != null)
                {
                    this.OrderNumber = ds.Tables[0].Rows[0]["OrderNumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["TaoCanNum"] != null)
                {
                    this.TaoCanNum = ds.Tables[0].Rows[0]["TaoCanNum"].ToString();
                }
                if (ds.Tables[0].Rows[0]["UserName"] != null)
                {
                    this.UserName = ds.Tables[0].Rows[0]["UserName"].ToString();
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
            strSql.Append("select [ERPNewHuiYuan].Id,Customer,Tel,Address,Sendrole,SendTime,SendCounts,RealSend,FirstTime,SendType,CStaus,EndTime,OrderNumber,      TaoCanNum,UserName,CreateTime,TaoCanName ");
            strSql.Append(" FROM [ERPNewHuiYuan] ");
            strSql.Append("LEFT JOIN [ERPHuiYuanTaoCan] ON [ERPHuiYuanTaoCan].SendCount = [ERPNewHuiYuan].TaoCanNum");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        public DataSet _GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Customer,Tel,Address ");
            strSql.Append(" FROM [ERPNewHuiYuan] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }


        public DataSet GetList2(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ERPNewHuiYuan.*,huiyuanLog.*");
            strSql.Append(" FROM [ERPNewHuiYuan],huiyuanLog ");
            strSql.Append(" where  ERPNewHuiYuan.UserName = ERPNewHuiYuan.UserName " + strWhere);

           
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  Method
    }
}
