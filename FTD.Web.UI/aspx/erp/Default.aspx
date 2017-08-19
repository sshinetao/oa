<%@ Page language="c#" Codebehind="default.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc._default" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>好帮手进销存</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<META HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<META HTTP-EQUIV="Cache-Control" CONTENT="no-cache">
		<META HTTP-EQUIV="Expires" CONTENT="0">
		<script>
			function chknull()
				{
		if(document.getElementById('Username').value=='')
			{
				alert('用户名不能为空');
				Form1.Username.focus();
				return false;
			}	


			
		if(document.getElementById('Password').value=='')
			{
				alert('密码不能为空');
				Form1.Password.focus();
				return false;
			}	
	}
            
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="1005" height="652" border="0">
				<tr>
					<td align="center" valign="top" background="i_blue/d_bg.jpg">
						<table width="600" height="40" border="0">
							<tr>
								<td>&nbsp;</td>
							</tr>
						</table>
						<table width="600" height="500" border="0">
							<tr>
								<td valign="top"><table width="600" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td height="67"><img src="i_blue/head1.jpg" width="600" height="67"></td>
										</tr>
										<tr>
											<td height="68"><img src="i_blue/head2.jpg" width="600" height="68"></td>
										</tr>
										<tr>
											<td height="61"><img src="i_blue/head3.jpg" width="600" height="61"></td>
										</tr>
										<tr>
											<td height="76"><img src="i_blue/head4.jpg" width="600" height="76"></td>
										</tr>
										<tr>
											<td height="120" valign="top" background="i_blue/head5.jpg">
												<table height="80" border="0" cellpadding="0" cellspacing="0">
													<tr>
														<td height="35" colspan="5">
														</td>
													</tr>
													<tr>
														<td width="166">&nbsp;</td>
														<td width="64">&nbsp;</td>
														<td width="147">
															<asp:TextBox id="Username" runat="server"></asp:TextBox></td>
														<td width="79" rowspan="3">
															<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/denglu.jpg"></asp:ImageButton></td>
														<td width="144">&nbsp;</td>
													</tr>
													<tr>
														<td height="1"></td>
														<td height="1"></td>
														<td height="1"></td>
														<td height="1"></td>
													</tr>
													<tr>
														<td>&nbsp;</td>
														<td>&nbsp;</td>
														<td><FONT face="宋体">
																<asp:TextBox id="Password" runat="server" TextMode="Password"></asp:TextBox></FONT></td>
														<td>&nbsp;</td>
													</tr>
												</table>
											</td>
										</tr>
										<tr>
											<td height="80"><img src="i_blue/head6.jpg" width="600" height="80"></td>
										</tr>
										<tr>
											<td><img src="i_blue/head7.jpg" width="600" height="28"></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
