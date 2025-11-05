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
    public partial class ListViewKullanimi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_urunler.DataSource = UrunListele();
            lv_urunler.DataBind();

            if (!IsPostBack)
            {
                ddl_kategoriler.DataSource = KategoriListele();
                ddl_kategoriler.DataBind();
            }
        }
        public List<Urun> UrunListele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            List<Urun> urunler = new List<Urun>();
            try
            {
                cmd.CommandText = "SELECT P.ProductID, ProductName, P.CategoryID, C.CategoryName, P.SupplierID, S.CompanyName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder,P.ReorderLevel, P.Discontinued FROM Products AS P jOIN Categories AS C ON P.CategoryID = C.CategoryID JOIN Suppliers AS S ON P.SupplierID = S.SupplierID";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Urun u = new Urun();
                    u.UrunID = reader.GetInt32(0);
                    u.UrunAdi = reader.GetString(1);
                    u.KategoriID = reader.GetInt32(2);
                    u.KategoriAdi = reader.GetString(3);
                    u.TedarikciID = reader.GetInt32(4);
                    u.TedarikciAdi = reader.GetString(5);
                    u.MiktarBirim = reader.GetString(6);
                    u.Fiyat = reader.GetDecimal(7);
                    u.Stok = reader.GetInt16(8);
                    u.SiparisAdedi = reader.GetInt16(9);
                    u.KritikSeviye = reader.GetInt16(10);
                    u.DevamEdiyorMu = reader.GetBoolean(11);
                    if (u.DevamEdiyorMu == true)
                    {
                        u.SatistaMi = "Satış Dışı";
                    }

                    urunler.Add(u);
                }
            }
            finally
            {
                con.Close();
            }
            return urunler;
        }

        public List<Urun> UrunListeleKategori(int katNo)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();
            List<Urun> urunler = new List<Urun>();
            try
            {
                cmd.CommandText = "SELECT P.ProductID, ProductName, P.CategoryID, C.CategoryName, P.SupplierID, S.CompanyName, P.QuantityPerUnit, P.UnitPrice, P.UnitsInStock, P.UnitsOnOrder,P.ReorderLevel, P.Discontinued FROM Products AS P jOIN Categories AS C ON P.CategoryID = C.CategoryID JOIN Suppliers AS S ON P.SupplierID = S.SupplierID WHERE P.CategoryID=@kid";
                cmd.Parameters.AddWithValue("@kid", katNo);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Urun u = new Urun();
                    u.UrunID = reader.GetInt32(0);
                    u.UrunAdi = reader.GetString(1);
                    u.KategoriID = reader.GetInt32(2);
                    u.KategoriAdi = reader.GetString(3);
                    u.TedarikciID = reader.GetInt32(4);
                    u.TedarikciAdi = reader.GetString(5);
                    u.MiktarBirim = reader.GetString(6);
                    u.Fiyat = reader.GetDecimal(7);
                    u.Stok = reader.GetInt16(8);
                    u.SiparisAdedi = reader.GetInt16(9);
                    u.KritikSeviye = reader.GetInt16(10);
                    u.DevamEdiyorMu = reader.GetBoolean(11);
                    if (u.DevamEdiyorMu == true)
                    {
                        u.SatistaMi = "Satış Dışı";
                    }

                    urunler.Add(u);
                }
            }
            finally
            {
                con.Close();
            }
            return urunler;
        }

        private List<Kategori> KategoriListele()
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
                return kategoriler;
            }
            finally
            {
                con.Close();
            }
        }
        protected void ddl_kategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kn = Convert.ToInt32(ddl_kategoriler.SelectedValue);
            if (kn == -1)
            {
                lv_urunler.DataSource = UrunListele();
                lv_urunler.DataBind();
            }
            else
            {
                lv_urunler.DataSource = UrunListeleKategori(kn);
                lv_urunler.DataBind();
            }
        }

        protected void cb_satistaOlanlar_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_satistaOlanlar.Checked)
            {
                var urunler = UrunListele().Where(u => !u.DevamEdiyorMu).ToList();
                lv_urunler.DataSource = urunler;
                lv_urunler.DataBind();
            }
            else
            {
                lv_urunler.DataSource = UrunListele();
                lv_urunler.DataBind();
            }
        }
    }
}