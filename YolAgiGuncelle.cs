using WinFormsApp1.Data;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class YolAgiGuncelle : Form
    {
        private AppDbContext _dbContext;
        private readonly int _selected;

        public YolAgiGuncelle(int selected)
        {
            InitializeComponent();
            _selected = selected;
        }
        private void YolAgiGuncelle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();

            var yolAgi = _dbContext.YolAgis
                .Include(y => y.Ilce).Where(y => y.ID == _selected).FirstOrDefault();

            if (yolAgi is not null)
            {
                label4.Text = yolAgi.Ilce.Adi + " " + "İlçesi Yol Ağı Bilgileri ";
                nmBSK.Value =(decimal)yolAgi.BSK;
                nmAsfalt.Value = (decimal)yolAgi.Asfalt;
                nmStabilize.Value = (decimal)yolAgi.Stabilize;
                nmKilitli.Value = (decimal)yolAgi.KilitParke;
                nmBeton.Value = (decimal)yolAgi.BetonYol;
                label2.Text = yolAgi.ToplamAg.ToString("F2");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var yolAgi = _dbContext.YolAgis
                .Include(y => y.Ilce).Where(y => y.ID == _selected).FirstOrDefault();            

            if (YolAgiToplamKontrol(yolAgi, (double)nmBSK.Value, (double)nmAsfalt.Value, (double)nmBeton.Value, (double)nmStabilize.Value,(double)nmKilitli.Value))
            {
                yolAgi.BSK = (double)nmBSK.Value;
                yolAgi.Asfalt = (double)nmAsfalt.Value;
                yolAgi.BetonYol = (double)nmBeton.Value;
                yolAgi.Stabilize = (double)nmStabilize.Value;
                yolAgi.KilitParke = (double)nmKilitli.Value;

                try
                {
                    _dbContext.Update(yolAgi);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }

                this.Close();
            }

            else
            {
                nmBSK.Value = (decimal)yolAgi.BSK;
                nmAsfalt.Value = (decimal)yolAgi.Asfalt;
                nmStabilize.Value = (decimal)yolAgi.Stabilize;
                nmKilitli.Value = (decimal)yolAgi.KilitParke;
                nmBeton.Value = (decimal)yolAgi.BetonYol;

                MessageBox.Show("Yol Ağı Toplam Hatalı.. Lütfen tekrar giriş yapınız..", "Dikkat!", MessageBoxButtons.OK);
            }

            nmBSK.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool YolAgiToplamKontrol(YolAgi yolAgi, double bsk, double asfalt, double beton, double stabilize,
            double kilit)
        {
            var sonuc = yolAgi.ToplamAg == bsk + asfalt + beton + stabilize + kilit;

            return sonuc;
        }
        private bool IsModelValid()
        {
            return false;
        }

        private void YolAgiGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
