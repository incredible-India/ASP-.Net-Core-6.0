using Microsoft.EntityFrameworkCore;

namespace WebApplication20.Models
{
    public class empc:DbContext
    {

        public empc(DbContextOptions<empc> options) : base(options)
        {

        }
        
        public DbSet<Emp> Employees { get; set; }
    }
}
