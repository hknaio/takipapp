using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class UCAsfaltDokum : UserControl
    {
        private AppDbContext _dbContext;
        private readonly string _asfalt;
        public UCAsfaltDokum(string asfalt)
        {
            InitializeComponent();
            _asfalt = asfalt;
        }

        private void UCAsfaltDokum_Load(object sender, EventArgs e)
        {
            var uygulama = _asfalt == "Asfalt Bakım Onarım" || _asfalt == "BSK"
                || _asfalt == "Asfalt Döküm İhalesi" ? true : false;

            _dbContext = new AppDbContext();
            _dbContext.Ilces.Load();
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();

            var ilce = cmbIlce.Text;

            _dbContext.YatirimProgramis.Where(y => y.Imalat.Contains(_asfalt) &&
                                                   //y.Yil == DateTime.Now.Year &&
                                                   y.Ilce == ilce).Load();
            dataGridView1.DataSource = _dbContext.YatirimProgramis.Local.ToBindingList();
            dataGridView1.AutoGenerateColumns = false;

            if (uygulama)
            {
                dataGridView1.Columns["Uygulama"].Visible = false;
            }

            OrderColumns();
        }
        private void OrderColumns()
        {
            dataGridView1.Columns["Ilce"].DisplayIndex = 0;
            dataGridView1.Columns["Koy"].DisplayIndex = 1;
            dataGridView1.Columns["Imalat"].DisplayIndex = 2;
            dataGridView1.Columns["Miktar"].DisplayIndex = 3;
            dataGridView1.Columns["Uygulama"].DisplayIndex = 4;
            dataGridView1.Columns["Dokum"].DisplayIndex = 5;
            dataGridView1.Columns["YaklasikMaliyet"].DisplayIndex = 6;
            dataGridView1.Columns["Kaynak"].DisplayIndex = 7;
            dataGridView1.Columns["YatirimDurumu"].DisplayIndex = 8;
            dataGridView1.Columns["AsfaltDokum"].DisplayIndex = 9;
            dataGridView1.Columns["ProgramId"].DisplayIndex = 10;
            dataGridView1.Columns["Birim"].DisplayIndex = 11;
            dataGridView1.Columns["Yil"].DisplayIndex = 12;
            dataGridView1.Columns["Program"].DisplayIndex = 13;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==
           dataGridView1.Columns[1].Index && e.RowIndex > -1)
            {
                var programId = (int)dataGridView1.CurrentRow.Cells["programId"].Value;

                using (AsfaltDokumGuncelle asfaltDokum = new(programId))
                {
                    asfaltDokum.ShowDialog();                    
                    this.OnLoad(e);
                    cmbIlce.Text = asfaltDokum.Ilce;

                    var list = _dbContext.YatirimProgramis.Where(y => y.Imalat.Contains(_asfalt) &&
                                                   y.Yil == DateTime.Now.Year &&
                                                   y.Ilce == asfaltDokum.Ilce).ToList();

                    dataGridView1.DataSource = list;
                }
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var id = (int)dataGridView1.Rows[e.RowIndex].Cells["ProgramId"].Value;
                var asfaltDokum = _dbContext.AsfaltDokums.Where(a => a.YatirimProgrami.ID == id).FirstOrDefault();
                e.Value = asfaltDokum is null ? 0 : asfaltDokum.DokumMesafesi;
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            if (cmbKaynak.Text != string.Empty)
            {
                if (cmbKaynak.Text == "Hepsi")
                {
                    var programs = _dbContext.YatirimProgramis.Where(y => y.Imalat.Contains(_asfalt)
                                                  && y.Yil == DateTime.Now.Year && y.Ilce == cmbIlce.Text
                                                 ).ToList();

                    dataGridView1.DataSource = programs;
                }

                else
                {
                    var programs = _dbContext.YatirimProgramis.Where(y => y.Imalat.Contains(_asfalt)
                                                  && y.Yil == DateTime.Now.Year && y.Ilce == cmbIlce.Text
                                                  && y.Kaynak == cmbKaynak.Text).ToList();

                    dataGridView1.DataSource = programs;
                }                
            }

            cmbKaynak.Focus();
        }
    }
}
