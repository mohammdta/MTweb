<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Addkindproduct.aspx.cs" Inherits="Addkindproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
        <center>
    <div class="container">

        <asp:TextBox ID="TextBoxName" runat="server" Placeholder="Name" CssClass="input-fieldAdd"></asp:TextBox>
        <br />
        <asp:FileUpload ID="FileUploadpic" runat="server"  CssClass="file-upload"/>
        <br />
        <asp:Button ID="ButtonAppKind" runat="server" Text="App Kind Product" OnClick="ButtonAppKind_Click"  CssClass="btn-submit" />
        <br />
        <asp:Label ID="Labelerro" runat="server" Text="The id was used" CssClass="error-message" Visible="false"></asp:Label>
    </div>
        </center>
</asp:Content>

