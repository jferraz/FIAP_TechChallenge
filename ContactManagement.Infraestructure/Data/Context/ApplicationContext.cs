using ContactManagement.Domain.Entities;
using ContactManagement.Infraestructure.Data.Map;
using Microsoft.EntityFrameworkCore;
using UserManagement.Infrastructure.Data.EntityMapping;

namespace ContactManagement.Infraestructure.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        #region UserContact 
        
        public DbSet<UserContact> Contacts { get; set; }
        public DbSet<PhoneDDD> DDD { get; set; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
                        
            modelBuilder.ApplyConfiguration(new UserContactMap());
            modelBuilder.ApplyConfiguration(new PhoneDDDMap());
        }
    }
}
