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
    public partial class VeriTabanindanPersonelCekme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gv_personeller.DataSource = PersonelleriGetir();
            gv_personeller.DataBind();
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

    }
}