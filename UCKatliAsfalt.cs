
namespace WinFormsApp1
{
    public partial class UCKatliAsfalt : UserControl
    {
        public UCKatliAsfalt()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCAsfaltVeri ucc = new("1.");
            addControls(ucc);
        }

        private void addControls(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
