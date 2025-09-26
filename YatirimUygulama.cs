using System.Data;
using System.Data.Entity;
using System.Drawing.Imaging;
using System.Net;
using YatirimTakip.Helpers;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using YatirimTakip.Models;
using YatirimTakip;
using System.Security.Principal;
using System.Security.Permissions;


namespace WinFormsApp1
{
    internal partial class YatirimUygulama : Form
    {
        private readonly int _id;
        private AppDbContext _dbContext;
        private Proje _proje;
        private bool _tarihleriSifirla;
        private readonly User _user;
        private static readonly string BaseSavePath = "C:\\Users\\Hakan Aygüzer\\Desktop\\Dosyalar\\Dosya_";
        private static readonly string BaseSavePathResim = "C:\\Users\\Hakan Aygüzer\\Desktop\\Resimler\\";
        private static readonly string BaseSavePathSrv = @"\\10.1.2.12\ys\Dosyalar\Dosya_";
        private static readonly string BaseSavePathResimSrv = @"\\10.1.2.12\ys";

        public YatirimUygulama(int id, User user)
        {
            InitializeComponent();
            _id = id;
            _tarihleriSifirla = false;
            _user = user;
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
            dataGridView2.Columns[3].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[11].DefaultCellStyle.Format = "N2";

            var Path = BaseSavePathResimSrv + "\\Resimler_" + _id + "\\" + _id;

            var credentials = new NetworkCredential(@"yol", "ys23*23M", "OZELIDARE");

            using (new NetworkConnection(@"\\10.1.2.12\ys", credentials))
            {
                if (File.Exists(Path + "_oncesi.jpg"))
                {
                    pictureBox1.Image = Image.FromFile(Path + "_oncesi.jpg");
                }

                if (File.Exists(Path + "_sonrasi.jpg"))
                {
                    pictureBox2.Image = Image.FromFile(Path + "_sonrasi.jpg");
                }
            }             

            OrderColumns();

            if (_proje is not null)
            {
                label2.Text = _proje.Adi;
                txtSure.Text = _proje.Sure.ToString() == "0" ? "" : _proje.Sure.ToString();
                txtYuklenici.Text = _proje.Yuklenici;
                cmbDurum.SelectedValue = _proje.Yuklenici is null ? ProjeDurumu.IhaleHazirlik : _proje.ProjeDurumu;
                txtSozlesmeBedeli.Text = _proje.SozlesmeBedeli.ToString("N2");
                txtAciklama.Text = _proje.Aciklama;
                label13.Text = _proje.YaklasikMaliyet.ToString("N2");
                lblToplamHakedis.Text = _proje.HakedisToplami.ToString("N2");
                lblHakedisTahakkuk.Text = _proje.HakedisToplamTahakkuk.ToString("N2");
                _tarihleriSifirla = _proje.KesinKabulTarihi == null ? true : false;

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

            else if (proje.IseBaslamaTarihi is not null && proje.KesinKabulTarihi is not null)
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
                dtpIseBaslama.Value = proje.IseBaslamaTarihi.Value;
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
            if (txtSure.Text == string.Empty)
            {
                txtSure.Text = "0";
            }

            if (dtpIseBaslama.Value.Date.Year > 1970)
            {
                dtpIseBaslama.CustomFormat = "dd MMMM yyyy dddd";
                dtpBitisTarihi.Value = dtpIseBaslama.Value.AddDays(Convert.ToDouble(txtSure.Text) - 1);
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
            dtpKesinKabul.Value = dtpGeciciKabul.Value.AddYears(1);
            dtpKesinKabul.CustomFormat = "dd MMMM yyyy dddd";
            _tarihleriSifirla = false;
        }

        private void dtpKesinKabul_ValueChanged(object sender, EventArgs e)
        {
            dtpKesinKabul.CustomFormat = "dd MMMM yyyy dddd";
            _tarihleriSifirla = false;
        }

        private void YatirimUygulama_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void txtSozlesmeBedeli_Leave(object sender, EventArgs e)
        {
            //double value;
            //if (double.TryParse(txtSozlesmeBedeli.Text, out value))
            //    txtSozlesmeBedeli.Text = string.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            //else
            //    txtSozlesmeBedeli.Text = string.Empty;
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

                    lblToplamHakedis.Text = _proje.HakedisToplami.ToString("N2");
                    lblHakedisTahakkuk.Text = _proje.HakedisToplamTahakkuk.ToString("N2");
                    txtHakedis.Text = txtHakedisMiktar.Text = string.Empty;
                }

                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

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

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns["Ilce"].DisplayIndex = 0;
            dataGridView1.Columns["Koy"].DisplayIndex = 1;
            dataGridView1.Columns["ProgramId"].DisplayIndex = 2;
            dataGridView1.Columns["Miktar"].DisplayIndex = 3;
            dataGridView1.Columns["Uygulama"].DisplayIndex = 4;
            dataGridView1.Columns["UygulamaEkle"].DisplayIndex = 5;
            dataGridView1.Columns["YaklasikMaliyet"].DisplayIndex = 6;
            dataGridView1.Columns["MaliyetButton"].DisplayIndex = 7;
            dataGridView1.Columns["Birim"].DisplayIndex = 8;
            dataGridView1.Columns["Imalat"].DisplayIndex = 9;
            dataGridView1.Columns["Yil"].DisplayIndex = 10;
            dataGridView1.Columns["YatirimDurumu"].DisplayIndex = 11;
            dataGridView1.Columns["Proje"].DisplayIndex = 12;
            dataGridView1.Columns["Kaynak"].DisplayIndex = 13;
            dataGridView1.Columns["ProjedenCikar"].DisplayIndex = 14;
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
                        var buttons = MessageBoxButtons.YesNo;
                        var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
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

            if (e.ColumnIndex ==
                dataGridView1.Columns[2].Index && e.RowIndex > -1)
            {
                var id = (int)dataGridView1.CurrentRow.Cells["ProgramId"].Value;
                var program = _dbContext.YatirimProgramis.Where(p => p.ID == id).FirstOrDefault();
                var buttons = MessageBoxButtons.YesNo;
                var result = MessageBox.Show("Çıkarmak İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                try
                {
                    if (result == DialogResult.Yes)
                    {
                        program.YatirimDurumu = Models.YatirimDurumu.Uygulanmadi;
                        program.Proje = null;
                        _proje.YaklasikMaliyet -= program.YaklasikMaliyet;

                        _dbContext.Update(program);
                        _dbContext.Update(_proje);
                        _dbContext.SaveChanges();

                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir şeyler ters gitti. Lütfen tekrar deneyin.", "Hata");
                }

                this.OnLoad(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try

            {
                _proje.IseBaslamaTarihi = dtpIseBaslama.Value;
                _proje.Sure = Convert.ToInt32(txtSure.Text == string.Empty ? "0" : txtSure.Text);
                _proje.IsBitisTarihi = dtpBitisTarihi.Value;
                _proje.GeciciKabulTarihi = _tarihleriSifirla ? null : dtpGeciciKabul.Value;
                _proje.KesinKabulTarihi = _tarihleriSifirla ? null : dtpKesinKabul.Value;
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
            catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYeniProgram_Click(object sender, EventArgs e)
        {
            using (ProgramlarSec programlar = new(this, _user))
            {
                programlar.ShowDialog();
                this.OnLoad(e);
            }
        }

        public void ReceiveData(List<YatirimProgrami> programList)
        {
            if (programList.Count > 0)
            {
                foreach (var program in programList)
                {
                    program.Proje = _proje;
                    program.YatirimDurumu = Models.YatirimDurumu.Uygulaniyor;
                    _proje.YaklasikMaliyet += program.YaklasikMaliyet;
                }

                _dbContext.Update(_proje);
                _dbContext.UpdateRange(programList);
                _dbContext.SaveChanges();
            }

            dataGridView1.Refresh();
        }

        private void btnTarihleriSifirla_Click(object sender, EventArgs e)
        {
            try
            {
                if (_proje.GeciciKabulTarihi is not null)
                {
                    _proje.GeciciKabulTarihi = null;
                    dtpGeciciKabul.CustomFormat = "          ";
                    dtpGeciciKabul.Format = DateTimePickerFormat.Custom;
                }

                if (_proje.KesinKabulTarihi is not null)
                {
                    _proje.KesinKabulTarihi = null;
                    dtpKesinKabul.CustomFormat = "          ";
                    dtpKesinKabul.Format = DateTimePickerFormat.Custom;
                }

                _tarihleriSifirla = true;

                _dbContext.Update(_proje);
                _dbContext.SaveChanges();
            }

            catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

        }

        private void btnOncesiGuncelle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImageToPictureBox(openFileDialog.FileName, pictureBox1);
                }
            }
        }

        private void LoadImageToPictureBox(string filePath, PictureBox pictureBox)
        {
            try
            {
                // Eski resmi temizle
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Dispose();
                }

                // Resmi yeniden boyutlandırarak yükle
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (var originalImage = Image.FromStream(stream))
                    {
                        var resizedImage = ResizeImage(originalImage, 800, 600);
                        pictureBox.Image = resizedImage;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Yükleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ResizeImage(Image originalImage, int maxWidth, int maxHeight)
        {
            double ratio = Math.Min((double)maxWidth / originalImage.Width, (double)maxHeight / originalImage.Height);
            int newWidth = (int)(originalImage.Width * ratio);
            int newHeight = (int)(originalImage.Height * ratio);

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalImage, 0, 0, newWidth, newHeight);
            }
            return resizedImage;
        }

        private void btnOnceFotoKaydet_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Önce bir resim yükleyin.");
                return;
            }

            string serverBasePath = BaseSavePathResimSrv; //@"\\SUNUCU_IP\Paylaşım";

            var credentials = new NetworkCredential(@"yol", "ys23*23M", "OZELIDARE");

            try
            {

                using (new NetworkConnection(serverBasePath, credentials))
                {
                    SaveImageWithAutoFolder(serverBasePath, pictureBox1.Image, "oncesi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException + " " + "!!");
            }
        }
        
        private void SaveImageWithAutoFolder(string baseServerPath, Image image, string onceSonra)
        {
            try
            {
                // 1. Otomatik klasör adı oluştur (tarih-saat bazlı)
                string folderName = "Resimler_" + _id;
                string fullFolderPath = Path.Combine(baseServerPath, folderName);

                // 2. Klasörü oluştur
                Directory.CreateDirectory(fullFolderPath);

                // 3. Resmi kaydet (benzersiz dosya adı ile)
                string fileName = _id + "_" + onceSonra + ".jpg";
                string fullImagePath = Path.Combine(fullFolderPath, fileName);

                image.Save(fullImagePath, ImageFormat.Jpeg);

                MessageBox.Show($"Resim kaydedildi:\n{fullImagePath}", "Başarılı",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt başarısız: {ex.Message}", "Hata",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSonraGuncelle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    LoadImageToPictureBox(openFileDialog.FileName, pictureBox2);
                }
            }
        }

        private void btnSonraKaydet_Click(object sender, EventArgs e)
        {

            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Önce bir resim yükleyin.");
                return;
            }

            string serverBasePath = BaseSavePathResimSrv; //@"\\SUNUCU_IP\Paylaşım";

            var credentials = new NetworkCredential(@"yol", "ys23*23M", "OZELIDARE");

            try
            {

                using (new NetworkConnection(serverBasePath, credentials))
                {
                    SaveImageWithAutoFolder(serverBasePath, pictureBox1.Image, "sonrasi");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException + " " + "!!");
            }
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            // Kaydedilecek dosyayı seç (örneğin OpenFileDialog ile)
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bool success = SaveFileToFixedLocation(openFileDialog.FileName);
                    if (success)
                    {
                        MessageBox.Show($"Dosya başarıyla kaydedildi:\n{Path.Combine(BaseSavePathSrv + _id, Path.GetFileName(openFileDialog.FileName))}");
                    }
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                // 1. Kaynak dosya kontrolü
                if (string.IsNullOrWhiteSpace(BaseSavePathSrv + _id))
                {
                    MessageBox.Show("Dosya bulunamadı");
                }

                // 2. Hedef dosya adını belirle
                string fileName = Path.GetFileName(BaseSavePathSrv + _id);

                string[] fileNames = Directory.GetFiles(BaseSavePathSrv + _id)
                                       .Select(Path.GetFileName)
                                       .ToArray();


                if (fileNames.Count() > 0)
                {
                    // 3. Kullanıcıya kaydetme yeri sor
                    using (SaveFileDialog saveDialog = new SaveFileDialog())
                    {
                        saveDialog.FileName = fileNames[0];
                        saveDialog.Filter = "Tüm Dosyalar (*.*)|*.*";
                        saveDialog.Title = "Dosyayı Kaydet";

                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            string destinationPath = saveDialog.FileName;

                            // Yerel dosya kopyalama
                            File.Copy(BaseSavePathSrv + _id + "\\" + fileNames[0], destinationPath, overwrite: true);

                            MessageBox.Show($"Dosya başarıyla kaydedildi:\n{destinationPath}");

                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"İndirme başarısız: {ex.Message}", "Hata",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool SaveFileToFixedLocation(string sourceFilePath)
        {
            try
            {

                var credentials = new NetworkCredential(@"yol", "ys23*23M", "OZELIDARE");

                using (new NetworkConnection(@"\\10.1.2.12\ys", credentials))
                {
                    // 1. Klasörü kontrol et, yoksa oluştur
                    if (!Directory.Exists(BaseSavePathSrv + _id))
                    {
                        Directory.CreateDirectory(BaseSavePathSrv + _id);
                    }

                    // 2. Hedef dosya adını oluştur (orijinal adı koru)
                    string fileName = Path.GetFileName(sourceFilePath);
                    string destinationPath = Path.Combine(BaseSavePathSrv + _id, fileName);

                    // 3. Dosyayı kopyala (üzerine yazma kontrolü)
                    if (File.Exists(destinationPath))
                    {
                        var result = MessageBox.Show(
                            "Aynı isimli dosya var. Üzerine yazılsın mı?",
                            "Uyarı",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning);

                        if (result != DialogResult.Yes) return false;
                    }

                    File.Copy(sourceFilePath, destinationPath, overwrite: true);
                    return true;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dosya kaydedilemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var credentials = new NetworkCredential(@"yol", "ys23*23M", "OZELIDARE");

            using (new NetworkConnection(@"\\10.1.2.12\ys", credentials))
            {
                string[] fileNames = Directory.GetFiles(BaseSavePathSrv + _id)
                                       .Select(Path.GetFileName)
                                       .ToArray();

                using (YatirimDosyalar dosyalar = new(fileNames, BaseSavePathSrv, _id))
                {
                    dosyalar.ShowDialog();
                    this.OnLoad(e);
                }
            }           
        }
    }
}
