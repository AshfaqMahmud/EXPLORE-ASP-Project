<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BlogShow.aspx.cs" Inherits="EXPLORE.BlogShow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="containerPost" style="padding: 15px; margin: 80px 50px 80px 50px; background-color: #66FFFF; font-family: 'Microsoft YaHei UI'; text-align: justify">
            <h2>
                <asp:Label ID="title" runat="server" Text="Title"></asp:Label></h2>

            <h3>Posted On : 
                <asp:Label ID="posttime" runat="server" Text="Posted on"></asp:Label></h3>
            <h5>Serial No: 
                <asp:Label ID="postid" runat="server" Text="Serial"></asp:Label></h5>
            <h5>Posted by : 
                <asp:Label ID="user" runat="server" Text="Name"></asp:Label></h5>

            <article  style="border: 1px solid #999999; padding: 5px ;margin-bottom:0px">
                <asp:Label ID="postdetails" runat="server" Text="Post"></asp:Label>
            </article>
            <div class="stausChck" style="border-style: hidden; border-width: 0px;margin-top:50px; padding: 10px; font-family: 'Microsoft JhengHei UI Light'; font-size: 18px; font-weight: bold; float: left; width: 607px;">
                Status:
                <asp:Label ID="bStatus" runat="server" Text="Pending"></asp:Label>
                <div style="border-style: hidden; border-width: 0px; padding: 10px; font-family: 'Microsoft JhengHei UI Light'; font-size: 18px; font-weight: bold; float: left; height: 28px; width: 225px;">
                    <asp:Button ID="DeclineBtn" runat="server" Text="Decline" Height="36px" Width="84px " OnClick="DeclineBtn_Click" />
                    <asp:Button ID="ApproveBtn" runat="server" Text="Approve" Height="36px" Width="82px" OnClick="ApproveBtn_Click" />
                </div>
                
            </div>
        </div>

    </form>
</body>
</html>
