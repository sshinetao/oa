<%@ Page language="c#" Codebehind="SystemLog_search.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.SystemLog_search" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<META HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<META HTTP-EQUIV="Cache-Control" CONTENT="no-cache">
		<META HTTP-EQUIV="Expires" CONTENT="0">
		<script>
	   function killErrors() {
		return true;
		}
			window.onerror = killErrors;	
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<script language='javascript' src='DateSelect.js'></script>
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="SystemLog.aspx">系统日志</A>&nbsp;&gt;&gt; 
									查询系统日志</td>
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
												<td align="right" width="15%"><FONT face="宋体">内容：</FONT></td>
												<td width="35%"><asp:textbox id="Name" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">模块名：</FONT></td>
												<td width="35%">
													<asp:TextBox id="MkName" runat="server" Width="100%"></asp:TextBox>
												</td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">操作人：</FONT></td>
												<td width="35%"><asp:textbox id="Realname" runat="server" Width="90%" ></asp:textbox><A href="javascript:void(0)"><IMG onclick="JusOpen()" src="image/FDJ.gif" border="0"></A></td>
												<td align="right" width="15%"><FONT face="宋体">录入时间：</FONT></td>
												<td width="35%">
													<asp:TextBox id="Nowtimes" runat="server" Width="85%" ></asp:TextBox>
													<script>SetNeed('Nowtimes')</script>
													<A href="javascript:void(0)"><IMG id="Nowtimes_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
															src="image/FDJ.gif" border="0"></A>
												</td>
											</tr>
							</tr>
						</table>
						<TABLE height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<td background="i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:imagebutton></td>
											<td width="52%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></td>
										</tr>
									</table>
								</td>
							</TR>
						</TABLE>
					</td>
				</tr>
			</table>
			</TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE><asp:textbox id="Username" runat="server"  style="DISPLAY: none"></asp:textbox>
			<script language="javascript">	

var wName_4;
        function  JusOpen()  
            {  
            var num=Math.random();
                wName_4=window.showModalDialog("username_open.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
         
                
var arr = wName_4.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("Realname").value=arr[0]; 
document.getElementById("Username").value=arr[1]; 
}


}
			</script>
		</form>
	</body>
</HTML>
