using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using WinFormsApp1.Data;
namespace WinFormsApp1
{
    public partial class YatirimUygulama : Form
    {
        private readonly int _id;
        private AppDbContext _dbContext;
        public YatirimUygulama(int id)
        {
            InitializeComponent();
            _id = id;
        }
        private void YatirimUygulama_Load(object sender, EventArgs e)
        {
            _dbContext = new AppDbContext();
            label2.Text = _dbContext.Projes.Where(p => p.ID == _id).Select(p => p.Adi).FirstOrDefault();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
