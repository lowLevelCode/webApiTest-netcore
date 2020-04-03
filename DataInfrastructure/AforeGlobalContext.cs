using Microsoft.EntityFrameworkCore;
using webApiTest.DataInfrastruture.Mapping;
using webApiTest.Domain.Posts;

namespace webApiTest.DataInfrastruture
{
    public class AforeGlobalContext : DbContext
    {
        public AforeGlobalContext (DbContextOptions<AforeGlobalContext> options): base(options)
        {
        }

        public DbSet<Post> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfiguration(new PostMap());
        }
    }
}