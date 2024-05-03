using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class AsfaltUygulamaGuncelle : Form
    {
        private AppDbContext _dbContext;
        private readonly string _asfalt;
        private readonly int _selected;
        public AsfaltUygulamaGuncelle(string asfalt, int selected)
        {
            InitializeComponent();
            _asfalt = asfalt;
            _selected = selected;
        }

        private void AsfaltUygulamaGuncelle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();

            var program = _dbContext.YatirimProgramis.Where(y => y.ID == _selected).FirstOrDefault();
            var asfaltUygulama = _dbContext.AsfaltUygulamaVeris.Where(a => a.YatirimProgrami == program).FirstOrDefault();

            if (program is not null)
            {
                label2.Text = program.Imalat + " - " + program.Ilce + " - " + program.Koy +
                    " - " + program.Kaynak;
                txtUygulama.Text = program.Uygulama.ToString();

                if (asfaltUygulama is not null)
                {
                    dtpBaslangicTarihi.Value = asfaltUygulama.BaslangicTarihi.Date;
                    dtpBitisTarihi.Value = asfaltUygulama.BitisTarihi.Date;
                    txtSure.Text = asfaltUygulama.Sure.ToString();
                }
            }
        }

        private void AsfaltUygulamaGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var selected = _dbContext.YatirimProgramis.Where(s => s.ID == _selected).FirstOrDefault();

            if (selected != null && !string.IsNullOrEmpty(txtUygulama.Text))
            {
                selected.Uygulama = Convert.ToDouble(txtUygulama.Text);

                try
                {
                    if (_dbContext.AsfaltUygulamaVeris.Where(a => a.YatirimProgrami == selected).Any())
                    {
                        var asfaltUygulamaVeri = _dbContext.AsfaltUygulamaVeris.Where(a => a.YatirimProgrami == selected).FirstOrDefault();

                        asfaltUygulamaVeri!.Sure = Convert.ToInt32(txtSure.Text);
                        asfaltUygulamaVeri!.BaslangicTarihi = dtpBaslangicTarihi.Value.Date;
                        asfaltUygulamaVeri!.BitisTarihi = dtpBitisTarihi.Value.Date;

                        _dbContext.Update(asfaltUygulamaVeri);
                    }

                    else
                    {
                        _dbContext.AsfaltUygulamaVeris.Add(new AsfaltUygulamaVeri
                        {
                            BaslangicTarihi = dtpBaslangicTarihi.Value.Date,
                            BitisTarihi = dtpBitisTarihi.Value.Date,
                            Sure = Convert.ToInt32(txtSure.Text),
                            YatirimProgrami = selected,
                        });
                    }

                    _dbContext.Update(selected);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

            txtUygulama.Focus();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpBitisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSure_TextChanged(object sender, EventArgs e)
        {
            if (txtSure.Text == string.Empty)
            {
                txtSure.Text = "0";
            }

            dtpBitisTarihi.Value = dtpBaslangicTarihi.Value.AddDays(Convert.ToDouble(txtSure.Text));
        }
    }
}
