<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<%@ Page language="c#" Codebehind="SellInMoney_sp.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.SellInMoney_sp" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>�ɭɽ������</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<SCRIPT language="javascript">
		  function del()
		  {
			    if (!confirm("�Ƿ�ȷ��ɾ����"))
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
								<td width="97%"><FONT color="#ffffff"><A class="line_b" href="main_1.aspx">����̨</A>&nbsp;&gt;&gt; 
										�����տ�����</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 101px"><FONT face="����">��������ؼ��֣�</FONT></TD>
                        <td style="WIDTH: 143px">
                            <asp:DropDownList runat="server" ID="sellquitSelect">
                                <asp:ListItem Value="title">��������</asp:ListItem>
                                <asp:ListItem Value="Allmoney">�����ܽ��</asp:ListItem>
                                <asp:ListItem Value="Outtime">�տ�����</asp:ListItem>
                                <asp:ListItem Value="IncomeSet">�տʽ</asp:ListItem>
                                <asp:ListItem Value="FkMoney">�տ���</asp:ListItem>
                                <asp:ListItem Value="CompanyName">�ͻ�����</asp:ListItem>
                                <asp:ListItem Value="JbName">������</asp:ListItem>
                            </asp:DropDownList></td>
						<TD style="WIDTH: 157px"><asp:textbox id="tilte" runat="server" Width="120px"></asp:textbox></TD>
						<TD><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/search.jpg"></asp:imagebutton><FONT face="����">&nbsp;</FONT>
							<asp:imagebutton id="Imagebutton1" runat="server" ImageUrl="i_blue/sp.jpg"></asp:imagebutton><FONT face="����">&nbsp;
								<asp:imagebutton id="Imagebutton9" runat="server" ImageUrl="i_blue/wsp.jpg"></asp:imagebutton>&nbsp;</FONT>
							<asp:imagebutton id="Imagebutton4" runat="server" ImageUrl="i_blue/ysp.jpg"></asp:imagebutton><FONT face="����">&nbsp;&nbsp;</FONT><asp:imagebutton id="ImageButton3" runat="server" ImageUrl="i_blue/back.jpg"></asp:imagebutton></TD>
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
									<asp:datagrid id="Datagrid2" runat="server" Width="100%" AllowPaging="True" BorderWidth="1px"
										OnPageIndexChanged="MyDataGrid_Page_1" PageSize="12" CellPadding="3" BorderColor="#4D77B1"
										AutoGenerateColumns="False" BackColor="White" GridLines="Vertical" BorderStyle="None">
										<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
										<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
										<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
										<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
										<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
										<Columns>
											<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
											<asp:BoundColumn DataField="title" SortExpression="title" HeaderText="��������">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="Allmoney" SortExpression="Allmoney" HeaderText="�����ܽ��">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="Outtime" SortExpression="Outtime" HeaderText="�տ�����" DataFormatString="{0:yyyy-M-dd}">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="IncomeSet" SortExpression="IncomeSet" HeaderText="�տʽ">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="FkMoney" SortExpression="FkMoney" HeaderText="�տ���">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="CompanyName" SortExpression="CompanyName" HeaderText="�ͻ�����">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="JbName" SortExpression="JbName" HeaderText="������">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="State" SortExpression="State" HeaderText="״̬">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="MyTimes">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="realname" SortExpression="realname" HeaderText="¼����">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
										</Columns>
										<PagerStyle Visible="False" NextPageText="��һҳ" PrevPageText="��һҳ" HorizontalAlign="Right" ForeColor="White"
											BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
									</asp:datagrid>
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
