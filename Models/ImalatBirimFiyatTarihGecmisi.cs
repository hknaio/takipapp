namespace WinFormsApp1.Models
{
    internal class ImalatBirimFiyatTarihGecmisi
    {
        public int ID { get; set; }
        public DateTime GecerlilikBaslangicTarihi { get; set; }
        public double BirimFiyat { get; set; }
        public Imalat Imalat { get; set; }
    }
}
