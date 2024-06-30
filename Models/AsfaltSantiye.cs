namespace WinFormsApp1.Models
{
    internal class AsfaltSantiye
    {
        public int ID { get; set; }
        public DateTime Tarih { get; set; }
        public int Ton { get; set; }
        public int IlceId { get; set; }
        public Ilce Ilce { get; set; }
        public int KoyId { get; set; }
        public Koy Koy { get; set; }
        public int? MezraId { get; set; }
        public Mezra? Mezra { get; set; }
    }
}
