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
    public partial class TablosuzListView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_urunler.DataSource = UrunListele();
            lv_urunler.DataBind();
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
    }
}