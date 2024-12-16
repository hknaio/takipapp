using Microsoft.EntityFrameworkCore;
using System.Linq;
using WinFormsApp1.Data;
using YatirimTakip.Helpers;

namespace WinFormsApp1
{
    internal record ToplamUygulama(int programId,string ilce, string imalat, double tahakkkuk, double toplamUygulama, double uygulama, double oransalTahakkuk);
    internal record IlceButce(string ilce, double kat1, double kat2, double bsk, double asfaltOnarim, double kilitliParke, double stabilize,
        double yolOnarim, double menfez, double istinat, double kopru, double reglaj, double kar, double beton, double yeniYol,
         double spiral, double icme, double tarim, double kaya, double diger);
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
                    double.IsNaN((s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)) ? 0 :
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
                    t.Where(t => t.imalat.Contains("Asfalt Bakım Onarım")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Kilitli Parke")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Stabilize")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Yol Onarım")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Menfez")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Istinat Duvarı")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Köprü")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Reglaj")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Karla Mücadele")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Beton Yol")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Yeni Yol")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Spiral Boru")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("İçme Suyu, Kanalizasyon Hattı Yapım-Onarım Kazı Çalışması")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Tarımsal Sulama Hattı Yapım-Onarım Kazı Çalışması")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Kaya Tahkimat")).Sum(t => t.oransalTahakkuk),
                    t.Where(t => t.imalat.Contains("Çevre Düzenleme İşleri")).Sum(t => t.oransalTahakkuk)
                 )).ToList();

            var puremanetsGrouped = purEmanets.GroupBy(p => p.Ilce).Select(t => new IlceButce
              (
                   t.Key.Adi,
                   t.Where(t => t.Imalat.Isim.Contains("1.")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("2.")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("BSK")).Sum(t => t.Tutar),                   
                   t.Where(t => t.Imalat.Isim.Contains("Asfalt Bakım Onarım")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Kilitli Parke")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Stabilize")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Yol Onarım")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Menfez")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Istinat Duvarı")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Köprü")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Reglaj")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Karla Mücadele")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Beton Yol")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Yeni Yol")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Spiral Boru")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("İçme Suyu, Kanalizasyon Hattı Yapım-Onarım Kazı Çalışması")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Tarımsal Sulama Hattı Yapım-Onarım Kazı Çalışması")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Kaya Tahkimat")).Sum(t => t.Tutar),
                   t.Where(t => t.Imalat.Isim.Contains("Çevre Düzenleme İşleri")).Sum(t => t.Tutar)
               ));

            toplamUygulamaGrouped = toplamUygulamaGrouped.Concat(puremanetsGrouped).ToList();

            var onarimVeBsk = _dbContext.AsfaltDokums.Include(p => p.YatirimProgrami).Where(
                      p => p.DokumBedeli != 0 && p.DokumTarihi.Year == yil && (p.YatirimProgrami.Imalat.Contains("BSK") || p.YatirimProgrami.Imalat.Contains("Asfalt Bakım Onarım")
                                                   || p.YatirimProgrami.Imalat.Contains("1.") || p.YatirimProgrami.Imalat.Contains("2.")))
                      .GroupBy(p => new { ilce = p.YatirimProgrami.Ilce })
                      .Select(t => new IlceButce
                      (
                          t.Key.ilce,
                    t.Where(t => t.YatirimProgrami.Imalat.Contains("1.")).Sum(t => t.DokumBedeli),
                    t.Where(t => t.YatirimProgrami.Imalat.Contains("2.")).Sum(t => t.DokumBedeli),
                    t.Where(t => t.YatirimProgrami.Imalat.Contains("BSK")).Sum(t => t.DokumBedeli),
                    t.Where(t => t.YatirimProgrami.Imalat.Contains("Asfalt Bakım Onarım")).Sum(t => t.DokumBedeli),
                    0,
                    0,
                    0,
                    0,
                    0,
                    0,
                    0,

                    0,
                    0,
                   
                    0,
                    0,

                    0,
                    0,
                    0,
                    0
                      )).ToList();

            toplamUygulamaGrouped = toplamUygulamaGrouped.Concat(onarimVeBsk).ToList();

            var finalList = toplamUygulamaGrouped.GroupBy(f => f.ilce).Select(s => new IlceButce
            (
                s.Key,
                double.IsNaN(s.Sum(i => i.kat1)) ? 0 : s.Sum(i => i.kat1),
                double.IsNaN(s.Sum(i => i.kat2)) ? 0 : s.Sum(i => i.kat2),
                double.IsNaN(s.Sum(i => i.bsk)) ? 0 : s.Sum(i => i.bsk),
                double.IsNaN(s.Sum(i => i.asfaltOnarim)) ? 0 : s.Sum(i => i.asfaltOnarim),
                double.IsNaN(s.Sum(i => i.kilitliParke)) ? 0 : s.Sum(i => i.kilitliParke),
                double.IsNaN(s.Sum(i => i.stabilize)) ? 0 : s.Sum(i => i.stabilize),
                double.IsNaN(s.Sum(i => i.yolOnarim)) ? 0 : s.Sum(i => i.yolOnarim),
                double.IsNaN(s.Sum(i => i.menfez)) ? 0 : s.Sum(i => i.menfez),
                double.IsNaN(s.Sum(i => i.istinat)) ? 0 : s.Sum(i => i.istinat),
                double.IsNaN(s.Sum(i => i.kopru)) ? 0 : s.Sum(i => i.kopru),
                double.IsNaN(s.Sum(i => i.reglaj)) ? 0 : s.Sum(i => i.reglaj),
                double.IsNaN(s.Sum(i => i.kar)) ? 0 : s.Sum(i => i.kar),
                double.IsNaN(s.Sum(i => i.beton)) ? 0 : s.Sum(i => i.beton),
                double.IsNaN(s.Sum(i => i.yeniYol)) ? 0 : s.Sum(i => i.yeniYol),
                double.IsNaN(s.Sum(i => i.spiral)) ? 0 : s.Sum(i => i.spiral),
                double.IsNaN(s.Sum(i => i.icme)) ? 0 : s.Sum(i => i.icme),
                double.IsNaN(s.Sum(i => i.tarim)) ? 0 : s.Sum(i => i.tarim),
                double.IsNaN(s.Sum(i => i.kaya)) ? 0 : s.Sum(i => i.kaya),
                double.IsNaN(s.Sum(i => i.diger)) ? 0 : s.Sum(i => i.diger)
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
