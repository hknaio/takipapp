namespace WinFormsApp1.Models
{
    internal class SpiralBirimFiyatTarihGecmisi
    {
        public int ID { get; set; }
        public DateTime GecerlilikBaslangicTarihi { get; set; }
        public double BirimFiyat { get; set; }
        public SpiralBoru SpiralBoru { get; set; }
    }
}
