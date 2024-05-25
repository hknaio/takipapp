
namespace WinFormsApp1
{
    public partial class UCSaricubukAna : UserControl
    {
        public UCSaricubukAna()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UCTupras ucc = new();
            addControls(ucc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCAsfaltSantiye ucc = new();
            addControls(ucc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCGidenMalzeme ucc = new();
            addControls(ucc);
        }

        private void addControls(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }
    }
}
