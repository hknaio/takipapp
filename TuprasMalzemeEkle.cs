using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class TuprasMalzemeEkle : Form
    {
        private AppDbContext _dbContext;
        private string _tur;

        public TuprasMalzemeEkle(string tur)
        {
            InitializeComponent();
            _tur = tur;
        }
        private void TuprasMalzemeEkle_Load(object sender, EventArgs e)
        {
            label7.Text = _tur;
            _dbContext = new AppDbContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                try
                {
                    _dbContext.Add(new TuprasMalzeme
                    {
                        Tur = _tur,
                        Tarih = dtTarih.Value.Date,
                        SiparisNo = Convert.ToInt32(txtSiparis.Text),
                        TuprasNet = Convert.ToInt32(txtTupras.Text),
                        IlOzelNet = Convert.ToInt32(txtOzelIdare.Text),
                        TartimNo =  Convert.ToInt32(txtTartim.Text),
                        Fark = Convert.ToInt32(txtFark.Text)
                    });

                    _dbContext.SaveChanges();
                }

                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

            txtSiparis.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool IsModelValid()
        {
            if (txtSiparis.Text != string.Empty && txtTupras.Text != string.Empty && txtOzelIdare.Text != string.Empty
                && txtTartim.Text != string.Empty && txtFark.Text != string.Empty)
            {
                return true;
            }

            return false;
        }
    }
}
