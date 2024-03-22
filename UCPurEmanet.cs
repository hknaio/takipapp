
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UCPurEmanet : UserControl
    {
        private AppDbContext _dbContext;
        public UCPurEmanet()
        {
            InitializeComponent();
        }

        private void UCPurEmanet_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Koys.Load();
            _dbContext.Ilces.Load();
            _dbContext.Imalats.Load();
            _dbContext.PurEmanets.Load();
            _dbContext.SpiralBorus.Load();
            dataGridView1.DataSource = _dbContext.PurEmanets.Local.ToBindingList();
            OrderColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PurEmanetEkle purEmanet = new())
            {
                purEmanet.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void UCPurEmanet_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                var purEmanet = (PurEmanet)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (purEmanet != null)
                {
                    e.Value = purEmanet.Ilce.Adi;
                }
            }
            if (e.ColumnIndex == 11)
            {
                var purEmanet = (PurEmanet)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (purEmanet != null)
                {
                    if (purEmanet.Imalat.Isim == "Spiral Boru")
                    {
                        var boru = _dbContext.SpiralBorus.Where(s => s.ID == purEmanet.SpiralBoruId).FirstOrDefault();
                        e.Value = purEmanet.Imalat.Isim + " - " + boru!.Cap.ToString();
                    }
                    else
                    {
                        e.Value = purEmanet.Imalat.Isim;
                    }
                }
            }
            if (e.ColumnIndex == 9)
            {
                var purEmanet = (PurEmanet)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (purEmanet != null)
                {
                    e.Value = purEmanet.Koy.Adi;
                }
            }
            if (e.ColumnIndex == 0)
            {
                var purEmanet = (PurEmanet)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (purEmanet != null)
                {
                    e.Value = purEmanet.Imalat.Cins;
                }
            }
            if (e.ColumnIndex == 1)
            {
                var purEmanet = (PurEmanet)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (purEmanet != null)
                {
                    e.Value = purEmanet.Imalat.Birim;
                }
            }
            if (e.ColumnIndex == 2)
            {
                var purEmanet = (PurEmanet)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (purEmanet != null)
                {
                    if (purEmanet.Imalat.Isim == "Spiral Boru")
                    {
                        var boru = _dbContext.SpiralBorus.Where(s => s.ID == purEmanet.SpiralBoruId).FirstOrDefault();
                        e.Value = boru!.BirimFiyat.ToString();
                    }
                    else
                    {
                        e.Value = purEmanet.Imalat.BirimFiyat;
                    }
                }
            }
        }

        private void OrderColumns()
        {
            dataGridView1.Columns["Tarih"].DisplayIndex = 1;
            dataGridView1.Columns["Ilce"].DisplayIndex = 2;
            dataGridView1.Columns["Koy"].DisplayIndex = 3;
            dataGridView1.Columns["Imalat"].DisplayIndex = 4;
            dataGridView1.Columns["Cins"].DisplayIndex = 5;
            dataGridView1.Columns["Birim"].DisplayIndex = 6;
            dataGridView1.Columns["Miktar"].DisplayIndex = 7;
            dataGridView1.Columns["BirimFiyat"].DisplayIndex = 8;
            dataGridView1.Columns["Tutar"].DisplayIndex = 9;
            dataGridView1.Columns["Sil"].DisplayIndex = 10;
            dataGridView1.Columns["SpiralBoru"].Visible = false;
            dataGridView1.Columns["SpiralBoruId"].Visible = false;
            dataGridView1.Columns["Tarih"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns[3].Index 
                && e.RowIndex > -1)
            {
               var puremanetId = dataGridView1.CurrentRow.Cells["ID"].Value;

                var purEmanet = _dbContext!.PurEmanets.Where(p => p.ID == (int)puremanetId).FirstOrDefault();

                try
                {
                    var imalat = (Imalat)dataGridView1.CurrentRow.Cells["Imalat"].Value;

                    var buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        if (imalat!.Isim.Contains("Spiral Boru"))
                        {
                            var spiralBoru = _dbContext?.SpiralBorus.Where(b => b.ID == purEmanet!.SpiralBoruId).FirstOrDefault();

                            if (spiralBoru != null)
                            {
                                spiralBoru.StokMiktar++;
                                _dbContext?.Update(spiralBoru);
                            }
                        }

                        _dbContext!.Remove(purEmanet!);
                        _dbContext.SaveChanges();
                        dataGridView1.Refresh();
                        this.OnLoad(e);
                    }                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }
        }
    }
}
