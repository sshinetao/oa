<%@ Page language="c#" Codebehind="BB_SellOrder_BT.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.BB_SellOrder_BT" %>
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
		<SCRIPT language="javascript">
  	     	   function killErrors() {
		return true;
		}
		window.onerror = killErrors;	
  	     
  	     
  	     	var  wName;  
            function  fnOpen()  
            {  
				 var num=Math.random();
                 wName=window.showModalDialog("posttype_open.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wName!=null && wName!= "undefined")
                 {
                   
			    	document.getElementById("unit").value=wName; 
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
										���۶������� &gt;&gt; ������������ʾ</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 44px"><FONT face="����">���⣺</FONT></TD>
						<TD style="WIDTH: 93px"><asp:TextBox id="title" runat="server" Width="88px"></asp:TextBox></TD>
						<TD style="WIDTH: 52px"><FONT face="����">���ţ�</FONT></TD>
						<TD style="WIDTH: 118px"><asp:textbox id="unit" runat="server" Width="88px" ></asp:textbox><A href="javascript:void(0)"><IMG var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectDanWei.aspx?TableName=ERPBuMen&LieName=BuMenName&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('unit').value=wName;} alt="" src="image/FDJ.gif" border="0"></A></TD>
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
						<TD style="WIDTH: 44px"><FONT face="����">���ͣ�</FONT></TD>
						<TD style="WIDTH: 93px"><asp:TextBox id="Type" runat="server" Width="88px"></asp:TextBox></TD>
						<TD style="WIDTH: 52px"><FONT face="����">ҵ��Ա��</FONT></TD>
						<TD style="WIDTH: 118px"><asp:textbox id="StockPeoName" runat="server" Width="112px"></asp:textbox></TD>
						<TD style="WIDTH: 61px"><FONT face="����">ǩ�����ڣ�</FONT></TD>
						<TD style="WIDTH: 111px"><asp:TextBox id="QdTime" runat="server" Width="80px" ></asp:TextBox>
							<script>SetNeed('QdTime')</script>
							</FONT><A href="javascript:void(0)"><IMG id="QdTime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
									src="image/FDJ.gif" border="0"></A></TD>
						<TD style="WIDTH: 61px"><FONT face="����">�ͻ���</FONT></TD>
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
												<asp:BoundColumn DataField="title" SortExpression="title" HeaderText="����">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Type" SortExpression="Type" HeaderText="��������">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="QdTime" SortExpression="QdTime" HeaderText="ǩ������" DataFormatString="{0:yyyy-M-dd}">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="OrderAdd" SortExpression="OrderAdd" HeaderText="����ǩ���ص�">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="CompanyName" SortExpression="CompanyName" HeaderText="�ͻ�">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="StockPeoName" SortExpression="StockPeoName" HeaderText="ҵ��Ա����">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="AllMoney" SortExpression="AllMoney" HeaderText="�ܽ��">
													<HeaderStyle Wrap="False"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="Ifopen" HeaderText="����">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="State" SortExpression="State" HeaderText="״̬">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn Visible="False" DataField="MyTimes"></asp:BoundColumn>
												<asp:BoundColumn DataField="YjMoney" SortExpression="YjMoney" HeaderText="�Ѹ����">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
											</Columns>
											<PagerStyle Visible="False" NextPageText="��һҳ" PrevPageText="��һҳ" HorizontalAlign="Right" ForeColor="White"
												BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
										</asp:datagrid></div>
									<FONT face="����" color="#ff0000"><STRONG>����ܼƣ�<%=allmoney%>Ԫ</STRONG></FONT>
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
