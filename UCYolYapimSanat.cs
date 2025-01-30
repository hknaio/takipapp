using YatirimTakip.Models;

namespace WinFormsApp1
{
    internal partial class UCYolYapimSanat : UserControl
    {
        private readonly User _user;
        public UCYolYapimSanat(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCProjeSanat ucc = new(_user);
            addControls(ucc);
        }

        private void addControls(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCPurEmanetSanat ucc = new(_user);
            addControls(ucc);
        }
    }
}
