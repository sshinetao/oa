<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<%@ Page language="c#" Codebehind="StockPlan.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.StockPlan" %>
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
	
		  function wb()
		  {
			    if (!confirm("是否确定把状态更改为[执行完毕]？"))
			    return false;
		  }	
		  function tz()
		  {
			    if (!confirm("是否确定把状态更改为[强制停止]？"))
			    return false;
		  }
		  function zf()
		  {
			    if (!confirm("是否确定把状态更改为[作废]？"))
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
										生产计划</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 101px"><FONT face="宋体">标题关键字：</FONT></TD>
                        <td style="WIDTH: 143px">
                            <asp:DropDownList runat="server" ID="selectList">
                                <asp:ListItem Value="tilte">计划标题</asp:ListItem>
                                <asp:ListItem Value="StartTime">制定时间</asp:ListItem>
                                <asp:ListItem Value="EndTime">实施时间</asp:ListItem>
                                <asp:ListItem Value="Unit">制定人</asp:ListItem>
                            </asp:DropDownList></td>
						<TD style="WIDTH: 157px"><asp:TextBox id="tilte" runat="server"></asp:TextBox></TD>
						<TD>
							<asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/search.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>
							<asp:imagebutton id="Imagebutton1" runat="server" ImageUrl="i_blue/insert.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;
								<asp:imagebutton id="Imagebutton9" runat="server" ImageUrl="i_blue/chakan.jpg"></asp:imagebutton>&nbsp;</FONT>
							<asp:imagebutton id="Imagebutton4" runat="server" ImageUrl="i_blue/xiugai.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>
							<asp:imagebutton id="Imagebutton5" runat="server" ImageUrl="i_blue/shanchu.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;
								<asp:imagebutton id="Imagebutton6" runat="server" ImageUrl="i_blue/wanbi.jpg"></asp:imagebutton>&nbsp;
								<asp:imagebutton id="Imagebutton7" runat="server" ImageUrl="i_blue/tingzhi.jpg"></asp:imagebutton>&nbsp;
								<asp:imagebutton id="Imagebutton8" runat="server" ImageUrl="i_blue/zuofei.jpg"></asp:imagebutton>&nbsp;</FONT><asp:imagebutton id="ImageButton3" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></TD>
					</TR>
				</TBODY>
			</TABLE>
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
												<asp:BoundColumn DataField="tilte" SortExpression="tilte" HeaderText="计划标题">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="StartTime" SortExpression="StartTime" HeaderText="制定时间">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="EndTime" SortExpression="EndTime" HeaderText="实施时间">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												
												
												<asp:BoundColumn DataField="Unit" SortExpression="Unit" HeaderText="制定人">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn Visible="False" DataField="number"></asp:BoundColumn>
												
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
