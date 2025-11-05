using ASPNET_Kontrolleri.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_Kontrolleri
{
    public partial class DataGridViewKullanimi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VeriKaynagi veriKaynagi = new VeriKaynagi();
            gv_ogrenciler.DataSource = veriKaynagi.OgrenciGetir();
            gv_ogrenciler.DataBind();

            gv_kategoriler.DataSource = KategorileriGetir();
            gv_kategoriler.DataBind();

            gv_personeller.DataSource = PersonelleriGetir();
            gv_personeller.DataBind();

            gv_urunler.DataSource = UrunleriGetir();
            gv_urunler.DataBind();
        }

        private List<Kategori> KategorileriGetir()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT CategoryID,CategoryName,Description FROM Categories";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kategori kat = new Kategori();
                    kat.ID = reader.GetInt32(0);
                    kat.Isim = reader.GetString(1);
                    if (!reader.IsDBNull(2))
                    {
                        kat.Aciklama = reader.GetString(2);
                    }
                    kategoriler.Add(kat);
                }
                return kategoriler;
            }
            catch { return null; }
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
        private List<Urun> UrunleriGetir()
        {
            List<Urun> urunler = new List<Urun>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel,Discontinued FROM Products";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Urun ur = new Urun();
                    ur.UrunID = reader.GetInt32(0);
                    ur.UrunAdi = reader.GetString(1);
                    ur.TedarikciID = reader.GetInt32(2);
                    ur.KategoriID = reader.GetInt32(3);
                    ur.MiktarBirim = reader.GetString(4);
                    ur.Fiyat = reader.GetDecimal(5);
                    ur.Stok = reader.GetInt16(6);
                    ur.SiparisAdedi = reader.GetInt16(7);
                    ur.KritikSeviye = reader.GetInt16(8);
                    ur.DevamEdiyorMu = reader.GetBoolean(9);

                    urunler.Add(ur);
                }
                return urunler;
            }
            catch { return null; }
            finally
            {
                con.Close();
            }
        }

    }
}
    