<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataBoundDropDown.aspx.cs" Inherits="ASPNET_Kontrolleri.DataBoundDropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dropdown List - Data Bound</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_ogrenciler" runat="server" ></asp:DropDownList>
            <asp:Button ID="btn_sec" runat="server" OnClick="btn_sec_Click" Text="Seç" />
            <br /><br />
            <asp:Label ID="lbl_secilen" runat="server">Lütfen Öğrenci Seçiniz</asp:Label>
        </div>
        <div>
            <br />
            <asp:DropDownList ID="ddl_ogretmenler" runat="server"></asp:DropDownList>
            <asp:Button ID="btn_sec2" runat="server" OnClick="btn_sec2_Click" Text="Seç" />
            <br /><br />
            <asp:Label ID="lbl_ogretmen" runat="server">Lütfen Öğretmen Seçiniz</asp:Label>
        </div>
        <div>
            <h2>Veritabanı Kullanmak</h2>
            <asp:DropDownList ID="ddl_kategoriler" runat="server" DataTextField="Isim" DataValueField="ID"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
