<%@ Page language="c#" Codebehind="Username_add.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.Username_add" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
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
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="Username.aspx">用户设置</A>&nbsp;&gt;&gt; 
									新增用户</td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<table height="450" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td vAlign="top" width="95%">
						<table cellSpacing="1" cellPadding="0" width="100%" bgColor="#7d9db4" border="0">
							<tr>
								<td vAlign="top" bgColor="#f3f8fe">
									<table height="26" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">用户名：</FONT></td>
												<td width="35%"><asp:textbox id="Username" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">用户姓名：</FONT></td>
												<td width="35%"><asp:textbox id="Realname" runat="server" Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">用户密码：</FONT></td>
												<td><asp:textbox id="Password" runat="server" Width="100%" TextMode="Password"></asp:textbox></td>
												<td align="right"><FONT face="宋体">工号：</FONT></td>
												<td><asp:textbox id="worknum" runat="server" Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">性别：</FONT></td>
												<td><asp:dropdownlist id="Sex" runat="server" Width="100%">
														<asp:ListItem Value="男">男</asp:ListItem>
														<asp:ListItem Value="女">女</asp:ListItem>
													</asp:dropdownlist></td>
												<td align="right">职能机构：</td>
												<td><asp:textbox id="Unit" runat="server" Width="90%" ></asp:textbox><A href="javascript:void(0)"><IMG var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectDanWei.aspx?TableName=ERPBuMen&LieName=BuMenName&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('unit').value=wName;} alt="" src="image/FDJ.gif" border="0"></A></td>
											</tr>
											<TR bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">有效开始日期：</FONT></td>
												<td><asp:textbox id="Firsttime" runat="server" Width="90%" ></asp:textbox>
													<script>SetNeed('Firsttime')</script>
													<A href="javascript:void(0)"><IMG id="Firsttime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
															src="image/FDJ.gif" border="0"></A></FONT></td>
												<TD align="right"><FONT face="宋体">有效结束日期：</FONT></TD>
												<TD><asp:textbox id="Lasttime" runat="server" Width="90%" ></asp:textbox>
													<script>SetNeed('Lasttime')</script>
													<A href="javascript:void(0)"><IMG id="Lasttime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
															src="image/FDJ.gif" border="0"></A></FONT></TD>
											</TR>
											<TR bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">Email：</FONT></td>
												<td><asp:textbox id="Email" runat="server" Width="100%"></asp:textbox></td>
												<TD align="right"><FONT face="宋体">是否允许登陆：</FONT></TD>
												<td><asp:dropdownlist id="Iflogin" runat="server" Width="100%">
														<asp:ListItem Value="是">是</asp:ListItem>
														<asp:ListItem Value="否">否</asp:ListItem>
													</asp:dropdownlist></td>
											</TR>
							</tr>
							<tr bgColor="#f3f8fe">
								<td align="right"><FONT face="宋体">备注：</FONT></td>
								<td colSpan="3"><asp:textbox id="Remark" runat="server" Width="100%" TextMode="MultiLine" Height="108px"></asp:textbox></td>
							</tr>
						</table>
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td background="i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:imagebutton></td>
											<td width="52%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></td>
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
			</TR></TBODY></TABLE></form>
	</body>
</HTML>
