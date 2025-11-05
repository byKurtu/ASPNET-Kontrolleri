using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_Kontrolleri.model
{
    public class Musteri
    {
        public string MusteriID { get; set; }
        public string SirketAdi { get; set; }
        public string IletisimAdi { get; set; }
        public string IletisimUnvani { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public string Telefon { get; set; }
        public string Faks { get; set; }

    }
}