namespace WinFormsApp1
{
    public partial class UCAsfaltAna : UserControl
    {
        public UCAsfaltAna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCKatliAsfalt ucc = new("1.");
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
            UCKatliAsfalt ucc = new("2.");
            addControls(ucc);
        }
    }
}
