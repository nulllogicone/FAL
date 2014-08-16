<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GoogleChartGenerator._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 121px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1">
            <tr>
                <td class="style2">
                    Title</td>
                <td>
                    <asp:TextBox ID="TextBoxTitel" runat="server">ohne Titel</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Type</td>
                <td>
                    <asp:RadioButton ID="RadioButtonPie" runat="server" Checked="True" 
                        GroupName="charttype" Text="Pie" />
                    <asp:RadioButton ID="RadioButtonBar" runat="server" GroupName="charttype" 
                        Text="Bar" />
                    <asp:RadioButton ID="RadioButtonLine" runat="server" GroupName="charttype" 
                        Text="Line" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Size (w x h)</td>
                <td>
                    <asp:TextBox ID="TextBoxWidth" runat="server" Width="47px">300</asp:TextBox>
                &nbsp;x
                    <asp:TextBox ID="TextBoxHeight" runat="server" Width="47px">200</asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    <asp:Button ID="ButtonShow" runat="server" onclick="ButtonShow_Click" 
        Text="show Image" />
    <br />
    <br />
    <asp:Image ID="ImageGoogleChart" runat="server" />
    <br />
    <br />
    <asp:TextBox ID="TextBoxUrl" runat="server" Width="100%"></asp:TextBox>
    </form>
</body>
</html>
