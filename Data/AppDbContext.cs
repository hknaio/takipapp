using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1.Data
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {

        }
        public DbSet<Imalat> Imalats { get; set; }
        public DbSet<YatirimProgrami> YatirimProgramis { get; set; }
        public DbSet<SpiralBoru> SpiralBorus { get; set; }  
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<Koy> Koys { get; set; }
        public DbSet<Mezra> Mezras { get; set; }
        public DbSet<PurEmanet> PurEmanets { get; set; }
        public DbSet<Proje> Projes { get; set; }
        public DbSet<Hakedis> Hakedis { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Yatirim");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Imalat>().ToTable(nameof(Imalat));
            modelBuilder.Entity<YatirimProgrami>().ToTable(nameof(YatirimProgrami));
            modelBuilder.Entity<SpiralBoru>().ToTable(nameof(SpiralBoru));  
            modelBuilder.Entity<Ilce>().ToTable(nameof(Ilce));
            modelBuilder.Entity<Koy>().ToTable(nameof(Koy));
            modelBuilder.Entity<Mezra>().ToTable(nameof(Mezra));
            modelBuilder.Entity<PurEmanet>().ToTable(nameof(PurEmanet));
            modelBuilder.Entity<Proje>().ToTable(nameof(Proje));
            modelBuilder.Entity<Hakedis>().ToTable(nameof(Hakedis));
        }
    }
}
