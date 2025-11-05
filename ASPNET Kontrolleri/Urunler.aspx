<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="ASPNET_Kontrolleri.Urunler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ürünler</title>
    <link href="css/GridViewStil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="tasiyici">
            <div class="baslik">
                <h1>Ürünler Listesi</h1>
            </div>
            <div class="filtre">
                Kategori = <asp:DropDownList ID="ddl_kategoriler" runat="server" DataTextField="Isim" DataValueField="ID" AppendDataBoundItems="true">
                                <asp:ListItem Value="-1" Text="Tüm Ürünler"></asp:ListItem>
                           </asp:DropDownList>
                <asp:Button ID="btn_filtre" runat="server" Text="Filtrele" OnClick="btn_filtre_Click" />
            </div>
            <div class="icerik">
                <asp:GridView ID="gv_urunler" runat="server" AutoGenerateColumns="false">
                    <Columns>
                        <asp:BoundField HeaderText="Ürün No" DataField="UrunID" />
                        <asp:BoundField HeaderText="Ürün Adı" DataField="UrunAdi" />
                        <asp:BoundField HeaderText="Kategori" DataField="KategoriAdi" />
                        <asp:BoundField HeaderText="Tedarikçi Firma" DataField="TedarikciAdi"/>
                        <asp:BoundField HeaderText="Paketleme" DataField="MiktarBirim" />
                        <asp:BoundField HeaderText="Stok Miktarı" DataField="Stok" />
                        <asp:BoundField HeaderText="Güvenlik Stoğu" DataField="KritikSeviye" />
                        <asp:BoundField HeaderText="Ürün Fiyatı" DataField="Fiyat"/>
                        <asp:BoundField HeaderText="Satışta Durum" DataField="SatistaMi" />
                    </Columns>
                </asp:GridView>
                    
            </div>
        </div>
    </form>
</body>
</html>
