using WinFormsApp1.Data;
using WinFormsApp1.Models;
using YatirimTakip.Models;

namespace WinFormsApp1
{
    internal partial class YeniProjeEkle : Form
    {
        private AppDbContext _dbContext;
        private readonly User _user;
        public YeniProjeEkle(User user)
        {
            InitializeComponent();
            _user = user;
        }
        private void YeniProjeEkle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
        }
        public void ReceiveData(List<YatirimProgrami> programList)
        {
            if (programList.Count > 0)
            {
                dataGridView1.DataSource = programList;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (ProgramlarSec programlar = new(this, _user))
            {
                programlar.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<YatirimProgrami> programlar = new(); 

            if (IsModelValid())
            {
                try
                {
                    var proje = new Proje
                    {
                        Adi = txtProjeAdi.Text,
                        Aciklama = txtAciklama.Text,
                        User = _user.UserName
                    };

                    _dbContext.Projes.Add(proje);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        var yatirimProgrami = (YatirimProgrami)row.DataBoundItem;
                        yatirimProgrami.Proje = proje;
                        yatirimProgrami.YatirimDurumu = Models.YatirimDurumu.Uygulaniyor;
                        proje.YaklasikMaliyet += yatirimProgrami.YaklasikMaliyet;
                        programlar.Add(yatirimProgrami);
                    }

                    _dbContext.UpdateRange(programlar);
                    _dbContext.SaveChanges();
                    dataGridView1.DataSource = null;
                    ClearTexts();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }

            txtProjeAdi.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsModelValid()
        {
            if (txtProjeAdi.Text != string.Empty && txtAciklama.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearTexts()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox or MaskedTextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }
        
        private void YeniProjeEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
