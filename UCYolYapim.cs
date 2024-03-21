
namespace WinFormsApp1
{
    public partial class UCYolYapim : UserControl
    {
        public UCYolYapim()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCProje ucc = new();
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
            UCPurEmanet ucc = new();
            addControls(ucc);
        }
    }
}
