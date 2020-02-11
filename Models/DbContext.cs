using Microsoft.EntityFrameworkCore;
namespace Job_Tracker.Models{
    public class JTContext: DbContext{
        public JTContext(DbContextOptions options) : base(options){}

        public DbSet <Job> Jobs {get;set;}

        public DbSet <Company> Companies {get;set;}
    }
}