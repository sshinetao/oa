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
    public class Bzrrstj
    {
            public Bzrrstj() {}

			#region Model
		private int _id;
		private string _rname;
		private string _pname;
		private string _yongshi;
		private string _shuliang;
		private string _gongzi;
		private string _zhuangtai;


	 
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string rname
		{
			set{ _rname=value;}
			get{return _rname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string pname
		{
			set{ _pname=value;}
			get{return _pname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string yongshi
		{
			set{ _yongshi=value;}
			get{return _yongshi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string shuliang
		{
			set{ _shuliang=value;}
			get{return _shuliang;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gongzi
		{
			set{ _gongzi=value;}
			get{return _gongzi;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zhuangtai
		{
			set{ _zhuangtai=value;}
			get{return _zhuangtai;}
		}
		/// <summary>
		/// 
		/// </summary>
	 
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public Bzrrstj(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,rname,pname,yongshi,shuliang,gongzi,zhuangtai  ");
			strSql.Append(" FROM baozhuangrenyuanyongshitongji ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["rname"]!=null)
				{
					this.rname=ds.Tables[0].Rows[0]["rname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pname"]!=null)
				{
					this.pname=ds.Tables[0].Rows[0]["pname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["yongshi"]!=null)
				{
					this.yongshi=ds.Tables[0].Rows[0]["yongshi"].ToString();
				}
				if(ds.Tables[0].Rows[0]["shuliang"]!=null)
				{
					this.shuliang=ds.Tables[0].Rows[0]["shuliang"].ToString();
				}
				if(ds.Tables[0].Rows[0]["gongzi"]!=null)
				{
					this.gongzi=ds.Tables[0].Rows[0]["gongzi"].ToString();
				}
				if(ds.Tables[0].Rows[0]["zhuangtai"]!=null)
				{
					this.zhuangtai=ds.Tables[0].Rows[0]["zhuangtai"].ToString();
				}
				 
			}
		}
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select count(1) from baozhuangrenyuanyongshitongji");
			strSql.Append(" where id=@id ");

			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("insert into baozhuangrenyuanyongshitongji (");
			strSql.Append("rname,pname,yongshi,shuliang,gongzi,zhuangtai )");
			strSql.Append(" values (");
			strSql.Append("@rname,@pname,@yongshi,@shuliang,@gongzi,@zhuangtai )");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@rname", SqlDbType.VarChar,150),
					new SqlParameter("@pname", SqlDbType.VarChar,150),
					new SqlParameter("@yongshi", SqlDbType.VarChar,50),
					new SqlParameter("@shuliang", SqlDbType.VarChar,50),
					new SqlParameter("@gongzi", SqlDbType.VarChar,150),
					new SqlParameter("@zhuangtai", SqlDbType.VarChar,50) };
			parameters[0].Value = rname;
			parameters[1].Value = pname;
			parameters[2].Value = yongshi;
			parameters[3].Value = shuliang;
			parameters[4].Value = gongzi;
			parameters[5].Value = zhuangtai;
			 
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
            strSql.Append("update baozhuangrenyuanyongshitongji set ");
			strSql.Append("rname=@rname,");
			strSql.Append("pname=@pname,");
			strSql.Append("yongshi=@yongshi,");
			strSql.Append("shuliang=@shuliang,");
			strSql.Append("gongzi=@gongzi,");
			strSql.Append("zhuangtai=@zhuangtai ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@rname", SqlDbType.VarChar,150),
					new SqlParameter("@pname", SqlDbType.VarChar,150),
					new SqlParameter("@yongshi", SqlDbType.Int,4),
					new SqlParameter("@shuliang", SqlDbType.Int,4),
					new SqlParameter("@gongzi", SqlDbType.Decimal,2),
					new SqlParameter("@zhuangtai", SqlDbType.VarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = rname;
			parameters[1].Value = pname;
			parameters[2].Value = yongshi;
			parameters[3].Value = shuliang;
			parameters[4].Value = gongzi;
			parameters[5].Value = zhuangtai;
			parameters[6].Value = id;

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
            strSql.Append("delete from baozhuangrenyuanyongshitongji ");
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
			strSql.Append("select id,rname,pname,yongshi,shuliang,gongzi,zhuangtai  ");
            strSql.Append(" FROM baozhuangrenyuanyongshitongji ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.id=int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["rname"]!=null )
				{
					this.rname=ds.Tables[0].Rows[0]["rname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["pname"]!=null )
				{
					this.pname=ds.Tables[0].Rows[0]["pname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["yongshi"]!=null )
				{
					this.yongshi=ds.Tables[0].Rows[0]["yongshi"].ToString();
				}
				if(ds.Tables[0].Rows[0]["shuliang"]!=null )
				{
					this.shuliang=ds.Tables[0].Rows[0]["shuliang"].ToString();
				}
				if(ds.Tables[0].Rows[0]["gongzi"]!=null )
				{
					this.gongzi=ds.Tables[0].Rows[0]["gongzi"].ToString();
				}
				if(ds.Tables[0].Rows[0]["zhuangtai"]!=null )
				{
					this.zhuangtai=ds.Tables[0].Rows[0]["zhuangtai"].ToString();
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
            strSql.Append(" FROM baozhuangrenyuanyongshitongji ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
    }
}
