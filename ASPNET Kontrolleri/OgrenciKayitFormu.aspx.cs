using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_Kontrolleri
{
    public partial class OgrenciKayitFormu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            lbl_sonuc.Text = "İsim: " + tb_isim.Text + "<br/>" +
                 "Soyisim: " + tb_soyisim.Text + "<br/>" +
                 "Numara: " + tb_numara.Text + "<br/>" +
                 "Sınıf: " + ddl_sinif.SelectedValue + "<br/>" +
                 "Şube: " + ddl_sube.SelectedValue + "<br/>" +
                 "İlçe: " + ddl_ilce.SelectedValue;

        }
    }
}