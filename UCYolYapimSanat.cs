
namespace WinFormsApp1
{
    public partial class UCYolYapimSanat : UserControl
    {
        public UCYolYapimSanat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCProjeSanat ucc = new();
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
            UCPurEmanetSanat ucc = new();
            addControls(ucc);
        }
    }
}
