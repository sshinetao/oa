<%@ Page language="c#" Codebehind="main_link.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.main_link" %>
<%@ Register TagPrefix="xpdragon" Namespace="DragonWebControls" Assembly="DragonControl" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<META http-equiv="Pragma" content="no-cache">
		<META http-equiv="Cache-Control" content="no-cache">
		<META http-equiv="Expires" content="0">
		<SCRIPT language="javascript">
		  function del()
		  {
			    if (!confirm("是否确定删除？"))
			    return false;
		  }
		
		</SCRIPT>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td width="97%"><FONT color="#ffffff"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt; 
										界面快捷方式</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<table height="30" cellSpacing="0" cellPadding="0" width="98%" border="0" align="center">
				<tr>
					<td vAlign="middle" width="90%"><FONT face="宋体">
							<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/insert.jpg"></asp:ImageButton>
							<asp:ImageButton id="ImageButton2" runat="server" ImageUrl="i_blue/shanchu.jpg"></asp:ImageButton>
							<asp:ImageButton id="ImageButton3" runat="server" ImageUrl="i_blue/back.jpg"></asp:ImageButton></FONT></td>
				</tr>
			</table>
			<TABLE WIDTH="300" HEIGHT="5" BORDER="0" CELLSPACING="0" CELLPADDING="0">
				<TR>
					<TD></TD>
				</TR>
			</TABLE>
			<table height="450" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td vAlign="top" width="95%">
						<table height="135" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td vAlign="top"><asp:datagrid id="DataGrid1" runat="server" GridLines="Vertical" BackColor="White" Width="100%"
										AutoGenerateColumns="False" BorderColor="#6595D6" CellPadding="3" BorderWidth="1px" AllowPaging="True"
										AllowSorting="True" PageSize="12" BorderStyle="None">
										<SelectedItemStyle Font-Bold="True" ForeColor="White"></SelectedItemStyle>
										<ItemStyle ForeColor="Black"></ItemStyle>
										<HeaderStyle Font-Underline="True" Font-Bold="True" HorizontalAlign="Center" ForeColor="Black"
											VerticalAlign="Middle" BackColor="#AECADF"></HeaderStyle>
										<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
										<Columns>
											<asp:ButtonColumn Text="&lt;Img src='i_blue/Select.gif' style='BORDER-STYLE:none'&gt;" HeaderImageUrl="i_blue/Select.gif"
												CommandName="Select">
												<HeaderStyle HorizontalAlign="Center" Width="45px"></HeaderStyle>
											</asp:ButtonColumn>
											<asp:BoundColumn Visible="False" DataField="id" SortExpression="id"></asp:BoundColumn>
											<asp:BoundColumn DataField="Name" SortExpression="Name" HeaderText="名称"></asp:BoundColumn>
											<asp:BoundColumn DataField="Tbyte" SortExpression="Tbyte" HeaderText="所占字符数"></asp:BoundColumn>
										</Columns>
										<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
											BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
									<XPDRAGON:GRIDPAGER id="GridPager1" runat="server" PageSize="12" Width="100%" NavigationAction="双击"
										SelectColumnSelectImage="i_blue/Current.gif" SelectColumnImage="i_blue/Select.gif" SelectColumnHeadImage="i_blue/Select.gif"
										DataGrid="DataGrid1" Height="16px" SelectRowColor="Silver" NavigationTerm=" " GridColor="#6595D6"
										AlternatingRowColor="#E6EDF7"></XPDRAGON:GRIDPAGER></td>
							</tr>
						</table>
					</td>
					<td width="15">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
