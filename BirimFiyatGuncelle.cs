using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class BirimFiyatGuncelle : Form
    {
        private AppDbContext _dbContext;
        private int _selected;
        public BirimFiyatGuncelle(double guncelFiyat, int selected)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            label2.Text = guncelFiyat.ToString();
            _selected = selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected = _dbContext.Imalats.Where(s => s.ID == _selected).FirstOrDefault();

            if (selected != null && txtYeniMiktar.Text != string.Empty)
            {
                selected.BirimFiyat = Convert.ToDouble(txtYeniMiktar.Text);

                try
                {
                    _dbContext.Update(selected);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }

                this.Close();
            }

            txtYeniMiktar.Focus();
        }

        private void BirimFiyatGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
