namespace WinFormsApp1.Models
{
    internal class AsfaltUygulamaVeri
    {
        public int ID { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int Sure { get; set; }
        public YatirimProgrami YatirimProgrami { get; set; }
    }
}
