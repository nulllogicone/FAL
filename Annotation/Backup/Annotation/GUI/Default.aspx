<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FAL.Annotation.GUI.Default"
    ValidateRequest="false" %>

<%@ Register Src="AnnotationRepeater.ascx" TagName="AnnotationRepeater" TagPrefix="uc1" %>
<%@ Register src="AnnotationEdit.ascx" tagname="AnnotationEdit" tagprefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>
            Annotation</h1>
        <p>
            <asp:Label ID="LabelToString" runat="server"></asp:Label>
        </p>
        <h2>
            Edit</h2>
            <uc2:AnnotationEdit ID="AnnotationEdit1" runat="server" />
        <h2>
            Repeater</h2>
        <uc1:AnnotationRepeater ID="AnnotationRepeater1" runat="server" PageSize="2" />
    </div>
    </form>
</body>
</html>
