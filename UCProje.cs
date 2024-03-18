using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UCProje : UserControl
    {
        private AppDbContext _dbContext;
        public UCProje()
        {
            InitializeComponent();
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            using (YeniProjeEkle yeniProje = new())
            {
                yeniProje.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void UCProje_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Projes.Load();
            dataGridView1.DataSource = _dbContext.Projes.Local.ToBindingList();
            dataGridView1.AutoGenerateColumns = false;
            OrderColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[1].Index
                && e.RowIndex > -1)
            {
                var projeId = dataGridView1.CurrentRow.Cells["ID"].Value;

                using (YatirimUygulama yatirim = new((int)projeId))
                {
                    yatirim.ShowDialog();
                    this.OnLoad(e);
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns[0].Index
                && e.RowIndex > -1)
            {
                var projeId = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                var proje = _dbContext.Projes.Where(p => p.ID == projeId).FirstOrDefault();

                if (proje != null) 
                {
                    var programs = _dbContext.YatirimProgramis.Where(y => y.Proje!.ID == projeId);

                    foreach (var yatirimProgrami in programs)
                    {
                        yatirimProgrami.YatirimDurumu = YatirimDurumu.Uygulanmadi;
                    }

                    var buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        _dbContext.YatirimProgramis.UpdateRange(programs);
                        _dbContext.Projes.Remove(proje);

                        _dbContext.SaveChanges();
                        dataGridView1.Refresh();
                    }
                }
            }
        }

        private void OrderColumns()
        {
            dataGridView1.Columns["Adi"].DisplayIndex = 0;
            dataGridView1.Columns["Aciklama"].DisplayIndex = 1;
            dataGridView1.Columns["YaklasikMaliyet"].DisplayIndex = 2;
            dataGridView1.Columns["SozlesmeBedeli"].DisplayIndex = 3;
            dataGridView1.Columns["ProjeDurumu"].DisplayIndex = 4;
            dataGridView1.Columns["Yuklenici"].DisplayIndex = 5;
            dataGridView1.Columns["Sil"].DisplayIndex = 6;
            dataGridView1.Columns["Uygulama"].DisplayIndex = 7;
            dataGridView1.Columns["ID"].DisplayIndex = 8;
        }
    }
}
