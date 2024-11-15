<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AddProducts.aspx.cs" Inherits="AddProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <div class="container">
            <asp:DropDownList ID="DropDownListkind" runat="server" CssClass="input-fieldAdd"></asp:DropDownList>
            <br />
            <asp:TextBox ID="TextBoxID" runat="server" placeholder="id" CssClass="input-fieldAdd"> </asp:TextBox>
            <br />
            <asp:TextBox ID="TextBoxname" runat="server" placeholder="name" CssClass="input-fieldAdd"></asp:TextBox>
            <br />
            <asp:FileUpload ID="FileUploadpic" runat="server"  CssClass="file-upload" />
            <br />
            <asp:TextBox ID="TextBoxprice" runat="server" placeholder="price" CssClass="input-fieldAdd" TextMode="Number"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBoxcount" runat="server" placeholder="count" CssClass="input-fieldAdd" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Label ID="Labelpublic" runat="server" Text="the product make public ?" CssClass="label-text"></asp:Label>
            <asp:RadioButton ID="RadioButtonYes" runat="server" GroupName="public"  Checked="True" Text="Yes" CssClass="radio-btn" />
            <asp:RadioButton ID="RadioButtonNo" runat="server" GroupName="public" Text="No" CssClass="radio-btn"  />
            <br />
            <asp:TextBox ID="TextBoxDiscount" runat="server" placeholder="discount" CssClass="input-fieldAdd" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Button ID="Buttonadd" runat="server" Text="Add product" OnClick="Buttonadd_Click" CssClass="btn-submit" />
            <br />
            <asp:Label ID="Labelerro" runat="server" Text="some thing is empty" CssClass="error-message" Visible="False"></asp:Label>
        </div>
    </center>
</asp:Content>

