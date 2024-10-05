using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Data;
using YatirimTakip.Helpers;

namespace WinFormsApp1
{
    internal record ToplamUygulama(int programId,string ilce, string imalat, double tahakkkuk, double toplamUygulama, double uygulama, double oransalTahakkuk);
    internal record IlceButce(string ilce, double kat1, double kat2, double bsk, double kilitliParke, double stabilize, double onarim, double sanat);
    public partial class RprButce : Form
    {
        private AppDbContext _dbContext;
        public RprButce()
        {
            InitializeComponent();
        }

        private void RprButce_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            for (int i = 1; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].DefaultCellStyle.Format = "N2";
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var yil = Convert.ToInt32(cmbYil.Text);

            var projeler = _dbContext.Projes
                .Include(p => p.Programis.Where(p => p.Yil == yil))
                .ToList();

            var purEmanets = _dbContext.PurEmanets
                .Include(p => p.Imalat)
                .Include(p => p.Ilce).Where(p => p.Tarih.Year == yil).ToList();

            List<ToplamUygulama> _toplamUygulamaList = [];

            foreach (var item in projeler)
            {
                var list = item.Programis.Select(s => new ToplamUygulama
                 (
                    s.ID,
                     s.Ilce,
                     s.Imalat,
                     item.HakedisToplamTahakkuk,
                     item.Programis.Sum(p => p.Uygulama),
                     s.Uygulama,
                    (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                    + AsfaltDokumBedel(s.ID)
                 )).ToList();

                _toplamUygulamaList.AddRange(list);

            }

            var toplamUygulamaGrouped = _toplamUygulamaList.GroupBy(t => t.ilce).Select(t => new IlceButce
                 (
                    t.Key,
                    t.Where(t => t.imalat.Contains("1.")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("2.")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("BSK")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Kilit")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Stabilize")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Onarım")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Köprü") || t.imalat.Contains("İstinat") ||
                    t.imalat.Contains("Menfez")).Sum(t => t.oransalTahakkuk)
                 )).ToList();

            var puremanetsGrouped = purEmanets.GroupBy(p => p.Ilce).Select(t => new IlceButce
              (
                   t.Key.Adi,
                   t.Where(t => t.Imalat.Isim.Contains("1.")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("2.")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("BSK")).Sum(t => t.Tutar),                   
                   t.Where(t => t.Imalat.Isim.Contains("Kilit")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Stabilize")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Yol Ona") || t.Imalat.Isim.Contains("Onarım")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Köprü") || t.Imalat.Isim.Contains("Menfez")).Sum(t => t.Tutar)
               ));

            toplamUygulamaGrouped = toplamUygulamaGrouped.Concat(puremanetsGrouped).ToList();

            var finalList = toplamUygulamaGrouped.GroupBy(f => f.ilce).Select(s => new IlceButce
            (
                 s.Key,
                s.Sum(i => i.kat1),
                s.Sum(i => i.kat2),
                s.Sum(i => i.bsk),
                s.Sum(i => i.kilitliParke),
                s.Sum(i => i.stabilize),
                s.Sum(i => i.onarim),
                s.Sum(i => i.sanat)
             )).ToList();

            dataGridView1.DataSource = finalList;
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

            pDF.CreatePdf(dataGridView1, "Bütçe " + cmbYil.Text);
        }

        private void RprButce_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
