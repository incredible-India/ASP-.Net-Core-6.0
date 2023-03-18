using Microsoft.EntityFrameworkCore;

namespace CodeFirstDefaultController.Models
{
    public class studentContext :DbContext
    {

        public studentContext(DbContextOptions<studentContext> options ):base(options)
        {
            
        }

        public DbSet<student> studentsTable { get; set; }
    }
}
