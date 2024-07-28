using iTextSharp.text.pdf;
using iTextSharp.text;

namespace YatirimTakip.Helpers
{
    internal class PDFCreator
    {
        public void CreatePdf(DataGridView dataGrid, string name)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

            if (dataGrid.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = name + ".pdf";
                bool ErrorMessage = false;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Diske yazılamadı." + ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGrid.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGrid.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontNormal));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dataGrid.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    var value = formatData(dcell.Value.ToString()) ? Convert.ToDouble(dcell.Value).ToString("N2") : dcell.Value.ToString();

                                    pTable.AddCell(new Phrase(
                                         value
                                        , fontNormal));
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }
                            MessageBox.Show("PDF Başarıyla oluştu.", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("PDF Oluşturulamadı." + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı..", "Info");
            }
        }

        private bool formatData(string data)
        {
            double v;
            if (double.TryParse(data, out v))
            {
                return true;
            }

            return false;
        }
    }    
}
