using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UCAsfaltVeri : UserControl
    {
        private AppDbContext _dbContext;
        private readonly string _asfalt;
        public UCAsfaltVeri(string asfalt)
        {
            InitializeComponent();
            _asfalt = asfalt;
        }

        private void UCAsfaltVeri_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.YatirimProgramis.Where(y => y.Imalat.Contains(_asfalt)
                                                   //&& y.Uygulama == 0
                                                   && y.YatirimDurumu == Models.YatirimDurumu.Uygulaniyor).Load();
            dataGridView1.DataSource = _dbContext.YatirimProgramis.Local.ToBindingList();
            dataGridView1.AutoGenerateColumns = false;
            OrderColumns();
        }

        private void OrderColumns()
        {
            dataGridView1.Columns["Ilce"].DisplayIndex = 0;
            dataGridView1.Columns["Koy"].DisplayIndex = 1;
            dataGridView1.Columns["Imalat"].DisplayIndex = 2;
            dataGridView1.Columns["Miktar"].DisplayIndex = 3;
            dataGridView1.Columns["Uygulama"].DisplayIndex = 4;
            dataGridView1.Columns["YaklasikMaliyet"].DisplayIndex = 5;
            dataGridView1.Columns["Kaynak"].DisplayIndex = 6;
            dataGridView1.Columns["YatirimDurumu"].DisplayIndex = 7;
            dataGridView1.Columns["UygulamaGuncelle"].DisplayIndex = 8;
            dataGridView1.Columns["ProgramId"].DisplayIndex = 9;
            dataGridView1.Columns["Birim"].DisplayIndex = 10;
            dataGridView1.Columns["Yil"].DisplayIndex = 11;
            dataGridView1.Columns["Program"].DisplayIndex = 12;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[0].Index && e.RowIndex > -1)
            {
                var programId = (int)dataGridView1.CurrentRow.Cells["programId"].Value;

                using (AsfaltUygulamaGuncelle asfaltUygulama = new(_asfalt,programId))
                {
                    asfaltUygulama.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }
    }
}
