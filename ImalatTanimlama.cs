using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class ImalatTanimlama : Form
    {
        private AppDbContext? _dbContext;
        public ImalatTanimlama()
        {
            InitializeComponent();
        }

        private void ImalatTanimlama_Load(object sender, EventArgs e)
        {
            txtBirimFiyat.Mask = "0000000";
            _dbContext = new AppDbContext();
            _dbContext.Imalats.Load();
            dataGridView1.DataSource = _dbContext.Imalats.Local.ToBindingList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                try
                {
                    _dbContext!.Imalats.Add(new Imalat
                    {
                        Isim = txtAdi.Text,
                        Birim = txtBirim.Text,
                        Cins = txtCins.Text,
                        BirimFiyat = Convert.ToDouble(txtBirimFiyat.Text)
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

            txtAdi.Focus();
        }

        private bool IsModelValid()
        {
            if (txtAdi.Text != string.Empty && txtBirim.Text != string.Empty
                && txtCins.Text != string.Empty && txtBirimFiyat.Text != string.Empty)
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

        private void ImalatTanimlama_FormClosing(object sender, FormClosingEventArgs e)
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
                var imalatId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var imalat = _dbContext!.Imalats.Where(i => i.ID == (int)imalatId).FirstOrDefault();

                if (imalat != null)
                {
                    try
                    {
                        _dbContext.Imalats.Remove(imalat);
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
