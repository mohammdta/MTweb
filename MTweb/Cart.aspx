<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:GridView ID="GridViewcart" runat="server" AutoGenerateColumns="False" CssClass="gridview-container"  AllowPaging="True" PageSize="5" >
        <Columns>

            <asp:TemplateField HeaderText="Name Product">
                <ItemTemplate>
                    <asp:Label ID="LabelFN" runat="server" Text='<%#Bind("Name") %>' CssClass="gridview-label"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Full Name">
                <ItemTemplate>
                    <asp:Label ID="LabelFN4" runat="server" Text='<%#Bind("Pic") %>' CssClass="gridview-label"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>   
                
            <asp:TemplateField HeaderText="Price after discount">
                <ItemTemplate>
                    <asp:Label ID="LabelPriceAfter" runat="server" CssClass="gridview-label"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Price Before">
                <ItemTemplate>
                    <asp:Label ID="LabelPrice" runat="server" Text='<%#Bind("Price") %>' CssClass="gridview-label"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>                

            <asp:TemplateField HeaderText="Count Counr">
                <ItemTemplate>
                    <asp:Label ID="DropDownListcount" runat="server" Text='<%#Bind("Count") %>' CssClass="gridview-label"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

