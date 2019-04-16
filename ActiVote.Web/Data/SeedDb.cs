namespace ActiVote.Web.Data
{
    using ActiVote.Web.Data.Entities;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    public class SeedDb
    {
        private readonly DataContext context;
        private readonly Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Events.Any())
            {
                this.AddEvent("First Event");
                this.AddEvent("Second Event");
                this.AddEvent("Third Event");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddEvent(string name)
        {
            this.context.Events.Add(new Event
            {
                EventName = name,
                Description = "Prueba description",
                
            });
        }
    }
}
