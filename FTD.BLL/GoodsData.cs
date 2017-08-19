using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类GoodsData。
	/// </summary>
	[Serializable]
	public partial class GoodsData
	{
		public GoodsData()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _goodsname;
		private string _countunit;
		private string _model;
		private string _type;
		private string _code;
		private string _color;
		private string _area;
		private string _cubage;
		private string _weight;
		private decimal? _amountup;
		private decimal? _amountdown;
		private decimal? _powermoney;
		private decimal? _stockmoney;
		private decimal? _sellmoney1;
		private decimal? _sellmoney2;
		private decimal? _sellmoney3;
		private decimal? _sellmoney4;
		private string _remark;
		private string _state;
		/// <summary>
		/// 
		/// </summary>
		public long id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Number
		{
			set{ _number=value;}
			get{return _number;}
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
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Color
		{
			set{ _color=value;}
			get{return _color;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Area
		{
			set{ _area=value;}
			get{return _area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Cubage
		{
			set{ _cubage=value;}
			get{return _cubage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Weight
		{
			set{ _weight=value;}
			get{return _weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Amountup
		{
			set{ _amountup=value;}
			get{return _amountup;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Amountdown
		{
			set{ _amountdown=value;}
			get{return _amountdown;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Powermoney
		{
			set{ _powermoney=value;}
			get{return _powermoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Stockmoney
		{
			set{ _stockmoney=value;}
			get{return _stockmoney;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Sellmoney1
		{
			set{ _sellmoney1=value;}
			get{return _sellmoney1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Sellmoney2
		{
			set{ _sellmoney2=value;}
			get{return _sellmoney2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Sellmoney3
		{
			set{ _sellmoney3=value;}
			get{return _sellmoney3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Sellmoney4
		{
			set{ _sellmoney4=value;}
			get{return _sellmoney4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GoodsData(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Number,GoodsName,CountUnit,Model,Type,Code,Color,Area,Cubage,Weight,Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark,State ");
			strSql.Append(" FROM [GoodsData] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["Number"]!=null)
				{
					this.Number=ds.Tables[0].Rows[0]["Number"].ToString();
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
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Code"]!=null)
				{
					this.Code=ds.Tables[0].Rows[0]["Code"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Color"]!=null)
				{
					this.Color=ds.Tables[0].Rows[0]["Color"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Area"]!=null)
				{
					this.Area=ds.Tables[0].Rows[0]["Area"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Cubage"]!=null)
				{
					this.Cubage=ds.Tables[0].Rows[0]["Cubage"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Weight"]!=null)
				{
					this.Weight=ds.Tables[0].Rows[0]["Weight"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Amountup"]!=null && ds.Tables[0].Rows[0]["Amountup"].ToString()!="")
				{
					this.Amountup=decimal.Parse(ds.Tables[0].Rows[0]["Amountup"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Amountdown"]!=null && ds.Tables[0].Rows[0]["Amountdown"].ToString()!="")
				{
					this.Amountdown=decimal.Parse(ds.Tables[0].Rows[0]["Amountdown"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Powermoney"]!=null && ds.Tables[0].Rows[0]["Powermoney"].ToString()!="")
				{
					this.Powermoney=decimal.Parse(ds.Tables[0].Rows[0]["Powermoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Stockmoney"]!=null && ds.Tables[0].Rows[0]["Stockmoney"].ToString()!="")
				{
					this.Stockmoney=decimal.Parse(ds.Tables[0].Rows[0]["Stockmoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sellmoney1"]!=null && ds.Tables[0].Rows[0]["Sellmoney1"].ToString()!="")
				{
					this.Sellmoney1=decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney1"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sellmoney2"]!=null && ds.Tables[0].Rows[0]["Sellmoney2"].ToString()!="")
				{
					this.Sellmoney2=decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney2"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sellmoney3"]!=null && ds.Tables[0].Rows[0]["Sellmoney3"].ToString()!="")
				{
					this.Sellmoney3=decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney3"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sellmoney4"]!=null && ds.Tables[0].Rows[0]["Sellmoney4"].ToString()!="")
				{
					this.Sellmoney4=decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney4"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null)
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["State"]!=null)
				{
					this.State=ds.Tables[0].Rows[0]["State"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [GoodsData]");
			strSql.Append(" where id=@id ");

			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into [GoodsData] (");
			strSql.Append("Number,GoodsName,CountUnit,Model,Type,Code,Color,Area,Cubage,Weight,Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark,State)");
			strSql.Append(" values (");
			strSql.Append("@Number,@GoodsName,@CountUnit,@Model,@Type,@Code,@Color,@Area,@Cubage,@Weight,@Amountup,@Amountdown,@Powermoney,@Stockmoney,@Sellmoney1,@Sellmoney2,@Sellmoney3,@Sellmoney4,@Remark,@State)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Number", SqlDbType.NVarChar,4000),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,4000),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,4000),
					new SqlParameter("@Model", SqlDbType.NVarChar,4000),
					new SqlParameter("@Type", SqlDbType.NVarChar,4000),
					new SqlParameter("@Code", SqlDbType.NVarChar,4000),
					new SqlParameter("@Color", SqlDbType.NVarChar,4000),
					new SqlParameter("@Area", SqlDbType.NVarChar,4000),
					new SqlParameter("@Cubage", SqlDbType.NVarChar,4000),
					new SqlParameter("@Weight", SqlDbType.NVarChar,4000),
					new SqlParameter("@Amountup", SqlDbType.Decimal,9),
					new SqlParameter("@Amountdown", SqlDbType.Decimal,9),
					new SqlParameter("@Powermoney", SqlDbType.Decimal,9),
					new SqlParameter("@Stockmoney", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney1", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney2", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney3", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney4", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@State", SqlDbType.NVarChar,50)};
			parameters[0].Value = Number;
			parameters[1].Value = GoodsName;
			parameters[2].Value = CountUnit;
			parameters[3].Value = Model;
			parameters[4].Value = Type;
			parameters[5].Value = Code;
			parameters[6].Value = Color;
			parameters[7].Value = Area;
			parameters[8].Value = Cubage;
			parameters[9].Value = Weight;
			parameters[10].Value = Amountup;
			parameters[11].Value = Amountdown;
			parameters[12].Value = Powermoney;
			parameters[13].Value = Stockmoney;
			parameters[14].Value = Sellmoney1;
			parameters[15].Value = Sellmoney2;
			parameters[16].Value = Sellmoney3;
			parameters[17].Value = Sellmoney4;
			parameters[18].Value = Remark;
			parameters[19].Value = State;

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
			strSql.Append("update [GoodsData] set ");
			strSql.Append("Number=@Number,");
			strSql.Append("GoodsName=@GoodsName,");
			strSql.Append("CountUnit=@CountUnit,");
			strSql.Append("Model=@Model,");
			strSql.Append("Type=@Type,");
			strSql.Append("Code=@Code,");
			strSql.Append("Color=@Color,");
			strSql.Append("Area=@Area,");
			strSql.Append("Cubage=@Cubage,");
			strSql.Append("Weight=@Weight,");
			strSql.Append("Amountup=@Amountup,");
			strSql.Append("Amountdown=@Amountdown,");
			strSql.Append("Powermoney=@Powermoney,");
			strSql.Append("Stockmoney=@Stockmoney,");
			strSql.Append("Sellmoney1=@Sellmoney1,");
			strSql.Append("Sellmoney2=@Sellmoney2,");
			strSql.Append("Sellmoney3=@Sellmoney3,");
			strSql.Append("Sellmoney4=@Sellmoney4,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("State=@State");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Number", SqlDbType.NVarChar,4000),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,4000),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,4000),
					new SqlParameter("@Model", SqlDbType.NVarChar,4000),
					new SqlParameter("@Type", SqlDbType.NVarChar,4000),
					new SqlParameter("@Code", SqlDbType.NVarChar,4000),
					new SqlParameter("@Color", SqlDbType.NVarChar,4000),
					new SqlParameter("@Area", SqlDbType.NVarChar,4000),
					new SqlParameter("@Cubage", SqlDbType.NVarChar,4000),
					new SqlParameter("@Weight", SqlDbType.NVarChar,4000),
					new SqlParameter("@Amountup", SqlDbType.Decimal,9),
					new SqlParameter("@Amountdown", SqlDbType.Decimal,9),
					new SqlParameter("@Powermoney", SqlDbType.Decimal,9),
					new SqlParameter("@Stockmoney", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney1", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney2", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney3", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney4", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = Number;
			parameters[1].Value = GoodsName;
			parameters[2].Value = CountUnit;
			parameters[3].Value = Model;
			parameters[4].Value = Type;
			parameters[5].Value = Code;
			parameters[6].Value = Color;
			parameters[7].Value = Area;
			parameters[8].Value = Cubage;
			parameters[9].Value = Weight;
			parameters[10].Value = Amountup;
			parameters[11].Value = Amountdown;
			parameters[12].Value = Powermoney;
			parameters[13].Value = Stockmoney;
			parameters[14].Value = Sellmoney1;
			parameters[15].Value = Sellmoney2;
			parameters[16].Value = Sellmoney3;
			parameters[17].Value = Sellmoney4;
			parameters[18].Value = Remark;
			parameters[19].Value = State;
			parameters[20].Value = id;

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
			strSql.Append("delete from [GoodsData] ");
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
			strSql.Append("select id,Number,GoodsName,CountUnit,Model,Type,Code,Color,Area,Cubage,Weight,Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark,State ");
			strSql.Append(" FROM [GoodsData] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["id"]!=null && ds.Tables[0].Rows[0]["id"].ToString()!="")
				{
					this.id=long.Parse(ds.Tables[0].Rows[0]["id"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Number"]!=null )
				{
					this.Number=ds.Tables[0].Rows[0]["Number"].ToString();
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
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Code"]!=null )
				{
					this.Code=ds.Tables[0].Rows[0]["Code"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Color"]!=null )
				{
					this.Color=ds.Tables[0].Rows[0]["Color"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Area"]!=null )
				{
					this.Area=ds.Tables[0].Rows[0]["Area"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Cubage"]!=null )
				{
					this.Cubage=ds.Tables[0].Rows[0]["Cubage"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Weight"]!=null )
				{
					this.Weight=ds.Tables[0].Rows[0]["Weight"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Amountup"]!=null && ds.Tables[0].Rows[0]["Amountup"].ToString()!="")
				{
					this.Amountup=decimal.Parse(ds.Tables[0].Rows[0]["Amountup"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Amountdown"]!=null && ds.Tables[0].Rows[0]["Amountdown"].ToString()!="")
				{
					this.Amountdown=decimal.Parse(ds.Tables[0].Rows[0]["Amountdown"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Powermoney"]!=null && ds.Tables[0].Rows[0]["Powermoney"].ToString()!="")
				{
					this.Powermoney=decimal.Parse(ds.Tables[0].Rows[0]["Powermoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Stockmoney"]!=null && ds.Tables[0].Rows[0]["Stockmoney"].ToString()!="")
				{
					this.Stockmoney=decimal.Parse(ds.Tables[0].Rows[0]["Stockmoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sellmoney1"]!=null && ds.Tables[0].Rows[0]["Sellmoney1"].ToString()!="")
				{
					this.Sellmoney1=decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney1"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sellmoney2"]!=null && ds.Tables[0].Rows[0]["Sellmoney2"].ToString()!="")
				{
					this.Sellmoney2=decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney2"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sellmoney3"]!=null && ds.Tables[0].Rows[0]["Sellmoney3"].ToString()!="")
				{
					this.Sellmoney3=decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney3"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sellmoney4"]!=null && ds.Tables[0].Rows[0]["Sellmoney4"].ToString()!="")
				{
					this.Sellmoney4=decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney4"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null )
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["State"]!=null )
				{
					this.State=ds.Tables[0].Rows[0]["State"].ToString();
				}
			}
		}
        public void GetModel(string _GoodsName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,Number,GoodsName,CountUnit,Model,Type,Code,Color,Area,Cubage,Weight,Amountup,Amountdown,Powermoney,Stockmoney,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Remark,State ");
            strSql.Append(" FROM [GoodsData] ");
            strSql.Append(" where GoodsName=@GoodsName ");
            SqlParameter[] parameters = {
					new SqlParameter("@GoodsName", SqlDbType.NVarChar)};
            parameters[0].Value = _GoodsName;

            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"] != null && ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    this.id = long.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Number"] != null)
                {
                    this.Number = ds.Tables[0].Rows[0]["Number"].ToString();
                }
                if (ds.Tables[0].Rows[0]["GoodsName"] != null)
                {
                    this.GoodsName = ds.Tables[0].Rows[0]["GoodsName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CountUnit"] != null)
                {
                    this.CountUnit = ds.Tables[0].Rows[0]["CountUnit"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Model"] != null)
                {
                    this.Model = ds.Tables[0].Rows[0]["Model"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Type"] != null)
                {
                    this.Type = ds.Tables[0].Rows[0]["Type"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Code"] != null)
                {
                    this.Code = ds.Tables[0].Rows[0]["Code"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Color"] != null)
                {
                    this.Color = ds.Tables[0].Rows[0]["Color"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Area"] != null)
                {
                    this.Area = ds.Tables[0].Rows[0]["Area"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Cubage"] != null)
                {
                    this.Cubage = ds.Tables[0].Rows[0]["Cubage"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Weight"] != null)
                {
                    this.Weight = ds.Tables[0].Rows[0]["Weight"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Amountup"] != null && ds.Tables[0].Rows[0]["Amountup"].ToString() != "")
                {
                    this.Amountup = decimal.Parse(ds.Tables[0].Rows[0]["Amountup"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amountdown"] != null && ds.Tables[0].Rows[0]["Amountdown"].ToString() != "")
                {
                    this.Amountdown = decimal.Parse(ds.Tables[0].Rows[0]["Amountdown"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Powermoney"] != null && ds.Tables[0].Rows[0]["Powermoney"].ToString() != "")
                {
                    this.Powermoney = decimal.Parse(ds.Tables[0].Rows[0]["Powermoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Stockmoney"] != null && ds.Tables[0].Rows[0]["Stockmoney"].ToString() != "")
                {
                    this.Stockmoney = decimal.Parse(ds.Tables[0].Rows[0]["Stockmoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Sellmoney1"] != null && ds.Tables[0].Rows[0]["Sellmoney1"].ToString() != "")
                {
                    this.Sellmoney1 = decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Sellmoney2"] != null && ds.Tables[0].Rows[0]["Sellmoney2"].ToString() != "")
                {
                    this.Sellmoney2 = decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Sellmoney3"] != null && ds.Tables[0].Rows[0]["Sellmoney3"].ToString() != "")
                {
                    this.Sellmoney3 = decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Sellmoney4"] != null && ds.Tables[0].Rows[0]["Sellmoney4"].ToString() != "")
                {
                    this.Sellmoney4 = decimal.Parse(ds.Tables[0].Rows[0]["Sellmoney4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Remark"] != null)
                {
                    this.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                }
                if (ds.Tables[0].Rows[0]["State"] != null)
                {
                    this.State = ds.Tables[0].Rows[0]["State"].ToString();
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
			strSql.Append(" FROM [GoodsData] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            strSql.Append(@"  order by id desc");
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method

        public DataTable GetGoodsDataPage(string strWhere, int PageIndex, int PageSize, out int RecordCount, out int PageCount)
        {
            //id,CompanyName,Phone,Address,CompanyInfo,addTime,Contactor,isSure
            string DBName = "GoodsData";
            string selFields = "*";
            string OrderBy = " id desc ";
            string indexfields = "id";
            return DbHelperSQL.GetPage(DBName, selFields, OrderBy, indexfields, strWhere, PageIndex, PageSize, out  RecordCount, out  PageCount);
        }

	}
}

