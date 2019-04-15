namespace ActiVote.Web.Data
{
    using ActiVote.Web.Data.Entities;
    using Microsoft.EntityFrameworkCore;
    public class DataContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Vote> Votes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
