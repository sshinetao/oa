<%@ Page language="c#" Codebehind="SellOut_ysp_show.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.SellOut_ysp_show" %>
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
		<script>
	   function killErrors() {
		return true;
		}
		window.onerror = killErrors;	
		
	
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<script language="javascript" src="DateSelect.js"></script>
			<table cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table1">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0" id="Table2">
							<tr>
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="SellOut_ysp.aspx">我审批的销售出库</A>&nbsp;&gt;&gt; 
									查看销售出库</td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<table height="450" cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table3">
				<tr>
					<td width="15">&nbsp;</td>
					<td vAlign="top" width="95%">
						<table cellSpacing="1" cellPadding="0" width="100%" bgColor="#7d9db4" border="0" id="Table4">
							<tr>
								<td vAlign="top" bgColor="#f3f8fe">
									<table height="26" cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table5">
										<tr>
											<td background="i_blue/third_head_bg.jpg"><FONT face="宋体"></FONT></td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0" id="Table6">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">标题：</FONT></td>
												<td width="35%"><asp:textbox id="title" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">出货日期：</FONT></td>
												<td width="35%">
													<asp:textbox id="ShTime" runat="server" Width="100%" DataType="DateTime" ></asp:textbox>
													<script>SetNeed('ShTime')</script>
													</FONT>
												</td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">订单类型</td>
												<td width="35%"><asp:textbox id="Type" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">出货仓：</FONT></td>
												<td width="35%"><asp:textbox id="Storeroom" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">客户名称：</FONT></td>
												<td width="35%"><asp:textbox id="CompanyName" runat="server" Width="100%" ></asp:textbox>
												</td>
												<td align="right" width="15%"><FONT face="宋体">客户地址：</FONT></td>
												<td width="35%"><FONT face="宋体">
														<asp:textbox id="CompanyAdd" runat="server" Width="100%" ></asp:textbox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%" style="HEIGHT: 33px"><FONT face="宋体">提货人：</FONT></td>
												<td width="35%" style="HEIGHT: 33px">
													<asp:textbox id="ThPeople" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" style="HEIGHT: 33px"><FONT face="宋体">提货人电话：</FONT></td>
												<td style="HEIGHT: 33px"><asp:textbox id="Tel" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">有效开始时间：</FONT></td>
												<td width="35%"><asp:textbox id="ThStarttime" runat="server" Width="100%"  DataType="DateTime"></asp:textbox>
													<script>SetNeed('ThStarttime')</script>
													</FONT></td>
												<td align="right" width="15%"><FONT face="宋体">有效结束时间：</FONT></td>
												<td width="35%"><asp:textbox id="ThEndtime" runat="server" Width="100%"  DataType="DateTime"></asp:textbox>
													<script>SetNeed('ThEndtime')</script>
													</FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%" style="HEIGHT: 33px"><FONT face="宋体">业务员：</FONT></td>
												<td width="35%" style="HEIGHT: 33px">
													<asp:textbox id="StockPeoName" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" style="HEIGHT: 33px"><FONT face="宋体">运输方式：</FONT></td>
												<td style="HEIGHT: 33px"><asp:textbox id="TrafficType" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">选择审批流程：</FONT></td>
												<td colSpan="3"><asp:textbox id="StreamName" runat="server" Width="100%" ></asp:textbox>
												</td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">填写人：</td>
												<td colspan="3"><FONT face="宋体">
														<asp:TextBox id="realname" runat="server" Width="100%"></asp:TextBox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">备注：</FONT></td>
												<td colSpan="3"><asp:textbox id="Remark" runat="server" Width="100%" TextMode="MultiLine" Height="52px" ></asp:textbox><A href="javascript:void(0)"></A></FONT></td>
											</tr>
											<tr bgcolor="#f3f8fe">
												<td align="right"><FONT face="宋体">审批备注：</FONT></td>
												<td colspan="3">
													<asp:textbox id="Sreakmart" runat="server" Width="100%" Height="108px" TextMode="MultiLine"></asp:textbox><A href="javascript:void(0)"></A></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td width="100%" colSpan="4">
													<div class="mainDiv"><asp:datagrid id="Datagrid2" runat="server" Width="100%" BorderStyle="None" GridLines="Vertical"
															BackColor="White" AutoGenerateColumns="False" BorderColor="#4D77B1" CellPadding="3" PageSize="12" OnPageIndexChanged="MyDataGrid_Page_1"
															BorderWidth="1px" AllowPaging="True">
															<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
															<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
															<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
															<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
															<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
															<Columns>
																<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
																<asp:BoundColumn DataField="GoodsName" SortExpression="GoodsName" HeaderText="商品名称">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="CountUnit" SortExpression="CountUnit" HeaderText="计量单位">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="Model" SortExpression="Model" HeaderText="规格型号">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="StockPoint" SortExpression="StockPoint" HeaderText="销售数量">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="SingleMoney" SortExpression="SingleMoney" HeaderText="单价"></asp:BoundColumn>
																<asp:BoundColumn DataField="Allmoney" SortExpression="Allmoney" HeaderText="销售总金额">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
															</Columns>
															<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
																BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
														</asp:datagrid></div>
													<uc1:fenye id="Fenye1" runat="server"></uc1:fenye></td>
											</tr>
							</tr>
						</table>
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table7">
							<tr>
								<td background="i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0" id="Table8">
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
			<asp:textbox id="number" runat="server"  style="DISPLAY: none"></asp:textbox></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE>
			<asp:TextBox id="Grealname" runat="server"  Width="100%" style="DISPLAY: none"></asp:TextBox></FONT>
			<asp:TextBox id="Gname" runat="server"  Width="100%" style="DISPLAY: none"></asp:TextBox>
			<asp:TextBox id="Gusername" runat="server"  Visible="False"></asp:TextBox><FONT face="宋体">
				<asp:TextBox id="Name" runat="server" style="DISPLAY: none"></asp:TextBox>
				<asp:TextBox id="username" runat="server" style="DISPLAY: none"></asp:TextBox>
				<asp:textbox id="CompanyNumber" runat="server" style="DISPLAY: none"></asp:textbox><asp:textbox id="StockPeoNum" runat="server" style="DISPLAY: none"></asp:textbox><asp:textbox id="StreamNumber" runat="server"  style="DISPLAY: none"></asp:textbox>
		</form>
		</FONT>
	</body>
</HTML>
