<%@ Page language="c#" Codebehind="left.aspx.cs" AutoEventWireup="false" Inherits="qpsmartweb_jxc.left" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>�ɭɽ������</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<FONT face="����">
				<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="100%" border="0">
					<TR>
						<TD>
							<iewc:TreeView id="TreeView1" runat="server" SystemImagesPath="webctrl_client/1_0/treeimages/"
								SelectExpands="True">
								<iewc:TreeNode NodeData="1000" ImageUrl="image/1.jpg" Text="�ɹ�����" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="1000a" ImageUrl="image/1.jpg" Text="�ɹ�����" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NodeData="1000aa" NavigateUrl="GoodsData_spk.aspx" ImageUrl="image/3.jpg" Text="��Ʒ��Ԥ���"
											Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NodeData="1000ab" NavigateUrl="GoodsOpenMoney.aspx" ImageUrl="image/3.jpg" Text="��Ӧ�̱���"
											Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="1000b" NavigateUrl="StockPlan.aspx" ImageUrl="image/3.jpg" Text="�ɹ��ƻ�"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000c" NavigateUrl="StockOrder.aspx" ImageUrl="image/3.jpg" Text="�ɹ�����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000d" NavigateUrl="StockOrder_sp.aspx" ImageUrl="image/3.jpg" Text="�ɹ���������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000e" NavigateUrl="StockIncome.aspx" ImageUrl="image/3.jpg" Text="�ɹ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000f" NavigateUrl="StockIncome_sp.aspx" ImageUrl="image/3.jpg" Text="�ɹ��������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000g" NavigateUrl="StockOut.aspx" ImageUrl="image/3.jpg" Text="�ɹ��˻�"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000h" NavigateUrl="StockOut_sp.aspx" ImageUrl="image/3.jpg" Text="�ɹ��˻�����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000i" NavigateUrl="StockOutMoney.aspx" ImageUrl="image/3.jpg" Text="�ɹ�����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="1000j" NavigateUrl="StockOutMoney_sp.aspx" ImageUrl="image/3.jpg" Text="�ɹ���������"
										Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="2000" ImageUrl="image/1.jpg" Text="���۹���" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="2000a" ImageUrl="image/1.jpg" Text="���ۼ۲�ѯ" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NodeData="2000aa" NavigateUrl="GoodsData_xs.aspx" ImageUrl="image/3.jpg" Text="��Ʒ��Ԥ���"
											Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NodeData="2000ab" NavigateUrl="GoodsOpenMoney_xs.aspx" ImageUrl="image/3.jpg" Text="���۱�������"
											Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="2000b" NavigateUrl="GoodsData_tj.aspx" ImageUrl="image/3.jpg" Text="��Ʒ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000c" NavigateUrl="SellQuote.aspx" ImageUrl="image/3.jpg" Text="���۱���"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000d" NavigateUrl="SellOrder.aspx" ImageUrl="image/3.jpg" Text="���۶���"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000e" NavigateUrl="SellOrder_sp.aspx" ImageUrl="image/3.jpg" Text="���۶�������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000f" NavigateUrl="StockReady.aspx" ImageUrl="image/3.jpg" Text="��������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000g" NavigateUrl="SellOut.aspx" ImageUrl="image/3.jpg" Text="���۳���" Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000h" NavigateUrl="SellOut_sp.aspx" ImageUrl="image/3.jpg" Text="���۳�������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000i" NavigateUrl="SellQuit.aspx" ImageUrl="image/3.jpg" Text="�����˻�"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000j" NavigateUrl="SellQuit_sp.aspx" ImageUrl="image/3.jpg" Text="�����˿�����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000k" NavigateUrl="SellInMoney.aspx" ImageUrl="image/3.jpg" Text="�����տ�"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000l" NavigateUrl="SellInMoney_sp.aspx" ImageUrl="image/3.jpg" Text="�����տ�����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="2000m" ImageUrl="image/1.jpg" Text="���ۼƻ�" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NavigateUrl="SellPlanBM.aspx" ImageUrl="image/3.jpg" Text="�������ۼƻ�����" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="SellPlanYWY.aspx" ImageUrl="image/3.jpg" Text="ҵ��Ա���ۼƻ�����" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="SellPlanHW.aspx" ImageUrl="image/3.jpg" Text="�������ۼƻ�����" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="3000" ImageUrl="image/1.jpg" Text="������" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="3000a" NavigateUrl="GoodsData_MX.aspx" ImageUrl="image/3.jpg" Text="�����ϸ"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000b" NavigateUrl="CheckCard.aspx" ImageUrl="image/3.jpg" Text="����̵�"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000c" ImageUrl="image/1.jpg" Text="����������" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NodeData="3000ca" NavigateUrl="GoodsSplit.aspx" ImageUrl="image/3.jpg" Text="������"
											Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NodeData="3000cb" NavigateUrl="GoodsBind.aspx" ImageUrl="image/3.jpg" Text="��������"
											Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="3000d" NavigateUrl="GoodsMove.aspx" ImageUrl="image/3.jpg" Text="�ֿ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000e" NavigateUrl="IncomeRoom.aspx" ImageUrl="image/3.jpg" Text="���"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000f" NavigateUrl="IncomeRoom_sp.aspx" ImageUrl="image/3.jpg" Text="�������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000g" NavigateUrl="OutRoom.aspx" ImageUrl="image/3.jpg" Text="����" Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000h" NavigateUrl="OutRoom_sp.aspx" ImageUrl="image/3.jpg" Text="��������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="3000i" ImageUrl="image/1.jpg" Text="������" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NodeData="3000ia" NavigateUrl="ReportLose.aspx" ImageUrl="image/3.jpg" Text="��汨��"
											Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NodeData="3000ib" NavigateUrl="ReportSpill.aspx" ImageUrl="image/3.jpg" Text="��汨��"
											Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="3000j" NavigateUrl="MonthSet.aspx" ImageUrl="image/3.jpg" Text="�´���-��ת���"
										Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="4000" ImageUrl="image/1.jpg" Text="ͳ�Ʊ���" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="4000a" ImageUrl="image/1.jpg" Text="�ɹ��ƻ�����" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NavigateUrl="StockPlan_BB_BT.aspx" ImageUrl="image/3.jpg" Text="���ƻ�������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="StockPlan_BB_SP.aspx" ImageUrl="image/3.jpg" Text="���ƻ�������ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000b" ImageUrl="image/1.jpg" Text="�ɹ���������" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_StockOrder_BT.aspx" ImageUrl="image/3.jpg" Text="������������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_StockOrder_HW.aspx" ImageUrl="image/3.jpg" Text="������������ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000c" ImageUrl="image/1.jpg" Text="�ɹ���ⱨ��" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_StockIncome_BT.aspx" ImageUrl="image/3.jpg" Text="����ⵥ������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_StockIncome_HW.aspx" ImageUrl="image/3.jpg" Text="����������ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000d" ImageUrl="image/1.jpg" Text="�ɹ��˻�����" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_StockOut_BT.aspx" ImageUrl="image/3.jpg" Text="���˻���������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_StockOut_HW.aspx" ImageUrl="image/3.jpg" Text="���˻���Ʒ��ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000e" ImageUrl="image/1.jpg" Text="���۱��۱���" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellQuote_BT.aspx" ImageUrl="image/3.jpg" Text="�����۱�����ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellQuote_HW.aspx" ImageUrl="image/3.jpg" Text="�����ۻ�����ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000f" ImageUrl="image/1.jpg" Text="���۶�������" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellOrder_BT.aspx" ImageUrl="image/3.jpg" Text="������������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellOrder_HW.aspx" ImageUrl="image/3.jpg" Text="������������ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000g" ImageUrl="image/1.jpg" Text="���۳��ⱨ��" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellOut_BT.aspx" ImageUrl="image/3.jpg" Text="�����ⵥ������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellOut_HW.aspx" ImageUrl="image/3.jpg" Text="�����ⵥ������ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000h" ImageUrl="image/1.jpg" Text="�����˻�����" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellQuit_BT.aspx" ImageUrl="image/3.jpg" Text="���˻���������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellQuit_HW.aspx" ImageUrl="image/3.jpg" Text="���˻���������ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000i" NavigateUrl="BB_YWY.aspx" ImageUrl="image/3.jpg" Text="ҵ��Ա���۱���"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="4000j" NavigateUrl="BB_GoodsData_HW.aspx" ImageUrl="image/3.jpg" Text="��汨��"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="4000k" ImageUrl="image/1.jpg" Text="��ⱨ��" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_IncomeRoom_BT.aspx" ImageUrl="image/3.jpg" Text="����ⵥ������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_IncomeRoom_HW.aspx" ImageUrl="image/3.jpg" Text="����ⵥ������ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000l" ImageUrl="image/1.jpg" Text="���ⱨ��" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_OutRoom_BT.aspx" ImageUrl="image/3.jpg" Text="�����ⵥ������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_OutRoom_HW.aspx" ImageUrl="image/3.jpg" Text="�����ⵥ������ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000m" ImageUrl="image/1.jpg" Text="�ֿ��������" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_GoodsMove_BT.aspx" ImageUrl="image/3.jpg" Text="��������;��ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_GoodsMove_HW.aspx" ImageUrl="image/3.jpg" Text="��������Ʒ��ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000n" ImageUrl="image/1.jpg" Text="���𱨱�" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_ReportLose_BT.aspx" ImageUrl="image/3.jpg" Text="������ֿ���ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_ReportLose_HW.aspx" ImageUrl="image/3.jpg" Text="��������Ʒ��ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000o" ImageUrl="image/1.jpg" Text="���籨��" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_ReportSpill_BT.aspx" ImageUrl="image/3.jpg" Text="������ֿ���ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_ReportSpill_HW.aspx" ImageUrl="image/3.jpg" Text="��������Ʒ��ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000p" ImageUrl="image/1.jpg" Text="Ӧ�տ��" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_SellInMoney_BT.aspx" ImageUrl="image/3.jpg" Text="�����۶�����ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_SellInMoney_JL.aspx" ImageUrl="image/3.jpg" Text="���տ��¼��ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000q" ImageUrl="image/1.jpg" Text="Ӧ�����" ExpandedImageUrl="image/2.jpg"
										Target="rform">
										<iewc:TreeNode NavigateUrl="BB_StockOutMoney_BT.aspx" ImageUrl="image/3.jpg" Text="���ɹ�������ʾ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="BB_StockOutMoney_JL.aspx" ImageUrl="image/3.jpg" Text="�������¼��ʾ" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="4000r" NavigateUrl="BB_Company.aspx" ImageUrl="image/3.jpg" Text="������λ����"
										Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="5000" ImageUrl="image/1.jpg" Text="��������" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="5000a" NavigateUrl="GoodsType.aspx" ImageUrl="image/3.jpg" Text="��Ʒ���"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000b" NavigateUrl="GoodsData.aspx" ImageUrl="image/3.jpg" Text="��Ʒ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000c" NavigateUrl="InSource.aspx" ImageUrl="image/3.jpg" Text="�����Դ"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000d" NavigateUrl="OutUse.aspx" ImageUrl="image/3.jpg" Text="������;" Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000e" NavigateUrl="Storeroom.aspx" ImageUrl="image/3.jpg" Text="�ֿ���Ϣ"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000f" NavigateUrl="Storebit.aspx" ImageUrl="image/3.jpg" Text="��λ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000g" NavigateUrl="CountUnit.aspx" ImageUrl="image/3.jpg" Text="������λ"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000h" NavigateUrl="PostType.aspx" ImageUrl="image/3.jpg" Text="��������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000i" NavigateUrl="CompanyType.aspx" ImageUrl="image/3.jpg" Text="�ͻ�����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000j" ImageUrl="image/1.jpg" Text="������λ" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode NavigateUrl="Company.aspx?key=1" ImageUrl="image/3.jpg" Text="�ͻ���λ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="Company.aspx?key=0" ImageUrl="image/3.jpg" Text="��Ӧ�̵�λ" Target="rform"></iewc:TreeNode>
										<iewc:TreeNode NavigateUrl="Company.aspx?key=2" ImageUrl="image/3.jpg" Text="���߽���" Target="rform"></iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="5000k" NavigateUrl="OrderType.aspx" ImageUrl="image/3.jpg" Text="��������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000l" NavigateUrl="IncomeSet.aspx" ImageUrl="image/3.jpg" Text="�ո�����ϸ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000m" NavigateUrl="BalanceSet.aspx" ImageUrl="image/3.jpg" Text="���㷽ʽ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000n" NavigateUrl="InvoiceType.aspx" ImageUrl="image/3.jpg" Text="��Ʊ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000o" NavigateUrl="OpenBank.aspx" ImageUrl="image/3.jpg" Text="��������"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000p" NavigateUrl="TrafficType.aspx" ImageUrl="image/3.jpg" Text="���䷽ʽ"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="5000q" NavigateUrl="PlanType.aspx" ImageUrl="image/3.jpg" Text="�ƻ�����"
										Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
								<iewc:TreeNode NodeData="6000" ImageUrl="image/1.jpg" Text="ϵͳ����" ExpandedImageUrl="image/2.jpg">
									<iewc:TreeNode NodeData="6000a" NavigateUrl="UserSteup.aspx" ImageUrl="image/3.jpg" Text="ʹ�õ�λ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000b" NavigateUrl="Manager.aspx" ImageUrl="image/3.jpg" Text="ְԱ����" Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000c" NavigateUrl="Username.aspx" ImageUrl="image/3.jpg" Text="�û�����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000d" NavigateUrl="Systemsqx.aspx" ImageUrl="image/3.jpg" Text="Ȩ�޹���"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000e" NavigateUrl="SystemLog.aspx" ImageUrl="image/3.jpg" Text="ϵͳ��־"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000f" NavigateUrl="SystemPassword.aspx" ImageUrl="image/3.jpg" Text="�޸�����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000g" ImageUrl="image/1.jpg" Text="����������" ExpandedImageUrl="image/2.jpg">
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="�ɹ�����" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Cgdd_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Cgdd_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="�ɹ����" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Cgrk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Cgrk_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="�ɹ��˻�" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Cgth_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Cgth_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="�ɹ�����" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Cgfk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Cgfk_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="���۶���" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Xsdd_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Xsdd_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="���۳���" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Xsck_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Xsck_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="�����˻�" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Xsth_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Xsth_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="�����տ�" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Xssk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Xssk_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode NodeData="9999" ImageUrl="image/1.jpg" Text="�̵㿨" ExpandedImageUrl="image/2.jpg"
											Target="rform">
											<iewc:TreeNode NavigateUrl="Pdk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Pdk_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode NodeData="9999" ImageUrl="image/1.jpg" Text="����" ExpandedImageUrl="image/2.jpg"
											Target="rform">
											<iewc:TreeNode NavigateUrl="Db_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Db_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="���" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Rk_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Rk_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
										<iewc:TreeNode ImageUrl="image/1.jpg" Text="����" ExpandedImageUrl="image/2.jpg" Target="rform">
											<iewc:TreeNode NavigateUrl="Ck_WorkStreamJd.aspx" ImageUrl="image/3.jpg" Text="�ڵ�����" Target="rform"></iewc:TreeNode>
											<iewc:TreeNode NavigateUrl="Ck_Stream.aspx" ImageUrl="image/3.jpg" Text="����������" Target="rform"></iewc:TreeNode>
										</iewc:TreeNode>
									</iewc:TreeNode>
									<iewc:TreeNode NodeData="6000h" NavigateUrl="main_link.aspx" ImageUrl="image/3.jpg" Text="��ݷ�ʽ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000i" NavigateUrl="main_tx_sz.aspx" ImageUrl="image/3.jpg" Text="���Ѽ�Ъ����"
										Target="rform"></iewc:TreeNode>
									<iewc:TreeNode NodeData="6000j" NavigateUrl="main_db.aspx" ImageUrl="image/3.jpg" Text="��������" Target="rform"></iewc:TreeNode>
								</iewc:TreeNode>
							</iewc:TreeView></TD>
					</TR>
				</TABLE>
			</FONT>
		</form>
	</body>
</HTML>
