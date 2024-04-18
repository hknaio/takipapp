using System.Data.Common;
using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class PurEmanetEkle : Form
    {
        private AppDbContext? _dbContext;
        public PurEmanetEkle()
        {
            InitializeComponent();
        }

        private void PurEmanetEkle_Load(object sender, EventArgs e)
        {
            txtMiktar.Mask = "0000";
            txtMiktar.Text = "0";
            _dbContext = new AppDbContext();
            _dbContext.Koys.Where(k => k.Ilce.Adi == cmbIlce.Text).Load();
            _dbContext.Ilces.Load();
            _dbContext.Imalats.Load();
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
            cmbKoy.DataSource = _dbContext.Koys.Local.ToBindingList();
            cmbKoy.DisplayMember = "Adi"; cmbKoy.Invalidate();
            cmbImalat.DataSource = _dbContext.Imalats.Local.ToBindingList();
            cmbImalat.DisplayMember = "Isim"; cmbImalat.Invalidate();
            cmbSpiral.Visible = false;
            txtBoruMetre.Visible = false;
            label6.Visible = false;
            chkMezraList.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                var ilce = (Ilce)cmbIlce.SelectedValue!;
                var koy = (Koy)cmbKoy.SelectedValue!;
                var imalat = (Imalat)cmbImalat.SelectedValue!;

                SpiralBoru? spiralBoru = new();

                if (cmbImalat.Text == "Spiral Boru")
                {
                    spiralBoru = _dbContext?.SpiralBorus.Where(b => b.Cap == Convert.ToInt32(cmbSpiral.Text)).FirstOrDefault();

                    if (spiralBoru != null)
                    {
                        spiralBoru.StokMiktar--;
                        _dbContext?.Update(spiralBoru);
                    }
                }

                try
                {
                    var purEmanet = new PurEmanet
                    {
                        Tarih = dtTarih.Value,
                        IlceId = ilce!.ID,
                        KoyId = koy!.ID,
                        ImalatId = imalat!.ID,
                        Miktar = cmbImalat.Text == "Spiral Boru" ? Convert.ToInt32(txtBoruMetre.Text)
                        : Convert.ToInt32(txtMiktar.Text),
                        Tutar = cmbImalat.Text == "Spiral Boru" ? spiralBoru!.BirimFiyat * Convert.ToInt32(txtBoruMetre.Text)
                        : imalat.BirimFiyat * Convert.ToInt32(txtMiktar.Text),
                        SpiralBoruId = cmbImalat.Text == "Spiral Boru" ? spiralBoru!.ID : null
                    };

                    foreach (var mezra in chkMezraList.CheckedItems)
                    {
                        var purEmanetMezra = new PurEmanetMezra
                        {
                            PurEmanet = purEmanet,
                            Mezra = (Mezra)mezra,
                        };
                        _dbContext!.PurEmanetMezras.Add(purEmanetMezra);
                    }

                    _dbContext!.PurEmanets.Add(purEmanet);

                    _dbContext.SaveChanges();
                    this.Close();
                }
                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }
            }

            txtMiktar.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsModelValid()
        {
            if (cmbImalat.Text != string.Empty && cmbIlce.Text != string.Empty
                && cmbKoy.Text != string.Empty)
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

        private void cmbIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbIlce.Text;

            var koyList = _dbContext!.Koys.Where(k => k.Ilce.Adi == selectedItem).ToList();

            if (koyList != null)
            {
                cmbKoy.DataSource = koyList;
            }
        }

        private void cmbImalat_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = cmbImalat.Text;

            if (selectedItem == "Spiral Boru")
            {
                cmbSpiral.Visible = txtBoruMetre.Visible = label6.Visible = true;
                cmbSpiral.DisplayMember = "Cap"; cmbSpiral.Invalidate();
                txtMiktar.Visible = false;

                var spiralBoruList = _dbContext?.SpiralBorus.ToList();

                if (spiralBoruList != null)
                {
                    cmbSpiral.DataSource = spiralBoruList;
                }
            }
        }

        private void chkMezra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMezra.Checked)
            {
                chkMezraList.Visible = true;
                var mezralar = _dbContext!.Mezras.Where(m => m.Koy.Adi == cmbKoy.Text).ToList();
                ListBox checkBoxList = chkMezraList;
                checkBoxList.DataSource = mezralar;
                checkBoxList.DisplayMember = "Adi";
                checkBoxList.ValueMember = "Adi";
            }
            else
            {
                chkMezraList.Visible = false;
            }
        }

        private void cmbKoy_SelectedIndexChanged(object sender, EventArgs e)
        {
            chkMezraList.ClearSelected();
            chkMezra.Checked = false;
            chkMezraList.Visible = false;

        }
    }
}
