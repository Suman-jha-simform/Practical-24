using Microsoft.EntityFrameworkCore;

namespace Practical_24.Model
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() { }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = @"Data Source=sf-cpu-338\SQLEXPRESS;Initial Catalog=Practical24;Integrated Security=True;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
