﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellOrder_update.aspx.cs" Inherits="FTD.Web.UI.aspx.HY.SellOrder_update" %>
<%@ Register TagPrefix="uc1" TagName="fenye" Src="../erp/fenye.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../erp/i_blue/ny.css" type="text/css" rel="stylesheet">
  <script src="../../Controls/My97DatePicker/WdatePicker.js" type="text/javascript"></script>
		<script>
		    function killErrors() {
		        return true;
		    }
		    window.onerror = killErrors;

		    function del() {
		        if (!confirm("是否确定删除？"))
		            return false;
		    }


		    function chknull() {


		        if (document.getElementById('tilte').value == '') {
		            alert('标题不能为空');
		            Form1.tilte.focus();
		            return false;
		        }

		        if (document.getElementById('unit').value == '') {
		            alert('部门不能为空');

		            return false;
		        }

		        if (document.getElementById('Storeroom').value == '') {
		            alert('仓库不能为空');

		            return false;
		        }



		        val = parseInt(document.getElementById('Discount').value);
		        if (val > 1) {
		            alert('折扣不能大于1');

		            return false;
		        }


		    }


		    function drjh() {


		        if (document.getElementById('CompanyName').value == '') {
		            alert('客户不能为空\n导入计划内容将对应此客户');
		            Form1.CompanyName.focus();
		            return false;
		        }

		        else if (!confirm("系统将清空当前订单明细列表，是否导入？")) {
		            return false;
		        }
		        else {



		            var num = Math.random();
		            var number = document.getElementById('number').value;
		            var CompanyNumber = document.getElementById('CompanyNumber').value;
		            window.showModalDialog("../erp/open_SellQuoteMx.aspx?tmp=" + num + "&number=" + number + "&CompanyNumber=" + CompanyNumber + "", "window", "dialogWidth:700px;DialogHeight=600px;status:no;scroll=yes;help:no");
		        }





		    }

		    var wName;
		    function fnOpen() {
		        var num = Math.random();
		        wName = window.showModalDialog("../erp/posttype_open.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");

		        if (wName != null && wName != "undefined") {

		            document.getElementById("unit").value = wName;
		            return;
		        }


		    }

		    var wName_ddlx;
		    function ddlxOpen() {
		        var num = Math.random();
		        wName_ddlx = window.showModalDialog("../erp/open_OrderType.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");

		        if (wName_ddlx != null && wName_ddlx != "undefined") {

		            document.getElementById("Type").value = wName_ddlx;
		            return;
		        }


		    }


		    var wNamekf;
		    function jhcOpen() {
		        var num = Math.random();
		        wNamekf = window.showModalDialog("../erp/open_Storeroom.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");

		        if (wNamekf != null && wNamekf != "undefined") {

		            document.getElementById("Storeroom").value = wNamekf;
		            return;
		        }


		    }

		    function zjOpen() {
		        var num = Math.random();
		        var number = document.getElementById('number').value;
		        window.showModalDialog("../erp/SellOrder_insert_add.aspx?tmp=" + num + "&number=" + number + " ", "window", "dialogWidth:700px;DialogHeight=400px;status:no;scroll=yes;help:no");




		    }


		    var wNamefp;
		    function fpOpen() {
		        var num = Math.random();
		        wNamefp = window.showModalDialog("../erp/open_InvoiceType.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");

		        if (wNamefp != null && wNamefp != "undefined") {

		            document.getElementById("InvoiceType").value = wNamefp;
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
					<td width="16" background="../erp/i_blue/m_head_3.jpg"><IMG height="34" src="../erp/i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="../erp/i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="SellOrder.aspx">销售订单</A>&nbsp;&gt;&gt; 
									修改销售订单</td>
							</tr>
						</table>
					</td>
					<td width="23"><IMG height="34" src="../erp/i_blue/m_head_2.jpg" width="21"></td>
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
											<td background="../erp/i_blue/third_head_bg.jpg">&nbsp;
												<asp:imagebutton id="ImageButton3"  runat="server" ImageUrl="../erp/i_blue/zenghang.jpg" ></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>
												<asp:imagebutton id="ImageButton4"  runat="server" ImageUrl="../erp/i_blue/xiugai.jpg" ></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>
												<asp:imagebutton id="ImageButton5"  runat="server" ImageUrl="../erp/i_blue/shanchu.jpg" OnClick="ImageButton5_Click1"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT> </td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
										<tr bgColor="#f3f8fe">
												<td align="right" width="15%">客户名称：</td>
												<td width="35%"><asp:textbox id="CompanyName" runat="server" Width="90%" ></asp:textbox></td>
												<td align="right">客户地址：</td>
												<td><asp:textbox id="CompanyAdd" runat="server" Width="100%"></asp:textbox></td>
											</tr>
										
											<tr bgColor="#f3f8fe">
                                                <td align="right" width="15%">电话：</td>
												<td width="35%"><asp:textbox id="Tel" runat="server" Width="100%" ></asp:textbox></td>
											
												<td align="right" width="15%">发货日期：</td>
												<td width="35%"><asp:textbox id="ShTime" runat="server" Width="90%"  DataType="DateTime" onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})"></asp:textbox>
													</td>
											</tr>
											<tr bgColor="#f3f8fe">
													</tr>
											
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">折扣率：</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="Discount" ondragenter="return false" style="IME-MODE: disabled" onmouseout="selstr()" runat="server"
														Width="100%">1</asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">总金额(未打折)：</FONT></td>
												<td width="35%"><asp:textbox onkeypress="var k=event.keyCode; return (k>=48&amp;&amp;k<=57)||k==46" onpaste="return !/\D/.test(clipboardData.getData('text'))"
														id="AllMoney" ondragenter="return false" style="IME-MODE: disabled" onmouseout="selstr()" runat="server"
														Width="100%">0</asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
                                                <td align="right">业务员姓名：</td>
												<td colSpan="3"><asp:textbox id="StockPeoName" runat="server" Width="90%" ></asp:textbox></td>
										
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">订单备注：</FONT></td>
												<td colSpan="3"><asp:textbox id="Remark" runat="server" Width="100%" Height="52px" TextMode="MultiLine"></asp:textbox><A href="javascript:void(0)"></A></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td width="100%" colSpan="4">
													<div class="mainDiv"><asp:datagrid id="Datagrid2" runat="server" AllowPaging="True" BorderWidth="1px" OnPageIndexChanged="MyDataGrid_Page_1"
															PageSize="12" CellPadding="3" BorderColor="#4D77B1" AutoGenerateColumns="False" BackColor="White" GridLines="Vertical"
															BorderStyle="None" Width="100%">
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
								<td background="../erp/i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%"><asp:imagebutton id="ImageButton1" runat="server" ImageUrl="../erp/i_blue/ok.jpg" OnClick="ImageButton1_Click2" style="height: 19px" ></asp:imagebutton></td>
											<td width="52%"><asp:imagebutton id="ImageButton2" runat="server" ImageUrl="../erp/i_blue/back.jpg" OnClick="ImageButton2_Click1" ></asp:imagebutton></td>
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
			    var wName_2;
			    function khOpen() {
			        var num = Math.random();
			        wName_2 = window.showModalDialog("open_Company.aspx?tmp=" + num + "&key=1 ", "window", "dialogWidth:800px;DialogHeight=500px;status:no;scroll=yes;help:no");

			        var arr = wName_2.split("|");
			        for (var i = 0; i < arr.length; i++) {

			            document.getElementById("CompanyNumber").value = arr[0];
			            document.getElementById("CompanyName").value = arr[1];
			            document.getElementById("BankNumber").value = arr[2];
			            document.getElementById("TaxNumber").value = arr[3];
			            document.getElementById("Bank").value = arr[4];
			        }


			    }
			</script>
			<script language="javascript">
			    var wName_3;
			    function usOpen() {
			        var num = Math.random();
			        wName_3 = window.showModalDialog("open_manage.aspx?tmp=" + num + " ", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");



			        var arr = wName_3.split("|");
			        for (var i = 0; i < arr.length; i++) {

			            document.getElementById("StockPeoName").value = arr[0];
			            document.getElementById("StockPeoNum").value = arr[2];

			        }


			    }
			</script>
			<script language="javascript">


			    var wName_5;
			    function splc() {
			        var num = Math.random();
			        wName_5 = window.showModalDialog("open_Xsdd_stream.aspx?tmp=" + num + "", "window", "dialogWidth:500px;DialogHeight=500px;status:no;scroll=yes;help:no");



			        var arr = wName_5.split("|");
			        for (var i = 0; i < arr.length; i++) {

			            document.getElementById("StreamName").value = arr[0];
			            document.getElementById("StreamNumber").value = arr[1];
			        }


			    }

			</script>
		</form>
	</body>
</HTML>
