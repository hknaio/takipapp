
namespace WinFormsApp1
{
    public partial class UCKatliAsfalt : UserControl
    {
        private readonly string _asfalt;
        public UCKatliAsfalt(string asfalt)
        {
            InitializeComponent();
            _asfalt = asfalt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCAsfaltVeri ucc = new(_asfalt);
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
            UCAsfaltDokum ucc = new(_asfalt);
            addControls(ucc);
        }

        private void UCKatliAsfalt_Load(object sender, EventArgs e)
        {
            Form parent = this.FindForm();

            this.Width = parent.Width - 400;
            this.Height = parent.Height - 300;
            panelContainer.Width = parent.Width - 400;
            panelContainer.Height = parent.Height - 300;
        }
    }
}
