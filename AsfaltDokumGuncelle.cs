using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class AsfaltDokumGuncelle : Form
    {
        private AppDbContext _dbContext;
        private readonly int _selected;
        public AsfaltDokumGuncelle(int selected)
        {
            InitializeComponent();
            _selected = selected;
        }
        private void AsfaltDokumGuncelle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();

            var program = _dbContext.YatirimProgramis.Where(y => y.ID == _selected).FirstOrDefault();
            var asfaltDokum = _dbContext.AsfaltDokums.Where(a => a.YatirimProgrami == program).FirstOrDefault();

            if (program is not null)
            {
                label2.Text = program.Imalat + " - " + program.Ilce + " - " + program.Koy +
                    " - " + program.Kaynak + " - Uygulama Miktar: " + program.Uygulama.ToString();

                txtAstarMiktari.Focus();

                if (asfaltDokum is not null)
                {
                    txtAstarMiktari.Text = asfaltDokum.AstarMiktari.ToString();
                    txtYamaMiktari.Text = asfaltDokum.YamaMiktari.ToString();
                    txtAsfaltMiktari.Text = asfaltDokum.AsfaltMiktari.ToString();
                    txtDokumMesafesi.Text = asfaltDokum.DokumMesafesi.ToString();
                    dtpDokumTarihi.Value = asfaltDokum.DokumTarihi.Date;
                    txtDokumBedeli.Text = asfaltDokum.DokumBedeli.ToString();
                    txtBskMiktari.Text = asfaltDokum.BSKMiktari.ToString();
                }
            }

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                var selected = _dbContext.YatirimProgramis.Where(s => s.ID == _selected).FirstOrDefault();

                if (selected != null)
                {
                    try
                    {
                        if (_dbContext.AsfaltDokums.Where(a => a.YatirimProgrami == selected).Any())
                        {
                            var asfaltDokum = _dbContext.AsfaltDokums.Where(a => a.YatirimProgrami == selected).FirstOrDefault();

                            asfaltDokum!.AstarMiktari = Convert.ToDouble(txtAstarMiktari.Text);
                            asfaltDokum!.YamaMiktari = Convert.ToDouble(txtYamaMiktari.Text);
                            asfaltDokum!.AsfaltMiktari = Convert.ToDouble(txtAsfaltMiktari.Text);
                            asfaltDokum!.DokumMesafesi = Convert.ToDouble(txtAstarMiktari.Text);
                            asfaltDokum!.DokumTarihi = dtpDokumTarihi.Value.Date;
                            asfaltDokum!.DokumBedeli = Convert.ToDouble(txtDokumBedeli.Text);
                            asfaltDokum!.BSKMiktari = Convert.ToDouble(txtBskMiktari.Text);

                            _dbContext.Update(asfaltDokum);
                        }

                        else
                        {
                            _dbContext.AsfaltDokums.Add(new AsfaltDokum
                            {
                                AstarMiktari = Convert.ToDouble(txtAstarMiktari.Text),
                                YamaMiktari = Convert.ToDouble(txtYamaMiktari.Text),
                                AsfaltMiktari = Convert.ToDouble(txtAsfaltMiktari.Text),
                                DokumMesafesi = Convert.ToDouble(txtAstarMiktari.Text),
                                DokumTarihi = dtpDokumTarihi.Value.Date,
                                DokumBedeli = Convert.ToDouble(txtDokumBedeli.Text),
                                BSKMiktari = Convert.ToDouble(txtBskMiktari.Text),
                                YatirimProgrami = selected,
                            });
                        }

                        _dbContext.Update(selected);
                        _dbContext.SaveChanges();
                    }
                    catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                    this.Close();
                }
            }

            txtAstarMiktari.Focus();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsModelValid()
        {
            if (txtAstarMiktari.Text != string.Empty && txtYamaMiktari.Text != string.Empty
                && txtAsfaltMiktari.Text != string.Empty && txtDokumMesafesi.Text != string.Empty
                && txtDokumBedeli.Text != string.Empty && txtBskMiktari.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void AsfaltDokumGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
