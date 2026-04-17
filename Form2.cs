using YatirimTakip;
using YatirimTakip.Models;

namespace WinFormsApp1
{
    internal partial class AnaEkran : Form
    {
        private readonly User _user;
        public AnaEkran(User user)
        {
            InitializeComponent();
            _user = user;
        }
        private void AnaEkran_Load(object sender, EventArgs e)
        {
            label2.Text = _user.Isim + " " + _user.Soyisim;
            //if (DateTime.Now.Day == 31 && DateTime.Now.Month == 12)
            //{
            //    var devir = new YatirimProgramiDevir();
            //    devir.ProgramDevret();
            //}
            SetVisibilities();
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
            UCYolYapim ucc = new(_user);
            addControls(ucc);
        }

        private void btnTanimlama_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "TANIMLAMALAR";
            slidePanel(button1);
            UCTanimlamalar ucc = new(_user);
            addControls(ucc);
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "RAPORLAR";
            slidePanel(button1);
            UCRaporlar ucc = new(_user);
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
            UCYolYapimSanat ucc = new(_user);
            addControls(ucc);
        }

        private void SetVisibilities()
        {
            if (_user.Role == "Asfalt")
            {
                //button1.Visible = false;
                var asfaltOldLoc = btnAsfaltYapim.Location;
                //btnAsfaltYapim.Location = button1.Location;
                btnSanatYapilari.Visible = false;
                btnTanimlama.Visible = false;
                button3.Visible = false;
                btnSu.Visible = false;
                btnDestek.Visible = false;
                btnRapor.Location = btnSanatYapilari.Location;
            }

            if (_user.Role == "Yol")
            {
                var asfaltOldLoc = btnAsfaltYapim.Location;
                btnSanatYapilari.Visible = false;
                btnTanimlama.Visible = false;
                btnAsfaltYapim.Visible = false;
                button3.Visible = false;
                btnSu.Visible = false;
                btnDestek.Visible = false;
                btnRapor.Location = asfaltOldLoc;
            }

            if (_user.Role == "Sanat")
            {
                button1.Visible = false;
                var asfaltOldLoc = btnAsfaltYapim.Location;
                btnAsfaltYapim.Visible = false;
                btnTanimlama.Visible = false;
                button3.Visible = false;
                btnSu.Visible = false;
                btnDestek.Visible = false;
                btnRapor.Location = asfaltOldLoc;
                btnSanatYapilari.Location = button1.Location;
            }

            if (_user.Role == "Su")
            {
                button1.Visible = false;
                var yolOldLoc = button1.Location;
                btnSanatYapilari.Visible = false;
                btnTanimlama.Visible = false;
                btnAsfaltYapim.Visible = false;
                btnSu.Location = yolOldLoc;
                button3.Visible = false;
                btnDestek.Visible = false;
                btnRapor.Location = btnAsfaltYapim.Location;
            }

            if (_user.Role == "Tarımsal")
            {
                button1.Visible = false;
                var yolOldLoc = button1.Location;
                btnSanatYapilari.Visible = false;
                btnTanimlama.Visible = false;
                btnAsfaltYapim.Visible = false;
                button3.Location = yolOldLoc;
                btnSu.Visible = false;
                btnDestek.Visible = false;
                btnRapor.Location = btnAsfaltYapim.Location;
            }

            if (_user.Role == "Destek" || _user.Role == "Kültür")
            {
                button1.Visible = false;
                var yolOldLoc = button1.Location;
                btnSanatYapilari.Visible = false;
                btnTanimlama.Visible = false;
                btnAsfaltYapim.Visible = false;
                button3.Visible = false;
                btnDestek.Location = yolOldLoc;
                btnSu.Visible = false;               
                btnRapor.Location = btnAsfaltYapim.Location;
            }

            if (_user.Role == "Rapor")
            {
                button1.Visible = false;
                var yolOldLoc = button1.Location;
                btnSanatYapilari.Visible = false;
                btnTanimlama.Visible = false;
                button3.Visible = false;
                btnSu.Visible = false;
                btnDestek.Visible = false;
                btnAsfaltYapim.Visible = false;
                btnRapor.Location = yolOldLoc;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "TARIMSAL HİZMETLER";
            slidePanel(button1);
            UCTarimsal ucc = new(_user);
            addControls(ucc);
        }

        private void btnSu_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "SU VE KANALİZASYON";
            slidePanel(button1);
            UCSu ucc = new(_user);
            addControls(ucc);
        }

        private void btnDestek_Click(object sender, EventArgs e)
        {
            lblTitle.Text = _user.Birim;
            slidePanel(button1);
            UCDestek ucc = new(_user);
            addControls(ucc);
        }
    }
}
