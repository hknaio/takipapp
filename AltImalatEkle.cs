
using DocumentFormat.OpenXml.Wordprocessing;
using WinFormsApp1.Data;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace YatirimTakip
{
    public partial class AltImalatEkle : Form
    {
        private string _birim;
        private int _projeId;
        private AppDbContext _dbContext;
        public AltImalatEkle(string birim, int projeId)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            _birim = birim;
            _projeId = projeId;
        }
        private void AltImalatEkle_Load(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GetAltImalatlar(_birim);
            cmbAltImalat.DataSource = bs; cmbAltImalat.Invalidate();
        }

        private List<string> GetAltImalatlar(string birim)
        {
            var tarimsalAltImalat = new List<string>() { "Su Alım Yapısı (Brit) (ad)", "Trapez Kanal (m)", "Dik Kanal (m)"
                                           , "Tarla Prizi (ad)", "Yol Geçidi (ad)", "Sel Geçidi (ad)", "PVC Boru (m)"
                                           , "PE Polietilen Boru (m)", "Mil Rögarı (ad)", "Su Alım Rögarı (Vanasız) (ad)",
                                              "Su Alım Rögarı (Vanalı) (ad)", "36 Ton Havuz", "72 Ton Havuz", "108 Ton Havuz", "144 Ton Havuz", "180 Ton Havuz"};

            var suAltImalat = new List<string>() { "İçmesuyu Yeni Tesis (m)", "Kanalizasyon Yeni Tesis (m)", "Drenaj",
                                                    "Biriktirme Deposu (adet)" , "İçmesuyu Tesis Geliştirme (m)", "30 m2 Depo Yapımı (adet)", "Kanalizasyon Tesis Geliştirme (m)",
                                                    "50 m3 Depo Yapımı (adet)", "Tecrübe Ekibi (gün)", "75 m3 Depo Yapımı", "100 m3 Depo Yapımı", "150 m3 Depo Yapımı", "200 m3 Depo Yapımı",
                                                    "300 m3 Depo Yapımı", "Terfi Binası (adet)" , "GES (kw)", "ENH (kw)", "Drenaj (m)", "Sondaj (adet)", "Arıtma Tesisi (adet)", "Parsel Hattı (m)",
                                                    "Kolektör Hattı (m)", "Şebek Hattı (m)", "250 Kişilik Foseptik (adet)", "500 Kişilik Foseptik (adet)", "1000 Kişilik Foseptik (adet)","1500 Kişilik Foseptik (adet)",
                                                    "Arıtma Tesisi (adet)", "Terfi Merkezi (adet)", "Depo Bakım Onarım"
                                          };

            if (birim == "Tarımsal Hizmetler")
            {
                return tarimsalAltImalat;
            }

            else if (birim == "Su ve Kanalizasyon Hizmetleri")
            {
                return suAltImalat;
            }

            else if (birim == "Admin")
            {
                suAltImalat.AddRange(tarimsalAltImalat);

                return suAltImalat;
            }

            else
            {
                return new List<string>();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbAltImalat.Text != string.Empty && txtFiyat.Text != string.Empty && txtMiktar.Text != string.Empty)
            {
                var proje = _dbContext.Projes.Where(p => p.ID == _projeId).FirstOrDefault();

                try
                {
                    _dbContext.ProjeAltImalats.Add(new Models.ProjeAltImalat
                    {
                         ImalatAdi = cmbAltImalat.Text,
                         Fiyat = Convert.ToDouble(txtFiyat.Text),
                         Miktar = Convert.ToInt32(txtMiktar.Text),
                         Proje = proje!,
                    });
                    _dbContext.SaveChanges();
                }
                catch (Exception ex) { MessageBox.Show($"Hata.\n\nHata mesajı: {ex.Message}\n\n"); }

                this.Close();
            }

            cmbAltImalat.Focus();
        }
    }
}
