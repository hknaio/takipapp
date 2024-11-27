using iTextSharp.text.pdf;
using iTextSharp.text;
using WinFormsApp1.Models;

namespace YatirimTakip.Helpers
{
    internal class PDFCreator
    {
        public void CreatePdf(DataGridView dataGrid, string name)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

            iTextSharp.text.Font fontBold = new iTextSharp.text.Font(STF_Helvetica_Turkish, 13, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.RED);

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
                            var colCount = name.Contains("Program Detay") ? dataGrid.Columns.Count - 4 : dataGrid.Columns.Count;
                            PdfPTable pTable = new PdfPTable(colCount);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGrid.Columns)
                            {
                                if (col.HeaderText != "Düzenle" && col.HeaderText != "Sil" && col.HeaderText != "ID" && col.HeaderText != "Proje")
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontBold));
                                    pTable.AddCell(pCell);
                                }
                            }
                            foreach (DataGridViewRow viewRow in dataGrid.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.ToolTipText != "Sil" && dcell.ToolTipText != "Düzenle")
                                    {
                                        var value = formatData(dcell.Value.ToString()) ? Convert.ToDouble(dcell.Value).ToString("N2") : dcell.Value.ToString();

                                        pTable.AddCell(new Phrase(
                                             value
                                            , fontNormal));
                                    }                                                   
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A3, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(AppName(document));
                                document.Add(TextData(name));
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

        public void CreatePdfProgram(DataGridView dataGrid, string name)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(STF_Helvetica_Turkish, 12, iTextSharp.text.Font.NORMAL);

            iTextSharp.text.Font fontBold = new iTextSharp.text.Font(STF_Helvetica_Turkish, 13, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.RED);

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
                            var colCount = name.Contains("Program Detay") ? dataGrid.Columns.Count - 4 : dataGrid.Columns.Count;
                            PdfPTable pTable = new PdfPTable(colCount);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dataGrid.Columns)
                            {
                                if (col.Index != 2 && col.Index != 14 && col.HeaderText != "Düzenle" && col.HeaderText != "Sil")
                                {
                                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, fontBold));
                                    pTable.AddCell(pCell);
                                }
                            }
                            foreach (DataGridViewRow viewRow in dataGrid.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    if (dcell.ColumnIndex != 2 && dcell.ColumnIndex != 14 && dcell.ToolTipText != "Sil" && dcell.ToolTipText != "Düzenle")
                                    {
                                        var value = formatData(dcell.Value.ToString()) ? Convert.ToDouble(dcell.Value).ToString("N2") : dcell.Value.ToString();

                                        pTable.AddCell(new Phrase(
                                             value
                                            , fontNormal));
                                    }
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A3, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(AppName(document));
                                document.Add(TextData(name));
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

        private void AddDistrictImageByName(Document document, string districtName)
        {
            try
            {
                // Uygulamanın çalıştığı dizine eriş
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Resim klasörü (örneğin Resources klasörü) uygulama dizininde olmalı
                string imageFolderPath = Path.Combine(appDirectory, "Resources");

                // Resim dosya yolunu oluştur
                string imagePath = Path.Combine(imageFolderPath, districtName + ".png"); // Resimler .png formatında

                if (File.Exists(imagePath))
                {
                    iTextSharp.text.Image districtImage = iTextSharp.text.Image.GetInstance(imagePath);
                    districtImage.ScaleToFit(250f, 250f); // Resim boyutunu ayarla
                    districtImage.Alignment = Element.ALIGN_CENTER; // Ortaya hizalama
                    document.Add(districtImage); // PDF'e resmi ekler

                    // Resimden sonra iki satır boşluk ekle
                    Paragraph spaceAfterImage = new Paragraph();
                    spaceAfterImage.Add(new Chunk("\n\n"));
                    document.Add(spaceAfterImage);
                }
                else
                {
                    MessageBox.Show("Resim bulunamadı: " + imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim eklenirken hata oluştu: " + ex.Message);
            }
        }


        private Paragraph CreateTitle(string districtName)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font fontBold = new iTextSharp.text.Font(STF_Helvetica_Turkish, 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK);

            string title = $"{districtName} İlçesi Bilgi Notu"; // İlçe adı dinamik olarak başlığa ekleniyor
            Chunk titleChunk = new Chunk(title, fontBold);

            Paragraph titleParagraph = new Paragraph(titleChunk)
            {
                Alignment = Element.ALIGN_CENTER // Başlığı ortalayın
            };

            titleParagraph.Add(new Chunk("\n")); // İki satır boşluk ekliyoruz


            return titleParagraph;
        }
        private Paragraph TextData(string name)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);


            iTextSharp.text.Font fontBold = new iTextSharp.text.Font(STF_Helvetica_Turkish, 15, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY);


            Chunk c1 = new(" \t\t\t\t\t\t\t\t\t" + name, fontBold);
            Chunk space = new("\n");


            var para = new Paragraph()
            {
                c1,space,space
            };

            return para;
        }

        private Paragraph AppName(Document document)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);


            iTextSharp.text.Font fontBold = new iTextSharp.text.Font(STF_Helvetica_Turkish, 15, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.RED);


            Chunk c1 = new(" \t\t\t\t\t\t\t\t\t" + "YATIRIM TAKİP YÖNETİM SİSTEMİ", fontBold);
            Chunk space = new("\n");


            var para = new Paragraph()
            {
                c1,space,space
            };

            try
            {
                // Uygulamanın çalıştığı dizine eriş
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // Resim klasörü (örneğin Resources klasörü) uygulama dizininde olmalı
                string imageFolderPath = Path.Combine(appDirectory, "Resources");

                // Resim dosya yolunu oluştur
                string imagePath = Path.Combine(imageFolderPath,"yatirimtakiplogo.png"); // Resimler .png formatında

                if (File.Exists(imagePath))
                {
                    iTextSharp.text.Image districtImage = iTextSharp.text.Image.GetInstance(imagePath);
                    districtImage.ScaleToFit(70f, 70f); // Resim boyutunu ayarla
                    districtImage.Alignment = Element.ALIGN_LEFT; // Ortaya hizalama
                    document.Add(districtImage); // PDF'e resmi ekler

                    // Resimden sonra iki satır boşluk ekle
                    Paragraph spaceAfterImage = new Paragraph();
                    spaceAfterImage.Add(new Chunk("\n\n"));
                    document.Add(spaceAfterImage);
                }
                else
                {
                    MessageBox.Show("Resim bulunamadı: " + imagePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Resim eklenirken hata oluştu: " + ex.Message);
            }

            return para;
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

        public Paragraph BilgiNotu(YolAgi yolAgi, List<YatirimProgrami> programs)
        {
            iTextSharp.text.pdf.BaseFont STF_Helvetica_Turkish = iTextSharp.text.pdf.BaseFont.CreateFont("Helvetica", "CP1254", iTextSharp.text.pdf.BaseFont.NOT_EMBEDDED);

            iTextSharp.text.Font fontBold = new iTextSharp.text.Font(STF_Helvetica_Turkish, 15, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY);


            Chunk yolagi = new(" " + yolAgi.Ilce.Adi + "  İlçesi Yol Ağımız " + yolAgi.ToplamAg + " km’dir." +
                " Bunun; " + yolAgi.BSK + "  km si BSK, " + yolAgi.Asfalt + "  km’si Sathi Kaplama " + yolAgi.Stabilize + " km’si stabilize " +
                " " + yolAgi.KilitParke + " km’si kilit parke ile kaplama türüne sahiptir. \t\t\t\t\t\t\t\t\t", fontBold);
            Chunk space = new("\n\n");


            var para = new Paragraph()
            {
                yolagi,space,space
            };

            Chunk araParagraph = new(yolAgi.Ilce.Adi.ToUpper() +" İLÇESİ İÇİN 2024 YILI ELAZIĞ İL ÖZEL İDARESİ YOL VE ULAŞIM HİZMETLERİ MÜDÜRLÜĞÜ BÜNYESİNDE YAPILAN İŞLER:", fontBold);

            var para2 = new Paragraph()
            {
                araParagraph,space,space
            };

            var bskToplam = programs.Where(p => p.Imalat.Contains("BSK")).Sum(p => p.Uygulama);

            Chunk bsk = new("BİTÜMLÜ SICAK ASFALT ÇALIŞMASI : " + bskToplam
                .ToString() + " m", fontBold);

            var para3 = new Paragraph()
            {
                bsk, space, space, space
            };

            var kat1Toplam = programs.Where(p => p.Imalat.Contains("1.")).Sum(p => p.Uygulama);

            Chunk kat1 = new("SATHİ KAPLAMA 1. KAT ASFALT ÇALIŞMASI : " + kat1Toplam
               .ToString() + " km", fontBold);

            var para4 = new Paragraph()
            {
                kat1, space, space, space
            };

            var kat2Toplam = programs.Where(p => p.Imalat.Contains("2.")).Sum(p => p.Uygulama);

            Chunk kat2 = new("SATHİ KAPLAMA 2. KAT ASFALT ÇALIŞMASI : " + kat2Toplam
               .ToString() + " km", fontBold);

            var para5 = new Paragraph()
            {
                kat2, space, space, space
            };

            var asfaltbakimToplam = programs.Where(p => p.Imalat.Contains("asfalt bakım") ||
               p.Imalat.Contains("Asfalt Bakım")).Sum(p => p.Uygulama);

            Chunk asfaltbakim = new("ASFALT BAKIM ONARIM ÇALIŞMASI : " + asfaltbakimToplam
               .ToString() + " km", fontBold);

            var para6 = new Paragraph()
            {
                asfaltbakim, space, space, space
            };

            var kilitliToplam = programs.Where(p => p.Imalat.Contains("ilitli")).Sum(p => p.Uygulama);

            Chunk kilitli = new("KİLİTLİ PARKE ÇALIŞMASI : " + kilitliToplam
               .ToString() + " km", fontBold);

            var para7 = new Paragraph()
            {
                kilitli, space, space, space
            };

            var stabilizeToplam = programs.Where(p => p.Imalat.Contains("stabilize")).Sum(p => p.Uygulama);

            Chunk stabilize = new("STABİLİZE ÇALIŞMASI : " + stabilizeToplam
               .ToString() + " km", fontBold);

            var para8 = new Paragraph()
            {
                stabilize, space, space, space
            };

            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = yolAgi.Ilce.Adi + " Bilgi Notu" + ".pdf";
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
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A3, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                document.Add(CreateTitle(yolAgi.Ilce.Adi));

                                document.Add(para);
                                AddDistrictImageByName(document, yolAgi.Ilce.Adi);
                                document.Add(para2);
                                if (bskToplam > 0)
                                {
                                    document.Add(para3);
                                }

                                if (kat1Toplam > 0)
                                {
                                    document.Add(para4);
                                }

                                if (kat2Toplam > 0)
                                {
                                    document.Add(para5);
                                }

                                if (asfaltbakimToplam > 0)
                                {
                                    document.Add(para6);
                                }

                                if (kilitliToplam > 0)
                                {
                                    document.Add(para7);
                                }

                                if (stabilizeToplam > 0)
                                {
                                    document.Add(para8);
                                }                                
                                
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
            catch (Exception)
            {

                throw;
            }           

            return para;
        }
    }    
}
