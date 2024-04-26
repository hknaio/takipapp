using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class ParkeBordurMiktarGuncelle : Form
    {
        private AppDbContext _dbContext;
        private int _selected;
        private string _malzeme;
        public ParkeBordurMiktarGuncelle(int guncelMiktar, string malzeme, int selected)
        {
            InitializeComponent();
            _selected = selected;
            _malzeme = malzeme;
            _dbContext = new AppDbContext();
            label2.Text = guncelMiktar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected = _dbContext.ParkeBordurIs.Where(s => s.ID == _selected).FirstOrDefault();
            var malzeme = _dbContext.ParkeBordurs.Where(s => s.Malzeme == _malzeme).FirstOrDefault();

            if (selected != null && malzeme != null)
            {
                malzeme.StokMiktar += selected.Miktar - Convert.ToInt32(txtYeniMiktar.Text);

                selected.Miktar = Convert.ToInt32(txtYeniMiktar.Text);

                try
                {
                    _dbContext.Update(malzeme);
                    _dbContext.Update(selected);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

            txtYeniMiktar.Focus();
        }

        private void ParkeBordurMiktarGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
