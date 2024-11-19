<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DataList ID="DataListpro" runat="server" RepeatColumns="2" OnItemCommand="DataListpro_ItemCommand">
        <ItemTemplate>
            <asp:Label ID="Labelgro" runat="server" Text='<%#Bind("Name") %>'></asp:Label>
            <br />
            <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%#Bind("Id") %>' Height="100" Width="100" />
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

