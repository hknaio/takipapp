using WinFormsApp1.Data;

namespace YatirimTakip
{
    public partial class SifreDegistir : Form
    {
        private AppDbContext _dbContext;
        public SifreDegistir()
        {
            _dbContext = new AppDbContext();
            InitializeComponent();
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {

        }

        private void SifreDegistir_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oldPassword = txtMevcutSifre.Text;
            string username = txtUsername.Text;
            string newPassword = txtYeniSifre.Text;

            if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(oldPassword))
            {
                MessageBox.Show("Lütfen bütün alanları doldurunuz.");
                return;
            }

            var user = _dbContext.Users.FirstOrDefault(u => u.UserName == username && u.Password == oldPassword);

            if (user is not null)
            {
                if (oldPassword != newPassword)
                {
                    try
                    {
                        user.Password = newPassword;
                        _dbContext.SaveChanges();
                        MessageBox.Show("Şifre değişikliği başarılı.");
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                }
                else
                {
                    MessageBox.Show("Yeni bir şifre giriniz..");
                    txtMevcutSifre.Clear(); txtYeniSifre.Clear();
                }
            }

            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.. Şifre ya da kullanıcı adı hatalı olabilir.");
            }          
        }
    }
}
