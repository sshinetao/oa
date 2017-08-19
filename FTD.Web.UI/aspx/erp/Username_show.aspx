<%@ Page language="c#" Codebehind="Username_show.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.Username_show" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<script>
			function chknull()
				{
		if(document.getElementById('Username').value=='')
			{
				alert('用户名不能为空');
				Form1.Username.focus();
				return false;
			}	

		if(document.getElementById('Realname').value=='')
			{
				alert('姓名不能为空');
				Form1.Realname.focus();
				return false;
			}	
			
		if(document.getElementById('Password').value=='')
			{
				alert('密码不能为空');
				Form1.Password.focus();
				return false;
			}	
			if(document.getElementById('Unit').value==''||document.getElementById('Unit').value=='undefined')
			{
				alert('职能机构不能为空');
				
				return false;
			}			
									
			}
			
			
		var  wName;  
        function  fnOpen()  
            {  
            var num=Math.random();
                wName=window.showModalDialog("posttype_open.aspx?tmp="+num+" dialogWidth:318px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
                document.getElementById("Unit").value=wName; 
             
               
                
            }
            
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><img src="i_blue/m_head_1.jpg" width="20" height="34"></td>
					<td width="748" background="i_blue/m_head_3.jpg"><table width="92%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="97%" class="headfont"><a href="main_1.aspx" class="line_b">工作台</a>&nbsp;&gt;&gt;&nbsp;<a href="Username.aspx" class="line_b">用户设置</a>&nbsp;&gt;&gt; 
									查看用户</td>
							</tr>
						</table>
					</td>
					<td width="23"><img src="i_blue/m_head_2.jpg" width="21" height="34"></td>
				</tr>
			</table>
			<table width="100%" height="450" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td width="95%" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#7d9db4">
							<tr>
								<td valign="top" bgcolor="#f3f8fe"><table width="100%" height="26" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
										</tr>
									</table>
									<table width="100%" border="0" cellpadding="4" cellspacing="1" bgcolor="#d8e1e8">
										<TBODY>
											<tr bgcolor="#f3f8fe">
												<td width="15%" align="right"><FONT face="宋体">用户名：</FONT></td>
												<td width="35%">
													<asp:TextBox id="Username" runat="server" Width="100%" ></asp:TextBox></td>
												<td width="15%" align="right"><FONT face="宋体">用户姓名：</FONT></td>
												<td width="35%">
													<asp:TextBox id="Realname" runat="server" Width="100%" ></asp:TextBox></td>
											</tr>
											<tr bgcolor="#f3f8fe">
												<td width="15%" align="right"><FONT face="宋体">工号：</FONT></td>
												<td width="85%" colspan="3">
													<asp:TextBox id="worknum" runat="server" Width="100%" ></asp:TextBox></td>
											</tr>
											<tr bgcolor="#f3f8fe">
												<td align="right"><FONT face="宋体">性别：</FONT></td>
												<td>
													<asp:TextBox id="Sex" runat="server"  Width="100%"></asp:TextBox></td>
												<td align="right"><FONT face="宋体">职能机构：</FONT></td>
												<td>
													<asp:TextBox id="Unit" runat="server" Width="100%" ></asp:TextBox><A href="javascript:void(0)"></A></td>
											</tr>
											<tr bgcolor="#f3f8fe">
												<td align="right"><FONT face="宋体">有效开始日期：</FONT></td>
												<td><FONT face="宋体"></FONT>
													<asp:TextBox id="Firsttime" runat="server"  Width="100%"></asp:TextBox><a href="javascript:void(0)"></a></td>
												<td align="right"><FONT face="宋体">有效结束日期：</FONT></td>
												<td><FONT face="宋体">
														<asp:TextBox id="Lasttime" runat="server"  Width="100%"></asp:TextBox></FONT></td>
											</tr>
											<TR bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">Email：</FONT></td>
												<td>
													<asp:TextBox id="Email" runat="server" Width="100%" ></asp:TextBox></td>
												<TD align="right"><FONT face="宋体">是否允许登陆：</FONT></TD>
												<TD>
													<asp:TextBox id="Iflogin" runat="server"  Width="100%"></asp:TextBox></TD>
											</TR>
							</tr>
							<TR bgColor="#f3f8fe">
								<TD align="right"><FONT face="宋体">备注：</FONT></TD>
								<td colspan="3">
									<asp:TextBox id="Remark" runat="server" Width="100%" Height="108px" TextMode="MultiLine" ></asp:TextBox></td>
							</TR>
						</table>
						<table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td background="i_blue/third_head_bg1.jpg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"></td>
											<td width="52%">
												<asp:ImageButton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:ImageButton></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			</TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE>
		</form>
	</body>
</HTML>
