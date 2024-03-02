using WinFormsApp1.Data;

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
            _dbContext.Database.EnsureCreated();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            using (AnaEkran main = new AnaEkran())
            {
                main.ShowDialog();
            }
        }
    }
}
