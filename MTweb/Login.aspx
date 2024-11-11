
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="div">
        <center>
            <div class="ls-container">
                <h2>Log in</h2>
                <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email or Username" CssClass="input-field"></asp:TextBox>
                <br />
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password" CssClass="input-field"></asp:TextBox>
                <br />
                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="ls-button" OnClick="btnLogin_Click" />
                <br />
                <asp:Label ID="lblMessage" runat="server" CssClass="error-message"></asp:Label>
                <br />
                <asp:LinkButton ID="LinkButtonSignUp" runat="server" OnClick="LinkButtonSignUp_Click">I don't have acount</asp:LinkButton>
            </div>
        </center>
    </div>

</asp:Content>

