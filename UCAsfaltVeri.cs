using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UCAsfaltVeri : UserControl
    {
        private AppDbContext _dbContext;
        public UCAsfaltVeri()
        {
            InitializeComponent();
        }

        private void UCAsfaltVeri_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.YatirimProgramis.Where(y => y.Imalat.Contains("1.Kat")
                                                   && y.YatirimDurumu == Models.YatirimDurumu.Uygulaniyor).Load();
            dataGridView1.DataSource = _dbContext.YatirimProgramis.Local.ToBindingList();
        }
    }
}
