using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class ProgramlarSec : Form
    {
        private AppDbContext _dbContext;
        private object _parent;
        public ProgramlarSec(object parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void ProgramlarSec_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
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

            if( _parent.GetType() == typeof(YeniProjeEkle))
            {
                typeof(YeniProjeEkle).GetMethod("ReceiveData")!.Invoke(_parent, new[] { seciliProgramListesi });
            }

            if (_parent.GetType() == typeof(YatirimUygulama))
            {
                typeof(YatirimUygulama).GetMethod("ReceiveData")!.Invoke(_parent, new[] { seciliProgramListesi });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
