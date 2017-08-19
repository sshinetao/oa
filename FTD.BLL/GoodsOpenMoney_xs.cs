using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类GoodsOpenMoney_xs。
	/// </summary>
	[Serializable]
	public partial class GoodsOpenMoney_xs
	{
		public GoodsOpenMoney_xs()
		{}
		#region Model
		private long _id;
		private string _goodsnumber;
		private string _goodsname;
		private string _countunit;
		private string _model;
		private string _type;
		private string _khname;
		private string _khnumber;
		private decimal? _sellmoney1;
		private decimal? _sellmoney2;
		private decimal? _sellmoney3;
		private decimal? _sellmoney4;
		private decimal? _zhekou;
		private decimal? _powermoney;
		private string _state;
		private string _remark;
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
		public string Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KhName
		{
			set{ _khname=value;}
			get{return _khname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KhNumber
		{
			set{ _khnumber=value;}
			get{return _khnumber;}
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
		public decimal? Zhekou
		{
			set{ _zhekou=value;}
			get{return _zhekou;}
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
		public string State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GoodsOpenMoney_xs(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,GoodsNumber,GoodsName,CountUnit,Model,Type,KhName,KhNumber,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Zhekou,Powermoney,State,Remark ");
			strSql.Append(" FROM [GoodsOpenMoney_xs] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
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
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["KhName"]!=null)
				{
					this.KhName=ds.Tables[0].Rows[0]["KhName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["KhNumber"]!=null)
				{
					this.KhNumber=ds.Tables[0].Rows[0]["KhNumber"].ToString();
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
				if(ds.Tables[0].Rows[0]["Zhekou"]!=null && ds.Tables[0].Rows[0]["Zhekou"].ToString()!="")
				{
					this.Zhekou=decimal.Parse(ds.Tables[0].Rows[0]["Zhekou"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Powermoney"]!=null && ds.Tables[0].Rows[0]["Powermoney"].ToString()!="")
				{
					this.Powermoney=decimal.Parse(ds.Tables[0].Rows[0]["Powermoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null)
				{
					this.State=ds.Tables[0].Rows[0]["State"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null)
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [GoodsOpenMoney_xs]");
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
			strSql.Append("insert into [GoodsOpenMoney_xs] (");
			strSql.Append("GoodsNumber,GoodsName,CountUnit,Model,Type,KhName,KhNumber,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Zhekou,Powermoney,State,Remark)");
			strSql.Append(" values (");
			strSql.Append("@GoodsNumber,@GoodsName,@CountUnit,@Model,@Type,@KhName,@KhNumber,@Sellmoney1,@Sellmoney2,@Sellmoney3,@Sellmoney4,@Zhekou,@Powermoney,@State,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@KhName", SqlDbType.NVarChar,50),
					new SqlParameter("@KhNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Sellmoney1", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney2", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney3", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney4", SqlDbType.Decimal,9),
					new SqlParameter("@Zhekou", SqlDbType.Decimal,9),
					new SqlParameter("@Powermoney", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NText)};
			parameters[0].Value = GoodsNumber;
			parameters[1].Value = GoodsName;
			parameters[2].Value = CountUnit;
			parameters[3].Value = Model;
			parameters[4].Value = Type;
			parameters[5].Value = KhName;
			parameters[6].Value = KhNumber;
			parameters[7].Value = Sellmoney1;
			parameters[8].Value = Sellmoney2;
			parameters[9].Value = Sellmoney3;
			parameters[10].Value = Sellmoney4;
			parameters[11].Value = Zhekou;
			parameters[12].Value = Powermoney;
			parameters[13].Value = State;
			parameters[14].Value = Remark;

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
			strSql.Append("update [GoodsOpenMoney_xs] set ");
			strSql.Append("GoodsNumber=@GoodsNumber,");
			strSql.Append("GoodsName=@GoodsName,");
			strSql.Append("CountUnit=@CountUnit,");
			strSql.Append("Model=@Model,");
			strSql.Append("Type=@Type,");
			strSql.Append("KhName=@KhName,");
			strSql.Append("KhNumber=@KhNumber,");
			strSql.Append("Sellmoney1=@Sellmoney1,");
			strSql.Append("Sellmoney2=@Sellmoney2,");
			strSql.Append("Sellmoney3=@Sellmoney3,");
			strSql.Append("Sellmoney4=@Sellmoney4,");
			strSql.Append("Zhekou=@Zhekou,");
			strSql.Append("Powermoney=@Powermoney,");
			strSql.Append("State=@State,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@KhName", SqlDbType.NVarChar,50),
					new SqlParameter("@KhNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Sellmoney1", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney2", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney3", SqlDbType.Decimal,9),
					new SqlParameter("@Sellmoney4", SqlDbType.Decimal,9),
					new SqlParameter("@Zhekou", SqlDbType.Decimal,9),
					new SqlParameter("@Powermoney", SqlDbType.Decimal,9),
					new SqlParameter("@State", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = GoodsNumber;
			parameters[1].Value = GoodsName;
			parameters[2].Value = CountUnit;
			parameters[3].Value = Model;
			parameters[4].Value = Type;
			parameters[5].Value = KhName;
			parameters[6].Value = KhNumber;
			parameters[7].Value = Sellmoney1;
			parameters[8].Value = Sellmoney2;
			parameters[9].Value = Sellmoney3;
			parameters[10].Value = Sellmoney4;
			parameters[11].Value = Zhekou;
			parameters[12].Value = Powermoney;
			parameters[13].Value = State;
			parameters[14].Value = Remark;
			parameters[15].Value = id;

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
			strSql.Append("delete from [GoodsOpenMoney_xs] ");
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
			strSql.Append("select id,GoodsNumber,GoodsName,CountUnit,Model,Type,KhName,KhNumber,Sellmoney1,Sellmoney2,Sellmoney3,Sellmoney4,Zhekou,Powermoney,State,Remark ");
			strSql.Append(" FROM [GoodsOpenMoney_xs] ");
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
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["KhName"]!=null )
				{
					this.KhName=ds.Tables[0].Rows[0]["KhName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["KhNumber"]!=null )
				{
					this.KhNumber=ds.Tables[0].Rows[0]["KhNumber"].ToString();
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
				if(ds.Tables[0].Rows[0]["Zhekou"]!=null && ds.Tables[0].Rows[0]["Zhekou"].ToString()!="")
				{
					this.Zhekou=decimal.Parse(ds.Tables[0].Rows[0]["Zhekou"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Powermoney"]!=null && ds.Tables[0].Rows[0]["Powermoney"].ToString()!="")
				{
					this.Powermoney=decimal.Parse(ds.Tables[0].Rows[0]["Powermoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["State"]!=null )
				{
					this.State=ds.Tables[0].Rows[0]["State"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null )
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
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
			strSql.Append(" FROM [GoodsOpenMoney_xs] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

