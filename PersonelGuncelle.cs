using WinFormsApp1.Data;
using WinFormsApp1.Models;
using YatirimTakip.Models;

namespace YatirimTakip
{
    public partial class PersonelGuncelle : Form
    {
        private AppDbContext _dbContext;
        private readonly int _selected;
        public PersonelGuncelle(int selected)
        {
            InitializeComponent();
            _selected = selected;
        }

        private void PersonelGuncelle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();

            var user = _dbContext.Users.Find(_selected);
            var userIlces = _dbContext.UserIlces.Where(u => u.User == user).ToList();

            if (user is not null)
            {
                txtAdi.Text = user.Isim;
                txtSoyadi.Text = user.Soyisim;
                cmbBirim.Text = user.Birim;
                cmbRol.Text = user.Role;
            }

            if (userIlces is not null)
            {
                chkIlce.DataSource = _dbContext.Ilces.ToList();
                chkIlce.DisplayMember = "Adi";
                chkIlce.ValueMember = "Adi";

                foreach (var item in userIlces)
                {
                    for (int i = 0; i < chkIlce.Items.Count; i++)
                    {
                        if (chkIlce.GetItemText(chkIlce.Items[i]) == item.Ilce.Adi)
                        {
                            chkIlce.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private void PersonelGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }               

        private void button1_Click_1(object sender, EventArgs e)
        {
            var user = _dbContext.Users.Find(_selected);
            if (user != null)
            {
                try
                {
                    user.Isim = txtAdi.Text;
                    user.Soyisim = txtSoyadi.Text;
                    user.Birim = cmbBirim.Text;
                    user.Role = cmbRol.Text;

                    // Update UserIlce associations
                    var selectedIlces = chkIlce.CheckedItems.Cast<Ilce>().ToList();
                    var existingUserIlces = _dbContext.UserIlces.Where(u => u.UserId == user.ID).ToList();

                    // Remove unselected UserIlces
                    foreach (var existing in existingUserIlces)
                    {
                        if (!selectedIlces.Any(i => i.ID == existing.IlceId))
                        {
                            _dbContext.UserIlces.Remove(existing);
                        }
                    }

                    // Add new UserIlces
                    foreach (var selected in selectedIlces)
                    {
                        if (!existingUserIlces.Any(u => u.IlceId == selected.ID))
                        {
                            _dbContext.UserIlces.Add(new UserIlce { UserId = user.ID, IlceId = selected.ID });
                        }
                    }

                    _dbContext.SaveChanges();
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                
            }
        }
    }
}
