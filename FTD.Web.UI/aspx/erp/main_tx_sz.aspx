<%@ Page language="c#" Codebehind="main_tx_sz.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.main_tx_sz" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<META http-equiv="Pragma" content="no-cache">
		<META http-equiv="Cache-Control" content="no-cache">
		<META http-equiv="Expires" content="0">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A> &nbsp;&gt;&gt;&nbsp;提醒间歇设置</td>
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
												<td align="right" width="15%"><FONT face="宋体">是否需要提醒：</FONT></td>
												<td width="35%">
													<asp:DropDownList id="iftx" runat="server" Width="100%">
														<asp:ListItem Value="需要">需要</asp:ListItem>
														<asp:ListItem Value="不需要">不需要</asp:ListItem>
													</asp:DropDownList></td>
												<td align="right" width="15%"><FONT face="宋体">提醒间歇设置：</FONT></td>
												<td width="35%"><FONT face="宋体">
														<asp:DropDownList id="txtime" runat="server" Width="100%">
															<asp:ListItem Value="300000">5分钟</asp:ListItem>
															<asp:ListItem Value="600000">10分钟</asp:ListItem>
															<asp:ListItem Value="900000">15分钟</asp:ListItem>
															<asp:ListItem Value="1200000">20分钟</asp:ListItem>
															<asp:ListItem Value="1500000">25分钟</asp:ListItem>
															<asp:ListItem Value="1800000">30分钟</asp:ListItem>
															<asp:ListItem Value="3600000">60分钟</asp:ListItem>
															<asp:ListItem Value="5400000">90分钟</asp:ListItem>
															<asp:ListItem Value="7200000">120分钟</asp:ListItem>
														</asp:DropDownList></FONT></td>
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
			</TR></TBODY></TABLE><asp:textbox id="Username" style="DISPLAY: none" runat="server" ></asp:textbox></form>
	</body>
</HTML>
