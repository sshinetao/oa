using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using FTD.DBUnit;//Please add references
namespace FTD.BLL
{
	/// <summary>
	/// 类Manager。
	/// </summary>
	[Serializable]
	public partial class Manager
	{
		public Manager()
		{}
		#region Model
		private long _id;
		private string _number;
		private string _name;
		private string _worknum;
		private string _sex;
		private string _unit;
		private string _sftype;
		private string _gztype;
		private string _nationals;
		private string _sfnumber;
		private string _origin;
		private string _birth;
		private string _marriage;
		private string _study;
		private string _professional;
		private string _studyhouse;
		private DateTime? _iworktime;
		private DateTime? _icompanytime;
		private string _status;
		private string _zzface;
		private string _awards;
		private string _titles;
		private string _training;
		private string _address;
		private string _tel;
		private string _email;
		private string _studyback;
		private string _workitro;
		private string _community;
		private string _remark;
		private string _photo;
		private DateTime? _settime;
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
		public string number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string worknum
		{
			set{ _worknum=value;}
			get{return _worknum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sex
		{
			set{ _sex=value;}
			get{return _sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sftype
		{
			set{ _sftype=value;}
			get{return _sftype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string gztype
		{
			set{ _gztype=value;}
			get{return _gztype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Nationals
		{
			set{ _nationals=value;}
			get{return _nationals;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string sfnumber
		{
			set{ _sfnumber=value;}
			get{return _sfnumber;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Origin
		{
			set{ _origin=value;}
			get{return _origin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string birth
		{
			set{ _birth=value;}
			get{return _birth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Marriage
		{
			set{ _marriage=value;}
			get{return _marriage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Study
		{
			set{ _study=value;}
			get{return _study;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Professional
		{
			set{ _professional=value;}
			get{return _professional;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Studyhouse
		{
			set{ _studyhouse=value;}
			get{return _studyhouse;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Iworktime
		{
			set{ _iworktime=value;}
			get{return _iworktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Icompanytime
		{
			set{ _icompanytime=value;}
			get{return _icompanytime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Zzface
		{
			set{ _zzface=value;}
			get{return _zzface;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Awards
		{
			set{ _awards=value;}
			get{return _awards;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Titles
		{
			set{ _titles=value;}
			get{return _titles;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Training
		{
			set{ _training=value;}
			get{return _training;}
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
		public string Tel
		{
			set{ _tel=value;}
			get{return _tel;}
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
		public string Studyback
		{
			set{ _studyback=value;}
			get{return _studyback;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Workitro
		{
			set{ _workitro=value;}
			get{return _workitro;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Community
		{
			set{ _community=value;}
			get{return _community;}
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
		public string photo
		{
			set{ _photo=value;}
			get{return _photo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? settime
		{
			set{ _settime=value;}
			get{return _settime;}
		}
		#endregion Model


		#region  Method

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Manager(long id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,number,name,worknum,sex,unit,sftype,gztype,Nationals,sfnumber,Origin,birth,Marriage,Study,Professional,Studyhouse,Iworktime,Icompanytime,Status,Zzface,Awards,Titles,Training,Address,Tel,Email,Studyback,Workitro,Community,Remark,photo,settime ");
			strSql.Append(" FROM [Manager] ");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.BigInt)};
			parameters[0].Value = id;

			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					 if (ds.Tables[0].Rows[0]["id"].ToString() != ""){this.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()); } 
				if(ds.Tables[0].Rows[0]["number"]!=null)
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
				}
				if(ds.Tables[0].Rows[0]["name"]!=null)
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["worknum"]!=null)
				{
					this.worknum=ds.Tables[0].Rows[0]["worknum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null)
				{
					this.sex=ds.Tables[0].Rows[0]["sex"].ToString();
				}
				if(ds.Tables[0].Rows[0]["unit"]!=null)
				{
					this.unit=ds.Tables[0].Rows[0]["unit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sftype"]!=null)
				{
					this.sftype=ds.Tables[0].Rows[0]["sftype"].ToString();
				}
				if(ds.Tables[0].Rows[0]["gztype"]!=null)
				{
					this.gztype=ds.Tables[0].Rows[0]["gztype"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Nationals"]!=null)
				{
					this.Nationals=ds.Tables[0].Rows[0]["Nationals"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sfnumber"]!=null)
				{
					this.sfnumber=ds.Tables[0].Rows[0]["sfnumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Origin"]!=null)
				{
					this.Origin=ds.Tables[0].Rows[0]["Origin"].ToString();
				}
				if(ds.Tables[0].Rows[0]["birth"]!=null)
				{
					this.birth=ds.Tables[0].Rows[0]["birth"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Marriage"]!=null)
				{
					this.Marriage=ds.Tables[0].Rows[0]["Marriage"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Study"]!=null)
				{
					this.Study=ds.Tables[0].Rows[0]["Study"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Professional"]!=null)
				{
					this.Professional=ds.Tables[0].Rows[0]["Professional"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Studyhouse"]!=null)
				{
					this.Studyhouse=ds.Tables[0].Rows[0]["Studyhouse"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Iworktime"]!=null && ds.Tables[0].Rows[0]["Iworktime"].ToString()!="")
				{
					this.Iworktime=DateTime.Parse(ds.Tables[0].Rows[0]["Iworktime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Icompanytime"]!=null && ds.Tables[0].Rows[0]["Icompanytime"].ToString()!="")
				{
					this.Icompanytime=DateTime.Parse(ds.Tables[0].Rows[0]["Icompanytime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Status"]!=null)
				{
					this.Status=ds.Tables[0].Rows[0]["Status"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Zzface"]!=null)
				{
					this.Zzface=ds.Tables[0].Rows[0]["Zzface"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Awards"]!=null)
				{
					this.Awards=ds.Tables[0].Rows[0]["Awards"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Titles"]!=null)
				{
					this.Titles=ds.Tables[0].Rows[0]["Titles"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Training"]!=null)
				{
					this.Training=ds.Tables[0].Rows[0]["Training"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Address"]!=null)
				{
					this.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null)
				{
					this.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Email"]!=null)
				{
					this.Email=ds.Tables[0].Rows[0]["Email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Studyback"]!=null)
				{
					this.Studyback=ds.Tables[0].Rows[0]["Studyback"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Workitro"]!=null)
				{
					this.Workitro=ds.Tables[0].Rows[0]["Workitro"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Community"]!=null)
				{
					this.Community=ds.Tables[0].Rows[0]["Community"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null)
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["photo"]!=null)
				{
					this.photo=ds.Tables[0].Rows[0]["photo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["settime"]!=null && ds.Tables[0].Rows[0]["settime"].ToString()!="")
				{
					this.settime=DateTime.Parse(ds.Tables[0].Rows[0]["settime"].ToString());
				}
			}
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists()
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from [Manager]");
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
			strSql.Append("insert into [Manager] (");
			strSql.Append("number,name,worknum,sex,unit,sftype,gztype,Nationals,sfnumber,Origin,birth,Marriage,Study,Professional,Studyhouse,Iworktime,Icompanytime,Status,Zzface,Awards,Titles,Training,Address,Tel,Email,Studyback,Workitro,Community,Remark,photo,settime)");
			strSql.Append(" values (");
			strSql.Append("@number,@name,@worknum,@sex,@unit,@sftype,@gztype,@Nationals,@sfnumber,@Origin,@birth,@Marriage,@Study,@Professional,@Studyhouse,@Iworktime,@Icompanytime,@Status,@Zzface,@Awards,@Titles,@Training,@Address,@Tel,@Email,@Studyback,@Workitro,@Community,@Remark,@photo,@settime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@worknum", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.NVarChar,50),
					new SqlParameter("@unit", SqlDbType.NVarChar,50),
					new SqlParameter("@sftype", SqlDbType.NVarChar,50),
					new SqlParameter("@gztype", SqlDbType.NVarChar,50),
					new SqlParameter("@Nationals", SqlDbType.NVarChar,50),
					new SqlParameter("@sfnumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Origin", SqlDbType.NVarChar,50),
					new SqlParameter("@birth", SqlDbType.NVarChar,50),
					new SqlParameter("@Marriage", SqlDbType.NVarChar,50),
					new SqlParameter("@Study", SqlDbType.NVarChar,50),
					new SqlParameter("@Professional", SqlDbType.NVarChar,50),
					new SqlParameter("@Studyhouse", SqlDbType.NVarChar,50),
					new SqlParameter("@Iworktime", SqlDbType.DateTime),
					new SqlParameter("@Icompanytime", SqlDbType.DateTime),
					new SqlParameter("@Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Zzface", SqlDbType.NVarChar,50),
					new SqlParameter("@Awards", SqlDbType.NVarChar,50),
					new SqlParameter("@Titles", SqlDbType.NVarChar,50),
					new SqlParameter("@Training", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,50),
					new SqlParameter("@Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Studyback", SqlDbType.NText),
					new SqlParameter("@Workitro", SqlDbType.NText),
					new SqlParameter("@Community", SqlDbType.NText),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@photo", SqlDbType.NVarChar,50),
					new SqlParameter("@settime", SqlDbType.DateTime)};
			parameters[0].Value = number;
			parameters[1].Value = name;
			parameters[2].Value = worknum;
			parameters[3].Value = sex;
			parameters[4].Value = unit;
			parameters[5].Value = sftype;
			parameters[6].Value = gztype;
			parameters[7].Value = Nationals;
			parameters[8].Value = sfnumber;
			parameters[9].Value = Origin;
			parameters[10].Value = birth;
			parameters[11].Value = Marriage;
			parameters[12].Value = Study;
			parameters[13].Value = Professional;
			parameters[14].Value = Studyhouse;
			parameters[15].Value = Iworktime;
			parameters[16].Value = Icompanytime;
			parameters[17].Value = Status;
			parameters[18].Value = Zzface;
			parameters[19].Value = Awards;
			parameters[20].Value = Titles;
			parameters[21].Value = Training;
			parameters[22].Value = Address;
			parameters[23].Value = Tel;
			parameters[24].Value = Email;
			parameters[25].Value = Studyback;
			parameters[26].Value = Workitro;
			parameters[27].Value = Community;
			parameters[28].Value = Remark;
			parameters[29].Value = photo;
			parameters[30].Value = settime;

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
			strSql.Append("update [Manager] set ");
			strSql.Append("number=@number,");
			strSql.Append("name=@name,");
			strSql.Append("worknum=@worknum,");
			strSql.Append("sex=@sex,");
			strSql.Append("unit=@unit,");
			strSql.Append("sftype=@sftype,");
			strSql.Append("gztype=@gztype,");
			strSql.Append("Nationals=@Nationals,");
			strSql.Append("sfnumber=@sfnumber,");
			strSql.Append("Origin=@Origin,");
			strSql.Append("birth=@birth,");
			strSql.Append("Marriage=@Marriage,");
			strSql.Append("Study=@Study,");
			strSql.Append("Professional=@Professional,");
			strSql.Append("Studyhouse=@Studyhouse,");
			strSql.Append("Iworktime=@Iworktime,");
			strSql.Append("Icompanytime=@Icompanytime,");
			strSql.Append("Status=@Status,");
			strSql.Append("Zzface=@Zzface,");
			strSql.Append("Awards=@Awards,");
			strSql.Append("Titles=@Titles,");
			strSql.Append("Training=@Training,");
			strSql.Append("Address=@Address,");
			strSql.Append("Tel=@Tel,");
			strSql.Append("Email=@Email,");
			strSql.Append("Studyback=@Studyback,");
			strSql.Append("Workitro=@Workitro,");
			strSql.Append("Community=@Community,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("photo=@photo,");
			strSql.Append("settime=@settime");
			strSql.Append(" where id=@id ");
			SqlParameter[] parameters = {
					new SqlParameter("@number", SqlDbType.NVarChar,50),
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@worknum", SqlDbType.NVarChar,50),
					new SqlParameter("@sex", SqlDbType.NVarChar,50),
					new SqlParameter("@unit", SqlDbType.NVarChar,50),
					new SqlParameter("@sftype", SqlDbType.NVarChar,50),
					new SqlParameter("@gztype", SqlDbType.NVarChar,50),
					new SqlParameter("@Nationals", SqlDbType.NVarChar,50),
					new SqlParameter("@sfnumber", SqlDbType.NVarChar,50),
					new SqlParameter("@Origin", SqlDbType.NVarChar,50),
					new SqlParameter("@birth", SqlDbType.NVarChar,50),
					new SqlParameter("@Marriage", SqlDbType.NVarChar,50),
					new SqlParameter("@Study", SqlDbType.NVarChar,50),
					new SqlParameter("@Professional", SqlDbType.NVarChar,50),
					new SqlParameter("@Studyhouse", SqlDbType.NVarChar,50),
					new SqlParameter("@Iworktime", SqlDbType.DateTime),
					new SqlParameter("@Icompanytime", SqlDbType.DateTime),
					new SqlParameter("@Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Zzface", SqlDbType.NVarChar,50),
					new SqlParameter("@Awards", SqlDbType.NVarChar,50),
					new SqlParameter("@Titles", SqlDbType.NVarChar,50),
					new SqlParameter("@Training", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,50),
					new SqlParameter("@Tel", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Studyback", SqlDbType.NText),
					new SqlParameter("@Workitro", SqlDbType.NText),
					new SqlParameter("@Community", SqlDbType.NText),
					new SqlParameter("@Remark", SqlDbType.NText),
					new SqlParameter("@photo", SqlDbType.NVarChar,50),
					new SqlParameter("@settime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.BigInt,8)};
			parameters[0].Value = number;
			parameters[1].Value = name;
			parameters[2].Value = worknum;
			parameters[3].Value = sex;
			parameters[4].Value = unit;
			parameters[5].Value = sftype;
			parameters[6].Value = gztype;
			parameters[7].Value = Nationals;
			parameters[8].Value = sfnumber;
			parameters[9].Value = Origin;
			parameters[10].Value = birth;
			parameters[11].Value = Marriage;
			parameters[12].Value = Study;
			parameters[13].Value = Professional;
			parameters[14].Value = Studyhouse;
			parameters[15].Value = Iworktime;
			parameters[16].Value = Icompanytime;
			parameters[17].Value = Status;
			parameters[18].Value = Zzface;
			parameters[19].Value = Awards;
			parameters[20].Value = Titles;
			parameters[21].Value = Training;
			parameters[22].Value = Address;
			parameters[23].Value = Tel;
			parameters[24].Value = Email;
			parameters[25].Value = Studyback;
			parameters[26].Value = Workitro;
			parameters[27].Value = Community;
			parameters[28].Value = Remark;
			parameters[29].Value = photo;
			parameters[30].Value = settime;
			parameters[31].Value = id;

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
			strSql.Append("delete from [Manager] ");
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
			strSql.Append("select id,number,name,worknum,sex,unit,sftype,gztype,Nationals,sfnumber,Origin,birth,Marriage,Study,Professional,Studyhouse,Iworktime,Icompanytime,Status,Zzface,Awards,Titles,Training,Address,Tel,Email,Studyback,Workitro,Community,Remark,photo,settime ");
			strSql.Append(" FROM [Manager] ");
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
				if(ds.Tables[0].Rows[0]["number"]!=null )
				{
					this.number=ds.Tables[0].Rows[0]["number"].ToString();
				}
				if(ds.Tables[0].Rows[0]["name"]!=null )
				{
					this.name=ds.Tables[0].Rows[0]["name"].ToString();
				}
				if(ds.Tables[0].Rows[0]["worknum"]!=null )
				{
					this.worknum=ds.Tables[0].Rows[0]["worknum"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sex"]!=null )
				{
					this.sex=ds.Tables[0].Rows[0]["sex"].ToString();
				}
				if(ds.Tables[0].Rows[0]["unit"]!=null )
				{
					this.unit=ds.Tables[0].Rows[0]["unit"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sftype"]!=null )
				{
					this.sftype=ds.Tables[0].Rows[0]["sftype"].ToString();
				}
				if(ds.Tables[0].Rows[0]["gztype"]!=null )
				{
					this.gztype=ds.Tables[0].Rows[0]["gztype"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Nationals"]!=null )
				{
					this.Nationals=ds.Tables[0].Rows[0]["Nationals"].ToString();
				}
				if(ds.Tables[0].Rows[0]["sfnumber"]!=null )
				{
					this.sfnumber=ds.Tables[0].Rows[0]["sfnumber"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Origin"]!=null )
				{
					this.Origin=ds.Tables[0].Rows[0]["Origin"].ToString();
				}
				if(ds.Tables[0].Rows[0]["birth"]!=null )
				{
					this.birth=ds.Tables[0].Rows[0]["birth"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Marriage"]!=null )
				{
					this.Marriage=ds.Tables[0].Rows[0]["Marriage"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Study"]!=null )
				{
					this.Study=ds.Tables[0].Rows[0]["Study"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Professional"]!=null )
				{
					this.Professional=ds.Tables[0].Rows[0]["Professional"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Studyhouse"]!=null )
				{
					this.Studyhouse=ds.Tables[0].Rows[0]["Studyhouse"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Iworktime"]!=null && ds.Tables[0].Rows[0]["Iworktime"].ToString()!="")
				{
					this.Iworktime=DateTime.Parse(ds.Tables[0].Rows[0]["Iworktime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Icompanytime"]!=null && ds.Tables[0].Rows[0]["Icompanytime"].ToString()!="")
				{
					this.Icompanytime=DateTime.Parse(ds.Tables[0].Rows[0]["Icompanytime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Status"]!=null )
				{
					this.Status=ds.Tables[0].Rows[0]["Status"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Zzface"]!=null )
				{
					this.Zzface=ds.Tables[0].Rows[0]["Zzface"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Awards"]!=null )
				{
					this.Awards=ds.Tables[0].Rows[0]["Awards"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Titles"]!=null )
				{
					this.Titles=ds.Tables[0].Rows[0]["Titles"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Training"]!=null )
				{
					this.Training=ds.Tables[0].Rows[0]["Training"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Address"]!=null )
				{
					this.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Tel"]!=null )
				{
					this.Tel=ds.Tables[0].Rows[0]["Tel"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Email"]!=null )
				{
					this.Email=ds.Tables[0].Rows[0]["Email"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Studyback"]!=null )
				{
					this.Studyback=ds.Tables[0].Rows[0]["Studyback"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Workitro"]!=null )
				{
					this.Workitro=ds.Tables[0].Rows[0]["Workitro"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Community"]!=null )
				{
					this.Community=ds.Tables[0].Rows[0]["Community"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Remark"]!=null )
				{
					this.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				}
				if(ds.Tables[0].Rows[0]["photo"]!=null )
				{
					this.photo=ds.Tables[0].Rows[0]["photo"].ToString();
				}
				if(ds.Tables[0].Rows[0]["settime"]!=null && ds.Tables[0].Rows[0]["settime"].ToString()!="")
				{
					this.settime=DateTime.Parse(ds.Tables[0].Rows[0]["settime"].ToString());
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
			strSql.Append(" FROM [Manager] ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		#endregion  Method
	}
}

