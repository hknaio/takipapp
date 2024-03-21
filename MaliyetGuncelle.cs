using System.Data.Entity;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class MaliyetGuncelle : Form
    {
        private AppDbContext _dbContext;
        private int _selected;
        private int _projeId;
        public MaliyetGuncelle(double guncelMiktar, int selected, int projeId)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            lblGuncelMiktar.Text = guncelMiktar.ToString();
            _selected = selected;
            _projeId = projeId;
        }

        private void MaliyetGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected = _dbContext.YatirimProgramis.Where(s => s.ID == _selected).FirstOrDefault();
            var proje = _dbContext.Projes.Where(p => p.ID == _projeId).FirstOrDefault();

            if (selected != null && proje != null)
            {
               selected.YaklasikMaliyet = Convert.ToDouble(txtYeniMiktar.Text);
                               
               proje.YaklasikMaliyet -= Convert.ToInt32(lblGuncelMiktar.Text);
               proje.YaklasikMaliyet += selected.YaklasikMaliyet; 

                try
                {
                    _dbContext.Update(proje);
                    _dbContext.Update(selected);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

            txtYeniMiktar.Focus();
        }
    }
}
