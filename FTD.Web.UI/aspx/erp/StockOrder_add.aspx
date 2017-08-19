<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StockOrder_add.aspx.cs" Inherits="FTD.Web.UI.aspx.erp.StockOrder_add" %>

<%@ Register TagPrefix="uc1" TagName="fenye" Src="fenye.ascx" %>
<!DOCTYPE html>

<html>
<head>
    <title>畲森山进销存</title>
    <meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
    <meta content="C#" name="CODE_LANGUAGE">
    <meta content="JavaScript" name="vs_defaultClientScript">
    <meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
    <link href="i_blue/ny.css" type="text/css" rel="stylesheet">
    <link href="../../Controls/easyui/themes/default/easyui.css" rel="stylesheet" />
    <script src="../../Controls/My97DatePicker/WdatePicker.js"></script>
    <script src="../../Controls/easyui/jquery.min.js"></script>
    <script src="../../Controls/easyui/jquery.easyui.min.js"></script>



</head>
<body ms_positioning="GridLayout">
    <form id="Form1" method="post" runat="server">
        <script language="javascript" src="DateSelect.js"></script>
        <table cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td width="16" background="i_blue/m_head_3.jpg">
                    <img height="34" src="i_blue/m_head_1.jpg" width="20"></td>
                <td width="748" background="i_blue/m_head_3.jpg">
                    <table height="25" cellspacing="0" cellpadding="0" width="92%" border="0">
                        <tr>
                            <td class="headfont" width="97%"><a class="line_b" href="main_1.aspx">工作台</a>&nbsp;&gt;&gt;&nbsp;<a class="line_b" href="SellOrder.aspx">销售订单</a>&nbsp;&gt;&gt; 
									新增采购订单</td>
                        </tr>
                    </table>
                </td>
                <td width="23">
                    <img height="34" src="i_blue/m_head_2.jpg" width="21"></td>
            </tr>
        </table>
        <table height="450" cellspacing="0" cellpadding="0" width="100%" border="0">
            <tr>
                <td width="15">&nbsp;</td>
                <td valign="top" width="95%">
                    <table cellspacing="1" cellpadding="0" width="100%" bgcolor="#7d9db4" border="0">
                        <tr>
                            <td valign="top" bgcolor="#f3f8fe">
                                <table height="26" cellspacing="0" cellpadding="0" width="100%" border="0">
                                    <tr>
                                        <td background="i_blue/third_head_bg.jpg">&nbsp;</td>
                                    </tr>
                                </table>
                                <table cellspacing="1" cellpadding="4" width="100%" bgcolor="#d8e1e8" border="0">
                                    <tbody>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right" width="15%"><font face="宋体">标题：</font></td>
                                            <td width="35%">
                                                <asp:TextBox ID="title" runat="server" Width="100%"></asp:TextBox></td>
                                            <td align="right" width="15%"><font face="宋体">订单类型：</font></td>
                                            <td width="35%">
                                                <asp:DropDownList ID="ddlOrderType"  runat="server" Width="90%"></asp:DropDownList>


                                            </td>
                                        </tr>


                                        <tr bgcolor="#f3f8fe">
                                            <td align="right" width="15%">进货仓：</td>
                                            <td width="35%">
                                                <asp:DropDownList ID="ddlStoreroom" runat="server" Width="90%"></asp:DropDownList>
                                            </td>
                                            <td align="right" width="15%">采购时间：</td>
                                            <td width="35%">
                                                <asp:TextBox ID="ShTime" runat="server" Width="90%" DataType="DateTime" onClick="WdatePicker({startDate:'%y-%M-01',dateFmt:'yyyy-MM-dd',alwaysUseStartDate:true})"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr bgcolor="#f3f8fe">
                                            <td align="right">业务员姓名：</td>
                                            <td colspan="3">
                                                <asp:TextBox ID="StockPeoName" runat="server" Width="90%"></asp:TextBox></td>

                                        </tr>



                                        <tr bgcolor="#f3f8fe">
                                            <td align="right"><font face="宋体">订单备注：</font></td>
                                            <td colspan="3">
                                                <asp:TextBox ID="Remark" runat="server" Width="100%" Height="52px" TextMode="MultiLine"></asp:TextBox><a href="javascript:void(0)"></a></FONT></td>
                                        </tr>




                                        <tr>
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
                                                            <th data-options="field:'zhongzhihu',width:80,align:'left',editor:{type:'text'}">种植户</th>
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
                                                            <th data-options="field:'zhongzhihu',width:80,align:'left',editor:{type:'text'},hidden:'true'">种植户</th>
                                                            <th data-options="field:'countunit',width:80,align:'left',hidden:'true'">计量单位</th>
                                                            <th data-options="field:'unitcost',width:80,align:'left',editor:{type:'numberbox',options:{precision:2}},">数量</th>
                                                            <th data-options="field:'price',width:250,editor:{type:'numberbox',options:{precision:2}}">单价</th>
                                                            <th data-options="field:'allprice',width:250">总价</th>
                                                            <th data-options="field:'beizhu',width:250,editor:{type:'text'}">备注</th>
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
                                </table>
                                <table height="25" cellspacing="0" cellpadding="0" width="100%" border="0">
                                    <tr>
                                        <td background="i_blue/third_head_bg1.jpg">
                                            <table cellspacing="0" cellpadding="0" width="100%" border="0">
                                                <tr>
                                                    <td width="39%">&nbsp;</td>
                                                    <td width="9%">
                                                        <input type="button" onclick="CheckClientValidationState();" value="提交" /></td>
                                                    <td width="52%"></td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                    <asp:TextBox ID="number" Style="DISPLAY: none" runat="server"></asp:TextBox>

                    <asp:TextBox ID="uname" Style="DISPLAY: none" runat="server"></asp:TextBox>
                    <asp:TextBox ID="rname" Style="DISPLAY: none" runat="server"></asp:TextBox>
                </td>
                <td width="15">&nbsp;</td>
            </tr>
            </TBODY>
        </table>
        <asp:TextBox ID="CompanyNumber" Style="DISPLAY: none" runat="server"></asp:TextBox><asp:TextBox ID="StockPeoNum" Style="DISPLAY: none" runat="server"></asp:TextBox><asp:TextBox ID="StreamNumber" Style="DISPLAY: none" runat="server"></asp:TextBox>

    </form>

    <script type="text/javascript">
        changeVal()
        $("#<%=ddlOrderType.ClientID %>").change(function () {
            changeVal()
            var dingdanleixing = $("#<%=ddlOrderType.ClientID %>").val()
            var lx;
            if (dingdanleixing == "农产品") {
                lx=0
            } else if (dingdanleixing == "包装物料") {
                lx=1
            } else if (dingdanleixing == "生产物资") {
                lx=2
            } else if (dingdanleixing == "其他") {
                lx=3
            }  
            window.location.href = "/aspx/erp/StockOrder_add.aspx?lx="+lx
        	    })



        function changeVal() {
            var dingdanleixing = $("#<%=ddlOrderType.ClientID %>").val()
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
        	        var dingdanleixing = $("#<%=ddlOrderType.ClientID %>").val()

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
        	            url: "../ashx/caigou.ashx?type=del",
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

 
        	    var zongjia = 0;
        	    function CheckClientValidationState() {
                    
        	        var val="";
        	        var dingdanleixing = $("#<%=ddlOrderType.ClientID %>").val()
        	        
        	        if (dingdanleixing == "农产品") {
        	            val=1
        	        } else {
        	            val = 2
        	        }

        	        var _shtime = document.getElementById('ShTime').value;;

        	        var _companyAdd = '';

        	        var _CompanyName = '';//document.getElementById('CompanyName2').value;;

        	        var _Tel = "";

        	        var _StockPeoNum = document.getElementById('StockPeoNum').value;;

        	        var _StockPeoName = document.getElementById('StockPeoName').value;;


        	        var _AllMoney = '';

        	        var _Remark = document.getElementById('Remark').value;;

        	        var _StreamNumber = $('select#ddlXsdd_WorkStreamType option:selected').val(); //document.getElementById('StreamNumber').value;

        	        var _Storeroom = $('select#ddlStoreroom option:selected').val();
        	        var _Discount = 1;
        	        var title = document.getElementById('title').value;
        	        var uname = document.getElementById('uname').value;
        	        var rname = document.getElementById('rname').value;
        	        var number = document.getElementById('number').value;


        	        if (endEditing(val)) {
        	            $('#dg' + val).datagrid('acceptChanges');
        	            debugger
        	            var rows = $('#dg'+val).datagrid("getRows"); //这段代码是获取当前页的所有行。
        	            var k = false;
        	            var k2 = "";
        	            var _res = false;
        	            var _All = 0;
        	            for (var i = 0; i < rows.length; i++) {   // 每次保存一次 销售单内容
        	                var row2 = rows[i];
        	                _All += row2.allprice;
                             
        	                zongjia = _All;
        	                var ordernum = "";
        	                var _json = jQuery.param({ "laiyuancun": row2.laiyuancun, "gname": row2.productname, "allprice": row2.allprice, "price": row2.price, "unitcost": row2.unitcost, "uname": uname, "rname": rname, 'number': number, 'itemid': row2.itemid, 'zhongzhihu': row2.zhongzhihu, 'beizhu': row2.beizhu, 'zhuangtai': row2.zhuangtai });
        	                
        	                var request = $.ajax({
        	                    url: "../ashx/caigou.ashx?type=save",
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

        	            //保存销售客户单

        	            var _json3 = jQuery.param({"type":$('#ddlOrderType').val() ,"title": title, "uname": uname, "rname": rname, "number": number, "ShTime": _shtime, 'CompanyAdd': _companyAdd, 'CompanyName': _CompanyName, 'Tel': _Tel, 'StockPeoNum': _StockPeoNum, 'StockPeoName': _StockPeoName, 'Discount': _Discount, 'AllMoney': zongjia, 'StreamNumber': _StreamNumber, 'Storeroom': _Storeroom });
        	            var request3 = $.ajax({
        	                url: "../ashx/caigou.ashx?type=order2",
        	                type: "POST",
        	                async: false,
        	                data: _json3,
        	                dataType: "json",
        	                cache: false,
        	                success: function (r, textStatus) {
        	                    if (textStatus == 'success') {
        	                        var msg = "您已经成功添加一条采购订单，\n\n需要添加新的订单吗？";
        	                        if (confirm(msg) == true) {
        	                            location.reload();
        	                            return true;
        	                        } else {
        	                            window.location.href = "StockOrder.aspx";
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
</html>
