using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class StokGuncelle : Form
    {
        private AppDbContext _dbContext;
        private int _selected;
        public StokGuncelle(int guncelMiktar, int selected)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            label2.Text = guncelMiktar.ToString();
            _selected = selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected = _dbContext.SpiralBorus.Where(s => s.ID == _selected).FirstOrDefault();

            if (selected != null)
            {
                selected.StokMiktar = Convert.ToInt32(txtYeniMiktar.Text);

                try
                {
                    _dbContext.Update(selected);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

            txtYeniMiktar.Focus();
        }

        private void StokGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
