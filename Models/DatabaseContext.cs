using BusinessEntity;
using Microsoft.EntityFrameworkCore;

namespace SmsPanel.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options) { }

        public DbSet<Store> Stores { get; set; }
        public DbSet<StoreListKala> StoreListKala { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=185.252.29.60,2022;Initial Catalog=crmirani_dbcrm;User ID=crmirani_arman;Password=Arman@papi@1378@; Encrypt=false; TrustServerCertificate=True");
                //optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=HazelnutDB;Integrated Security=true; Encrypt=false; TrustServerCertificate=True");
            }
        }
    }
}
