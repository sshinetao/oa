<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="liushui.aspx.cs" Inherits="FTD.Web.UI.aspx.caiwu.liushui" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title><link href="../../css/main.css" type="text/css" rel="stylesheet" />
  <LINK href="../../Style/Style.css" type="text/css" rel="STYLESHEET">
</head>
<body>
    <form id="form1" runat="server">

            <div>    
     <table style="width: 100%" border="0" cellpadding="0" cellspacing="0">            
            <tr>
                <td valign="middle" style=" height: 30px; ">&nbsp;<img src="../../images/BanKuaiJianTou.gif" />
                <a class="hei" href="../Main/MyDesk.aspx">桌面</a>&nbsp;> 财务中心&nbsp;&gt;&gt;&nbsp;流水帐
                </td>
                <td align="left" valign="middle" style=" height: 30px;">
                    <a href="javascript:void(0)" class=" btn-aqua"><%=showMonth %>月</a>


                </td>
            </tr>
        </table>
        
    </div>

           <link href="../../Controls/easyui/themes/default/easyui.css" rel="stylesheet" />
            <link href="../../Controls/easyui/themes/icon.css" rel="stylesheet" />
            <script src="../../Controls/easyui/jquery.min.js"></script>
            <script src="../../Controls/easyui/jquery.easyui.min.js"></script>
            <table id="dg" class="easyui-datagrid" title="流水帐" style="width:100%;height:auto"
			data-options="
                                                       
				iconCls: 'icon-edit',
				singleSelect: true,
				toolbar: '#tb',
				url: '../ashx/caiwu.ashx?type=get&m='+<%=showMonth %>+'&y='+<%=showYear %>,
				method: 'get',
				onClickCell: onClickCell,
				onEndEdit: onEndEdit
			">
		<thead>
			<tr>
				
                <th rowspan="2" data-options="field:'itemid',width:100,hidden:'true'">编号</th>
				<th rowspan="2"  data-options="field:'day',width:40,align:'left',editor:'textbox'"><%=showMonth %>月-日期</th>
				<th rowspan="2" data-options="field:'pingzheng',width:180,editor:'textbox'">凭证号数</th>
				<th  rowspan="2" data-options="field:'duifang',width:180,align:'left',editor:'textbox'">对方科目</th>
				<th  rowspan="2" data-options="field:'zaiyao',width:180,align:'left',editor:'textbox'">摘要</th>
				<th colspan="10"   data-options="field:'inmoney',width:220,align:'left'">收入金额</th>
				<th colspan="10"   data-options="field:'outmoney',width:220,align:'left'">付出金额</th>
				<th colspan="10"   data-options="field:'nowmoney',width:220,align:'left'">结存金额</th>

			</tr>
            <tr>
                
                <th data-options="field:'in_qw',width:20,editor:{type:'numberbox',options:{precision:0}}">千</th>                
                <th data-options="field:'in_bw',width:20,editor:{type:'numberbox',options:{precision:0}}">百</th>
                <th data-options="field:'in_sw',width:20,editor:{type:'numberbox',options:{precision:0}}">十</th>
                <th data-options="field:'in_w',width:20,editor:{type:'numberbox',options:{precision:0}}">万</th>
                <th data-options="field:'in_q',width:20,editor:{type:'numberbox',options:{precision:0}}">千</th>
                <th data-options="field:'in_b',width:20,editor:{type:'numberbox',options:{precision:0}}">百</th>
                <th data-options="field:'in_s',width:20,editor:{type:'numberbox',options:{precision:0}}">十</th>
                <th data-options="field:'in_y',width:20,editor:{type:'numberbox',options:{precision:0}}">元</th>
                <th data-options="field:'in_j',width:20,editor:{type:'numberbox',options:{precision:0}}">角</th>
                <th data-options="field:'in_f',width:20,editor:{type:'numberbox',options:{precision:0}}">分</th>

                  <th data-options="field:'out_qw',width:20,editor:{type:'numberbox',options:{precision:0}}">千</th>                
                <th data-options="field:'out_bw',width:20,editor:{type:'numberbox',options:{precision:0}}">百</th>
                <th data-options="field:'out_sw',width:20,editor:{type:'numberbox',options:{precision:0}}">十</th>
                <th data-options="field:'out_w',width:20,editor:{type:'numberbox',options:{precision:0}}">万</th>
                <th data-options="field:'out_q',width:20,editor:{type:'numberbox',options:{precision:0}}">千</th>
                <th data-options="field:'out_b',width:20,editor:{type:'numberbox',options:{precision:0}}">百</th>
                <th data-options="field:'out_s',width:20,editor:{type:'numberbox',options:{precision:0}}">十</th>
                <th data-options="field:'out_y',width:20,editor:{type:'numberbox',options:{precision:0}}">元</th>
                <th data-options="field:'out_j',width:20,editor:{type:'numberbox',options:{precision:0}}">角</th>
                <th data-options="field:'out_f',width:20,editor:{type:'numberbox',options:{precision:0}}">分</th>
                
                <th data-options="field:'now_qw',width:20,editor:{type:'numberbox',options:{precision:0}}">千</th>                
                <th data-options="field:'now_bw',width:20,editor:{type:'numberbox',options:{precision:0}}">百</th>
                <th data-options="field:'now_sw',width:20,editor:{type:'numberbox',options:{precision:0}}">十</th>
                <th data-options="field:'now_w',width:20,editor:{type:'numberbox',options:{precision:0}}">万</th>
                <th data-options="field:'now_q',width:20,editor:{type:'numberbox',options:{precision:0}}">千</th>
                <th data-options="field:'now_b',width:20,editor:{type:'numberbox',options:{precision:0}}">百</th>
                <th data-options="field:'now_s',width:20,editor:{type:'numberbox',options:{precision:0}}">十</th>
                <th data-options="field:'now_y',width:20,editor:{type:'numberbox',options:{precision:0}}">元</th>
                <th data-options="field:'now_j',width:20,editor:{type:'numberbox',options:{precision:0}}">角</th>
                <th data-options="field:'now_f',width:20,editor:{type:'numberbox',options:{precision:0}}">分</th>

            </tr>
		</thead>
	</table>

	<div id="tb" style="height:auto">
		<a href="javascript:void(0)" class="easyui-linkbutton" data-options="iconCls:'icon-add',plain:true" onclick="append()">添加流水</a>
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
	        //if (editIndex != index) {
	        //    if (endEditing()) {
	        //        $('#dg').datagrid('selectRow', index)
			//				.datagrid('beginEdit', index);
	        //        var ed = $('#dg').datagrid('getEditor', { index: index, field: field });
	        //        if (ed) {
	        //            ($(ed.target).data('textbox') ? $(ed.target).textbox('textbox') : $(ed.target)).focus();
	        //        }
	        //        editIndex = index;
	        //    } else {
	        //        setTimeout(function () {
	        //            $('#dg').datagrid('selectRow', editIndex);
	        //        }, 0);
	        //    }
	        //}
	    }
	    function onEndEdit(index, row) {
	      
	        // SaveSellOrder(row.productname, v3, v2, _itemid);
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

	        CheckClientValidationState();
	        //if (endEditing()) {
	        //    $('#dg').datagrid('acceptChanges');
	        //}



	    }

	    function CheckClientValidationState() {

	        if (endEditing()) {
	            $('#dg').datagrid('acceptChanges');
	            var rows = $("#dg").datagrid("getRows"); //这段代码是获取当前页的所有行。
	            var k = false;
	            var k2 = "";
	            var _res = false;
	            var uname = document.getElementById('uname').value;
	            var rname = document.getElementById('rname').value;
	            var _year = <%=showYear %>;
	            var _month=<%=showMonth %>;
	            var _All = 0;
	            for (var i = 0; i < rows.length; i++) {   // 每次保存一次 销售单内容
	                var row2 = rows[i];
	                _All += row2.allprice;
	                var ordernum = "";
	                var _json = jQuery.param({
	                    "itemid": row2.itemid, "day": row2.day, "pingzheng": row2.pingzheng, "duifang": row2.duifang, "zaiyao": row2.zaiyao,
	                    'in_qw': row2.in_qw, 'in_bw': row2.in_bw, 'in_sw': row2.in_sw, 'in_w': row2.in_w, 'in_q': row2.in_q, 'in_b': row2.in_b, 'in_s': row2.in_s, 'in_y': row2.in_y, 'in_j': row2.in_j, 'in_f': row2.in_f, 'now_qw': row2.now_qw, 'now_bw': row2.now_bw, 'now_sw': row2.now_sw, 'now_w': row2.now_w, 'now_q': row2.now_q, 'now_b': row2.now_b, 'now_s': row2.now_s, 'now_y': row2.now_y, 'now_j': row2.now_j, 'now_f': row2.now_f, 'out_qw': row2.out_qw, 'out_bw': row2.out_bw, 'out_sw': row2.out_sw, 'out_w': row2.out_w, 'out_q': row2.out_q, 'out_b': row2.out_b, 'out_s': row2.out_s, 'out_y': row2.out_y, 'out_j': row2.out_j, 'out_f': row2.out_f, 'uname': uname, 'rname': rname,'year':_year,'month':_month
	                });
	                var request = $.ajax({
	                    url: "../ashx/caiwu.ashx?type=save",
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



	            return true;



	        }
	        else {
	            return false;
	        }
	    }

	</script>
        <asp:TextBox id="number" runat="server"  style="DISPLAY: none"></asp:TextBox>
            <asp:textbox id="year" style="DISPLAY: none" runat="server" ></asp:textbox>
            
			<asp:textbox id="uname" style="DISPLAY: none" runat="server" ></asp:textbox>
			<asp:textbox id="rname" style="DISPLAY: none" runat="server" ></asp:textbox>
    </form>
</body>
</html>
