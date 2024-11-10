<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AddAcount.aspx.cs" Inherits="AddAcount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <style>
        
.ls-button {
        width: 45%;
}

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <center>

        <div class="ls-container">
            <h2>Add User</h2>
            <asp:TextBox ID="TextBoxFullname" runat="server" Placeholder="Fullname" CssClass="input-field"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBoxEmail" runat="server" Placeholder="Email" CssClass="input-field"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBoxPhone" runat="server" Placeholder="Phone" CssClass="input-field" TextMode="Number"></asp:TextBox>

            <br />
            <asp:TextBox ID="TextBoxpass" runat="server" Placeholder="Password" CssClass="input-field"></asp:TextBox>

            <br />
            <asp:Label ID="Labelerro" runat="server" Text="The email was used" CssClass="error-message" Visible="false"></asp:Label>
            <br />
            <asp:Button ID="ButtonU" runat="server" Text="sign up User" CssClass="ls-button" OnClick="ButtonU_Click" />
            <asp:Button ID="ButtonA" runat="server" Text="sign up Admin" OnClick="ButtonA_Click"  CssClass="ls-button" BackColor="Red" />
        </div>

    </center>
</asp:Content>

