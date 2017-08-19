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
    public class Bztj
    {
        public Bztj(){}
        #region Model
        private int _id;
        private string _pname;
        private string _zhiliang;
        private int _shuliang;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        public string Pname
        {
            get { return _pname; }
            set { _pname = value; }
        }
       
        public string Zhiliang
        {
            get { return _zhiliang; }
            set { _zhiliang = value; }
        }


        public int Shuliang
        {
            get { return _shuliang; }
            set { _shuliang = value; }
        }



       

        #endregion Model


        #region  Method

        /// <summary>
		/// 得到一个对象实体
		/// </summary>
        public Bztj(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,pname,zhiliang,shuliang  ");
			strSql.Append(" FROM baozhuangtongji ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.Id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
 
				if(ds.Tables[0].Rows[0]["pname"]!=null)
				{
					this.Pname=ds.Tables[0].Rows[0]["pname"].ToString();
				}
                if (ds.Tables[0].Rows[0]["Zhiliang"] != null)
				{
                    this.Zhiliang = ds.Tables[0].Rows[0]["Zhiliang"].ToString();
				}
				if(ds.Tables[0].Rows[0]["shuliang"]!=null)
				{
                    this.Shuliang = int.Parse(ds.Tables[0].Rows[0]["shuliang"].ToString());
				}
				 
				 
			}
		}
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) from baozhuangtongji");
			strSql.Append(" where id=@id ");

			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into baozhuangtongji (");
			strSql.Append("pname,zhiliang,shuliang )");
			strSql.Append(" values (");
            strSql.Append(" @pname,@zhiliang,@shuliang )");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
 
					new SqlParameter("@pname", SqlDbType.VarChar,150),
					new SqlParameter("@zhiliang", SqlDbType.VarChar,50),
					new SqlParameter("@shuliang", SqlDbType.Int)  };
			parameters[0].Value = Pname;
			parameters[1].Value = Zhiliang;
			parameters[2].Value = Shuliang;
 
			 
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
            strSql.Append("update baozhuangtongji set ");
			strSql.Append("pname=@pname,");
            strSql.Append("zhiliang=@zhiliang,");
			strSql.Append("shuliang=@shuliang ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@pname", SqlDbType.VarChar,150),
					new SqlParameter("@zhiliang", SqlDbType.VarChar,4),
					new SqlParameter("@shuliang", SqlDbType.Int,4),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = Pname;
			parameters[1].Value = Zhiliang;
			parameters[2].Value = Shuliang;
			parameters[3].Value = Id;

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
		public bool Delete(int id)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("delete from baozhuangtongji ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
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
		public void GetModel(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id, pname,zhiliang,shuliang  ");
            strSql.Append(" FROM baozhuangtongji ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.Id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
			 
				if(ds.Tables[0].Rows[0]["pname"]!=null )
				{
					this.Pname=ds.Tables[0].Rows[0]["pname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["zhiliang"]!=null )
				{
                    this.Zhiliang = ds.Tables[0].Rows[0]["zhiliang"].ToString();
				}
				if(ds.Tables[0].Rows[0]["shuliang"]!=null )
				{
                    this.Shuliang = int.Parse(ds.Tables[0].Rows[0]["shuliang"].ToString());
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
            strSql.Append(" FROM baozhuangtongji ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
    }
}
