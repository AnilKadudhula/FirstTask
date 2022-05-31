using Microsoft.EntityFrameworkCore;

namespace FirstTask.Data
{
    public class FirstTaskDBContext : DbContext
    {
        public FirstTaskDBContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Home = "Hi-Tech",
                    Open = "Status",
                    Completed = "Pending",
                    Pendding = "Pendding",
                    PeerReviews = "rating"

                },
                new Employee
                {
                    Id = 2,
                    Home = "Hi-Tech",
                    Open = "Status",
                    Completed = "Pending",
                    Pendding = "Pendding",
                    PeerReviews = "rating"

                },
                 new Employee
                 {
                     Id = 3,
                     Home = "Hi-Tech",
                     Open = "Status",
                     Completed = "Pending",
                     Pendding = "Pendding",
                     PeerReviews = "rating"

                 }

                );


        }
    }
}
