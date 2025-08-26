using System.ComponentModel;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Reflection;
using WinFormsApp1.Data;
using WinFormsApp1.Models;
using YatirimTakip.Models;

namespace WinFormsApp1
{
    internal partial class UCProjeTarimsal : UserControl
    {
        private AppDbContext _dbContext;
        private readonly User _user;
        public UCProjeTarimsal(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void btnNewProject_Click(object sender, EventArgs e)
        {
            using (YeniProjeEkleTarimsal yeniProje = new(_user))
            {
                yeniProje.ShowDialog();
                this.OnLoad(e);
            }
        }

        private void UCProjeTarimsal_Load(object sender, EventArgs e)
        {
            Form parent = this.FindForm();

            this.Width = parent.Width - 500;
            this.Height = parent.Height - 400;
            dataGridView1.Width = parent.Width - 500;
            dataGridView1.Height = parent.Height - 400;

            _dbContext = new AppDbContext();

            var ilces = _dbContext.UserIlces.Where(u => u.User.ID == _user.ID).Select(u => u.IlceId).ToList();
            List<Ilce> ilceList = new();

            ilces.ForEach(l => ilceList.Add(_dbContext.Ilces.Where(i => i.ID == l).FirstOrDefault()));

            cmbIlce.DataSource = ilceList;
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
            var projesFilter = _dbContext.Projes.Include(p => p.Programis).Where(p => p.Programis.Any(p => p.Ilce == cmbIlce.Text && p.Birim == "Tarımsal")).ToList();

            dataGridView1.DataSource = projesFilter;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[9].DefaultCellStyle.Format = "N2";
            dataGridView1.Columns[10].DefaultCellStyle.Format = "N2";
            OrderColumns();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[1].Index
                && e.RowIndex > -1)
            {
                var projeId = dataGridView1.CurrentRow.Cells["ID"].Value;

                using (YatirimUygulama yatirim = new((int)projeId, _user))
                {
                    yatirim.ShowDialog();
                    this.OnLoad(e);
                }
            }

            if (e.ColumnIndex == dataGridView1.Columns[0].Index
                && e.RowIndex > -1)
            {
                var projeId = (int)dataGridView1.CurrentRow.Cells["ID"].Value;
                var proje = _dbContext.Projes.Where(p => p.ID == projeId).FirstOrDefault();

                if (proje != null)
                {
                    var programs = _dbContext.YatirimProgramis.Where(y => y.Proje!.ID == projeId);

                    foreach (var yatirimProgrami in programs)
                    {
                        yatirimProgrami.YatirimDurumu = YatirimDurumu.Uygulanmadi;
                    }

                    var buttons = MessageBoxButtons.YesNo;
                    var result = MessageBox.Show("Silmek İstediğinize Emin misiniz?", "Dikkat", buttons, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        _dbContext.YatirimProgramis.UpdateRange(programs);
                        _dbContext.Projes.Remove(proje);

                        _dbContext.SaveChanges();
                        dataGridView1.Refresh();
                    }
                }
            }
        }

        private void OrderColumns()
        {
            dataGridView1.Columns["Adi"].DisplayIndex = 0;
            dataGridView1.Columns["Aciklama"].DisplayIndex = 1;
            dataGridView1.Columns["YaklasikMaliyet"].DisplayIndex = 2;
            dataGridView1.Columns["SozlesmeBedeli"].DisplayIndex = 3;
            dataGridView1.Columns["ProjeDurumu"].DisplayIndex = 4;
            dataGridView1.Columns["Yuklenici"].DisplayIndex = 5;
            dataGridView1.Columns["GeciciKabulTarihi"].DisplayIndex = 6;
            dataGridView1.Columns["KesinKabulTarihi"].DisplayIndex = 7;
            dataGridView1.Columns["Sil"].DisplayIndex = 8;
            dataGridView1.Columns["Uygulama"].DisplayIndex = 9;
            dataGridView1.Columns["ID"].DisplayIndex = 10;
            dataGridView1.Columns["GeciciKabulTarihi"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
            dataGridView1.Columns["KesinKabulTarihi"].DefaultCellStyle.Format = "dd'/'MM'/'yyyy";
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "ProjeDurumu")
            {
                ProjeDurumu enumValue = (ProjeDurumu)e.Value!;
                e.Value = ((DescriptionAttribute)typeof(ProjeDurumu).GetMember(enumValue.ToString()).FirstOrDefault().GetCustomAttributes(typeof(DescriptionAttribute)).FirstOrDefault()).Description;
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "KesinKabulTarihi"
                && e.Value is not null)
            {
                var tarih = (DateTime)e.Value!;

                if ((tarih - DateTime.Now.Date).TotalDays < 60)
                {
                    dataGridView1.Columns[e.ColumnIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (cmbIlce.Text != string.Empty)
            {
                var projesFilter = _dbContext.Projes.Include(p => p.Programis).Where(p => p.Programis.Any(p => p.Ilce == cmbIlce.Text && p.Birim == "Tarımsal Hizmetler")).ToList();
                dataGridView1.DataSource = projesFilter;
            }

            cmbIlce.Focus();
        }
    }
}
