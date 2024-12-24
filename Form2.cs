using WinFormsApp1.Helpers;

namespace WinFormsApp1
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            //if (DateTime.Now.Day == 31 && DateTime.Now.Month == 12)
            //{
            //    var devir = new YatirimProgramiDevir();
            //    devir.ProgramDevret();
            //}
        }
        private void slidePanel(Button btn)
        {
            panelSide.Height = btn.Height;
            panelSide.Top = btn.Top;
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
            lblTitle.Text = "YOL YAPIM BAKIM ONARIM";
            slidePanel(button1);
            UCYolYapim ucc = new();
            addControls(ucc);
        }

        private void btnTanimlama_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "TANIMLAMALAR";
            slidePanel(button1);
            UCTanimlamalar ucc = new();
            addControls(ucc);
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "RAPORLAR";
            slidePanel(button1);
            UCRaporlar ucc = new();
            addControls(ucc);
        }

        private void btnAsfaltYapim_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "ASFALT YAPIM";
            slidePanel(button1);
            UCAsfalt ucc = new();
            addControls(ucc);
        }

        private void btnSanatYapilari_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "SANAT YAPILARI";
            slidePanel(button1);
            UCYolYapimSanat ucc = new();
            addControls(ucc);
        }
    }
}
