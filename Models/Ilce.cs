
namespace WinFormsApp1.Models
{
    internal class Ilce
    {
        public int ID {  get; set; }
        public string Adi { get; set; }
        public ICollection<Koy> Koyler { get; set; }
    }
}
