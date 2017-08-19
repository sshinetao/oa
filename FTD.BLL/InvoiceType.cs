using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类InvoiceType。
	/// </summary>
	[Serializable]
	public partial class InvoiceType
	{
		public InvoiceType()
		{}
		#region Model
		private long _id;
		private string _name;
		private string _cess;
		private string _length;
		private string _printspec;
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
		public string Cess
		{
			set{ _cess=value;}
			get{return _cess;}
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
		public string PrintSpec
		{
			set{ _printspec=value;}
			get{return _printspec;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public InvoiceType(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Name,Cess,Length,PrintSpec ");
			strSql.Append(" FROM [InvoiceType] ");
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
				if(ds.Tables[0].Rows[0]["Cess"]!=null)
				{
					this.Cess=ds.Tables[0].Rows[0]["Cess"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Length"]!=null)
				{
					this.Length=ds.Tables[0].Rows[0]["Length"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PrintSpec"]!=null)
				{
					this.PrintSpec=ds.Tables[0].Rows[0]["PrintSpec"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [InvoiceType]");
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
			strSql.Append("insert into [InvoiceType] (");
			strSql.Append("Name,Cess,Length,PrintSpec)");
			strSql.Append(" values (");
			strSql.Append("@Name,@Cess,@Length,@PrintSpec)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Cess", SqlDbType.NVarChar,50),
					new SqlParameter("@Length", SqlDbType.NVarChar,50),
					new SqlParameter("@PrintSpec", SqlDbType.NVarChar,50)};
			parameters[0].Value = Name;
			parameters[1].Value = Cess;
			parameters[2].Value = Length;
			parameters[3].Value = PrintSpec;

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
			strSql.Append("update [InvoiceType] set ");
			strSql.Append("Name=@Name,");
			strSql.Append("Cess=@Cess,");
			strSql.Append("Length=@Length,");
			strSql.Append("PrintSpec=@PrintSpec");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Cess", SqlDbType.NVarChar,50),
					new SqlParameter("@Length", SqlDbType.NVarChar,50),
					new SqlParameter("@PrintSpec", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = Name;
			parameters[1].Value = Cess;
			parameters[2].Value = Length;
			parameters[3].Value = PrintSpec;
			parameters[4].Value = id;

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
			strSql.Append("delete from [InvoiceType] ");
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
			strSql.Append("select id,Name,Cess,Length,PrintSpec ");
			strSql.Append(" FROM [InvoiceType] ");
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
				if(ds.Tables[0].Rows[0]["Cess"]!=null )
				{
					this.Cess=ds.Tables[0].Rows[0]["Cess"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Length"]!=null )
				{
					this.Length=ds.Tables[0].Rows[0]["Length"].ToString();
				}
				if(ds.Tables[0].Rows[0]["PrintSpec"]!=null )
				{
					this.PrintSpec=ds.Tables[0].Rows[0]["PrintSpec"].ToString();
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
			strSql.Append(" FROM [InvoiceType] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

