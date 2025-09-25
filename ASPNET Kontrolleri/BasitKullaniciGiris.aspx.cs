using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_Kontrolleri
{
    public partial class BasitKullaniciGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_giris_Click(object sender, EventArgs e)           
        {
            if(!string.IsNullOrEmpty(tb_kadi.Text)) {
                if (tb_kadi.Text == "admin" && tb_sifre.Text == "1234" && tb_tekrarsifre.Text == "1234")
                {
                    lbl_mesaj.Text = "Giriş Başarılı";
                    lbl_mesaj.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lbl_mesaj.Text = "Giriş Başarısız";
                    lbl_mesaj.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                lbl_kadiMesaj.Text = "Kullanıcı Adı Boş Bırakılamaz";
            }

            if(!string.IsNullOrEmpty(tb_sifre.Text))
            {
                if(tb_sifre.Text == tb_tekrarsifre.Text)
                {
                    lbl_mesaj.Text = "Şifreler Uyuşuyor";
                }
            }
            else
            {
                lbl_sifreMesaj.Text = "Şifre Boş Bırakılamaz";
            }
            if (!string.IsNullOrEmpty(tb_tekrarsifre.Text))
            {
            }
            else
            {
                lbl_tekrarSifreMesaj.Text = "Şifre Boş Bırakılamaz";
            }
            if (!string.IsNullOrEmpty(tb_eposta.Text))
            {
            }
            else
            {
                lbl_epostaMesaj.Text = "E Posta Boş Bırakılamaz";
            }
            if (tb_eposta.Text.Contains("@"))
            {
                
            }
            else
            {
                lbl_epostaMesaj.Text = "E Posta Adresi Geçersiz";
            }
            if (!string.IsNullOrEmpty(tb_telno.Text))
            {
            }
            else
            {
                lbl_telnoMesaj.Text = "Telefon Numarası Boş Bırakılamaz";
            }

        }
    }
}