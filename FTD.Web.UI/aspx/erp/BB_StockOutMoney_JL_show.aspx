<%@ Page language="c#" Codebehind="BB_StockOutMoney_JL_show.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.BB_StockOutMoney_JL_show" %>
<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>�ɭɽ������</title>
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
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><IMG height="34" src="i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td width="97%"><FONT color="#ffffff"><A class="line_b" href="main_1.aspx">����̨</A>&nbsp;&gt;&gt; 
										Ӧ����� &gt;&gt; �������¼��ʾ &gt;&gt; �鿴����</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
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
											<td background="i_blue/third_head_bg.jpg">&nbsp;
												<asp:TextBox id="JbPeoNum" runat="server"  style="DISPLAY: none"></asp:TextBox>
												<asp:TextBox id="StreamNumber" runat="server" style="DISPLAY: none"></asp:TextBox></td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�������⣺</FONT></td>
												<td width="35%"><asp:textbox id="title" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">��Ӧ�����ƣ�</FONT></td>
												<td width="35%"><asp:textbox id="CompanyName" runat="server" Width="100%" ></asp:textbox><A href="javascript:void(0)"></A></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">�Ѹ���</td>
												<td><asp:textbox id="YfMoney" runat="server" Width="100%" ></asp:textbox><A href="javascript:void(0)"></A></td>
												<td align="right"><FONT face="����">��ǰ״̬��</FONT></td>
												<td>
													<asp:textbox id="State" runat="server"  Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">���ʽ��</td>
												<td><asp:textbox id="IncomeSet" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right"><FONT face="����">�����</FONT></td>
												<td>
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="FkMoney" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
														onmouseout="selstr()" >0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">�������ڣ�</td>
												<td>
													<asp:textbox id="Outtime" runat="server" Width="100%" ></asp:textbox>
													<script>SetNeed('Outtime')</script>
													</FONT>
												</td>
												<td align="right"><FONT face="����">ʣ���</FONT></td>
												<td>
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="SyMoney" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
														 onclick="selstr(this,this);return false"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">��Ʊ�ţ�</td>
												<td><asp:textbox id="InvoiceType" runat="server" Width="100%" ></asp:textbox><A href="javascript:void(0)"></A></td>
												<td align="right"><FONT face="����">�����ˣ�</FONT></td>
												<td>
													<asp:textbox id="JbName" runat="server" Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="����">ѡ���������̣�</FONT></td>
												<td colSpan="3"><asp:textbox id="StreamName" runat="server" Width="100%" ></asp:textbox>
												</td>
											</tr>
										</TBODY>
									</table>
									<hr>
									<div align="center"><STRONG>������ϸ</STRONG></div>
									<hr>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�������ͣ�</FONT></td>
												<td width="35%"><asp:textbox id="Type" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">�����ڲ��룺</FONT></td>
												<td width="35%"><FONT face="����"><asp:textbox id="NbNumber" runat="server" Width="100%" ></asp:textbox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">ǩ�����ڣ�</FONT></td>
												<td width="35%"><asp:textbox id="QdTime" runat="server" Width="100%" ></asp:textbox>
													<script>SetNeed('QdTime')</script>
													</FONT><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="����">����ǩ���ص㣺</FONT></td>
												<td width="35%"><asp:textbox id="OrderAdd" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�������еص㣺</FONT></td>
												<td width="35%"><asp:textbox id="LxAdd" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">�����֣�</FONT></td>
												<td width="35%"><asp:textbox id="Storeroom" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�ջ����ڣ�</FONT></td>
												<td width="35%"><asp:textbox id="ShTime" runat="server" Width="100%"  DataType="DateTime"></asp:textbox>
													<script>SetNeed('ShTime')</script>
													</FONT><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="����">���ţ�</FONT></td>
												<td width="35%"><asp:textbox id="Unit" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">��Ӧ�̵�ַ��</FONT></td>
												<td width="35%"><asp:textbox id="CompanyAdd" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right">����ܼƣ�</td>
												<td><asp:textbox id="AllMoney" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">�ɹ�Ա������</td>
												<td><asp:textbox id="StockPeoName" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right"><FONT face="����">¼���ˣ�</FONT></td>
												<td>
													<asp:textbox id="realname" runat="server"  Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="����">ѡ���������̣�</FONT></td>
												<td colSpan="3"><asp:textbox id="CgStreamName" runat="server" Width="100%" ></asp:textbox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="����">������ע��</FONT></td>
												<td colSpan="3"><asp:textbox id="OrderRemark" runat="server" Width="100%"  Height="52px" TextMode="MultiLine"></asp:textbox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td width="100%" colSpan="4">
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
																<asp:BoundColumn DataField="GoodsName" SortExpression="GoodsName" HeaderText="��Ʒ����">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="CountUnit" SortExpression="CountUnit" HeaderText="������λ">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="Model" SortExpression="Model" HeaderText="����ͺ�">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="StockPoint" SortExpression="StockPoint" HeaderText="�ɹ�����">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="SingleMoney" SortExpression="SingleMoney" HeaderText="����"></asp:BoundColumn>
																<asp:BoundColumn DataField="Allmoney" SortExpression="Allmoney" HeaderText="�ɹ��ܽ��">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="Stocktype" SortExpression="Stocktype" HeaderText="������ʽ"></asp:BoundColumn>
															</Columns>
															<PagerStyle Visible="False" NextPageText="��һҳ" PrevPageText="��һҳ" HorizontalAlign="Right" ForeColor="White"
																BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
														</asp:datagrid></div>
													<uc1:fenye id="Fenye1" runat="server"></uc1:fenye></td>
											</tr>
							</tr>
						</table>
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td background="i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
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
			<asp:textbox id="number" style="DISPLAY: none" runat="server" ></asp:textbox></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE><asp:textbox id="CompanyNumber" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StockPeoNum" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="CgStreamNumber" style="DISPLAY: none" runat="server" ></asp:textbox>
			
		</form>
	</body>
</HTML>
