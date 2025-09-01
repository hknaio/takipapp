using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UCBordur : UserControl
    {
        private AppDbContext _dbContext;
        public UCBordur()
        {
            InitializeComponent();
        }

        private void UCBordur_Load(object sender, EventArgs e)
        {
            Form parent = this.FindForm();

            this.Width = parent.Width - 500;
            this.Height = parent.Height;
            dataGridView1.Width = parent.Width - 500;
            dataGridView1.Height = parent.Height;

            _dbContext = new AppDbContext();
            _dbContext.ParkeBordurIs.Where(p => p.ParkeBordurTip == Models.ParkeBordurTip.Bordur).Load();
            _dbContext.ParkeBordurs.Where(p => p.Malzeme == "Bordür").Load();
            dataGridView1.DataSource = _dbContext.ParkeBordurIs.Local.ToBindingList();
        }

        private void UCBordur_Leave(object sender, EventArgs e)
        {
            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (ParkeBordurEkle parkeBordur = new("Bordür"))
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
                var bordurIsId = dataGridView1.CurrentRow.Cells["ID"].Value;
                var bordurIs = _dbContext!.ParkeBordurIs.Where(p => p.ID == (int)bordurIsId).FirstOrDefault();
                var bordur = _dbContext!.ParkeBordurs.Where(p => p.Malzeme == "Bordür").FirstOrDefault();

                try
                {
                    var buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        bordur!.StokMiktar += bordurIs!.Miktar;

                        _dbContext!.Remove(bordurIs!);
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

                using (ParkeBordurMiktarGuncelle bordurGuncelle = new((int)miktar, "Bordür", (int)id))
                {
                    bordurGuncelle.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }

        private void btnBordurStok_Click(object sender, EventArgs e)
        {
            using (ParkeBordurStokGuncelle stokGuncelle = new("Bordür"))
            {
                stokGuncelle.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
