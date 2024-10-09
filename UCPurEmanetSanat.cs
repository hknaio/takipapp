
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Windows.Forms;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UCPurEmanetSanat : UserControl
    {
        private AppDbContext _dbContext;
        private List<SpiralBoru> _spiralBorus;
        public UCPurEmanetSanat()
        {
            InitializeComponent();
        }

        private void UCPurEmanet_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Koys.Load();
            _dbContext.Ilces.Load();
            _dbContext.Mezras.Load();
            _dbContext.Imalats.Load();
            _dbContext.PurEmanets.Where(p => p.Ilce.Adi == cmbIlce.Text 
                                          && p.Tarih.Month == dtTarih.Value.Month
                                          && (p.Imalat.Isim.Contains("Menfez") ||
                                          p.Imalat.Isim.Contains("Spiral Boru") ||
                                          p.Imalat.Isim.Contains("Taş Duvar") ||
                                          p.Imalat.Isim.Contains("Köprü"))).Load();
            _dbContext.SpiralBorus.Load();
            _dbContext.PurEmanetMezras.Load();
            dataGridView1.DataSource = _dbContext.PurEmanets.Local.ToBindingList();
            dataGridView1.Columns[14].DefaultCellStyle.Format = "N2";
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
            dtTarih.CustomFormat = "MMMM yyyy";
            OrderColumns();
            _spiralBorus = _dbContext.SpiralBorus.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (PurEmanetEkleSanat purEmanet = new())
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
            if (e.ColumnIndex == 6)
            {
                var purEmanet = (PurEmanet)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (purEmanet != null)
                {
                    e.Value = purEmanet.Ilce.Adi;
                }
            }
            if (e.ColumnIndex == 10)
            {
                var purEmanet = (PurEmanet)(this.dataGridView1.Rows[e.RowIndex].DataBoundItem);
                if (purEmanet != null)
                {
                    if (purEmanet.Imalat.Isim == "Spiral Boru")
                    {
                        var boru = _spiralBorus.Where(s => s.ID == purEmanet.SpiralBoruId).FirstOrDefault();
                        e.Value = purEmanet.Imalat.Isim + " - " + boru!.Cap.ToString();
                    }
                    else
                    {
                        e.Value = purEmanet.Imalat.Isim;
                    }
                }
            }
            if (e.ColumnIndex == 8)
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
                    e.Value = purEmanet.Imalat.Birim;
                }
            }
        }

        private void OrderColumns()
        {
            dataGridView1.Columns["Tarih"].DisplayIndex = 0;
            dataGridView1.Columns["Ilce"].DisplayIndex = 1;
            dataGridView1.Columns["Koy"].DisplayIndex = 2;
            dataGridView1.Columns["Imalat"].DisplayIndex = 3;
            dataGridView1.Columns["Birim"].DisplayIndex = 4;
            dataGridView1.Columns["Miktar"].DisplayIndex = 5;
            dataGridView1.Columns["Tutar"].DisplayIndex = 6;
            dataGridView1.Columns["Sil"].DisplayIndex = 7;
            dataGridView1.Columns["Detay"].DisplayIndex = 8;
            dataGridView1.Columns["SpiralBoru"].Visible = false;
            dataGridView1.Columns["SpiralBoruId"].Visible = false;
            dataGridView1.Columns["Tarih"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView1.Columns[1].Index
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

            if (e.ColumnIndex == dataGridView1.Columns[2].Index
                && e.RowIndex > -1)
            {
                var puremanetId = dataGridView1.CurrentRow.Cells["ID"].Value;

                using PurEmanetDetay purEmanetDetay = new((int)puremanetId);
                purEmanetDetay.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            var puremanets = _dbContext.PurEmanets.Where(p => p.Ilce.Adi == cmbIlce.Text
                                          && p.Tarih.Month == dtTarih.Value.Month
                                          && (p.Imalat.Isim.Contains("Menfez") ||
                                          p.Imalat.Isim.Contains("Spiral Boru") ||
                                          p.Imalat.Isim.Contains("Taş Duvar") ||
                                          p.Imalat.Isim.Contains("Köprü"))).ToList();

            dataGridView1.DataSource = puremanets;
        }
    }
}
