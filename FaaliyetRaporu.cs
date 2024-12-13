using WinFormsApp1.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using YatirimTakip.Helpers;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    internal record FaaliyetRapor(string ilce, double isAdet,double kat1, double kat2, double bsk, double asfaltOnarim ,double kilitliParke, double stabilize,
        double yolOnarim ,double menfez, double istinat, double kopru, double reglaj, double kar,double beton, double yeniYol,
        double arac, double spiral, double icme, double tarim, double kaya, double diger, double miktar);

    public partial class FaaliyetRaporu : Form
    {
        private AppDbContext _dbContext;
        public FaaliyetRaporu()
        {
            InitializeComponent();
        }

        private void FaaliyetRaporu_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.AsfaltDokums.Load();

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
                     s.Imalat.Contains("1.") || s.Imalat.Contains("2.") ? 0 : s.Uygulama,
                    (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                    + AsfaltDokumBedel(s.ID)
                 )).ToList();

                _toplamUygulamaList.AddRange(list);
            }

            var puremanetsGrouped = purEmanets.GroupBy(p => p.Ilce).Select(t => new FaaliyetRapor
               (
                    t.Key.Adi,
                    t.Where(c => c.Ilce.Adi == t.Key.Adi).Count(),
                    t.Where(t => t.Imalat.Isim.Contains("1.")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("2.")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("BSK")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Asfalt Bakım Onarım")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Kilitli Parke")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Stabilize")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Yol Onarım")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Menfez")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Istinat Duvarı")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Köprü")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Reglaj")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Karla Mücadele")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Beton Yol")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Yeni Yol")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Araç Kiralama")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Spiral Boru")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("İçme Suyu, Kanalizasyon Hattı Yapım-Onarım Kazı Çalışması")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Tarımsal Sulama Hattı Yapım-Onarım Kazı Çalışması")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Kaya Tahkimat")).Sum(t => t.Miktar),
                    t.Where(t => t.Imalat.Isim.Contains("Çevre Düzenleme İşleri")).Sum(t => t.Miktar),
                    double.IsNaN(t.Sum(t => t.Tutar)) ? 0 :
                    t.Sum(t => t.Tutar)
                ));

            var toplamUygulamaGrouped = _toplamUygulamaList.GroupBy(t => t.ilce).Select(t => new FaaliyetRapor
                 (
                    t.Key,
                    t.Where(c => c.ilce == t.Key).Count(),
                    t.Where(t => t.imalat.Contains("1.")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("2.")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("BSK")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Asfalt Bakım Onarım")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Kilitli Parke")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Stabilize")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Yol Onarım")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Menfez")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Istinat Duvarı")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Köprü")).Sum(t => t.uygulama),
             
                    t.Where(t => t.imalat.Contains("Reglaj")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Karla Mücadele")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Beton Yol")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Yeni Yol")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Araç Kiralama")).Sum(t => t.uygulama),

                    t.Where(t => t.imalat.Contains("Spiral Boru")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("İçme Suyu, Kanalizasyon Hattı Yapım-Onarım Kazı Çalışması")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Tarımsal Sulama Hattı Yapım-Onarım Kazı Çalışması")).Sum(t => t.uygulama),
                    t.Where(t => t.imalat.Contains("Kaya Tahkimat")).Sum(t => t.uygulama),

                    t.Where(t => t.imalat.Contains("Çevre Düzenleme İşleri")).Sum(t => t.uygulama),
                    double.IsNaN(t.Sum(t => t.oransalTahakkuk)) ? 0 : 
                    t.Sum(t => t.oransalTahakkuk)
                 )).ToList();

            toplamUygulamaGrouped = toplamUygulamaGrouped.Concat(puremanetsGrouped).ToList();

            var onarimVeBsk = _dbContext.AsfaltDokums.Include(p => p.YatirimProgrami).Where(
                      p => p.DokumBedeli != 0 && (p.YatirimProgrami.Imalat.Contains("BSK") || p.YatirimProgrami.Imalat.Contains("Asfalt Bakım Onarım")
                                                   || p.YatirimProgrami.Imalat.Contains("1.") || p.YatirimProgrami.Imalat.Contains("2.")))
                      .GroupBy(p => new { ilce = p.YatirimProgrami.Ilce, imalat = p.YatirimProgrami.Imalat })                      
                      .Select(t => new FaaliyetRapor
                      (
                          t.Key.ilce,
                    t.Where(c => c.YatirimProgrami.Ilce == t.Key.ilce).Count(),
                    t.Where(t => t.YatirimProgrami.Imalat.Contains("1.")).Sum(t => t.DokumMesafesi),
                    t.Where(t => t.YatirimProgrami.Imalat.Contains("2.")).Sum(t => t.DokumMesafesi),
                    t.Where(t => t.YatirimProgrami.Imalat.Contains("BSK")).Sum(t => t.DokumMesafesi),
                    t.Where(t => t.YatirimProgrami.Imalat.Contains("Asfalt Bakım Onarım")).Sum(t => t.DokumMesafesi),
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
                    0,

                    0,
                    
                    t.Sum(t => t.DokumBedeli)
                      )).ToList();

            toplamUygulamaGrouped = toplamUygulamaGrouped.Concat(onarimVeBsk).ToList();

            var finalList = toplamUygulamaGrouped.GroupBy(f => f.ilce).Select(f => new FaaliyetRapor(
                f.Key,
                f.Sum(i => i.isAdet),
                f.Sum(i => i.kat1),
                f.Sum(i => i.kat2),
                f.Sum(i => i.bsk),
                f.Sum(i => i.asfaltOnarim),
                f.Sum(i => i.kilitliParke),
                f.Sum(i => i.stabilize),
                f.Sum(i => i.yolOnarim),
                f.Sum(i => i.menfez),
                f.Sum(i => i.istinat),
                f.Sum(i => i.kopru),
                f.Sum(i => i.reglaj),
                f.Sum(i => i.kar),
                f.Sum(i => i.beton),
                f.Sum(i => i.yeniYol),
                f.Sum(i => i.arac),
                f.Sum(i => i.spiral),
                f.Sum(i => i.icme),
                f.Sum(i => i.tarim),
                f.Sum(i => i.kaya),
                f.Sum(i => i.diger),
                f.Sum(i => i.miktar)
                )).ToList();

            var butunIl = finalList.GroupBy(f => 1).Select(f => new FaaliyetRapor(
                "Tümü",
                f.Sum(i => i.isAdet),
                f.Sum(i => i.kat1),
                f.Sum(i => i.kat2),
                f.Sum(i => i.bsk),
                f.Sum(i => i.asfaltOnarim),
                f.Sum(i => i.kilitliParke),
                f.Sum(i => i.stabilize),
                f.Sum(i => i.yolOnarim),
                f.Sum(i => i.menfez),
                f.Sum(i => i.istinat),
                f.Sum(i => i.kopru),
                f.Sum(i => i.reglaj),
                f.Sum(i => i.kar),
                f.Sum(i => i.beton),
                f.Sum(i => i.yeniYol),
                f.Sum(i => i.arac),
                f.Sum(i => i.spiral),
                f.Sum(i => i.icme),
                f.Sum(i => i.tarim),
                f.Sum(i => i.kaya),
                f.Sum(i => i.diger),
                f.Sum(i => i.miktar)
                )).ToList();

            finalList = finalList.Concat(butunIl).ToList();

            dataGridView1.DataSource = finalList;
        }
        private double AsfaltDokumBedel(int id)
        {
            var asfaltBedel = _dbContext.Database.SqlQuery<double>($"SELECT DokumBedeli as [VALUE] FROM AsfaltDokum WHERE YatirimProgramiID = {id}")
                           .FirstOrDefault();

            return asfaltBedel;
        }
        private double AsfaltDokumMesafe(int id)
        {
            var asfaltMesafe = _dbContext.AsfaltDokums.Where(a => a.YatirimProgrami.ID == id)
                .Select(a => a.DokumMesafesi).FirstOrDefault();

          
                return asfaltMesafe;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PDFCreator pDF = new();

            pDF.CreatePdfFaaliyet(dataGridView1, "Faaliyet Raporu " + cmbYil.Text);
        }

        private void FaaliyetRaporu_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }









        //private void DynamicImalat()
        //{
        //    var imalats = _dbContext.Imalats.Select(i => i.Isim).ToList();
        //    dataGridView1.ColumnCount = imalats.Count + 1;
        //    dataGridView1.Columns[0].Name = "Ilce"; dataGridView1.Columns[0].DataPropertyName = "Ilce";
        //    dynamic imalatResult = new ExpandoObject();

        //    for (int i = 0; i < imalats.Count; i++)
        //    {
        //        dataGridView1.Columns[i + 1].Name = imalats[i];
        //        dataGridView1.Columns[i + 1].DataPropertyName = imalats[i];

        //        AddProperty(imalatResult, imalats[i], 7.2);
        //    }

        //    foreach (var imalat in imalatResult)
        //    {
        //        var val = imalat;
        //    }

        //    var imalatMiktar = _dbContext.PurEmanets.Include(p => p.Imalat)
        //                                       .Include(p => p.Ilce).GroupBy(p => new { p.Imalat.Isim, p.Ilce.Adi })
        //                                       .Select(p => new
        //                                       {
        //                                           Imalat = p.Key.Isim,
        //                                           Ilce = p.Key.Adi,
        //                                           Miktar = p.Sum(p => p.Miktar)
        //                                       }).ToList();

        //    var programImalatMiktar = _dbContext.YatirimProgramis.GroupBy(y => new { y.Imalat, y.Ilce })
        //        .Select(p => new
        //        {
        //            Imalat = p.Key.Imalat,
        //            Ilce = p.Key.Ilce,
        //            Miktar = p.Sum(p => p.Uygulama)
        //        }).ToList();

        //    programImalatMiktar = programImalatMiktar.Concat(imalatMiktar).ToList();
        //}

        ////program miktarlar + püremanet miktarlar (asfalt döküm istinası)
        ////bütçedeki gibi ihale pay edilmiş maliyet
        ////köy için de aynı detaylar.
        ////datagridview.Datasource = list of property imalats 

        //public static void AddProperty(ExpandoObject expando, string propertyName, object propertyValue)
        //{
        //    // ExpandoObject supports IDictionary so we can extend it like this
        //    var expandoDict = expando as IDictionary<string, object>;
        //    if (expandoDict.ContainsKey(propertyName))
        //        expandoDict[propertyName] = propertyValue;
        //    else
        //        expandoDict.Add(propertyName, propertyValue);
        //}
    }
}
