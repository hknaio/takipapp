
using WinFormsApp1.Data;

namespace WinFormsApp1
{
    public partial class UygulamaGuncelle : Form
    {
        private AppDbContext _dbContext;
        private int _selected;
        public UygulamaGuncelle(double guncelUygulama, int selected)
        {
            InitializeComponent();
            _dbContext = new AppDbContext();
            label2.Text = guncelUygulama.ToString();
            _selected = selected;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selected = _dbContext.YatirimProgramis.Where(s => s.ID == _selected).FirstOrDefault();

            if (selected != null)
            {
                selected.Uygulama = Convert.ToDouble(txtYeniMiktar.Text);

                try
                {
                    _dbContext.Update(selected);
                    _dbContext.SaveChanges();
                }
                catch (Exception)
                {

                }

                this.Close();
            }

            txtYeniMiktar.Focus();
        }

        private void UygulamaGuncelle_FormClosing(object sender, FormClosingEventArgs e)
        {
            base.OnClosing(e);

            _dbContext?.Dispose();
            _dbContext = null;
        }
    }
}
