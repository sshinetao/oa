<%--文件名:RewardsForm.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RewardsForm.aspx.cs" Inherits="FileManage_RewardsForm" Title="当前位置：人事管理->员工奖惩记录" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width: 556px; height: 161px">
        <tr>
            <td align="left" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 16px;
                background-color: teal">
                &nbsp;请输入查询员工姓名：<asp:TextBox ID="TextBox1" runat="server" Width="145px">%%</asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="查询" Width="80px" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="新增" Width="80px" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="修改" Width="80px" /></td>
        </tr>
        <tr>
            <td align="left" style="font-size: 0.8em; width: 2232px; font-family: 宋体; height: 27px;
                background-color: gainsboro">
                &nbsp;自编号:<asp:TextBox ID="TextBox2" runat="server" BackColor="DarkGray" ReadOnly="True"
                    Width="35px"></asp:TextBox>
                所在部门:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1"
                    DataTextField="部门名称" DataValueField="部门名称" Width="80px">
                </asp:DropDownList>
                员工姓名:<asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2"
                    DataTextField="姓名" DataValueField="员工编号" Width="80px">
                </asp:DropDownList>
                奖惩日期:<asp:TextBox ID="TextBox3" runat="server" Width="88px">1988-11-28</asp:TextBox><br />
                &nbsp;奖惩类型:<asp:TextBox ID="TextBox4" runat="server" Width="88px">警告</asp:TextBox>
                奖惩原因:<asp:TextBox ID="TextBox5" runat="server" Width="314px">累计矿课5次</asp:TextBox>
                <br />
                &nbsp;奖惩批准单位:<asp:TextBox ID="TextBox6" runat="server" Width="266px">重庆市轻工业学校</asp:TextBox>
                &nbsp;解除处分日期:<asp:TextBox ID="TextBox7" runat="server" Width="77px">2099-11-28</asp:TextBox>
                <br />
                &nbsp;补充说明:<asp:TextBox ID="TextBox8" runat="server" Width="474px">暂无</asp:TextBox></td>
        </tr>
        <tr>
            <td style="width: 2232px; height: 100px; background-color: gainsboro">
                <asp:Panel ID="Panel1" runat="server" Height="220px" ScrollBars="Auto" Width="553px">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [公司部门]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        SelectCommand="SELECT * FROM [在职员工视图] WHERE ([所属部门] = @所属部门)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="DropDownList1" Name="所属部门" PropertyName="SelectedValue"
                                Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:MyPersonnelDBConnectionString %>"
                        DeleteCommand="DELETE FROM [奖惩记录] WHERE [自编号] = @自编号" InsertCommand="INSERT INTO [奖惩记录] ([员工编号], [员工姓名], [奖惩日期], [奖惩类型], [奖惩原因], [奖惩批准单位], [解除处分日期], [补充说明]) VALUES (@员工编号, @员工姓名, @奖惩日期, @奖惩类型, @奖惩原因, @奖惩批准单位, @解除处分日期, @补充说明)"
                        SelectCommand="SELECT * FROM [奖惩记录] WHERE ([员工姓名] LIKE '%' + @员工姓名 + '%')" UpdateCommand="UPDATE [奖惩记录] SET [员工编号] = @员工编号, [员工姓名] = @员工姓名, [奖惩日期] = @奖惩日期, [奖惩类型] = @奖惩类型, [奖惩原因] = @奖惩原因, [奖惩批准单位] = @奖惩批准单位, [解除处分日期] = @解除处分日期, [补充说明] = @补充说明 WHERE [自编号] = @自编号">
                        <DeleteParameters>
                            <asp:Parameter Name="自编号" Type="Int32" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工编号" PropertyName="SelectedValue"
                                Type="String" />
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工姓名" PropertyName="SelectedItem.Text"
                                Type="String" />
                            <asp:ControlParameter ControlID="TextBox3" Name="奖惩日期" PropertyName="Text" Type="DateTime" />
                            <asp:ControlParameter ControlID="TextBox4" Name="奖惩类型" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox5" Name="奖惩原因" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox6" Name="奖惩批准单位" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox7" Name="解除处分日期" PropertyName="Text" Type="DateTime" />
                            <asp:ControlParameter ControlID="TextBox8" Name="补充说明" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox2" Name="自编号" PropertyName="Text" Type="Int32" />
                        </UpdateParameters>
                        <SelectParameters>
                            <asp:ControlParameter ControlID="TextBox1" Name="员工姓名" PropertyName="Text" Type="String" />
                        </SelectParameters>
                        <InsertParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工编号" PropertyName="SelectedValue"
                                Type="String" />
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工姓名" PropertyName="SelectedItem.Text"
                                Type="String" />
                            <asp:ControlParameter ControlID="TextBox3" Name="奖惩日期" PropertyName="Text" Type="DateTime" />
                            <asp:ControlParameter ControlID="TextBox4" Name="奖惩类型" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox5" Name="奖惩原因" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox6" Name="奖惩批准单位" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox7" Name="解除处分日期" PropertyName="Text" Type="DateTime" />
                            <asp:ControlParameter ControlID="TextBox8" Name="补充说明" PropertyName="Text" Type="String" />
                        </InsertParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="自编号"
                        DataSourceID="SqlDataSource3" Font-Names="宋体" Font-Size="Small" GridLines="Vertical"
                        OnRowCreated="GridView1_RowCreated" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                        Width="1000px">
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
                            <asp:BoundField DataField="员工姓名" HeaderText="员工姓名" SortExpression="员工姓名" />
                            <asp:BoundField DataField="奖惩日期" HeaderText="奖惩日期" SortExpression="奖惩日期" />
                            <asp:BoundField DataField="奖惩类型" HeaderText="奖惩类型" SortExpression="奖惩类型" />
                            <asp:BoundField DataField="奖惩原因" HeaderText="奖惩原因" SortExpression="奖惩原因" />
                            <asp:BoundField DataField="奖惩批准单位" HeaderText="奖惩批准单位" SortExpression="奖惩批准单位" />
                            <asp:BoundField DataField="解除处分日期" HeaderText="解除处分日期" SortExpression="解除处分日期" />
                            <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                        <AlternatingRowStyle BackColor="#DCDCDC" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

