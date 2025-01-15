using WinFormsApp1.Data;
using CsvHelper;
using CsvHelper.Excel;
using WinFormsApp1.Models;
using YatirimTakip;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private AppDbContext _dbContext;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            //_dbContext.Database.EnsureCreated();
            //IlceKoyMezraKayit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var user = _dbContext.Users.Where(s => s.UserName == txtUsername.Text && s.Password == txtPassword.Text).FirstOrDefault();

            if (txtUsername.Text != string.Empty && txtPassword.Text != string.Empty)
            {
                if (user is not null)
                {
                    //using (AnaEkran main = new AnaEkran())
                    //{
                    //    main.ShowDialog();

                    //}
                    AnaEkran anaEkran = new AnaEkran(user);
                    this.Hide();
                    anaEkran.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }

            txtUsername.Focus();
        }

        private void IlceKoyMezraKayit()
        {
            using var reader = new CsvReader(
                new ExcelParser("C:\\Users\\Hakan Aygüzer\\Documents\\imalat.xlsx"));

            reader.Read();
            while (reader.Read())
            {
                var tarih = reader.GetField(0);

                var ilce = reader.GetField(1);
                var ilcep = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(ilce.ToLower());

                var koy = reader.GetField(2);
                var koyp = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(koy.ToLower());
                var mezraKontrol = _dbContext.Mezras.Where(m => m.Adi == koyp).Any();

                int koyid = 0;
                if (mezraKontrol)
                {
                    koyid = _dbContext.Mezras.Where(m => m.Adi == koyp).Select(m => m.Koy.ID).FirstOrDefault();
                }

                var imalat = reader.GetField(3);
                var imalatp = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(imalat.ToLower());
                var imalatd = _dbContext.Imalats.Where(i => i.Isim == imalatp).FirstOrDefault();

                var miktar = reader.GetField(4);

                double v;
                if (double.TryParse(miktar, out v))
                {
                    var purEmanet = new PurEmanet
                    {
                        Tarih = Convert.ToDateTime(tarih),
                        IlceId = _dbContext.Ilces.Where(i => i.Adi == ilcep).Select(i => i.ID).FirstOrDefault(),
                        KoyId = mezraKontrol ? koyid : _dbContext.Koys.Where(i => i.Adi == koyp).Select(i => i.ID).FirstOrDefault(),
                        ImalatId = imalatd!.ID,
                        Miktar = v,
                        Tutar = imalatd!.BirimFiyat * v,
                    };

                    if (mezraKontrol)
                    {
                        var purEmanetMezra = new PurEmanetMezra
                        {
                            Mezra = _dbContext.Mezras.Where(i => i.Adi == koyp).FirstOrDefault(),
                            PurEmanet = purEmanet,
                        };


                        _dbContext.PurEmanetMezras.Add(purEmanetMezra);
                    }

                    _dbContext.PurEmanets.Add(purEmanet);
                    _dbContext.SaveChanges();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SifreDegistir degistir = new())
            {
                degistir.ShowDialog();
                this.OnLoad(e);
            }
        }
    }
}
