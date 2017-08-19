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
    public class OldCar
    {
        public OldCar()
		{}

			#region Model
		private int _id;
		private string _tasknum;
		private string _htnum;
		private string _seller;
		private string _sell_tel;
		private string _sell_address;
		private string _buyer;
		private string _buy_tel;
		private string _buy_address;
		private string _plat_num;
		private string _dengji_num;
		private string _cartype;
		private string _chejianum;
		private string _changpai;
		private string _zhuanru;
		private string _fapiaofile;
		private string _chejiafile;
		private string _userid;
		private DateTime? _createtime= DateTime.Now;
		private string _sell_coder;
		private string _buy_coder;
		private DateTime? _offer_time;
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
		public string tasknum
		{
			set{ _tasknum=value;}
			get{return _tasknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string htnum
		{
			set{ _htnum=value;}
			get{return _htnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string seller
		{
			set{ _seller=value;}
			get{return _seller;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sell_tel
		{
			set{ _sell_tel=value;}
			get{return _sell_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sell_address
		{
			set{ _sell_address=value;}
			get{return _sell_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string buyer
		{
			set{ _buyer=value;}
			get{return _buyer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string buy_tel
		{
			set{ _buy_tel=value;}
			get{return _buy_tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string buy_address
		{
			set{ _buy_address=value;}
			get{return _buy_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string plat_num
		{
			set{ _plat_num=value;}
			get{return _plat_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string dengji_num
		{
			set{ _dengji_num=value;}
			get{return _dengji_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string cartype
		{
			set{ _cartype=value;}
			get{return _cartype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string chejianum
		{
			set{ _chejianum=value;}
			get{return _chejianum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string changpai
		{
			set{ _changpai=value;}
			get{return _changpai;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string zhuanru
		{
			set{ _zhuanru=value;}
			get{return _zhuanru;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string fapiaofile
		{
			set{ _fapiaofile=value;}
			get{return _fapiaofile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string chejiafile
		{
			set{ _chejiafile=value;}
			get{return _chejiafile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Userid
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sell_coder
		{
			set{ _sell_coder=value;}
			get{return _sell_coder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string buy_coder
		{
			set{ _buy_coder=value;}
			get{return _buy_coder;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? offer_time
		{
			set{ _offer_time=value;}
			get{return _offer_time;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public OldCar(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,tasknum,htnum,seller,sell_tel,sell_address,buyer,buy_tel,buy_address,plat_num,dengji_num,cartype,chejianum,changpai,zhuanru,fapiaofile,chejiafile,Userid,CreateTime,sell_coder,buy_coder,offer_time ");
			strSql.Append(" FROM [oldcar] ");
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
				if(ds.Tables[0].Rows[0]["tasknum"]!=null)
				{
					this.tasknum=ds.Tables[0].Rows[0]["tasknum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["htnum"]!=null)
				{
					this.htnum=ds.Tables[0].Rows[0]["htnum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["seller"]!=null)
				{
					this.seller=ds.Tables[0].Rows[0]["seller"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sell_tel"]!=null)
				{
					this.sell_tel=ds.Tables[0].Rows[0]["sell_tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sell_address"]!=null)
				{
					this.sell_address=ds.Tables[0].Rows[0]["sell_address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["buyer"]!=null)
				{
					this.buyer=ds.Tables[0].Rows[0]["buyer"].ToString();
				}
				if(ds.Tables[0].Rows[0]["buy_tel"]!=null)
				{
					this.buy_tel=ds.Tables[0].Rows[0]["buy_tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["buy_address"]!=null)
				{
					this.buy_address=ds.Tables[0].Rows[0]["buy_address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["plat_num"]!=null)
				{
					this.plat_num=ds.Tables[0].Rows[0]["plat_num"].ToString();
				}
				if(ds.Tables[0].Rows[0]["dengji_num"]!=null)
				{
					this.dengji_num=ds.Tables[0].Rows[0]["dengji_num"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cartype"]!=null)
				{
					this.cartype=ds.Tables[0].Rows[0]["cartype"].ToString();
				}
				if(ds.Tables[0].Rows[0]["chejianum"]!=null)
				{
					this.chejianum=ds.Tables[0].Rows[0]["chejianum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["changpai"]!=null)
				{
					this.changpai=ds.Tables[0].Rows[0]["changpai"].ToString();
				}
				if(ds.Tables[0].Rows[0]["zhuanru"]!=null)
				{
					this.zhuanru=ds.Tables[0].Rows[0]["zhuanru"].ToString();
				}
				if(ds.Tables[0].Rows[0]["fapiaofile"]!=null)
				{
					this.fapiaofile=ds.Tables[0].Rows[0]["fapiaofile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["chejiafile"]!=null)
				{
					this.chejiafile=ds.Tables[0].Rows[0]["chejiafile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Userid"]!=null)
				{
					this.Userid=ds.Tables[0].Rows[0]["Userid"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sell_coder"]!=null)
				{
					this.sell_coder=ds.Tables[0].Rows[0]["sell_coder"].ToString();
				}
				if(ds.Tables[0].Rows[0]["buy_coder"]!=null)
				{
					this.buy_coder=ds.Tables[0].Rows[0]["buy_coder"].ToString();
				}
				if(ds.Tables[0].Rows[0]["offer_time"]!=null && ds.Tables[0].Rows[0]["offer_time"].ToString()!="")
				{
					this.offer_time=DateTime.Parse(ds.Tables[0].Rows[0]["offer_time"].ToString());
				}
			}
		}
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [oldcar]");
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
			strSql.Append("insert into [oldcar] (");
			strSql.Append("tasknum,htnum,seller,sell_tel,sell_address,buyer,buy_tel,buy_address,plat_num,dengji_num,cartype,chejianum,changpai,zhuanru,fapiaofile,chejiafile,Userid,CreateTime,sell_coder,buy_coder,offer_time)");
			strSql.Append(" values (");
			strSql.Append("@tasknum,@htnum,@seller,@sell_tel,@sell_address,@buyer,@buy_tel,@buy_address,@plat_num,@dengji_num,@cartype,@chejianum,@changpai,@zhuanru,@fapiaofile,@chejiafile,@Userid,@CreateTime,@sell_coder,@buy_coder,@offer_time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@tasknum", SqlDbType.VarChar,150),
					new SqlParameter("@htnum", SqlDbType.VarChar,150),
					new SqlParameter("@seller", SqlDbType.VarChar,50),
					new SqlParameter("@sell_tel", SqlDbType.VarChar,50),
					new SqlParameter("@sell_address", SqlDbType.VarChar,150),
					new SqlParameter("@buyer", SqlDbType.VarChar,50),
					new SqlParameter("@buy_tel", SqlDbType.VarChar,50),
					new SqlParameter("@buy_address", SqlDbType.VarChar,50),
					new SqlParameter("@plat_num", SqlDbType.VarChar,50),
					new SqlParameter("@dengji_num", SqlDbType.VarChar,50),
					new SqlParameter("@cartype", SqlDbType.VarChar,50),
					new SqlParameter("@chejianum", SqlDbType.VarChar,50),
					new SqlParameter("@changpai", SqlDbType.VarChar,500),
					new SqlParameter("@zhuanru", SqlDbType.VarChar,150),
					new SqlParameter("@fapiaofile", SqlDbType.VarChar,250),
					new SqlParameter("@chejiafile", SqlDbType.VarChar,50),
					new SqlParameter("@Userid", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@sell_coder", SqlDbType.VarChar,50),
					new SqlParameter("@buy_coder", SqlDbType.VarChar,50),
					new SqlParameter("@offer_time", SqlDbType.DateTime)};
			parameters[0].Value = tasknum;
			parameters[1].Value = htnum;
			parameters[2].Value = seller;
			parameters[3].Value = sell_tel;
			parameters[4].Value = sell_address;
			parameters[5].Value = buyer;
			parameters[6].Value = buy_tel;
			parameters[7].Value = buy_address;
			parameters[8].Value = plat_num;
			parameters[9].Value = dengji_num;
			parameters[10].Value = cartype;
			parameters[11].Value = chejianum;
			parameters[12].Value = changpai;
			parameters[13].Value = zhuanru;
			parameters[14].Value = fapiaofile;
			parameters[15].Value = chejiafile;
			parameters[16].Value = Userid;
			parameters[17].Value = CreateTime;
			parameters[18].Value = sell_coder;
			parameters[19].Value = buy_coder;
			parameters[20].Value = offer_time;

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
			strSql.Append("update [oldcar] set ");
			strSql.Append("tasknum=@tasknum,");
			strSql.Append("htnum=@htnum,");
			strSql.Append("seller=@seller,");
			strSql.Append("sell_tel=@sell_tel,");
			strSql.Append("sell_address=@sell_address,");
			strSql.Append("buyer=@buyer,");
			strSql.Append("buy_tel=@buy_tel,");
			strSql.Append("buy_address=@buy_address,");
			strSql.Append("plat_num=@plat_num,");
			strSql.Append("dengji_num=@dengji_num,");
			strSql.Append("cartype=@cartype,");
			strSql.Append("chejianum=@chejianum,");
			strSql.Append("changpai=@changpai,");
			strSql.Append("zhuanru=@zhuanru,");
			strSql.Append("fapiaofile=@fapiaofile,");
			strSql.Append("chejiafile=@chejiafile,");
			strSql.Append("Userid=@Userid,");
			strSql.Append("CreateTime=@CreateTime,");
			strSql.Append("sell_coder=@sell_coder,");
			strSql.Append("buy_coder=@buy_coder,");
			strSql.Append("offer_time=@offer_time");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@tasknum", SqlDbType.VarChar,150),
					new SqlParameter("@htnum", SqlDbType.VarChar,150),
					new SqlParameter("@seller", SqlDbType.VarChar,50),
					new SqlParameter("@sell_tel", SqlDbType.VarChar,50),
					new SqlParameter("@sell_address", SqlDbType.VarChar,150),
					new SqlParameter("@buyer", SqlDbType.VarChar,50),
					new SqlParameter("@buy_tel", SqlDbType.VarChar,50),
					new SqlParameter("@buy_address", SqlDbType.VarChar,50),
					new SqlParameter("@plat_num", SqlDbType.VarChar,50),
					new SqlParameter("@dengji_num", SqlDbType.VarChar,50),
					new SqlParameter("@cartype", SqlDbType.VarChar,50),
					new SqlParameter("@chejianum", SqlDbType.VarChar,50),
					new SqlParameter("@changpai", SqlDbType.VarChar,500),
					new SqlParameter("@zhuanru", SqlDbType.VarChar,150),
					new SqlParameter("@fapiaofile", SqlDbType.VarChar,250),
					new SqlParameter("@chejiafile", SqlDbType.VarChar,50),
					new SqlParameter("@Userid", SqlDbType.VarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@sell_coder", SqlDbType.VarChar,50),
					new SqlParameter("@buy_coder", SqlDbType.VarChar,50),
					new SqlParameter("@offer_time", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = tasknum;
			parameters[1].Value = htnum;
			parameters[2].Value = seller;
			parameters[3].Value = sell_tel;
			parameters[4].Value = sell_address;
			parameters[5].Value = buyer;
			parameters[6].Value = buy_tel;
			parameters[7].Value = buy_address;
			parameters[8].Value = plat_num;
			parameters[9].Value = dengji_num;
			parameters[10].Value = cartype;
			parameters[11].Value = chejianum;
			parameters[12].Value = changpai;
			parameters[13].Value = zhuanru;
			parameters[14].Value = fapiaofile;
			parameters[15].Value = chejiafile;
			parameters[16].Value = Userid;
			parameters[17].Value = CreateTime;
			parameters[18].Value = sell_coder;
			parameters[19].Value = buy_coder;
			parameters[20].Value = offer_time;
			parameters[21].Value = id;

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
			strSql.Append("delete from [oldcar] ");
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
			strSql.Append("select id,tasknum,htnum,seller,sell_tel,sell_address,buyer,buy_tel,buy_address,plat_num,dengji_num,cartype,chejianum,changpai,zhuanru,fapiaofile,chejiafile,Userid,CreateTime,sell_coder,buy_coder,offer_time ");
			strSql.Append(" FROM [oldcar] ");
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
				if(ds.Tables[0].Rows[0]["tasknum"]!=null )
				{
					this.tasknum=ds.Tables[0].Rows[0]["tasknum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["htnum"]!=null )
				{
					this.htnum=ds.Tables[0].Rows[0]["htnum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["seller"]!=null )
				{
					this.seller=ds.Tables[0].Rows[0]["seller"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sell_tel"]!=null )
				{
					this.sell_tel=ds.Tables[0].Rows[0]["sell_tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sell_address"]!=null )
				{
					this.sell_address=ds.Tables[0].Rows[0]["sell_address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["buyer"]!=null )
				{
					this.buyer=ds.Tables[0].Rows[0]["buyer"].ToString();
				}
				if(ds.Tables[0].Rows[0]["buy_tel"]!=null )
				{
					this.buy_tel=ds.Tables[0].Rows[0]["buy_tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["buy_address"]!=null )
				{
					this.buy_address=ds.Tables[0].Rows[0]["buy_address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["plat_num"]!=null )
				{
					this.plat_num=ds.Tables[0].Rows[0]["plat_num"].ToString();
				}
				if(ds.Tables[0].Rows[0]["dengji_num"]!=null )
				{
					this.dengji_num=ds.Tables[0].Rows[0]["dengji_num"].ToString();
				}
				if(ds.Tables[0].Rows[0]["cartype"]!=null )
				{
					this.cartype=ds.Tables[0].Rows[0]["cartype"].ToString();
				}
				if(ds.Tables[0].Rows[0]["chejianum"]!=null )
				{
					this.chejianum=ds.Tables[0].Rows[0]["chejianum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["changpai"]!=null )
				{
					this.changpai=ds.Tables[0].Rows[0]["changpai"].ToString();
				}
				if(ds.Tables[0].Rows[0]["zhuanru"]!=null )
				{
					this.zhuanru=ds.Tables[0].Rows[0]["zhuanru"].ToString();
				}
				if(ds.Tables[0].Rows[0]["fapiaofile"]!=null )
				{
					this.fapiaofile=ds.Tables[0].Rows[0]["fapiaofile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["chejiafile"]!=null )
				{
					this.chejiafile=ds.Tables[0].Rows[0]["chejiafile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Userid"]!=null )
				{
					this.Userid=ds.Tables[0].Rows[0]["Userid"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CreateTime"]!=null && ds.Tables[0].Rows[0]["CreateTime"].ToString()!="")
				{
					this.CreateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["sell_coder"]!=null )
				{
					this.sell_coder=ds.Tables[0].Rows[0]["sell_coder"].ToString();
				}
				if(ds.Tables[0].Rows[0]["buy_coder"]!=null )
				{
					this.buy_coder=ds.Tables[0].Rows[0]["buy_coder"].ToString();
				}
				if(ds.Tables[0].Rows[0]["offer_time"]!=null && ds.Tables[0].Rows[0]["offer_time"].ToString()!="")
				{
					this.offer_time=DateTime.Parse(ds.Tables[0].Rows[0]["offer_time"].ToString());
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
			strSql.Append(" FROM [oldcar] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
    }
}
