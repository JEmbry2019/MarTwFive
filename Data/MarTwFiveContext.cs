using MarTwFive.Models;
using Microsoft.EntityFrameworkCore;

namespace MarTwFive.Data
{
    //Creates a new database context named StudentInformationContext
    public class MarTwFiveContext : DbContext
    {
        public MarTwFiveContext(DbContextOptions<MarTwFiveContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Game> Activities { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Camper> Campers { get; set; }
    }
}