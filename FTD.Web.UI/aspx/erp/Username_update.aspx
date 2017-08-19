<%@ Page language="c#" Codebehind="Username_update.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.Username_update" %>
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
		   function killErrors() {
		   return true;
		   }
		   window.onerror = killErrors;	
		
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
                wName=window.showModalDialog("posttype_open.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no"); 
              
                 if(wName!=null && wName!= "undefined")
                 {
                   
			    	document.getElementById("Unit").value=wName; 
			    	return;
                 }
             
               
                
            }
            
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<script language="javascript" src="DateSelect.js"></script>
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><img src="i_blue/m_head_1.jpg" width="20" height="34"></td>
					<td width="748" background="i_blue/m_head_3.jpg"><table width="92%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="97%" class="headfont"><a href="main_1.aspx" class="line_b">工作台</a>&nbsp;&gt;&gt;&nbsp;<a href="Username.aspx" class="line_b">用户设置</a>&nbsp;&gt;&gt; 
									修改用户</td>
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
													<asp:TextBox id="Realname" runat="server" Width="100%"></asp:TextBox></td>
											</tr>
											<tr bgcolor="#f3f8fe">
												<td width="15%" align="right"><FONT face="宋体">工号：</FONT></td>
												<td width="85%" colspan="3">
													<asp:TextBox id="worknum" runat="server" Width="100%" ></asp:TextBox></td>
											</tr>
											<tr bgcolor="#f3f8fe">
												<td align="right"><FONT face="宋体">性别：</FONT></td>
												<td>
													<asp:DropDownList id="Sex" runat="server" Width="100%">
														<asp:ListItem Value="男">男</asp:ListItem>
														<asp:ListItem Value="女">女</asp:ListItem>
													</asp:DropDownList></td>
												<td align="right"><FONT face="宋体">职能机构：</FONT></td>
												<td>
													<asp:TextBox id="Unit" runat="server" Width="90%" ></asp:TextBox><A href="javascript:void(0)"><IMG alt="" var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectDanWei.aspx?TableName=ERPBuMen&LieName=BuMenName&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('unit').value=wName;} src="image/FDJ.gif" border="0"></A></td>
											</tr>
											<tr bgcolor="#f3f8fe">
												<td align="right"><FONT face="宋体">有效开始日期：</FONT></td>
												<td>
													<asp:textbox id="Firsttime" runat="server" Width="90%" ></asp:textbox>
													<script>SetNeed('Firsttime')</script>
													<A href="javascript:void(0)"><IMG id="Firsttime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
															src="image/FDJ.gif" border="0"></A></td>
												<td align="right"><FONT face="宋体">有效结束日期：</FONT></td>
												<td>
													<asp:textbox id="Lasttime" runat="server" Width="90%" ></asp:textbox>
													<script>SetNeed('Lasttime')</script>
													<A href="javascript:void(0)"><IMG id="Lasttime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
															src="image/FDJ.gif" border="0"></A></td>
											</tr>
											<TR bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">Email：</FONT></td>
												<td>
													<asp:TextBox id="Email" runat="server" Width="100%"></asp:TextBox></td>
												<TD align="right"><FONT face="宋体">是否允许登陆：</FONT></TD>
												<TD>
													<asp:DropDownList id="Iflogin" runat="server" Width="100%">
														<asp:ListItem Value="是">是</asp:ListItem>
														<asp:ListItem Value="否">否</asp:ListItem>
													</asp:DropDownList></TD>
											</TR>
							</tr>
							<TR bgColor="#f3f8fe">
								<TD align="right"><FONT face="宋体">备注：</FONT></TD>
								<td colspan="3">
									<asp:TextBox id="Remark" runat="server" Width="100%" Height="108px" TextMode="MultiLine"></asp:TextBox></td>
							</TR>
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
