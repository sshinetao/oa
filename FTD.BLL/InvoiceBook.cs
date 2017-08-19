using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类InvoiceBook。
	/// </summary>
	[Serializable]
	public partial class InvoiceBook
	{
		public InvoiceBook()
		{}
		#region Model
		private long _id;
		private string _name;
		private string _length;
		private long? _startnum;
		private long? _endnum;
		private long? _setnum;
		private long? _losepoint;
		private long? _redpoint;
		private string _ifover;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Length
		{
			set{ _length=value;}
			get{return _length;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? Startnum
		{
			set{ _startnum=value;}
			get{return _startnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? Endnum
		{
			set{ _endnum=value;}
			get{return _endnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? Setnum
		{
			set{ _setnum=value;}
			get{return _setnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? LosePoint
		{
			set{ _losepoint=value;}
			get{return _losepoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long? RedPoint
		{
			set{ _redpoint=value;}
			get{return _redpoint;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IfOver
		{
			set{ _ifover=value;}
			get{return _ifover;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public InvoiceBook(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Name,Length,Startnum,Endnum,Setnum,LosePoint,RedPoint,IfOver ");
			strSql.Append(" FROM [InvoiceBook] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["Name"]!=null)
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Length"]!=null)
				{
					this.Length=ds.Tables[0].Rows[0]["Length"].ToString();
				}

                if (ds.Tables[0].Rows[0]["Startnum"].ToString() != "") { this.Startnum = int.Parse(ds.Tables[0].Rows[0]["Startnum"].ToString()); }
                if (ds.Tables[0].Rows[0]["Endnum"].ToString() != "") { this.Endnum = int.Parse(ds.Tables[0].Rows[0]["Endnum"].ToString()); }
                if (ds.Tables[0].Rows[0]["Setnum"].ToString() != "") { this.Setnum = int.Parse(ds.Tables[0].Rows[0]["Setnum"].ToString()); }
                if (ds.Tables[0].Rows[0]["LosePoint"].ToString() != "") { this.LosePoint = int.Parse(ds.Tables[0].Rows[0]["LosePoint"].ToString()); }
                if (ds.Tables[0].Rows[0]["RedPoint"].ToString() != "") { this.RedPoint = int.Parse(ds.Tables[0].Rows[0]["RedPoint"].ToString()); }
					
				if(ds.Tables[0].Rows[0]["IfOver"]!=null)
				{
					this.IfOver=ds.Tables[0].Rows[0]["IfOver"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [InvoiceBook]");
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
			strSql.Append("insert into [InvoiceBook] (");
			strSql.Append("Name,Length,Startnum,Endnum,Setnum,LosePoint,RedPoint,IfOver)");
			strSql.Append(" values (");
			strSql.Append("@Name,@Length,@Startnum,@Endnum,@Setnum,@LosePoint,@RedPoint,@IfOver)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Length", SqlDbType.NVarChar,50),
					new SqlParameter("@Startnum", SqlDbType.BigInt,8),
					new SqlParameter("@Endnum", SqlDbType.BigInt,8),
					new SqlParameter("@Setnum", SqlDbType.BigInt,8),
					new SqlParameter("@LosePoint", SqlDbType.BigInt,8),
					new SqlParameter("@RedPoint", SqlDbType.BigInt,8),
					new SqlParameter("@IfOver", SqlDbType.NVarChar,50)};
			parameters[0].Value = Name;
			parameters[1].Value = Length;
			parameters[2].Value = Startnum;
			parameters[3].Value = Endnum;
			parameters[4].Value = Setnum;
			parameters[5].Value = LosePoint;
			parameters[6].Value = RedPoint;
			parameters[7].Value = IfOver;

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
			strSql.Append("update [InvoiceBook] set ");
			strSql.Append("Name=@Name,");
			strSql.Append("Length=@Length,");
			strSql.Append("Startnum=@Startnum,");
			strSql.Append("Endnum=@Endnum,");
			strSql.Append("Setnum=@Setnum,");
			strSql.Append("LosePoint=@LosePoint,");
			strSql.Append("RedPoint=@RedPoint,");
			strSql.Append("IfOver=@IfOver");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Length", SqlDbType.NVarChar,50),
					new SqlParameter("@Startnum", SqlDbType.BigInt,8),
					new SqlParameter("@Endnum", SqlDbType.BigInt,8),
					new SqlParameter("@Setnum", SqlDbType.BigInt,8),
					new SqlParameter("@LosePoint", SqlDbType.BigInt,8),
					new SqlParameter("@RedPoint", SqlDbType.BigInt,8),
					new SqlParameter("@IfOver", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = Name;
			parameters[1].Value = Length;
			parameters[2].Value = Startnum;
			parameters[3].Value = Endnum;
			parameters[4].Value = Setnum;
			parameters[5].Value = LosePoint;
			parameters[6].Value = RedPoint;
			parameters[7].Value = IfOver;
			parameters[8].Value = id;

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
			strSql.Append("delete from [InvoiceBook] ");
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
			strSql.Append("select id,Name,Length,Startnum,Endnum,Setnum,LosePoint,RedPoint,IfOver ");
			strSql.Append(" FROM [InvoiceBook] ");
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
				if(ds.Tables[0].Rows[0]["Name"]!=null )
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Length"]!=null )
				{
					this.Length=ds.Tables[0].Rows[0]["Length"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Startnum"]!=null && ds.Tables[0].Rows[0]["Startnum"].ToString()!="")
				{
					this.Startnum=long.Parse(ds.Tables[0].Rows[0]["Startnum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Endnum"]!=null && ds.Tables[0].Rows[0]["Endnum"].ToString()!="")
				{
					this.Endnum=long.Parse(ds.Tables[0].Rows[0]["Endnum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Setnum"]!=null && ds.Tables[0].Rows[0]["Setnum"].ToString()!="")
				{
					this.Setnum=long.Parse(ds.Tables[0].Rows[0]["Setnum"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LosePoint"]!=null && ds.Tables[0].Rows[0]["LosePoint"].ToString()!="")
				{
					this.LosePoint=long.Parse(ds.Tables[0].Rows[0]["LosePoint"].ToString());
				}
				if(ds.Tables[0].Rows[0]["RedPoint"]!=null && ds.Tables[0].Rows[0]["RedPoint"].ToString()!="")
				{
					this.RedPoint=long.Parse(ds.Tables[0].Rows[0]["RedPoint"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IfOver"]!=null )
				{
					this.IfOver=ds.Tables[0].Rows[0]["IfOver"].ToString();
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
			strSql.Append(" FROM [InvoiceBook] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

