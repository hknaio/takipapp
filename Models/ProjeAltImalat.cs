using System.ComponentModel;
using WinFormsApp1.Models;

namespace YatirimTakip.Models
{
    public class ProjeAltImalat
    {
        public int ID { get; set; }
        public string ImalatAdi { get; set; }
        public int Miktar { get; set; }
        public double Fiyat { get; set; }

        [Browsable(false)]
        public Proje Proje { get; set; }
    }
}
