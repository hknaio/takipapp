using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class MezraTanimlama : Form
    {
        private AppDbContext _dbContext;

        public MezraTanimlama()
        {
            InitializeComponent();
        }
        private void MezraTanimlama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Koys.Load();
            _dbContext.Mezras.Load();
            cmbKoy.DataSource = _dbContext.Koys.Local.ToBindingList();
            cmbKoy.DisplayMember = "Adi"; cmbKoy.Invalidate();
            dataGridView1.DataSource = _dbContext.Mezras.Local.ToBindingList();

        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                try
                {
                    var koy = _dbContext.Koys.Where(i => i.Adi == cmbKoy.Text).FirstOrDefault();

                    if (koy is not null)
                    {

                        _dbContext.Mezras.Add(new Mezra
                        {
                            Adi = txtMezra.Text,
                            Koy = koy,
                        });

                        _dbContext.SaveChanges();
                        dataGridView1.Refresh();
                        ClearTexts();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }

            txtMezra.Focus();
        }
        private bool IsModelValid()
        {
            if (txtMezra.Text != string.Empty && cmbKoy.Text != string.Empty)
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
        private void MezraTanimlama_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                var mezra = (Mezra)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (mezra != null)
                {
                    e.Value = mezra.Koy.Adi;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[0].Index && e.RowIndex > -1)
            {
                var mezraId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var mezra = _dbContext!.Mezras.Where(i => i.ID == (int)mezraId).FirstOrDefault();

                if (mezra != null)
                {
                    try
                    {
                        var buttons = MessageBoxButtons.YesNo;
                        var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            _dbContext.Mezras.Remove(mezra);
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
