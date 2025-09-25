<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OgrenciKayitFormu.aspx.cs" Inherits="ASPNET_Kontrolleri.OgrenciKayitFormu" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Öğrenci Kayıt Formu</title>
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="css/OgrenciKayitFormuStil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="kutu">
            <h3>Öğrenci Kayıt Formu</h3>

            <div class="form-group">
                <label>İsim</label>
                <asp:TextBox ID="tb_isim" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Soyisim</label>
                <asp:TextBox ID="tb_soyisim" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Numara</label>
                <asp:TextBox ID="tb_numara" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <label>Sınıf</label>
                <asp:DropDownList ID="ddl_sinif" runat="server" CssClass="form-control">
                    <asp:ListItem Text="9" Value="9"></asp:ListItem>
                    <asp:ListItem Text="10" Value="10"></asp:ListItem>
                    <asp:ListItem Text="11" Value="11"></asp:ListItem>
                    <asp:ListItem Text="12" Value="12"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Şube</label>
                <asp:DropDownList ID="ddl_sube" runat="server" CssClass="form-control">
                    <asp:ListItem Text="A" Value="A"></asp:ListItem>
                    <asp:ListItem Text="B" Value="B"></asp:ListItem>
                    <asp:ListItem Text="C" Value="C"></asp:ListItem>
                    <asp:ListItem Text="D" Value="D"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-group">
                <label>Eskişehir İlçe</label>
                <asp:DropDownList ID="ddl_ilce" runat="server" CssClass="form-control">
                    <asp:ListItem Text="Odunpazarı" Value="Odunpazarı"></asp:ListItem>
                    <asp:ListItem Text="Tepebaşı" Value="Tepebaşı"></asp:ListItem>
                    <asp:ListItem Text="Seyitgazi" Value="Seyitgazi"></asp:ListItem>
                    <asp:ListItem Text="Çifteler" Value="Çifteler"></asp:ListItem>
                    <asp:ListItem Text="Mihalgazi" Value="Mihalgazi"></asp:ListItem>
                    <asp:ListItem Text="Alpu" Value="Alpu"></asp:ListItem>
                    <asp:ListItem Text="Beylikova" Value="Beylikova"></asp:ListItem>
                    <asp:ListItem Text="İnönü" Value="İnönü"></asp:ListItem>
                    <asp:ListItem Text="Mahmudiye" Value="Mahmudiye"></asp:ListItem>
                    <asp:ListItem Text="Sarıcakaya" Value="Sarıcakaya"></asp:ListItem>
                    <asp:ListItem Text="Han" Value="Han"></asp:ListItem>
                    <asp:ListItem Text="Günyüzü" Value="Günyüzü"></asp:ListItem>
                </asp:DropDownList>
            </div>

            <asp:Button ID="btn_kaydet" runat="server" Text="Kaydet" OnClick="btn_kaydet_Click" CssClass="kaydet" />
            <asp:Label ID="lbl_sonuc" runat="server" ForeColor="DarkGreen" Font-Bold="True"></asp:Label>
        </div>
    </form>
</body>
</html>
