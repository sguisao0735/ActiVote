namespace ActiVote.Web.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entities;

    public class Repository : IRepository
    {
        private readonly DataContext context;

        public Repository(DataContext context)
        {
            this.context = context;
        }

        public IEnumerable<Event> GetEvents()
        {
            return this.context.Events.OrderBy(p => p.EventName);
        }

        public Event GetEvent(int id)
        {
            return this.context.Events.Find(id);
        }

        public void AddEvent(Event @event)

        {
            this.context.Events.Add(@event);

        }

        public void UpdateEvent(Event @event)

        {
            this.context.Events.Update(@event);
        }

        public void RemoveEvent(Event @event)

        {
            this.context.Events.Remove(@event);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await this.context.SaveChangesAsync() > 0;
        }

        public bool EventExists(int id)
        {
            return this.context.Events.Any(p => p.Id == id);
        }

        public IEnumerable<Candidate> GetCandidates()
        {
            return this.context.Candidates.OrderBy(p => p.Name);
        }

        public Candidate GetCandidate(int id)
        {
            return this.context.Candidates.Find(id);
        }

        public void AddCandidate(Candidate @Candidate)

        {
            this.context.Candidates.Add(@Candidate);

        }

        public void UpdateCandidate(Candidate @Candidate)

        {
            this.context.Candidates.Update(@Candidate);
        }

        public void RemoveCandidate(Candidate @Candidate)

        {
            this.context.Candidates.Remove(@Candidate);
        }

        public bool CandidateExists(int id)

        {
            return this.context.Candidates.Any(p => p.Id == id);
        }
    }

}
