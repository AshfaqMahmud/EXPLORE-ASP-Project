<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="EXPLORE.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Name
            "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="243px"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Dept
            "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 10px" Width="240px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Salary
            "></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="243px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="StudentId
            "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 10px" Width="209px"></asp:TextBox>
         <br />
         <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
        <br />
    </form>
     
</html>
