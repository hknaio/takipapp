
using YatirimTakip;
using YatirimTakip.Models;

namespace WinFormsApp1
{
    internal partial class UCRaporlar : UserControl
    {
        private readonly User _user;
        public UCRaporlar(User user)
        {
            InitializeComponent();
            _user = user;
        }
        private void UCRaporlar_Load(object sender, EventArgs e)
        {
            if (_user.Role == "Yol" || _user.Role == "Admin" || _user.Role == "Asfalt" || _user.Role == "Sanat"
             || _user.Role == "Yonetim" || _user.Role == "Rapor")
            {
                btnFaaliyetKoySu.Visible = btnFaaliyetSu.Visible = btnSuButce.Visible = false;
                btnFaaliyetKoyTarimsal.Visible = btnFaaliyetTarimsal.Visible = btnTarimsalButce.Visible = false;
            }

            if (_user.Role == "Su" || _user.Role == "Admin" || _user.Role == "Yonetim" || _user.Role == "Rapor")
            {
                button1.Visible = button2.Visible = button4.Visible = button5.Visible = false;
                btnFaaliyetKoyTarimsal.Visible = btnFaaliyetTarimsal.Visible = btnTarimsalButce.Visible = false;
                btnSuButce.Location = button5.Location;
                btnFaaliyetSu.Location = button1.Location;
                btnFaaliyetKoySu.Location = button2.Location;
            }

            if (_user.Role == "Tarımsal" || _user.Role == "Admin" || _user.Role == "Yonetim" || _user.Role == "Rapor")
            {
                button1.Visible = button2.Visible = button4.Visible = button5.Visible = false;
                btnFaaliyetKoySu.Visible = btnFaaliyetSu.Visible = btnSuButce.Visible = false;
                btnTarimsalButce.Location = button5.Location;
                btnFaaliyetTarimsal.Location = button1.Location;
                btnFaaliyetKoyTarimsal.Location = button2.Location;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FaaliyetRaporu yeniProje = new())
            {
                yeniProje.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnProgramRaporu_Click(object sender, EventArgs e)
        {
            using (RprProgram programRaporu = new())
            {
                programRaporu.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (RprButce butce = new())
            {
                butce.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FaaliyetRaporuKoy faaliyetRaporuKoy = new())
            {
                faaliyetRaporuKoy.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            using (RprIlceYatirimIcmal rprIlceYatirim = new())
            {
                rprIlceYatirim.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (RprBilgiNotu rprBilgiNotu = new())
            {
                rprBilgiNotu.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (PuremanetRapor rprPuremanet = new())
            {
                rprPuremanet.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnTarimsalButce_Click(object sender, EventArgs e)
        {
            using (RprButceTarimsal butce = new())
            {
                butce.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnFaaliyetTarimsal_Click(object sender, EventArgs e)
        {
            using (FaaliyetRaporuTarimsal yeniProje = new())
            {
                yeniProje.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnFaaliyetKoyTarimsal_Click(object sender, EventArgs e)
        {
            using (FaaliyetRaporuKoyTarimsal yeniProje = new())
            {
                yeniProje.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnSuButce_Click(object sender, EventArgs e)
        {
            using (RprButceSu butce = new())
            {
                butce.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnFaaliyetSu_Click(object sender, EventArgs e)
        {
            using (FaaliyetRaporuSu yeniProje = new())
            {
                yeniProje.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnFaaliyetKoySu_Click(object sender, EventArgs e)
        {
            using (FaaliyetRaporuKoySu faaliyetRaporuKoy = new())
            {
                faaliyetRaporuKoy.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
