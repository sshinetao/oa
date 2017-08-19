<%@ Page language="c#" Codebehind="SystemPassword.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.SystemPassword" %>
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
			
				function check()
				{
				if(document.getElementById('Username').value=='')
				{
					alert('用户名不能为空');
					return false;
				}
							
				if(document.getElementById('Password').value=='')
				{
					alert('旧密码不能为空');
					return false;
				}
									
				if(document.getElementById('NewPassword').value=='')
				{
					alert('新密码不能为空');
					return false;
				}


	
				if(document.getElementById('NewPassword').value!=document.getElementById('NewPassword_c').value)
				{
					alert('确认密码和新密码不一样');
					return false;
				}
				
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
								<td width="97%" class="headfont"><a href="main_1.aspx" class="line_b">工作台</a> &nbsp;&gt;&gt;&nbsp;修改密码</td>
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
													<asp:TextBox id="Username" runat="server" Width="100%"></asp:TextBox></td>
												<td width="15%" align="right"><FONT face="宋体">用户旧密码：</FONT></td>
												<td width="35%">
													<asp:TextBox id="Password" runat="server" Width="100%" TextMode="Password"></asp:TextBox></td>
											</tr>
											<tr bgcolor="#f3f8fe">
												<td align="right"><FONT face="宋体">用户新密码：</FONT></td>
												<td>
													<asp:TextBox id="NewPassword" runat="server" Width="100%" TextMode="Password"></asp:TextBox></td>
												<td align="right"><FONT face="宋体">确认新密码：</FONT></td>
												<td>
													<asp:TextBox id="NewPassword_c" runat="server" Width="100%" TextMode="Password"></asp:TextBox></td>
											</tr>
							</tr>
						</table>
						<table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td background="i_blue/third_head_bg1.jpg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%">
												<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:ImageButton></td>
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
