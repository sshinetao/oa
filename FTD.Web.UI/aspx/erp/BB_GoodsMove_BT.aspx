<%@ Page language="c#" Codebehind="BB_GoodsMove_BT.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.BB_GoodsMove_BT" %>
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
								<td width="97%"><FONT color="#ffffff"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt; 
										调拨报表 &gt;&gt; 按调拨用途显示</FONT></td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="i_blue/m_head_2.jpg" width="21"></td>
				</tr>
			</table>
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
				<TBODY>
					<TR>
						<TD style="WIDTH: 44px"><FONT face="宋体">用途：</FONT></TD>
						<TD style="WIDTH: 93px"><asp:TextBox id="Uses" runat="server" Width="88px"></asp:TextBox></TD>
						<TD style="WIDTH: 51px"><FONT face="宋体">经办人：</FONT></TD>
						<TD style="WIDTH: 118px"><asp:textbox id="StockPeoName" runat="server" Width="112px"></asp:textbox></TD>
						<TD style="WIDTH: 61px"><FONT face="宋体">开始时间：</FONT></TD>
						<TD style="WIDTH: 111px"><asp:TextBox id="Starttime" runat="server" Width="80px" ></asp:TextBox>
							<script>SetNeed('Starttime')</script>
							</FONT><A href="javascript:void(0)"><IMG id="Starttime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
									src="image/FDJ.gif" border="0"></A></TD>
						<TD style="WIDTH: 61px"><FONT face="宋体">结束时间：</FONT></TD>
						<TD style="WIDTH: 117px"><asp:TextBox id="Endtime" runat="server" Width="80px" ></asp:TextBox>
							<script>SetNeed('Endtime')</script>
							</FONT><A href="javascript:void(0)"><IMG id="Endtime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
									src="image/FDJ.gif" border="0"></A>
						</TD>
						<TD>
							<asp:imagebutton id="ImageButton2" runat="server" ImageUrl="i_blue/search.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT><FONT face="宋体">
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
										<asp:datagrid id="Datagrid2" runat="server" BorderStyle="None" GridLines="Vertical" BackColor="White"
											Width="100%" AutoGenerateColumns="False" BorderColor="#4D77B1" CellPadding="3" PageSize="12"
											OnPageIndexChanged="MyDataGrid_Page_1" BorderWidth="1px" AllowPaging="True">
											<FooterStyle ForeColor="Black" BackColor="#AECADF"></FooterStyle>
											<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669AC1"></SelectedItemStyle>
											<AlternatingItemStyle BackColor="#FBFCFE"></AlternatingItemStyle>
											<ItemStyle ForeColor="Black" BackColor="#E6EDF7"></ItemStyle>
											<HeaderStyle Font-Bold="True" HorizontalAlign="Center" BackColor="#AECADF"></HeaderStyle>
											<Columns>
												<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
												<asp:BoundColumn DataField="Uses" SortExpression="Uses" HeaderText="用途">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="StockPeoName" SortExpression="StockPeoName" HeaderText="经办人姓名">
													<HeaderStyle Wrap="False"></HeaderStyle>
													<ItemStyle Wrap="False"></ItemStyle>
												</asp:BoundColumn>
											</Columns>
											<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
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
