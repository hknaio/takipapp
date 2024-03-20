using WinFormsApp1.Data;
using WinFormsApp1.Models;

namespace WinFormsApp1.Helpers
{
    public class YatirimProgramiDevir
    {
        private AppDbContext _dbContext;
        public YatirimProgramiDevir()
        {
            _dbContext = new AppDbContext();
        }

        public void ProgramDevret()
        {
            var uygulanmayanlar = _dbContext.YatirimProgramis.Where(y => y.YatirimDurumu == YatirimDurumu.Uygulanmadi);

            foreach (var program in uygulanmayanlar)
            {
                program.Yil += 1;
            }

            try
            {
                _dbContext.UpdateRange(uygulanmayanlar);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata.\n\nProgram devri esnasında hata çıktı. Detay : {ex.Message}\n\n");
            }
        }
    }
}
