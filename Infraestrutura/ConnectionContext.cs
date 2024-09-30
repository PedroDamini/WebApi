using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Infraestrutura
{
    public class ConnectionContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(
                "Sever=localhost;" +
                "Port=5432;Database=employee_sample;" +
                "User Id=postgres;" +
                "Password=admin;");

    }
}
