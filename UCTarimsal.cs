using WinFormsApp1;

namespace YatirimTakip
{
    public partial class UCTarimsal : UserControl
    {
        public UCTarimsal()
        {
            InitializeComponent();
        }

        private void btnProje_Click(object sender, EventArgs e)
        {
            UCProjeTarimsal ucc = new();
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
            UCPurEmanetTarimsal ucc = new();
            addControls(ucc);
        }
    }
}
