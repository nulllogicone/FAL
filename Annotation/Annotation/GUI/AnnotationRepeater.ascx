<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AnnotationRepeater.ascx.cs"
    Inherits="FAL.Annotation.GUI.AnnotationRepeater" %>
<asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
        <div class="annotation_box">
            <span class="annotation_datum">
                <%# Eval("Datum") %></span>
            <asp:Image ID="ImageIcon" runat="server" CssClass="annotation_image" ImageUrl='<%# Eval("IconUrl") %>' AlternateText='<%# Eval("IconUrl") %>'
                Visible='<%# Eval("IconUrl").ToString().Length > 0 %>' />
            <div class="annotation_name">
                <%# Eval("Titel") %>
            </div>
            <%# Eval("Text") %>
        </div>
    </ItemTemplate>
</asp:Repeater>
<div style="clear: left">
</div>
