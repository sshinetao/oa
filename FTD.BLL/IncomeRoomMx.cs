﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类IncomeRoomMx。
	/// </summary>
	[Serializable]
	public partial class IncomeRoomMx
	{
		public IncomeRoomMx()
		{}
		#region Model
		private long _id;
		private string _keyfile;
		private string _goodsnumber;
		private string _goodsname;
		private string _countunit;
		private string _model;
		private decimal? _stockpoint;
        private decimal? _singlemoney;

        public decimal? Singlemoney
        {
            get { return _singlemoney; }
            set { _singlemoney = value; }
        }
        private decimal? _allmoney;

        public decimal? Allmoney
        {
            get { return _allmoney; }
            set { _allmoney = value; }
        }
		private string _username;
		private string _realname;
		private DateTime? _nowtimes;
        private string _zhongzhihu;

        public string Zhongzhihu
        {
            get { return _zhongzhihu; }
            set { _zhongzhihu = value; }
        }
        private string _zhuangtai;

        public string Zhuangtai
        {
            get { return _zhuangtai; }
            set { _zhuangtai = value; }
        }
        private string _beizhu;

        public string Beizhu
        {
            get { return _beizhu; }
            set { _beizhu = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public long Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Keyfile
		{
			set{ _keyfile=value;}
			get{return _keyfile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsNumber
		{
			set{ _goodsnumber=value;}
			get{return _goodsnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsName
		{
			set{ _goodsname=value;}
			get{return _goodsname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CountUnit
		{
			set{ _countunit=value;}
			get{return _countunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Model
		{
			set{ _model=value;}
			get{return _model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? StockPoint
		{
			set{ _stockpoint=value;}
			get{return _stockpoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Username
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Realname
		{
			set{ _realname=value;}
			get{return _realname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Nowtimes
		{
			set{ _nowtimes=value;}
			get{return _nowtimes;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public IncomeRoomMx(long Id)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select Id,Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,Username,Realname,Nowtimes ,zhongzhihu,zhuangtai,beizhu,SingleMoney,Allmoney");
			strSql.Append(" FROM [IncomeRoomMx] ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["Id"].ToString() != "") { this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()); }
				if(ds.Tables[0].Rows[0]["Keyfile"]!=null)
				{
					this.Keyfile=ds.Tables[0].Rows[0]["Keyfile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GoodsNumber"]!=null)
				{
					this.GoodsNumber=ds.Tables[0].Rows[0]["GoodsNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GoodsName"]!=null)
				{
					this.GoodsName=ds.Tables[0].Rows[0]["GoodsName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CountUnit"]!=null)
				{
					this.CountUnit=ds.Tables[0].Rows[0]["CountUnit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Model"]!=null)
				{
					this.Model=ds.Tables[0].Rows[0]["Model"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPoint"]!=null && ds.Tables[0].Rows[0]["StockPoint"].ToString()!="")
				{
					this.StockPoint=decimal.Parse(ds.Tables[0].Rows[0]["StockPoint"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Username"]!=null)
				{
					this.Username=ds.Tables[0].Rows[0]["Username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Realname"]!=null)
				{
					this.Realname=ds.Tables[0].Rows[0]["Realname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Nowtimes"]!=null && ds.Tables[0].Rows[0]["Nowtimes"].ToString()!="")
				{
					this.Nowtimes=DateTime.Parse(ds.Tables[0].Rows[0]["Nowtimes"].ToString());
				}
                if (ds.Tables[0].Rows[0]["zhongzhihu"] != null)
                {
                    this.Zhongzhihu = ds.Tables[0].Rows[0]["zhongzhihu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhuangtai"] != null)
                {
                    this.Zhuangtai = ds.Tables[0].Rows[0]["zhuangtai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.Beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SingleMoney"] != null)
                {
                    this.Singlemoney = decimal.Parse(ds.Tables[0].Rows[0]["SingleMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Allmoney"] != null)
                {
                    this.Allmoney = decimal.Parse(ds.Tables[0].Rows[0]["Allmoney"].ToString());
                }
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [IncomeRoomMx]");
			strSql.Append(" where Id=@Id ");

			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [IncomeRoomMx] (");
            strSql.Append("Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,Username,Realname,Nowtimes,zhongzhihu,zhuangtai,beizhu,SingleMoney,Allmoney)");
			strSql.Append(" values (");
            strSql.Append("@Keyfile,@GoodsNumber,@GoodsName,@CountUnit,@Model,@StockPoint,@Username,@Realname,@Nowtimes,@zhongzhihu,@zhuangtai,@beizhu,@SingleMoney,@Allmoney)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Keyfile", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPoint", SqlDbType.Decimal,9),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
                    new SqlParameter("@zhongzhihu", SqlDbType.NVarChar,50),
                    new SqlParameter("@zhuangtai", SqlDbType.NVarChar,50),
                    new SqlParameter("@beizhu", SqlDbType.NVarChar,100),
                    new SqlParameter("@SingleMoney",SqlDbType.Decimal,9),
                    new SqlParameter("@Allmoney", SqlDbType.Decimal,9)                            };
			parameters[0].Value = Keyfile;
			parameters[1].Value = GoodsNumber;
			parameters[2].Value = GoodsName;
			parameters[3].Value = CountUnit;
			parameters[4].Value = Model;
			parameters[5].Value = StockPoint;
			parameters[6].Value = Username;
			parameters[7].Value = Realname;
			parameters[8].Value = Nowtimes;
            parameters[9].Value = Zhongzhihu;
            parameters[10].Value = Zhuangtai;
            parameters[11].Value = Beizhu;
            parameters[12].Value = Singlemoney;
            parameters[13].Value = Allmoney;
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
			strSql.Append("update [IncomeRoomMx] set ");
			strSql.Append("Keyfile=@Keyfile,");
			strSql.Append("GoodsNumber=@GoodsNumber,");
			strSql.Append("GoodsName=@GoodsName,");
			strSql.Append("CountUnit=@CountUnit,");
			strSql.Append("Model=@Model,");
			strSql.Append("StockPoint=@StockPoint,");
			strSql.Append("Username=@Username,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Nowtimes=@Nowtimes,");
            strSql.Append("zhongzhihu=@zhongzhihu ,");
            strSql.Append("zhuangtai=@zhuangtai ,");
            strSql.Append("beizhu=@beizhu ,");
            strSql.Append("SingleMoney=@SingleMoney, ");
            strSql.Append("Allmoney=@Allmoney ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Keyfile", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPoint", SqlDbType.Decimal,9),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
                    new SqlParameter("@zhongzhihu", SqlDbType.NVarChar,50),
                    new SqlParameter("@zhuangtai", SqlDbType.NVarChar,50),
                    new SqlParameter("@beizhu", SqlDbType.NVarChar,100),
                     new SqlParameter("@SingleMoney", SqlDbType.Decimal,9),
                      new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = Keyfile;
			parameters[1].Value = GoodsNumber;
			parameters[2].Value = GoodsName;
			parameters[3].Value = CountUnit;
			parameters[4].Value = Model;
			parameters[5].Value = StockPoint;
			parameters[6].Value = Username;
			parameters[7].Value = Realname;
			parameters[8].Value = Nowtimes;
            parameters[9].Value = Zhongzhihu;
            parameters[10].Value = Zhuangtai;
            parameters[11].Value = Beizhu;
            parameters[12].Value = Singlemoney;
            parameters[13].Value = Allmoney;
			parameters[14].Value = Id;

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
		public bool Delete(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from [IncomeRoomMx] ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

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
		public void GetModel(long Id)
		{
			StringBuilder strSql=new StringBuilder();
            strSql.Append("select Id,Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,Username,Realname,Nowtimes,zhongzhihu,zhuangtai,beizhu,SingleMoney,Allmoney");
			strSql.Append(" FROM [IncomeRoomMx] ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["Id"]!=null && ds.Tables[0].Rows[0]["Id"].ToString()!="")
				{
					this.Id=long.Parse(ds.Tables[0].Rows[0]["Id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Keyfile"]!=null )
				{
					this.Keyfile=ds.Tables[0].Rows[0]["Keyfile"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GoodsNumber"]!=null )
				{
					this.GoodsNumber=ds.Tables[0].Rows[0]["GoodsNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["GoodsName"]!=null )
				{
					this.GoodsName=ds.Tables[0].Rows[0]["GoodsName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CountUnit"]!=null )
				{
					this.CountUnit=ds.Tables[0].Rows[0]["CountUnit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Model"]!=null )
				{
					this.Model=ds.Tables[0].Rows[0]["Model"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPoint"]!=null && ds.Tables[0].Rows[0]["StockPoint"].ToString()!="")
				{
					this.StockPoint=decimal.Parse(ds.Tables[0].Rows[0]["StockPoint"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Username"]!=null )
				{
					this.Username=ds.Tables[0].Rows[0]["Username"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Realname"]!=null )
				{
					this.Realname=ds.Tables[0].Rows[0]["Realname"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Nowtimes"]!=null && ds.Tables[0].Rows[0]["Nowtimes"].ToString()!="")
				{
					this.Nowtimes=DateTime.Parse(ds.Tables[0].Rows[0]["Nowtimes"].ToString());
				}
                if (ds.Tables[0].Rows[0]["zhongzhihu"] != null)
                {
                    this.Zhongzhihu = ds.Tables[0].Rows[0]["zhongzhihu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zhuangtai"] != null)
                {
                    this.Zhuangtai = ds.Tables[0].Rows[0]["zhuangtai"].ToString();
                }
                if (ds.Tables[0].Rows[0]["beizhu"] != null)
                {
                    this.Beizhu = ds.Tables[0].Rows[0]["beizhu"].ToString();
                }
                if (ds.Tables[0].Rows[0]["SingleMoney"] != null)
                {
                    this.Singlemoney = decimal.Parse(ds.Tables[0].Rows[0]["SingleMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Allmoney"] != null)
                {
                    this.Allmoney = decimal.Parse(ds.Tables[0].Rows[0]["Allmoney"].ToString());
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
			strSql.Append(" FROM [IncomeRoomMx] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

