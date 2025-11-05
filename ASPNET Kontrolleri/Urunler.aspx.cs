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
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gv_urunler.DataSource = UrunListele();
                gv_urunler.DataBind();

                ddl_kategoriler.DataSource = KategorileriGetir();
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

        private List<Kategori> KategorileriGetir()
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

        protected void btn_filtre_Click(object sender, EventArgs e)
        {
            if (ddl_kategoriler.SelectedItem.Value != "-1")
            {
                int katNo = Convert.ToInt32(ddl_kategoriler.SelectedItem.Value);
                gv_urunler.DataSource = UrunListeleKategori(katNo);
                gv_urunler.DataBind();
            }
            else
            {
                gv_urunler.DataSource = UrunListele();
                gv_urunler.DataBind(); ;
            }
        }
    }
}