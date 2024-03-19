
using System.ComponentModel;

namespace WinFormsApp1.Models
{
    public enum YatirimDurumu
    {
        Uygulanmadi,
        IhaleAsamasi,
        Uygulandi
    }
    public class YatirimProgrami 
    {
        public int ID { get; set; }
        public string Ilce {  get; set; }
        public string Koy { get; set; }
        public string Birim { get; set; }
        public string Imalat { get; set; }
        public string Miktar { get; set; }
        public string Kaynak { get; set; }
        public double Uygulama { get; set; }
        public double YaklasikMaliyet { get; set; }
        public int Yil { get; set; }        
        public string Program { get; set; } 
        public YatirimDurumu YatirimDurumu { get; set; }
        public Proje? Proje { get; set; }
    }
}
