using Microsoft.EntityFrameworkCore;
using WinFormsApp1;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using YatirimTakip.Helpers;

namespace YatirimTakip
{
    public partial class PuremanetRapor : Form
    {
        internal record Puremanetrpr(string koyMezra, string imalat, DateTime? tarih, double miktarUygulama, double harcama);

        private AppDbContext _dbContext;
        public PuremanetRapor()
        {
            InitializeComponent();
        }

        private void PuremanetRapor_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Ilces.Load();
            _dbContext.Imalats.Load();

            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();

            List<Imalat> imalatsDb = new List<Imalat> { new Imalat { Isim = "Hepsi" } };

            var imalats = _dbContext.Imalats.ToList();
            List<Imalat> imalatList = [.. imalatsDb, .. imalats];

            cmbImalat.DataSource = imalatList;
            cmbImalat.DisplayMember = "Isim"; cmbImalat.Invalidate();
        }

        private void PuremanetRapor_Leave(object sender, EventArgs e)
        {

        }

        private void PuremanetRapor_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbIlce.Text;
            List<Koy> koyList = [new Koy { Adi = "Hepsi" }];

            var koyListDB = _dbContext!.Koys.Where(k => k.Ilce.Adi == selectedItem).ToList();

            koyList = [.. koyList, .. koyListDB];

            if (koyList != null)
            {
                cmbKoy.DataSource = koyList;
                cmbKoy.DisplayMember = "Adi"; cmbKoy.Invalidate();
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var yil = Convert.ToInt32(cmbYil.Text);
            var ilce = (Ilce)cmbIlce.SelectedValue!;
            var koy = cmbKoy.Text;

            if (cmbYil.Text != string.Empty)
            {
                if (cmbKoy.Text == "Hepsi")
                {
                    var purEmanets = _dbContext.PurEmanets
                       .Include(p => p.Koy)
                       .Include(p => p.Imalat)
                       .Where(p => p.Tarih.Year == yil
                   && p.Ilce.Adi == ilce.Adi
                   && (cmbImalat.Text == "Hepsi" || p.Imalat.Isim == cmbImalat.Text) ).ToList();

                    var purEmanetGrouped = purEmanets.Select(s => new Puremanetrpr
                       (
                           s.Koy.Adi,
                           s.Imalat.Isim,
                           s.Tarih.Date,
                           s.Miktar,
                           s.Tutar
                       )).ToList();

                    dataGridView1.DataSource = purEmanetGrouped;
                }

                else {

                    var purEmanets = _dbContext.PurEmanets
                       .Include(p => p.Koy)
                       .Include(p => p.Imalat)
                       .Where(p => p.Tarih.Year == yil
                   && p.Ilce.Adi == ilce.Adi && p.Koy.Adi == cmbKoy.Text
                   && (cmbImalat.Text == "Hepsi" || p.Imalat.Isim == cmbImalat.Text)).ToList();

                    var purEmanetGrouped = purEmanets.Select(s => new Puremanetrpr
                       (
                           s.Koy.Adi,
                           s.Imalat.Isim,
                           s.Tarih.Date,
                           s.Miktar,
                           s.Tutar
                       )).ToList();

                    dataGridView1.DataSource = purEmanetGrouped;
                }
            }

            cmbYil.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDFCreator pDF = new();
            var ilce = (Ilce)cmbIlce.SelectedValue!;
            pDF.CreatePdf(dataGridView1, ilce.Adi + " Püremanet Raporu " + cmbYil.Text);
        }
    }
}
