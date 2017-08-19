<%@ Page language="c#" Codebehind="aaa.aspx.cs" AutoEventWireup="false" Inherits="ls_collection.aaa" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>aaa</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<style> 
		.fixedHeaderTr { POSITION: relative; ; TOP: expression(this.offsetParent.scrollTop) } 
		.mainDiv { SCROLLBAR-FACE-COLOR: #9999ff; OVERFLOW: auto; ; WIDTH: expression(document.body.clientWidth-2); ; HEIGHT: expression((document.body.clientHeight-this.offsetTop-2>this.children[0].offsetHeight)?(this.children[0].offsetHeight+2) : (document.body.clientHeight-this.offsetTop-2)) } 
		</style>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE id="Table1" cellSpacing="1" cellPadding="1" width="300" border="1">
				<TR>
					<TD>
						<div class="mainDiv">
							<asp:datagrid id="Datagrid2" runat="server" BorderStyle="None" GridLines="Vertical" BackColor="White"
								Width="100%" AutoGenerateColumns="False" BorderColor="#4D77B1" CellPadding="3" PageSize="12"
								BorderWidth="1px">
								<FooterStyle Wrap="False" ForeColor="Black" BackColor="#AECADF"></FooterStyle>
								<SelectedItemStyle Font-Bold="True" Wrap="False" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
								<EditItemStyle Wrap="False"></EditItemStyle>
								<AlternatingItemStyle Wrap="False" BackColor="#FBFCFE"></AlternatingItemStyle>
								<ItemStyle Wrap="False" ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
								<HeaderStyle Font-Bold="True" Wrap="False" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
								<Columns>
									<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
									<asp:BoundColumn DataField="Number" SortExpression="Number" HeaderText="货品编号">
										<HeaderStyle Wrap="False"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="GoodsName" SortExpression="GoodsName" HeaderText="名称">
										<HeaderStyle Wrap="False"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="CountUnit" SortExpression="CountUnit" HeaderText="计量单位">
										<HeaderStyle Wrap="False"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="Model" SortExpression="Model" HeaderText="规格型号">
										<HeaderStyle Wrap="False"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="Amountup" SortExpression="Amountup" HeaderText="预设库警上限">
										<HeaderStyle Wrap="False"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="Amountdown" SortExpression="Amountdown" HeaderText="预设库警下限">
										<HeaderStyle Wrap="False"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="Amountdown" SortExpression="Amountdown" HeaderText="预设库警下限">
										<HeaderStyle Wrap="False"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="Amountdown" SortExpression="Amountdown" HeaderText="预设库警下限">
										<HeaderStyle Wrap="False"></HeaderStyle>
									</asp:BoundColumn>
									<asp:BoundColumn DataField="Amountdown" SortExpression="Amountdown" HeaderText="预设库警下限"></asp:BoundColumn>
									<asp:BoundColumn DataField="Amountdown" SortExpression="Amountdown" HeaderText="预设库警下限"></asp:BoundColumn>
									<asp:BoundColumn DataField="Amountdown" SortExpression="Amountdown" HeaderText="预设库警下限"></asp:BoundColumn>
									<asp:BoundColumn DataField="Amountdown" SortExpression="Amountdown" HeaderText="预设库警下限"></asp:BoundColumn>
									<asp:BoundColumn DataField="Amountdown" SortExpression="Amountdown" HeaderText="预设库警下限"></asp:BoundColumn>
									<asp:BoundColumn DataField="Amountdown" SortExpression="Amountdown" HeaderText="预设库警下限"></asp:BoundColumn>
								</Columns>
								<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
									BackColor="#AECADF" Wrap="False" Mode="NumericPages"></PagerStyle>
							</asp:datagrid>
						</div>
					</TD>
				</TR>
			</TABLE>
		</form>
	</body>
</HTML>
