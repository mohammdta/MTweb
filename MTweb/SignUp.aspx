<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SignUp.aspx.cs" Inherits="SignUp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>

    .div {
    padding: 20px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

        <center>
    <div class="div">

            <div class="ls-container">
                <h2>Sign Up</h2>
                <asp:TextBox ID="TextBoxFullname" runat="server" Placeholder="Fullname" CssClass="input-field"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorName" ControlToValidate="TextBoxFullname" runat="server" ErrorMessage="Required Name" Text="*" CssClass="error-message"></asp:RequiredFieldValidator>

                <br />

                <asp:TextBox ID="TextBoxEmail" runat="server" Placeholder="Email" CssClass="input-field"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" ControlToValidate="TextBoxEmail" runat="server" ErrorMessage="Required Email" Text="*" CssClass="error-message"></asp:RequiredFieldValidator>

                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email is incorect" Text="*" ControlToValidate="TextBoxEmail" CssClass="error-message" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

                <br />
                <asp:TextBox ID="TextBoxPhone" runat="server" Placeholder="Phone" CssClass="input-field" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone" ControlToValidate="TextBoxPhone" runat="server" ErrorMessage="Required Phone" Text="*" CssClass="error-message"></asp:RequiredFieldValidator>

                <br />
                <asp:TextBox ID="TextBoxpass" runat="server" TextMode="Password" Placeholder="Password" CssClass="input-field"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPass" ControlToValidate="TextBoxpass" runat="server" ErrorMessage="Required Password" Text="*" CssClass="error-message"></asp:RequiredFieldValidator>

                <br />

                <asp:TextBox ID="TextBoxrepass" runat="server" TextMode="Password" Placeholder="re Password" CssClass="input-field"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBoxrepass" runat="server" ErrorMessage="Required rePassword" Text="*" CssClass="error-message"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorPass" runat="server" ControlToValidate="TextBoxrepass" ErrorMessage="The password is not the scound password" Text="*" ControlToCompare="TextBoxpass" CssClass="error-message"></asp:CompareValidator>

                <br />
                <asp:Label ID="Labelerro" runat="server" Text="The email was used" CssClass="error-message" Visible="false"></asp:Label>
                <br />
                <asp:Button ID="Buttonsignup" runat="server" Text="sign up" CssClass="ls-button" OnClick="Buttonsignup_Click" />
            </div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Fix the erros:" CssClass="error-message" />
    </div>
        </center>
</asp:Content>

