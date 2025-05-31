using Microsoft.EntityFrameworkCore;
using To_Do.Models;

namespace To_Do.Context
{
    public class ApplicatiDbContext: DbContext
    {
        public ApplicatiDbContext(DbContextOptions<ApplicatiDbContext> options) : base(options)
        {
        }
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
