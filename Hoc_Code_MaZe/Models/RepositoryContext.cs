using Microsoft.EntityFrameworkCore;

namespace Hoc_Code_MaZe.Models
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options)
           : base(options)
        {
        }
        public DbSet<Owner>? Owners { get; set; }
        public DbSet<Account>? Accounts { get; set; }
    }
}
