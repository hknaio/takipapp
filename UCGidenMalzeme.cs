using System.Data.Entity;
using WinFormsApp1.Data;
namespace WinFormsApp1
{
    public partial class UCGidenMalzeme : UserControl
    {
        private AppDbContext _dbContext;
        public UCGidenMalzeme()
        {
            InitializeComponent();
        }

        private void UCGidenMalzeme_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            label1.Text = "Giden Malzeme Listesi";
            _dbContext.GidenMalzemes.Load();
            dataGridView1.DataSource = _dbContext.GidenMalzemes.Local.ToBindingList();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (GidenMalzemeEkle gidenMalzeme = new())
            {
                gidenMalzeme.ShowDialog();
                this.OnLoad(e);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
          dataGridView1.Columns[0].Index && e.RowIndex > -1)
            {
                var gidenMalzemeId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var gidenMalzeme = _dbContext!.GidenMalzemes.Where(i => i.ID == (int)gidenMalzemeId).FirstOrDefault();

                if (gidenMalzeme != null)
                {
                    try
                    {
                        var buttons = MessageBoxButtons.YesNo;
                        var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            _dbContext.GidenMalzemes.Remove(gidenMalzeme);
                            _dbContext.SaveChanges();
                            dataGridView1.Refresh();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bir şeyler ters gitti. Lütfen tekrar deneyin.", "Hata");
                    }
                }
            }
        }
        private void UCGidenMalzeme_Leave(object sender, EventArgs e)
        {
            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
