<%@ Page language="c#" Codebehind="BB_Company.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.BB_Company" %>
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
								<td width="97%"><FONT color="#ffffff"><A class="line_b" href="main_1.aspx">����̨</A> &nbsp;&gt;&gt; 
										������λ����</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 93px"><FONT face="����">������λ���ƣ�</FONT></TD>
						<TD style="WIDTH: 146px"><asp:TextBox id="Name" runat="server" Width="144px"></asp:TextBox></TD>
						<TD>
							<asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/search.jpg"></asp:imagebutton><FONT face="����">&nbsp;</FONT><FONT face="����">
								<asp:imagebutton id="Imagebutton9" runat="server" ImageUrl="i_blue/chakan.jpg"></asp:imagebutton></FONT></FONT></TD>
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
												<asp:BoundColumn DataField="Name" SortExpression="Name" HeaderText="����"></asp:BoundColumn>
												<asp:BoundColumn DataField="Type" SortExpression="Type" HeaderText="����"></asp:BoundColumn>
												<asp:BoundColumn DataField="Linkman" SortExpression="Linkman" HeaderText="��ϵ��"></asp:BoundColumn>
												<asp:BoundColumn DataField="Deputy" SortExpression="Deputy" HeaderText="���˴���"></asp:BoundColumn>
												<asp:BoundColumn HeaderText="Ӧ�����ܶ�"></asp:BoundColumn>
												<asp:BoundColumn HeaderText="�Ѹ����ܶ�"></asp:BoundColumn>
												<asp:BoundColumn HeaderText="δ�����ܶ�"></asp:BoundColumn>
												<asp:BoundColumn HeaderText="Ӧ�տ��ܶ�"></asp:BoundColumn>
												<asp:BoundColumn HeaderText="���տ��ܶ�"></asp:BoundColumn>
												<asp:BoundColumn HeaderText="δ�տ��ܶ�"></asp:BoundColumn>
											</Columns>
											<PagerStyle NextPageText="��һҳ" PrevPageText="��һҳ" HorizontalAlign="Right" ForeColor="White"
												BackColor="#AECADF" Mode="NumericPages"></PagerStyle>
										</asp:datagrid></div>
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
