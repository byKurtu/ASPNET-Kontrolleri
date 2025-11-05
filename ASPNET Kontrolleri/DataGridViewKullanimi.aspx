<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataGridViewKullanimi.aspx.cs" Inherits="ASPNET_Kontrolleri.DataGridViewKullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Data Grid View</h3>
            <h3>Koleksiyon içerisindeki veya veritabanın içerisinden alınan verileri tablo şeklinde listelemek için kullanılır</h3>
            <p>Tablo yapısını kendisi ototmatik olarak oluşturur</p>
            <asp:GridView ID="gv_ogrenciler" runat="server"></asp:GridView>

        </div>
        <div>
            <h3>Veritabanı Kullanarak Grid View</h3>
            <asp:GridView ID="gv_kategoriler" runat="server"></asp:GridView>
            <br />
            <asp:GridView ID="gv_personeller" runat="server"></asp:GridView>
            <br />
            <asp:GridView ID="gv_urunler" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
