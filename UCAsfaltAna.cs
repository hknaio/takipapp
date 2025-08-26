using System.Windows.Forms;

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

        private void button3_Click(object sender, EventArgs e)
        {
            UCAsfaltDokum ucc = new("Asfalt Bakım Onarım");
            addControls(ucc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UCAsfaltDokum ucc = new("BSK");
            addControls(ucc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UCAsfaltDokum ucc = new("Asfalt Döküm İhalesi");
            addControls(ucc);
        }

        private void UCAsfaltAna_Load(object sender, EventArgs e)
        {
            Form parent = this.FindForm();

            this.Width = parent.Width - 400;
            this.Height = parent.Height - 300;
            panelContainer.Width = parent.Width - 400;
            panelContainer.Height = parent.Height - 300;
        }
    }
}
