<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Settings.ascx.cs" Inherits="BluidSolutions.Modules.FBComments.Settings" %>
<style type="text/css">
    .style1
    {
        text-align: right;
    }
</style>
<table>
<tr>
<td class="style1">
    <asp:Label ID="Label1" runat="server" Text="Mode:"></asp:Label>
    </td><td style="margin-left: 40px">
        <asp:DropDownList ID="DDL_Mode" runat="server">
            <asp:ListItem>Page</asp:ListItem>
            <asp:ListItem>DNNBlog</asp:ListItem>
            <asp:ListItem>Custom</asp:ListItem>
        </asp:DropDownList>
    </td>
    <td style="margin-left: 40px">&nbsp;</td>
</tr>
<tr>
<td class="style1">
    <asp:Label ID="LB_QSP" runat="server" Text="Custom Query String Parameter:"></asp:Label>
    </td><td style="margin-left: 40px">
        <asp:TextBox ID="TB_QSP" runat="server"></asp:TextBox>
    </td>
    <td style="margin-left: 40px">&nbsp;</td>
</tr>
<tr>
<td class="style1">
    <asp:Label ID="Label2" runat="server" Text="Assume FB SDK?"></asp:Label>
    </td><td style="margin-left: 40px">
        <asp:CheckBox ID="CB_AssumeFBSDK" runat="server" />
    </td>
    <td style="margin-left: 40px">&nbsp;</td>
</tr>
<tr>
<td class="style1">
    <asp:Label ID="Label6" runat="server" Text="AppID:"></asp:Label>
    </td><td style="margin-left: 40px">
        <asp:TextBox ID="TB_AppID" runat="server"></asp:TextBox>
    </td>
    <td style="margin-left: 40px">&nbsp;</td>
</tr>
<tr>
<td class="style1">
    <asp:Label ID="Label3" runat="server" Text="Number of posts:"></asp:Label>
    </td><td style="margin-left: 40px">
        <asp:TextBox ID="TB_NumberOfPosts" runat="server"></asp:TextBox>
    </td>
    <td style="margin-left: 40px">&nbsp;</td>
</tr>
<tr>
<td class="style1">
    <asp:Label ID="Label4" runat="server" Text="Width:"></asp:Label>
    </td><td style="margin-left: 40px">
        <asp:TextBox ID="TB_Width" runat="server"></asp:TextBox>
    </td>
    <td style="margin-left: 40px">px</td>
</tr>
<tr>
<td class="style1">
    <asp:Label ID="Label5" runat="server" Text="Color Scheme:" CssClass="SubHead"></asp:Label>
    </td><td style="margin-left: 40px">
        <asp:DropDownList ID="DDL_ColorScheme" runat="server">
            <asp:ListItem>Light</asp:ListItem>
            <asp:ListItem>Dark</asp:ListItem>
        </asp:DropDownList>
    </td>
    <td style="margin-left: 40px">&nbsp;</td>
</tr>
<tr>
<td class="style1">
    &nbsp;</td><td style="margin-left: 40px">
        &nbsp;</td>
    <td style="margin-left: 40px">&nbsp;</td>
</tr>
</table>