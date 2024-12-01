<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="showproduct.aspx.cs" Inherits="showproduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <style>
        /* General Container Styling */
        .datalist-container {
            display: flex;
            flex-wrap: wrap;
            justify-content: space-around;
            gap: 20px;
        }

        .datalist-item {
            width: 45%; /* Adjust this to control item width */
            padding: 15px;
            background-color: #f9f9f9;
            border: 1px solid #ddd;
            border-radius: 8px;
            box-shadow: 0px 2px 10px rgba(0, 0, 0, 0.1);
            text-align: center;
            font-family: 'Arial', sans-serif;
            transition: all 0.3s ease;
        }

            /* Item Hover Effect */
            .datalist-item:hover {
                transform: translateY(-5px);
                box-shadow: 0px 5px 15px rgba(0, 0, 0, 0.15);
            }

        /* Image Styling */
        #Imagepro {
            max-width: 100%;
            height: auto;
            border-radius: 8px;
            margin-bottom: 15px;
        }

        /* Label Styling */
        .item-label {
            display: block;
            font-size: 14px;
            color: #333;
            margin-bottom: 8px;
            font-weight: bold;
        }

        /* Price Label Styling */
        .price-label {
            color: #007BFF;
            font-size: 18px;
            font-weight: bold;
            margin-top: 10px;
        }

        /* Button Styling */
        .btn-addcart {
            background-color: #28a745;
            color: white;
            border: none;
            padding: 10px 20px;
            font-size: 16px;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

            .btn-addcart:hover {
                background-color: #218838;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DataList ID="DataListpro" runat="server" RepeatColumns="2" OnItemCommand="DataListpro_ItemCommand">
        <ItemTemplate>
            <div class="datalist-item">


                <asp:Label ID="Labelname1" runat="server" Text="Name of product" CssClass="item-label"></asp:Label>
                <asp:Label ID="LabelName" runat="server" Text='<%#Bind("Name") %>'></asp:Label>
                <br />
                <asp:Image ID="Imagepro" runat="server" />
                <br />
                <asp:Label ID="Labelcount1" runat="server" Text="Count" CssClass="item-label"></asp:Label>
                <asp:Label ID="LabelCount" runat="server" Text='<%#Bind("Count") %>'></asp:Label>
                <br />
                <asp:Label ID="LabelPrice" runat="server" Text='<%#Bind("Price")%>' CssClass="item-label price-label"></asp:Label>
                <br />
                <asp:Label ID="LabelPricebe" runat="server" Text='<%#Bind("Price") %>' CssClass="item-label price-label"></asp:Label>
                <br />
                <asp:Button ID="ButtonAddCart" runat="server" Text="AddCart" CommandArgument='<%#Bind("id") %>' CssClass="btn-addcart" />
            </div>
        </ItemTemplate>

    </asp:DataList>
</asp:Content>

