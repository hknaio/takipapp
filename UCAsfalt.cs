
using System.Windows.Forms;

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
            UCAsfaltAna ucc = new();
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
            UCSaricubukAna ucc = new();
            addControls(ucc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UCAsfaltParke ucc = new();
            addControls(ucc);
        }

        private void UCAsfalt_Load(object sender, EventArgs e)
        {
            Form parent = this.FindForm();

            this.Width = parent.Width - 400;
            this.Height = parent.Height - 300;
            panelContainer.Width = parent.Width - 400;
            panelContainer.Height = parent.Height - 300;
        }
    }
}
