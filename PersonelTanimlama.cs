using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using YatirimTakip.Models;

namespace YatirimTakip
{
    public partial class PersonelTanimlama : Form
    {
        private AppDbContext _dbContext;
        public PersonelTanimlama()
        {
            InitializeComponent();
        }

        private void PersonelTanimlama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();

            _dbContext.Users.Load();
            _dbContext.UserIlces.Load();
            chkIlce.DataSource = _dbContext.Ilces.ToList();
            chkIlce.DisplayMember = "Adi";
            chkIlce.ValueMember = "Adi";
            dataGridView1.DataSource = _dbContext.Users.Local.ToBindingList();
            OrderColumns();
            PageDatagrid();
        }

        private void PersonelTanimlama_Leave(object sender, EventArgs e)
        {

        }

        private void PersonelTanimlama_FormClosing(object sender, FormClosingEventArgs e)
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
                    var user = new User
                    {
                        Isim = txtAdi.Text,
                        Soyisim = txtSoyadi.Text,
                        UserName = txtAdi.Text[0].ToString().ToLower() + txtSoyadi.Text.ToLower(), //set hakana
                        Password = txtAdi.Text[0].ToString().ToLower() + txtSoyadi.Text.ToLower(), //encrypt data
                        Birim = cmbBirim.Text,
                        Role = cmbRol.Text
                    };
                    _dbContext.Users.Add(user);

                    foreach (var ilceUser in chkIlce.CheckedItems)
                    {
                        var record = new UserIlce
                        {
                            User = user,
                            Ilce = (Ilce)ilceUser
                        };
                        _dbContext!.UserIlces.Add(record);
                    }

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

            txtAdi.Focus();
        }

        private bool IsModelValid()
        {
            if (txtAdi.Text != string.Empty && txtSoyadi.Text != string.Empty
                && cmbBirim.Text != string.Empty && cmbRol.Text != string.Empty)
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
                var userId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var user = _dbContext!.Users.Where(i => i.ID == (int)userId).FirstOrDefault();
                var userIlces = _dbContext.UserIlces.Where(i => i.UserId == (int)userId).ToList();

                if (user is not null)
                {
                    try
                    {
                        var buttons = MessageBoxButtons.YesNo;
                        var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            _dbContext.UserIlces.RemoveRange(userIlces);
                            _dbContext.Users.Remove(user);
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

            if (e.ColumnIndex ==
           dataGridView1.Columns[2].Index)
            {
                var userId = (int)dataGridView1.CurrentRow.Cells["ID"].Value;

                using (PersonelGuncelle guncelle = new((int)userId))
                {
                    guncelle.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }
        private void OrderColumns()
        {
            dataGridView1.Columns["Isim"].DisplayIndex = 0;
            dataGridView1.Columns["Soyisim"].DisplayIndex = 1;
            dataGridView1.Columns["Birim"].DisplayIndex = 2;
            dataGridView1.Columns["Rol"].DisplayIndex = 3;
            dataGridView1.Columns["KullaniciAdi"].DisplayIndex = 4;
            dataGridView1.Columns["Ilceler"].DisplayIndex = 5;
        }

        private int _pageSize = 10; // Number of records per page
        private int _currentPage = 1;

        private void PageDatagrid()
        {
            var totalRecords = _dbContext.Users.Count();
            var totalPages = (int)Math.Ceiling((double)totalRecords / _pageSize);

            var users = _dbContext.Users
                .Skip((_currentPage - 1) * _pageSize)
                .Take(_pageSize)
                .ToList();

            dataGridView1.DataSource = users;

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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var user = (User)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                var userIlces = _dbContext.UserIlces.Where(m => m.User.Isim == user.Isim).ToList();
                string ilces = string.Empty;
                foreach (var ilce in userIlces)
                {
                    ilces += ilce.Ilce.Adi + " ";
                }

                if (user is not null || userIlces is not null)
                {
                    e.Value = ilces;
                }
            }
        }
    }
}
