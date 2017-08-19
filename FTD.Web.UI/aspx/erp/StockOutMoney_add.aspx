<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<%@ Page language="c#" Codebehind="StockOutMoney_add.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.StockOutMoney_add" %>
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


	    	if(document.getElementById('title').value=='')
			{
				alert('标题不能为空');
			
				return false;
			}	
			
		    if(document.getElementById('CompanyName').value=='')
			{
				alert('供应商不能为空');
			
				return false;
			}	
		
									
			}
			
			
	
			
			var  wName_sf;  
            function  sfOpen()  
            {  
				 var num=Math.random();
                 wName_sf=window.showModalDialog("open_IncomeSet.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");               
             
                 if(wName_sf!=null && wName_sf!= "undefined")
                 {
                   
			    	document.getElementById("IncomeSet").value=wName_sf; 
			    	return;
                 }
            
                
            }
            
	  		function selstr()
		{
	
		document.all.SyMoney.value=document.all.AllMoney.value-document.all.YfMoney.value-document.all.FkMoney.value;
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="StockOutMoney_add.aspx">采购付款</A>&nbsp;&gt;&gt; 
									新增采购付款</td>
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
												<asp:TextBox id="JbPeoNum" runat="server"  style="DISPLAY: none"></asp:TextBox>
												<asp:TextBox id="StreamNumber" runat="server" style="DISPLAY: none"></asp:TextBox></td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">订单标题：</FONT></td>
												<td width="35%"><asp:textbox id="title" runat="server" Width="90%" ></asp:textbox>
													<asp:ImageButton id="ImageButton1" runat="server" ImageUrl="image/FDJ.gif"></asp:ImageButton></td>
												<td align="right" width="15%"><FONT face="宋体">供应商名称：</FONT></td>
												<td width="35%"><asp:textbox id="CompanyName" runat="server" Width="90%" ></asp:textbox><A href="javascript:void(0)"><IMG onclick="khOpen();" alt="" src="image/FDJ.gif" border="0"></A></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">已付金额：</td>
												<td><asp:textbox id="YfMoney" runat="server" Width="100%" ></asp:textbox><A href="javascript:void(0)"></A></td>
												<td align="right"><FONT face="宋体">当前状态：</FONT></td>
												<td>
													<asp:textbox id="State" runat="server"  Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">付款方式：</td>
												<td><asp:textbox id="IncomeSet" runat="server" Width="90%"></asp:textbox><A href="javascript:void(0)"><IMG onclick="sfOpen();" alt="" src="image/FDJ.gif" border="0"></A></td>
												<td align="right"><FONT face="宋体">付款金额：</FONT></td>
												<td>
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="FkMoney" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
														onmouseout="selstr()">0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">付款日期：</td>
												<td>
													<asp:textbox id="Outtime" runat="server" Width="90%" ></asp:textbox>
													<script>SetNeed('Outtime')</script>
													</FONT><A href="javascript:void(0)"><IMG id="Outtime_HelpButton" onclick="Jscript:var sID ;sID = event.srcElement.id; sID = sID.substring(0,sID.lastIndexOf('_HelpButton'));DateSelect(sID);"
															src="image/FDJ.gif" border="0"></A>
												</td>
												<td align="right"><FONT face="宋体">剩余金额：</FONT></td>
												<td>
													<asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="SyMoney" ondragenter="return false" style="IME-MODE: disabled" runat="server" Width="100%"
														 onclick="selstr(this,this);return false"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">发票号：</td>
												<td><asp:textbox id="InvoiceType" runat="server" Width="100%"></asp:textbox><A href="javascript:void(0)"></A></td>
												<td align="right"><FONT face="宋体">经办人：</FONT></td>
												<td>
													<asp:textbox id="JbName" runat="server" Width="90%"></asp:textbox><A href="javascript:void(0)"><IMG onclick="var wName;var RadNum=Math.random();wName=window.showModalDialog('../Main/SelectUser.aspx?TableName=ERPUser&LieName=UserName&Radstr='+RadNum,'','dialogWidth:350px;DialogHeight=400px;status:no;help:no;resizable:yes;');if(wName==null){}else{document.getElementById('JbName').value=wName;}" alt="" src="image/FDJ.gif" border="0"></A></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">选择审批流程：</FONT></td>
												<td colSpan="3"><asp:textbox id="StreamName" runat="server" Width="90%" ></asp:textbox><A href="javascript:void(0)"><IMG onclick="splc()" src="image/FDJ.gif" border="0"></A></FONT>
												</td>
											</tr>
										</TBODY>
									</table>
									<hr>
									<div align="center"><STRONG>订单明细</STRONG></div>
									<hr>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">订单类型：</FONT></td>
												<td width="35%"><asp:textbox id="Type" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">订单内部码：</FONT></td>
												<td width="35%"><FONT face="宋体"><asp:textbox id="NbNumber" runat="server" Width="100%" ></asp:textbox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">签订日期：</FONT></td>
												<td width="35%"><asp:textbox id="QdTime" runat="server" Width="100%" ></asp:textbox>
													<script>SetNeed('QdTime')</script>
													</FONT><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="宋体">订单签订地点：</FONT></td>
												<td width="35%"><asp:textbox id="OrderAdd" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">订单履行地点：</FONT></td>
												<td width="35%"><asp:textbox id="LxAdd" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">进货仓：</FONT></td>
												<td width="35%"><asp:textbox id="Storeroom" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">收货日期：</FONT></td>
												<td width="35%"><asp:textbox id="ShTime" runat="server" Width="100%"  DataType="DateTime"></asp:textbox>
													<script>SetNeed('ShTime')</script>
													</FONT><A href="javascript:void(0)"></A></td>
												<td align="right" width="15%"><FONT face="宋体">部门：</FONT></td>
												<td width="35%"><asp:textbox id="Unit" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">供应商地址：</FONT></td>
												<td width="35%"><asp:textbox id="CompanyAdd" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right">金额总计：</td>
												<td><asp:textbox id="AllMoney" runat="server" Width="100%" ></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right">采购员姓名：</td>
												<td><asp:textbox id="StockPeoName" runat="server" Width="100%" ></asp:textbox></td>
												<td align="right"><FONT face="宋体">录入人：</FONT></td>
												<td>
													<asp:textbox id="realname" runat="server"  Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">选择审批流程：</FONT></td>
												<td colSpan="3"><asp:textbox id="CgStreamName" runat="server" Width="100%" ></asp:textbox></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">订单备注：</FONT></td>
												<td colSpan="3"><asp:textbox id="OrderRemark" runat="server" Width="100%"  Height="52px" TextMode="MultiLine"></asp:textbox></FONT></td>
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
																<asp:BoundColumn DataField="GoodsName" SortExpression="GoodsName" HeaderText="商品名称">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="CountUnit" SortExpression="CountUnit" HeaderText="计量单位">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="Model" SortExpression="Model" HeaderText="规格型号">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="StockPoint" SortExpression="StockPoint" HeaderText="采购数量">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="SingleMoney" SortExpression="SingleMoney" HeaderText="单价"></asp:BoundColumn>
																<asp:BoundColumn DataField="Allmoney" SortExpression="Allmoney" HeaderText="采购总金额">
																	<HeaderStyle Wrap="False"></HeaderStyle>
																	<ItemStyle Wrap="False"></ItemStyle>
																</asp:BoundColumn>
																<asp:BoundColumn DataField="Stocktype" SortExpression="Stocktype" HeaderText="订购方式"></asp:BoundColumn>
															</Columns>
															<PagerStyle Visible="False" NextPageText="下一页" PrevPageText="上一页" HorizontalAlign="Right" ForeColor="White"
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
											<td width="9%">
												<asp:ImageButton id="ImageButton3" runat="server" ImageUrl="i_blue/ok.jpg" onmouseover="selstr()"></asp:ImageButton></td>
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
			</TR></TBODY></TABLE><asp:textbox id="CompanyNumber" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StockPeoNum" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="CgStreamNumber" style="DISPLAY: none" runat="server" ></asp:textbox>
			<script language="javascript">	
var  wName_2;  
function  khOpen()  
{  

			if(document.getElementById('title').value!='')
			{
				alert('该供应商已经对应了订单，请先清空当前订单信息');
			
				return false;
			}	
		     
            
            
            
var num=Math.random();
wName_2=window.showModalDialog("open_Company.aspx?tmp="+num+"&key=0 ","window","dialogWidth:800px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
var arr = wName_2.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("CompanyNumber").value=arr[0]; 
document.getElementById("CompanyName").value=arr[1]; 


}


}
			</script>
			<script language="javascript">	
				  		var  wName_3;  
        function  usOpen()  
            {  

            
            var num=Math.random();
                wName_3=window.showModalDialog("open_manage.aspx?tmp="+num+" ","window","dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
         
                
var arr = wName_3.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("JbName").value=arr[0]; 
document.getElementById("JbPeoNum").value=arr[2]; 

}


}


			function drdd()
			{


	    	if(document.getElementById('CompanyName').value=='')
			{
				alert('供应商不能为空\n选择订单将对应该供应商');
				Form1.CompanyName.focus();
				return false;
			}	
			else
			{
			     var num=Math.random();
				 var number=document.getElementById('number').value;
				 var CompanyNumber=document.getElementById('CompanyNumber').value;
				 wName_dd=window.showModalDialog("open_StockOutMoney_Order.aspx?tmp="+num+"&number="+number+"&CompanyNumber="+CompanyNumber+"","window","dialogWidth:700px;DialogHeight=600px;status:no;scroll=yes;help:no");			
			
var arr = wName_dd.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("number").value=arr[0]; 
document.getElementById("title").value=arr[1]; 

}
			
			}
			
			
			}	
			</script>
			<script language="javascript">	
				 
	
			var  wName_5;  
        function  splc()  
            {  
            var num=Math.random();
                wName_5=window.showModalDialog("open_Cgfk_stream.aspx?tmp="+num+"","window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");                
              
         
                
var arr = wName_5.split("|");
for(var i=0;i<arr.length;i++)
{ 

document.getElementById("StreamName").value=arr[0]; 
document.getElementById("StreamNumber").value=arr[1]; 
}


}

			</script>
		</form>
	</body>
</HTML>
