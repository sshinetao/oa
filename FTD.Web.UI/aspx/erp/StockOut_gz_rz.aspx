<%@ Page language="c#" Codebehind="StockOut_gz_rz.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.StockOut_gz_rz" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>真达畲森山进销存</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<META HTTP-EQUIV="Pragma" CONTENT="no-cache">
		<META HTTP-EQUIV="Cache-Control" CONTENT="no-cache">
		<META HTTP-EQUIV="Expires" CONTENT="0">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><img src="i_blue/m_head_1.jpg" width="20" height="34"></td>
					<td width="748" background="i_blue/m_head_3.jpg"><table width="92%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="97%"><FONT color="#ffffff"><a href="main_1.aspx" class="line_b">工作台</a>&nbsp;&gt;&gt;
										<a href="StockOut.aspx" class="line_b">采购退货</a>&nbsp;&gt;&gt; 操作日志</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><img src="i_blue/m_head_2.jpg" width="21" height="34"></td>
				</tr>
			</table>
			<table width="100%" height="30" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="85%">&nbsp;</td>
					<td width="15%" valign="middle">&nbsp;&nbsp;&nbsp;
						<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/back.jpg"></asp:ImageButton>&nbsp;
						<a href="JavaScript:history.go(-1)"></a>
					</td>
				</tr>
			</table>
			<table width="100%" height="450" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td width="95%" valign="top"><table width="100%" height="135" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td valign="top">
									<asp:datagrid id="Datagrid2" runat="server" AllowPaging="True" BorderWidth="1px" OnPageIndexChanged="MyDataGrid_Page_1"
										PageSize="12" CellPadding="3" BorderColor="#4D77B1" AutoGenerateColumns="False" Width="100%"
										BackColor="White" GridLines="Vertical">
										<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
										<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
										<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
										<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
											<asp:BoundColumn DataField="title" HeaderText="标题"></asp:BoundColumn>
											<asp:BoundColumn DataField="settime" HeaderText="操作时间"></asp:BoundColumn>
										</Columns>
										<PagerStyle NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
											BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
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
