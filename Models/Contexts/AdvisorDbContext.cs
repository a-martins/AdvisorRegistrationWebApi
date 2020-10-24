using Microsoft.EntityFrameworkCore;

namespace AdvisorRegistrationWebApi.Models.Contexts
{
    public class AdvisorDbContext:DbContext
    {
        public AdvisorDbContext(DbContextOptions<AdvisorDbContext> options) : base(options)
        {
        }

        public DbSet<Advisor> Advisors { get; set; }
    }
}
