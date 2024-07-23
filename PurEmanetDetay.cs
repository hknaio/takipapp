using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class PurEmanetDetay : Form
    {
        private AppDbContext _dbContext;
        private readonly int _id;
        private PurEmanet _purEmanet;
        public PurEmanetDetay(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void PurEmanetDetay_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _purEmanet = _dbContext!.PurEmanets
                .Include(p => p.Ilce)
                .Include(p => p.Koy)
                .Include(p => p.Imalat)
                .Include(p => p.SpiralBoru)
                .Include(p => p.Mezralar)
                     .ThenInclude(p => p.Mezra)
                .Where(p => p.ID == _id).FirstOrDefault();
            string mezralar = string.Empty;

            if (_purEmanet is not null)
            {
                lblTarih.Text = _purEmanet.Tarih.ToShortDateString();
                lblIlce.Text = _purEmanet.Ilce.Adi;
                lblKoy.Text = _purEmanet.Koy.Adi;
                _purEmanet.Mezralar.ToList().ForEach(
                    m => mezralar += m.Mezra.Adi + " ");
                lblMezralar.Text = mezralar;
                lblImalat.Text = ImalatAdi(_purEmanet);
                lblCins.Text = _purEmanet.Imalat.Cins;
                lblBirim.Text = _purEmanet.Imalat.Birim;
                lblBirimFiyat.Text = BirimFiyat(_purEmanet);
                lblMiktar.Text = _purEmanet.Miktar.ToString();
                lblTutar.Text = _purEmanet.Tutar.ToString("0.00");
                lblPersonel.Text = "Hakan Aygüzer";
            }
        }

        private string ImalatAdi(PurEmanet purEmanet)
        {
            string imalatAdi = string.Empty;

            if (purEmanet.Imalat.Isim == "Spiral Boru")
            {
                var boru = _dbContext.SpiralBorus.Where(s => s.ID == purEmanet.SpiralBoruId).FirstOrDefault();
                imalatAdi = purEmanet.Imalat.Isim + " - " + boru!.Cap.ToString();
            }
            else
            {
                imalatAdi = purEmanet.Imalat.Isim;
            }

            return imalatAdi;
        }

        private string BirimFiyat(PurEmanet purEmanet)
        {
            string birimFiyat = string.Empty;

            var imalatFiyatTarih = purEmanet.Imalat.FiyatGecerlilikBaslangicTarihi;

            if (purEmanet.Imalat.Isim == "Spiral Boru")
            {
                if (purEmanet.Tarih >= imalatFiyatTarih)
                {
                    var boru = _dbContext.SpiralBorus.Where(s => s.ID == purEmanet.SpiralBoruId).FirstOrDefault();
                    birimFiyat = boru!.BirimFiyat.ToString("0.00");
                }
                else
                {
                    var birimFiyatEski = _dbContext.SpiralBirimFiyatTarihGecmisis
                        .Where(s => s.SpiralBoru.ID == purEmanet.SpiralBoruId).ToList()
                        .OrderBy(t => Math.Abs((t.GecerlilikBaslangicTarihi - purEmanet.Tarih).Ticks))
                                 .First();

                    birimFiyat = birimFiyatEski.BirimFiyat.ToString("0.00");
                }
            }

            else
            {
                if (purEmanet.Tarih >= imalatFiyatTarih)
                {
                    birimFiyat = purEmanet.Imalat.BirimFiyat.ToString("0.00");
                }
                else
                {
                    var birimFiyatEski = _dbContext.ImalatBirimFiyatTarihGecmisis
                        .Where(i => i.Imalat.ID == purEmanet.ImalatId).ToList()
                        .OrderBy(t => Math.Abs((t.GecerlilikBaslangicTarihi - purEmanet.Tarih).Ticks))
                                 .First();

                    birimFiyat = birimFiyatEski.BirimFiyat.ToString("0.00");
                }
            }

            return birimFiyat;
        }

        private void PurEmanetDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
