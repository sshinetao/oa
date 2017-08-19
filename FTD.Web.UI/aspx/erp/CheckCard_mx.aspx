<%@ Page language="c#" Codebehind="CheckCard_mx.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.CheckCard_mx" %>
<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
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
	   function killErrors() {
		return true;
		}
		window.onerror = killErrors;			
		
		
		  function del()
		  {
			    if (!confirm("是否确定删除？"))
			    return false;
		  }
		
		</SCRIPT>
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
								<td width="97%"><FONT color="#ffffff"><A class="line_b" href="main_1.aspx">工作台</A> &nbsp;&gt;&gt; 
										库房盘点 &gt;&gt; 盘点明细</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<table height="30" cellSpacing="0" cellPadding="0" width="98%" align="center" border="0">
				<tr>
					<TD style="WIDTH: 45px"><FONT face="宋体">货物：</FONT></TD>
					<TD style="WIDTH: 88px"><asp:textbox id="GoodsName" runat="server" Width="80px"></asp:textbox></TD>
					<TD style="WIDTH: 45px"><FONT face="宋体">库房：</FONT></TD>
					<TD style="WIDTH: 70px"><asp:textbox id="Storeroom" runat="server" Width="60px"></asp:textbox></TD>
					<TD style="WIDTH: 50px"><FONT face="宋体">盘点人：</FONT></TD>
					<TD style="WIDTH: 65px"><asp:textbox id="Realname" runat="server" Width="60px"></asp:textbox></TD>
					<TD style="WIDTH: 38px"><FONT face="宋体">类型：</FONT></TD>
					<TD style="WIDTH: 59px">
						<asp:DropDownList id="leixing" runat="server">
							<asp:ListItem Value="----">----</asp:ListItem>
							<asp:ListItem Value="&lt;0">盘亏</asp:ListItem>
							<asp:ListItem Value="&gt;=0">盘盈</asp:ListItem>
						</asp:DropDownList></TD>
					<TD style="WIDTH: 40px"><FONT face="宋体">日期：</FONT></TD>
					<TD style="WIDTH: 133px"><asp:textbox id="Nowtimes" runat="server" Width="80px" ></asp:textbox>
						<script>SetNeed('Nowtimes')</script>
						<A href="javascript:void(0)"><IMG id="Nowtimes_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
								src="image/FDJ.gif" border="0"></A>
					</TD>
					<td vAlign="middle">
						<P>
							<asp:imagebutton id="Imagebutton8" runat="server" ImageUrl="i_blue/search.jpg"></asp:imagebutton>&nbsp;
							<asp:imagebutton id="Imagebutton1" runat="server" ImageUrl="i_blue/huowuliebiao.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT><asp:imagebutton id="ImageButton3" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></P>
					</td>
				</tr>
			</table>
			<TABLE height="5" cellSpacing="0" cellPadding="0" width="300" border="0">
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
								<td vAlign="top">
									<div class="mainDiv">
										<asp:datagrid id="Datagrid2" runat="server" BorderStyle="None" GridLines="Vertical" BackColor="White"
											Width="100%" AutoGenerateColumns="False" BorderColor="#4D77B1" CellPadding="3" PageSize="12"
											OnPageIndexChanged="MyDataGrid_Page_1" BorderWidth="1px" AllowPaging="True">
											<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
											<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
											<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
											<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
											<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
											<Columns>
												<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
												<asp:BoundColumn DataField="GoodsName" SortExpression="GoodsName" HeaderText="名称">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Storeroom" SortExpression="Storeroom" HeaderText="库房">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="AccountPoint" SortExpression="AccountPoint" HeaderText="账面数">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="FactPoint" SortExpression="FactPoint" HeaderText="实盘数">
													<HeaderStyle Wrap="False"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Difference" SortExpression="Difference" HeaderText="差异数量">
													<HeaderStyle Wrap="False"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="CountUnit" SortExpression="CountUnit" HeaderText="计量单位">
													<HeaderStyle Wrap="False"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Model" SortExpression="Model" HeaderText="规格型号">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Realname" SortExpression="Realname" HeaderText="盘点人">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
											</Columns>
											<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
												BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
										</asp:datagrid></div>
									<uc1:fenye id="Fenye1" runat="server"></uc1:fenye></td>
							</tr>
						</table>
					</td>
					<td width="15">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
