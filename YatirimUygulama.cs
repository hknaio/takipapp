using System.Data;
using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class YatirimUygulama : Form
    {
        private readonly int _id;
        private AppDbContext _dbContext;
        public YatirimUygulama(int id)
        {
            InitializeComponent();
            _id = id;
        }
        private void YatirimUygulama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            var proje = _dbContext.Projes
                  .Include(p => p.Programis)
                  .Include(p => p.Hakedis)                   
                  .Where(p => p.ID == _id).FirstOrDefault();
            cmbDurum.DataSource = Enum.GetValues(typeof(ProjeDurumu));

            if (proje is not null)
            {
                label2.Text = proje.Adi;
                txtSure.Text = proje.Sure.ToString();
                txtYuklenici.Text = proje.Yuklenici;
                cmbDurum.SelectedItem = proje.ProjeDurumu;
                txtSozlesmeBedeli.Text = proje.SozlesmeBedeli.ToString("0.00");
                txtAciklama.Text = proje.Aciklama;
                label13.Text = proje.YaklasikMaliyet.ToString();
                lblToplamHakedis.Text = proje.HakedisToplami.ToString();
                lblHakedisTahakkuk.Text = proje.HakedisToplamTahakkuk.ToString();
                dataGridView1.DataSource = proje.Programis?.ToList();
                dataGridView2.DataSource = proje.Hakedis?.ToList();

                formatDtps(proje);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void formatDtps(Proje proje)
        {
            if (proje.IseBaslamaTarihi is null)
            {
                dtpIseBaslama.CustomFormat = "          ";
                dtpIseBaslama.Format = DateTimePickerFormat.Custom;
            }

            else
            {
                dtpIseBaslama.Value = proje.IseBaslamaTarihi.Value;
                dtpKesinKabul.Value = proje.KesinKabulTarihi.Value;
            }

            if (proje.IsBitisTarihi is null)
            {
                dtpBitisTarihi.CustomFormat = "          ";
                dtpBitisTarihi.Format = DateTimePickerFormat.Custom;
            }

            else
            {
                dtpBitisTarihi.Value = proje.IsBitisTarihi.Value;
            }

            if (proje.GeciciKabulTarihi is null)
            {
                dtpGeciciKabul.CustomFormat = "          ";
                dtpGeciciKabul.Format = DateTimePickerFormat.Custom;
            }

            else
            {
                dtpGeciciKabul.Value = proje.GeciciKabulTarihi.Value;
            }

            if (proje.KesinKabulTarihi is null)
            {
                dtpKesinKabul.CustomFormat = "          ";
                dtpKesinKabul.Format = DateTimePickerFormat.Custom;
            }

            else
            {
                dtpKesinKabul.Value = proje.KesinKabulTarihi.Value;
            }
        }
        private void dtpIseBaslama_ValueChanged(object sender, EventArgs e)
        {
            dtpIseBaslama.CustomFormat = "dd MMMM yyyy dddd";
        }

        private void txtSure_TextChanged(object sender, EventArgs e)
        {
            if (dtpIseBaslama.Value.Date.Year > 1970)
            {
                dtpIseBaslama.CustomFormat = "dd MMMM yyyy dddd";
                dtpBitisTarihi.Value = dtpIseBaslama.Value.AddDays(Convert.ToDouble(txtSure.Text));
                dtpBitisTarihi.CustomFormat = "dd MMMM yyyy dddd";
            }

            else
            {
                dtpIseBaslama.Focus();
            }

        }

        private void dtpGeciciKabul_ValueChanged(object sender, EventArgs e)
        {
            dtpGeciciKabul.CustomFormat = "dd MMMM yyyy dddd";
        }

        private void dtpKesinKabul_ValueChanged(object sender, EventArgs e)
        {
            dtpKesinKabul.CustomFormat = "dd MMMM yyyy dddd";
        }

        private void YatirimUygulama_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void txtSozlesmeBedeli_Leave(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(txtSozlesmeBedeli.Text, out value))
                txtSozlesmeBedeli.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                txtSozlesmeBedeli.Text = string.Empty;
        }


    }
}
