using DocumentFormat.OpenXml.Wordprocessing;

namespace YatirimTakip.Models
{    
    internal class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string Birim { get; set; }
        public string Role { get; set; }
        public string IsimSoyisim => $"{Isim} {Soyisim}";
    }
}
