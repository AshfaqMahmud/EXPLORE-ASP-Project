<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AdminPanel.aspx.cs" Inherits="EXPLORE.AdminPanel" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="font-family: 'Microsoft JhengHei UI'; font-size: large; font-weight: normal; color: #003399; text-align:left; margin-right:50px ">
        <h2>Admin Panel</h2>
        <span>Total pending post:<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></span>
        <span>Total approved post:<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></span>
    </div>
    <br />
    <div>
        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        <asp:GridView ID="gview" runat="server" AutoGenerateColumns="false" Width="100%" OnSelectedIndexChanged="gview_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="BID" HeaderText="Blog ID" />
                <asp:BoundField DataField="BTitle" HeaderText="Title" />
                <asp:BoundField DataField="BCategory" HeaderText="Category" />
                <asp:BoundField DataField="BDate" HeaderText="Posted on" />
                <asp:BoundField DataField="BStatus" HeaderText="Status" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="selectBlog" Text="Select" runat="server" CommandArgument='<%# Eval("bID")%>' OnClick="gview_SelectedIndexChanged" />
                    </ItemTemplate>
                    
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
    
</asp:Content>
