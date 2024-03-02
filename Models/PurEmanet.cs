
namespace WinFormsApp1.Models
{
    internal class PurEmanet
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public int IlceId { get; set; }
        public Ilce Ilce { get; set; }
        public int KoyId { get; set; }
        public Koy Koy { get; set; }
        public int ImalatId { get; set; }
        public Imalat Imalat { get; set; }
        public int? SpiralBoruId { get; set; }
        public SpiralBoru? SpiralBoru { get; set; }
        public double Miktar { get; set; }
        public double Tutar { get; set; }
    }
}
