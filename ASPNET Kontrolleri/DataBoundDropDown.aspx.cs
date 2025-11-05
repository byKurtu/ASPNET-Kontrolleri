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
    public partial class DataBoundDropDown : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                VeriKaynagi vk = new VeriKaynagi();
                ddl_ogrenciler.DataTextField = "IsimSoyisim";
                ddl_ogrenciler.DataValueField = "No";
                ddl_ogrenciler.DataSource = vk.OgrenciGetir();
                ddl_ogretmenler.DataTextField = "ogretmenIsimSoyisim";
                ddl_ogretmenler.DataSource = vk.OgretmenGetir();
                ddl_ogretmenler.DataBind();
                ddl_ogrenciler.DataBind();//ddl'e data bind eklenmez ise veriler bağlanmaz.

                ddl_kategoriler.DataSource = KategorileriGetir();
                ddl_kategoriler.DataBind();

            }
        }

        protected void btn_sec_Click(object sender, EventArgs e)
        {
            string secilen = ddl_ogrenciler.SelectedItem.Text;
            lbl_secilen.Text = "Seçilen Öğrenci: " + secilen;
        }

        protected void btn_sec2_Click(object sender, EventArgs e)
        {
            string secilenogretmen = ddl_ogretmenler.SelectedItem.Text;
            lbl_ogretmen.Text = "Seçilen Öğretmen: " + secilenogretmen;
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
    }
}