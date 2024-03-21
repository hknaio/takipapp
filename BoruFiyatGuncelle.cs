using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class BoruFiyatGuncelle : Form
    {
        private AppDbContext _dbContext;
        private int _selected;
        public BoruFiyatGuncelle(double guncelBirimFiyat, int selected)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            label2.Text = guncelBirimFiyat.ToString();
            _selected = selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected = _dbContext.SpiralBorus.Where(s => s.ID == _selected).FirstOrDefault();

            if (selected != null)
            {
                selected.BirimFiyat = Convert.ToDouble(txtYeniMiktar.Text);

                try
                {
                    _dbContext.Update(selected);
                    _dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }

                this.Close();
            }

            txtYeniMiktar.Focus();
        }

        private void BoruFiyatGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
