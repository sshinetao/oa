<%@ Page language="c#" Codebehind="Db_Stream.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.Db_Stream" %>
<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
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
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><img src="i_blue/m_head_1.jpg" width="20" height="34"></td>
					<td width="748" background="i_blue/m_head_3.jpg"><table width="92%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="97%"><FONT color="#ffffff"><a href="main_1.aspx" class="line_b">工作台</a>&nbsp;&gt;&gt; 
										调拨审批流程&nbsp; &gt;&gt;&nbsp; 工作流名称</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><img src="i_blue/m_head_2.jpg" width="21" height="34"></td>
				</tr>
			</table>
			<table height="30" cellSpacing="0" cellPadding="0" width="98%" border="0" align="center">
				<tr>
					<td vAlign="middle" width="90%"><FONT face="宋体">
							<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/insert.jpg"></asp:ImageButton>&nbsp;<asp:ImageButton id="ImageButton4" runat="server" ImageUrl="i_blue/xiugai.jpg"></asp:ImageButton>&nbsp;<asp:ImageButton id="ImageButton2" runat="server" ImageUrl="i_blue/shanchu.jpg"></asp:ImageButton>&nbsp;
							<asp:ImageButton id="ImageButton5" runat="server" ImageUrl="i_blue/shezhiliucheng.jpg"></asp:ImageButton>&nbsp;<asp:ImageButton id="ImageButton3" runat="server" ImageUrl="i_blue/back.jpg"></asp:ImageButton></FONT></td>
				</tr>
			</table>
			<TABLE WIDTH="300" HEIGHT="5" BORDER="0" CELLSPACING="0" CELLPADDING="0">
				<TR>
					<TD></TD>
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
										BackColor="White" GridLines="Vertical" BorderStyle="None">
										<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
										<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
										<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
										<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
											<asp:BoundColumn DataField="Number" SortExpression="Number" HeaderText="工作流编号"></asp:BoundColumn>
											<asp:BoundColumn DataField="Name" SortExpression="Name" HeaderText="工作流名称"></asp:BoundColumn>
										</Columns>
										<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
											BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
									<uc1:fenye id="Fenye1" runat="server"></uc1:fenye>
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
