<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<%@ Page language="c#" Codebehind="SellQuit_sp_sp.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.SellQuit_sp_sp" %>
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
		
		 function del()
		  {
			    if (!confirm("�Ƿ�ȷ��ɾ����"))
			    return false;
		  }	
		
		
		    
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">����̨</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="SellQuit_sp.aspx">�����˻�����</A>&nbsp;&gt;&gt; 
									�鿴�����˻�����</td>
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
											<td background="i_blue/third_head_bg.jpg"><FONT face="����"></FONT></td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">���⣺</FONT></td>
												<td width="35%"><asp:textbox id="title" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">�˻����ڣ�</FONT></td>
												<td width="35%">
													<asp:textbox id="ShTime" runat="server" Width="100%" DataType="DateTime" ></asp:textbox>
													<script>SetNeed('ShTime')</script>
													</FONT>
												</td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">������</td>
												<td width="35%"><asp:textbox id="StockPeoName" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">�ջ��֣�</FONT></td>
												<td width="35%"><asp:textbox id="Storeroom" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�ͻ����ƣ�</FONT></td>
												<td width="35%"><asp:textbox id="CompanyName" runat="server" Width="100%" ></asp:textbox>
												</td>
												<td align="right" width="15%"><FONT face="����"><FONT face="����">�ͻ�</FONT>��ַ��</FONT></td>
												<td width="35%"><FONT face="����">
														<asp:textbox id="CompanyAdd" runat="server" Width="100%" ></asp:textbox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="����">�������̣�</FONT></td>
												<td colSpan="3"><asp:textbox id="StreamName" runat="server" Width="100%" ></asp:textbox>
												</td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">��д�ˣ�</td>
												<td><FONT face="����">
														<asp:TextBox id="realname" runat="server" Width="100%"></asp:TextBox></FONT></td>
												<td align="right"><FONT face="����">�Ƿ�ͨ��������</FONT></td>
												<td>
													<asp:DropDownList id="Ifts" runat="server" Width="100%" AutoPostBack="True">
														<asp:ListItem Value="��">��</asp:ListItem>
														<asp:ListItem Value="��">��</asp:ListItem>
													</asp:DropDownList><A href="javascript:void(0)"></A></FONT></td>
											</tr>
											<asp:Panel id="Panel1" runat="server">
												<TR bgColor="#f3f8fe">
													<TD align="right"><FONT face="����">ѡ�񲵻ؽڵ㣺</FONT></TD>
													<TD colSpan="3">
														<asp:DropDownList id="bhuser" runat="server" Width="100%"></asp:DropDownList><A href="javascript:void(0)"></A></FONT></TD>
												</TR>
											</asp:Panel>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="����">ժҪ��</FONT></td>
												<td colSpan="3"><asp:textbox id="Remark" runat="server" Width="100%" TextMode="MultiLine" Height="52px" ></asp:textbox><A href="javascript:void(0)"></A></FONT></td>
											</tr>
											<tr bgcolor="#f3f8fe">
												<td align="right"><FONT face="����">������ע��</FONT></td>
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
																<asp:BoundColumn DataField="StockPoint" SortExpression="StockPoint" HeaderText="�˻�����">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="SingleMoney" SortExpression="SingleMoney" HeaderText="����"></asp:BoundColumn>
																<asp:BoundColumn DataField="Allmoney" SortExpression="Allmoney" HeaderText="�˻��ܽ��">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
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
											<td width="9%">
												<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:ImageButton></td>
											<td width="52%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<asp:TextBox id="Grealname" runat="server"  Width="100%" style="DISPLAY: none"></asp:TextBox></FONT>
			<asp:TextBox id="Gname" runat="server"  Width="100%" style="DISPLAY: none"></asp:TextBox>
			<asp:TextBox id="Gusername" runat="server"  Visible="False"></asp:TextBox><FONT face="����">
				<asp:TextBox id="Name" runat="server" style="DISPLAY: none"></asp:TextBox>
				<asp:TextBox id="username" runat="server" style="DISPLAY: none"></asp:TextBox>
				<asp:textbox id="number" runat="server"  style="DISPLAY: none"></asp:textbox></FONT></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE><asp:textbox id="CompanyNumber" runat="server" style="DISPLAY: none"></asp:textbox><asp:textbox id="StockPeoNum" runat="server" style="DISPLAY: none"></asp:textbox><asp:textbox id="StreamNumber" runat="server"  style="DISPLAY: none"></asp:textbox>
		</form>
	</body>
</HTML>
