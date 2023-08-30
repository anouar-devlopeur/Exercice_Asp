<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pagecategorie.aspx.cs" Inherits="global.pagecategorie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ajouter" Width="97px" />
    </form>
    
</body>
</html>
