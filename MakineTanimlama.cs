using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using YatirimTakip.Models;

namespace YatirimTakip
{
    internal partial class MakineTanimlama : Form
    {
        private readonly User _user;
        private AppDbContext _dbContext;

        public MakineTanimlama(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void MakineTanimlama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.IsMakinesis.Load();            
            dataGridView1.DataSource = _dbContext.IsMakinesis.Local.ToBindingList();
            PageDatagrid();
        }

        private void MakineTanimlama_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                try
                {
                    var ismakinesi = new IsMakinesi
                    {
                        Plaka = txtPlaka.Text,
                        Turu = cmbTur.Text
                    };

                    _dbContext.IsMakinesis.Add(ismakinesi);



                    _dbContext.SaveChanges();
                    dataGridView1.Refresh();
                    PageDatagrid();
                    ClearTexts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }

            txtPlaka.Focus();
        }
        private bool IsModelValid()
        {
            if (txtPlaka.Text != string.Empty
                && cmbTur.Text != string.Empty)
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
        private int _pageSize = 10; // Number of records per page
        private int _currentPage = 1;

        private void PageDatagrid()
        {
            var totalRecords = _dbContext.Users.Count();
            var totalPages = (int)Math.Ceiling((double)totalRecords / _pageSize);

            var makinesis = _dbContext.IsMakinesis
                .Skip((_currentPage - 1) * _pageSize)
                .Take(_pageSize)
                .ToList();

            dataGridView1.DataSource = makinesis;

            // Update pagination controls (if any)
            lblPageInfo.Text = $"Page {_currentPage} of {totalPages}";
            btnPrevious.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < totalPages;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage++;
            PageDatagrid();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _currentPage--;
            PageDatagrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[0].Index)
            {
                var makineId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var makine = _dbContext!.IsMakinesis.Where(i => i.ID == (int)makineId).FirstOrDefault();

                if (makine is not null)
                {
                    try
                    {
                        var buttons = MessageBoxButtons.YesNo;
                        var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            _dbContext.IsMakinesis.Remove(makine);
                            _dbContext.SaveChanges();
                            dataGridView1.Refresh();
                            PageDatagrid();
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
