<%@ Page language="c#" Codebehind="IncomeRoom_gz.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.IncomeRoom_gz" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>真达畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="IncomeRoom.aspx">入库</A>&nbsp;&gt;&gt; 
									审批跟踪</td>
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
											<td align="right" background="i_blue/third_head_bg.jpg">
												<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/czrz.jpg"></asp:ImageButton>&nbsp;</td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">标题：</FONT></td>
												<td width="35%"><asp:textbox id="title" runat="server"  Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体"><FONT face="宋体">进货仓</FONT>：</FONT></td>
												<td width="35%">
													<asp:textbox id="Storeroom" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体"><FONT face="宋体">工作流名称</FONT>：</FONT></td>
												<td width="35%"><asp:textbox id="StreamName" runat="server"  Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体"><FONT face="宋体">状态</FONT>：</FONT></td>
												<td width="35%"><asp:textbox id="State" runat="server"  Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">工作流节点名称：</FONT></td>
												<td width="35%"><asp:textbox id="Gname" runat="server"  Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体"><FONT face="宋体">当前审批人</FONT>：</FONT></td>
												<td width="35%">
													<asp:textbox id="Grealname" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">审核批注：</FONT></td>
												<td width="85%" colspan="3"><asp:textbox id="Sreakmart" runat="server"  Width="100%" TextMode="MultiLine"
														Height="92px"></asp:textbox></td>
												<asp:textbox id="Textbox2" runat="server" Width="100%" ></asp:textbox>
								</td>
							</tr>
							<tr bgColor="#f3f8fe">
								<td align="center" colSpan="4"><asp:label id="Label1" runat="server">Label</asp:label></td>
							</tr>
						</table>
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td background="i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"></td>
											<td width="52%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<asp:textbox id="KeyFile" style="DISPLAY: none" runat="server" ></asp:textbox>
			<asp:TextBox id="Number" runat="server"  Visible="False"></asp:TextBox>
			<asp:TextBox id="StreamNumber" runat="server"  Visible="False"></asp:TextBox>
			<asp:TextBox id="Gusername" runat="server"  Visible="False"></asp:TextBox></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE>
		</form>
	</body>
</HTML>
