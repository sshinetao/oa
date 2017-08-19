<%--文件名:TrainingForm.aspx--%>
<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="TrainingForm.aspx.cs" Inherits="FileManage_TrainingForm" Title="当前位置：人事管理->员工培训记录" %>
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
                开始日期:<asp:TextBox ID="TextBox3" runat="server" Width="88px">1993-4-12</asp:TextBox><br />
                &nbsp;结束日期:<asp:TextBox ID="TextBox4" runat="server" Width="88px">1993-4-16</asp:TextBox>
                培训单位:<asp:TextBox ID="TextBox5" runat="server" Width="113px">重庆市财政局</asp:TextBox>
                培训地点:<asp:TextBox ID="TextBox6" runat="server" Width="129px">重庆轻工业职工大学</asp:TextBox><br />
                &nbsp;培训内容:<asp:TextBox ID="TextBox7" runat="server" Width="355px">新会计制度</asp:TextBox>
                培训经费:<asp:TextBox ID="TextBox8" runat="server" Width="47px">350.00</asp:TextBox><br />
                &nbsp;证书名称：<asp:TextBox ID="TextBox9" runat="server" Width="157px">新会计制度上岗证</asp:TextBox>
                补充说明:<asp:TextBox ID="TextBox10" runat="server" Width="239px">公费</asp:TextBox></td>
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
                        DeleteCommand="DELETE FROM [培训记录] WHERE [自编号] = @自编号" InsertCommand="INSERT INTO [培训记录] ([员工编号], [员工姓名], [开始日期], [结束日期], [培训单位], [培训地点], [培训内容], [培训经费], [证书名称], [补充说明]) VALUES (@员工编号, @员工姓名, @开始日期, @结束日期, @培训单位, @培训地点, @培训内容, @培训经费, @证书名称, @补充说明)"
                        SelectCommand="SELECT * FROM [培训记录] WHERE ([员工姓名] LIKE '%' + @员工姓名 + '%')" UpdateCommand="UPDATE [培训记录] SET [员工编号] = @员工编号, [员工姓名] = @员工姓名, [开始日期] = @开始日期, [结束日期] = @结束日期, [培训单位] = @培训单位, [培训地点] = @培训地点, [培训内容] = @培训内容, [培训经费] = @培训经费, [证书名称] = @证书名称, [补充说明] = @补充说明 WHERE [自编号] = @自编号">
                        <DeleteParameters>
                            <asp:Parameter Name="自编号" Type="Int32" />
                        </DeleteParameters>
                        <UpdateParameters>
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工编号" PropertyName="SelectedValue"
                                Type="String" />
                            <asp:ControlParameter ControlID="DropDownList2" Name="员工姓名" PropertyName="SelectedItem.Text"
                                Type="String" />
                            <asp:ControlParameter ControlID="TextBox3" Name="开始日期" PropertyName="Text" Type="DateTime" />
                            <asp:ControlParameter ControlID="TextBox4" Name="结束日期" PropertyName="Text" Type="DateTime" />
                            <asp:ControlParameter ControlID="TextBox5" Name="培训单位" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox6" Name="培训地点" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox7" Name="培训内容" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox8" Name="培训经费" PropertyName="Text" Type="Double" />
                            <asp:ControlParameter ControlID="TextBox9" Name="证书名称" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox10" Name="补充说明" PropertyName="Text" Type="String" />
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
                            <asp:ControlParameter ControlID="TextBox3" Name="开始日期" PropertyName="Text" Type="DateTime" />
                            <asp:ControlParameter ControlID="TextBox4" Name="结束日期" PropertyName="Text" Type="DateTime" />
                            <asp:ControlParameter ControlID="TextBox5" Name="培训单位" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox6" Name="培训地点" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox7" Name="培训内容" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox8" Name="培训经费" PropertyName="Text" Type="Double" />
                            <asp:ControlParameter ControlID="TextBox9" Name="证书名称" PropertyName="Text" Type="String" />
                            <asp:ControlParameter ControlID="TextBox10" Name="补充说明" PropertyName="Text" Type="String" />
                        </InsertParameters>
                    </asp:SqlDataSource>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                        BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="自编号"
                        DataSourceID="SqlDataSource3" Font-Names="宋体" Font-Size="Small" GridLines="Vertical"
                        OnRowCreated="GridView1_RowCreated" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
                        Width="1200px">
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
                            <asp:BoundField DataField="开始日期" HeaderText="开始日期" SortExpression="开始日期" />
                            <asp:BoundField DataField="结束日期" HeaderText="结束日期" SortExpression="结束日期" />
                            <asp:BoundField DataField="培训单位" HeaderText="培训单位" SortExpression="培训单位" />
                            <asp:BoundField DataField="培训地点" HeaderText="培训地点" SortExpression="培训地点" />
                            <asp:BoundField DataField="培训内容" HeaderText="培训内容" SortExpression="培训内容" />
                            <asp:BoundField DataField="培训经费" HeaderText="培训经费" SortExpression="培训经费" />
                            <asp:BoundField DataField="证书名称" HeaderText="证书名称" SortExpression="证书名称" />
                            <asp:BoundField DataField="补充说明" HeaderText="补充说明" SortExpression="补充说明" />
                        </Columns>
                        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" />
                        <AlternatingRowStyle BackColor="Gainsboro" />
                    </asp:GridView>
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>

