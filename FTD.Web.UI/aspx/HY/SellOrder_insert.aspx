<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SellOrder_insert.aspx.cs" Inherits="FTD.Web.UI.aspx.HY.SellOrder_insert" %>

<%@ Register TagPrefix="uc1" TagName="fenye" Src="../erp/fenye.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
        <meta charset="UTF-8">
		<title>畲森山进销存</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="../erp/i_blue/ny.css" type="text/css" rel="stylesheet">
  <script src="../../Controls/My97DatePicker/WdatePicker.js" type="text/javascript"></script>

		
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="100%" border="0">
				<tr>
					<td width="16" background="../erp/i_blue/m_head_3.jpg"><IMG height="34" src="../erp/i_blue/m_head_1.jpg" width="20"></td>
					<td width="748" background="../erp/i_blue/m_head_3.jpg">
						<table height="25" cellSpacing="0" cellPadding="0" width="92%" border="0">
							<tr>
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="SellOrder.aspx">销售订单</A>&nbsp;&gt;&gt; 
									新增销售订单</td>
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
												<td width="35%">
                                                    <asp:textbox id="ShTime" runat="server" Width="90%"  DataType="DateTime" onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})"></asp:textbox>
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
													<div class="mainDiv">
                                                        <asp:datagrid id="Datagrid2" runat="server" AllowPaging="True" BorderWidth="1px" OnPageIndexChanged="MyDataGrid_Page_1"
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
                                            <tr>
                                                <td width="100%" colSpan="4">
                                                    <link href="../../Controls/easyui/themes/default/easyui.css" rel="stylesheet" />
                                                    <link href="../../Controls/easyui/themes/icon.css" rel="stylesheet" />
                                                    <script src="../../Controls/easyui/jquery.min.js"></script>
                                                    <script src="../../Controls/easyui/jquery.easyui.min.js"></script>
                                                    <table id="dg" class="easyui-datagrid" title="选择商品" style="width:100%;height:auto"
			data-options="
                                                       
				iconCls: 'icon-edit',
				singleSelect: true,
				toolbar: '#tb',
				url: '../ashx/getproduct.ashx?type=sell',
				method: 'get',
				onClickCell: onClickCell,
				onEndEdit: onEndEdit
			">
		<thead>
			<tr>
				<th data-options="field:'productname',width:100,
						formatter:function(value,row){
                                   
							return row.productname;
						},
						editor:{
							type:'combobox',
							options:{
								valueField:'productname',
								textField:'productname',
								method:'get',
								url:'../ashx/getproduct.ashx?type=ck',
								required:true,
                            onSelect:function() {
                              
                                },
                             onChange: function (n,o)
                                {
                               var varSelect = $(this).combobox('getValue');
                              var row = $('#dg').datagrid('getSelected');
                              var rowIndex = $('#dg').datagrid('getRowIndex',row);//获取行号                          
                                     var ed = $('#dg').datagrid('getEditor', {index:rowIndex,field:'countunit'});                     
	                            row.countunit = '斤';  
                                }
                               
							}
						}">产品名称</th>
                <th data-options="field:'itemid',width:100,hidden:'true'">编号</th>
				<th data-options="field:'countunit',width:80,align:'right'">计量单位</th>
				<th data-options="field:'unitcost',width:80,align:'right',editor:{type:'numberbox',options:{precision:2}},">采购数量</th>
				<th data-options="field:'price',width:250,editor:{type:'numberbox',options:{precision:2}}">单价</th>
				<th data-options="field:'allprice',width:250">总价</th>
                <th data-options="field:'allprice',width:250">操作</th>
			</tr>
		</thead>
	</table>

	<div id="tb" style="height:auto">
		<a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-add',plain:true" onclick="append()">添加商品</a>
		<a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-remove',plain:true" onclick="removeit()">删除商品</a>
		<a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-save',plain:true" onclick="accept()">保存</a>
		</div>
	
	<script type="text/javascript">
	    var editIndex = undefined;
	    function endEditing() {
	        if (editIndex == undefined) { return true }
	        if ($('#dg').datagrid('validateRow', editIndex)) {
	            $('#dg').datagrid('endEdit', editIndex);
	            editIndex = undefined;
	            return true;
	        } else {
	            return false;
	        }
	    }
	    function onClickCell(index, field) {
	        if (editIndex != index) {
	            if (endEditing()) {
	                $('#dg').datagrid('selectRow', index)
							.datagrid('beginEdit', index);
	                var ed = $('#dg').datagrid('getEditor', { index: index, field: field });
	                if (ed) {
	                    ($(ed.target).data('textbox') ? $(ed.target).textbox('textbox') : $(ed.target)).focus();
	                }
	                editIndex = index;
	            } else {
	                setTimeout(function () {
	                    $('#dg').datagrid('selectRow', editIndex);
	                }, 0);
	            }
	        }
	    }
	    function onEndEdit(index, row) {
	        var ed = $(this).datagrid('getEditor', {
	            index: index,
	            field: 'productname'
	        });
	        
	        row.productname = $(ed.target).combobox('getText');

	        var ed2 = $(this).datagrid('getEditor', {
	            index: index,
	            field: 'unitcost'
	        });

	        var v2 = $(ed2.target).numberbox('getValue');
	        var ed3 = $(this).datagrid('getEditor', {
	            index: index,
	            field: 'price'
	        });

	        var v3 = $(ed3.target).numberbox('getValue');
	        var _price = v2 * v3;
	        row.allprice = _price;
	        var _itemid = row.itemid;
	       // SaveSellOrder(row.productname, v3, v2, _itemid);
	        return false;
	    }


	    function SaveSellOrder(productname, price, unitcost, _itemid) {
	        var uname = document.getElementById('uname').value;
	        var rname = document.getElementById('rname').value;
	        var number = document.getElementById('number').value;
	        var ordernum ="";
	        var _json = jQuery.param({ "gname": productname, "price": price, "unitcost": unitcost, "uname": uname, "rname": rname, 'number': number, 'itemid': _itemid });
	        var request = $.ajax({
	            url: "../ashx/getproduct.ashx?type=save",
	            type: "POST",
	            async: false,
	            data: _json, 
	            dataType: "json",
	            cache: false,
	            success: function (r, textStatus) {
	                return true;
	            },
	            error: function (XMLHttpRequest, textStatus, errorThrown) { return false; }
	        });
	        return false;
	       
	    }


	    function RndNum(n) {

	        var rnd = "";

	        for (var i = 0; i < n; i++)

	            rnd += Math.floor(Math.random() * 10);

	        return rnd;

	    }


	    function append() {
	        if (endEditing()) {
	            $('#dg').datagrid('appendRow', { itemid:RndNum(4) });
	            editIndex = $('#dg').datagrid('getRows').length - 1;
	            $('#dg').datagrid('selectRow', editIndex)
						.datagrid('beginEdit', editIndex);
	        }
	    }
	    function removeit() {
	        if (editIndex == undefined) { return }
	        $('#dg').datagrid('cancelEdit', editIndex)
					.datagrid('deleteRow', editIndex);
	        var rows = $('#dg').datagrid('getRows');
	        var row = rows[editIndex];
	        var _itemid = row.itemid;
	        var number = document.getElementById('number').value;
	        var ordernum = "";
	        var _json = jQuery.param({ 'number': number, 'itemid': _itemid });
	        var request = $.ajax({
	            url: "../ashx/getproduct.ashx?type=del",
	            type: "POST",
	            async: false,
	            data: _json, 
	            dataType: "json",
	            cache: false,
	            success: function (r, textStatus) {
	                alert(1);
	            },
	            error: function (XMLHttpRequest, textStatus, errorThrown) { }
	        });
	        editIndex = undefined;
	    }

	    function del(_itemid)
	    {	       
	    }



	    function accept() {
	        if (endEditing()) {
	            $('#dg').datagrid('acceptChanges');	            
	        }	        
	    }
	  
	    function CheckClientValidationState() {


	        var _shtime = document.getElementById('ShTime').value;;
	        var _companyAdd = document.getElementById('CompanyAdd').value;;
	        var _CompanyName = document.getElementById('CompanyName').value;;
	        var _Tel = document.getElementById('Tel').value;;
	        var _StockPeoNum = document.getElementById('StockPeoNum').value;;
	        var _StockPeoName = document.getElementById('StockPeoName').value;;
	        var _Discount = document.getElementById('Discount').value;;
	        var _AllMoney = document.getElementById('AllMoney').value;;
	        var _Remark = document.getElementById('Remark').value;;
	        var _StreamNumber = document.getElementById('StreamNumber').value;;
	        if (_CompanyName == null || _CompanyName == "")
	        {
	            alert('请输入客户名称');
	            return false;
	        }
	        if (_companyAdd == null || _companyAdd == "") {
	            alert('请输入客户送货地址');
	            return false;
	        }
	        if (_Tel == null || _Tel == "") {
	            alert('请输入客户地址');
	            return false;
	        }
	        if (endEditing()) {
	            $('#dg').datagrid('acceptChanges');
	            var rows = $("#dg").datagrid("getRows"); //这段代码是获取当前页的所有行。
	            var k = false;
	            var k2 = "";
	            var _res = false;
	            var uname = document.getElementById('uname').value;
	            var rname = document.getElementById('rname').value;
	            var number = document.getElementById('number').value;
	            var _All = 0;
	            for (var i = 0; i < rows.length; i++) {   // 每次保存一次 销售单内容
	                var row2 = rows[i];
	                _All += row2.allprice;
	                var ordernum = "";
	                var _json = jQuery.param({ "gname": row2.productname, "price": row2.price, "unitcost": row2.unitcost, "uname": uname, "rname": rname, 'number': number, 'itemid': row2.itemid });
	                var request = $.ajax({
	                    url: "../ashx/getproduct.ashx?type=save",
	                    type: "POST",
	                    async: false,
	                    data: _json,
	                    dataType: "json",
	                    cache: false,
	                    success: function (r, textStatus) {
	                       
	                    },
	                    error: function (XMLHttpRequest, textStatus, errorThrown) { _res= false; }
	                });	               

	            }

	            alert(_All);
                //保存销售客户单

	            var _json3 = jQuery.param({ "uname": uname, "rname": rname, "number": number, "ShTime": _shtime, 'CompanyAdd': _companyAdd, 'CompanyName': _CompanyName, 'Tel': _Tel, 'StockPeoNum': _StockPeoNum, 'StockPeoName': _StockPeoName, 'Discount': _Discount, 'AllMoney': _AllMoney, 'StreamNumber': _StreamNumber });
	            var request3 = $.ajax({
	                url: "../ashx/getproduct.ashx?type=order",
	                type: "POST",
	                async: false,
	                data: _json3,
	                dataType: "json",
	                cache: false,
	                success: function (r, textStatus) {
	                    if(textStatus=='success')
	                    {
	                        var msg = "您已经成功添加一条普通会员订单，\n\n需要添加新的订单吗？";
	                        if (confirm(msg) == true) {
	                            location.reload();
	                            return true;
	                        } else {
	                            window.location.href = "SellOrderList.aspx";
	                            return false;
	                        }
	                    }

	                },
	                error: function (XMLHttpRequest, textStatus, errorThrown) {
	                    if (textStatus == 'error') {

	                    }
	                }
	            });
	            
	           
	                return true;
	            


	        }
	        else {
	            return false;
	        }
	    }

	</script>

                                                </td>

							</tr>
						</table>
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td background="../erp/i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>


											<td width="9%">
                                                <input type="button" onclick="CheckClientValidationState();" value="提交" />
                                              </td>
											<td width="52%"></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<asp:textbox id="number" style="DISPLAY: none" runat="server" ></asp:textbox>
			<asp:textbox id="uname" style="DISPLAY: none" runat="server" ></asp:textbox>
			<asp:textbox id="rname" style="DISPLAY: none" runat="server" ></asp:textbox>


					</TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE><asp:textbox id="StockPeoNum" style="DISPLAY: none" runat="server"></asp:textbox><asp:textbox id="StreamNumber" style="DISPLAY: none" runat="server" ></asp:textbox>
		
		</form>
	</body>
</HTML>
