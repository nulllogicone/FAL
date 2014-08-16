<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SqlRepository._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Unbenannte Seite</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField HeaderText="SqlItem">
                    <ItemTemplate>
                        <strong>
                            <%# Eval("Title") %></strong><br />
                        <%# Eval("Text") %></ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Command">
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Command") %>' TextMode="MultiLine"
                            Rows="5"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <h2>
        Ausführen</h2>
    <asp:Button ID="ButtonExecute" runat="server" onclick="ButtonExecute_Click" 
        Text="ausführen" />
    <asp:Label ID="LabelResult" runat="server" Text="Result"></asp:Label>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
