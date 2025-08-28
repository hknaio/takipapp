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
            if (cmbKaynak.Text != string.Empty && cmbYil.Text != string.Empty)
            {
                var programlar = _dbContext.YatirimProgramis.Where(y => y.Kaynak == cmbKaynak.Text && y.Yil == Convert.ToInt32(cmbYil.Text))
              .GroupBy(y => y.Ilce).Select(p => new
              {
                  Ilce = p.Key,
                  ToplamIs = p.Where(y => y.Ilce == p.Key).Count(),
                  DevamEden = p.Where(y => y.Ilce == p.Key && y.Program != "Ek Program" && y.YatirimDurumu == YatirimDurumu.Uygulaniyor).Count(),
                  DevamEdenEk = p.Where(y => y.Ilce == p.Key && y.Program == "Ek Program" && y.YatirimDurumu == YatirimDurumu.Uygulaniyor).Count(),
                  Biten = p.Where(y => y.Ilce == p.Key && y.Program != "Ek Program" && y.YatirimDurumu == YatirimDurumu.Uygulandi).Count(),
                  BitenEk = p.Where(y => y.Ilce == p.Key && y.Program == "Ek Program" && y.YatirimDurumu == YatirimDurumu.Uygulandi).Count(),
                  Baslamamis = p.Where(y => y.Ilce == p.Key && y.Program != "Ek Program" && y.YatirimDurumu == YatirimDurumu.Uygulanmadi).Count(),
                  BaslamamisEk = p.Where(y => y.Ilce == p.Key && y.Program == "Ek Program" && y.YatirimDurumu == YatirimDurumu.Uygulanmadi).Count()
              }).ToList();

                dataGridView1.DataSource = programlar;
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExceleAktar exceleAktar = new();
            exceleAktar.DataGridViewToExcel(dataGridView1);
        }
    }
}
