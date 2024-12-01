<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

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
            width: 45%; /* Adjust width for responsiveness */
            padding: 15px;
            background-color: #f9f9f9;
            border: 1px solid #ddd;
            border-radius: 8px;
            text-align: center;
            font-family: 'Arial', sans-serif;
            box-shadow: 0px 2px 10px rgba(0, 0, 0, 0.1);
            transition: all 0.3s ease;
        }

            /* Item Hover Effect */
            .datalist-item:hover {
                transform: translateY(-5px);
                box-shadow: 0px 5px 15px rgba(0, 0, 0, 0.15);
            }

        /* Label Styling for Name */
        #Labelgro {
            display: block;
            font-size: 16px;
            color: #333;
            font-weight: bold;
            margin-bottom: 10px;
        }

        /* ImageButton Styling */
        #ImageButton1 {
            border-radius: 8px;
            transition: transform 0.3s ease;
        }

            /* Image Hover Effect */
            #ImageButton1:hover {
                transform: scale(1.05);
            }

            /* Responsive Image Styling */
            #ImageButton1 img {
                max-width: 100%;
                height: auto;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:DataList ID="DataListpro" runat="server" RepeatColumns="2" OnItemCommand="DataListpro_ItemCommand">
        <ItemTemplate>
            <div class="datalist-item">

                <asp:Label ID="Labelgro" runat="server" Text='<%#Bind("Name") %>' CssClass="item-label"></asp:Label>
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%#Bind("Id") %>' Height="100" Width="100" CssClass="product-image" />
        </div>
        </ItemTemplate>
    </asp:DataList>
</asp:Content>

