using Microsoft.EntityFrameworkCore;


namespace WinFormsApp5.Data
{
    internal class DataContext:DbContext
    {
        public DbSet<Clients> Clients { get; set; }
        public DbSet<garages> garages { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
