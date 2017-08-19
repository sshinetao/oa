<%@ Page language="c#" Codebehind="left.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.left" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>畲森山进销存</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD>
							<iewc:TreeView id="TreeView1" runat="server" SystemImagesPath="webctrl_client/1_0/treeimages/"
								SelectExpands="True">
								<iewc:TreeNode NodeData="1000" ImageUrl="image/1.jpg" Text="采购管理" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="1000a" ImageUrl="image/1.jpg" Text="采购报价" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NodeData="1000aa" NavigateUrl="GoodsData_spk.aspx" ImageUrl="image/3.jpg" Text="商品库预设价"
											Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NodeData="1000ab" NavigateUrl="GoodsOpenMoney.aspx" ImageUrl="image/3.jpg" Text="供应商报价"
											Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="1000b" NavigateUrl="StockPlan.aspx" ImageUrl="image/3.jpg" Text="采购计划"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000c" NavigateUrl="StockOrder.aspx" ImageUrl="image/3.jpg" Text="采购订单"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000d" NavigateUrl="StockOrder_sp.aspx" ImageUrl="image/3.jpg" Text="采购订单审批"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000e" NavigateUrl="StockIncome.aspx" ImageUrl="image/3.jpg" Text="采购入库"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000f" NavigateUrl="StockIncome_sp.aspx" ImageUrl="image/3.jpg" Text="采购入库审批"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000g" NavigateUrl="StockOut.aspx" ImageUrl="image/3.jpg" Text="采购退货"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000h" NavigateUrl="StockOut_sp.aspx" ImageUrl="image/3.jpg" Text="采购退货审批"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000i" NavigateUrl="StockOutMoney.aspx" ImageUrl="image/3.jpg" Text="采购付款"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000j" NavigateUrl="StockOutMoney_sp.aspx" ImageUrl="image/3.jpg" Text="采购付款审批"
										Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="2000" ImageUrl="image/1.jpg" Text="销售管理" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="2000a" ImageUrl="image/1.jpg" Text="销售价查询" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NodeData="2000aa" NavigateUrl="GoodsData_xs.aspx" ImageUrl="image/3.jpg" Text="商品库预设价"
											Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NodeData="2000ab" NavigateUrl="GoodsOpenMoney_xs.aspx" ImageUrl="image/3.jpg" Text="销售报价资料"
											Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="2000b" NavigateUrl="GoodsData_tj.aspx" ImageUrl="image/3.jpg" Text="商品调价"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000c" NavigateUrl="SellQuote.aspx" ImageUrl="image/3.jpg" Text="销售报价"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000d" NavigateUrl="SellOrder.aspx" ImageUrl="image/3.jpg" Text="销售订单"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000e" NavigateUrl="SellOrder_sp.aspx" ImageUrl="image/3.jpg" Text="销售订单审批"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000f" NavigateUrl="StockReady.aspx" ImageUrl="image/3.jpg" Text="货物配料"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000g" NavigateUrl="SellOut.aspx" ImageUrl="image/3.jpg" Text="销售出库" Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000h" NavigateUrl="SellOut_sp.aspx" ImageUrl="image/3.jpg" Text="销售出库审批"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000i" NavigateUrl="SellQuit.aspx" ImageUrl="image/3.jpg" Text="销售退货"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000j" NavigateUrl="SellQuit_sp.aspx" ImageUrl="image/3.jpg" Text="销售退库审批"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000k" NavigateUrl="SellInMoney.aspx" ImageUrl="image/3.jpg" Text="销售收款"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000l" NavigateUrl="SellInMoney_sp.aspx" ImageUrl="image/3.jpg" Text="销售收款审批"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000m" ImageUrl="image/1.jpg" Text="销售计划" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NavigateUrl="SellPlanBM.aspx" ImageUrl="image/3.jpg" Text="部门销售计划编制" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="SellPlanYWY.aspx" ImageUrl="image/3.jpg" Text="业务员销售计划编制" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="SellPlanHW.aspx" ImageUrl="image/3.jpg" Text="货物销售计划编制" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="3000" ImageUrl="image/1.jpg" Text="库存管理" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="3000a" NavigateUrl="GoodsData_MX.aspx" ImageUrl="image/3.jpg" Text="库存明细"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000b" NavigateUrl="CheckCard.aspx" ImageUrl="image/3.jpg" Text="库存盘点"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000c" ImageUrl="image/1.jpg" Text="货物拆分捆绑" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NodeData="3000ca" NavigateUrl="GoodsSplit.aspx" ImageUrl="image/3.jpg" Text="货物拆分"
											Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NodeData="3000cb" NavigateUrl="GoodsBind.aspx" ImageUrl="image/3.jpg" Text="货物捆绑"
											Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="3000d" NavigateUrl="GoodsMove.aspx" ImageUrl="image/3.jpg" Text="仓库调拨"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000e" NavigateUrl="IncomeRoom.aspx" ImageUrl="image/3.jpg" Text="入库"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000f" NavigateUrl="IncomeRoom_sp.aspx" ImageUrl="image/3.jpg" Text="入库审批"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000g" NavigateUrl="OutRoom.aspx" ImageUrl="image/3.jpg" Text="出库" Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000h" NavigateUrl="OutRoom_sp.aspx" ImageUrl="image/3.jpg" Text="出库审批"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000i" ImageUrl="image/1.jpg" Text="报损报溢" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NodeData="3000ia" NavigateUrl="ReportLose.aspx" ImageUrl="image/3.jpg" Text="库存报损"
											Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NodeData="3000ib" NavigateUrl="ReportSpill.aspx" ImageUrl="image/3.jpg" Text="库存报溢"
											Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="3000j" NavigateUrl="MonthSet.aspx" ImageUrl="image/3.jpg" Text="月处理-结转库存"
										Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="4000" ImageUrl="image/1.jpg" Text="统计报表" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="4000a" ImageUrl="image/1.jpg" Text="采购计划报表" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NavigateUrl="StockPlan_BB_BT.aspx" ImageUrl="image/3.jpg" Text="按计划标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="StockPlan_BB_SP.aspx" ImageUrl="image/3.jpg" Text="按计划货物显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000b" ImageUrl="image/1.jpg" Text="采购订单报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_StockOrder_BT.aspx" ImageUrl="image/3.jpg" Text="按订单标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_StockOrder_HW.aspx" ImageUrl="image/3.jpg" Text="按订单货物显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000c" ImageUrl="image/1.jpg" Text="采购入库报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_StockIncome_BT.aspx" ImageUrl="image/3.jpg" Text="按入库单标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_StockIncome_HW.aspx" ImageUrl="image/3.jpg" Text="按入库货物显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000d" ImageUrl="image/1.jpg" Text="采购退货报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_StockOut_BT.aspx" ImageUrl="image/3.jpg" Text="按退货单标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_StockOut_HW.aspx" ImageUrl="image/3.jpg" Text="按退货商品显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000e" ImageUrl="image/1.jpg" Text="销售报价报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellQuote_BT.aspx" ImageUrl="image/3.jpg" Text="按报价标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellQuote_HW.aspx" ImageUrl="image/3.jpg" Text="按报价货物显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000f" ImageUrl="image/1.jpg" Text="销售订单报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellOrder_BT.aspx" ImageUrl="image/3.jpg" Text="按订单标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellOrder_HW.aspx" ImageUrl="image/3.jpg" Text="按订单货物显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000g" ImageUrl="image/1.jpg" Text="销售出库报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellOut_BT.aspx" ImageUrl="image/3.jpg" Text="按出库单标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellOut_HW.aspx" ImageUrl="image/3.jpg" Text="按出库单货物显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000h" ImageUrl="image/1.jpg" Text="销售退货报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellQuit_BT.aspx" ImageUrl="image/3.jpg" Text="按退货单标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellQuit_HW.aspx" ImageUrl="image/3.jpg" Text="按退货单货物显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000i" NavigateUrl="BB_YWY.aspx" ImageUrl="image/3.jpg" Text="业务员销售报表"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="4000j" NavigateUrl="BB_GoodsData_HW.aspx" ImageUrl="image/3.jpg" Text="库存报表"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="4000k" ImageUrl="image/1.jpg" Text="入库报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_IncomeRoom_BT.aspx" ImageUrl="image/3.jpg" Text="按入库单标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_IncomeRoom_HW.aspx" ImageUrl="image/3.jpg" Text="按入库单货物显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000l" ImageUrl="image/1.jpg" Text="出库报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_OutRoom_BT.aspx" ImageUrl="image/3.jpg" Text="按出库单标题显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_OutRoom_HW.aspx" ImageUrl="image/3.jpg" Text="按出库单货物显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000m" ImageUrl="image/1.jpg" Text="仓库调拨报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_GoodsMove_BT.aspx" ImageUrl="image/3.jpg" Text="按调拨用途显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_GoodsMove_HW.aspx" ImageUrl="image/3.jpg" Text="按调拨商品显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000n" ImageUrl="image/1.jpg" Text="报损报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_ReportLose_BT.aspx" ImageUrl="image/3.jpg" Text="按报损仓库显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_ReportLose_HW.aspx" ImageUrl="image/3.jpg" Text="按报损商品显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000o" ImageUrl="image/1.jpg" Text="报溢报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_ReportSpill_BT.aspx" ImageUrl="image/3.jpg" Text="按报损仓库显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_ReportSpill_HW.aspx" ImageUrl="image/3.jpg" Text="按报损商品显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000p" ImageUrl="image/1.jpg" Text="应收款报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellInMoney_BT.aspx" ImageUrl="image/3.jpg" Text="按销售订单显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellInMoney_JL.aspx" ImageUrl="image/3.jpg" Text="按收款记录显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000q" ImageUrl="image/1.jpg" Text="应付款报表" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_StockOutMoney_BT.aspx" ImageUrl="image/3.jpg" Text="按采购订单显示" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_StockOutMoney_JL.aspx" ImageUrl="image/3.jpg" Text="按付款记录显示" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000r" NavigateUrl="BB_Company.aspx" ImageUrl="image/3.jpg" Text="往来单位报表"
										Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="5000" ImageUrl="image/1.jpg" Text="参数设置" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="5000a" NavigateUrl="GoodsType.aspx" ImageUrl="image/3.jpg" Text="货品类别"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000b" NavigateUrl="GoodsData.aspx" ImageUrl="image/3.jpg" Text="货品资料"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000c" NavigateUrl="InSource.aspx" ImageUrl="image/3.jpg" Text="入库来源"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000d" NavigateUrl="OutUse.aspx" ImageUrl="image/3.jpg" Text="出库用途" Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000e" NavigateUrl="Storeroom.aspx" ImageUrl="image/3.jpg" Text="仓库信息"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000f" NavigateUrl="Storebit.aspx" ImageUrl="image/3.jpg" Text="库位设置"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000g" NavigateUrl="CountUnit.aspx" ImageUrl="image/3.jpg" Text="计量单位"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000h" NavigateUrl="PostType.aspx" ImageUrl="image/3.jpg" Text="部门设置"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000i" NavigateUrl="CompanyType.aspx" ImageUrl="image/3.jpg" Text="客户分类"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000j" ImageUrl="image/1.jpg" Text="往来单位" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NavigateUrl="Company.aspx?key=1" ImageUrl="image/3.jpg" Text="客户单位" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="Company.aspx?key=0" ImageUrl="image/3.jpg" Text="供应商单位" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="Company.aspx?key=2" ImageUrl="image/3.jpg" Text="两者皆是" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="5000k" NavigateUrl="OrderType.aspx" ImageUrl="image/3.jpg" Text="订单类型"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000l" NavigateUrl="IncomeSet.aspx" ImageUrl="image/3.jpg" Text="收付款明细设置"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000m" NavigateUrl="BalanceSet.aspx" ImageUrl="image/3.jpg" Text="结算方式设置"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000n" NavigateUrl="InvoiceType.aspx" ImageUrl="image/3.jpg" Text="发票类型"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000o" NavigateUrl="OpenBank.aspx" ImageUrl="image/3.jpg" Text="开户银行"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000p" NavigateUrl="TrafficType.aspx" ImageUrl="image/3.jpg" Text="运输方式"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000q" NavigateUrl="PlanType.aspx" ImageUrl="image/3.jpg" Text="计划类型"
										Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="6000" ImageUrl="image/1.jpg" Text="系统管理" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="6000a" NavigateUrl="UserSteup.aspx" ImageUrl="image/3.jpg" Text="使用单位设置"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000b" NavigateUrl="Manager.aspx" ImageUrl="image/3.jpg" Text="职员设置" Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000c" NavigateUrl="Username.aspx" ImageUrl="image/3.jpg" Text="用户管理"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000d" NavigateUrl="Systemsqx.aspx" ImageUrl="image/3.jpg" Text="权限管理"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000e" NavigateUrl="SystemLog.aspx" ImageUrl="image/3.jpg" Text="系统日志"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000f" NavigateUrl="SystemPassword.aspx" ImageUrl="image/3.jpg" Text="修改密码"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000g" ImageUrl="image/1.jpg" Text="工作流设置" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="采购订单" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Cgdd_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Cgdd_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="采购入库" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Cgrk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Cgrk_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="采购退货" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Cgth_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Cgth_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="采购付款" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Cgfk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Cgfk_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="销售订单" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Xsdd_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Xsdd_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="销售出库" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Xsck_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Xsck_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="销售退货" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Xsth_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Xsth_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="销售收款" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Xssk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Xssk_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode NodeData="9999" ImageUrl="image/1.jpg" Text="盘点卡" ExpandedImageUrl="image/2.jpg"
											Target="rform">
											<iewc:TreeNode NavigateUrl="Pdk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Pdk_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode NodeData="9999" ImageUrl="image/1.jpg" Text="调拨" ExpandedImageUrl="image/2.jpg"
											Target="rform">
											<iewc:TreeNode NavigateUrl="Db_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Db_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="入库" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Rk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Rk_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="出库" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Ck_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="节点名称" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Ck_Stream.aspx" ImageUrl="image/3.jpg" Text="工作流设置" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="6000h" NavigateUrl="main_link.aspx" ImageUrl="image/3.jpg" Text="快捷方式设置"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000i" NavigateUrl="main_tx_sz.aspx" ImageUrl="image/3.jpg" Text="提醒间歇设置"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000j" NavigateUrl="main_db.aspx" ImageUrl="image/3.jpg" Text="待办事宜" Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
							</iewc:TreeView></TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
