<%@ Register TagPrefix="xpdragon" Namespace="DragonWebControls" Assembly="DragonControl" %>
<%@ Page language="c#" Codebehind="SystemLog_search_for.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.SystemLog_search_for" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="SystemLog.aspx">系统日志</A>&nbsp;&gt;&gt; 
									查询系统日志 &gt;&gt; 查询结果</td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<table height="30" cellSpacing="0" cellPadding="0" width="98%" align="center" border="0">
				<tr>
					<td vAlign="middle" width="90%"><FONT face="宋体"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/gjcx.jpg"></asp:imagebutton>&nbsp;<asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/shanchu.jpg"></asp:imagebutton>&nbsp;<asp:imagebutton id="Imagebutton4" runat="server" ImageUrl="i_blue/shanchuquanbu.jpg"></asp:imagebutton>&nbsp;<asp:imagebutton id="ImageButton3" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></FONT></td>
				</tr>
			</table>
			<TABLE height="5" cellSpacing="0" cellPadding="0" width="300" border="0">
				<TR>
					<TD><FONT face="宋体"></FONT></TD>
				</TR>
			</TABLE>
			<table height="450" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td vAlign="top" width="95%">
						<table height="135" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td vAlign="top"><asp:datagrid id="Datagrid2" runat="server" BorderWidth="2px" GridLines="Vertical" BackColor="White"
										BorderStyle="None" Width="100%" AutoGenerateColumns="False" BorderColor="#6595D6" CellPadding="3" PageSize="12"
										OnPageIndexChanged="MyDataGrid_Page_1" AllowPaging="True" AllowSorting="True">
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
											<asp:BoundColumn DataField="Name" SortExpression="Name" HeaderText="内容"></asp:BoundColumn>
											<asp:BoundColumn DataField="MkName" SortExpression="MkName" HeaderText="操作模块"></asp:BoundColumn>
											<asp:BoundColumn DataField="Username" SortExpression="Username" HeaderText="操作人用户名"></asp:BoundColumn>
											<asp:BoundColumn DataField="Realname" SortExpression="Realname" HeaderText="操作人姓名"></asp:BoundColumn>
											<asp:BoundColumn DataField="Nowtimes" SortExpression="Nowtimes" HeaderText="操作时间"></asp:BoundColumn>
										</Columns>
										<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
											BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
									</asp:datagrid><XPDRAGON:GRIDPAGER id="GridPager1" runat="server" Width="100%" PageSize="12" NavigationAction="双击"
										SelectColumnSelectImage="i_blue/Current.gif" SelectColumnImage="i_blue/Select.gif" SelectColumnHeadImage="i_blue/Select.gif"
										DataGrid="Datagrid2" Height="16px" SelectRowColor="Silver" NavigationTerm=" " GridColor="#6595D6" AlternatingRowColor="#E6EDF7"></XPDRAGON:GRIDPAGER></td>
							</tr>
						</table>
					</td>
					<td width="15">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
