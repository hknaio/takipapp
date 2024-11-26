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
            List<FaaliyetRaporKoy> _toplamUygulamaList = [];

            if (cmbYil.Text != string.Empty)
            {
                if (cmbKaynak.Text != string.Empty)
                {
                    dataGridView1.DataSource = new List<FaaliyetRaporKoy>();

                    var yil = Convert.ToInt32(cmbYil.Text);
                    var ilce = (Ilce)cmbIlce.SelectedValue!;
                    var koy = cmbKoy.Text;

                    List<PurEmanet> purEmanets = new();
                    List<Proje> projeler = new();

                    if (cmbKoy.Text == "Hepsi")
                    {
                        if (cmbKaynak.Text == "Hepsi")
                        {
                            purEmanets = _dbContext.PurEmanets
                      .Include(p => p.Koy)
                      .Include(p => p.Imalat)
                      .Where(p => p.Tarih.Year == yil
                  && p.Ilce.Adi == ilce.Adi).ToList();

                            projeler = _dbContext.Projes
                            .Include(p => p.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi))
                            .ToList();

                            foreach (var item in projeler)
                            {
                                var list = item.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi
                                                                  )
                                    .Select(s => new FaaliyetRaporKoy
                                 (
                                    s.Koy,
                                     s.Kaynak,
                                     s.Imalat,
                                     item.KesinKabulTarihi is null ? new DateTime(1970, 01, 01) : item.KesinKabulTarihi.Value.Date,
                                     s.Uygulama,
double.IsNaN((s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    + AsfaltDokumBedel(s.ID)) ? 0 : (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    + AsfaltDokumBedel(s.ID)
                                 )).ToList();

                                _toplamUygulamaList.AddRange(list);
                            }
                        }

                        else
                        {
                            projeler = _dbContext.Projes.AsNoTracking()
                            .Include(p => p.Programis.Where(p => p.Kaynak == cmbKaynak.Text
                                                              && p.Yil == yil && p.Ilce == ilce.Adi
                                                              ))
                            .ToList();

                            foreach (var item in projeler)
                            {
                                var list = item.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi
                                                                  && p.Kaynak == cmbKaynak.Text)
                                    .Select(s => new FaaliyetRaporKoy
                                 (
                                    s.Koy,
                                     s.Kaynak,
                                     s.Imalat,
                                     item.KesinKabulTarihi is null ? new DateTime(1970, 01, 01) : item.KesinKabulTarihi.Value.Date,
                                     s.Uygulama,
double.IsNaN((s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    + AsfaltDokumBedel(s.ID)) ? 0 :
                                    (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    + AsfaltDokumBedel(s.ID)
                                 )).ToList();

                                _toplamUygulamaList.AddRange(list);
                            }
                        }
                    }

                    else
                    {                        
                        if (cmbKaynak.Text == "Hepsi")
                        {
                            purEmanets = _dbContext.PurEmanets
                       .Include(p => p.Koy)
                       .Include(p => p.Imalat)
                       .Where(p => p.Tarih.Year == yil
                   && p.Ilce.Adi == ilce.Adi && p.Koy.Adi == cmbKoy.Text).ToList();


                            projeler = _dbContext.Projes
                            .Include(p => p.Programis.Where(p => p.Yil == yil
                                                              && p.Koy.Contains(koy)
                                                              && p.Ilce == ilce.Adi
                                                              ))
                            .ToList();

                            foreach (var item in projeler)
                            {
                                var list = item.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi
                                                                  && p.Koy.Contains(koy))
                                    .Select(s => new FaaliyetRaporKoy
                                 (
                                    s.Koy,
                                     s.Kaynak,
                                     s.Imalat,
                                     item.KesinKabulTarihi is null ? new DateTime(1970, 01, 01) : item.KesinKabulTarihi.Value.Date,
                                     s.Uygulama,
double.IsNaN((s.Uygulama / item.Programis.Where(p => p.Koy == koy).Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    + AsfaltDokumBedel(s.ID)) ? 0 : (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    + AsfaltDokumBedel(s.ID)
                                 )).ToList();

                                _toplamUygulamaList.AddRange(list);
                            }
                        }

                        else
                        {
                            projeler = _dbContext.Projes.AsNoTracking()
                            .Include(p => p.Programis.Where(p => p.Kaynak == cmbKaynak.Text
                                                              && p.Yil == yil
                                                              && p.Koy.Contains(koy)
                                                              && p.Ilce == ilce.Adi
                                                              ))
                            .ToList();

                            foreach (var item in projeler)
                            {
                                var list = item.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi
                                                                  && p.Koy.Contains(koy))
                                    .Select(s => new FaaliyetRaporKoy
                                 (
                                    s.Koy,
                                     s.Kaynak,
                                     s.Imalat,
                                     item.KesinKabulTarihi is null ? new DateTime(1970, 01, 01) : item.KesinKabulTarihi.Value.Date,
                                     s.Uygulama,
double.IsNaN((s.Uygulama / item.Programis.Where(p => p.Koy == koy).Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    + AsfaltDokumBedel(s.ID)) ? 0 :
                                    (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    + AsfaltDokumBedel(s.ID)
                                 )).ToList();

                                _toplamUygulamaList.AddRange(list);
                            }
                        }
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

                    if (koy != "Hepsi")
                    {
                        if (cmbKaynak.Text == "Hepsi")
                        {
                            var onarimVeBsk = _dbContext.AsfaltDokums.Include(p => p.YatirimProgrami).Where(
                       p => p.DokumBedeli != 0 && (p.YatirimProgrami.Imalat.Contains("BSK") || p.YatirimProgrami.Imalat.Contains("Asfalt Bakım Onarım"))
                            && p.YatirimProgrami.Ilce == ilce.Adi && p.YatirimProgrami.Yil == yil
                            && p.YatirimProgrami.Koy == koy)
                       .Select(p => new FaaliyetRaporKoy
                       (
                           p.YatirimProgrami.Koy,
                           p.YatirimProgrami.Kaynak,
                           p.YatirimProgrami.Imalat,
                           p.DokumTarihi,
                           p.BSKMiktari,
                           p.DokumBedeli
                       )).ToList();

                            _toplamUygulamaList = _toplamUygulamaList.Concat(onarimVeBsk).OrderBy(u => u.koyMezra)
                                .ThenBy(u => u.imalat).ToList();
                        }

                        else
                        {
                            var onarimVeBsk = _dbContext.AsfaltDokums.Include(p => p.YatirimProgrami).Where(
                       p => p.DokumBedeli != 0 && (p.YatirimProgrami.Imalat.Contains("BSK") || p.YatirimProgrami.Imalat.Contains("Asfalt Bakım Onarım"))
                            && p.YatirimProgrami.Ilce == ilce.Adi && p.YatirimProgrami.Yil == yil
                            && p.YatirimProgrami.Koy == koy
                            && p.YatirimProgrami.Kaynak == cmbKaynak.Text)
                       .Select(p => new FaaliyetRaporKoy
                       (
                           p.YatirimProgrami.Koy,
                           p.YatirimProgrami.Kaynak,
                           p.YatirimProgrami.Imalat,
                           p.DokumTarihi,
                           p.BSKMiktari,
                           p.DokumBedeli
                       )).ToList();

                            _toplamUygulamaList = _toplamUygulamaList.Concat(onarimVeBsk).OrderBy(u => u.koyMezra)
                                .ThenBy(u => u.imalat).ToList();
                        }
                    }

                    else
                    {
                        if (cmbKaynak.Text == "Hepsi")
                        {

                            var onarimVeBsk = _dbContext.AsfaltDokums.Include(p => p.YatirimProgrami).Where(
                            p => p.DokumBedeli != 0 && (p.YatirimProgrami.Imalat.Contains("BSK") || p.YatirimProgrami.Imalat.Contains("Asfalt Bakım Onarım"))
                                 && p.YatirimProgrami.Ilce == ilce.Adi && p.YatirimProgrami.Yil == yil
                                )
                            .Select(p => new FaaliyetRaporKoy
                            (
                                p.YatirimProgrami.Koy,
                                p.YatirimProgrami.Kaynak,
                                p.YatirimProgrami.Imalat,
                                p.DokumTarihi,
                                p.BSKMiktari,
                                p.DokumBedeli
                            )).ToList();

                            _toplamUygulamaList = _toplamUygulamaList.Concat(onarimVeBsk).OrderBy(u => u.koyMezra)
                                .ThenBy(u => u.imalat).ToList();
                        }

                        else
                        {

                            var onarimVeBsk = _dbContext.AsfaltDokums.Include(p => p.YatirimProgrami).Where(
                            p => p.DokumBedeli != 0 && (p.YatirimProgrami.Imalat.Contains("BSK") || p.YatirimProgrami.Imalat.Contains("Asfalt Bakım Onarım"))
                                 && p.YatirimProgrami.Ilce == ilce.Adi && p.YatirimProgrami.Yil == yil
                                 && p.YatirimProgrami.Kaynak == cmbKaynak.Text
                                )
                            .Select(p => new FaaliyetRaporKoy
                            (
                                p.YatirimProgrami.Koy,
                                p.YatirimProgrami.Kaynak,
                                p.YatirimProgrami.Imalat,
                                p.DokumTarihi,
                                p.BSKMiktari,
                                p.DokumBedeli
                            )).ToList();

                            _toplamUygulamaList = _toplamUygulamaList.Concat(onarimVeBsk).OrderBy(u => u.koyMezra)
                                .ThenBy(u => u.imalat).ToList();
                        }
                    }

                    dataGridView1.DataSource = _toplamUygulamaList;
                }

                cmbKaynak.Focus();               
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
            pDF.CreatePdf(dataGridView1, ilce.Adi + " Köyler Faaliyet Raporu " + cmbYil.Text);
        }

        private void FaaliyetRaporuKoy_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
