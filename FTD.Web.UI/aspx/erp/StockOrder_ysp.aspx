<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<%@ Page language="c#" Codebehind="StockOrder_ysp.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.StockOrder_ysp" %>
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
										我审批的采购订单</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 87px"><FONT face="宋体">标题关键字：</FONT></TD>
						<TD style="WIDTH: 130px"><asp:textbox id="tilte" runat="server" Width="120px"></asp:textbox></TD>
						<TD><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/search.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>&nbsp;<FONT face="宋体">
								<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/chakan.jpg"></asp:ImageButton>&nbsp;
								<asp:ImageButton id="ImageButton5" runat="server" ImageUrl="i_blue/shanchu.jpg"></asp:ImageButton>&nbsp;<FONT face="Verdana">
								</FONT>
								<asp:imagebutton id="Imagebutton4" runat="server" ImageUrl="i_blue/wsp.jpg"></asp:imagebutton>&nbsp;
								<asp:imagebutton id="Imagebutton9" runat="server" ImageUrl="i_blue/ysp.jpg"></asp:imagebutton>&nbsp;</FONT><asp:imagebutton id="ImageButton3" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></TD>
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
									<div class="mainDiv"><asp:datagrid id="Datagrid2" runat="server" Width="100%" AllowPaging="True" BorderWidth="1px"
											OnPageIndexChanged="MyDataGrid_Page_1" PageSize="12" CellPadding="3" BorderColor="#4D77B1" AutoGenerateColumns="False"
											BackColor="White" GridLines="Vertical" BorderStyle="None">
											<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
											<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
											<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
											<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
											<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
											<Columns>
												<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
												<asp:BoundColumn DataField="title" SortExpression="title" HeaderText="标题">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Type" SortExpression="StartTime" HeaderText="订单类型">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="QdTime" SortExpression="EndTime" HeaderText="签订日期" DataFormatString="{0:yyyy-M-dd}">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="OrderAdd" SortExpression="Type" HeaderText="订单签订地点">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="CompanyName" SortExpression="CompanyName" HeaderText="供应商名称">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="StockPeoName" SortExpression="StockPeoName" HeaderText="采购员姓名">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="AllMoney" SortExpression="AllMoney" HeaderText="总金额">
													<HeaderStyle Wrap="False"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Ifopen" HeaderText="共享">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="State" SortExpression="State" HeaderText="状态">
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
