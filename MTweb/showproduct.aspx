<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="showproduct.aspx.cs" Inherits="showproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <asp:DataList ID="DataListpro" runat="server" RepeatColumns="2">
        <ItemTemplate>
            <asp:Label ID="LabelName" runat="server" Text='<%#Bind("Name") %>'></asp:Label>
            <br />
            <asp:Image ID="Imagepro" runat="server" />
            <br />
            <asp:Label ID="LabelCount" runat="server" Text='<%#Bind("Count") %>'></asp:Label>
            <br />
            <asp:Label ID="LabelPrice" runat="server"  Text='<%#Bind("Price")%>' ></asp:Label>
            <br />
            <asp:Label ID="LabelPricebe" runat="server" Text='<%#Bind("Price") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

