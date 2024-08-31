using WinFormsApp1.Data;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;
using YatirimTakip.Helpers;

namespace WinFormsApp1
{
    internal record FaaliyetRaporKoy(string koyMezra, string program, string imalat,DateTime? tarih,double miktarUygulama, double harcama);
    public partial class FaaliyetRaporuKoy : Form
    {
        private AppDbContext _dbContext;
        public FaaliyetRaporuKoy()
        {
            InitializeComponent();
        }

        private void FaaliyetRaporuKoy_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Ilces.Load();
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (cmbYil.Text != string.Empty)
            {
                var yil = Convert.ToInt32(cmbYil.Text);
                var ilce = (Ilce)cmbIlce.SelectedValue!;

                var purEmanets = _dbContext.PurEmanets
                    .Include(p => p.Koy)
                    .Include(p => p.Imalat)
                    .Where(p => p.Tarih.Year == yil
                && p.Ilce.Adi == ilce.Adi).ToList();

                var projeler = _dbContext.Projes
                    .Include(p => p.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi))
                    .ToList();


                List<FaaliyetRaporKoy> _toplamUygulamaList = [];

                foreach (var item in projeler)
                {
                    var list = item.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi).Select(s => new FaaliyetRaporKoy
                     (
                        s.Koy,
                         s.Kaynak,
                         s.Imalat,
                         item.KesinKabulTarihi is null ? new DateTime(1970,01,01) : item.KesinKabulTarihi.Value.Date,
                         s.Uygulama,
                        (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                        + AsfaltDokumBedel(s.ID)
                     )).ToList();

                    _toplamUygulamaList.AddRange(list);
                }

                if (purEmanets is not null)
                {
                    var purEmanetGrouped = purEmanets.Select(s => new FaaliyetRaporKoy
                    (
                        s.Koy.Adi,
                        "Püremanet",
                        s.Imalat.Isim,
                        s.Tarih.Date,
                        s.Miktar,
                        s.Tutar
                    )).ToList();

                    _toplamUygulamaList = _toplamUygulamaList.Concat(purEmanetGrouped).OrderBy(u => u.koyMezra).ToList();
                }

                dataGridView1.DataSource = _toplamUygulamaList;
            }

            cmbYil.Focus();
        }
        private double AsfaltDokumBedel(int id)
        {
            var asfaltBedel = _dbContext.AsfaltDokums.Where(a => a.YatirimProgrami.ID == id)
                .Select(a => a.DokumBedeli).FirstOrDefault();

            return asfaltBedel;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PDFCreator pDF = new();
            var ilce = (Ilce)cmbIlce.SelectedValue!;
            pDF.CreatePdf(dataGridView1,ilce.Adi + " Köyler Faaliyet Raporu " + cmbYil.Text);
        }

        private void FaaliyetRaporuKoy_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
