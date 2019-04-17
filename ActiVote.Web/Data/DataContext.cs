﻿namespace ActiVote.Web.Data
{
    using ActiVote.Web.Data.Entities;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    public class DataContext : IdentityDbContext<User>
    {
        public DbSet<Event> Events { get; set; }

        public DbSet<Candidate> Candidates { get; set; }

        public DbSet<Vote> Votes { get; set; }

        public DbSet<Country> Countries  { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

    }
}
