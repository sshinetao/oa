<%--文件名:PersonnelForm.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PersonnelForm.aspx.cs" Inherits="FileManage_PersonnelForm" Title="当前位置：人事管理->员工基本档案" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 556px; height: 161px">
        <tr>
            <td align="left" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 16px;
                background-color: teal">
                请输入查询员工姓名：<asp:TextBox ID="TextBox1" runat="server" Width="149px">%%</asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="查询" Width="80px" />
                <asp:Button ID="Button2" runat="server" Text="新增" Width="80px" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="修改" Width="80px" OnClick="Button3_Click" /></td>
        </tr>
        <tr>
            <td align="left" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 27px;
                background-color: gainsboro">
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                    SelectCommand="SELECT * FROM [公司部门]"></asp:SqlDataSource>
                &nbsp;员工编号:<asp:TextBox ID="TextBox2" runat="server" Width="61px">A000001</asp:TextBox>
                所属部门:<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2"
                    DataTextField="部门名称" DataValueField="部门名称">
                </asp:DropDownList>
                姓名：<asp:TextBox ID="TextBox3" runat="server" Width="49px">罗斌</asp:TextBox>
                性别:<asp:DropDownList ID="DropDownList2" runat="server">
                    <asp:ListItem>男</asp:ListItem>
                    <asp:ListItem>女</asp:ListItem>
                </asp:DropDownList>
                民族:<asp:TextBox ID="TextBox4" runat="server" Width="42px">汉族</asp:TextBox><br />
                &nbsp;籍贯:<asp:TextBox ID="TextBox5" runat="server" Width="144px">重庆市长寿区</asp:TextBox>
                出生日期:<asp:TextBox ID="TextBox6" runat="server" Width="71px">1972-8-5</asp:TextBox>
                身份证号码:<asp:TextBox ID="TextBox7" runat="server" Width="131px">510221197208152316</asp:TextBox><br />
                &nbsp;政治面貌:<asp:TextBox ID="TextBox8" runat="server" Width="47px">共产党员</asp:TextBox>
                婚姻状况:<asp:DropDownList ID="DropDownList3" runat="server">
                    <asp:ListItem>已婚</asp:ListItem>
                    <asp:ListItem>未婚</asp:ListItem>
                </asp:DropDownList>
                文化程度:<asp:DropDownList ID="DropDownList4" runat="server">
                    <asp:ListItem>本科</asp:ListItem>
                    <asp:ListItem>硕士</asp:ListItem>
                    <asp:ListItem>博士</asp:ListItem>
                    <asp:ListItem>专科</asp:ListItem>
                    <asp:ListItem>高中</asp:ListItem>
                    <asp:ListItem>其他</asp:ListItem>
                </asp:DropDownList>
                职称:<asp:DropDownList ID="DropDownList5" runat="server">
                    <asp:ListItem>高级</asp:ListItem>
                    <asp:ListItem>中级</asp:ListItem>
                    <asp:ListItem>初级</asp:ListItem>
                    <asp:ListItem>其他</asp:ListItem>
                </asp:DropDownList>
                职务:<asp:TextBox ID="TextBox9" runat="server" Width="53px">普通员工</asp:TextBox><br />
                &nbsp;专业:<asp:TextBox ID="TextBox10" runat="server" Width="98px">财务会计</asp:TextBox>
                毕业院校:<asp:TextBox ID="TextBox11" runat="server" Width="139px">西南财经大学</asp:TextBox>
                进入公司时间:<asp:TextBox ID="TextBox12" runat="server" Width="96px">1991-7-13</asp:TextBox><br />
                &nbsp;合同服务年限:<asp:DropDownList ID="DropDownList6" runat="server">
                    <asp:ListItem>三年</asp:ListItem>
                    <asp:ListItem>一年</asp:ListItem>
                    <asp:ListItem>二年</asp:ListItem>
                    <asp:ListItem>五年</asp:ListItem>
                    <asp:ListItem>长期</asp:ListItem>
                    <asp:ListItem>其他</asp:ListItem>
                </asp:DropDownList>
                基本工资:<asp:TextBox ID="TextBox13" runat="server" Width="47px">0.00</asp:TextBox>
                银行账号:<asp:TextBox ID="TextBox14" runat="server" Width="213px">3763969980130035760</asp:TextBox><br />
                &nbsp;养老保险账号:<asp:TextBox ID="TextBox15" runat="server" Width="87px">604948674</asp:TextBox>
                医疗保险账号:<asp:TextBox ID="TextBox16" runat="server" Width="79px">6004325960</asp:TextBox>
                住房基金账号:<asp:TextBox ID="TextBox17" runat="server" Width="89px">6004325960</asp:TextBox><br />
                &nbsp;联系电话:<asp:TextBox ID="TextBox18" runat="server" Width="63px">023-40405690</asp:TextBox>
                手机号码:<asp:TextBox ID="TextBox19" runat="server" Width="76px">13036371686</asp:TextBox>
                电子信箱:<asp:TextBox ID="TextBox20" runat="server" Width="114px">binluobin@163.com</asp:TextBox>
                自编号:<asp:TextBox ID="TextBox24" runat="server" BackColor="Gray" ReadOnly="True" Width="19px"></asp:TextBox><br />
                &nbsp;家庭住址:<asp:TextBox ID="TextBox21" runat="server" Width="127px">重庆市长寿区三峡路7号1单元6-1</asp:TextBox>
                邮政编码:<asp:TextBox ID="TextBox22" runat="server" Width="47px">401220</asp:TextBox>
                补充说明:<asp:TextBox ID="TextBox23" runat="server" Width="159px">暂无</asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 2232px; height: 100px; background-color: gainsboro">
                <asp:Panel ID="Panel1" runat="server" Height="150px" ScrollBars="Auto" Width="553px">
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="自编号"
                        DataSourceID="SqlDataSource1" Font-Names="宋体" Font-Size="Small" GridLines="Vertical"
                        Width="3500px" OnRowCreated="GridView1_RowCreated" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <Columns>
                            <asp:CommandField ButtonType="Button" HeaderText="选择" ShowSelectButton="True" />
                            <asp:TemplateField HeaderText="删除" ShowHeader="False">
                                <ItemTemplate>
                                    <asp:Button ID="Button1" runat="server" CausesValidation="False" CommandName="Delete"
                                        Text="删除" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="自编号" HeaderText="自编号" InsertVisible="False" ReadOnly="True"
                                SortExpression="自编号" />
                            <asp:BoundField DataField="员工编号" HeaderText="员工编号" SortExpression="员工编号" />
                            <asp:BoundField DataField="所属部门" HeaderText="所属部门" SortExpression="所属部门" />
                            <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                            <asp:BoundField DataField="性别" HeaderText="性别" SortExpression="性别" />
                            <asp:BoundField DataField="民族" HeaderText="民族" SortExpression="民族" />
                            <asp:BoundField DataField="籍贯" HeaderText="籍贯" SortExpression="籍贯" />
                            <asp:BoundField DataField="出生日期" HeaderText="出生日期" SortExpression="出生日期" />
                            <asp:BoundField DataField="身份证号码" HeaderText="身份证号码" SortExpression="身份证号码" />
                            <asp:BoundField DataField="政治面貌" HeaderText="政治面貌" SortExpression="政治面貌" />
                            <asp:BoundField DataField="婚姻状况" HeaderText="婚姻状况" SortExpression="婚姻状况" />
                            <asp:BoundField DataField="文化程度" HeaderText="文化程度" SortExpression="文化程度" />
                            <asp:BoundField DataField="职称" HeaderText="职称" SortExpression="职称" />
                            <asp:BoundField DataField="职务" HeaderText="职务" SortExpression="职务" />
                            <asp:BoundField DataField="专业" HeaderText="专业" SortExpression="专业" />
                            <asp:BoundField DataField="毕业院校" HeaderText="毕业院校" SortExpression="毕业院校" />
                            <asp:BoundField DataField="进入公司时间" HeaderText="进入公司时间" SortExpression="进入公司时间" />
                            <asp:BoundField DataField="合同服务年限" HeaderText="合同服务年限" SortExpression="合同服务年限" />
                            <asp:BoundField DataField="基本工资" HeaderText="基本工资" SortExpression="基本工资" />
                            <asp:BoundField DataField="银行账号" HeaderText="银行账号" SortExpression="银行账号" />
                            <asp:BoundField DataField="养老保险账号" HeaderText="养老保险账号" SortExpression="养老保险账号" />
                            <asp:BoundField DataField="医疗保险账号" HeaderText="医疗保险账号" SortExpression="医疗保险账号" />
                            <asp:BoundField DataField="住房基金账号" HeaderText="住房基金账号" SortExpression="住房基金账号" />
                            <asp:BoundField DataField="联系电话" HeaderText="联系电话" SortExpression="联系电话" />
                            <asp:BoundField DataField="手机号码" HeaderText="手机号码" SortExpression="手机号码" />
                            <asp:BoundField DataField="电子信箱" HeaderText="电子信箱" SortExpression="电子信箱" />
                            <asp:BoundField DataField="家庭住址" HeaderText="家庭住址" SortExpression="家庭住址" />
                            <asp:BoundField DataField="邮政编码" HeaderText="邮政编码" SortExpression="邮政编码" />
                            <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                        <AlternatingRowStyle BackColor="Gainsboro" />
                    </asp:GridView>
                </asp:Panel>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                    DeleteCommand="DELETE FROM [在职员工视图] WHERE [自编号] = @自编号" InsertCommand="INSERT INTO [基本档案] ([员工编号], [所属部门], [姓名], [性别], [民族], [籍贯], [出生日期], [身份证号码], [政治面貌], [婚姻状况], [文化程度], [职称], [职务], [专业], [毕业院校], [进入公司时间], [合同服务年限], [基本工资], [银行账号], [养老保险账号], [医疗保险账号], [住房基金账号], [联系电话], [手机号码], [电子信箱], [家庭住址], [邮政编码], [补充说明]) VALUES (@员工编号, @所属部门, @姓名, @性别, @民族, @籍贯, @出生日期, @身份证号码, @政治面貌, @婚姻状况, @文化程度, @职称, @职务, @专业, @毕业院校, @进入公司时间, @合同服务年限, @基本工资, @银行账号, @养老保险账号, @医疗保险账号, @住房基金账号, @联系电话, @手机号码, @电子信箱, @家庭住址, @邮政编码, @补充说明)"
                    ProviderName="<%$ ConnectionStrings:MyPersonnelDBConnectionString.ProviderName %>"
                    SelectCommand="SELECT [自编号], [员工编号], [所属部门], [姓名], [性别], [民族], [籍贯], [出生日期], [身份证号码], [政治面貌], [婚姻状况], [文化程度], [职称], [职务], [专业], [毕业院校], [进入公司时间], [合同服务年限], [基本工资], [银行账号], [养老保险账号], [医疗保险账号], [住房基金账号], [联系电话], [手机号码], [电子信箱], [家庭住址], [邮政编码], [补充说明] FROM [在职员工视图] WHERE ([姓名] LIKE '%' + @姓名 + '%')"
                    UpdateCommand="UPDATE [在职员工视图] SET [员工编号] = @员工编号, [所属部门] = @所属部门, [姓名] = @姓名, [性别] = @性别, [民族] = @民族, [籍贯] = @籍贯, [出生日期] = @出生日期, [身份证号码] = @身份证号码, [政治面貌] = @政治面貌, [婚姻状况] = @婚姻状况, [文化程度] = @文化程度, [职称] = @职称, [职务] = @职务, [专业] = @专业, [毕业院校] = @毕业院校, [进入公司时间] = @进入公司时间, [合同服务年限] = @合同服务年限, [基本工资] = @基本工资, [银行账号] = @银行账号, [养老保险账号] = @养老保险账号, [医疗保险账号] = @医疗保险账号, [住房基金账号] = @住房基金账号, [联系电话] = @联系电话, [手机号码] = @手机号码, [电子信箱] = @电子信箱, [家庭住址] = @家庭住址, [邮政编码] = @邮政编码, [补充说明] = @补充说明 WHERE [自编号] = @自编号">
                    <DeleteParameters>
                        <asp:Parameter Name="自编号" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:ControlParameter ControlID="TextBox2" Name="员工编号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="DropDownList1" Name="所属部门" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="TextBox3" Name="姓名" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="DropDownList2" Name="性别" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="TextBox4" Name="民族" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox5" Name="籍贯" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox6" Name="出生日期" PropertyName="Text" Type="DateTime" />
                        <asp:ControlParameter ControlID="TextBox7" Name="身份证号码" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox8" Name="政治面貌" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="DropDownList3" Name="婚姻状况" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="DropDownList4" Name="文化程度" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="DropDownList5" Name="职称" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="TextBox9" Name="职务" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox10" Name="专业" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox11" Name="毕业院校" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox12" Name="进入公司时间" PropertyName="Text" Type="DateTime" />
                        <asp:ControlParameter ControlID="DropDownList6" Name="合同服务年限" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="TextBox13" Name="基本工资" PropertyName="Text" Type="Double" />
                        <asp:ControlParameter ControlID="TextBox14" Name="银行账号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox15" Name="养老保险账号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox16" Name="医疗保险账号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox17" Name="住房基金账号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox18" Name="联系电话" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox19" Name="手机号码" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox20" Name="电子信箱" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox21" Name="家庭住址" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox22" Name="邮政编码" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox23" Name="补充说明" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox24" DefaultValue="" Name="自编号" PropertyName="Text"
                            Type="Int32" />
                    </UpdateParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="TextBox1" Name="姓名" PropertyName="Text" Type="String" />
                    </SelectParameters>
                    <InsertParameters>
                        <asp:ControlParameter ControlID="TextBox2" Name="员工编号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="DropDownList1" Name="所属部门" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="TextBox3" Name="姓名" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="DropDownList2" Name="性别" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="TextBox4" Name="民族" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox5" Name="籍贯" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox6" Name="出生日期" PropertyName="Text" Type="DateTime" />
                        <asp:ControlParameter ControlID="TextBox7" Name="身份证号码" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox8" Name="政治面貌" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="DropDownList3" Name="婚姻状况" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="DropDownList4" Name="文化程度" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="DropDownList5" Name="职称" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="TextBox9" Name="职务" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox10" Name="专业" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox11" Name="毕业院校" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox12" Name="进入公司时间" PropertyName="Text" Type="DateTime" />
                        <asp:ControlParameter ControlID="DropDownList4" Name="合同服务年限" PropertyName="SelectedValue"
                            Type="String" />
                        <asp:ControlParameter ControlID="TextBox13" Name="基本工资" PropertyName="Text" Type="Double" />
                        <asp:ControlParameter ControlID="TextBox14" Name="银行账号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox15" Name="养老保险账号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox16" Name="医疗保险账号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox17" Name="住房基金账号" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox18" Name="联系电话" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox19" Name="手机号码" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox20" Name="电子信箱" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox21" Name="家庭住址" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox22" Name="邮政编码" PropertyName="Text" Type="String" />
                        <asp:ControlParameter ControlID="TextBox23" Name="补充说明" PropertyName="Text" Type="String" />
                    </InsertParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
    </table>
</asp:Content>

