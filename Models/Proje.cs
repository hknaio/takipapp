
using System.ComponentModel;

namespace WinFormsApp1.Models
{
    public enum ProjeDurumu
    {        
        IhaleHazirlik,
        IhaleAsamasi,
        DevamEdiyor,
        GeciciKabul,
        KesinKabul,
        Bitti,
        Sonuclandi
    }
    public class Proje
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string? Aciklama { get; set; }

        [Browsable(false)]
        public DateTime? IseBaslamaTarihi { get; set; }

        [Browsable(false)]
        public DateTime? IsBitisTarihi { get; set; }

        [Browsable(false)]
        public int Sure { get; set; }
        public string? Yuklenici { get; set; }

        [Browsable(false)]
        public DateTime? GeciciKabulTarihi { get; set; }

        [Browsable(false)]
        public DateTime? KesinKabulTarihi { get; set; }
        public ProjeDurumu ProjeDurumu { get; set; }
        public double SozlesmeBedeli { get; set; }
        public double YaklasikMaliyet { get; set; }

        [Browsable(false)]
        public double HakedisToplami { get; set; }

        [Browsable(false)]
        public double HakedisToplamTahakkuk { get; set; }

        [Browsable(false)]
        public ICollection<YatirimProgrami> Programis { get; set; }

        [Browsable(false)]
        public ICollection<Hakedis>? Hakedis { get; set; }
    }
}
