
using YatirimTakip;

namespace WinFormsApp1
{
    public partial class UCRaporlar : UserControl
    {
        public UCRaporlar()
        {
            InitializeComponent();
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
    }
}
