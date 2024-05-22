using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class AsfaltSantiyeEkle : Form
    {
        private AppDbContext _dbContext;
        public AsfaltSantiyeEkle()
        {
            InitializeComponent();
        }

        private void AsfaltSantiyeEkle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                try
                {
                    _dbContext.Add(new AsfaltSantiye
                    {
                        Tarih = dtTarih.Value.Date,
                        Koy1 = txtKoy1.Text,
                        Koy2 = txtKoy2.Text,
                        Koy3 = txtKoy3.Text,
                        Ton = Convert.ToInt32(txtTon.Text)
                    });

                    _dbContext.SaveChanges();
                }

                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

            txtKoy1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsModelValid()
        {
            if (txtKoy1.Text != string.Empty && txtKoy2.Text != string.Empty && txtKoy3.Text != string.Empty
                && txtTon.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void AsfaltSantiyeEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
