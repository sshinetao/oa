<%@ Page language="c#" Codebehind="shengchanshishi_update.aspx.cs" AutoEventWireup="false" Inherits="FTD.Web.UI.aspx.erp.shengchanshishi_update" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="i_blue/ny.css" type="text/css" rel="stylesheet">
                    <script src="../../Controls/My97DatePicker/WdatePicker.js"></script>
		<script>
	   function killErrors() {
		return true;
		}
		window.onerror = killErrors;	
		
			function chknull()
				{

			    if (document.getElementById('种植基地').value == '') {
			        alert('基地名不能为空');
			        Form1.zhongzhijidi.focus();
			        return false;
			    }

			    if (document.getElementById('种植品名').value == '') {
			        alert('品名不能为空');
			        Form1.zhongzhipinming.focus();
			        return false;
			    }
			    if (document.getElementById('面积').value == '') {
			        alert('面积大小不能为空');
			        Form1.mianji.focus();
			        return false;
			    }
			    if (document.getElementById('预计产量').value == '') {
			        alert('预计产量不能为空');
			        Form1.yujichanliang.focus();
			        return false;
			    }
			    if (document.getElementById('合同收购价格').value == '') {
			        alert('收购价格不能为空');
			        Form1.shougoujiage.focus();
			        return false;
			    }
			    if (document.getElementById('种植时间').value == '') {
			        alert('种植时间不能为空');
			        Form1.zhongzhishijian.focus();
			        return false;
			    }

			    if (document.getElementById('预计采收时间').value == '') {
			        alert('时间不能为空');
			        Form1.caishoushijian.focus();
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="shengchanshishi.aspx">仓库信息</A>&nbsp;&gt;&gt; 
									修改生产计划实施情况</td>
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
												<td align="right" width="15%"><FONT face="宋体">种植品名：</FONT></td>
												<td width="35%"><asp:textbox id="zhongzhipinming" runat="server" Width="90%"></asp:textbox> </td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">面积：</FONT></td>
												<td width="35%"><asp:textbox id="mianji" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">预计产量：</FONT></td>
												<td width="35%"><asp:textbox id="yujichanliang" runat="server" Width="90%"></asp:textbox> </td>
												<td align="right" width="15%"><FONT face="宋体">收购价格：</FONT></td>
												<td width="35%"><asp:textbox id="shougoujiage" runat="server" Width="90%"  ></asp:textbox> </td>
											</tr>
                                            <tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">种植时间：</FONT></td>
												<td width="35%"><asp:textbox id="zhongzhishijian" runat="server" Width="100%" DataType="DateTime" onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">预计采收时间：</FONT></td>
												<td width="35%"><asp:textbox id="caishoushijian" runat="server" Width="90%" DataType="DateTime" onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})"></asp:textbox> </td>
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
