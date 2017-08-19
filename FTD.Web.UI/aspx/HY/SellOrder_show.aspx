﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellOrder_show.aspx.cs" Inherits="FTD.Web.UI.aspx.HY.SellOrder_show" %>
<%@ Register TagPrefix="uc1" TagName="fenye" Src="../erp/fenye.ascx" %>
<!DOCTYPE html>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../erp/i_blue/ny.css" type="text/css" rel="stylesheet">
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
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="../erp/i_blue/m_head_3.jpg"><IMG height="34" src="../erp/i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="../erp/i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="SellOrder.aspx">销售订单</A>&nbsp;&gt;&gt; 
									查看销售订单</td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="../erp/i_blue/m_head_2.jpg" width="21"></td>
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
											<td background="../erp/i_blue/third_head_bg.jpg">&nbsp;</td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">客户名称：</td>
												<td width="35%"><asp:textbox id="CompanyName" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right">客户地址：</td>
												<td><asp:textbox id="CompanyAdd" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">电话：</td>
												<td width="35%"><asp:textbox id="Tel" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%">发货日期：</td>
												<td width="35%"><asp:textbox id="ShTime" runat="server" Width="100%"  DataType="DateTime"></asp:textbox>
													</td>
											</tr>
											
										
										
											<tr bgColor="#f3f8fe">
												
												<td align="right">业务员姓名：</td>
												<td colspan="3" ><asp:textbox id="StockPeoName" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">折扣率：</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Discount" ondragenter="return false" style="IME-MODE: disabled" onmouseout="selstr()" runat="server"
														Width="100%" >0</asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">总金额(未打折)：</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="AllMoney" ondragenter="return false" style="IME-MODE: disabled" onmouseout="selstr()" runat="server"
														Width="100%" >0</asp:textbox></td>
											</tr>
											
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">订单备注：</FONT></td>
												<td colSpan="3"><asp:textbox id="Remark" runat="server" Width="100%" TextMode="MultiLine" Height="52px" ></asp:textbox><A href="javascript:void(0)"></A></FONT></td>
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
														
																<asp:BoundColumn DataField="StockPoint" SortExpression="StockPoint" HeaderText="采购数量">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="SingleMoney" SortExpression="SingleMoney" HeaderText="单价"></asp:BoundColumn>
																<asp:BoundColumn DataField="Allmoney" SortExpression="Allmoney" HeaderText="采购总金额">
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
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td background="../erp/i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"><FONT face="宋体"></FONT></td>
											<td width="52%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="../erp/i_blue/back.jpg" OnClick="ImageButton2_Click1"></asp:imagebutton></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<asp:textbox id="number" style="DISPLAY: none" runat="server" ></asp:textbox></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE><asp:textbox id="CompanyNumber" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StockPeoNum" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StreamNumber" style="DISPLAY: none" runat="server" ></asp:textbox>
		</form>
	</body>
</HTML>
