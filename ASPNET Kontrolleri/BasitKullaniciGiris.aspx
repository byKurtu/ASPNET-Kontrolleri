<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BasitKullaniciGiris.aspx.cs" Inherits="ASPNET_Kontrolleri.BasitKullaniciGiris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        *{margin:0; padding:0;}
        /*Sayfadaki her html kontrolünün kendi karakteristlik boşluklarını yok et*/
        .tasiyici {
            width: 420px;
            min-height: 200px;
            border: 1px solid silver;
            margin: 200px auto;
            padding: 20px;
            text-align: center;
            background-color: white;
        }
        body {
            font-family: Calibri;
            background-color: lightgray;
        }
        .metinkutu {
            width:396px;
            padding:10px;
            border-radius:12px;
            border:1px solid deeppink;
        }
        .satir {
            padding: 10px 0;
        }
        .girisbutton {
            width: 420px;
            padding: 10px;
            background-color: deeppink;
            color: white;
            font-size: 13pt;
            font-weight:900;
            border:1px solid pink;
            border-radius:12px;
        }
        .baslik {
            padding-bottom: 15px;
            border-bottom: 1px solid silver;
            color: dimgray;
            margin-bottom: 15px;
        }
        .mesaj {
            color: darkred;
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div Class="tasiyici">
            <div class="baslik">
                <h1>Giriş Yap</h1>
                <p>Giriş yapmak içni lütfen bilgilerinizi giriniz</p>
            </div>
            <div class="satir">
                <asp:textbox ID="tb_eposta" runat="server" CssClass="metinkutu" placeholder="E-Posta"></asp:textbox>
                <asp:Label ID="lbl_epostaMesaj" runat="server" CssClass="mesaj"></asp:Label>
            </div>
            <div class="satir">
                <asp:textbox ID="tb_kadi" runat="server" CssClass="metinkutu" placeholder="Kullanıcı Adı"></asp:textbox>
                <asp:Label ID="lbl_kadiMesaj" runat="server" CssClass="mesaj"></asp:Label>
            </div>
            <div class="satir">
                <asp:textbox ID="tb_sifre" runat="server" CssClass="metinkutu" placeholder="Şifre"></asp:textbox>
                <asp:Label ID="lbl_sifreMesaj" runat="server" CssClass="mesaj"></asp:Label>
            </div>
            <div class="satir">
                <asp:textbox ID="tb_tekrarsifre" runat="server" CssClass="metinkutu" placeholder="Tekrar Şifre"></asp:textbox>
                <asp:Label ID="lbl_tekrarSifreMesaj" runat="server" CssClass="mesaj"></asp:Label>
            <div class="satir">
                <asp:textbox ID="tb_telno" runat="server" CssClass="metinkutu" placeholder="Telefon Numarası"></asp:textbox>
                <asp:Label ID="lbl_telnoMesaj" runat="server" CssClass="mesaj"></asp:Label>
            </div>
            </div>
            <div class="satir">
                <asp:Button ID="btn_giris" runat="server" Text="Giriş Yap" CssClass="girisbutton" OnClick="btn_giris_Click"/>
            </div>
            <div class="satir">
                <asp:Label ID="lbl_mesaj"  runat="server" CssClass="mesaj"></asp:Label>
            </div>
    </form>
</body>
</html>
