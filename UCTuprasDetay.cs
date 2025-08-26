using System.Data.Entity;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class UCTuprasDetay : UserControl
    {
        private AppDbContext _dbContext;
        private readonly string _malzeme;
        public UCTuprasDetay(string malzeme)
        {
            InitializeComponent();
            _malzeme = malzeme;
        }

        private void UCTuprasDetay_Load(object sender, EventArgs e)
        {
            Form parent = this.FindForm();

            this.Width = parent.Width - 500;
            this.Height = parent.Height - 350;
            dataGridView1.Width = parent.Width - 500;
            dataGridView1.Height = parent.Height - 350;

            _dbContext = new AppDbContext();
            label1.Text = _malzeme + " Listesi";
            _dbContext.TuprasMalzemes.Where(t => t.Tur == _malzeme).Load();
            dataGridView1.DataSource = _dbContext.TuprasMalzemes.Local.ToBindingList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using (TuprasMalzemeEkle tupras = new(_malzeme))
            {
                tupras.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void UCTuprasDetay_Leave(object sender, EventArgs e)
        {
            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[0].Index && e.RowIndex > -1)
            {
                var tuprasId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var tupras = _dbContext!.TuprasMalzemes.Where(i => i.ID == (int)tuprasId).FirstOrDefault();

                if (tupras != null)
                {
                    try
                    {
                        var buttons = MessageBoxButtons.YesNo;
                        var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            _dbContext.TuprasMalzemes.Remove(tupras);
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
