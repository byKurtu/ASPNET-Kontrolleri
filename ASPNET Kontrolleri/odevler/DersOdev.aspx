<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DersOdev.aspx.cs" Inherits="ASPNET_Kontrolleri.DersOdev" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kayıt Formu</title>
    <link href="css/DersOdevStil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h2>Kayıt Formu</h2>
            <p>Lütfen bilgileri eksiksiz doldurunuz.</p>

            <div class="satir">
                <asp:TextBox ID="tb_isim" runat="server" CssClass="metinKutu" placeholder="Adınız Soyadınız"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_kimlik" runat="server" CssClass="metinKutu" placeholder="T.C. Kimlik No"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_telefon" runat="server" CssClass="metinKutu" placeholder="Telefon Numaranız"></asp:TextBox>
            </div>
            <div class="satir">
                <asp:TextBox ID="tb_sehir" runat="server" CssClass="metinKutu" placeholder="Yaşadığınız Şehir"></asp:TextBox>
            </div>

            <div class="satir">
                <strong>Cinsiyet:</strong>
                <asp:RadioButton ID="rb_erkek" runat="server" GroupName="cinsiyet" Text="Erkek" /><br />
                <asp:RadioButton ID="rb_kadin" runat="server" GroupName="cinsiyet" Text="Kadın" />
            </div>

            <div class="satir">
                <strong>Medeni Hâl:</strong>
                <asp:RadioButton ID="rb_evli" runat="server" GroupName="medeniHal" Text="Evli" /><br />
                <asp:RadioButton ID="rb_bekar" runat="server" GroupName="medeniHal" Text="Bekar" />
            </div>

            <div class="satir">
                <strong>Yabancı Diller:</strong>
                <asp:CheckBox ID="chk_ing" runat="server" Text="İngilizce" /><br />
                <asp:CheckBox ID="chk_alm" runat="server" Text="Almanca" /><br />
                <asp:CheckBox ID="chk_ch" runat="server" Text="Çince" /><br />
                <asp:CheckBox ID="chk_jp" runat="server" Text="Japonca" /><br />
                <asp:CheckBox ID="chk_diger" runat="server" Text="Diğer" />
            </div>

            <div class="satir">
                <asp:CheckBox ID="chk_onay" runat="server" Text="Bilgilerimin doğru olduğunu onaylıyorum" />
            </div>

        </div>
    </form>
</body>
</html>
