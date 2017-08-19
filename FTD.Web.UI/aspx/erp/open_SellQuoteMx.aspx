<%@ Page language="c#" Codebehind="open_SellQuoteMx.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.open_SellQuoteMx" %>
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
		<base target="_self">
		<SCRIPT language="javascript">
			   function killErrors() {
		return true;
		}
		window.onerror = killErrors;	
		  function del()
		  {
			    if (!confirm("确定导入？"))
			    return false;
		  }
	
	  
			   function  CCC()  
            {       
             
                window.close();  
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
								<td width="97%"><FONT color="#ffffff"> 导入销售报价</FONT></td>
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
						<TD style="WIDTH: 157px"><asp:TextBox id="tilte" runat="server"></asp:TextBox></TD>
						<TD>
							<asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/search.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>
							<asp:imagebutton id="Imagebutton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;
								<IMG onclick="CCC()" src="i_blue/close.jpg" border="0"></FONT></TD>
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
									<div class="mainDiv">&nbsp;</div>
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
											<asp:BoundColumn DataField="title" SortExpression="title" HeaderText="标题">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="CompanyName" SortExpression="CompanyName" HeaderText="客户名称">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="Unit" SortExpression="Unit" HeaderText="所属部门">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="Allmoney" SortExpression="Allmoney" HeaderText="金额总计">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="Allmoney" SortExpression="Allmoney" HeaderText="采购总金额">
												<HeaderStyle Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="False"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn DataField="StockPeoName" SortExpression="StockPeoName" HeaderText="业务员姓名"></asp:BoundColumn>
											<asp:BoundColumn Visible="False" DataField="number"></asp:BoundColumn>
										</Columns>
										<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
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
