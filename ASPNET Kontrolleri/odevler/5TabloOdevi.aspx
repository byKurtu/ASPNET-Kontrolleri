<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5TabloOdevi.aspx.cs" Inherits="ASPNET_Kontrolleri.odevler._5TabloOdevi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>5 Tablo Ödevi</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Data Grid View</h1>

            <h3>Personel Tablosu</h3>
            <asp:GridView ID="gv_personeller" runat="server"></asp:GridView>

            <br />

            <h3>Müşteri Tablosu</h3>
            <asp:GridView ID="gv_musteriler" runat="server"></asp:GridView>
        </div>

        <br />

        <h1>Data List View</h1>

        <h3>Tedarikçi Tablosu</h3>
        <asp:ListView ID="lv_tedarikciler" runat="server">
            <LayoutTemplate>
                <table border="1" cellspacing="0" cellpadding="4">
                    <tr style="background-color:#f2f2f2;">
                        <th>Tedarikçi ID</th>
                        <th>Şirket Adı</th>
                        <th>İletişim Adı</th>
                        <th>İletişim Ünvanı</th>
                        <th>Adres</th>
                        <th>Şehir</th>
                        <th>Bölge</th>
                        <th>Posta Kodu</th>
                        <th>Ülke</th>
                        <th>Telefon</th>
                        <th>Faks</th>
                        <th>Ana Sayfa</th>
                    </tr>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Eval("TedarikciID") %></td>
                    <td><%# Eval("SirketAdi") %></td>
                    <td><%# Eval("IletisimAdi") %></td>
                    <td><%# Eval("IletisimUnvani") %></td>
                    <td><%# Eval("Adres") %></td> 
                    <td><%# Eval("Sehir") %></td>
                    <td><%# Eval("Bolge") %></td>
                    <td><%# Eval("PostaKodu") %></td>
                    <td><%# Eval("Ulke") %></td>
                    <td><%# Eval("Telefon") %></td>
                    <td><%# Eval("Faks") %></td>
                    <td><%# Eval("AnaSayfa") %></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>

        <br />

        <h3>Siparişler Tablosu</h3>
        <asp:ListView ID="lv_orders" runat="server">
            <LayoutTemplate>
                <table border="1" cellspacing="0" cellpadding="4">
                    <tr style="background-color:#f2f2f2;">
                        <th>Sipariş No</th>
                        <th>Müşteri ID</th>
                        <th>Çalışan ID</th>
                        <th>Sipariş Tarihi</th>
                        <th>Sevkiyat Tarihi</th>
                        <th>Kargo Şirketi</th>
                        <th>Kargo Ücreti</th>
                        <th>Ülke</th>
                        <th>Şehir</th>
                        <th>Adres</th>
                        <th>Posta Kodu</th>
                    </tr>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Eval("OrderID") %></td>
                    <td><%# Eval("CustomerID") %></td>
                    <td><%# Eval("EmployeeID") %></td>
                    <td><%# Eval("OrderDate", "{0:dd.MM.yyyy}") %></td>
                    <td><%# Eval("ShippedDate", "{0:dd.MM.yyyy}") %></td>
                    <td><%# Eval("ShipName") %></td>
                    <td><%# Eval("Freight") %> ₺</td>
                    <td><%# Eval("ShipCountry") %></td>
                    <td><%# Eval("ShipCity") %></td>
                    <td><%# Eval("ShipAddress") %></td>
                    <td><%# Eval("ShipPostalCode") %></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>

        <br />

        <h3>Sipariş Detayları Tablosu</h3>
        <asp:ListView ID="lv_orderdetails" runat="server">
            <LayoutTemplate>
                <table border="1" cellspacing="0" cellpadding="4">
                    <tr style="background-color:#f2f2f2;">
                        <th>Sipariş No</th>
                        <th>Ürün No</th>
                        <th>Birim Fiyat</th>
                        <th>Adet</th>
                        <th>İndirim</th>
                    </tr>
                    <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Eval("OrderID") %></td>
                    <td><%# Eval("ProductID") %></td>
                    <td><%# Eval("UnitPrice") %> ₺</td>
                    <td><%# Eval("Quantity") %></td>
                    <td><%# Eval("Discount") %></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>

    </form>
</body>
</html>
