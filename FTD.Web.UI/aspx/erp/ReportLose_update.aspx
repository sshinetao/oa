<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<%@ Page language="c#" Codebehind="ReportLose_update.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.ReportLose_update" %>
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
		
		
			function chknull()
				{


	    	if(document.getElementById('BsTimes').value=='')
			{
				alert('�������ڲ���Ϊ��');
			
				return false;
			}	
			
		    if(document.getElementById('Storeroom').value=='')
			{
				alert('�ֿⲻ��Ϊ��');
			
				return false;
			}	
		
									
			}
			
			
	
			

	     	var  wName_ddlx;  
            function  jsOpen()  
            {  
				 var num=Math.random();
                 wName_ddlx=window.showModalDialog("open_InSource.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wName_ddlx!=null && wName_ddlx!= "undefined")
                 {
                   
			    	document.getElementById("InSource").value=wName_ddlx; 
			    	return;
                 }
       
            }
            
            
	     	var  wNamekf;  
            function  jhcOpen()  
            {  
				 var num=Math.random();
                 wNamekf=window.showModalDialog("open_Storeroom.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wNamekf!=null && wNamekf!= "undefined")
                 {
                   
			    	document.getElementById("Storeroom").value=wNamekf; 
			    	return;
                 }
            
                
            }	

			function  zjOpen()  
            {  
            var num=Math.random();
            var number=document.getElementById('number').value;
           window.showModalDialog("ReportLose_add_add.aspx?tmp="+num+"&number="+number+" ","window","dialogWidth:700px;DialogHeight=400px;status:no;scroll=yes;help:no");                
              
               
               
                
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">����̨</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="ReportLose.aspx">����</A>&nbsp;&gt;&gt; 
									�޸ı���</td>
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
												<asp:imagebutton id="ImageButton3" runat="server" ImageUrl="i_blue/zenghang.jpg"></asp:imagebutton><FONT face="����">&nbsp;</FONT>
												<asp:imagebutton id="ImageButton4" runat="server" ImageUrl="i_blue/xiugai.jpg"></asp:imagebutton><FONT face="����">&nbsp;</FONT>
												<asp:imagebutton id="ImageButton5" runat="server" ImageUrl="i_blue/shanchu.jpg"></asp:imagebutton><FONT face="����"></FONT></td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">�ֿ�����</td>
												<td width="35%"><asp:textbox id="Storeroom" runat="server"  Width="90%"></asp:textbox><A href="javascript:void(0)"><IMG onclick="jhcOpen();" alt="" src="image/FDJ.gif" border="0"></A></td>
												<td align="right" width="15%"><FONT face="����">�������ڣ�</FONT></td>
												<td width="35%"><asp:textbox id="BsTimes" runat="server"  Width="90%"></asp:textbox>
													<script>SetNeed('BsTimes')</script>
													</FONT><A href="javascript:void(0)"><IMG id="BsTimes_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
															src="image/FDJ.gif" border="0"></A>
												</td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">�����ˣ�</td>
												<td width="35%"><asp:textbox id="StockPeoName" runat="server"  Width="90%"></asp:textbox><A href="javascript:void(0)"><IMG onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectUser.aspx?TableName=ERPUser&LieName=UserName&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('StockPeoName').value=wName;}" alt="" src="image/FDJ.gif" border="0"></A></td>
												<td align="right" width="15%"><FONT face="����">¼���ˣ�</FONT></td>
												<td width="35%"><asp:textbox id="Realname" runat="server"  Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="����">ժҪ��</FONT></td>
												<td colSpan="3"><asp:textbox id="Remark" runat="server" Width="100%" Height="52px" TextMode="MultiLine"></asp:textbox><A href="javascript:void(0)"></A></FONT></td>
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
																<asp:BoundColumn DataField="StockPoint" SortExpression="StockPoint" HeaderText="��������">
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
											<td width="9%"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="i_blue/ok.jpg"></asp:imagebutton></td>
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
			</TR></TBODY></TABLE><asp:textbox id="CompanyNumber" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StockPeoNum" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StreamNumber" style="DISPLAY: none" runat="server" ></asp:textbox>
			<script language="javascript">	
				  		var  wName_3;  
        function  usOpen()  
            {  
            var num=Math.random();
                wName_3=window.showModalDialog("open_manage.aspx?tmp="+num+" ","window","dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
         
                
var arr = wName_3.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("StockPeoName").value=arr[0]; 
document.getElementById("StockPeoNum").value=arr[2]; 

}


}
			</script>
		</form>
	</body>
</HTML>
