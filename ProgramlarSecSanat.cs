using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using YatirimTakip.Models;

namespace WinFormsApp1
{
    internal partial class ProgramlarSecSanat : Form
    {
        private AppDbContext _dbContext;
        private object _parent;
        private readonly User _user;

        public ProgramlarSecSanat(object parent, User user)
        {
            InitializeComponent();
            _parent = parent;
            _user = user;
        }

        private void ProgramlarSec_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            cmbYil.Text = DateTime.Now.Year.ToString();           
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var ilces = _dbContext.UserIlces.Where(u => u.User.ID == _user.ID).Select(u => u.IlceId).ToList();
            //_dbContext.Projes.Include(p => p.Programis).Where(p => p.Programis.Any(p => p.Ilce == "Alacakaya")).Load();
            List<Ilce> ilceList = new();

            ilces.ForEach(l => ilceList.Add(_dbContext.Ilces.Where(i => i.ID == l).FirstOrDefault()));

            var ilceNames = ilceList.Select(i => i.Adi).ToList();
            if (cmbKaynak.Text != string.Empty && cmbYil.Text != string.Empty)
            {
                var programlar = _dbContext.YatirimProgramis.Where(p => p.Yil == Convert.ToInt32(cmbYil.Text) 
                && p.Kaynak == cmbKaynak.Text && p.Imalat.Contains("Menfez") && p.YatirimDurumu == Models.YatirimDurumu.Uygulanmadi).OrderBy(y => y.Ilce).ToList();

                programlar = programlar.Where(p => ilceNames.Contains(p.Ilce)).ToList();

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

            if( _parent.GetType() == typeof(YeniProjeEkleSanat))
            {
                typeof(YeniProjeEkleSanat).GetMethod("ReceiveData")!.Invoke(_parent, new[] { seciliProgramListesi });
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
