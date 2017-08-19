using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类StockPlanMx。
	/// </summary>
	[Serializable]
	public partial class StockPlanMx
	{
		public StockPlanMx()
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
		private decimal? _allmoney;
		private string _stocktype;
		private string _stockpeonum;
		private string _stockpeoname;
		private string _companynumber;
		private string _companyname;
		private string _companyadd;
		private DateTime? _jyordertime;
		private DateTime? _jytotime;
		private DateTime? _txtime;
		private string _username;
		private string _realname;
		private DateTime? _nowtimes;
		private string _ifopen;
		private string _type;
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
		public decimal? SingleMoney
		{
			set{ _singlemoney=value;}
			get{return _singlemoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Allmoney
		{
			set{ _allmoney=value;}
			get{return _allmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Stocktype
		{
			set{ _stocktype=value;}
			get{return _stocktype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StockPeoNum
		{
			set{ _stockpeonum=value;}
			get{return _stockpeonum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StockPeoName
		{
			set{ _stockpeoname=value;}
			get{return _stockpeoname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyNumber
		{
			set{ _companynumber=value;}
			get{return _companynumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyName
		{
			set{ _companyname=value;}
			get{return _companyname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyAdd
		{
			set{ _companyadd=value;}
			get{return _companyadd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? JyOrderTime
		{
			set{ _jyordertime=value;}
			get{return _jyordertime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? JyToTime
		{
			set{ _jytotime=value;}
			get{return _jytotime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? TxTime
		{
			set{ _txtime=value;}
			get{return _txtime;}
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
		/// <summary>
		/// 
		/// </summary>
		public string Ifopen
		{
			set{ _ifopen=value;}
			get{return _ifopen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public StockPlanMx(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,Stocktype,StockPeoNum,StockPeoName,CompanyNumber,CompanyName,CompanyAdd,JyOrderTime,JyToTime,TxTime,Username,Realname,Nowtimes,Ifopen,Type ");
			strSql.Append(" FROM [StockPlanMx] ");
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
				if(ds.Tables[0].Rows[0]["SingleMoney"]!=null && ds.Tables[0].Rows[0]["SingleMoney"].ToString()!="")
				{
					this.SingleMoney=decimal.Parse(ds.Tables[0].Rows[0]["SingleMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Allmoney"]!=null && ds.Tables[0].Rows[0]["Allmoney"].ToString()!="")
				{
					this.Allmoney=decimal.Parse(ds.Tables[0].Rows[0]["Allmoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Stocktype"]!=null)
				{
					this.Stocktype=ds.Tables[0].Rows[0]["Stocktype"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoNum"]!=null)
				{
					this.StockPeoNum=ds.Tables[0].Rows[0]["StockPeoNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoName"]!=null)
				{
					this.StockPeoName=ds.Tables[0].Rows[0]["StockPeoName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyNumber"]!=null)
				{
					this.CompanyNumber=ds.Tables[0].Rows[0]["CompanyNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyName"]!=null)
				{
					this.CompanyName=ds.Tables[0].Rows[0]["CompanyName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyAdd"]!=null)
				{
					this.CompanyAdd=ds.Tables[0].Rows[0]["CompanyAdd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["JyOrderTime"]!=null && ds.Tables[0].Rows[0]["JyOrderTime"].ToString()!="")
				{
					this.JyOrderTime=DateTime.Parse(ds.Tables[0].Rows[0]["JyOrderTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JyToTime"]!=null && ds.Tables[0].Rows[0]["JyToTime"].ToString()!="")
				{
					this.JyToTime=DateTime.Parse(ds.Tables[0].Rows[0]["JyToTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TxTime"]!=null && ds.Tables[0].Rows[0]["TxTime"].ToString()!="")
				{
					this.TxTime=DateTime.Parse(ds.Tables[0].Rows[0]["TxTime"].ToString());
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
				if(ds.Tables[0].Rows[0]["Ifopen"]!=null)
				{
					this.Ifopen=ds.Tables[0].Rows[0]["Ifopen"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [StockPlanMx]");
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
			strSql.Append("insert into [StockPlanMx] (");
			strSql.Append("Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,Stocktype,StockPeoNum,StockPeoName,CompanyNumber,CompanyName,CompanyAdd,JyOrderTime,JyToTime,TxTime,Username,Realname,Nowtimes,Ifopen,Type)");
			strSql.Append(" values (");
			strSql.Append("@Keyfile,@GoodsNumber,@GoodsName,@CountUnit,@Model,@StockPoint,@SingleMoney,@Allmoney,@Stocktype,@StockPeoNum,@StockPeoName,@CompanyNumber,@CompanyName,@CompanyAdd,@JyOrderTime,@JyToTime,@TxTime,@Username,@Realname,@Nowtimes,@Ifopen,@Type)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Keyfile", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPoint", SqlDbType.Decimal,9),
					new SqlParameter("@SingleMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@Stocktype", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NText),
					new SqlParameter("@JyOrderTime", SqlDbType.DateTime),
					new SqlParameter("@JyToTime", SqlDbType.DateTime),
					new SqlParameter("@TxTime", SqlDbType.DateTime),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50)};
			parameters[0].Value = Keyfile;
			parameters[1].Value = GoodsNumber;
			parameters[2].Value = GoodsName;
			parameters[3].Value = CountUnit;
			parameters[4].Value = Model;
			parameters[5].Value = StockPoint;
			parameters[6].Value = SingleMoney;
			parameters[7].Value = Allmoney;
			parameters[8].Value = Stocktype;
			parameters[9].Value = StockPeoNum;
			parameters[10].Value = StockPeoName;
			parameters[11].Value = CompanyNumber;
			parameters[12].Value = CompanyName;
			parameters[13].Value = CompanyAdd;
			parameters[14].Value = JyOrderTime;
			parameters[15].Value = JyToTime;
			parameters[16].Value = TxTime;
			parameters[17].Value = Username;
			parameters[18].Value = Realname;
			parameters[19].Value = Nowtimes;
			parameters[20].Value = Ifopen;
			parameters[21].Value = Type;

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
			strSql.Append("update [StockPlanMx] set ");
			strSql.Append("Keyfile=@Keyfile,");
			strSql.Append("GoodsNumber=@GoodsNumber,");
			strSql.Append("GoodsName=@GoodsName,");
			strSql.Append("CountUnit=@CountUnit,");
			strSql.Append("Model=@Model,");
			strSql.Append("StockPoint=@StockPoint,");
			strSql.Append("SingleMoney=@SingleMoney,");
			strSql.Append("Allmoney=@Allmoney,");
			strSql.Append("Stocktype=@Stocktype,");
			strSql.Append("StockPeoNum=@StockPeoNum,");
			strSql.Append("StockPeoName=@StockPeoName,");
			strSql.Append("CompanyNumber=@CompanyNumber,");
			strSql.Append("CompanyName=@CompanyName,");
			strSql.Append("CompanyAdd=@CompanyAdd,");
			strSql.Append("JyOrderTime=@JyOrderTime,");
			strSql.Append("JyToTime=@JyToTime,");
			strSql.Append("TxTime=@TxTime,");
			strSql.Append("Username=@Username,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Nowtimes=@Nowtimes,");
			strSql.Append("Ifopen=@Ifopen,");
			strSql.Append("Type=@Type");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Keyfile", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPoint", SqlDbType.Decimal,9),
					new SqlParameter("@SingleMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Allmoney", SqlDbType.Decimal,9),
					new SqlParameter("@Stocktype", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoNum", SqlDbType.NVarChar,50),
					new SqlParameter("@StockPeoName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyAdd", SqlDbType.NText),
					new SqlParameter("@JyOrderTime", SqlDbType.DateTime),
					new SqlParameter("@JyToTime", SqlDbType.DateTime),
					new SqlParameter("@TxTime", SqlDbType.DateTime),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@Ifopen", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = Keyfile;
			parameters[1].Value = GoodsNumber;
			parameters[2].Value = GoodsName;
			parameters[3].Value = CountUnit;
			parameters[4].Value = Model;
			parameters[5].Value = StockPoint;
			parameters[6].Value = SingleMoney;
			parameters[7].Value = Allmoney;
			parameters[8].Value = Stocktype;
			parameters[9].Value = StockPeoNum;
			parameters[10].Value = StockPeoName;
			parameters[11].Value = CompanyNumber;
			parameters[12].Value = CompanyName;
			parameters[13].Value = CompanyAdd;
			parameters[14].Value = JyOrderTime;
			parameters[15].Value = JyToTime;
			parameters[16].Value = TxTime;
			parameters[17].Value = Username;
			parameters[18].Value = Realname;
			parameters[19].Value = Nowtimes;
			parameters[20].Value = Ifopen;
			parameters[21].Value = Type;
			parameters[22].Value = Id;

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
			strSql.Append("delete from [StockPlanMx] ");
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
			strSql.Append("select Id,Keyfile,GoodsNumber,GoodsName,CountUnit,Model,StockPoint,SingleMoney,Allmoney,Stocktype,StockPeoNum,StockPeoName,CompanyNumber,CompanyName,CompanyAdd,JyOrderTime,JyToTime,TxTime,Username,Realname,Nowtimes,Ifopen,Type ");
			strSql.Append(" FROM [StockPlanMx] ");
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
				if(ds.Tables[0].Rows[0]["SingleMoney"]!=null && ds.Tables[0].Rows[0]["SingleMoney"].ToString()!="")
				{
					this.SingleMoney=decimal.Parse(ds.Tables[0].Rows[0]["SingleMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Allmoney"]!=null && ds.Tables[0].Rows[0]["Allmoney"].ToString()!="")
				{
					this.Allmoney=decimal.Parse(ds.Tables[0].Rows[0]["Allmoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Stocktype"]!=null )
				{
					this.Stocktype=ds.Tables[0].Rows[0]["Stocktype"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoNum"]!=null )
				{
					this.StockPeoNum=ds.Tables[0].Rows[0]["StockPeoNum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["StockPeoName"]!=null )
				{
					this.StockPeoName=ds.Tables[0].Rows[0]["StockPeoName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyNumber"]!=null )
				{
					this.CompanyNumber=ds.Tables[0].Rows[0]["CompanyNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyName"]!=null )
				{
					this.CompanyName=ds.Tables[0].Rows[0]["CompanyName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CompanyAdd"]!=null )
				{
					this.CompanyAdd=ds.Tables[0].Rows[0]["CompanyAdd"].ToString();
				}
				if(ds.Tables[0].Rows[0]["JyOrderTime"]!=null && ds.Tables[0].Rows[0]["JyOrderTime"].ToString()!="")
				{
					this.JyOrderTime=DateTime.Parse(ds.Tables[0].Rows[0]["JyOrderTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JyToTime"]!=null && ds.Tables[0].Rows[0]["JyToTime"].ToString()!="")
				{
					this.JyToTime=DateTime.Parse(ds.Tables[0].Rows[0]["JyToTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TxTime"]!=null && ds.Tables[0].Rows[0]["TxTime"].ToString()!="")
				{
					this.TxTime=DateTime.Parse(ds.Tables[0].Rows[0]["TxTime"].ToString());
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
				if(ds.Tables[0].Rows[0]["Ifopen"]!=null )
				{
					this.Ifopen=ds.Tables[0].Rows[0]["Ifopen"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
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
			strSql.Append(" FROM [StockPlanMx] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

