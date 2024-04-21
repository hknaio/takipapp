using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class BirimFiyatGuncelle : Form
    {
        private AppDbContext _dbContext;
        private int _selected;
        public BirimFiyatGuncelle(double guncelFiyat, int selected, DateTime guncelTarih)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            label2.Text = guncelFiyat.ToString();
            label6.Text = guncelTarih.ToShortDateString();
            _selected = selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected = _dbContext.Imalats.Where(s => s.ID == _selected).FirstOrDefault();

            if (selected != null && txtYeniMiktar.Text != string.Empty &&
                selected.BirimFiyat != Convert.ToDouble(txtYeniMiktar.Text) && 
                 selected.FiyatGecerlilikBaslangicTarihi.Date != dtpYeniTarih.Value.Date)
            {              

                try
                {
                    var buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show("Birim Fiyat : " + selected.BirimFiyat + " ile " + txtYeniMiktar.Text + "\n" +
                                                "Geçerlilik Tarihi: " + selected.FiyatGecerlilikBaslangicTarihi.Date.ToShortDateString() + " ile " + dtpYeniTarih.Value.Date.ToShortDateString() +
                                                "\nDeğiştirmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Information);
                    
                    if (result == DialogResult.Yes)
                    {
                        _dbContext.ImalatBirimFiyatTarihGecmisis.Add(new ImalatBirimFiyatTarihGecmisi
                        {
                            BirimFiyat = selected.BirimFiyat,
                            GecerlilikBaslangicTarihi = selected.FiyatGecerlilikBaslangicTarihi,
                            Imalat = selected,
                        });

                        selected.BirimFiyat = Convert.ToDouble(txtYeniMiktar.Text);
                        selected.FiyatGecerlilikBaslangicTarihi = dtpYeniTarih.Value.Date;

                        _dbContext.Update(selected);
                        _dbContext.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }

                this.Close();
            }

            txtYeniMiktar.Focus();
        }

        private void BirimFiyatGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
