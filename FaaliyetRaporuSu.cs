using WinFormsApp1.Data;
using Microsoft.EntityFrameworkCore;
using YatirimTakip.Helpers;
using System.Dynamic;
using OfficeOpenXml;


namespace WinFormsApp1
{   
    internal record ProjeData(string Ilce, double Miktar, string Imalat);
    public partial class FaaliyetRaporuSu : Form
    {
        private AppDbContext _dbContext;
        public FaaliyetRaporuSu()
        {
            InitializeComponent();
        }

        private void FaaliyetRaporuSu_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.AsfaltDokums.Load();

            for (int i = 1; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].DefaultCellStyle.Format = "N2";
        }
        private void btnGetir_Click(object sender, EventArgs e)
        {
            LoadExpandoDataGridView();
        }       
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewToExcel();
        }
        private void LoadExpandoDataGridView()
        {        
            try
            {
                using (var context = new AppDbContext())
                {
                    var purEmanets = context.PurEmanets.Where(p => p.Tarih.Year == Convert.ToInt32(cmbYil.Text)
                         && p.Imalat.Mudurluk == "Su ve Kanalizasyon Hizmetleri")
                        .Select(m => m.Imalat.Isim)
                        .Distinct()
                        .ToList();

                    var query = context.PurEmanets.Include(m => m.Imalat)
                        .Where(p => p.Tarih.Year == Convert.ToInt32(cmbYil.Text)
                         && p.Imalat.Mudurluk == "Su ve Kanalizasyon Hizmetleri")
                        .GroupBy(m => m.Ilce)
                        .ToList();

                    var projeler = _dbContext.Projes.Include(p => p.Programis)
                        .Where(p => p.Programis.Any(p => p.Yil == Convert.ToInt32(cmbYil.Text) 
                        && p.YatirimDurumu == Models.YatirimDurumu.Uygulandi && p.Birim == "Su ve Kanalizasyon Hizmetleri") 
                        )                        
                        .ToList();

                    var projeDatas = new List<ProjeData>();

                    foreach (var item in projeler)
                    {
                        var list = item.Programis
                            .GroupBy(p => p.Ilce)
                            .Select(s => new ProjeData
                            (
                                s.Key,
                                s.Sum(m => m.Uygulama),
                                s.Select(m => m.Imalat).FirstOrDefault()
                            )).ToList();

                        projeDatas.AddRange(list);
                    }
                    
                    var dinamikVeri = new List<dynamic>();

                    foreach (var grp in query)
                    {
                        dynamic expando = new ExpandoObject();
                        var expandoDict = (IDictionary<string, object>)expando;
                        expandoDict["Ilce"] = grp.Key;

                        foreach (var puremanet in purEmanets)
                        {
                            var toplam = grp.Where(m => m.Imalat.Isim == puremanet)
                                            .Sum(m => m.Miktar);

                            var projeMiktar = projeDatas.Where(m => m.Ilce == grp.Key.Adi && m.Imalat == puremanet)
                                .Sum(m => m.Miktar);

                            toplam += projeMiktar;

                            expandoDict[puremanet] = toplam;
                        }

                        dinamikVeri.Add(expando);
                    }

                    dataGridView1.Columns.Clear();
                    dataGridView1.Columns.Add("Ilce", "İlçe");

                    foreach (var puremanet in purEmanets)
                    {
                        dataGridView1.Columns.Add(puremanet, puremanet);
                    }

                    foreach (dynamic veri in dinamikVeri)
                    {
                        var row = new DataGridViewRow();
                        row.CreateCells(dataGridView1);
                        row.Cells[0].Value = veri.Ilce.Adi;

                        for (int i = 0; i < purEmanets.Count; i++)
                        {
                            row.Cells[i + 1].Value = ((IDictionary<string, object>)veri)[purEmanets[i]];
                        }

                        dataGridView1.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void DataGridViewToExcel()
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "Excel Dosyaları|*.xlsx";
                    saveDialog.Title = "Excel'e Aktar";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveDialog.FileName;

                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sayfa1");

                            
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                worksheet.Cells[1, j + 1].Value = dataGridView1.Columns[j].HeaderText;
                            }
                            
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    var cell = worksheet.Cells[i + 2, j + 1];
                                    cell.Value = dataGridView1.Rows[i].Cells[j].Value;
                                    
                                    if (j > 0) 
                                    {
                                        
                                        if (double.TryParse(cell.Value?.ToString(), out double numericValue))
                                        {
                                            //cell.Style.Numberformat.Format = "#,##0.00 ₺"; // Para birimi formatı
                                        }
                                    }
                                }
                            }

                            
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            
                            FileInfo excelFile = new FileInfo(filePath);
                            excelPackage.SaveAs(excelFile);

                            MessageBox.Show("Excel'e aktarım tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FaaliyetRaporuSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
