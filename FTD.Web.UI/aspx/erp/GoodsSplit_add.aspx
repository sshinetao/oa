<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<%@ Page language="c#" Codebehind="GoodsSplit_add.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.GoodsSplit_add" %>
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


	    	if(document.getElementById('GoodsName').value=='')
			{
				alert('�������Ʋ���Ϊ��');
			
				return false;
			}	
			
		    if(document.getElementById('Storeroom').value=='')
			{
				alert('�ֿⲻ��Ϊ��');
			
				return false;
			}	
		
									
			}
			
			
			function drjh()
			{


	    	if(document.getElementById('CompanyName').value=='')
			{
				alert('�ͻ�����Ϊ��\n���붩�����ݽ���Ӧ�˿ͻ�');
				Form1.CompanyName.focus();
				return false;
			}
			
			else if(!confirm("ϵͳ����յ�ǰ�ɹ���ϸ�б��Ƿ��룿"))
			{
				 return false;
			}
			 
			else
			{
			     var num=Math.random();
				 var number=document.getElementById('number').value;
				 var CompanyNumber=document.getElementById('CompanyNumber').value;
				 window.showModalDialog("open_SellOrder.aspx?tmp="+num+"&number="+number+"&CompanyNumber="+CompanyNumber+"","window","dialogWidth:700px;DialogHeight=600px;status:no;scroll=yes;help:no");			
			}
			


		
									
			}		
			
	     	var  wName;  
            function  fnOpen()  
            {  
				 var num=Math.random();
                 wName=window.showModalDialog("open_TrafficType.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wName!=null && wName!= "undefined")
                 {
                   
			    	document.getElementById("TrafficType").value=wName; 
			    	return;
                 }
            
                
            }





	     	var  wName_ddlx;  
            function  jsOpen()  
            {  
				 var num=Math.random();
                 wName_ddlx=window.showModalDialog("open_Balance.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wName_ddlx!=null && wName_ddlx!= "undefined")
                 {
                   
			    	document.getElementById("Balance").value=wName_ddlx; 
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
           window.showModalDialog("GoodsSplit_add_add.aspx?tmp="+num+"&number="+number+" ","window","dialogWidth:700px;DialogHeight=400px;status:no;scroll=yes;help:no");                
              
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">����̨</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="GoodsSplit.aspx">������</A>&nbsp;&gt;&gt; 
									����������</td>
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
												<td align="right" width="15%">��Ʒ���ƣ�</td>
												<td width="35%"><asp:textbox id="GoodsName" runat="server" Width="90%"></asp:textbox><A href="javascript:void(0)"><IMG onclick="cpOpen();" alt="" src="image/FDJ.gif" border="0"></A></td>
												<td align="right" width="15%">������λ��</td>
												<td width="35%">
													<script>SetNeed('ShTime')</script>
													</FONT><asp:textbox id="CountUnit" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">����ͺţ�</td>
												<td width="35%"><asp:textbox id="Model" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%">��ɫ��</td>
												<td width="35%"><asp:textbox id="Color" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">�����ⷿ��</td>
												<td width="35%"><asp:textbox id="Storeroom" runat="server" Width="90%" ></asp:textbox><A href="javascript:void(0)"><IMG onclick="jhcOpen();" alt="" src="image/FDJ.gif" border="0"></A>
												</td>
												<td align="right" width="15%">���������</td>
												<td width="35%"><FONT face="����"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
															id="SplitPoint" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%">0</asp:textbox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">��ע��</td>
												<td width="85%" colSpan="3"><asp:textbox id="Remark" runat="server" Width="100%" Height="60px" TextMode="MultiLine"></asp:textbox></td>
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
																<asp:BoundColumn DataField="Color" SortExpression="Color" HeaderText="��ɫ"></asp:BoundColumn>
																<asp:BoundColumn DataField="SplitPoint" SortExpression="SplitPoint" HeaderText="��������">
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
			</TR></TBODY></TABLE><asp:textbox id="GoodsNumber" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StockPeoNum" style="DISPLAY: none" runat="server"></asp:textbox>
			<script language="javascript">	
var  wName_1;  
function  cpOpen()  
{  
var num=Math.random();
wName_1=window.showModalDialog("open_GoodsData.aspx?tmp="+num+" ","window","dialogWidth:800px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
var arr = wName_1.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("GoodsNumber").value=arr[0]; 
document.getElementById("GoodsName").value=arr[1]; 
document.getElementById("CountUnit").value=arr[2]; 
document.getElementById("Model").value=arr[3]; 
document.getElementById("Color").value=arr[5]; 


}


}
			</script>
		</form>
	</body>
</HTML>
