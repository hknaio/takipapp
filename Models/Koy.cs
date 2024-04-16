
namespace WinFormsApp1.Models
{
    internal class Koy
    {
        public int ID { get; set; }
        public string Adi { get; set; }
        public ICollection<Mezra> Mezralar { get; set; }
        public Ilce Ilce { get; set; }
    }
}
