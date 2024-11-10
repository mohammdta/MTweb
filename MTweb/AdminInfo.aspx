<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminInfo.aspx.cs" Inherits="AdminAd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <div class="div">

      <center>
          <asp:GridView ID="GridViewinfo" runat="server" AutoGenerateColumns="False" CssClass="gridview-container" OnRowEditing="GridViewinfo_edit " OnRowCancelingEdit="GridViewinfo_cancel" OnRowDeleting="GridViewinfo_Delete" OnRowUpdating="GridViewinfo_updat" AllowPaging="True" PageSize="5" OnPageIndexChanging="IndexChanging">
      <Columns>

                  <asp:TemplateField HeaderText="Full Name">
                      <ItemTemplate>
                          <asp:Label ID="LabelFN" runat="server" Text='<%#Bind("fn") %>' CssClass="gridview-label"></asp:Label>
                      </ItemTemplate>
                      <EditItemTemplate>
                          <asp:TextBox ID="TextBoxFN" runat="server" Text='<%#Bind("fn") %>'></asp:TextBox>
                      </EditItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Email">
                      <ItemTemplate>
                          <asp:Label ID="LabelEmail" runat="server" Text='<%#Bind("email") %>' CssClass="gridview-label"></asp:Label>
                      </ItemTemplate>
                      <EditItemTemplate>
                          <asp:Label ID="LabelEmailEdit" runat="server" Text='<%#Bind("email") %>'></asp:Label>
                      </EditItemTemplate>
                  </asp:TemplateField>

                  <asp:TemplateField HeaderText="Password">
                      <ItemTemplate>
                          <asp:Label ID="Labelpassword" runat="server" Text='<%#Bind("password") %>' CssClass="gridview-label"></asp:Label>
                      </ItemTemplate>
                      <EditItemTemplate>
                          <asp:TextBox ID="TextBoxPassword" runat="server" Text='<%#Bind("password") %>'></asp:TextBox>
                      </EditItemTemplate>
                  </asp:TemplateField>

                  <asp:TemplateField HeaderText="Phone">
                      <ItemTemplate>
                          <asp:Label ID="Labelphone" runat="server" Text='<%#Bind("phone") %>' CssClass="gridview-label"></asp:Label>
                      </ItemTemplate>
                      <EditItemTemplate>
                          <asp:TextBox ID="TextBoxPhone" runat="server" Text='<%#Bind("phone") %>'></asp:TextBox>
                      </EditItemTemplate>
                  </asp:TemplateField>

                  <asp:TemplateField>
                      <ItemTemplate>
                          <asp:LinkButton ID="LinkButtonEdit" Text="Edit" runat="server" CommandName="Edit"></asp:LinkButton>
                          <asp:LinkButton ID="LinkButtonDelete" Text="Delete" runat="server" CommandName="Delete"></asp:LinkButton>
                      </ItemTemplate>
                      <EditItemTemplate>
                          <asp:LinkButton ID="LinkButtonUpdate" Text="Update" runat="server" CommandName="Update"></asp:LinkButton>
                          <asp:LinkButton ID="LinkButtonCancel" Text="Cancel" runat="server" CommandName="Cancel"></asp:LinkButton>
                      </EditItemTemplate>
                  </asp:TemplateField>

              </Columns>
          </asp:GridView>
      </center>
  </div>
</asp:Content>

