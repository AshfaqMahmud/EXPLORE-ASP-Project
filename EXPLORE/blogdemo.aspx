<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="blogdemo.aspx.cs" Inherits="EXPLORE.blogdemo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="padding: 100px; margin-right: 100px; margin-left: 100px">
	 <div id="blog" class="row"> 
                
                  <div class="col-sm-2 paddingTop20">
            <nav class="nav-sidebar">
                <ul class="nav" style="display: inline-block; color: #996633">
                    <li class="active"><a href="javascript:;"><span class="glyphicon glyphicon-star">
                    <li><a href="writeBlog.aspx">Write Your Experiences</a></li>
                    <li><a href="javascript:;">Latest news</a></li>
                    <li><a href="javascript:;">Updates</a></li>
                    <li><a href="javascript:;">Latest Additions!</a></li>
              
                   
                </ul>
            </nav>
                      

          
            <asp:Repeater id="Repeater" runat="server">
                    <ItemTemplate>	
                 
                        </ItemTemplate>
</asp:Repeater>
                 
               <div class="col-md-12 gap10"></div>
             </div>
</div>
         <script src="//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js"></script>
     <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
    
</asp:Content>
