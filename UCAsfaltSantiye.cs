using System.Data.Entity;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class UCAsfaltSantiye : UserControl
    {
        private AppDbContext _dbContext;
        public UCAsfaltSantiye()
        {
            InitializeComponent();
        }
        private void UCAsfaltSantiye_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            label1.Text = "Asfalt Şantiyesi Günlük Üretim Miktarı";
            _dbContext.AsfaltSantiyes.Load();
            dataGridView1.DataSource = _dbContext.AsfaltSantiyes.Local.ToBindingList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (AsfaltSantiyeEkle asfaltSantiye = new())
            {
                asfaltSantiye.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void UCAsfaltSantiye_Leave(object sender, EventArgs e)
        {
            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
          dataGridView1.Columns[0].Index && e.RowIndex > -1)
            {
                var asfaltSantiyeId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var asfaltSantiye = _dbContext!.AsfaltSantiyes.Where(i => i.ID == (int)asfaltSantiyeId).FirstOrDefault();

                if (asfaltSantiye != null)
                {
                    try
                    {
                        var buttons = MessageBoxButtons.YesNo;
                        var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            _dbContext.AsfaltSantiyes.Remove(asfaltSantiye);
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
    }
}
