using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using qpsmartweb_jxc.Public;
using System.Data.OleDb;
namespace bjoa
{
	/// <summary>
	/// seadmessage 的摘要说明。
	/// </summary>
	public class seadmessage : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.TextBox title;
		protected System.Web.UI.WebControls.TextBox content;
		protected System.Web.UI.WebControls.DropDownList fjlb;
		protected System.Web.UI.WebControls.Button Button1;
		protected System.Web.UI.WebControls.Button Button3;
		protected System.Web.UI.WebControls.Label newname;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.ImageButton ImageButton1;
		protected System.Web.UI.WebControls.TextBox Number;
		protected System.Web.UI.HtmlControls.HtmlInputFile uploadFile;
		Db List=new Db();
		BindDrowDownList list=new BindDrowDownList();
		string _SavePath=null;
		protected System.Web.UI.WebControls.DropDownList user;
		public string fortmp;
		public string CreateFileId()
		{
			string y = DateTime.Now.Year.ToString();
			string m = DateTime.Now.Month.ToString();
			string d = DateTime.Now.Day.ToString();
			string h = DateTime.Now.Hour.ToString();
			string n = DateTime.Now.Minute.ToString();
			string s = DateTime.Now.Second.ToString();

			
			Random r  = new Random();
			string RandomNum = r.Next(1000).ToString();

			
			string bb = y + m + d + h + n + s + RandomNum;

			return bb;
		}
		private void Page_Load(object sender, System.EventArgs e)
		{
            FTD.Unit.PublicMethod.CheckSession();

			this.Button3.Attributes.Add("onclick","javascript:return checkForm();");
			this.Button1.Attributes.Add("onclick","javascript:return delfj();");

			string sql_down="select * from Username ";

			
			if(!IsPostBack)
			{
				list.Bind_DropDownList_nothing(user,sql_down,"username","realname");
			
				
				
			}

			if(Request.QueryString["us"]!=null)
			{
				if(!IsPostBack)
				{
					user.SelectedValue=Request.QueryString["us"].ToString();
				}
			}


			if(!IsPostBack)
			{
				Random g  = new Random();
				string rad=g.Next(10000).ToString();

				Number.Text=""+System.DateTime.Now.Year.ToString()+""+System.DateTime.Now.Month.ToString()+""+System.DateTime.Now.Day.ToString()+""+System.DateTime.Now.Hour.ToString()+""+System.DateTime.Now.Minute.ToString()+""+System.DateTime.Now.Second.ToString()+""+System.DateTime.Now.Millisecond.ToString()+""+rad+"";
			}

			//附件列表
			string sql_down_1="select * from nbdxxFj where KeyField='"+Number.Text+"'";
		
			
			list.Bind_DropDownList_nothing(fjlb,sql_down_1,"NewName","Name");

		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.ImageButton1.Click += new System.Web.UI.ImageClickEventHandler(this.ImageButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void Button3_Click(object sender, System.EventArgs e)
		{
			string newName=CreateFileId();
			Response.Cookies["newName"].Value =newname.Text;
			
           
			System.Web.HttpFileCollection _files = System.Web.HttpContext.Current.Request.Files;
   
			
			System.Text.StringBuilder _message = new System.Text.StringBuilder("文件已成功上传");
			
		
			try 
			{
				for ( System.Int32 _iFile = 0; _iFile < _files.Count; _iFile ++ ) 
				{
   
					System.Web.HttpPostedFile _postedFile = _files[_iFile]; 
					System.String _fileName, _fileExtension; 
					_fileName = System.IO.Path.GetFileName(_postedFile.FileName);
					//	upoldname= System.IO.Path.GetFileName(_postedFile.FileName);
					_fileExtension = System.IO.Path.GetExtension(_fileName);
					if(_fileExtension==".rar"|| _fileExtension==".RAR")
					{
						newname.Text=newName+".rar"; 
						
					}
					if(_fileExtension==".zip"||_fileExtension==".ZIP")
					{
					
						newname.Text=newName+".zip"; 
						
					
					}

					if(_fileExtension==".doc"||_fileExtension==".DOC")
					{
					
						newname.Text=newName+".doc"; 
					
					
					}

					if(_fileExtension==".xls"||_fileExtension==".XLS")
					{
					
						newname.Text=newName+".xls"; 
					
					
					}


					if(_fileExtension==".ppt"||_fileExtension==".PPT")
					{
					
						newname.Text=newName+".ppt"; 
					
					
					}

					_SavePath = this.Server.MapPath("nbdxxFj/");
					_postedFile.SaveAs (_SavePath+newName+_fileExtension);

					string sql_insert="insert into nbdxxFj values('"+_fileName+"','"+newname.Text+"','"+Number.Text+"')";
					List.ExeSql(sql_insert);



				}
    
				
				
			}
				
			catch ( System.Exception Ex ) 
			{ 
   
				Label1.Text = Ex.Message ;
				  
   
			}

			
			//附件列表
			string sql_down1="select * from nbdxxFj where KeyField='"+Number.Text+"'";
					
			
			list.Bind_DropDownList_nothing(fjlb,sql_down1,"NewName","Name");
		}

		private void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
			string insert="insert into nbdxx values('"+title.Text+"','"+content.Text+"','"+System.DateTime.Now.ToString()+"','"+user.SelectedValue+"','"+user.SelectedItem.Text+"','"+Session["username"]+"','"+Session["TrueName"]+"','否','"+this.Number.Text+"')";
			List.ExeSql(insert);
			this.Response.Write("<script language=javascript>alert('提交成功！');window.close();</script>");
		}
	}
}
