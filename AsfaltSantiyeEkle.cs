using System.ComponentModel;
using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class AsfaltSantiyeEkle : Form
    {
        private AppDbContext _dbContext;
        public AsfaltSantiyeEkle()
        {
            InitializeComponent();
        }

        private void AsfaltSantiyeEkle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Ilces.Load();
            _dbContext.Koys.Where(k => k.Ilce.Adi == cmbIlce.Text).Load();
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
            cmbKoy.DataSource = _dbContext.Koys.Local.ToBindingList();
            cmbKoy.DisplayMember = "Adi"; cmbKoy.Invalidate();
            cmbMezra.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                var ilce = (Ilce)cmbIlce.SelectedValue!;
                var koy = (Koy)cmbKoy.SelectedValue!;
                var mezra = (Mezra)cmbMezra.SelectedValue!;

                try
                {
                    _dbContext.Add(new AsfaltSantiye
                    {
                        Tarih = dtTarih.Value.Date,
                        IlceId = ilce!.ID,
                        KoyId = koy is not null ? koy.ID : 0,
                        MezraId = mezra is not null && chkMezra.Checked ? mezra.ID : null,
                        Ton = Convert.ToInt32(txtTon.Text)
                    });

                    _dbContext.SaveChanges();
                }

                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

            cmbIlce.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsModelValid()
        {
            if ((cmbIlce.Text != string.Empty || cmbKoy.Text != string.Empty || cmbMezra.Text != string.Empty)
                && txtTon.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void AsfaltSantiyeEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbIlce.Text;

            cmbKoy.Text = string.Empty;

            var koyList = _dbContext!.Koys.Where(k => k.Ilce.Adi == selectedItem).ToList();

            if (koyList != null)
            {
                cmbKoy.DataSource = koyList;
            }
        }

        private void cmbKoy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbKoy.Text;

            cmbMezra.Text = string.Empty;

            var mezraList = _dbContext!.Mezras.Where(k => k.Koy.Adi == selectedItem).ToList();

            if (mezraList != null)
            {
                cmbMezra.DataSource = mezraList;
                cmbMezra.DisplayMember = "Adi"; cmbMezra.Invalidate();
            }
        }

        private void chkMezra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMezra.Checked)
            {
                cmbMezra.Visible = true;
                var mezralar = _dbContext!.Mezras.Where(m => m.Koy.Adi == cmbKoy.Text).ToList();
                cmbMezra.DataSource = mezralar;
                cmbMezra.DisplayMember = "Adi"; cmbMezra.Invalidate();
            }
            else
            {
                cmbMezra.Visible = false;
            }
        }
    }
}
