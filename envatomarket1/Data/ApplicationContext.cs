using envatomarket1.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace envatomarket1.Data
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
          public DbSet<Blog> Blogs { get; set; }
         
    }
}
