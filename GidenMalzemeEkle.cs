using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class GidenMalzemeEkle : Form
    {
        private AppDbContext _dbContext;
        public GidenMalzemeEkle()
        {
            InitializeComponent();
        }
        private void GidenMalzemeEkle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            txtDiger.Visible = false;
        }

        private void cmbEvsaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEvsaf.Text == "Diğer")
            {
                txtDiger.Visible = true;
            }
            else
            {
                txtDiger.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                try
                {
                    _dbContext.Add(new GidenMalzeme
                    {
                        Evsaf = cmbEvsaf.Text == "Diğer" ? txtDiger.Text : cmbEvsaf.Text,
                        Yer = txtYer.Text,
                        Personel = cmbPersonel.Text,
                        Tarih = dtTarih.Value.Date,                       
                    });

                    _dbContext.SaveChanges();
                }

                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

             cmbEvsaf.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsModelValid()
        {
            if (cmbEvsaf.Text != string.Empty && cmbPersonel.Text != string.Empty && txtYer.Text != string.Empty
                )
            {
                return true;
            }

            return false;
        }
        private void GidenMalzemeEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
