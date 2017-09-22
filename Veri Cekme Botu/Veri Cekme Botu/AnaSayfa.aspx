<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AnaSayfa.aspx.cs" Inherits="Veri_Cekme_Botu.AnaSayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtAdres" runat="server"></asp:TextBox>
        <asp:Button ID="btnVeriCek" runat="server" Text="Button" OnClick="btnVeriCek_Click" /><br />
        <asp:Label ID="lblVeriler" runat="server" Text="Label"></asp:Label>    
    </div>
    </form>
</body>
</html>
