using System.Data;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class YatirimTanimlamaDetay : Form
    {
        private AppDbContext? _dbContext;
        public YatirimTanimlamaDetay(int yil, string kaynak)
        {
            InitializeComponent();
            label3.Text = kaynak;
            label4.Text = yil.ToString();
            _dbContext = new AppDbContext();
            var yatirimProgramlar = _dbContext.YatirimProgramis
                .Where(y => y.Yil == yil && y.Kaynak == kaynak);
            dataGridView1.DataSource = yatirimProgramlar.ToList();
        }

        private void YatirimTanimlamaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
