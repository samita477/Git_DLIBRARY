<%@ Page Title="" Language="C#" MasterPageFile="~/DL/DDL.Master" AutoEventWireup="true"
    CodeBehind="book_student.aspx.cs" Inherits="DIGITALLIBRARY.DL.book_student" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style2
        {
            width: 100%;
        }
        
        .main
        {
            width: 1000px;
            height: 250px;
            border: solid 1px Green;
            margin: 0 auto;
        }
        
        .foot
        {
            height: 200px;
            border: solid 1px Black;
            margin: 0 auto;
            background: #fff;
            color: #000;
            text-align: center;
            vertical-align: middle;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="main">
        <tr>
            <td class="style15" colspan="6" height="70" align="center" bgcolor="#99CCFF">
                <asp:Label ID="lblBookStudent" runat="server" Text="AVAILABLE BOOK"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="gvSearchBook" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#336666" BorderStyle="Double" CellPadding="4" GridLines="Horizontal"
                    OnSelectedIndexChanged="gvBook_SelectedIndexChanged" AllowPaging="True" PageSize="3"
                    OnPageIndexChanging="gvSearchBook_PageIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="Book_ID" HeaderText="Book_ID" InsertVisible="False" ReadOnly="True"
                            SortExpression="Book_ID" />
                        <asp:BoundField DataField="Book_Name" HeaderText="Book_Name" SortExpression="Book_Name" />
                        <asp:BoundField DataField="Page" HeaderText="Page" SortExpression="Page" />
                        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                        <asp:BoundField DataField="edition" HeaderText="edition" SortExpression="edition" />
                        <asp:BoundField DataField="avl_quantity" HeaderText="avl_quantity" SortExpression="avl_quantity" />
                        <asp:BoundField DataField="date_of_entry" HeaderText="date_of_entry" SortExpression="date_of_entry" />
                        <asp:TemplateField HeaderText="Book">
                            <ItemTemplate>
                                <asp:Button ID="btnReserve" runat="server" OnClick="btnReserve_Click" Text="Reserve Book"
                                    Width="120px" BackColor="#336666" Font-Bold="True" ForeColor="White" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
                <asp:HiddenField ID="btnBook_Id" runat="server" />
                <br />
                <br />
                <asp:GridView ID="gvSearchTeacher" runat="server" AutoGenerateColumns="False" BackColor="White"
                    BorderColor="#336666" BorderStyle="Double" CellPadding="4" GridLines="Horizontal"
                    OnSelectedIndexChanged="gvBook_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Book_ID" HeaderText="Book_ID" InsertVisible="False" ReadOnly="True"
                            SortExpression="Book_ID" />
                        <asp:BoundField DataField="Book_Name" HeaderText="Book_Name" SortExpression="Book_Name" />
                        <asp:BoundField DataField="Page" HeaderText="Page" SortExpression="Page" />
                        <asp:BoundField DataField="price" HeaderText="price" SortExpression="price" />
                        <asp:BoundField DataField="edition" HeaderText="edition" SortExpression="edition" />
                        <asp:BoundField DataField="avl_quantity" HeaderText="avl_quantity" SortExpression="avl_quantity" />
                        <asp:BoundField DataField="date_of_entry" HeaderText="date_of_entry" SortExpression="date_of_entry" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#333333" />
                    <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="White" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#487575" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#275353" />
                </asp:GridView>
            </td>
        </tr>
    </table>
    <div>
        <table>
            <tr>
                <td>
                    BOOK SUGGESTION::
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DataList ID="DataList1" RepeatColumns="2" runat="server" 
                        RepeatDirection="VERTICAL">
                        <ItemTemplate>
                            <table>
                                <tr>
                                    <td>
                                        <img width="75px" alt="Book" height=" 50px" src='<%# "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_URL")) %>' />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="LblBookName" runat="server" Text='<%#Eval("Book_Name") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="BtnReserve0" runat="server" Text="Reserve Book" CommandArgument='<%#Eval("Book_ID")%>'
                                            OnClick="BtnReserve0_Click" />
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:DataList>
                </td>
            </tr>
        </table>
    </div>
    <%--<table class="foot">
        <tr>
            <td>
                BOOK SUGGESTION::
            </td>
        </tr>
        <tr>
            <td>
                <asp:DataList ID="DataList1" RepeatColumns="3" runat="server" >
                    <ItemTemplate>
                        <table>
                            <tr>
                                <td>
                                    <img width="75px" alt="Book" height=" 50px" src='<%# "data:image/jpg;base64," + Convert.ToBase64String((byte[])Eval("image_URL")) %>' />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="LblBookName" runat="server" Text='<%#Eval("Book_Name") %>'></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="BtnReserve0" runat="server" Text="Reserve Book" CommandArgument='<%#Eval("Book_ID")%>'
                                        onclick="BtnReserve0_Click"   />
                                </td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
    </table>--%>
</asp:Content>
