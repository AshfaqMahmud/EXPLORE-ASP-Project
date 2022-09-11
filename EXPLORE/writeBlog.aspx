<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="writeBlog.aspx.cs" Inherits="EXPLORE.writeBlog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card" style="padding: 10px; margin-top: 5em; background-repeat: no-repeat; background-attachment: scroll; background-color: #99FFCC;">
                    
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="img/blog.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Share Your Experiences</h4>

                                    <asp:Label class="badge badge-pill badge-info" ID="Label1" runat="server" Text="Your status"></asp:Label>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col" id="postTitle" style="min-width: 450px">
                                <label>Title</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="blogTitle" runat="server" placeholder="Title"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col" id="category">
                                <label>Category</label>
                                <div class="form-group">
                                    <asp:DropDownList ID="blogCat" runat="server">
                                        <asp:ListItem>Experience</asp:ListItem>
                                        <asp:ListItem>Culture</asp:ListItem>
                                        <asp:ListItem>Food</asp:ListItem>
                                    </asp:DropDownList>

                                </div>
                            </div>

                        </div>

                    </div>
                    <div class="row">
                        <div class="col" id="desc">
                            <label>What's on your Mind?</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="blogDesc" runat="server" placeholder="Experience" TextMode="MultiLine" Rows="5"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <label>Share photos</label>
                            <div class="form-group">
                                <asp:FileUpload ID="FileUpload1" runat="server" placeholder="Upload Image1" BorderStyle="Ridge" BackColor="#66FFCC" BorderColor="#006666" />

                            </div>
                            <div class="form-group">
                                <asp:FileUpload ID="FileUpload2" runat="server" placeholder="Upload Image2" BorderStyle="Ridge" BackColor="#66FFCC" BorderColor="#006666" />

                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-8 mx-auto">
                            <center>
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" UseSubmitBehavior="false"/>
                                </div>
                            </center>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
