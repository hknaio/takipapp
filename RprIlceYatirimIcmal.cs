using WinFormsApp1.Data;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;
using YatirimTakip.Helpers;

namespace YatirimTakip
{
    internal record YatirimIcmal(string koy, int yil, string imalat, double ilozel, double koydes, double ilbank, double diger, double toplam);
    internal record ToplamUygulama(int programId, string koy, string imalat, double tahakkkuk, double toplamUygulama, double uygulama, double oransalTahakkuk);
    public partial class RprIlceYatirimIcmal : Form
    {
        private AppDbContext _dbContext;

        public RprIlceYatirimIcmal()
        {
            InitializeComponent();
        }

        private void RprIlceYatirimIcmal_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Ilces.Load();
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
            dataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "N2";
        }

        private void RprIlceYatirimIcmal_Leave(object sender, EventArgs e)
        {
            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (cmbIlce.Text != string.Empty)
            {
                var ilce = (Ilce)cmbIlce.SelectedValue!;

                var projeler = _dbContext.Projes
               .Include(p => p.Programis.Where(p => p.Ilce == ilce.Adi))
               .ToList();

                List<YatirimIcmal> _toplamUygulamaList = [];

                foreach (var item in projeler)
                {
                    var list = item.Programis.Where(p => p.Ilce == ilce.Adi).Select(s => new YatirimIcmal
                     (
                         s.Koy,
                         s.Yil,
                         s.Imalat,
                        double.IsInfinity((s.Uygulama / item.Programis.Where(r => r.Kaynak == "İl Özel İdaresi").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)) ? 0
                        : (s.Uygulama / item.Programis.Where(r => r.Kaynak == "İl Özel İdaresi").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk),
                        double.IsInfinity((s.Uygulama / item.Programis.Where(r => r.Kaynak == "KÖYDES").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)) ? 0
                        : (s.Uygulama / item.Programis.Where(r => r.Kaynak == "KÖYDES").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk),
                        double.IsInfinity((s.Uygulama / item.Programis.Where(r => r.Kaynak == "İlbank").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)) ? 0
                        : (s.Uygulama / item.Programis.Where(r => r.Kaynak == "İlbank").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk),
                        double.IsInfinity((s.Uygulama / item.Programis.Where(r => r.Kaynak == "Diğer").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)) ? 0
                        : (s.Uygulama / item.Programis.Where(r => r.Kaynak == "Diğer").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk),
                        CheckInfinite((s.Uygulama / item.Programis.Where(r => r.Kaynak == "İl Özel İdaresi").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)) +
                        CheckInfinite((s.Uygulama / item.Programis.Where(r => r.Kaynak == "KÖYDES").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)) +
                        CheckInfinite((s.Uygulama / item.Programis.Where(r => r.Kaynak == "İlbank").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk)) +
                        CheckInfinite((s.Uygulama / item.Programis.Where(r => r.Kaynak == "Diğer").Sum(p => p.Uygulama) * item.HakedisToplamTahakkuk))
                        )).ToList();

                    _toplamUygulamaList.AddRange(list);
                }

                dataGridView1.DataSource = _toplamUygulamaList;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDFCreator pDF = new();
            var ilce = (Ilce)cmbIlce.SelectedValue!;
            pDF.CreatePdf(dataGridView1, ilce.Adi + " Yatırım İcmal Raporu ");
        }

        private double CheckInfinite(double value)
        {
            return double.IsInfinity(value) ? 0 : value;
        }
    }
}
