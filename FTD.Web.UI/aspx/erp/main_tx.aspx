<%@ Page language="c#" Codebehind="main_tx.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.main_tx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>好帮手进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table id="Table2" height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><FONT face="宋体">工作平台友情提醒</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<table id="Table3" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td vAlign="top" width="95%">
						<table id="Table4" cellSpacing="1" cellPadding="0" width="100%" bgColor="#7d9db4" border="0">
							<tr>
								<td vAlign="top" bgColor="#f3f8fe">
									<table id="Table5" height="26" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
										</tr>
									</table>
									<table id="Table6" cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<asp:Label id="Label1" runat="server"></asp:Label>
										<asp:Label id="Label2" runat="server"></asp:Label>
										<asp:Label id="Label6" runat="server"></asp:Label>
										<asp:Label id="Label7" runat="server"></asp:Label>
										<asp:Label id="Label8" runat="server"></asp:Label>
										<asp:Label id="Label3" runat="server"></asp:Label>
										<asp:Label id="Label4" runat="server"></asp:Label>
										<asp:Label id="Label5" runat="server"></asp:Label>
										<asp:Label id="Label9" runat="server"></asp:Label>
										<asp:Label id="Label10" runat="server"></asp:Label>
										<asp:Label id="Label11" runat="server"></asp:Label>
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="center"><FONT face="宋体" color="#ff0000">此窗口将与<asp:TextBox id="btnSubmit" runat="server"  Width="15px" BackColor="#F3F8FE" CssClass="textbox"></asp:TextBox>秒后自动关闭</FONT></td>
												<SCRIPT language="javascript" type="text/javascript">
						<!--
							var secs = 60;
							var wait = secs * 1000;
							document.Form1.btnSubmit.value = "" + secs + "";
							//document.Form1.btnSubmit.disabled = true;
							for(i = 1; i <= secs; i++)
							{
								window.setTimeout("Update(" + i + ")", i * 1000);
							}
							window.setTimeout("Timer()", wait);
							
							function Update(num, value)
							{
								if(num == (wait/1000))
								{
									document.Form1.btnSubmit.value = "";
								}
								else
								{
									printnr = (wait / 1000) - num;
									document.Form1.btnSubmit.value = "" + printnr + "";
								}
							}
							
							function Timer()
							{
							//	document.Form1.btnSubmit.disabled = false;
								document.Form1.btnSubmit.value = "0";
							}
						-->
												</SCRIPT>
											</tr>
								</td>
							</tr>
						</table>
						<TABLE id="Table7" height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<TR>
								<td background="i_blue/third_head_bg1.jpg">
									<table id="Table8" cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"></td>
											<td width="52%"></td>
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
			</TR></TBODY></TABLE>
		</form>
	</body>
</HTML>
