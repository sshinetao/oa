<%@ Page language="c#" Codebehind="SellPlanHW_update.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.SellPlanHW_update" %>
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
				alert('���ﲻ��Ϊ��');
			
				return false;
			}	
			
		    if(document.getElementById('Limit').value=='')
			{
				alert('�ƻ�����Ϊ��');
			
				return false;
			}	
		
									
			}
			
			






            
            
            
            var  wNamefp;  
            function  fpOpen()  
            {  
				 var num=Math.random();
                 wNamefp=window.showModalDialog("open_PlanType.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wNamefp!=null && wNamefp!= "undefined")
                 {
                   
			    	document.getElementById("Type").value=wNamefp; 
			    	return;
                 }
            
                
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">����̨</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="SellPlanHW.aspx">�������ۼƻ�</A>&nbsp;&gt;&gt; 
									�޸Ļ������ۼƻ�</td>
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
											<td background="i_blue/third_head_bg.jpg"></td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT style="BACKGROUND-COLOR: #f3f8fe">���</FONT></td>
												<td width="35%">
													<asp:textbox id="GoodsName" runat="server" Width="90%" ></asp:textbox><A href="javascript:void(0)"><IMG onclick="splc();" alt="" src="image/FDJ.gif" border="0"></A></td>
												<td align="right" width="15%">�ƻ����ͣ�</td>
												<td width="35%"><asp:textbox id="Type" runat="server" Width="90%"></asp:textbox><A href="javascript:void(0)"><IMG onclick="fpOpen();" alt="" src="image/FDJ.gif" border="0"></A></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="����">�ƻ���</FONT></td>
												<td width="35%"><FONT face="����">
														<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
															id="Limit" ondragenter="return false" style="IME-MODE: disabled" onmouseout="selstr()" runat="server"
															Width="100%">0</asp:textbox></FONT></td>
												<td align="right" width="15%"><FONT face="����">״̬��</FONT></td>
												<td width="35%"><FONT face="����">
														<asp:textbox id="State" runat="server" Width="100%" >¼����</asp:textbox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="����">��ʼʱ�䣺</FONT></td>
												<td><asp:textbox id="Starttime" runat="server" Width="90%" ></asp:textbox>
													<script>SetNeed('Starttime')</script>
													<A href="javascript:void(0)"><IMG id="Starttime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
															src="image/FDJ.gif" border="0"></A></td>
												<td align="right">����ʱ�䣺</td>
												<td>
													<asp:textbox id="Endtime" runat="server" Width="90%" ></asp:textbox>
													<script>SetNeed('Endtime')</script>
													<A href="javascript:void(0)"><IMG id="Endtime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
															src="image/FDJ.gif" border="0"></A>
												</td>
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
			<asp:TextBox id="number" runat="server"  style="DISPLAY: none"></asp:TextBox>
			<asp:TextBox id="GoodsNumber" runat="server" style="DISPLAY: none"></asp:TextBox></TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE>
			<script language="javascript">	
				 
	
			var  wName_5;  
        function  splc()  
            {  
            var num=Math.random();
                wName_5=window.showModalDialog("open_GoodsData.aspx?tmp="+num+"","window", "dialogWidth:700px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
         
                
var arr = wName_5.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("GoodsNumber").value=arr[0]; 
document.getElementById("GoodsName").value=arr[1]; 
}


}

			</script>
		</form>
	</body>
</HTML>
