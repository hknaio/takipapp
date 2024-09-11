using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class YatirimProgramiDuzenle : Form
    {
        private AppDbContext _dbContext;
        private readonly int _id;
        private YatirimProgrami _yatirimProgrami;
        public YatirimProgramiDuzenle(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void YatirimProgramiDuzenle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _yatirimProgrami = _dbContext!.YatirimProgramis.Where(y => y.ID == _id).FirstOrDefault();

            if (_yatirimProgrami is not null)
            {
                lblDurum.Text = _yatirimProgrami.YatirimDurumu.ToString();
                lblIlce.Text = _yatirimProgrami.Ilce;
                txtKoyler.Text = _yatirimProgrami.Koy;
                lblBirim.Text = _yatirimProgrami.Birim;
                lblImalat.Text = _yatirimProgrami.Imalat;
                txtMiktar.Text = _yatirimProgrami.Miktar;
            }
        }

        private void YatirimProgramiDuzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            DialogResult result = new();

            if (txtMiktar.Text != _yatirimProgrami.Miktar || txtKoyler.Text != _yatirimProgrami.Koy)
            {
                try
                {
                    if (txtMiktar.Text != _yatirimProgrami.Miktar)
                    {
                        var buttons = MessageBoxButtons.YesNo;

                        result = MessageBox.Show("Miktar : " + _yatirimProgrami.Miktar + " ile " + txtMiktar.Text + "\n" +
                                                "\nDeğiştirmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Information);

                    }

                    else if (txtKoyler.Text != _yatirimProgrami.Koy)
                    {
                        var buttons = MessageBoxButtons.YesNo;

                        result = MessageBox.Show("Köy : " + _yatirimProgrami.Koy + " ile " + txtKoyler.Text + "\n" +
                                                "\nDeğiştirmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Information);

                    }

                    if (result == DialogResult.Yes)
                    {
                        _yatirimProgrami.Miktar = txtMiktar.Text;
                        _yatirimProgrami.Koy = txtKoyler.Text;
                        _dbContext.Update(_yatirimProgrami);
                        _dbContext.SaveChanges();

                        this.Close();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Bir şeyler ters gitti. Lütfen tekrar deneyin.", "Hata");
                }
            }

            txtMiktar.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
