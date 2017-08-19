<%@ Page language="c#" Codebehind="open_SellOrder_in.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.open_SellOrder_in" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>销售订单</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
		<base target="_self">
		<script language="javascript">		
    		   var  getFromParent=window.dialogArguments;  
		    function CheckSelect()
		    {
		        var retrunstr = "";
		        var oRadio = document.getElementsByName("Rad");
		        var rvalue = 0;
		        for (var i = 0; i < oRadio.length; i++) {
		            if (oRadio[i].checked) {
		                rvalue = oRadio[i].value;
		                return rvalue;
		                break;
		            }
		        }
		        return retrunstr;
            }
                       
           function  sendFromChild()  
            {       
                window.returnValue=CheckSelect();  
                window.close();  
            } 
            


			
									
		
	
	         function  CCC()  
            {       
                window.returnValue="|";  
                window.close();  
            } 

			window.onbeforeunload = function()  
			{
			    var n = window.event.screenX - window.screenLeft;
			    var b = n > document.documentElement.scrollWidth-20;
			 if(b && window.event.clientY < 0 || window.event.altKey)
			 {
				
			 }
			}
        		
		</script>
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table width="100%" border="0" cellspacing="0" cellpadding="0">
				<tr>
					<td width="16" background="i_blue/m_head_3.jpg"><img src="i_blue/m_head_1.jpg" width="20" height="34"></td>
					<td width="748" background="i_blue/m_head_3.jpg"><table width="92%" height="25" border="0" cellpadding="0" cellspacing="0">
							<tr>
								<td width="97%" class="headfont">销售订单</td>
							</tr>
						</table>
					</td>
					<td width="23"><img src="i_blue/m_head_2.jpg" width="21" height="34"></td>
				</tr>
			</table>
			<table width="100%" height="450" border="0" cellpadding="0" cellspacing="0">
				<tr>
					<td width="15">&nbsp;</td>
					<td width="95%" valign="top"><table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#7d9db4">
							<tr>
								<td valign="top" bgcolor="#f3f8fe"><table width="100%" height="26" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
										</tr>
									</table>
									<table width="100%" border="0" cellpadding="4" cellspacing="1" bgcolor="#d8e1e8">
										<tr bgcolor="#f3f8fe">
											<td width="100%">
												<table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td width="25%"><FONT face="宋体">订单标题关键字：</FONT></td>
														<td width="42%">
															<asp:TextBox id="name" runat="server" Width="216px"></asp:TextBox></td>
														<td width="33%"><FONT face="宋体">&nbsp;</FONT>
															<asp:ImageButton id="ImageButton2" runat="server" ImageUrl="i_blue/search.jpg"></asp:ImageButton></td>
													</tr>
												</table>
											</td>
										</tr>
										<tr bgcolor="#f3f8fe">
											<td width="100%"><FONT face="宋体">
													<asp:datagrid id="Datagrid2" runat="server" Width="100%" AllowPaging="True" OnPageIndexChanged="MyDataGrid_Page_1"
														PageSize="11" CellPadding="3" BorderColor="#4D77B1" AutoGenerateColumns="False" BorderStyle="None"
														BackColor="White" GridLines="Vertical" BorderWidth="1px">
														<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
														<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
														<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
														<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
														<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
														<Columns>
															<asp:TemplateColumn>
																<HeaderStyle Width="30px"></HeaderStyle>
																<ItemTemplate>
																	&nbsp;<INPUT type="radio"  name="Rad" id="Radio1"  CHECKED value='<%#DataBinder.Eval(Container.DataItem, "number")%>|<%#DataBinder.Eval(Container.DataItem, "title")%>'>
																</ItemTemplate>
															</asp:TemplateColumn>
															<asp:BoundColumn DataField="title" HeaderText="标题">
																<HeaderStyle Wrap="False"></HeaderStyle>
																<ItemStyle Wrap="False"></ItemStyle>
															</asp:BoundColumn>
															<asp:BoundColumn DataField="Type" SortExpression="Type" HeaderText="订单类型">
																<HeaderStyle Wrap="False"></HeaderStyle>
																<ItemStyle Wrap="False"></ItemStyle>
															</asp:BoundColumn>
															<asp:BoundColumn DataField="QdTime" SortExpression="QdTime" HeaderText="签订日期" DataFormatString="{0:yyyy-M-dd}">
																<HeaderStyle Wrap="False"></HeaderStyle>
																<ItemStyle Wrap="False"></ItemStyle>
															</asp:BoundColumn>
															<asp:BoundColumn DataField="Storeroom" SortExpression="Storeroom" HeaderText="出货仓">
																<HeaderStyle Wrap="False"></HeaderStyle>
																<ItemStyle Wrap="False"></ItemStyle>
															</asp:BoundColumn>
															<asp:BoundColumn DataField="CompanyName" SortExpression="CompanyName" HeaderText="客户名称">
																<HeaderStyle Wrap="False"></HeaderStyle>
																<ItemStyle Wrap="False"></ItemStyle>
															</asp:BoundColumn>
															<asp:BoundColumn DataField="StockPeoName" SortExpression="StockPeoName" HeaderText="业务员姓名">
																<HeaderStyle Wrap="False"></HeaderStyle>
																<ItemStyle Wrap="False"></ItemStyle>
															</asp:BoundColumn>
															<asp:BoundColumn DataField="AllMoney" SortExpression="AllMoney" HeaderText="总金额">
																<HeaderStyle Wrap="False"></HeaderStyle>
																<ItemStyle Wrap="False"></ItemStyle>
															</asp:BoundColumn>
															<asp:BoundColumn DataField="YjMoney" SortExpression="YjMoney" HeaderText="已收金额">
																<HeaderStyle Wrap="False"></HeaderStyle>
																<ItemStyle Wrap="False"></ItemStyle>
															</asp:BoundColumn>
															<asp:BoundColumn DataField="State" SortExpression="State" HeaderText="状态">
																<HeaderStyle Wrap="False"></HeaderStyle>
																<ItemStyle Wrap="False"></ItemStyle>
															</asp:BoundColumn>
														</Columns>
														<PagerStyle NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
															BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
													</asp:datagrid></FONT></td>
										</tr>
									</table>
									<table width="100%" height="25" border="0" cellpadding="0" cellspacing="0">
										<tr>
											<td background="i_blue/third_head_bg1.jpg"><table width="100%" border="0" cellspacing="0" cellpadding="0">
													<tr>
														<td width="39%">&nbsp;</td>
														<td width="19%">
															<a href="JavaScript:void(0)"><img src="i_blue/ok.jpg" border="0" onclick="sendFromChild();"></a><FONT face="宋体">&nbsp;</FONT><a href="JavaScript:void(0)"><img src="i_blue/qingkong.jpg" border="0" onclick="CCC()"></a></td>
														<td width="42%"></td>
													</tr>
												</table>
											</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
					<td width="15">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
