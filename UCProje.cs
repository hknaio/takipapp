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
    public partial class UCProje : UserControl
    {
        public UCProje()
        {
            InitializeComponent();
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            using (YeniProjeEkle yeniProje = new())
            {
                yeniProje.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void UCProje_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            using (YatirimUygulama yatirim = new())
            {
                yatirim.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
