using Microsoft.EntityFrameworkCore;
using _Istudnet.Models;

namespace _Istudnet.Data
{
    public class studentContext : DbContext
    {
        public studentContext(DbContextOptions<studentContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}
