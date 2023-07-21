using Microsoft.EntityFrameworkCore;

namespace TestApp.Data
{
    public class CompanyContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-24PO16E;Database=CompanyDB;Integrated Security=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var companies = new List<Company>
            {
                new Company { Id = 1, Address = "702 8th Street", City = "Atlanta", Name = "Super Mart of the West", State = "Georgia", Phone = "(800) 555-55-99" },
                new Company { Id = 2, Address = "702 8th Street", City = "Dallas", Name = "Electronic Deport", State = "Texas", Phone = "(900) 556-33-33" },
                new Company { Id = 3, Address = "702 8th Street", City = "Bentonville", Name = "ElectricMax", State = "Arkansas", Phone = "(763) 888-00-11" }
            };

            var employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Heart", BirthDate = DateTime.Now, Title = "Mr. ", Position = "CEO", CompanyId = companies[0].Id },
                new Employee { Id = 2, FirstName = "Olivia", LastName = "Peyton", BirthDate = DateTime.Now, Title = "Mrs. ", Position = "Developer", CompanyId = companies[0].Id },
                new Employee { Id = 3, FirstName = "Robert", LastName = "Reagan", BirthDate = DateTime.Now, Title = "Mr. ", Position = "Manager", CompanyId = companies[1].Id },
                new Employee { Id = 4, FirstName = "Cynthia", LastName = "Stanvick", BirthDate = DateTime.Now, Title = "Mrs. ", Position = "TeamLead", CompanyId = companies[1].Id },
                new Employee { Id = 5, FirstName = "Tim", LastName = "Cook", BirthDate = DateTime.Now, Title = "Mr. ", Position = "CEO", CompanyId = companies[2].Id },
                new Employee { Id = 6, FirstName = "Adam", LastName = "Smith", BirthDate = DateTime.Now, Title = "Mr. ", Position = "Developer", CompanyId = companies[2].Id },
            };

            var orders = new List<Order>
            {
                new Order{ Id = 1, OrderDate = DateTime.Now, StoreCity = "Las Vegas", CompanyId = companies[0].Id },
                new Order{ Id = 2, OrderDate = DateTime.Now, StoreCity = "Las Vegas", CompanyId = companies[0].Id },
                new Order{ Id = 3, OrderDate = DateTime.Now, StoreCity = "San Jose", CompanyId = companies[1].Id },
                new Order{ Id = 4, OrderDate = DateTime.Now, StoreCity = "San Jose", CompanyId = companies[1].Id },
                new Order{ Id = 5, OrderDate = DateTime.Now, StoreCity = "Seattle", CompanyId = companies[2].Id},
                new Order{ Id = 6, OrderDate = DateTime.Now, StoreCity = "Seattle", CompanyId = companies[2].Id },
            };

            var notes = new List<Note>
            {
                new Note { Id = 1, InvoiceNumber = 100, EmployeeId = employees[0].Id, CompanyId = companies[0].Id },
                new Note { Id = 2, InvoiceNumber = 101, EmployeeId = employees[1].Id, CompanyId = companies[0].Id },
                new Note { Id = 3, InvoiceNumber = 102, EmployeeId = employees[2].Id, CompanyId = companies[1].Id },
                new Note { Id = 4, InvoiceNumber = 103, EmployeeId = employees[3].Id, CompanyId = companies[1].Id },
                new Note { Id = 5, InvoiceNumber = 104, EmployeeId = employees[4].Id, CompanyId = companies[2].Id },
                new Note { Id = 6, InvoiceNumber = 105, EmployeeId = employees[5].Id, CompanyId = companies[2].Id },
            };

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Note)
                .WithOne(e => e.Employee)
                .HasForeignKey<Note>(k => k.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Company>()
                .HasData(companies);

            modelBuilder.Entity<Employee>()
                .HasData(employees);

            modelBuilder.Entity<Order>()
                .HasData(orders);

            modelBuilder.Entity<Note>()
                .HasData(notes);

            base.OnModelCreating(modelBuilder);
        }
    }
}
