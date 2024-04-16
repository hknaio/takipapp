using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class KoyTanimlama : Form
    {
        private AppDbContext _dbContext;
        public KoyTanimlama()
        {
            InitializeComponent();
        }

        private void KoyTanimlama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Koys.Load();
            _dbContext.Ilces.Load();
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
            dataGridView1.DataSource = _dbContext.Koys.Local.ToBindingList();
        }

        private bool IsModelValid()
        {
            if (txtKoy.Text != string.Empty && cmbIlce.Text != string.Empty)
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

        private void KoyTanimlama_FormClosing(object sender, FormClosingEventArgs e)
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
                    var ilce = _dbContext.Ilces.Where(i => i.Adi == cmbIlce.Text).FirstOrDefault();

                    if (ilce is not null)
                    {

                        _dbContext.Koys.Add(new Koy
                        {
                            Adi = txtKoy.Text,
                            Ilce = ilce,
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

            txtKoy.Focus();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                var koy = (Koy)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (koy != null)
                {
                    e.Value = koy.Ilce.Adi;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[1].Index && e.RowIndex > -1)
            {
                var koyId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var koy = _dbContext!.Koys.Where(i => i.ID == (int)koyId).FirstOrDefault();

                if (koy != null)
                {
                    try
                    {
                        var buttons = MessageBoxButtons.YesNo;
                        var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            _dbContext.Koys.Remove(koy);
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

        private void btnKoyleriGetir_Click(object sender, EventArgs e)
        {
            if (cmbIlce.Text != string.Empty)
            {
                var koyler = _dbContext.Koys.Where(k => k.Ilce.Adi == cmbIlce.Text).ToList();
                dataGridView1.DataSource = koyler;
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value
                   = (e.RowIndex + 1).ToString();
        }
    }
}
