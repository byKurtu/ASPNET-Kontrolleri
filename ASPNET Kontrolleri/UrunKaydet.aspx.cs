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
    public partial class UrunKaydet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            KategorileriDoldur();
            TedarikcileriDoldur();
        }
        public void KategorileriDoldur()
        {
            List<Kategori> kategoriler = new List<Kategori>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT CategoryID,CategoryName FROM Categories";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Kategori kat = new Kategori();
                    kat.ID = reader.GetInt32(0);
                    kat.Isim = reader.GetString(1);
                    kategoriler.Add(kat);
                }
            }
            finally{con.Close();}
            ddl_kategoriler.DataSource = kategoriler;
            ddl_kategoriler.DataBind();
        }

        public void TedarikcileriDoldur()
        {
            List<Tedarikci> tedarikciler = new List<Tedarikci>();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT SupplierID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage FROM Suppliers";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Tedarikci t = new Tedarikci();
                    t.TedarikciID = reader.GetInt32(0);
                    t.SirketAdi = reader.GetString(1);
                    t.IletisimAdi = !reader.IsDBNull(2) ? reader.GetString(2) : "-";
                    t.IletisimUnvani = !reader.IsDBNull(3) ? reader.GetString(3) : "-";
                    t.Adres = !reader.IsDBNull(4) ? reader.GetString(4) : "-";
                    t.Sehir = !reader.IsDBNull(5) ? reader.GetString(5) : "-";
                    t.Bolge = !reader.IsDBNull(6) ? reader.GetString(6) : "-";
                    t.PostaKodu = !reader.IsDBNull(7) ? reader.GetString(7) : "-";
                    t.Ulke = !reader.IsDBNull(8) ? reader.GetString(8) : "-";
                    t.Telefon = !reader.IsDBNull(9) ? reader.GetString(9) : "-";
                    t.Faks = !reader.IsDBNull(10) ? reader.GetString(10) : "-";
                    t.AnaSayfa = !reader.IsDBNull(11) ? reader.GetString(11) : "-";
                    tedarikciler.Add(t);
                }
            }
            finally { con.Close(); }
            ddl_tedarikciler.DataSource = tedarikciler;
            ddl_tedarikciler.DataBind();
        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            try
            {
                cmd.CommandText = @"INSERT INTO Products (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued) VALUES (@ProductName, @SupplierID, @CategoryID, @QuantityPerUnit, @UnitPrice, @UnitsInStock, @UnitsOnOrder, @ReorderLevel, @Discontinued)";
                cmd.Parameters.AddWithValue("@ProductName", tb_isim.Text);
                cmd.Parameters.AddWithValue("@SupplierID", ddl_tedarikciler.SelectedValue);
                cmd.Parameters.AddWithValue("@CategoryID", ddl_kategoriler.SelectedValue);
                cmd.Parameters.AddWithValue("@QuantityPerUnit", "1 Kutu");
                cmd.Parameters.AddWithValue("@UnitPrice", decimal.Parse(tb_fiyat.Text));
                cmd.Parameters.AddWithValue("@UnitsInStock", short.Parse(tb_stok.Text));
                cmd.Parameters.AddWithValue("@UnitsOnOrder", short.Parse(tb_siparis.Text));
                cmd.Parameters.AddWithValue("@ReorderLevel", short.Parse(tb_guvenlik.Text));
                cmd.Parameters.AddWithValue("@Discontinued", cb_satistaMi.Checked ? 0 : 1);
                con.Open();
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Ürün başarıyla kaydedildi!');</script>");
                tb_isim.Text = "";
                tb_fiyat.Text = "0.00";
                tb_stok.Text = "0";
                tb_guvenlik.Text = "0";
                tb_siparis.Text = "0";
                cb_satistaMi.Checked = false;
                ddl_kategoriler.SelectedIndex = 0;
                ddl_tedarikciler.SelectedIndex = 0;
            }
            finally{con.Close();}
        }
    }
}