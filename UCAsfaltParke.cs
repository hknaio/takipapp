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
    public partial class UCAsfaltParke : UserControl
    {
        public UCAsfaltParke()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCParke ucc = new();
            addControls(ucc);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCBordur ucc = new();
            addControls(ucc);
        }
        private void addControls(UserControl uc)
        {
            panelContainer.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void UCAsfaltParke_Load(object sender, EventArgs e)
        {
            Form parent = this.FindForm();

            this.Width = parent.Width - 500;
            this.Height = parent.Height - 400;
            panelContainer.Width = parent.Width - 500;
            panelContainer.Height = parent.Height - 400;
        }
    }
}
