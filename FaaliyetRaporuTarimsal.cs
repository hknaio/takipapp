using WinFormsApp1.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using YatirimTakip.Helpers;
using WinFormsApp1.Models;
using System.Dynamic;

namespace WinFormsApp1
{
    internal record FaaliyetRaporTarimsal(string ilce, double isAdet,double kat1, double kat2, double bsk, double asfaltOnarim ,double kilitliParke, double stabilize,
        double yolOnarim ,double menfez, double istinat, double kopru, double reglaj, double kar,double beton, double yeniYol,
         double spiral, double icme, double tarim, double kaya, double diger, double miktar);

    public partial class FaaliyetRaporuTarimsal : Form
    {
        private AppDbContext _dbContext;
        public FaaliyetRaporuTarimsal()
        {
            InitializeComponent();
        }

        private void FaaliyetRaporuTarimsal_Load(object sender, EventArgs e)
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
        private void LoadExpandoDataGridView()
        {
            try
            {

                var purEmanets = _dbContext.PurEmanets.Where(p => p.Tarih.Year == Convert.ToInt32(cmbYil.Text)
                     && p.Imalat.Mudurluk == "Tarımsal Hizmetler")
                    .Select(m => m.Imalat.Isim)
                    .Distinct()
                    .ToList();

                var query = _dbContext.PurEmanets.Include(m => m.Imalat)
                    .Where(p => p.Tarih.Year == Convert.ToInt32(cmbYil.Text)
                     && p.Imalat.Mudurluk == "Tarımsal Hizmetler")
                    .GroupBy(m => m.Ilce)
                    .ToList();

                var projeler = _dbContext.Projes.Include(p => p.Programis)
                    .Where(p => p.Programis.Any(p => p.Yil == Convert.ToInt32(cmbYil.Text)
                    && p.YatirimDurumu == Models.YatirimDurumu.Uygulandi && p.Birim == "Tarımsal Hizmetler")
                    )
                    .ToList();

                var projeDatas = new List<ProjeData>();

                foreach (var item in projeler)
                {
                    var list = item.Programis
                        .GroupBy(p => new { p.Ilce, p.Imalat })
                        .Select(s => new ProjeData
                        (
                            s.Key.Ilce,
                            s.Sum(m => m.Uygulama),
                            s.Select(m => m.Imalat).FirstOrDefault()
                        )).ToList();

                    projeDatas.AddRange(list);
                }

                foreach (var item in projeDatas.Select(i => i.Imalat).Distinct())
                {
                    purEmanets.Add(item);
                }

                purEmanets = purEmanets.Distinct().ToList();

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

                ExceleAktar aktar = new();
                aktar.AddTotalRowGeneric(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExceleAktar exceleAktar = new();
            exceleAktar.DataGridViewToExcel(dataGridView1);
        }

        private void FaaliyetRaporuTarimsal_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
