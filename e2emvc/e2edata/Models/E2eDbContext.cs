using System.Data.Entity;

namespace e2edata.Models
{
    public class E2eDbContext : DbContext
    {
        public E2eDbContext()
        {
            Database.SetInitializer<E2eDbContext>(new DropCreateDatabaseIfModelChanges<E2eDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Products> Product { get; set; }

    }
}