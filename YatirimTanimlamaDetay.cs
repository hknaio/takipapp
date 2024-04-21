using System.Data;
using System.Data.Entity;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class YatirimTanimlamaDetay : Form
    {
        private readonly int _yil;
        private readonly string _kaynak;
        private AppDbContext? _dbContext;
        public YatirimTanimlamaDetay(int yil, string kaynak)
        {
            InitializeComponent();
            _yil = yil;
            _kaynak = kaynak;
        }
        private void YatirimTanimlamaDetay_Load(object sender, EventArgs e)
        {
            label3.Text = _kaynak;
            label4.Text = _yil.ToString();
            _dbContext = new AppDbContext();
            _dbContext.YatirimProgramis
                .Where(y => y.Yil == _yil && y.Kaynak == _kaynak)
                .OrderBy(y => y.Ilce).Load();
            dataGridView1.DataSource = _dbContext.YatirimProgramis.Local.ToBindingList();
        }

        private void YatirimTanimlamaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void btnEkProgram_Click(object sender, EventArgs e)
        {
            using (EkProgramEkle ek = new(Convert.ToInt32(label4.Text), label3.Text))
            {
                ek.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[0].Index && e.RowIndex > -1)
            {
                var programId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var program = _dbContext!.YatirimProgramis.Where(i => i.ID == (int)programId).FirstOrDefault();

                if (program != null)
                {
                    try
                    {
                        var buttons = MessageBoxButtons.YesNo;
                        var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            _dbContext.YatirimProgramis.Remove(program);
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

            if (e.ColumnIndex ==
          dataGridView1.Columns[1].Index && e.RowIndex > -1)
            {
                var programId = dataGridView1.CurrentRow.Cells["ID"].Value;

                using (YatirimProgramiDuzenle yatirimProgramiDuzenle = new((int)programId))
                {
                    yatirimProgramiDuzenle.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }
    }
}
