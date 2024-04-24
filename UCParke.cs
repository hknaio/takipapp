using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UCParke : UserControl
    {
        private AppDbContext _dbContext;
        public UCParke()
        {
            InitializeComponent();
        }

        private void UCParke_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.ParkeBordurIs.Where(p => p.ParkeBordurTip == Models.ParkeBordurTip.Parke).Load();
            _dbContext.ParkeBordurs.Where(p => p.Malzeme == "Parke").Load();
            dataGridView1.DataSource = _dbContext.ParkeBordurIs.Local.ToBindingList();
        }

        private void UCParke_Leave(object sender, EventArgs e)
        {
            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
