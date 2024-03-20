using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class ProgramlarSec : Form
    {
        private AppDbContext _dbContext;
        private YeniProjeEkle _parent;
        public ProgramlarSec(YeniProjeEkle parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void ProgramlarSec_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            cmbYil.Text = DateTime.Now.Year.ToString();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (cmbKaynak.Text != string.Empty && cmbYil.Text != string.Empty)
            {
                var programlar = _dbContext.YatirimProgramis.Where(p => p.Yil == Convert.ToInt32(cmbYil.Text)
                && p.Kaynak == cmbKaynak.Text && p.YatirimDurumu == Models.YatirimDurumu.Uygulanmadi).OrderBy(y => y.Ilce).ToList();

                dataGridView1.DataSource = programlar;
            }

            cmbYil.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<YatirimProgrami> seciliProgramListesi = new();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Sec"].Value);
                if (isSelected)
                {
                    seciliProgramListesi.Add((YatirimProgrami)row.DataBoundItem);
                }
            }
            this.Close();

            _parent.ReceiveData(seciliProgramListesi);
            _parent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
