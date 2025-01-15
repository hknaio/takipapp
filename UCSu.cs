using WinFormsApp1;

namespace YatirimTakip
{
    public partial class UCSu : UserControl
    {
        public UCSu()
        {
            InitializeComponent();
        }

        private void btnProje_Click(object sender, EventArgs e)
        {
            UCProjeSu ucc = new();
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
            UCPurEmanetSu ucc = new();
            addControls(ucc);
        }
    }
}
