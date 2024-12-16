namespace WinFormsApp1.Models
{
    internal class TuprasMalzeme
    {
        public int ID { get; set; }
        public string Tur {  get; set; }
        public DateTime Tarih {  get; set; }
        public int SiparisNo { get; set; }
        public double TuprasNet { get; set; }
        public double IlOzelNet { get; set; }
        public int TartimNo { get; set; }
        public double Fark { get; set; }
    }
}
