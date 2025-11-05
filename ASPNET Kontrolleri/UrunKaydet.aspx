<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UrunKaydet.aspx.cs" Inherits="ASPNET_Kontrolleri.UrunKaydet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ürün Kaydet</title>
    <link href="css/KayitFormStil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="tasiyici">
            <div class="baslik">
                <h3>Ürün Ekle</h3>
            </div>
            <div class="icerik">
                <div class="sol">
                    <div class="satir">
                        <label>Ürün Adı</label>
                        <asp:TextBox ID="tb_isim" runat="server" CssClass="kamil" placeHolder="Boş Bırakmayınız"></asp:TextBox>
                    </div>
                    <div class="satir">
                        <label>Kategori Seçiniz</label><br />
                        <asp:DropDownList ID="ddl_kategoriler" runat="server" DataTextField="Isim" DataValueField="ID" CssClass="cemal"></asp:DropDownList>
                    </div>
                    <div class="satir">
                        <label>Tedarikçi Seçiniz</label><br />
                        <asp:DropDownList ID="ddl_tedarikciler" runat="server" DataTextField="SirketAdi" DataValueField="TedarikciID" CssClass="cemal"></asp:DropDownList>
                    </div>
                    <div class="satir">
                        <asp:checkbox ID="cb_satistaMi" runat="server" Text="satişta" />

                    </div>
                    <div class="satir">
                        <asp:Button ID="btn_kaydet" runat="server" Text="Ürün Kaydet" CssClass="kaydetButon" OnClick="btn_kaydet_Click" />
                    </div>
                </div>
                <div class="sag">
                    <div class="satir">
                        <label>Ürün Fiyatı</label>
                        <asp:TextBox ID="tb_fiyat" runat="server" CssClass="kamil" Text="0.00"></asp:TextBox>
                    </div>
                    <div class="satir">
                        <label>Stok Miktarı</label>
                        <asp:TextBox ID="tb_stok" runat="server" CssClass="kamil" Text="0"></asp:TextBox>
                    </div>
                    <div class="satir">
                        <label>Güvenlik Stoğu</label>
                        <asp:TextBox ID="tb_guvenlik" runat="server" CssClass="kamil" Text="0"></asp:TextBox>
                    </div>
                    <div class="satir">
                        <label>Sipariş edlien miktar</label>
                        <asp:TextBox ID="tb_siparis" runat="server" CssClass="kamil" Text="0"></asp:TextBox>
                    </div>
                </div>
                <div style="clear:both"></div>
            </div>
        </div>
    </form>
</body>
</html>
