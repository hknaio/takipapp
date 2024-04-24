namespace WinFormsApp1.Models
{
    public enum ParkeBordurTip
    {
        Parke,
        Bordur
    }
    internal class ParkeBordurIs
    {
        public int ID { get; set; }
        public int Miktar { get; set; }
        public string Birim { get; set; }
        public string KoyAdi { get; set; }
        public string TalepEden { get; set; }
        public DateTime GidisTarihi { get; set; }
        public string AracPlakasi { get; set; }
        public ParkeBordurTip ParkeBordurTip { get; set; }  
    }
}
