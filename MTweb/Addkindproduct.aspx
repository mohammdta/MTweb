<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Addkindproduct.aspx.cs" Inherits="Addkindproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TextBox ID="TextBoxName" runat="server" Placeholder="Name"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBoxid" runat="server" Placeholder="Id"></asp:TextBox>
    <br />
    <asp:FileUpload ID="FileUploadpic" runat="server" />
    <br />
    <asp:Button ID="ButtonAppKind" runat="server" Text="App Kind Product" OnClick="ButtonAppKind_Click" />
    <br />
    <asp:Label ID="Labelerro" runat="server" Text="The id was used"  CssClass="error-message" Visible="false"></asp:Label>
</asp:Content>

