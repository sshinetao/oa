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
    public partial class KQSQ
    {
        public KQSQ()
		{}
		#region Model
        private long _id;
        private string _name;
        private string _type;
        private string _fuzeren;
        private string _zhuangtai;
        private DateTime _kaishishijian;
        private DateTime _jieshushijian;

        public DateTime Jieshushijian
        {
            get { return _jieshushijian; }
            set { _jieshushijian = value; }
        }
        public DateTime Kaishishijian
        {
            get { return _kaishishijian; }
            set { _kaishishijian = value; }
        }
        

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
       
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        
        public string Fuzeren
        {
            get { return _fuzeren; }
            set { _fuzeren = value; }
        }
        
        public string Zhuangtai
        {
            get { return _zhuangtai; }
            set { _zhuangtai = value; }
        }
		 
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public KQSQ(long id)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id ,type ,fuzeren ,Name ,zhuangtai,kaishishijian,jieshushijian");
            strSql.Append(" FROM [kaoqinshenqing] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
                if (ds.Tables[0].Rows[0]["id"].ToString() != "") 
                {
                    this.Id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); 
                }
                if (ds.Tables[0].Rows[0]["Name"] != null)
                {
                    this.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["type"] != null)
                {
                    this.Type = ds.Tables[0].Rows[0]["type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fuzeren"] != null)
                {
                    this.Fuzeren = ds.Tables[0].Rows[0]["fuzeren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhuangtai"] != null)
                {
                    this.Zhuangtai = ds.Tables[0].Rows[0]["zhuangtai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kaishishijian"] != null)
                {
                    this.Kaishishijian = DateTime.Parse(ds.Tables[0].Rows[0]["kaishishijian"]+"");
                }
                if (ds.Tables[0].Rows[0]["jieshushijian"] != null)
                {
                    this.Jieshushijian = DateTime.Parse(ds.Tables[0].Rows[0]["jieshushijian"] + "");
                }
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) from [kaoqinshenqing]");
			strSql.Append(" where id=@id ");

			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value =Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("INSERT INTO dbo.kaoqinshenqing");
            strSql.Append("( type, fuzeren, name, zhuangtai ,kaishishijian,jieshushijian)");
			strSql.Append(" values (");
            strSql.Append("@type ,");
            strSql.Append("@fuzeren ,");
            strSql.Append("@name ,");
            strSql.Append("@zhuangtai,");
            strSql.Append("@kaishishijian,");
            strSql.Append("@jieshushijian  )");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@type", SqlDbType.NVarChar,50) ,
                    new SqlParameter("@fuzeren", SqlDbType.NVarChar,50) ,
                    new SqlParameter("@name", SqlDbType.NVarChar,50) ,
                    new SqlParameter("@zhuangtai", SqlDbType.NVarChar,50) ,
                    new SqlParameter("@kaishishijian", SqlDbType.DateTime) ,
                    new SqlParameter("@jieshushijian", SqlDbType.DateTime) 
                                        };
			parameters[0].Value = Type;
            parameters[1].Value = Fuzeren;
            parameters[2].Value = Name;
            parameters[3].Value = Zhuangtai;
            parameters[4].Value = Kaishishijian;
            parameters[5].Value = Jieshushijian;
			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
			StringBuilder strSql=new StringBuilder();
            strSql.Append("update [kaoqinshenqing] set ");
            strSql.Append("fuzeren=@fuzeren,");
            strSql.Append("type=@type,");
            strSql.Append("Name=@name,");
            strSql.Append("zhuangtai=@zhuangtai,");
            strSql.Append("kaishishijian=@kaishishijian,");
            strSql.Append("jieshushijian=@jieshushijian ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
                    new SqlParameter("@fuzeren", SqlDbType.NVarChar,50) ,
					new SqlParameter("@type", SqlDbType.NVarChar,50) ,
                    new SqlParameter("@name", SqlDbType.NVarChar,50) ,
                    new SqlParameter("@zhuangtai", SqlDbType.NVarChar,50) ,
                    new SqlParameter("@kaishishijian", SqlDbType.DateTime) ,
                    new SqlParameter("@jieshushijian", SqlDbType.DateTime) ,
					new SqlParameter("@id", SqlDbType.BigInt,8)};
            parameters[0].Value = Fuzeren;
            parameters[1].Value = Type;
            parameters[2].Value = Name;
            parameters[3].Value = Zhuangtai;
            parameters[4].Value = Kaishishijian;
            parameters[5].Value = Jieshushijian;
            parameters[6].Value =Id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(long id)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("delete from [kaoqinshenqing] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public void GetModel(long id)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select id,type, fuzeren, Name, zhuangtai ,kaishishijian,jieshushijian");
            strSql.Append(" FROM [kaoqinshenqing] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.Id=long.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Name"]!=null )
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
                if (ds.Tables[0].Rows[0]["type"] != null)
                {
                    this.Type = ds.Tables[0].Rows[0]["type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["fuzeren"] != null)
                {
                    this.Fuzeren = ds.Tables[0].Rows[0]["fuzeren"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhuangtai"] != null)
                {
                    this.Zhuangtai = ds.Tables[0].Rows[0]["zhuangtai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["kaishishijian"] != null)
                {
                    this.Kaishishijian = DateTime.Parse(ds.Tables[0].Rows[0]["kaishishijian"] + "");
                }
                if (ds.Tables[0].Rows[0]["jieshushijian"] != null)
                {
                    this.Jieshushijian = DateTime.Parse(ds.Tables[0].Rows[0]["jieshushijian"] + "");
                }
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select * ");
            strSql.Append(" FROM [kaoqinshenqing] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
    }
}
