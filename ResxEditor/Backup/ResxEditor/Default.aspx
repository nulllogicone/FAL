<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" ValidateRequest="false"
    AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ResxEditor.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Path
    <asp:Button ID="ButtonLoad" runat="server" Text="öffnen" OnClick="ButtonLoad_Click" />
    <asp:Button ID="ButtonSave" runat="server" Text="speichern" OnClick="ButtonSave_Click" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="name">
                <ItemTemplate>
                    <asp:Label ID="LabelName" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="value">
                <ItemTemplate>
                    <asp:TextBox ID="TextBoxValue" runat="server" Text='<%# Bind("value") %>' TextMode="MultiLine"
                        Rows="3" Width="400"></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
