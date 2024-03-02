using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
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
    }
}
