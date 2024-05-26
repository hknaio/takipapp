using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class ParkeBordurStokGuncelle : Form
    {
        private AppDbContext _dbContext;
        private string _malzeme;
        public ParkeBordurStokGuncelle(string malzeme)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            _malzeme = malzeme;
            label2.Text = _dbContext.ParkeBordurs.Where(p => p.Malzeme == _malzeme).Select(p => p.StokMiktar).FirstOrDefault()
                .ToString();
            _dbContext = new AppDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var malzeme = _dbContext.ParkeBordurs.Where(s => s.Malzeme == _malzeme).FirstOrDefault();

            if (malzeme != null && txtYeniMiktar.Text != string.Empty)
            {
                malzeme.StokMiktar = Convert.ToInt32(txtYeniMiktar.Text);

                try
                {
                    _dbContext.Update(malzeme);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

            txtYeniMiktar.Focus();
        }
    }
}
