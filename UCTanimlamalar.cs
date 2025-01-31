using YatirimTakip;
using YatirimTakip.Models;

namespace WinFormsApp1
{
    internal partial class UCTanimlamalar : UserControl
    {
        private readonly User _user;
        public UCTanimlamalar(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ImalatTanimlama imalat = new())
            {
                imalat.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (YatirimTanimlama yatirim = new())
            {
                yatirim.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SpiralBoruTanimlama spiralBoru = new())
            {
                spiralBoru.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (IlceTanimlama ilce = new())
            {
                ilce.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (KoyTanimlama koy = new())
            {
                koy.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (MezraTanimlama mezra = new())
            {
                mezra.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (YolAgiTanimlama yolAgi = new())
            {
                yolAgi.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (PersonelTanimlama pers = new())
            {
                pers.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (MakineTanimlama makine = new(_user))
            {
                makine.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
