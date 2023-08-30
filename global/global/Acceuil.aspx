<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Acceuil.aspx.cs" Inherits="global.Acceuil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label> <br />

            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br /><asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        </div>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
       
        <asp:Button ID="Button1" runat="server" Text="Affiche" OnClick="Button1_Click" />
    </form>
</body>
</html>

