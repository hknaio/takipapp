namespace WinFormsApp1.Models
{
    internal class PurEmanetMezra
    {
        public int ID { get; set; } 
        public int PurEmanetId { get; set; }
        public int MezraId { get; set; }
        public PurEmanet PurEmanet { get; set; } = null!;
        public Mezra Mezra { get; set; } = null!;
    }
}
