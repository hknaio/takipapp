using OfficeOpenXml;

namespace YatirimTakip.Helpers
{
    internal class ExceleAktar
    {
        public void DataGridViewToExcel(DataGridView dataGridView1)
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
                                    string columnName = dataGridView1.Columns[j].Name;

                                    if (j > 0)
                                    {

                                        if (DateTime.TryParse(cell.Value?.ToString(), out DateTime date)
                                            && columnName.Equals("Tarih", StringComparison.OrdinalIgnoreCase))
                                        {
                                            cell.Value = date;
                                            cell.Style.Numberformat.Format = "dd.MM.yyyy"; // Türkçe tarih formatı
                                        }

                                        if (double.TryParse(cell.Value?.ToString(), out double numericValue)
                                            && columnName.Equals("Harcama", StringComparison.OrdinalIgnoreCase))
                                        {
                                            cell.Style.Numberformat.Format = "#,##0.00 ₺"; // Para birimi formatı
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

        public void DataGridViewToExcelButce(DataGridView dataGridView1)
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
                                    string columnName = dataGridView1.Columns[j].Name;

                                    if (j > 0)
                                    {
                                                                                

                                        if (double.TryParse(cell.Value?.ToString(), out double numericValue)
                                            && !columnName.Equals("İlçe", StringComparison.OrdinalIgnoreCase))
                                        {
                                            cell.Style.Numberformat.Format = "#,##0.00 ₺"; // Para birimi formatı
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

        public void AddTotalRowGeneric(DataGridView dgv)
        {
            if (dgv.Rows.Count == 0)
                return;

            // Yeni satır için toplam değerleri saklayacak array
            object[] toplamlar = new object[dgv.Columns.Count];

            // "Toplam" yazısı ilk hücreye
            toplamlar[0] = "Toplam";

            // Tüm sütunlar üzerinden dön
            for (int col = 1; col < dgv.Columns.Count; col++)
            {
                decimal sum = 0;
                bool isNumeric = false;

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (!row.IsNewRow && row.Cells[col].Value != null)
                    {
                        // Hücre sayısal mı kontrol et
                        if (decimal.TryParse(row.Cells[col].Value.ToString(), out decimal val))
                        {
                            sum += val;
                            isNumeric = true;
                        }
                    }
                }

                // Eğer sütun sayısalsa toplamı ekle, değilse boş bırak
                toplamlar[col] = isNumeric ? (object)sum : "";
            }

            // Yeni satırı ekle
            int rowIndex = dgv.Rows.Add();
            DataGridViewRow totalRow = dgv.Rows[rowIndex];

            for (int col = 0; col < dgv.Columns.Count; col++)
                totalRow.Cells[col].Value = toplamlar[col];

            // Stil
            totalRow.DefaultCellStyle.BackColor = Color.LightGray;
            totalRow.DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
        }
    }
}
