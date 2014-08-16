<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AnnotationEdit.ascx.cs"
    Inherits="FAL.Annotation.GUI.AnnotationEdit" %>
<table>
    <tr valign="top">
        <td>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True"
                AutoGenerateColumns="False" DataKeyNames="AnnotationGuid" DataSourceID="LinqDataSourceAnnotation">
                <RowStyle VerticalAlign="Top" />
                <Columns>
                    <asp:CommandField ShowEditButton="True" />
                    <asp:BoundField DataField="Datum" HeaderText="Datum" SortExpression="Datum" ReadOnly="true" />
                    <asp:TemplateField HeaderText="Text" SortExpression="Titel">
                        <EditItemTemplate>
                            Icon:
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("IconUrl") %>' Width="200"></asp:TextBox><br />
                            Titel:<asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("Titel") %>'></asp:TextBox><br />
                            <asp:TextBox ID="TextBox1" TextMode="MultiLine" Rows="10" Width="400" runat="server"
                                Text='<%# Bind("Text") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <div style="clear: left; border: solid 1px #cccccc; padding: 5px; margin: 2px;">
                                <img style="float: left;" src='<%# Eval("IconUrl") %>' alt='<%# Eval("IconUrl") %>' />
                                <b>
                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("Titel") %>'></asp:Label></b>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("Text") %>'></asp:Label>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Type" SortExpression="Type">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Type") %>' Width="80"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Type") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status" SortExpression="Status">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Status") %>' Width="80"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("Status") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Priority" SortExpression="Priority">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Priority") %>' Width="80"></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("Priority") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CheckBoxField DataField="IsPublic" HeaderText="IsPublic" SortExpression="IsPublic" />
                </Columns>
            </asp:GridView>
        </td>
        <td>
            <h2>
                Neue Anmerkung hinzufügen</h2>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="AnnotationGuid"
                DataSourceID="LinqDataSourceAnnotation" DefaultMode="Insert" Height="50px" Width="125px"
                OnItemInserted="DetailsView1_ItemInserted">
                <Fields>
                    <asp:BoundField DataField="Titel" HeaderText="Titel" SortExpression="Titel" />
                    <asp:TemplateField HeaderText="Text" SortExpression="Text">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Text") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Text") %>' TextMode="MultiLine"
                                Rows="5"></asp:TextBox>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Text") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="IconUrl" HeaderText="IconUrl" SortExpression="IconUrl" />
                    <asp:BoundField DataField="Type" HeaderText="Type" SortExpression="Type" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    <asp:BoundField DataField="Priority" HeaderText="Priority" SortExpression="Priority" />
                    <asp:CheckBoxField DataField="IsPublic" HeaderText="IsPublic" SortExpression="IsPublic" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
            </asp:DetailsView>
            <asp:LinqDataSource ID="LinqDataSourceAnnotation" runat="server" ContextTypeName="FAL.Annotation.DAL.AnnotationDataContext"
                EnableInsert="True" EnableUpdate="True" TableName="Annotation" EnableDelete="True"
                OrderBy="Datum desc">
            </asp:LinqDataSource>
        </td>
    </tr>
</table>
