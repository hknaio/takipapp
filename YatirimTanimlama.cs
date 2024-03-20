using System.ComponentModel;
using System.Data.Entity;
using CsvHelper;
using CsvHelper.Excel;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class YatirimTanimlama : Form
    {
        private AppDbContext? _dbContext;
        private Button selectButton;
        private OpenFileDialog openFileDialog1;
        public YatirimTanimlama()
        {
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog()
            {
                FileName = "Yatırım programı dosyası seç.",
                Filter = "Text files (*.xlsx)|*.xlsx",
                Title = "Excel dosyası seç"
            };

            selectButton = new Button()
            {
                Size = new Size(200, 40),
                Location = new Point(15, 15),
                Text = "Yatırım Dosyası Seç"
            };
            selectButton.Click += new EventHandler(selectButton_Click);
            Controls.Add(selectButton);
        }

        private void YatirimTanimlama_Load(object sender, EventArgs e)
        {
            txtYil.Mask = "0000";
            _dbContext = new AppDbContext();
            _dbContext.YatirimProgramis.Distinct().Load();
            var yatirimProgramlar = _dbContext.YatirimProgramis.Local
                .Select(y => new { y.Kaynak,y.Yil }).Distinct().ToList();            
            dataGridView1.DataSource =  yatirimProgramlar;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = openFileDialog1.FileName;
                    using (Stream str = openFileDialog1.OpenFile())
                    {
                        label1.Text = filePath;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (label1.Text == "-")
            {
                MessageBox.Show($"Hata.\n\nHata mesajı: Dosya seçiniz..\n\n");
                return;
            }

            if (IsModelValid())
            {
                try
                {
                    using var reader = new CsvReader(new ExcelParser(label1.Text));

                    var records = new List<YatirimProgrami>();
                    reader.Read(); reader.Read(); reader.Read();
                    while (reader.Read())
                    {
                        if (reader.GetField(3) == "Yol ve Ulaşım")
                        {
                            var record = new YatirimProgrami
                            {
                                Ilce = reader.GetField(1),
                                Koy = reader.GetField(2),
                                Birim = reader.GetField(3),
                                Imalat = reader.GetField(4),
                                Miktar = reader.GetField(5),
                                Kaynak = cmbKaynak.Text,
                                Yil = Convert.ToInt32(txtYil.Text),
                                Program = "Ana Program",
                                YatirimDurumu = YatirimDurumu.Uygulanmadi,
                            };
                            records.Add(record);
                        }
                    }

                    _dbContext!.YatirimProgramis.AddRange(records);
                    _dbContext.SaveChanges();
                    dataGridView1.Refresh();
                    this.OnLoad(e);
                    ClearTexts();

                    MessageBox.Show($"Başarılı.\n\nKayıtlar eklendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }

            txtYil.Focus();
        }

        private bool IsModelValid()
        {
            if (txtYil.Text != string.Empty && cmbKaynak.Text != string.Empty
                )
            {
                return true;
            }

            return false;
        }

        private void ClearTexts()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox or MaskedTextBox or ComboBox)
                {
                    c.Text = string.Empty;
                }
            }

            label1.Text = "-";
        }

        private void YatirimTanimlama_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var yil = dataGridView1.CurrentRow.Cells["Yil"].Value;
            var kaynak = dataGridView1.CurrentRow.Cells["Kaynak"].Value;

            if (e.ColumnIndex ==
           dataGridView1.Columns[0].Index)
            {
                using (YatirimTanimlamaDetay yeniProje = new((int)yil,(string)kaynak))
                {
                    yeniProje.ShowDialog();
                    this.OnLoad(e);
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns[1].Index)
            {
                var yatirimProgramlar = _dbContext!.YatirimProgramis.Where(y => y.Yil == (int)yil && y.Kaynak == (string)kaynak);

                try
                {
                    _dbContext.RemoveRange(yatirimProgramlar);
                    _dbContext.SaveChanges();
                    dataGridView1.Refresh();
                    this.OnLoad(e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }
        }
    }
}
