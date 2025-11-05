using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_Kontrolleri.model
{
    public class Tedarikci
    {
        public int TedarikciID { get; set; }
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
        public string AnaSayfa { get; set; }
    }

}