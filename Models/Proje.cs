
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WinFormsApp1.Models
{
    public static class EnumList
    {
        public static IEnumerable<KeyValuePair<T, string>> EnumKeyValue<T>()
        {
            return Enum.GetValues(typeof(T))
                .Cast<T>()
                .Select(p => new KeyValuePair<T, string>(
                    p,
                    (p.GetType().GetField(p.ToString())
                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault() as DescriptionAttribute)?.Description ?? p.ToString()
                    ))
                    .ToList();
        }
    }
    public enum ProjeDurumu
    {
        [Description("İhale Hazırlık")]
        IhaleHazirlik,
        [Description("İhale Aşaması")]
        IhaleAsamasi,
        [Description("Devam Ediyor")]
        DevamEdiyor,
        [Description("Geçici Kabul")]
        GeciciKabul,
        [Description("Kesin Kabul")]
        KesinKabul,
        [Description("Bitti (Geçici)")]
        Bitti,
        [Description("Sonuçlandı (Kesin)")]
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
