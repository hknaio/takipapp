using WinFormsApp1.Data;
using WinFormsApp1.Models;
using WinFormsApp1.Helpers;
using YatirimTakip.Helpers;

namespace WinFormsApp1
{
    public partial class RprProgram : Form
    {
        private AppDbContext _dbContext;
        public RprProgram()
        {
            _dbContext = new AppDbContext();
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var programlar = _dbContext.YatirimProgramis.Where(y => y.Kaynak == cmbKaynak.Text)
                .GroupBy(y => y.Ilce).Select(p => new
                {
                    Ilce = p.Key,
                    ToplamIs = p.Where(y => y.Ilce == p.Key).Count(),
                    DevamEden = p.Where(y => y.Ilce == p.Key && y.YatirimDurumu == YatirimDurumu.Uygulaniyor).Count(),
                    Biten = p.Where(y => y.Ilce == p.Key && y.YatirimDurumu == YatirimDurumu.Uygulandi).Count(),
                    Baslamamis = p.Where(y => y.Ilce == p.Key && y.YatirimDurumu == YatirimDurumu.Uygulanmadi).Count(),
                }).ToList();

            dataGridView1.DataSource = programlar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PDFCreator pDF = new();

            pDF.CreatePdf(dataGridView1, "Program");
        }
    }
}
