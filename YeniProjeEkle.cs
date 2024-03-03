
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class YeniProjeEkle : Form
    {
        public YeniProjeEkle()
        {
            InitializeComponent();
        }

        public void ReceiveData(List<YatirimProgrami> programList)
        {
            if (programList.Count > 0)
            {
                dataGridView1.DataSource = programList;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (ProgramlarSec programlar = new(this))
            {
                programlar.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
