<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Label Kullanimi.aspx.cs" Inherits="ASPNET_Kontrolleri.Label_Kullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Label programlanabilir dinamik yazı yazdırma aracıdır şuan okuduğunuz bu yazı asp:Label olmadığı için değiştirelemez statik'tir.
            <br />
            <asp:Label ID="lbl_mesaj" runat="server">asp:Label dinamik(Değiştireblir) yazı aracıdır </asp:Label>
            <br />
            <asp:Button ID="btn_degistir" Text="Label Yazısını Değiştir" runat="server" OnClick="btn_degistir_Click" />
        </div>
    </form>
</body>
</html>
