using ASPNET_Kontrolleri.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_Kontrolleri.odevler
{
    public partial class _5TabloOdevi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_tedarikciler.DataSource = TedarikciGetir();
            lv_tedarikciler.DataBind();

            lv_orders.DataSource = OrdersGetir();
            lv_orders.DataBind();

            lv_orderdetails.DataSource = OrderDetailsGetir();
            lv_orderdetails.DataBind();

            if (!IsPostBack)
            {
                gv_personeller.DataSource = PersonelleriGetir();
                gv_personeller.DataBind();

                gv_musteriler.DataSource = MusteriGetir();
                gv_musteriler.DataBind();
            }
        }

        private List<Tedarikci> TedarikciGetir()
        {
            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = @"SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tedarikci t = new Tedarikci();
                    t.TedarikciID = reader.GetInt32(0);
                    t.SirketAdi = reader.GetString(1);
                    t.IletisimAdi = reader.IsDBNull(2) ? null : reader.GetString(2);
                    t.IletisimUnvani = reader.IsDBNull(3) ? null : reader.GetString(3);
                    t.Adres = reader.IsDBNull(4) ? null : reader.GetString(4);
                    t.Sehir = reader.IsDBNull(5) ? null : reader.GetString(5);
                    t.Bolge = reader.IsDBNull(6) ? null : reader.GetString(6);
                    t.PostaKodu = reader.IsDBNull(7) ? null : reader.GetString(7);
                    t.Ulke = reader.IsDBNull(8) ? null : reader.GetString(8);
                    t.Telefon = reader.IsDBNull(9) ? null : reader.GetString(9);
                    t.Faks = reader.IsDBNull(10) ? null : reader.GetString(10);
                    t.AnaSayfa = reader.IsDBNull(11) ? null : reader.GetString(11);

                    tedarikciler.Add(t);
                }
                return tedarikciler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        private List<Musteri> MusteriGetir()
        {
            List<Musteri> musteriler = new List<Musteri>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = @"SELECT CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax FROM Customers";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Musteri m = new Musteri();
                    m.MusteriID = reader.GetString(0);
                    m.SirketAdi = reader.GetString(1);
                    m.IletisimAdi = reader.IsDBNull(2) ? null : reader.GetString(2);
                    m.IletisimUnvani = reader.IsDBNull(3) ? null : reader.GetString(3);
                    m.Adres = reader.IsDBNull(4) ? null : reader.GetString(4);
                    m.Sehir = reader.IsDBNull(5) ? null : reader.GetString(5);
                    m.Bolge = reader.IsDBNull(6) ? null : reader.GetString(6);
                    m.PostaKodu = reader.IsDBNull(7) ? null : reader.GetString(7);
                    m.Ulke = reader.IsDBNull(8) ? null : reader.GetString(8);
                    m.Telefon = reader.IsDBNull(9) ? null : reader.GetString(9);
                    m.Faks = reader.IsDBNull(10) ? null : reader.GetString(10);
                    musteriler.Add(m);

                }
                return musteriler;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        

        private List<Personel> PersonelleriGetir()
        {
            List<Personel> Personeller = new List<Personel>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = @"SELECT EmployeeID, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, 
                                   Address, City, Region, PostalCode, Country, HomePhone, Extension, Photo, Notes, ReportsTo, PhotoPath 
                            FROM Employees";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Personel per = new Personel();

                    per.PersonelID = reader.GetInt32(0);
                    per.Soyisim = reader.GetString(1);
                    per.Isim = reader.GetString(2);
                    per.Unvan = reader.GetString(3);
                    per.Hitap = reader.GetString(4);
                    per.DogumTarihi = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5);
                    per.IseGirisTarihi = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6);
                    per.Adres = reader.IsDBNull(7) ? null : reader.GetString(7);
                    per.Sehir = reader.IsDBNull(8) ? null : reader.GetString(8);
                    per.Bolge = reader.IsDBNull(9) ? null : reader.GetString(9);
                    per.PostaKodu = reader.IsDBNull(10) ? null : reader.GetString(10);
                    per.Ulke = reader.IsDBNull(11) ? null : reader.GetString(11);
                    per.Telefon = reader.IsDBNull(12) ? null : reader.GetString(12);
                    per.Dahili = reader.IsDBNull(13) ? null : reader.GetString(13);
                    per.Foto = reader.IsDBNull(14) ? null : (byte[])reader[14];
                    per.Notlar = reader.IsDBNull(15) ? null : reader.GetString(15);
                    per.BagliOlduguKisiID = reader.IsDBNull(16) ? (int?)null : reader.GetInt32(16);
                    per.FotoYolu = reader.IsDBNull(17) ? null : reader.GetString(17);

                    Personeller.Add(per);
                }
                return Personeller;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }


        }

        private List<Order> OrdersGetir()
        {
            List<Order> orders = new List<Order>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = @"SELECT OrderID, CustomerID, EmployeeID, OrderDate, ShippedDate, ShipName, Freight, ShipCountry, ShipCity, ShipAddress, ShipPostalCode FROM Orders";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Order o = new Order();
                    o.OrderID = reader.GetInt32(0);
                    o.CustomerID = reader.IsDBNull(1) ? null : reader.GetString(1);
                    o.EmployeeID = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2);
                    o.OrderDate = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3);
                    o.ShippedDate = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4);
                    o.ShipName = reader.IsDBNull(5) ? null : reader.GetString(5);
                    o.Freight = reader.IsDBNull(6) ? (decimal?)null : reader.GetDecimal(6);
                    o.ShipCountry = reader.IsDBNull(7) ? null : reader.GetString(7);
                    o.ShipCity = reader.IsDBNull(8) ? null : reader.GetString(8);
                    o.ShipAddress = reader.IsDBNull(9) ? null : reader.GetString(9);
                    o.ShipPostalCode = reader.IsDBNull(10) ? null : reader.GetString(10);
                    orders.Add(o);
                }
                return orders;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }

        private List<OrderDetail> OrderDetailsGetir()
        {
            List<OrderDetail> detaylar = new List<OrderDetail>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = @"SELECT OrderID, ProductID, UnitPrice, Quantity, Discount FROM [Order Details]";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    OrderDetail d = new OrderDetail();
                    d.OrderID = reader.GetInt32(0);
                    d.ProductID = reader.GetInt32(1);
                    d.UnitPrice = reader.GetDecimal(2);
                    d.Quantity = reader.GetInt16(3);
                    d.Discount = reader.GetFloat(4);
                    detaylar.Add(d);
                }
                return detaylar;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
    }
}