namespace WinFormsApp1.Models
{
    internal class Imalat
    {
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Cins { get; set; }
        public string Birim { get; set; }
        public double BirimFiyat { get; set; }
        public DateTime FiyatGecerlilikBaslangicTarihi {  get; set; }
        public ICollection<ImalatBirimFiyatTarihGecmisi> TarihListesi { get; set; }
    }
}
