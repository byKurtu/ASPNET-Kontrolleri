<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListViewKullanimi.aspx.cs" Inherits="ASPNET_Kontrolleri.ListViewKullanimi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>List View Kullanımı</title>
    <link href="css/GridViewStil.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="baslik">
            <h2>Ürünler Listesi</h2>
        </div>
            <div class="filtre">
                <asp:DropDownList ID="ddl_kategoriler" runat="server" OnSelectedIndexChanged="ddl_kategoriler_SelectedIndexChanged" AutoPostBack="true" AppendDataBoundItems="true" DataTextField="Isim" DataValueField="ID" >
                    <asp:ListItem Value="-1" Text="Tüm Ürünler"></asp:ListItem>
                    
                </asp:DropDownList>
                <asp:CheckBox ID="cb_satistaOlanlar" runat="server" AutoPostBack="true" OnCheckedChanged="cb_satistaOlanlar_CheckedChanged" Text="Sadece Satışta Olanlar" />
            </div>
        <div class="icerik">
            <asp:ListView ID="lv_urunler" runat="server">
                <LayoutTemplate>
                    <table border="1" colspacing="0" >
                        <tr>
                            <th>Ürün No</th>
                            <th>Ürün Adı</th>
                            <th>Kategori</th>
                            <th>Tedarikçi</th>
                            <th>Stok Miktarı</th>
                            <th>Fiyat</th>
                            <th>Satış Durum</th>
                        </tr>
                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                    </table>
                </LayoutTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("UrunID") %></td>
                        <td><%# Eval("UrunAdi") %></td>
                        <td><%# Eval("KategoriAdi") %></td>
                        <td><%# Eval("TedarikciAdi") %></td>
                        <td><%# Eval("Stok") %></td>
                        <td><%# Eval("Fiyat") %> ₺</td>
                        <td><%# Eval("SatistaMi") %></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView> 
        </div>
    </form>
</body>
</html>
