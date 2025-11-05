<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TablosuzListView.aspx.cs" Inherits="ASPNET_Kontrolleri.TablosuzListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ürünler</title>
    <link href="css/ListViewStill.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="tasiyici">
            <div class="baslik">
                <h2>Ürünler Listesi</h2>
            </div>

            <div class="icerik">
                <asp:ListView ID="lv_urunler" runat="server">
                    <LayoutTemplate>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="urunKutu">
                            <img src="resimler/yertutucu.jpg" style="width:100%" />
                            <h4><%# Eval("UrunAdi") %></h4>
                            <%# Eval("KategoriAdi") %>
                            <%# Eval("TedarikciAdi") %>
                            <h4><%# Eval("Fiyat") %></h4>
                           Stok Adeti =<%# Eval("Stok") %>
                        </div>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
    </form>
</body>
</html>
