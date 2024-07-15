using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2010.Excel;
using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class YolAgiTanimlama : Form
    {
        private AppDbContext _dbContext;
        public YolAgiTanimlama()
        {
            InitializeComponent();
        }

        private void YolAgiTanimlama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            SeedYolAgi();
            _dbContext.Ilces.Load();
            _dbContext.YolAgis.Load();
            dataGridView1.DataSource = _dbContext.YolAgis.Local.ToBindingList();
            OrderColumns();
        }

        private void OrderColumns()
        {
            dataGridView1.Columns["Ilce"].DisplayIndex = 0;
            dataGridView1.Columns["BSK"].DisplayIndex = 1;
            dataGridView1.Columns["Asfalt"].DisplayIndex = 2;
            dataGridView1.Columns["Stabilize"].DisplayIndex = 3;
            dataGridView1.Columns["KilitParke"].DisplayIndex = 4;
            dataGridView1.Columns["BetonYol"].DisplayIndex = 5;
            dataGridView1.Columns["Toplam"].DisplayIndex = 6;
        }
        private void SeedYolAgi()
        {
            if (_dbContext.YolAgis.Count() == 0)
            {
                var ilceler = _dbContext.Ilces.ToList();

                YolAgi[] yolAgi =
                {
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Ağın").FirstOrDefault(),  BSK = 2.13, Asfalt = 83.55, Stabilize = 0, KilitParke = 12.49, BetonYol = 0, ToplamAg = 98.17 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Alacakaya").FirstOrDefault(),  BSK = 10.63, Asfalt = 65.78, Stabilize = 33.48, KilitParke = 14.74, BetonYol = 2.72, ToplamAg = 127.34 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Arıcak").FirstOrDefault(),  BSK = 8.86, Asfalt = 96.38, Stabilize = 68.26, KilitParke = 12.23, BetonYol = 7.38, ToplamAg = 193.11 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Baskil").FirstOrDefault(),  BSK = 18.34, Asfalt = 312.45, Stabilize = 426.07, KilitParke = 10.57, BetonYol = 3.50, ToplamAg = 770.93 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Karakoçan").FirstOrDefault(),  BSK = 29.46, Asfalt = 303.75, Stabilize = 143.64, KilitParke = 17.25, BetonYol = 0, ToplamAg = 494.09 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Keban").FirstOrDefault(),  BSK = 0, Asfalt = 211.08, Stabilize = 94.56, KilitParke = 11.89, BetonYol = 0, ToplamAg = 317.53 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Kovancılar").FirstOrDefault(),  BSK = 24.29, Asfalt = 285.61, Stabilize = 131.27, KilitParke = 45.62, BetonYol = 0, ToplamAg = 486.79 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Maden").FirstOrDefault(),  BSK = 33.50, Asfalt = 251.37, Stabilize = 181.65, KilitParke = 4.29, BetonYol = 0, ToplamAg = 470.51 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Merkez").FirstOrDefault(),  BSK = 91.95, Asfalt = 558.20, Stabilize = 204.63, KilitParke = 38.12, BetonYol = 0, ToplamAg = 892.90 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Palu").FirstOrDefault(),  BSK = 2.31, Asfalt = 158.64, Stabilize = 81.42, KilitParke = 21.22, BetonYol = 0, ToplamAg = 263.59 },
                   new() { Ilce = ilceler!.Where(i => i.Adi! == "Sivrice").FirstOrDefault(),  BSK = 24.18, Asfalt = 282.35, Stabilize = 215.35, KilitParke = 10.92, BetonYol = 0, ToplamAg = 532.80 },

                };

                _dbContext.YolAgis.AddRange(yolAgi);
                _dbContext.SaveChanges();
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                var yolAgi = (YolAgi)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (yolAgi != null)
                {
                    e.Value = yolAgi.Ilce.Adi;
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[0].Index && e.RowIndex > -1)
            {
                var yolAgiID = dataGridView1.CurrentRow.Cells["ID"].Value;

                using (YolAgiGuncelle yolAgiGuncelle = new((int)yolAgiID))
                {
                    yolAgiGuncelle.ShowDialog();
                    this.OnLoad(e);
                }
            }
        }
        private void YolAgiTanimlama_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
