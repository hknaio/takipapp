using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Data;
using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class YatirimUygulama : Form
    {
        private readonly int _id;
        private AppDbContext _dbContext;
        private Proje _proje;
        public YatirimUygulama(int id)
        {
            InitializeComponent();
            _id = id;
        }
        private void YatirimUygulama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _proje = _dbContext.Projes.Where(p => p.ID == _id).FirstOrDefault();
            _dbContext.Hakedis.Where(h => h.Proje.ID == _id).Load();
            _dbContext.YatirimProgramis.Where(p => p.Proje.ID == _id).Load();
            dataGridView2.DataSource = _dbContext.Hakedis.Local.ToBindingList();
            dataGridView1.DataSource = _dbContext.YatirimProgramis.Local.ToBindingList();
            cmbDurum.DataSource = EnumList.EnumKeyValue<ProjeDurumu>();
            cmbDurum.DisplayMember = "Value";
            cmbDurum.ValueMember = "Key";
            OrderColumns();

            if (_proje is not null)
            {
                label2.Text = _proje.Adi;
                txtSure.Text = _proje.Sure.ToString() == "0" ? "" : _proje.Sure.ToString();
                txtYuklenici.Text = _proje.Yuklenici;
                cmbDurum.SelectedItem = _proje.Yuklenici is null ? ProjeDurumu.IhaleAsamasi : _proje.ProjeDurumu;
                txtSozlesmeBedeli.Text = _proje.SozlesmeBedeli.ToString("0.00");
                txtAciklama.Text = _proje.Aciklama;
                label13.Text = _proje.YaklasikMaliyet.ToString();
                lblToplamHakedis.Text = _proje.HakedisToplami.ToString();
                lblHakedisTahakkuk.Text = _proje.HakedisToplamTahakkuk.ToString();
                

                formatDtps(_proje);
            }
        }

        private void formatDtps(Proje proje)
        {
            if (proje.IseBaslamaTarihi is null)
            {
                dtpIseBaslama.CustomFormat = "          ";
                dtpIseBaslama.Format = DateTimePickerFormat.Custom;
            }

            else
            {
                dtpIseBaslama.Value = proje.IseBaslamaTarihi.Value;
                dtpKesinKabul.Value = proje.KesinKabulTarihi.Value;
            }

            if (proje.IsBitisTarihi is null)
            {
                dtpBitisTarihi.CustomFormat = "          ";
                dtpBitisTarihi.Format = DateTimePickerFormat.Custom;
            }

            else
            {
                dtpBitisTarihi.Value = proje.IsBitisTarihi.Value;
            }

            if (proje.GeciciKabulTarihi is null)
            {
                dtpGeciciKabul.CustomFormat = "          ";
                dtpGeciciKabul.Format = DateTimePickerFormat.Custom;
            }

            else
            {
                dtpGeciciKabul.Value = proje.GeciciKabulTarihi.Value;
            }

            if (proje.KesinKabulTarihi is null)
            {
                dtpKesinKabul.CustomFormat = "          ";
                dtpKesinKabul.Format = DateTimePickerFormat.Custom;
            }

            else
            {
                dtpKesinKabul.Value = proje.KesinKabulTarihi.Value;
            }
        }
        private void dtpIseBaslama_ValueChanged(object sender, EventArgs e)
        {
            dtpIseBaslama.CustomFormat = "dd MMMM yyyy dddd";
        }

        private void txtSure_TextChanged(object sender, EventArgs e)
        {
            if (dtpIseBaslama.Value.Date.Year > 1970)
            {
                dtpIseBaslama.CustomFormat = "dd MMMM yyyy dddd";
                dtpBitisTarihi.Value = dtpIseBaslama.Value.AddDays(Convert.ToDouble(txtSure.Text));
                dtpBitisTarihi.CustomFormat = "dd MMMM yyyy dddd";
            }

            else
            {
                dtpIseBaslama.Focus();
            }

        }

        private void dtpGeciciKabul_ValueChanged(object sender, EventArgs e)
        {
            dtpGeciciKabul.CustomFormat = "dd MMMM yyyy dddd";
        }

        private void dtpKesinKabul_ValueChanged(object sender, EventArgs e)
        {
            dtpKesinKabul.CustomFormat = "dd MMMM yyyy dddd";
        }

        private void YatirimUygulama_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void txtSozlesmeBedeli_Leave(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(txtSozlesmeBedeli.Text, out value))
                txtSozlesmeBedeli.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                txtSozlesmeBedeli.Text = string.Empty;
        }

        private void btnHakedisEkle_Click(object sender, EventArgs e)
        {
            if (txtHakedis.Text != string.Empty && txtHakedisMiktar.Text != string.Empty)
            {
                try
                {                    
                    var miktar = txtHakedisMiktar.Text.Remove(0, 1);

                    _dbContext.Hakedis.Add(new Hakedis
                    {
                        Adi = txtHakedis.Text,
                        Miktar = Convert.ToDouble(miktar),
                        Proje = _proje
                    });

                    _proje.HakedisToplami += Convert.ToDouble(txtHakedisMiktar.Text.Remove(0, 1));
                    _proje.HakedisToplamTahakkuk = _proje.HakedisToplami * 1.2;
                    _dbContext.Projes.Update(_proje);

                    _dbContext.SaveChanges();
                    dataGridView2.Refresh();

                    lblToplamHakedis.Text = _proje.HakedisToplami.ToString();
                    lblHakedisTahakkuk.Text = _proje.HakedisToplamTahakkuk.ToString();
                    txtHakedis.Text = txtHakedisMiktar.Text = string.Empty;
                }

                catch (Exception)
                {

                }

            }

            txtHakedis.Focus();
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtHakedisMiktar_Leave(object sender, EventArgs e)
        {
            double value;
            if (double.TryParse(txtHakedisMiktar.Text, out value))
                txtHakedisMiktar.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            else
                txtHakedisMiktar.Text = string.Empty;
        }

        private void OrderColumns()
        {
            dataGridView2.Columns["ID"].DisplayIndex = 0;
            dataGridView2.Columns["No"].DisplayIndex = 1;
            dataGridView2.Columns["HakedisMiktari"].DisplayIndex = 2;
            dataGridView2.Columns["Sil"].DisplayIndex = 3;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView2.Columns[0].Index)
            {              
                var hakedisId = dataGridView2.CurrentRow.Cells["ID"].Value;
                var hakedis = _dbContext!.Hakedis.Where(i => i.ID == (int)hakedisId).FirstOrDefault();

                if (hakedis != null)
                {
                    try
                    {
                        _proje.HakedisToplami -= hakedis.Miktar;
                        _proje.HakedisToplamTahakkuk = _proje.HakedisToplami * 1.2;
                        _dbContext.Projes.Update(_proje);

                        _dbContext.Hakedis.Remove(hakedis);
                        _dbContext.SaveChanges();
                        dataGridView2.Refresh();

                        lblToplamHakedis.Text = _proje.HakedisToplami.ToString();
                        lblHakedisTahakkuk.Text = _proje.HakedisToplamTahakkuk.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bir şeyler ters gitti. Lütfen tekrar deneyin.", "Hata");
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[0].Index && e.RowIndex > -1)
            {
                var uygulama = dataGridView1.CurrentRow.Cells["Uygulama"].Value;
                var id = dataGridView1.CurrentRow.Cells["ProgramId"].Value;

                using (UygulamaGuncelle uygulamaGuncelle = new((double)uygulama, (int)id))
                {
                    uygulamaGuncelle.ShowDialog();
                    this.OnLoad(e);
                }
            }

            if (e.ColumnIndex ==
           dataGridView1.Columns[1].Index && e.RowIndex > -1)
            {
                var yaklasikMaliyet = dataGridView1.CurrentRow.Cells["YaklasikMaliyet"].Value;
                var id = dataGridView1.CurrentRow.Cells["ProgramId"].Value;

                using (MaliyetGuncelle maliyetGuncelle = new((double)yaklasikMaliyet, (int)id, _id))
                {
                    maliyetGuncelle.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                _proje.IseBaslamaTarihi = dtpIseBaslama.Value;
                _proje.Sure = Convert.ToInt32(txtSure.Text);
                _proje.IsBitisTarihi = dtpBitisTarihi.Value;
                _proje.GeciciKabulTarihi = dtpGeciciKabul.Value;
                _proje.KesinKabulTarihi = dtpKesinKabul.Value;
                _proje.Yuklenici = txtYuklenici.Text;
                _proje.ProjeDurumu = (ProjeDurumu)cmbDurum.SelectedValue!;
                if (_proje.ProjeDurumu == ProjeDurumu.Bitti)
                {
                    foreach (var program in _proje.Programis)
                    {
                        program.YatirimDurumu = Models.YatirimDurumu.Uygulandi;
                    }
                }
                _proje.Aciklama = txtAciklama.Text;
                _proje.SozlesmeBedeli = Convert.ToDouble(
                    txtSozlesmeBedeli.Text.Contains('₺') ? txtSozlesmeBedeli.Text.Remove(0, 1) :
                    txtSozlesmeBedeli.Text);
                _proje.HakedisToplami = Convert.ToDouble(lblToplamHakedis.Text);
                _proje.HakedisToplamTahakkuk = Convert.ToDouble(lblHakedisTahakkuk.Text);

                _dbContext.Projes.Update(_proje);
                _dbContext.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
