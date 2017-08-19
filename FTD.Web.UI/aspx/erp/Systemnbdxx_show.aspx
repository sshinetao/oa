<%@ Page language="c#" Codebehind="Systemnbdxx_show.aspx.cs" AutoEventWireup="false" Inherits="bjoa.Systemnbdxx_show" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>协同办公平台</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<script>
			
		function killErrors() {
		return true;
		}
		window.onerror = killErrors;
		</script>
		<SCRIPT language="javascript" type="text/javascript">

function checkForm()
{
with(document.Form1)
{

//--------------1
var strUploadFile=uploadFile.value;
var picOK=false;

if (strUploadFile=="")
	{
	alert("提示:\r您还没有选择上传的文件！"); 
	return(false); 
	uploadFile.focus;
	} 
	var nameLen=strUploadFile.length;
	var rightName=strUploadFile.substr(nameLen-4,4).toLowerCase();


	if (nameLen>0)
	{
		if ( rightName==".rar" ||  rightName==".zip" ||  rightName==".doc"  ||  rightName==".xls"  ||  rightName==".ppt" || rightName==".RAR" ||  rightName==".ZIP" ||  rightName==".DOC"  ||  rightName==".XLS"  ||  rightName==".PPT"   )
		{ picOK=true; }

		if (picOK==false)
		{ alert("提示:\r只能上传.rar|.zip |.doc|.xls|.ppt格式的文件！");
		return(false);
		uploadFile.focus;
		}
	}

//--------------1

}
}
		</SCRIPT>
		<script>

			
	
            
 

	function  down()  
	{
	 if(document.getElementById('fjlb').value=='')
			{
			
				alert('未选中文件');
				
				return false;
			}
			else
			{
				var num=Math.random();
				var littleproduct=document.getElementById("fjlb");
				var cindex = littleproduct.selectedIndex;
				var cText  = littleproduct.options[cindex].text;
				var cValue = littleproduct.options[cindex].value;
				
				 // window.showModalDialog("MeetingHouse_down.aspx?tmp="+num+"&number="+cValue+" ","window","dialogWidth:1000px;DialogHeight=600px;status:no;scroll=yes;help:no");                
				  
				  
				window.open ("Systemnbdxx_add_down.aspx?tmp="+num+"&number="+cValue+"", "newwindow", "height=1, width=1,toolbar=no, menubar=no, scrollbars=no,resizable=yes,location=no, status=no")
			}
	 
	
	}
	
	function  delfj()  
	{
	 if(document.getElementById('fjlb').value=='')
			{
			
				alert('未选种文件');
				
				return false;
			}
			else
			{
				var num=Math.random();
				var littleproduct=document.getElementById("fjlb");
				var cindex = littleproduct.selectedIndex;
				var cText  = littleproduct.options[cindex].text;
				var cValue = littleproduct.options[cindex].value;
				
				  window.showModalDialog("Systemnbdxx_add_del.aspx?tmp="+num+"&number="+cValue+" ","window","dialogWidth:1000px;DialogHeight=600px;status:no;scroll=yes;help:no");                
				//window.open ("MeetingHouse_fj_del.aspx?tmp="+num+"&number="+cValue+"", "newwindow", "height=1, width=1,toolbar=no, menubar=no, scrollbars=no,resizable=no,location=no, status=no")
			}
	 
	
	}			
				
			            
                   
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form method="post" runat="server" ID="Form1">
			<script language='javascript' src='DateSelect.js'></script>
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><img src="i_blue/m_head_1.jpg" width="20" height="34"></td>
					<td width="748" background="i_blue/m_head_3.jpg"><table width="92%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="97%" class="headfont"><a href="main_1.aspx" class="line_b">工作台</a>&nbsp;&gt;&gt;&nbsp;<a href="Systemnbdxx.aspx" class="line_b">消息管理</a>&nbsp;&gt;&gt; 
									查看消息</td>
							</tr>
						</table>
					</td>
					<td width="23"><img src="i_blue/m_head_2.jpg" width="21" height="34"></td>
				</tr>
			</table>
			<table width="100%" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td width="95%" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#7d9db4">
							<TBODY>
								<tr>
									<td valign="top" bgcolor="#f3f8fe"><table width="100%" height="26" border="0" cellpadding="0" cellspacing="0">
											<tr>
												<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
											</tr>
										</table>
										<table width="100%" border="0" cellpadding="4" cellspacing="1" bgcolor="#d8e1e8">
											<TBODY>
												<tr bgcolor="#f3f8fe">
													<td align="right" width="15%"><FONT face="宋体">消息标题：</FONT></td>
													<td width="85%">
														<asp:TextBox id="title" runat="server" Width="100%" ></asp:TextBox><a href="javascript:void(0)"></a></td>
												</tr>
												<tr bgcolor="#f3f8fe">
													<td align="right" width="15%"><FONT face="宋体">消息内容：</FONT></td>
													<td width="85%">
														<asp:TextBox id="content" runat="server" Width="100%" Height="118px" TextMode="MultiLine" ></asp:TextBox><a href="javascript:void(0)"></a></td>
												</tr>
												<tr bgColor="#f3f8fe">
													<td align="right"><FONT face="宋体"><FONT face="宋体"><FONT face="宋体">附件列表</FONT></FONT>：</FONT></td>
													<td><asp:dropdownlist id="fjlb" runat="server" Width="472px"></asp:dropdownlist><INPUT onclick="javascript:return down();" type="button" value="下  载"><FONT face="宋体">&nbsp;</FONT></td>
												</tr>
								</tr>
							</TBODY>
						</table>
						<table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td background="i_blue/third_head_bg1.jpg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"></td>
											<td width="52%">&nbsp;
												<asp:ImageButton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:ImageButton></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<asp:TextBox id="Number" runat="server" Visible="False"></asp:TextBox></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE>
		</form>
	</body>
</HTML>
