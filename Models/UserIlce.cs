using WinFormsApp1.Models;

namespace YatirimTakip.Models
{
    internal class UserIlce
    {
        public int ID { get; set; }
        public int IlceId { get; set; }
        public int UserId { get; set; } 
        public Ilce Ilce { get; set; }
        public User User { get; set; }
    }
}
