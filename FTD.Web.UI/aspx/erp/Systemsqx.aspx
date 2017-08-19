<%@ Page language="c#" Codebehind="Systemsqx.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.Systemsqx" %>
<%@ Register TagPrefix="xpdragon" Namespace="DragonWebControls" Assembly="DragonControl" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><img src="i_blue/m_head_1.jpg" width="20" height="34"></td>
					<td width="748" background="i_blue/m_head_3.jpg"><table width="92%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="97%"><FONT color="#ffffff"><a href="main_1.aspx" class="line_b">工作台</a>&nbsp;&gt;&gt; 
										用户权限设置</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><img src="i_blue/m_head_2.jpg" width="21" height="34"></td>
				</tr>
			</table>
			<table height="30" cellSpacing="0" cellPadding="0" width="98%" align="center" border="0">
				<tr>
					<td vAlign="middle" width="90%"><FONT face="宋体"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/quanxian.jpg"></asp:imagebutton>&nbsp;<asp:imagebutton id="ImageButton3" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></FONT></td>
				</tr>
			</table>
			<TABLE height="5" cellSpacing="0" cellPadding="0" width="300" border="0">
				<TR>
					<TD><FONT face="宋体"></FONT></TD>
				</TR>
			</TABLE>
			<table width="100%" height="450" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td width="95%" valign="top"><table width="100%" height="135" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td valign="top">
									<asp:datagrid id="Datagrid2" runat="server" AllowPaging="True" BorderWidth="1px" OnPageIndexChanged="MyDataGrid_Page_1"
										PageSize="12" CellPadding="3" BorderColor="#4D77B1" AutoGenerateColumns="False" Width="100%"
										BorderStyle="None" BackColor="White" GridLines="Vertical">
										<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
										<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
										<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
										<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
											<asp:BoundColumn DataField="username" HeaderText="用户名"></asp:BoundColumn>
											<asp:BoundColumn DataField="Realname" HeaderText="用户姓名"></asp:BoundColumn>
											<asp:BoundColumn DataField="Sex" HeaderText="性别"></asp:BoundColumn>
											<asp:BoundColumn DataField="Unit" HeaderText="职能机构"></asp:BoundColumn>
											<asp:BoundColumn DataField="Firsttime" HeaderText="有效开始日期" DataFormatString="{0:yyyy-M-dd}"></asp:BoundColumn>
											<asp:BoundColumn DataField="Lasttime" HeaderText="有效结束日期" DataFormatString="{0:yyyy-M-dd}"></asp:BoundColumn>
											<asp:BoundColumn DataField="Iflogin" HeaderText="是否允许登陆"></asp:BoundColumn>
										</Columns>
										<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
											BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
									<XPDRAGON:GRIDPAGER id="GridPager1" runat="server" Width="100%" PageSize="12" NavigationAction="双击"
										SelectColumnSelectImage="i_blue/Current.gif" SelectColumnImage="i_blue/Select.gif" SelectColumnHeadImage="i_blue/Select.gif"
										DataGrid="Datagrid2" Height="16px" SelectRowColor="Silver" NavigationTerm=" " GridColor="#6595D6"
										AlternatingRowColor="#E6EDF7"></XPDRAGON:GRIDPAGER>
								</td>
							</tr>
						</table>
					</td>
					<td width="15">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
