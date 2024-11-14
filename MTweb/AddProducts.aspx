<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AddProducts.aspx.cs" Inherits="AddProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <center>
        <div class="div">
            <asp:DropDownList ID="DropDownListkind" runat="server"></asp:DropDownList>
            <br />
            <asp:TextBox ID="TextBoxID" runat="server" placeholder="id"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBoxname" runat="server" placeholder="name"></asp:TextBox>
            <br />
            <asp:FileUpload ID="FileUploadpic" runat="server" />
            <br />
            <asp:TextBox ID="TextBoxprice" runat="server" placeholder="price"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBoxcount" runat="server" placeholder="count"></asp:TextBox>
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem Selected="True">Yes</asp:ListItem>
                <asp:ListItem Value="No"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:TextBox ID="TextBoxDiscount" runat="server" placeholder="discount"></asp:TextBox>
            <br />
            <asp:Button ID="Buttonadd" runat="server" Text="Add product" OnClick="Buttonadd_Click" />
            <br />
            <asp:Label ID="Labelerro" runat="server" Text="some thing is empty" CssClass="error-message" Visible="False"></asp:Label>
        </div>
    </center>
</asp:Content>

