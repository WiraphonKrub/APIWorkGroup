using Microsoft.EntityFrameworkCore;
using APIWorkGroup.Models;
namespace APIWorkGroup.Models
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiDatabase");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Admin_TB> admin_TBs { get; set; }
        public DbSet<Status_TB> status_TBs { get; set; }
        public DbSet<Type_TB> type_TBs { get; set; }
    }

}