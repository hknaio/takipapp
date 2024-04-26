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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (ParkeBordurEkle parkeBordur = new("Parke"))
            {
                parkeBordur.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[1].Index
                && e.RowIndex > -1)
            {
                var parkeIsId = dataGridView1.CurrentRow.Cells["ID"].Value;
                var parkeIs = _dbContext!.ParkeBordurIs.Where(p => p.ID == (int)parkeIsId).FirstOrDefault();
                var parke = _dbContext!.ParkeBordurs.Where(p => p.Malzeme == "Parke").FirstOrDefault();

                try
                {
                    var buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        parke!.StokMiktar += parkeIs!.Miktar;

                        _dbContext!.Remove(parkeIs!);
                        _dbContext.SaveChanges();
                        dataGridView1.Refresh();
                        this.OnLoad(e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns[0].Index
                && e.RowIndex > -1)
            {
                var miktar = dataGridView1.CurrentRow.Cells["Miktar"].Value;
                var id = dataGridView1.CurrentRow.Cells["ID"].Value;

                using (ParkeBordurMiktarGuncelle parkeGuncelle = new((int)miktar, "Parke", (int)id))
                {
                    parkeGuncelle.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }

        private void btnParkeStok_Click(object sender, EventArgs e)
        {
            using (ParkeBordurStokGuncelle stokGuncelle = new("Parke"))
            {
                stokGuncelle.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
