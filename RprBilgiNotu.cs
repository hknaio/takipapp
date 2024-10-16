using WinFormsApp1.Data;
using YatirimTakip.Helpers;
using Microsoft.EntityFrameworkCore;

namespace YatirimTakip
{
    public partial class RprBilgiNotu : Form
    {
        private AppDbContext _dbContext;
        public RprBilgiNotu()
        {
            InitializeComponent();
        }
        private void RprBilgiNotu_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Ilces.Load();
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            PDFCreator pDFCreator = new PDFCreator();

            var yolAgi = _dbContext.YolAgis.Where(x => x.Ilce.Adi == cmbIlce.Text).FirstOrDefault();
            var programs = _dbContext.YatirimProgramis.Where(x => x.Ilce == cmbIlce.Text
            && x.YatirimDurumu == WinFormsApp1.Models.YatirimDurumu.Uygulandi).ToList();
                   
            pDFCreator.BilgiNotu(yolAgi, programs);
        }
    }
}
