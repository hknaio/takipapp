using System.Data;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class YatirimUygulama : Form
    {
        private readonly int _id;
        private AppDbContext _dbContext;
        public YatirimUygulama(int id)
        {
            InitializeComponent();
            _id = id;
        }
        private void YatirimUygulama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            var proje = _dbContext.Projes.Where(p => p.ID == _id).FirstOrDefault();

            if (proje is not null)
            {
                label2.Text = proje.Adi;
                txtSure.Text = proje.Sure.ToString();

                formatDtps(proje);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void formatDtps(Proje proje)
        {
            if (proje.IseBaslamaTarihi is null)
            {
                dtpIseBaslama.CustomFormat = "          ";
                dtpIseBaslama.Format = DateTimePickerFormat.Custom;
                dtpBitisTarihi.CustomFormat = "          ";
                dtpBitisTarihi.Format = DateTimePickerFormat.Custom;
            }

            else
            {
                dtpIseBaslama.Value = proje.IseBaslamaTarihi.Value;
                dtpBitisTarihi.Value = proje.IsBitisTarihi.Value;
            }
        }
        private void dtpIseBaslama_ValueChanged(object sender, EventArgs e)
        {
            dtpIseBaslama.CustomFormat = "dd MMMM yyyy dddd";
        }

        private void txtSure_TextChanged(object sender, EventArgs e)
        {
            dtpIseBaslama.CustomFormat = "dd MMMM yyyy dddd";
            dtpBitisTarihi.Value = dtpIseBaslama.Value.AddDays(Convert.ToDouble(txtSure.Text));
            dtpBitisTarihi.CustomFormat = "dd MMMM yyyy dddd";           
        }
    }
}
