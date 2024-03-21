
namespace WinFormsApp1
{
    public partial class UCAsfalt : UserControl
    {
        public UCAsfalt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCAsfaltVeri ucc = new();
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
