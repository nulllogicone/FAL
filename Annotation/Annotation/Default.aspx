<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FAL.Annotation._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1>
            FAL.Annotation</h1>
        <p>
            Hier ist das Projektverzeichnis (root) für Anmerkungen.</p>
        <p>
            Ob Tipps, TODOs, News oder Bug Meldungen - alles soll rein!</p>
        <p>
            <asp:GridView ID="GridView1" runat="server" style="font-family:Arial; font-size:10pt;">
            </asp:GridView>
        </p>
    
    </div>
    </form>
</body>
</html>
