<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<%@ Page language="c#" Codebehind="BB_StockOutMoney_JL.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.BB_StockOutMoney_JL" %>
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
  	     	   function killErrors() {
		return true;
		}
		window.onerror = killErrors;	
  	     
  	     
	     	var  wName_ddlx;  
            function  jsOpen()  
            {  
				 var num=Math.random();
                 wName_ddlx=window.showModalDialog("open_IncomeSet.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wName_ddlx!=null && wName_ddlx!= "undefined")
                 {
                   
			    	document.getElementById("IncomeSet").value=wName_ddlx; 
			    	return;
                 }
            
                
            }
            
            



		  		  
		</SCRIPT>
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
										Ӧ����� &gt;&gt; �������¼��ʾ</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 64px"><FONT face="����">�������⣺</FONT></TD>
						<TD style="WIDTH: 111px"><asp:TextBox id="title" runat="server" Width="104px"></asp:TextBox></TD>
						<TD style="WIDTH: 52px"><FONT face="����">��Ʊ�ţ�</FONT></TD>
						<TD style="WIDTH: 98px"><asp:textbox id="InvoiceType" runat="server" Width="88px"></asp:textbox></TD>
						<TD style="WIDTH: 61px"><FONT face="����">��ʼʱ�䣺</FONT></TD>
						<TD style="WIDTH: 111px"><asp:TextBox id="Starttime" runat="server" Width="80px" ></asp:TextBox>
							<script>SetNeed('Starttime')</script>
							</FONT><A href="javascript:void(0)"><IMG id="Starttime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
									src="image/FDJ.gif" border="0"></A></TD>
						<TD style="WIDTH: 61px"><FONT face="����">����ʱ�䣺</FONT></TD>
						<TD style="WIDTH: 117px"><asp:TextBox id="Endtime" runat="server" Width="80px" ></asp:TextBox>
							<script>SetNeed('Endtime')</script>
							</FONT><A href="javascript:void(0)"><IMG id="Endtime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
									src="image/FDJ.gif" border="0"></A>
						</TD>
						<TD><FONT face="����">
								<asp:imagebutton id="Imagebutton1" runat="server" ImageUrl="i_blue/search.jpg"></asp:imagebutton></FONT></FONT></TD>
						<TD></TD>
					</TR>
					<TR>
						<TD style="WIDTH: 64px"><FONT face="����">���ʽ��</FONT></TD>
						<TD style="WIDTH: 111px"><asp:TextBox id="IncomeSet" runat="server" Width="88px"></asp:TextBox><A href="javascript:void(0)"><IMG onclick="jsOpen();" alt="" src="image/FDJ.gif" border="0"></A></TD>
						<TD style="WIDTH: 52px"><FONT face="����">�����ˣ�</FONT></TD>
						<TD style="WIDTH: 98px"><asp:textbox id="JbName" runat="server" Width="88px"></asp:textbox></TD>
						<TD style="WIDTH: 61px"><FONT face="����">�������ڣ�</FONT></TD>
						<TD style="WIDTH: 111px"><asp:TextBox id="Outtime" runat="server" Width="80px" ></asp:TextBox>
							<script>SetNeed('Outtime')</script>
							</FONT><A href="javascript:void(0)"><IMG id="Outtime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
									src="image/FDJ.gif" border="0"></A></TD>
						<TD style="WIDTH: 61px"><FONT face="����">��Ӧ�̣�</FONT></TD>
						<TD style="WIDTH: 117px">
							<asp:TextBox id="CompanyName" runat="server" Width="112px"></asp:TextBox>
						</TD>
						<TD><FONT face="����"></FONT><FONT face="����">
								<asp:imagebutton id="Imagebutton3" runat="server" ImageUrl="i_blue/chakan.jpg"></asp:imagebutton></FONT></FONT></TD>
						<TD></TD>
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
										<asp:datagrid id="Datagrid2" runat="server" Width="100%" BorderStyle="None" GridLines="Vertical"
											BackColor="White" AutoGenerateColumns="False" BorderColor="#4D77B1" CellPadding="3" PageSize="12"
											OnPageIndexChanged="MyDataGrid_Page_1" BorderWidth="1px" AllowPaging="True">
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
												<asp:BoundColumn DataField="Outtime" SortExpression="Outtime" HeaderText="��������" DataFormatString="{0:yyyy-M-dd}">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="IncomeSet" SortExpression="IncomeSet" HeaderText="���ʽ">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="FkMoney" SortExpression="FkMoney" HeaderText="������">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="CompanyName" SortExpression="CompanyName" HeaderText="��Ӧ������">
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
											</Columns>
											<PagerStyle Visible="False" NextPageText="��һҳ" PrevPageText="��һҳ" HorizontalAlign="Right" ForeColor="White"
												BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
										</asp:datagrid></div>
									<FONT face="����" color="#ff0000"><STRONG>�Ѹ���<%=yfmoney%></STRONG></FONT><uc1:fenye id="Fenye1" runat="server"></uc1:fenye></td>
							</tr>
						</table>
					</td>
					<td width="15">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>