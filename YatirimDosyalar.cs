
using System.Data;

namespace YatirimTakip
{
    public partial class YatirimDosyalar : Form
    {
        private string _srvPath;
        private int _id;
        public YatirimDosyalar(string[] dosyalar, string srvPath, int id)
        {
            InitializeComponent();

            _srvPath = srvPath;
            _id = id;

            int sutunIndex = 0; // Doldurmak istediğiniz sütunun index'i

            // DataGridView'da yeterli satır olduğundan emin ol
            dataGridView1.Rows.Clear();
            if (dosyalar.Length > 0)
            {
                dataGridView1.Rows.Add(dosyalar.Length);
            }

            // Belirtilen sütunu doldur
            for (int i = 0; i < dosyalar.Length; i++)
            {
                dataGridView1.Rows[i].Cells[sutunIndex].Value = dosyalar[i];
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string fileName = (string)dataGridView1.Rows[e.RowIndex].Cells[0].Value;

            if (e.ColumnIndex ==
           dataGridView1.Columns[1].Index)
            {
                // 1. Kaynak dosya kontrolü
                if (string.IsNullOrWhiteSpace((string)dataGridView1.Rows[e.RowIndex].Cells[0].Value))
                {
                    MessageBox.Show("Dosya bulunamadı");
                }

                try
                {
                    // 3. Kullanıcıya kaydetme yeri sor
                    using (SaveFileDialog saveDialog = new SaveFileDialog())
                    {
                        saveDialog.FileName = fileName;
                        saveDialog.Filter = "Tüm Dosyalar (*.*)|*.*";
                        saveDialog.Title = "Dosyayı Kaydet";

                        if (saveDialog.ShowDialog() == DialogResult.OK)
                        {
                            string destinationPath = saveDialog.FileName;

                            // Yerel dosya kopyalama
                            File.Copy(_srvPath + _id + "\\" + fileName, destinationPath, overwrite: true);

                            MessageBox.Show($"Dosya başarıyla kaydedildi:\n{destinationPath}");
                            
                            this.OnLoad(e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"İndirme başarısız: {ex.Message}", "Hata",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.ColumnIndex ==
           dataGridView1.Columns[2].Index)
            {
                string filePath = _srvPath + _id + "\\" + fileName; // Silinecek dosyanın tam yolu

                try
                {
                    // Dosya var mı kontrol et
                    if (File.Exists(filePath))
                    {
                        // Dosyayı sil
                        File.Delete(filePath);
                        MessageBox.Show("Dosya başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EditDatagridElements(dataGridView1);
                        this.OnLoad(e);
                    }
                    else
                    {
                        MessageBox.Show("Dosya bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Dosyayı silmek için yetkiniz yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Dosya silinirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmeyen hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void YatirimDosyalar_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);
        }

        private void EditDatagridElements(DataGridView dataGridView)
        {
            string[] fileNames = Directory.GetFiles(_srvPath + _id)
                                       .Select(Path.GetFileName)
                                       .ToArray();

            int sutunIndex = 0; // Doldurmak istediğiniz sütunun index'i

            // DataGridView'da yeterli satır olduğundan emin ol
            dataGridView1.Rows.Clear();
            if (fileNames.Length > 0)
            {
                dataGridView1.Rows.Add(fileNames.Length);
            }

            // Belirtilen sütunu doldur
            for (int i = 0; i < fileNames.Length; i++)
            {
                dataGridView1.Rows[i].Cells[sutunIndex].Value = fileNames[i];
            }
        }
    }


}
