namespace WinFormsApp1
{
    public partial class UCTupras : UserControl
    {
        public UCTupras()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UCTuprasDetay ucc = new("50-70 Asfalt");
            addControls(ucc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCTuprasDetay ucc = new("160-220 Asfalt");
            addControls(ucc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCTuprasDetay ucc = new("FM2B2 Astar (CMC-30)");
            addControls(ucc);
        }

        private void addControls(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UCTuprasDetay ucc = new("FM2B2 Astar (MC-30)");
            addControls(ucc);
        }
    }
}
