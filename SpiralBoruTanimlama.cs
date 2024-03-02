using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class SpiralBoruTanimlama : Form
    {
        private AppDbContext? _dbContext;
        public SpiralBoruTanimlama()
        {
            InitializeComponent();
        }

        private void SpiralBoruTanimlama_Load(object sender, EventArgs e)
        {
            txtCap.Mask = "0000";
            _dbContext = new AppDbContext();
            _dbContext.SpiralBorus.Load();
            dataGridView1.DataSource = _dbContext.SpiralBorus.Local.ToBindingList();
        }

        private void SpiralBoruTanimlama_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                try
                {
                    _dbContext!.SpiralBorus.Add(new SpiralBoru
                    {
                        Cap = Convert.ToInt32(txtCap.Text),
                        Birim = txtBirim.Text,
                        StokMiktar = Convert.ToInt32(txtStok.Text),
                    });
                    _dbContext.SaveChanges();
                    dataGridView1.Refresh();
                    ClearTexts();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir şeyler ters gitti. Lütfen tekrar deneyin.", "Hata");
                }
            }

            txtCap.Focus();
        }

        private bool IsModelValid()
        {
            if (txtCap.Text != string.Empty && txtBirim.Text != string.Empty
                && txtStok.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearTexts()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox or MaskedTextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[1].Index)
            {
                var boruId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var boru = _dbContext!.SpiralBorus.Where(i => i.ID == (int)boruId).FirstOrDefault();

                if (boru != null)
                {
                    try
                    {
                        _dbContext.SpiralBorus.Remove(boru);
                        _dbContext.SaveChanges();
                        dataGridView1.Refresh();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bir şeyler ters gitti. Lütfen tekrar deneyin.", "Hata");
                    }
                }
            }

            if (e.ColumnIndex ==
          dataGridView1.Columns[0].Index)
            {
                var miktar = dataGridView1.CurrentRow.Cells["StokMiktar"].Value;
                var id = dataGridView1.CurrentRow.Cells["ID"].Value;

                using (StokGuncelle stokGuncelle = new((int)miktar, (int)id))
                {
                    stokGuncelle.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }
    }
}
