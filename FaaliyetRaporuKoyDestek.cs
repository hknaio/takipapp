using WinFormsApp1.Data;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;
using YatirimTakip.Helpers;

namespace WinFormsApp1
{
    internal record FaaliyetRaporKoyDestek(string koyMezra, string program, string imalat,DateTime? tarih,double miktarUygulama, double harcama);
    public partial class FaaliyetRaporuKoyDestek : Form
    {
        private AppDbContext _dbContext;
        public FaaliyetRaporuKoyDestek()
        {
            InitializeComponent();
        }

        private void FaaliyetRaporuKoyDestek_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Ilces.Load();

            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();

            List<Imalat> imalatsDb = new List<Imalat> { new Imalat { Isim = "Hepsi" } };

            var imalats = _dbContext.Imalats.ToList();
            List<Imalat> imalatList = [.. imalatsDb, .. imalats];

            cmbImalat.DataSource = imalatList;
            cmbImalat.DisplayMember = "Isim"; cmbImalat.Invalidate();
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
                  && p.Ilce.Adi == ilce.Adi && p.Imalat.Mudurluk == "Destek Hizmetler"
                  && (cmbImalat.Text == "Hepsi" || p.Imalat.Isim == cmbImalat.Text)).ToList();

                            projeler = _dbContext.Projes
                            .Include(p => p.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi && p.Birim == "Destek Hizmetler") )
                            .ToList();

                            foreach (var item in projeler)
                            {
                                var list = item.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi
                                            && (cmbImalat.Text == "Hepsi" || p.Imalat == cmbImalat.Text))
                                    .Select(s => new FaaliyetRaporKoy
                                 (
                                    s.Koy,
                                     s.Kaynak,
                                     s.Imalat,
                                     item.KesinKabulTarihi is null ? new DateTime(1970, 01, 01) : item.KesinKabulTarihi.Value.Date,
                                     s.Uygulama,
double.IsNaN((s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    ) ? 0 : (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    
                                 )).ToList();

                                _toplamUygulamaList.AddRange(list);
                            }
                        }

                        else
                        {
                            projeler = _dbContext.Projes.AsNoTracking()
                            .Include(p => p.Programis.Where(p => p.Kaynak == cmbKaynak.Text
                                                              && p.Yil == yil && p.Ilce == ilce.Adi
                                                              && p.Birim == "Destek Hizmetler"
                                                              ))
                            .ToList();

                            foreach (var item in projeler)
                            {
                                var list = item.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi
                                                                  && p.Kaynak == cmbKaynak.Text
                                                                  && (cmbImalat.Text == "Hepsi" || p.Imalat == cmbImalat.Text))
                                    .Select(s => new FaaliyetRaporKoy
                                 (
                                    s.Koy,
                                     s.Kaynak,
                                     s.Imalat,
                                     item.KesinKabulTarihi is null ? new DateTime(1970, 01, 01) : item.KesinKabulTarihi.Value.Date,
                                     s.Uygulama,
double.IsNaN((s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    ) ? 0 :
                                    (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    
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
                   && p.Ilce.Adi == ilce.Adi && p.Koy.Adi == cmbKoy.Text && p.Imalat.Mudurluk == "Destek Hizmetler"
                   && (cmbImalat.Text == "Hepsi" || p.Imalat.Isim == cmbImalat.Text)).ToList();


                            projeler = _dbContext.Projes
                            .Include(p => p.Programis.Where(p => p.Yil == yil
                                                              && p.Ilce == ilce.Adi
                                                              && p.Birim == "Destek Hizmetler"
                                                              ))
                            .ToList();

                            foreach (var item in projeler)
                            {
                                var list = item.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi
                                                                  && p.Koy.Contains(koy)
                                                                  && (cmbImalat.Text == "Hepsi" || p.Imalat == cmbImalat.Text))
                                    .Select(s => new FaaliyetRaporKoy
                                 (
                                    s.Koy,
                                     s.Kaynak,
                                     s.Imalat,
                                     item.KesinKabulTarihi is null ? new DateTime(1970, 01, 01) : item.KesinKabulTarihi.Value.Date,s.Uygulama
                                     ,
double.IsNaN((s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    ) ? 0 : (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    
                                 )).ToList();

                                _toplamUygulamaList.AddRange(list);
                            }
                        }

                        else
                        {
                            projeler = _dbContext.Projes.AsNoTracking()
                            .Include(p => p.Programis.Where(p => p.Kaynak == cmbKaynak.Text
                                                              && p.Yil == yil
                                                              && p.Ilce == ilce.Adi
                                                              && p.Birim == "Destek Hizmetler"
                                                              ))
                            .ToList();

                            foreach (var item in projeler)
                            {
                                var list = item.Programis.Where(p => p.Yil == yil && p.Ilce == ilce.Adi
                                && (cmbImalat.Text == "Hepsi" || p.Imalat == cmbImalat.Text)
                                && p.Koy.Contains(koy))
                                    .Select(s => new FaaliyetRaporKoy
                                 (
                                    s.Koy,
                                     s.Kaynak,
                                     s.Imalat,
                                     item.KesinKabulTarihi is null ? new DateTime(1970, 01, 01) : item.KesinKabulTarihi.Value.Date,s.Uygulama
                                    ,
double.IsNaN((s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                    ) ? 0 :
                                    (s.Uygulama / item.Programis.Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)
                                   
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

                    

                    var finalUygulamaList = _toplamUygulamaList.Select(f => new FaaliyetRaporKoy(
                        f.koyMezra,
                        f.program,
                        f.imalat + " (" + _dbContext.Imalats.Where(i => i.Isim == f.imalat).Select(i => i.Birim).FirstOrDefault() + ")",
                        f.tarih,
                        f.miktarUygulama,
                        f.harcama
                        )).ToList();

                    dataGridView1.DataSource = finalUygulamaList;
                }

                cmbKaynak.Focus();               
            }

            cmbYil.Focus();
        }          
        private void button1_Click(object sender, EventArgs e)
        {
            ExceleAktar exceleAktar = new ExceleAktar();
            exceleAktar.DataGridViewToExcel(dataGridView1);
        }

        private void FaaliyetRaporuKoyDestek_FormClosing(object sender, FormClosingEventArgs e)
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
