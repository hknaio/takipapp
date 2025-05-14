using System.Data.Entity;
using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class EkProgramEkle : Form
    {
        private readonly int _yil;
        private readonly string _kaynak;
        private AppDbContext _dbContext;
        public EkProgramEkle(int yil, string kaynak)
        {
            InitializeComponent();
            _yil = yil;
            _kaynak = kaynak;
        }

        private void EkProgramEkle_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            _dbContext.Ilces.Load(); _dbContext.Imalats.Load();
            cmbIlce.DataSource = _dbContext.Ilces.Local.ToBindingList();
            cmbIlce.DisplayMember = "Adi"; cmbIlce.Invalidate();
            cmbImalat.DataSource = _dbContext.Imalats.Local.ToBindingList();
            cmbImalat.DisplayMember = "Isim"; cmbImalat.Invalidate();
            lblYil.Text = _yil.ToString();
            lblKaynak.Text = _kaynak;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (IsModelValid())
            {
                try
                {
                    var ilce = (Ilce)cmbIlce.SelectedValue!;
                    var imalat = (Imalat)cmbImalat.SelectedValue!;

                    _dbContext.YatirimProgramis.Add(new YatirimProgrami
                    {
                        Birim = cmbBirim.Text,
                        Ilce = ilce.Adi,
                        Imalat = imalat.Isim,
                        Koy = txtKoy.Text,
                        Miktar = txtMiktar.Text,
                        Yil = Convert.ToInt32(lblYil.Text),
                        Kaynak = lblKaynak.Text,
                        Program = "Ek Program",
                        YatirimDurumu = YatirimDurumu.Uygulanmadi,
                    });

                    _dbContext.SaveChanges();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n");
                }
            }

            cmbIlce.Focus();
        }

        private bool IsModelValid()
        {
            if (txtKoy.Text != string.Empty && txtMiktar.Text != string.Empty
                && cmbIlce.Text != string.Empty)
            {
                return true;
            }

            return false;
        }

        private void EkProgramEkle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
