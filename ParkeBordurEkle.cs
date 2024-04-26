using WinFormsApp1.Data;
using System.Data.Entity;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class ParkeBordurEkle : Form
    {
        private AppDbContext _dbContext;
        private readonly string _malzeme;
        public ParkeBordurEkle(string malzeme)
        {
            InitializeComponent();
            _malzeme = malzeme;
        }

        private void ParkeBordurEkle_Load(object sender, EventArgs e)
        {
            txtMiktar.Mask = "0000";
            txtMiktar.Text = "0";
            lblBirim.Text = _malzeme == "Parke" ? "m2" : "m";
            _dbContext = new AppDbContext();
            _dbContext.Koys.Where(k => k.Ilce.Adi == cmbIlce.Text).Load();
            _dbContext.Ilces.Load();
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
            cmbKoy.DataSource = _dbContext.Koys.Local.ToBindingList();
            cmbKoy.DisplayMember = "Adi"; cmbKoy.Invalidate();

        }

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbIlce.Text;

            var koyList = _dbContext!.Koys.Where(k => k.Ilce.Adi == selectedItem).ToList();

            if (koyList != null)
            {
                cmbKoy.DataSource = koyList;
            }
        }

        private void ParkeBordurEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                var koy = (Koy)cmbKoy.SelectedValue!;
                var personel = cmbPersonel.SelectedItem;
                var parke = _dbContext!.ParkeBordurs.Where(p => p.Malzeme == "Parke").FirstOrDefault();

                try
                {
                    _dbContext.ParkeBordurIs.Add(new ParkeBordurIs 
                    { 
                        Miktar = Convert.ToInt32(txtMiktar.Text),
                        Birim = lblBirim.Text,
                        KoyAdi = koy.Adi,
                        TalepEden = personel.ToString(),
                        GidisTarihi = dtTarih.Value.Date,
                        AracPlakasi = txtPlaka.Text,
                        ParkeBordurTip = ParkeBordurTip.Parke,
                    });

                    parke.StokMiktar -= Convert.ToInt32(txtMiktar.Text);

                    _dbContext?.Update(parke);

                    _dbContext.SaveChanges();
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

            }

            txtMiktar.Focus();

        }

        private bool IsModelValid()
        {
            if (cmbPersonel.Text != string.Empty && cmbIlce.Text != string.Empty
                && cmbKoy.Text != string.Empty && txtMiktar.Text != "0"
                && txtPlaka.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void ClearTexts()
        {
            foreach (Control c in this.Controls)
            {
                if (c is ComboBox or MaskedTextBox)
                {
                    c.Text = string.Empty;
                }
            }
        }
    }
}
