<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IncomeRoom_add.aspx.cs" Inherits="FTD.Web.UI.aspx.erp.IncomeRoom_add" %>

<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<!DOCTYPE >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
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
								<td class="headfont" width="97%"><A class="line_b" href="main_1.aspx">工作台</A>&nbsp;&gt;&gt;&nbsp;<A class="line_b" href="IncomeRoom.aspx">入库</A>&nbsp;&gt;&gt; 
									新增入库</td>
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
												<asp:imagebutton id="ImageButton3" runat="server" ImageUrl="i_blue/zenghang.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>
												<asp:imagebutton id="ImageButton4" runat="server" ImageUrl="i_blue/xiugai.jpg"></asp:imagebutton><FONT face="宋体">&nbsp;</FONT>
												<asp:imagebutton id="ImageButton5" runat="server" ImageUrl="i_blue/shanchu.jpg"></asp:imagebutton><FONT face="宋体"></FONT></td>
										</tr>
									</table>
									<table cellSpacing="1" cellPadding="4" width="100%" bgColor="#d8e1e8" border="0">
										<TBODY>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%"><FONT face="宋体">标题：</FONT></td>
												<td width="35%"><asp:textbox id="title" runat="server" Width="100%"></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">入库时间：</FONT></td>
												<td width="35%">
													<asp:textbox id="ShTime" runat="server" Width="90%" DataType="DateTime"  onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})" ></asp:textbox>
													
												</td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%">仓管：</td>
												<td width="35%"><asp:textbox id="StockPeoName" runat="server" Width="90%" ></asp:textbox></td>
												<td align="right" width="15%"><FONT face="宋体">进货仓：</FONT></td>
												<td width="35%">
                                                   
                                                     <asp:DropDownList ID="ddlStoreroom" runat="server" Width="90%"></asp:DropDownList>
                                                </td>
											</tr>
											<tr bgColor="#f3f8fe">
												<td align="right" width="15%" style="HEIGHT: 33px"><FONT face="宋体">采购员：</FONT></td>
												<td width="35%" style="HEIGHT: 33px;display:none" >
                                                     <asp:DropDownList  ID="ddlSource" runat="server" Width="90%"></asp:DropDownList></td>
                                                    <td style="HEIGHT: 33px"><asp:textbox id="caigouyuan" runat="server" Width="100%" ></asp:textbox></td>
											</td>
												<td align="right" style="HEIGHT: 33px"><FONT face="宋体">状态：</FONT></td>
												<td style="HEIGHT: 33px"><asp:textbox id="Balance" runat="server" Width="100%" >录入中..</asp:textbox></td>
											</tr>
										    <tr bgColor="#f3f8fe">
                                                   <td align="right" width="15%" style="HEIGHT: 33px"><FONT face="宋体">入库类型：</FONT></td>
                                                <td width="35%" style="HEIGHT: 33px" >
                                                     <asp:DropDownList  ID="rukuleixing" runat="server" Width="90%"></asp:DropDownList></td>
                                                     
										    </tr>
											<tr bgColor="#f3f8fe">
												<td align="right"><FONT face="宋体">摘要：</FONT></td>
												<td colSpan="3"><asp:textbox id="Remark" runat="server" Width="100%" TextMode="MultiLine" Height="52px"></asp:textbox><A href="javascript:void(0)"></A></FONT></td>
											</tr>
											<tr bgColor="#f3f8fe">
												 <td width="100%" colspan="4" id="td1" >
                                                <link href="../../Controls/easyui/themes/icon.css" rel="stylesheet" />
                                                <table id="dg1" class="easyui-datagrid" title="选择商品" style="width: 100%; height: auto"
                                                    data-options="                                                       
				                                                iconCls: 'icon-edit',
				                                                singleSelect: true,
				                                                toolbar: '#tb1',
				                                                url: '../ashx/caigou.ashx?type=sell',
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
								url:'../ashx/caigou.ashx?type=ck',
								required:true,
                            onSelect:function() {
                                },
                             onChange: function (n,o)
                                {
                               var varSelect = $(this).combobox('getValue');
                              var row = $('#dg1').datagrid('getSelected');
                              var rowIndex = $('#dg1').datagrid('getRowIndex',row);//获取行号                          
                                     var ed = $('#dg1').datagrid('getEditor', {index:rowIndex,field:'countunit'});                     
	                            row.countunit = '斤';  
                                }
                               
							}
						}">产品名称</th>
                                                            <th data-options="field:'itemid',width:100,hidden:'true'">编号</th>
                                                            <th data-options="field:'zhongzhihu',width:180,align:'left',editor:{type:'textbox'}">种植户</th>
                                                            <th data-options="field:'countunit',width:80,align:'left'">计量单位</th>
                                                            <th data-options="field:'unitcost',width:80,align:'left',editor:{type:'numberbox',options:{precision:2}}">数量</th>
                                                            <th data-options="field:'price',width:250,editor:{type:'numberbox',options:{precision:2}}">单价</th>
                                                            <th data-options="field:'allprice',width:250">总价</th>
                                                            <th data-options="field:'beizhu',width:250,hidden:'true'">备注</th>
                                                            <th data-options="field:'zhuangtai',width:100,editor:{type:'combobox',options:{data:[{'value':'1','text':'月结'},{'value':'2','text':'现付'}],valueField:'text',textField:'text'}}">状态</th>
                                                            
                                                        </tr>

                                                    </thead>
                                                </table>




                                                <div id="tb1" style="height: auto">
                                                    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-add',plain:true" onclick="append('1')">添加商品</a>
                                                    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-remove',plain:true" onclick="removeit('1')">删除商品</a>
                                                    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-save',plain:true" onclick="accept('1')">保存</a>
                                                </div>



                                            </td>
                                            <td width="100%" colspan="4" id="td2" style="display:none">
                                                <link href="../../Controls/easyui/themes/icon.css" rel="stylesheet" />
                                                <table id="dg2" class="easyui-datagrid" title="选择商品" style="width: 100%; height: auto"
                                                    data-options="                                                       
				                                                iconCls: 'icon-edit',
				                                                singleSelect: true,
				                                                toolbar: '#tb2',
				                                                url: '../ashx/caigou.ashx?type=sell',
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
								url:'../ashx/caigou.ashx?type=ck',
								required:true,
                            onSelect:function() {
                                },
                             onChange: function (n,o)
                                {
                               var varSelect = $(this).combobox('getValue');
                              var row = $('#dg2').datagrid('getSelected');
                              var rowIndex = $('#dg2').datagrid('getRowIndex',row);//获取行号                          
                                     var ed = $('#dg2').datagrid('getEditor', {index:rowIndex,field:'countunit'});                     
	                            row.countunit = '斤';  
                                }
                               
							}
						}">产品名称</th>
                                                            <th data-options="field:'itemid',width:100,hidden:'true'">编号</th>
                                                            <th data-options="field:'zhongzhihu',width:80,align:'left',editor:{type:'textbox'},hidden:'true'">种植户</th>
                                                            <th data-options="field:'countunit',width:80,align:'left',hidden:'true'">计量单位</th>
                                                            <th data-options="field:'unitcost',width:80,align:'left',editor:{type:'numberbox',options:{precision:2}},">数量</th>
                                                            <th data-options="field:'price',width:250,editor:{type:'numberbox',options:{precision:2}}">单价</th>
                                                            <th data-options="field:'allprice',width:250">总价</th>
                                                            <th data-options="field:'beizhu',width:250,editor:{type:'textbox'}">备注</th>
                                                            <th data-options="field:'zhuangtai',width:250,hidden:'true'">状态</th>

                                                            
                                                        </tr>

                                                    </thead>
                                                </table>




                                                <div id="tb2" style="height: auto">
                                                    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-add',plain:true" onclick="append('2')">添加商品</a>
                                                    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-remove',plain:true" onclick="removeit('2')">删除商品</a>
                                                    <a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-save',plain:true" onclick="accept('2')">保存</a>
                                                </div>



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
											<td width="9%"><input type="button" onclick="CheckClientValidationState();" value="提交" /></td>
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
			</TR></TBODY></TABLE>
            <asp:textbox id="CompanyNumber" runat="server" style="DISPLAY: none"></asp:textbox><asp:textbox id="StockPeoNum" runat="server" style="DISPLAY: none"></asp:textbox><asp:textbox id="StreamNumber" runat="server"  style="DISPLAY: none"></asp:textbox>
			
		</form>

        	<script type="text/javascript">
        	    changeVal()
        	    $("#<%=rukuleixing.ClientID %>").change(function () {
                     changeVal()
                     var dingdanleixing = $("#<%=rukuleixing.ClientID %>").val()
            var lx;
            if (dingdanleixing == "农产品") {
                lx = 0
            } else if (dingdanleixing == "包装物料") {
                lx = 1
            } else if (dingdanleixing == "生产物资") {
                lx = 2
            } else if (dingdanleixing == "其他") {
                lx = 3
            }
            window.location.href = "/aspx/erp/incomeroom_add.aspx?lx=" + lx
        })



        function changeVal() {
            var dingdanleixing = $("#<%=rukuleixing.ClientID %>").val()
            //td1 包装物料、生产物资、其他
            //td2 7.	农产品
            if (dingdanleixing != "农产品") {
                // window.location.reload()
                $("#td1").css("display", "none");
                $("#td2").css("display", "");
            } else {

                $("#td1").css("display", "");
                $("#td2").css("display", "none");
            }
        }



        	    var editIndex = undefined;
        	    function endEditing(val) {
        	        if (editIndex == undefined) { return true }
        	        if ($('#dg'+val).datagrid('validateRow', editIndex)) {
        	            $('#dg'+val).datagrid('endEdit', editIndex);
        	            editIndex = undefined;
        	            return true;
        	        } else {
        	            return false;
        	        }
        	    }
        	    function onClickCell(index, field) {
        	        var val="";
        	        var dingdanleixing = $("#<%=rukuleixing.ClientID %>").val()

                     if (dingdanleixing == "农产品") {
                         val = 1
                     } else {
                         val = 2
                     }
        	        if (editIndex != index) {
        	            if (endEditing(val)) {
        	                $('#dg'+val).datagrid('selectRow', index)
                                    .datagrid('beginEdit', index);
        	                var ed = $('#dg'+val).datagrid('getEditor', { index: index, field: field });
        	                if (ed) {
        	                    ($(ed.target).data('textbox') ? $(ed.target).textbox('textbox') : $(ed.target)).focus();
        	                }
        	                editIndex = index;
        	            } else {
        	                setTimeout(function () {
        	                    $('#dg'+val).datagrid('selectRow', editIndex);
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

        	        return false;
        	    }





        	    function RndNum(n) {

        	        var rnd = "";

        	        for (var i = 0; i < n; i++)

        	            rnd += Math.floor(Math.random() * 10);

        	        return rnd;

        	    }


        	    function append(val) {

        	        if (endEditing(val)) {
        	            $('#dg'+val).datagrid('appendRow', { itemid: RndNum(4) });
        	            editIndex = $('#dg'+val).datagrid('getRows').length - 1;
        	            $('#dg'+val).datagrid('selectRow', editIndex)
                                .datagrid('beginEdit', editIndex);
        	        }
        	    }

        	   
        	    function removeit(val) {
        	        if (editIndex == undefined) { return }
        	        $('#dg'+val).datagrid('cancelEdit', editIndex)
                            .datagrid('deleteRow', editIndex);
        	        var rows = $('#dg'+val).datagrid('getRows');
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



        	    function accept(val) {
        	        if (endEditing(val)) {
        	            $('#dg'+val).datagrid('acceptChanges');
        	        }
        	    }

        	    function CheckClientValidationState() {
                    
        	        var val="";
        	        var dingdanleixing = $("#<%=rukuleixing .ClientID %>").val()
        	        
        	        if (dingdanleixing == "农产品") {
        	            val=1
        	        } else {
        	            val = 2
        	        }

        	        var _shtime = document.getElementById('ShTime').value;;

        	        var _Tel = "";

        	        var _StockPeoNum = document.getElementById('StockPeoNum').value;;

        	        var _StockPeoName = document.getElementById('StockPeoName').value;;

                    
        	        var _AllMoney = '';

        	        var _StreamNumber = '';//'' $('select#ddlXsdd_WorkStreamType option:selected').val(); //document.getElementById('StreamNumber').value;

        	        var _Storeroom = $('select#ddlStoreroom option:selected').val();
        	        var _Discount = 1;
        	        var _title = document.getElementById('title').value;
        	        var uname = document.getElementById('uname').value;
        	        var rname = document.getElementById('rname').value;
        	        var number = document.getElementById('number').value;
        	        var _ddlSource = document.getElementById('caigouyuan').value;
        	        var _Remark = document.getElementById('Remark').value;
        	       
        	        if (endEditing(val)) {

        	            $('#dg'+val).datagrid('acceptChanges');
        	            var rows = $("#dg" + val).datagrid("getRows"); //这段代码是获取当前页的所有行。
        	            var k = false;
        	            var k2 = "";
        	            var _res = false;
        	            var _All = 0;
        	            for (var i = 0; i < rows.length; i++) {   // 每次保存一次 销售单内容
        	                var row2 = rows[i];
        	                _All += row2.allprice;
        	                var ordernum = "";
        	                var _json = jQuery.param({ "gname": row2.productname, "Allmoney": row2.allprice, "Singlemoney": row2.price, "price": row2.price, "unitcost": row2.unitcost, "uname": uname, "rname": rname, 'number': number, 'itemid': row2.itemid, 'model2': row2.model, 'countunit': row2.countunit, 'zhongzhihu': row2.zhongzhihu, 'beizhu': row2.beizhu, 'zhuangtai': row2.zhuangtai });
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

        	            //保存入库单

        	            var _json3 = jQuery.param({ "title": _title, "uname": uname, "rname": rname, "number": number, "ShTime": _shtime, "rukuleixing": dingdanleixing, 'StockPeoNum': _StockPeoNum, 'StockPeoName': _StockPeoName, 'StreamNumber': _StreamNumber, 'StreamName': _StreamNumber, 'Storeroom': _Storeroom, 'InSource': _ddlSource, 'Remark': _Remark });
        	            var request3 = $.ajax({
        	                url: "../ashx/getIncome.ashx?type=order2",
        	                type: "POST",
        	                async: false,
        	                data: _json3,
        	                dataType: "json",
        	                cache: false,
        	                success: function (r, textStatus) {
        	                    if (textStatus == 'success') {
        	                        var msg = "您已经成功添加一条普通会员订单，\n\n需要添加新的订单吗？";
        	                        if (confirm(msg) == true) {
        	                            location.reload();
        	                            return true;
        	                        } else {
        	                            window.location.href = "IncomeRoom.aspx";
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
	</body>
</HTML>
