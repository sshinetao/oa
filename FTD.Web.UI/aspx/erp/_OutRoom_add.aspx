<%@ Page language="c#" Codebehind="_OutRoom_add.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.OutRoom_add" %>
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

          <link href="../../Controls/easyui/themes/default/easyui.css" rel="stylesheet" />
        <script src="../../Controls/My97DatePicker/WdatePicker.js"></script>
        <script src="../../Controls/easyui/jquery.min.js"></script>
        <script src="../../Controls/easyui/jquery.easyui.min.js"></script>
		
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">����̨</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="OutRoom.aspx">����</A>&nbsp;&gt;&gt; 
									��������</td>
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
												<td align="right" width="15%"><FONT face="����">���⣺</FONT></td>
												<td width="35%"><asp:textbox id="title" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">���ʱ�䣺</FONT></td>
												<td width="35%">
													<asp:textbox id="ThTime" runat="server" Width="90%" DataType="DateTime"  onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})"></asp:textbox>
													
												</td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">����ˣ�</td>
												<td width="35%"><asp:textbox id="ThPeople" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="����">����˵绰��</FONT></td>
												<td width="35%"><asp:textbox id="Tel" runat="server" Width="100%"></asp:textbox></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%" style="HEIGHT: 33px"><FONT face="����">�����֣�</FONT></td>
												<td width="35%" style="HEIGHT: 33px">
                                                          <asp:DropDownList ID="ddlStoreroom" runat="server" Width="90%"></asp:DropDownList>
                                                
												</td>
												<td align="right" style="HEIGHT: 33px">������;</td>
												<td style="HEIGHT: 33px">
                                                    <asp:DropDownList ID="ddlSource" runat="server" Width="90%"></asp:DropDownList>

												</td>
											</tr>
										
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="����">ժҪ��</FONT></td>
												<td colSpan="3"><asp:textbox id="Remark" runat="server" Width="100%" TextMode="MultiLine" Height="52px"></asp:textbox><A href="javascript:void(0)"></A></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td width="100%" colSpan="4">
                                                    <link href="../../Controls/easyui/themes/icon.css" rel="stylesheet" />
                                                    <table id="dg" class="easyui-datagrid" title="ѡ����Ʒ" style="width:100%;height:auto"
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
                              var rowIndex = $('#dg').datagrid('getRowIndex',row);//��ȡ�к�                          
                                     var ed = $('#dg').datagrid('getEditor', {index:rowIndex,field:'countunit'});                     
	                            row.countunit = '��';  
                                }
                               
							}
						}">��Ʒ����</th>
                <th data-options="field:'itemid',width:100,hidden:'true'">���</th>
				<th data-options="field:'countunit',width:80,align:'right'">������λ</th>
				<th data-options="field:'unitcost',width:80,align:'right',editor:{type:'numberbox',options:{precision:2}},">�ɹ�����</th>
				<th data-options="field:'price',width:250,editor:{type:'numberbox',options:{precision:2}}">����</th>
				<th data-options="field:'allprice',width:250">�ܼ�</th>
			</tr>
		</thead>
	</table>

	<div id="tb" style="height:auto">
		<a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-add',plain:true" onclick="append()">�����Ʒ</a>
		<a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-remove',plain:true" onclick="removeit()">ɾ����Ʒ</a>
		<a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-save',plain:true" onclick="accept()">����</a>
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
	        var ordernum = "";
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
	            $('#dg').datagrid('appendRow', { itemid: RndNum(4) });
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

	    function del(_itemid) {
	    }



	    function accept() {
	        if (endEditing()) {
	            $('#dg').datagrid('acceptChanges');
	        }
	    }

	    function CheckClientValidationState() {

	        var _shtime = document.getElementById('ShTime').value;;

	        var _Tel = "";

	        var _StockPeoNum = document.getElementById('StockPeoNum').value;;

	        var _StockPeoName = document.getElementById('StockPeoName').value;;



	        var _StreamNumber = $('select#ddlXsdd_WorkStreamType option:selected').val(); //document.getElementById('StreamNumber').value;

	        var _Storeroom = $('select#ddlStoreroom option:selected').val();
	        var _Source = $('select#ddlSource option:selected').val();

	        if (_StockPeoName == null || _StockPeoName == "") {
	            alert('����������������');
	            return false;
	        }

	        var uname = document.getElementById('uname').value;
	        var rname = document.getElementById('rname').value;
	        var number = document.getElementById('number').value;

	        if (endEditing()) {

	            $('#dg').datagrid('acceptChanges');
	            var rows = $("#dg").datagrid("getRows"); //��δ����ǻ�ȡ��ǰҳ�������С�
	            var k = false;
	            var k2 = "";
	            var _res = false;
	            var _All = 0;
	            for (var i = 0; i < rows.length; i++) {   // ÿ�α���һ�� ���۵�����
	                var row2 = rows[i];
	                _All += row2.allprice;
	                var ordernum = "";
	                var _json = jQuery.param({ "gname": row2.productname, "price": row2.price, "unitcost": row2.unitcost, "uname": uname, "rname": rname, 'number': number, 'itemid': row2.itemid });
	                var request = $.ajax({
	                    url: "../ashx/getIncome.ashx?type=save",
	                    type: "POST",
	                    async: false,
	                    data: _json,
	                    dataType: "json",
	                    cache: false,
	                    success: function (r, textStatus) {

	                    },
	                    error: function (XMLHttpRequest, textStatus, errorThrown) { _res = false; }
	                });

	            }

	            //������ⵥ

	            var _json3 = jQuery.param({ "uname": uname, "rname": rname, "number": number, "ShTime": _shtime, 'StockPeoNum': _StockPeoNum, 'StockPeoName': _StockPeoName, 'StreamNumber': _StreamNumber, 'StreamName': _StreamNumber, 'Storeroom': _Storeroom, 'InSource': _Source });
	            var request3 = $.ajax({
	                url: "../ashx/getIncome.ashx?type=order2",
	                type: "POST",
	                async: false,
	                data: _json3,
	                dataType: "json",
	                cache: false,
	                success: function (r, textStatus) {
	                    if (textStatus == 'success') {
	                        var msg = "���Ѿ��ɹ����һ����ͨ��Ա������\n\n��Ҫ����µĶ�����";
	                        if (confirm(msg) == true) {
	                            location.reload();
	                            return true;
	                        } else {
	                            window.location.href = "SellOrder.aspx";
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
							</tr>
						</table>
						<table height="25" cellSpacing="0" cellPadding="0" width="100%" border="0">
							<tr>
								<td background="i_blue/third_head_bg1.jpg">
									<table cellSpacing="0" cellPadding="0" width="100%" border="0">
										<tr>
											<td width="39%">&nbsp;</td>
											<td width="9%">
                                                <input type="button" onclick="CheckClientValidationState();" value="�ύ" /></td>
											<td width="52%"></td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
			<asp:textbox id="number" runat="server"  style="DISPLAY: none"></asp:textbox>
            
            
			<asp:textbox id="uname" style="DISPLAY: none" runat="server" ></asp:textbox>
			<asp:textbox id="rname" style="DISPLAY: none" runat="server" ></asp:textbox>
            
            </TD>
			<td width="15">&nbsp;</td>
			</TR></TBODY></TABLE><asp:textbox id="CompanyNumber" runat="server" style="DISPLAY: none"></asp:textbox><asp:textbox id="StockPeoNum" runat="server" style="DISPLAY: none"></asp:textbox><asp:textbox id="StreamNumber" runat="server"  style="DISPLAY: none"></asp:textbox>
			
		</form>
	</body>
</HTML>
