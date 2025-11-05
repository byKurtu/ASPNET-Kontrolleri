using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_Kontrolleri.model
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public int? TedarikciID { get; set; }
        public string TedarikciAdi { get; set; }
        public int? KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string MiktarBirim { get; set; }
        public decimal? Fiyat { get; set; }
        public short? Stok { get; set; }
        public short? SiparisAdedi { get; set; }
        public short? KritikSeviye { get; set; }
        public bool DevamEdiyorMu { get; set; }

        public string SatistaMi { get; set; }
    }
}