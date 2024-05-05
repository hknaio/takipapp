
namespace WinFormsApp1.Models
{
    internal class AsfaltDokum
    {
        public int ID { get; set; }
        public double AstarMiktari { get; set; }
        public double YamaMiktari { get; set; }
        public double AsfaltMiktari { get; set; }
        public double DokumMesafesi { get; set; }
        public DateTime DokumTarihi { get; set; }
        public double DokumBedeli { get; set; }
        public double BSKMiktari { get; set; }
        public YatirimProgrami YatirimProgrami { get; set; }
    }
}
