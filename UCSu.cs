using WinFormsApp1;
using YatirimTakip.Models;

namespace YatirimTakip
{
    internal partial class UCSu : UserControl
    {
        private User _user;
        public UCSu(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnProje_Click(object sender, EventArgs e)
        {
            UCProjeSu ucc = new(_user);
            addControls(ucc);
        }
        private void addControls(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnPuremanet_Click(object sender, EventArgs e)
        {
            UCPurEmanetSu ucc = new(_user);
            addControls(ucc);
        }
    }
}
