using WinFormsApp1;
using YatirimTakip.Models;

namespace YatirimTakip
{
    internal partial class UCTarimsal : UserControl
    {
        private readonly User _user;
        public UCTarimsal(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnProje_Click(object sender, EventArgs e)
        {
            UCProjeTarimsal ucc = new(_user);
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
            UCPurEmanetTarimsal ucc = new(_user);
            addControls(ucc);
        }

        private void UCTarimsal_Load(object sender, EventArgs e)
        {
            Form parent = this.FindForm();

            this.Width = parent.Width - 500;
            this.Height = parent.Height - 400;
            panelContainer.Width = parent.Width - 500;
            panelContainer.Height = parent.Height - 400;
        }
    }
}
