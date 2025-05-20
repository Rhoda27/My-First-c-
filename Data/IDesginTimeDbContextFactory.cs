using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace api.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=CODEDB;TrustServerCertificate=true;User Id=sa;Password=YourStrong@Passw0rd;Encrypt=True;");
            
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
