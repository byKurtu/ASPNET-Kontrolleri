using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_Kontrolleri.model
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string Soyisim { get; set; }
        public string Isim { get; set; }
        public string Unvan { get; set; }
        public string Hitap { get; set; }
        public DateTime? DogumTarihi { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string Bolge { get; set; }
        public string PostaKodu { get; set; }
        public string Ulke { get; set; }
        public string Telefon { get; set; }
        public string Dahili { get; set; }
        public byte[] Foto { get; set; }
        public string Notlar { get; set; }
        public int? BagliOlduguKisiID { get; set; }
        public string FotoYolu { get; set; }
    }
}