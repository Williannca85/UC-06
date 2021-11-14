using Microsoft.EntityFrameworkCore;


namespace Hotsite.Models
{
    public class DatabaseContext: DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=hotsite;Uid=root;");
        }

        public DbSet<Interesse> Interesses { get; set; }

    }
}