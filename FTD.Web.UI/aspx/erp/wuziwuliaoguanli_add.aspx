<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wuziwuliaoguanli_add.aspx.cs" Inherits="FTD.Web.UI.aspx.erp.wuziwuliaoguanli_add" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
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
		
			function chknull()
				{


	    	if(document.getElementById('种植基地').value=='')
			{
				alert('基地名不能为空');
				Form1.zhongzhijidi.focus();
				return false;
			}	
			
		    if(document.getElementById('种植户').value=='')
			{
				alert('户名不能为空');
				Form1.zhongzhihu.focus();
				return false;
			}	
		    if (document.getElementById('物资').value == '') {
		        alert('物资不能为空');
		        Form1.wuzi.focus();
		        return false;
		    }
		    if (document.getElementById('数量').value == '') {
		        alert('数量不能为空');
		        Form1.shuliang.focus();
		        return false;
		    }
		    if (document.getElementById('价格').value == '') {
		        alert('价格不能为空');
		        Form1.jiage.focus();
		        return false;
		    }
		    if (document.getElementById('金额').value == '') {
		        alert('金额不能为空');
		        Form1.jine.focus();
		        return false;
		    }
				
		    if (document.getElementById('状态').value == '') {
		        alert('状态只能是记账或者现结！');
		        Form1.zhuangtai.focus();
		        return false;
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="Storeroom.aspx">仓库信息</A>&nbsp;&gt;&gt; 
									录入物资物料情况</td>
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
											<td background="i_blue/third_head_bg.jpg">&nbsp;</td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">种植基地：</FONT></td>
												<td width="35%"><asp:textbox id="zhongzhijidi" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">种植户：</FONT></td>
												<td width="35%"><asp:textbox id="zhongzhihu" runat="server" Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">物资：</FONT></td>
												<td width="35%"><asp:textbox id="wuzi" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">数量：</FONT></td>
												<td width="35%"><asp:textbox id="shuliang" runat="server" Width="100%"></asp:textbox></td>
                                                </tr>
                                            <tr bgColor="#f3f8fe">
                                                <td align="right" width="15%"><FONT face="宋体">价格：</FONT></td>
												<td width="35%"><asp:textbox id="jiage" runat="server" Width="100%"></asp:textbox></td>
                                                </tr>
                                            <tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">金额：</FONT></td>
												<td width="35%"><asp:textbox id="jine" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">状态：</FONT></td>
												<td width="35%">
                                                    <asp:DropDownList ID="zhuangtai" runat="server">
                                                        <asp:ListItem> 记账</asp:ListItem>
                                                        <asp:ListItem>现结</asp:ListItem>
                                                    </asp:DropDownList>

												</td>
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
			</TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE>
			<script language="javascript">	
				  		var  wName_1;  
        function  usOpen()  
            {  
            var num=Math.random();
                wName_1=window.showModalDialog("open_manage.aspx?tmp="+num+" ","window","dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
         
                
var arr = wName_1.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("zhongzhijidi").value=arr[0]; 

}


}
			</script>
		</form>
	</body>
</HTML>

