using System;
using System.Web.UI;

namespace ASPNET_Kontrolleri
{
    public partial class DersOdev : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
            string isim = tb_isim.Text;
            string kimlik = tb_kimlik.Text;
            string telefon = tb_telefon.Text;
            string sehir = tb_sehir.Text;

            string cinsiyet = rb_erkek.Checked ? "Erkek" : rb_kadin.Checked ? "Kadın" : "Belirtilmedi";

            string medeniHal = rb_evli.Checked ? "Evli" : rb_bekar.Checked ? "Bekar" : "Belirtilmedi";

            string diller = "";
            if (chk_ing.Checked) diller += "İngilizce, ";
            if (chk_alm.Checked) diller += "Almanca, ";
            if (chk_ch.Checked) diller += "Çince, ";
            if (chk_jp.Checked) diller += "Japonca, ";
            if (chk_diger.Checked) diller += "Diğer, ";
            if (diller.EndsWith(", ")) diller = diller.Substring(0, diller.Length - 2);
            if (string.IsNullOrEmpty(diller)) diller = "Yok";

            string onay = chk_onay.Checked ? "Bilgiler onaylandı" : "Onay verilmedi";

            lbl_sonuc.Text =
                $"<b>Ad Soyad:</b> {isim}<br/>" +
                $"<b>T.C. Kimlik No:</b> {kimlik}<br/>" +
                $"<b>Telefon:</b> {telefon}<br/>" +
                $"<b>Şehir:</b> {sehir}<br/>" +
                $"<b>Cinsiyet:</b> {cinsiyet}<br/>" +
                $"<b>Medeni Hâl:</b> {medeniHal}<br/>" +
                $"<b>Yabancı Diller:</b> {diller}<br/>" +
                $"<b>Onay:</b> {onay}";
        }
    }
}
