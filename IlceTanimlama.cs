using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class IlceTanimlama : Form
    {
        private AppDbContext _dbContext;
        public IlceTanimlama()
        {
            InitializeComponent();
        }

        private void IlceTanimlama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Ilces.Load();
            dataGridView1.DataSource = _dbContext.Ilces.Local.ToBindingList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                try
                {
                    _dbContext.Ilces.Add(new Ilce
                    {
                        Adi = txtAdi.Text
                    });
                    _dbContext.SaveChanges();
                    dataGridView1.Refresh();
                    ClearTexts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }
        }

        private bool IsModelValid()
        {
            if (txtAdi.Text != string.Empty)
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

        private void IlceTanimlama_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[0].Index)
            {
                var ilceId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var ilce = _dbContext!.Ilces.Where(i => i.ID == (int)ilceId).FirstOrDefault();

                if (ilce != null)
                {
                    try
                    {
                        _dbContext.Ilces.Remove(ilce);
                        _dbContext.SaveChanges();
                        dataGridView1.Refresh();
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
