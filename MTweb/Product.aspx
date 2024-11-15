<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DataList ID="DataListpro" runat="server">
        <ItemTemplate>
            <asp:Label ID="Labelgro" runat="server" Text='<%#Bind("Name") %>'></asp:Label>
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" />
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

