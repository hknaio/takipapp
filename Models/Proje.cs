
namespace WinFormsApp1.Models
{
    public enum ProjeDurumu
    {
        DevamEdiyor,
        GeciciKabul,
        KesinKabul,
        Bitti,
        Sonuclandi
    }
    internal class Proje
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public string? Aciklama { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public DateTime IsBitisTarihi { get; set; }
        public int Sure { get; set; }
        public string Yuklenici { get; set; }
        public DateTime GeciciKabulTarihi { get; set; }
        public DateTime KesinKabulTarihi { get; set; }
        public ProjeDurumu ProjeDurumu { get; set; }
        public double SozlesmeBedeli { get; set; }
        public double YaklasikMaliyet { get; set; }
        public ICollection<YatirimProgrami> Programis { get; set; }
        public ICollection<Hakedis>? Hakedis { get; set; }
    }
}
