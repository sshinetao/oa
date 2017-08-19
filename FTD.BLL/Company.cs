using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类Company。
	/// </summary>
	[Serializable]
	public partial class Company
	{
		public Company()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _name;
		private string _type;
		private string _linkman;
		private string _movetel;
		private string _bank;
		private string _banknumber;
		private string _taxnumber;
		private string _deputy;
		private string _tel;
		private string _fax;
		private decimal? _receivable;
		private decimal? _payable;
		private string _address;
		private string _mail;
		private string _email;
		private string _qq;
		private string _other;
		private string _remark;
		private string _alltype;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
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
		public string Linkman
		{
			set{ _linkman=value;}
			get{return _linkman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MoveTel
		{
			set{ _movetel=value;}
			get{return _movetel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Bank
		{
			set{ _bank=value;}
			get{return _bank;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BankNumber
		{
			set{ _banknumber=value;}
			get{return _banknumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TaxNumber
		{
			set{ _taxnumber=value;}
			get{return _taxnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Deputy
		{
			set{ _deputy=value;}
			get{return _deputy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Fax
		{
			set{ _fax=value;}
			get{return _fax;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Receivable
		{
			set{ _receivable=value;}
			get{return _receivable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Payable
		{
			set{ _payable=value;}
			get{return _payable;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mail
		{
			set{ _mail=value;}
			get{return _mail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QQ
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Other
		{
			set{ _other=value;}
			get{return _other;}
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
		public string AllType
		{
			set{ _alltype=value;}
			get{return _alltype;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Company(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,Number,Name,Type,Linkman,MoveTel,Bank,BankNumber,TaxNumber,Deputy,Tel,Fax,Receivable,Payable,Address,Mail,Email,QQ,Other,Remark,AllType ");
			strSql.Append(" FROM [Company] ");
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
				if(ds.Tables[0].Rows[0]["Name"]!=null)
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null)
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Linkman"]!=null)
				{
					this.Linkman=ds.Tables[0].Rows[0]["Linkman"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MoveTel"]!=null)
				{
					this.MoveTel=ds.Tables[0].Rows[0]["MoveTel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Bank"]!=null)
				{
					this.Bank=ds.Tables[0].Rows[0]["Bank"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BankNumber"]!=null)
				{
					this.BankNumber=ds.Tables[0].Rows[0]["BankNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TaxNumber"]!=null)
				{
					this.TaxNumber=ds.Tables[0].Rows[0]["TaxNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Deputy"]!=null)
				{
					this.Deputy=ds.Tables[0].Rows[0]["Deputy"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null)
				{
					this.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Fax"]!=null)
				{
					this.Fax=ds.Tables[0].Rows[0]["Fax"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Receivable"]!=null && ds.Tables[0].Rows[0]["Receivable"].ToString()!="")
				{
					this.Receivable=decimal.Parse(ds.Tables[0].Rows[0]["Receivable"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Payable"]!=null && ds.Tables[0].Rows[0]["Payable"].ToString()!="")
				{
					this.Payable=decimal.Parse(ds.Tables[0].Rows[0]["Payable"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Address"]!=null)
				{
					this.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Mail"]!=null)
				{
					this.Mail=ds.Tables[0].Rows[0]["Mail"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Email"]!=null)
				{
					this.Email=ds.Tables[0].Rows[0]["Email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QQ"]!=null)
				{
					this.QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Other"]!=null)
				{
					this.Other=ds.Tables[0].Rows[0]["Other"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null)
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["AllType"]!=null)
				{
					this.AllType=ds.Tables[0].Rows[0]["AllType"].ToString();
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Company]");
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
			strSql.Append("insert into [Company] (");
			strSql.Append("Number,Name,Type,Linkman,MoveTel,Bank,BankNumber,TaxNumber,Deputy,Tel,Fax,Receivable,Payable,Address,Mail,Email,QQ,Other,Remark,AllType)");
			strSql.Append(" values (");
			strSql.Append("@Number,@Name,@Type,@Linkman,@MoveTel,@Bank,@BankNumber,@TaxNumber,@Deputy,@Tel,@Fax,@Receivable,@Payable,@Address,@Mail,@Email,@QQ,@Other,@Remark,@AllType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Number", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Linkman", SqlDbType.NVarChar,50),
					new SqlParameter("@MoveTel", SqlDbType.NVarChar,50),
					new SqlParameter("@Bank", SqlDbType.NVarChar,50),
					new SqlParameter("@BankNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@TaxNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Deputy", SqlDbType.NVarChar,50),
					new SqlParameter("@Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@Receivable", SqlDbType.Decimal,9),
					new SqlParameter("@Payable", SqlDbType.Decimal,9),
					new SqlParameter("@Address", SqlDbType.NText),
					new SqlParameter("@Mail", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@Other", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@AllType", SqlDbType.NVarChar,50)};
			parameters[0].Value = Number;
			parameters[1].Value = Name;
			parameters[2].Value = Type;
			parameters[3].Value = Linkman;
			parameters[4].Value = MoveTel;
			parameters[5].Value = Bank;
			parameters[6].Value = BankNumber;
			parameters[7].Value = TaxNumber;
			parameters[8].Value = Deputy;
			parameters[9].Value = Tel;
			parameters[10].Value = Fax;
			parameters[11].Value = Receivable;
			parameters[12].Value = Payable;
			parameters[13].Value = Address;
			parameters[14].Value = Mail;
			parameters[15].Value = Email;
			parameters[16].Value = QQ;
			parameters[17].Value = Other;
			parameters[18].Value = Remark;
			parameters[19].Value = AllType;

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
			strSql.Append("update [Company] set ");
			strSql.Append("Number=@Number,");
			strSql.Append("Name=@Name,");
			strSql.Append("Type=@Type,");
			strSql.Append("Linkman=@Linkman,");
			strSql.Append("MoveTel=@MoveTel,");
			strSql.Append("Bank=@Bank,");
			strSql.Append("BankNumber=@BankNumber,");
			strSql.Append("TaxNumber=@TaxNumber,");
			strSql.Append("Deputy=@Deputy,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Fax=@Fax,");
			strSql.Append("Receivable=@Receivable,");
			strSql.Append("Payable=@Payable,");
			strSql.Append("Address=@Address,");
			strSql.Append("Mail=@Mail,");
			strSql.Append("Email=@Email,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("Other=@Other,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("AllType=@AllType");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@Number", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Linkman", SqlDbType.NVarChar,50),
					new SqlParameter("@MoveTel", SqlDbType.NVarChar,50),
					new SqlParameter("@Bank", SqlDbType.NVarChar,50),
					new SqlParameter("@BankNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@TaxNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Deputy", SqlDbType.NVarChar,50),
					new SqlParameter("@Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@Receivable", SqlDbType.Decimal,9),
					new SqlParameter("@Payable", SqlDbType.Decimal,9),
					new SqlParameter("@Address", SqlDbType.NText),
					new SqlParameter("@Mail", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@Other", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@AllType", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = Number;
			parameters[1].Value = Name;
			parameters[2].Value = Type;
			parameters[3].Value = Linkman;
			parameters[4].Value = MoveTel;
			parameters[5].Value = Bank;
			parameters[6].Value = BankNumber;
			parameters[7].Value = TaxNumber;
			parameters[8].Value = Deputy;
			parameters[9].Value = Tel;
			parameters[10].Value = Fax;
			parameters[11].Value = Receivable;
			parameters[12].Value = Payable;
			parameters[13].Value = Address;
			parameters[14].Value = Mail;
			parameters[15].Value = Email;
			parameters[16].Value = QQ;
			parameters[17].Value = Other;
			parameters[18].Value = Remark;
			parameters[19].Value = AllType;
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
			strSql.Append("delete from [Company] ");
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
			strSql.Append("select id,Number,Name,Type,Linkman,MoveTel,Bank,BankNumber,TaxNumber,Deputy,Tel,Fax,Receivable,Payable,Address,Mail,Email,QQ,Other,Remark,AllType ");
			strSql.Append(" FROM [Company] ");
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
				if(ds.Tables[0].Rows[0]["Name"]!=null )
				{
					this.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Type"]!=null )
				{
					this.Type=ds.Tables[0].Rows[0]["Type"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Linkman"]!=null )
				{
					this.Linkman=ds.Tables[0].Rows[0]["Linkman"].ToString();
				}
				if(ds.Tables[0].Rows[0]["MoveTel"]!=null )
				{
					this.MoveTel=ds.Tables[0].Rows[0]["MoveTel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Bank"]!=null )
				{
					this.Bank=ds.Tables[0].Rows[0]["Bank"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BankNumber"]!=null )
				{
					this.BankNumber=ds.Tables[0].Rows[0]["BankNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["TaxNumber"]!=null )
				{
					this.TaxNumber=ds.Tables[0].Rows[0]["TaxNumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Deputy"]!=null )
				{
					this.Deputy=ds.Tables[0].Rows[0]["Deputy"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null )
				{
					this.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Fax"]!=null )
				{
					this.Fax=ds.Tables[0].Rows[0]["Fax"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Receivable"]!=null && ds.Tables[0].Rows[0]["Receivable"].ToString()!="")
				{
					this.Receivable=decimal.Parse(ds.Tables[0].Rows[0]["Receivable"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Payable"]!=null && ds.Tables[0].Rows[0]["Payable"].ToString()!="")
				{
					this.Payable=decimal.Parse(ds.Tables[0].Rows[0]["Payable"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Address"]!=null )
				{
					this.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Mail"]!=null )
				{
					this.Mail=ds.Tables[0].Rows[0]["Mail"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Email"]!=null )
				{
					this.Email=ds.Tables[0].Rows[0]["Email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QQ"]!=null )
				{
					this.QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Other"]!=null )
				{
					this.Other=ds.Tables[0].Rows[0]["Other"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null )
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["AllType"]!=null )
				{
					this.AllType=ds.Tables[0].Rows[0]["AllType"].ToString();
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
			strSql.Append(" FROM [Company] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

