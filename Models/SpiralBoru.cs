namespace WinFormsApp1.Models
{
    internal class SpiralBoru
    {
        public int ID { get; set; }
        public int Cap { get; set; }
        public int StokMiktar { get; set; }
        public string Birim { get; set; } 
        public double BirimFiyat { get; set; }
        public string? Mudurluk { get; set; }
        public DateTime FiyatGecerlilikBaslangicTarihi { get; set; }
        public ICollection<SpiralBirimFiyatTarihGecmisi> TarihListesi { get; set; }

    }
}
