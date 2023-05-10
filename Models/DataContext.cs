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
        public DbSet<Application_TB> application_TBs { get; set; }
        public DbSet<BPO_TB> BPO_TBs { get; set; }
        public DbSet<InterfaceApplication_TB> InterfaceApplication_TBs { get; set; }
        public DbSet<MALISIB_TB> MALISIB_TBs { get; set; }
        public DbSet<OCIO_TB> OCIO_TBs { get; set; }
        public DbSet<Platform_TB> Platform_TBs { get; set; }
        public DbSet<Server_TB> Server_TBs { get; set; }
        public DbSet<Status_TB> Status_TBs { get; set; }
        public DbSet<SubPlatform_TB> SubPlatform_TBs { get; set; }
        public DbSet<SupportTeam_TB> SupportTeam_TBs { get; set; }
        public DbSet<Type_TB> Type_TBs { get; set; }
        public DbSet<Vendor_TB> Vendor_TBs { get; set; }
    }

}