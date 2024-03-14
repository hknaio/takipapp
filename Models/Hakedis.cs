using System.ComponentModel;

namespace WinFormsApp1.Models
{
    public class Hakedis
    {
        public int ID { get; set; } 
        public string Adi { get; set; }   
        public double Miktar { get; set; }

        [Browsable(false)]
        public Proje Proje { get; set; }
    }
}
