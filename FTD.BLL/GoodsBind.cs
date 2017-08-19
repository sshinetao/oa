using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类GoodsBind。
	/// </summary>
	[Serializable]
	public partial class GoodsBind
	{
		public GoodsBind()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _goodsnumber;
		private string _goodsname;
		private string _countunit;
		private string _model;
		private string _color;
		private string _storeroom;
		private decimal? _splitpoint;
		private string _username;
		private string _realname;
		private DateTime? _nowtimes;
		private string _remark;
		private DateTime? _mytimes;
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
		public string number
		{
			set{ _number=value;}
			get{return _number;}
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
		public string Color
		{
			set{ _color=value;}
			get{return _color;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Storeroom
		{
			set{ _storeroom=value;}
			get{return _storeroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SplitPoint
		{
			set{ _splitpoint=value;}
			get{return _splitpoint;}
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
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? MyTimes
		{
			set{ _mytimes=value;}
			get{return _mytimes;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public GoodsBind(long Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,number,GoodsNumber,GoodsName,CountUnit,Model,Color,Storeroom,SplitPoint,Username,Realname,Nowtimes,Remark,MyTimes ");
			strSql.Append(" FROM [GoodsBind] ");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Id", SqlDbType.BigInt)};
			parameters[0].Value = Id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["Id"].ToString() != "") { this.Id = int.Parse(ds.Tables[0].Rows[0]["Id"].ToString()); }
				if(ds.Tables[0].Rows[0]["number"]!=null)
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
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
				if(ds.Tables[0].Rows[0]["Color"]!=null)
				{
					this.Color=ds.Tables[0].Rows[0]["Color"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Storeroom"]!=null)
				{
					this.Storeroom=ds.Tables[0].Rows[0]["Storeroom"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SplitPoint"]!=null && ds.Tables[0].Rows[0]["SplitPoint"].ToString()!="")
				{
					this.SplitPoint=decimal.Parse(ds.Tables[0].Rows[0]["SplitPoint"].ToString());
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
				if(ds.Tables[0].Rows[0]["Remark"]!=null)
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MyTimes"]!=null && ds.Tables[0].Rows[0]["MyTimes"].ToString()!="")
				{
					this.MyTimes=DateTime.Parse(ds.Tables[0].Rows[0]["MyTimes"].ToString());
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [GoodsBind]");
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
			strSql.Append("insert into [GoodsBind] (");
			strSql.Append("number,GoodsNumber,GoodsName,CountUnit,Model,Color,Storeroom,SplitPoint,Username,Realname,Nowtimes,Remark,MyTimes)");
			strSql.Append(" values (");
			strSql.Append("@number,@GoodsNumber,@GoodsName,@CountUnit,@Model,@Color,@Storeroom,@SplitPoint,@Username,@Realname,@Nowtimes,@Remark,@MyTimes)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Color", SqlDbType.NVarChar,50),
					new SqlParameter("@Storeroom", SqlDbType.NVarChar,50),
					new SqlParameter("@SplitPoint", SqlDbType.Decimal,9),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@MyTimes", SqlDbType.DateTime)};
			parameters[0].Value = number;
			parameters[1].Value = GoodsNumber;
			parameters[2].Value = GoodsName;
			parameters[3].Value = CountUnit;
			parameters[4].Value = Model;
			parameters[5].Value = Color;
			parameters[6].Value = Storeroom;
			parameters[7].Value = SplitPoint;
			parameters[8].Value = Username;
			parameters[9].Value = Realname;
			parameters[10].Value = Nowtimes;
			parameters[11].Value = Remark;
			parameters[12].Value = MyTimes;

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
			strSql.Append("update [GoodsBind] set ");
			strSql.Append("number=@number,");
			strSql.Append("GoodsNumber=@GoodsNumber,");
			strSql.Append("GoodsName=@GoodsName,");
			strSql.Append("CountUnit=@CountUnit,");
			strSql.Append("Model=@Model,");
			strSql.Append("Color=@Color,");
			strSql.Append("Storeroom=@Storeroom,");
			strSql.Append("SplitPoint=@SplitPoint,");
			strSql.Append("Username=@Username,");
			strSql.Append("Realname=@Realname,");
			strSql.Append("Nowtimes=@Nowtimes,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("MyTimes=@MyTimes");
			strSql.Append(" where Id=@Id ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@GoodsName", SqlDbType.NVarChar,50),
					new SqlParameter("@CountUnit", SqlDbType.NVarChar,50),
					new SqlParameter("@Model", SqlDbType.NVarChar,50),
					new SqlParameter("@Color", SqlDbType.NVarChar,50),
					new SqlParameter("@Storeroom", SqlDbType.NVarChar,50),
					new SqlParameter("@SplitPoint", SqlDbType.Decimal,9),
					new SqlParameter("@Username", SqlDbType.NVarChar,50),
					new SqlParameter("@Realname", SqlDbType.NVarChar,50),
					new SqlParameter("@Nowtimes", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@MyTimes", SqlDbType.DateTime),
					new SqlParameter("@Id", SqlDbType.BigInt,8)};
			parameters[0].Value = number;
			parameters[1].Value = GoodsNumber;
			parameters[2].Value = GoodsName;
			parameters[3].Value = CountUnit;
			parameters[4].Value = Model;
			parameters[5].Value = Color;
			parameters[6].Value = Storeroom;
			parameters[7].Value = SplitPoint;
			parameters[8].Value = Username;
			parameters[9].Value = Realname;
			parameters[10].Value = Nowtimes;
			parameters[11].Value = Remark;
			parameters[12].Value = MyTimes;
			parameters[13].Value = Id;

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
			strSql.Append("delete from [GoodsBind] ");
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
			strSql.Append("select Id,number,GoodsNumber,GoodsName,CountUnit,Model,Color,Storeroom,SplitPoint,Username,Realname,Nowtimes,Remark,MyTimes ");
			strSql.Append(" FROM [GoodsBind] ");
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
				if(ds.Tables[0].Rows[0]["number"]!=null )
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
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
				if(ds.Tables[0].Rows[0]["Color"]!=null )
				{
					this.Color=ds.Tables[0].Rows[0]["Color"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Storeroom"]!=null )
				{
					this.Storeroom=ds.Tables[0].Rows[0]["Storeroom"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SplitPoint"]!=null && ds.Tables[0].Rows[0]["SplitPoint"].ToString()!="")
				{
					this.SplitPoint=decimal.Parse(ds.Tables[0].Rows[0]["SplitPoint"].ToString());
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
				if(ds.Tables[0].Rows[0]["Remark"]!=null )
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MyTimes"]!=null && ds.Tables[0].Rows[0]["MyTimes"].ToString()!="")
				{
					this.MyTimes=DateTime.Parse(ds.Tables[0].Rows[0]["MyTimes"].ToString());
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
			strSql.Append(" FROM [GoodsBind] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

