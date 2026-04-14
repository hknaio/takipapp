using System.ComponentModel;
using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using YatirimTakip.Models;

namespace WinFormsApp1
{
    internal partial class PurEmanetEkleTarimsal : Form
    {
        private AppDbContext? _dbContext;
        private BindingList<Spiral> spiralList = new();
        private User _user;
        public PurEmanetEkleTarimsal(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void PurEmanetEkleTarimsal_Load(object sender, EventArgs e)
        {
            txtMiktar.Text = "0";
            _dbContext = new AppDbContext();
            _dbContext.Koys.Where(k => k.Ilce.Adi == cmbIlce.Text).Load();
            _dbContext.Imalats.Where(i => i.Mudurluk == "Tarımsal Hizmetler").Load();

            var ilces = _dbContext.UserIlces.Where(u => u.User.ID == _user.ID).Select(u => u.IlceId).ToList();
            List<Ilce> ilceList = new();

            ilces.ForEach(l => ilceList.Add(_dbContext.Ilces.Where(i => i.ID == l).FirstOrDefault()));

            var users = _dbContext.Users.ToList();

            var operators = users.Where(u => u.Role == "Operatör").ToList();
            operators.Add(new User { Isim = "-", Soyisim = "-" });
            cmbOperator.DataSource = operators;
            cmbOperator.DisplayMember = "IsimSoyisim"; cmbOperator.Invalidate();

            var talepEdens = users.Where(u => u.Birim == "Tarımsal Hizmetler").ToList();
            talepEdens.Add(new User { Isim = "-", Soyisim = "-" });
            cmbTalepEden.DataSource = talepEdens;
            cmbTalepEden.DisplayMember = "IsimSoyisim"; cmbTalepEden.Invalidate();

            var ismakinesis = _dbContext.IsMakinesis.ToList();
            ismakinesis.Add(new IsMakinesi { Plaka = "--" });
            cmbIsMakinesi.DataSource = ismakinesis;
            cmbIsMakinesi.DisplayMember = "Plaka"; cmbIsMakinesi.Invalidate();


            cmbIlce.DataSource = ilceList;
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
            cmbKoy.DataSource = _dbContext.Koys.Local.ToBindingList();
            cmbKoy.DisplayMember = "Adi"; cmbKoy.Invalidate();
            cmbImalat.DataSource = _dbContext.Imalats.Local.ToBindingList();
            cmbImalat.DisplayMember = "DisplayText"; cmbImalat.Invalidate();
            cmbSpiral.Visible = false;
            txtBoruMetre.Visible = false;
            label6.Visible = false;
            chkMezraList.Visible = false;
            btnBoruEkle.Visible = false;
            dgBoru.Visible = false;
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
                    foreach (DataGridViewRow item in dgBoru.Rows)
                    {
                        var cap = item.Cells["Cap"].Value;
                        var miktar = item.Cells["Miktar"].Value;

                        spiralBoru = _dbContext?.SpiralBorus.Where(b => b.Cap == Convert.ToInt32(cap) && b.Mudurluk == "Tarımsal Hizmetler").FirstOrDefault();

                        if (spiralBoru != null)
                        {
                            spiralBoru.StokMiktar -= Convert.ToInt32(miktar);
                            _dbContext?.Update(spiralBoru);
                        }

                        var purEmanet = new PurEmanet
                        {
                            Tarih = dtTarih.Value,
                            IlceId = ilce!.ID,
                            KoyId = koy!.ID,
                            ImalatId = imalat!.ID,
                            Miktar = Convert.ToDouble(miktar),
                            Tutar = Math.Round(spiralBoru!.BirimFiyat * Convert.ToDouble(miktar), 2),
                            SpiralBoruId = spiralBoru!.ID,
                            TalepEdenPersonel = cmbTalepEden.Text,
                            Operator = cmbOperator.Text,
                            IsMakinesi = cmbIsMakinesi.Text,
                            User = _user.UserName
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
                    }

                    try
                    {
                        _dbContext.SaveChanges();
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }
                }

                else
                {
                    try
                    {
                        var purEmanet = new PurEmanet
                        {
                            Tarih = dtTarih.Value,
                            IlceId = ilce!.ID,
                            KoyId = koy!.ID,
                            ImalatId = imalat!.ID,
                            Miktar = Convert.ToDouble(txtMiktar.Text),
                            Tutar = Math.Round(imalat.BirimFiyat * Convert.ToDouble(txtMiktar.Text), 2),
                            SpiralBoruId = null,
                            TalepEdenPersonel = cmbTalepEden.Text,
                            Operator = cmbOperator.Text,
                            IsMakinesi = cmbIsMakinesi.Text,
                            User = _user.UserName
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
                btnBoruEkle.Visible = true;
                dgBoru.Visible = true;

                var spiralBoruList = _dbContext?.SpiralBorus.Where(s => s.Mudurluk == "Tarımsal Hizmetler").ToList();

                if (spiralBoruList != null)
                {
                    cmbSpiral.DataSource = spiralBoruList;
                }
            }

            else
            {
                txtMiktar.Visible = true;
                cmbSpiral.Visible = txtBoruMetre.Visible = label6.Visible = false;
                btnBoruEkle.Visible = false;
                dgBoru.Visible = false;
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

        private void btnBoruEkle_Click(object sender, EventArgs e)
        {
            if (cmbSpiral.Text != string.Empty && txtBoruMetre.Text != string.Empty)
            {
                var spiral = new Spiral(cmbSpiral.Text,"", "", Convert.ToDouble(txtBoruMetre.Text));
                spiralList.Add(spiral);
                dgBoru.DataSource = null;
                dgBoru.DataSource = spiralList;
                OrderColumns();
                txtBoruMetre.Clear();
            }
        }
        private void OrderColumns()
        {
            dgBoru.Columns["Cap"].DisplayIndex = 0;
            dgBoru.Columns["Miktar"].DisplayIndex = 1;
            dgBoru.Columns["Sil"].DisplayIndex = 2;
        }

        private void dgBoru_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dgBoru.Columns[0].Index)
            {
                dgBoru.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
